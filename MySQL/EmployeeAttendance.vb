Imports MySQL.Data.MySqlClient

Public Class EmployeeAttendance

    Private Sub EmployeeAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values for combo boxes
        cmbPresent.SelectedIndex = 1 ' This Month
        cmbLate.SelectedIndex = 1    ' This Month
        cmbAbsent.SelectedIndex = 1  ' This Month

        ' Load weekly attendance
        LoadWeeklyAttendance()

        ' Load initial summary data
        LoadAttendanceData()
    End Sub

    Private Sub LoadAttendanceData()
        Dim employeeId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()

        ' Get present count based on combo box selection
        lblPresent.Text = GetAttendanceCount(employeeId, "Present", GetPeriodDates(cmbPresent.SelectedItem.ToString()))

        ' Get late count based on combo box selection
        lblLate.Text = GetAttendanceCount(employeeId, "Late", GetPeriodDates(cmbLate.SelectedItem.ToString()))

        ' Get absent count based on combo box selection
        lblAbsent.Text = GetAttendanceCount(employeeId, "Absent", GetPeriodDates(cmbAbsent.SelectedItem.ToString()))
    End Sub

    Private Function GetPeriodDates(period As String) As (StartDate As Date, EndDate As Date)
        Dim today As Date = Date.Today
        Dim startDate, endDate As Date

        Select Case period
            Case "This Week"
                ' Start from Monday of current week
                Dim daysFromMonday As Integer = today.DayOfWeek - DayOfWeek.Monday
                If daysFromMonday < 0 Then daysFromMonday += 7
                startDate = today.AddDays(-daysFromMonday)
                endDate = today

            Case "This Month"
                ' Start from 1st of current month to today or end of month
                startDate = New Date(today.Year, today.Month, 1)
                endDate = today

            Case Else
                ' Default to current month
                startDate = New Date(today.Year, today.Month, 1)
                endDate = today
        End Select

        Return (startDate, endDate)
    End Function

    Private Function GetAttendanceCount(employeeId As String, attendanceType As String, periodDates As (StartDate As Date, EndDate As Date)) As String
        Dim count As Integer = 0

        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = ""

                Select Case attendanceType
                    Case "Present"
                        query = "SELECT COUNT(*) FROM attendance 
                            WHERE employeeid = @empid 
                            AND date BETWEEN @startDate AND @endDate
                            AND timeout IS NOT NULL"

                    Case "Late"
                        query = "SELECT COUNT(*) FROM attendance 
                            WHERE employeeid = @empid 
                            AND date BETWEEN @startDate AND @endDate
                            AND TIME(timein) > '08:15:00'"

                    Case "Absent"
                        ' For absent, we need to calculate working days minus present days
                        Dim totalWorkingDays As Integer = GetTotalWorkingDays(periodDates.StartDate, periodDates.EndDate)
                        Dim presentDays As Integer = GetAttendanceCount(employeeId, "Present", periodDates)
                        count = Math.Max(0, totalWorkingDays - presentDays)
                        Return count.ToString()

                End Select

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empid", employeeId)
                    cmd.Parameters.AddWithValue("@startDate", periodDates.StartDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@endDate", periodDates.EndDate.ToString("yyyy-MM-dd"))

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        count = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading {attendanceType.ToLower()} count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            count = 0
        End Try

        Return count.ToString()
    End Function

    Private Function GetTotalWorkingDays(startDate As Date, endDate As Date) As Integer
        Dim totalDays As Integer = 0
        Dim currentDate As Date = startDate

        While currentDate <= endDate
            ' Count only weekdays (Monday to Saturday)
            If currentDate.DayOfWeek <> DayOfWeek.Sunday Then
                totalDays += 1
            End If
            currentDate = currentDate.AddDays(1)
        End While

        Return totalDays
    End Function

    Private Sub LoadWeeklyAttendance()
        Dim employeeId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()

        pnlWeeklyAttendance.Controls.Clear()
        pnlWeeklyAttendance.SuspendLayout() ' Prevent flickering

        Dim attendanceDays As List(Of Date) = GetLast7WorkingDays()

        For Each day As Date In attendanceDays
            Dim attendanceData As AttendanceData = GetAttendanceDataForDate(employeeId, day)
            Dim item As New AttendanceItemControl() With {
            .Width = pnlWeeklyAttendance.Width - 30 ' Account for scrollbar and padding
        }
            item.SetAttendanceData(day, attendanceData)
            pnlWeeklyAttendance.Controls.Add(item)
        Next

        pnlWeeklyAttendance.ResumeLayout()
    End Sub

    Private Function CreateAttendanceItem(employeeId As String, attendanceDate As Date) As AttendanceItemControl
        Dim item As New AttendanceItemControl()
        item.Width = pnlWeeklyAttendance.Width - 25 ' Account for scrollbar

        ' Get attendance data for this date
        Dim attendanceData As AttendanceData = GetAttendanceDataForDate(employeeId, attendanceDate)

        ' Set the data
        item.SetAttendanceData(attendanceDate, attendanceData)

        Return item
    End Function

    Private Function GetLast7WorkingDays() As List(Of Date)
        Dim workingDays As New List(Of Date)()
        Dim currentDate As Date = Date.Today
        Dim daysAdded As Integer = 0

        ' Go backwards until we have 7 working days
        While daysAdded < 7
            ' Skip Sundays
            If currentDate.DayOfWeek <> DayOfWeek.Sunday Then
                workingDays.Add(currentDate)
                daysAdded += 1
            End If
            currentDate = currentDate.AddDays(-1)
        End While

        ' Return in descending order (most recent first)
        Return workingDays
    End Function

    Private Function GetAttendanceDataForDate(employeeId As String, attendanceDate As Date) As AttendanceData
        Dim data As New AttendanceData()

        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                SELECT timein, timeout, totalhours 
                FROM attendance 
                WHERE employeeid = @empid 
                AND date = @attendanceDate;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empid", employeeId)
                    cmd.Parameters.AddWithValue("@attendanceDate", attendanceDate.ToString("yyyy-MM-dd"))

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Employee has attendance record for this date
                            If Not IsDBNull(reader("timein")) AndAlso Not IsDBNull(reader("timeout")) Then
                                Dim timeIn As DateTime = Convert.ToDateTime(reader("timein"))
                                Dim timeOut As DateTime = Convert.ToDateTime(reader("timeout"))
                                Dim totalHours As Decimal = If(IsDBNull(reader("totalhours")),
                                                         CDec((timeOut - timeIn).TotalHours),
                                                         Convert.ToDecimal(reader("totalhours")))

                                data.TimeIn = timeIn.ToString("hh:mm tt")
                                data.TimeOut = timeOut.ToString("hh:mm tt")
                                data.TotalHours = totalHours
                                data.OTHours = Math.Max(0, totalHours - 8)

                                ' Determine if late (arrived after 8:15 AM)
                                If timeIn.TimeOfDay > New TimeSpan(8, 15, 0) Then
                                    data.Status = "Late"
                                Else
                                    data.Status = "Present"
                                End If
                            Else
                                ' Has timein but no timeout
                                data.Status = "Present"
                                data.TimeIn = Convert.ToDateTime(reader("timein")).ToString("hh:mm tt")
                                data.TimeOut = "Not checked out"
                            End If
                        Else
                            ' No attendance record - check if it's a weekend
                            If attendanceDate.DayOfWeek = DayOfWeek.Sunday Then
                                data.Status = "Holiday"
                                data.IsHoliday = True
                            Else
                                data.Status = "Absent"
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            data.Status = "Error"
            data.TimeIn = "N/A"
            data.TimeOut = "N/A"
        End Try

        Return data
    End Function

    Private Sub ConfigureWeeklyAttendancePanel()
        With pnlWeeklyAttendance
            .AutoScroll = True
            .FlowDirection = FlowDirection.TopDown
            .WrapContents = False
            .BackColor = Color.FromArgb(250, 250, 250) ' Light gray background
            .Padding = New Padding(10) ' Add padding around the edges
            .BorderStyle = BorderStyle.FixedSingle ' Optional: add border
        End With
    End Sub

    Private Sub cmbPresent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresent.SelectedIndexChanged
        If cmbPresent.SelectedItem IsNot Nothing Then
            Dim employeeId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            lblPresent.Text = GetAttendanceCount(employeeId, "Present", GetPeriodDates(cmbPresent.SelectedItem.ToString()))
        End If
    End Sub

    Private Sub cmbLate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLate.SelectedIndexChanged
        If cmbLate.SelectedItem IsNot Nothing Then
            Dim employeeId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            lblLate.Text = GetAttendanceCount(employeeId, "Late", GetPeriodDates(cmbLate.SelectedItem.ToString()))
        End If
    End Sub

    Private Sub cmbAbsent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAbsent.SelectedIndexChanged
        If cmbAbsent.SelectedItem IsNot Nothing Then
            Dim employeeId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            lblAbsent.Text = GetAttendanceCount(employeeId, "Absent", GetPeriodDates(cmbAbsent.SelectedItem.ToString()))
        End If
    End Sub

    ' --- Navigation Buttons ---
    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payslipForm As New EmployeePayslip()
        payslipForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        payslipForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        payslipForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        payslipForm.StartPosition = FormStartPosition.Manual
        payslipForm.Location = Me.Location
        payslipForm.Show()
        Me.Hide()
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empDashboardForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empDashboardForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Dim profileForm As New EmployeeProfile()
        profileForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        profileForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        profileForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        profileForm.StartPosition = FormStartPosition.Manual
        profileForm.Location = Me.Location
        profileForm.Show()
        Me.Hide()
    End Sub

    Private Sub checkInbtn_Click_1(sender As Object, e As EventArgs) Handles checkInbtn.Click
        Dim empCheckInForm As New EmployeeCheckIn()
        empCheckInForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empCheckInForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empCheckInForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empCheckInForm.StartPosition = FormStartPosition.Manual
        empCheckInForm.Location = Me.Location
        empCheckInForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub

End Class