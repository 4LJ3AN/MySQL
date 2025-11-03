Imports System.Windows.Forms.DataVisualization.Charting
Imports MySQL.Data.MySqlClient
Imports System.Diagnostics

Public Class EmployeeDashboard

    Private Sub EmployeeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateNetPayLabel()
        UpdateDaysLabel()
        UpdateHoursLabels()
        LoadWeeklyHoursChart()
    End Sub

    Private Sub UpdateNetPayLabel()
        Dim connLocal As MySqlConnection = Nothing
        Try
            connLocal = (New DatabaseConnection).GetConnection()
            connLocal.Open()

            ' --- Step 1: Get current employee ID ---
            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            'Debugging info
            'MessageBox.Show("Querying for Employee ID = '" & empId & "'")

            ' --- Step 2: Determine start of pay period ---
            Dim today As DateTime = DateTime.Now
            Dim startOfPeriod As DateTime

            If today.Day >= 15 Then
                startOfPeriod = New DateTime(today.Year, today.Month, 15)
            Else
                Dim prevMonth As DateTime = today.AddMonths(-1)
                startOfPeriod = New DateTime(prevMonth.Year, prevMonth.Month, 15)
            End If

            ' --- Step 3: Query total hours and hourly rate ---
            Dim query As String = "
            SELECT 
                IFNULL(SUM(a.totalhours), 0) AS total_hours, 
                IFNULL(e.hourlyrate, 0) AS hourlyrate
            FROM attendance a
            JOIN employees e ON a.employeeid = e.id
            WHERE a.employeeid = @empid
              AND a.date BETWEEN @startDate AND @today;
        "
            'Debugging info
            'MessageBox.Show("Start Date: " & startOfPeriod.ToString("yyyy-MM-dd") &
            '    vbCrLf & "Today: " & today.ToString("yyyy-MM-dd"))

            Using cmd As New MySqlCommand(query, connLocal)
                cmd.Parameters.AddWithValue("@empid", empId)
                cmd.Parameters.AddWithValue("@startDate", startOfPeriod.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@today", today.ToString("yyyy-MM-dd"))

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        'Debugging info
                        'MessageBox.Show("total_hours=" & reader("total_hours").ToString() &
                        '                ", hourlyrate=" & reader("hourlyrate").ToString())

                        Dim totalHours As Double = If(IsDBNull(reader("total_hours")), 0, Convert.ToDouble(reader("total_hours")))
                        Dim hourlyRate As Double = If(IsDBNull(reader("hourlyrate")), 0, Convert.ToDouble(reader("hourlyrate")))
                        Dim netPay As Double = totalHours * hourlyRate

                        lblNetPay.Text = "₱" & netPay.ToString("N2")
                    Else
                        lblNetPay.Text = "₱0.00"
                    End If
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error calculating net pay: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
    End Sub

    Private Sub UpdateDaysLabel()
        Dim connLocal As MySqlConnection = Nothing
        Try
            connLocal = (New DatabaseConnection).GetConnection()
            connLocal.Open()

            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            Dim today As DateTime = DateTime.Now
            Dim month As Integer = today.Month
            Dim year As Integer = today.Year

            ' --- Step 1: Count working days in the current month (excluding Sundays) ---
            Dim totalWorkingDays As Integer = 0
            Dim firstDay As New DateTime(year, month, 1)
            Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)

            For day As Integer = 0 To daysInMonth - 1
                Dim currentDay As DateTime = firstDay.AddDays(day)
                If currentDay.DayOfWeek <> DayOfWeek.Sunday Then
                    totalWorkingDays += 1
                End If
            Next

            ' --- Step 2: Count attendance records for this employee this month ---SS
            Dim query As String = "
            SELECT COUNT(DISTINCT date) AS days_present
            FROM attendance
            WHERE employeeid = @empid
              AND MONTH(date) = @month
              AND YEAR(date) = @year
        "

            Dim daysPresent As Integer = 0
            Using cmd As New MySqlCommand(query, connLocal)
                cmd.Parameters.AddWithValue("@empid", empId)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    daysPresent = Convert.ToInt32(result)
                End If
            End Using

            ' --- Step 3: Update label text ---
            lblDays.Text = $"{daysPresent} / {totalWorkingDays}"

        Catch ex As Exception
            MessageBox.Show("Error updating days worked: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
    End Sub

    Private Sub UpdateHoursLabels()
        Dim connLocal As MySqlConnection = Nothing
        Try
            connLocal = (New DatabaseConnection).GetConnection()
            connLocal.Open()

            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            Dim today As DateTime = DateTime.Now
            Dim month As Integer = today.Month
            Dim year As Integer = today.Year

            ' --- Step 1: Fetch all attendance entries with timein and timeout ---
            Dim query As String = "
            SELECT date, timein, timeout
            FROM attendance
            WHERE employeeid = @empid
              AND MONTH(date) = @month
              AND YEAR(date) = @year
              AND timeout IS NOT NULL
        "

            Dim totalHours As Double = 0
            Dim totalOT As Double = 0

            Using cmd As New MySqlCommand(query, connLocal)
                cmd.Parameters.AddWithValue("@empid", empId)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim attDate As DateTime = Convert.ToDateTime(reader("date"))
                        Dim checkIn As DateTime = Convert.ToDateTime(reader("timein"))
                        Dim checkOut As DateTime = Convert.ToDateTime(reader("timeout"))

                        ' Skip Sundays just in case
                        If attDate.DayOfWeek = DayOfWeek.Sunday Then Continue While

                        ' Total hours worked that day
                        Dim workedHours As Double = (checkOut - checkIn).TotalHours

                        ' Calculate overtime (hours after 5 PM)
                        Dim otStart As DateTime = attDate.AddHours(17) ' 5:00 PM same day
                        Dim otHours As Double = 0
                        If checkOut > otStart Then
                            otHours = (checkOut - otStart).TotalHours
                        End If

                        ' Accumulate
                        totalHours += workedHours
                        totalOT += otHours
                    End While
                End Using
            End Using

            ' --- Step 2: Update the labels ---
            lblHoursWorked.Text = Math.Round(totalHours, 2) & " hrs"
            lblOTHours.Text = Math.Round(totalOT, 2) & " hrs"

        Catch ex As Exception
            MessageBox.Show("Error calculating hours: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
    End Sub

    Private Sub LoadWeeklyHoursChart()
        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
                Dim today As DateTime = DateTime.Now

                ' Compute Monday of current week
                Dim startOfWeek As DateTime = today.AddDays(-(CInt(today.DayOfWeek) - 1))
                If startOfWeek > today Then startOfWeek = startOfWeek.AddDays(-7)
                Dim endOfWeek As DateTime = startOfWeek.AddDays(6)

                Debug.WriteLine($"[DEBUG] Today: {today:yyyy-MM-dd}")
                Debug.WriteLine($"[DEBUG] StartOfWeek: {startOfWeek:yyyy-MM-dd}")
                Debug.WriteLine($"[DEBUG] EndOfWeek: {endOfWeek:yyyy-MM-dd}")

                ' Initialize working days
                Dim hoursWorked As New Dictionary(Of String, Double) From {
                {"Mon", 0}, {"Tue", 0}, {"Wed", 0}, {"Thu", 0}, {"Fri", 0}, {"Sat", 0}
            }

                Dim query As String = "
                SELECT DATE(date) AS work_date, totalhours
                FROM attendance
                WHERE employeeid = @empid
                  AND DATE(date) BETWEEN DATE(@startOfWeek) AND DATE(@endOfWeek)
                  AND DAYOFWEEK(date) <> 1;
            "


                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empId
                    cmd.Parameters.Add("@startOfWeek", MySqlDbType.Date).Value = startOfWeek.Date
                    cmd.Parameters.Add("@endOfWeek", MySqlDbType.Date).Value = endOfWeek.Date

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Debug.WriteLine("[DEBUG] Query executed successfully. Reading rows...")

                        While reader.Read()
                            If Not IsDBNull(reader("work_date")) AndAlso Not IsDBNull(reader("totalhours")) Then
                                Dim workDate As DateTime = Convert.ToDateTime(reader("work_date"))
                                ' Ensure correct decimal precision — no Convert.ToDouble()
                                Dim totalHours As Decimal = reader.GetDecimal(reader.GetOrdinal("totalhours"))
                                Dim dayName As String = workDate.ToString("ddd")

                                Debug.WriteLine($"[DEBUG] Found record: {workDate:yyyy-MM-dd} ({dayName}) = {totalHours} hrs")

                                If hoursWorked.ContainsKey(dayName) Then
                                    hoursWorked(dayName) = Convert.ToDouble(totalHours)
                                End If
                            Else
                                Debug.WriteLine("[DEBUG] Skipping row with NULL values.")
                            End If
                        End While
                    End Using
                End Using

                ' Debug output
                Debug.WriteLine("[DEBUG] Final hoursWorked dictionary:")
                For Each kvp In hoursWorked
                    Debug.WriteLine($"    {kvp.Key} → {kvp.Value} hrs")
                Next

                ' Apply to custom chart
                WeeklyHoursChart1.SetHoursData(hoursWorked)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading weekly hours chart: " & ex.Message)
            Debug.WriteLine($"[ERROR] {ex}")
        End Try
    End Sub




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

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        attendanceForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        attendanceForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
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