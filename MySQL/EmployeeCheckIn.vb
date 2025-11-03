Imports System.Net
Imports MySQL.Data.MySqlClient

Public Class EmployeeCheckIn
    Private timer As Timer
    Private checkInTime As DateTime?
    Private checkOutTime As DateTime?
    Private currentStatus As String = "Not Checked In"

    Dim db As New DatabaseConnection()
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub EmployeeCheckIn_FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTimer()
        SetupUI()
        UpdateCheckButtons()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Try
            conn = db.GetConnection()
            conn.Open()

            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Prevent duplicate check-in for same day
            Dim checkQuery As String = "SELECT * FROM attendance WHERE employeeid=@empid AND date=@date LIMIT 1"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@empid", empId)
                checkCmd.Parameters.AddWithValue("@date", currentDate)

                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("You already checked in today.")
                        reader.Close()
                        Exit Sub
                    End If
                End Using
            End Using

            ' Insert check-in (leave timeout NULL)
            Dim insertQuery As String = "INSERT INTO attendance (employeeid, date, timein) VALUES (@empid, @date, @timein)"
            Using insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@empid", empId)
                insertCmd.Parameters.AddWithValue("@date", currentDate)
                ' Pass the datetime string or a DateTime object; connector will handle it
                insertCmd.Parameters.AddWithValue("@timein", DateTime.Now)
                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Check-in recorded successfully!")
            UpdateCheckButtons()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim connLocal As MySqlConnection = Nothing
        Try
            connLocal = (New DatabaseConnection).GetConnection()
            connLocal.Open()

            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim nowDt As DateTime = DateTime.Now ' full DateTime

            ' --- Step 1: Verify if employee checked in but not yet checked out ---
            Dim checkQuery As String = "SELECT attendanceid, timein FROM attendance WHERE employeeid=@empid AND date=@date AND timeout IS NULL LIMIT 1"
            Dim attendanceId As Integer = -1
            Dim timeIn As DateTime? = Nothing

            Using checkCmd As New MySqlCommand(checkQuery, connLocal)
                checkCmd.Parameters.AddWithValue("@empid", empId)
                checkCmd.Parameters.AddWithValue("@date", currentDate)

                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                    If reader.Read() Then
                        attendanceId = Convert.ToInt32(reader("attendanceid"))
                        If Not IsDBNull(reader("timein")) Then
                            timeIn = Convert.ToDateTime(reader("timein"))
                        End If
                    End If
                End Using
            End Using

            If attendanceId = -1 OrElse timeIn Is Nothing Then
                MessageBox.Show("You have not checked in today or have already checked out.", "Check-Out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' --- Step 2: Compute total hours worked (handles overnight shifts too) ---
            Dim totalHours As Double
            If nowDt < timeIn.Value Then
                ' handles case where check-out is after midnight
                totalHours = (nowDt.AddDays(1) - timeIn.Value).TotalHours
            Else
                totalHours = (nowDt - timeIn.Value).TotalHours
            End If
            totalHours = Math.Round(totalHours, 2)

            ' --- Step 3: Update timeout and totalhours ---
            Dim updateQuery As String = "
            UPDATE attendance
            SET timeout=@timeout, totalhours=@totalhours
            WHERE attendanceid=@attid
        "
            Using updateCmd As New MySqlCommand(updateQuery, connLocal)
                updateCmd.Parameters.AddWithValue("@timeout", nowDt)
                updateCmd.Parameters.AddWithValue("@totalhours", totalHours)
                updateCmd.Parameters.AddWithValue("@attid", attendanceId)
                updateCmd.ExecuteNonQuery()
            End Using

            ' --- Step 4: Notify user and refresh UI ---
            MessageBox.Show("Check-out recorded successfully at " & nowDt.ToString("hh:mm:ss tt") &
                        vbCrLf & "Hours worked today: " & totalHours.ToString("N2") & " hrs",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateCheckButtons()

        Catch ex As Exception
            MessageBox.Show("Error during check-out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
    End Sub

    Private Sub UpdateCheckButtons()
        Dim connLocal As MySqlConnection = Nothing
        Try
            connLocal = (New DatabaseConnection).GetConnection()
            connLocal.Open()

            Dim empId As String = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT timein, timeout FROM attendance WHERE employeeid=@empid AND date=@date LIMIT 1"
            Using cmdLocal As New MySqlCommand(query, connLocal)
                cmdLocal.Parameters.AddWithValue("@empid", empId)
                cmdLocal.Parameters.AddWithValue("@date", currentDate)

                Using reader As MySqlDataReader = cmdLocal.ExecuteReader()
                    If reader.Read() Then
                        ' Safely handle NULL values
                        Dim timeInValue As Object = reader("timein")
                        Dim timeOutValue As Object = reader("timeout")

                        Dim hasTimeIn As Boolean = Not IsDBNull(timeInValue)
                        Dim hasTimeOut As Boolean = Not IsDBNull(timeOutValue)

                        Dim timeIn As DateTime? = Nothing
                        Dim timeOut As DateTime? = Nothing

                        If hasTimeIn Then timeIn = Convert.ToDateTime(timeInValue)
                        If hasTimeOut Then timeOut = Convert.ToDateTime(timeOutValue)

                        ' --- Update labels for times ---
                        If hasTimeIn Then
                            lblCheckInTime.Text = "Check In Time: " & timeIn.Value.ToString("hh:mm tt")
                        Else
                            lblCheckInTime.Text = "Check In Time: N/A"
                        End If

                        If hasTimeOut Then
                            lblCheckOutTime.Text = "Check Out Time: " & timeOut.Value.ToString("hh:mm tt")
                        Else
                            lblCheckOutTime.Text = "Check Out Time: N/A"
                        End If

                        ' --- Update Hours Worked label ---
                        If hasTimeIn AndAlso Not hasTimeOut Then
                            Dim hoursWorked As TimeSpan = DateTime.Now - timeIn.Value
                            lblHoursWorked.Text = "Hours Worked: " & Math.Round(hoursWorked.TotalHours, 2).ToString() & " hrs"
                        ElseIf hasTimeIn AndAlso hasTimeOut Then
                            Dim hoursWorked As TimeSpan = timeOut.Value - timeIn.Value
                            lblHoursWorked.Text = "Hours Worked: " & Math.Round(hoursWorked.TotalHours, 2).ToString() & " hrs"
                        Else
                            lblHoursWorked.Text = "Hours Worked: N/A"
                        End If

                        ' --- Button visibility, interactivity, and status label ---
                        If Not hasTimeIn Then
                            btnCheckIn.Visible = True
                            btnCheckIn.Enabled = True

                            btnCheckOut.Visible = False
                            lblStatus.Text = "Status: Not Checked In"
                            lblStatus.ForeColor = Color.Gray

                        ElseIf hasTimeIn AndAlso Not hasTimeOut Then
                            btnCheckIn.Visible = False

                            btnCheckOut.Visible = True
                            btnCheckOut.Enabled = True
                            btnCheckOut.Text = "Check Out"
                            btnCheckOut.BackColor = Color.LightGreen
                            lblStatus.Text = "Status: Checked In"
                            lblStatus.ForeColor = Color.Green

                        ElseIf hasTimeIn AndAlso hasTimeOut Then
                            btnCheckIn.Visible = False

                            ' Make Check Out button stay visible but disabled
                            btnCheckOut.Visible = True
                            btnCheckOut.Enabled = False
                            btnCheckOut.Text = "Checked Out"
                            btnCheckOut.BackColor = Color.LightGray
                            lblStatus.Text = "Status: Checked Out"
                            lblStatus.ForeColor = Color.Red
                        End If

                    Else
                        ' No record for today
                        btnCheckIn.Visible = True
                        btnCheckIn.Enabled = True

                        btnCheckOut.Visible = False
                        lblStatus.Text = "Status: Not Checked In"
                        lblStatus.ForeColor = Color.Gray

                        lblCheckInTime.Text = "Check In Time: N/A"
                        lblCheckOutTime.Text = "Check Out Time: N/A"
                        lblHoursWorked.Text = "Hours Worked: N/A"
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating status and button states: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
    End Sub

    Private WithEvents refreshTimer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTimer.Interval = 5000
        refreshTimer.Start()
    End Sub

    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        UpdateCheckButtons()
    End Sub

    Private Sub SetupUI()
        lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub InitializeTimer()
        timer = New Timer()
        timer.Interval = 1000 ' Update every second
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        Dim now As DateTime = DateTime.Now
        lblCurrentDate.Text = now.ToString("dddd, MMMM dd, yyyy")
        lblCurrentTime.Text = now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empDashboardForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empDashboardForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub

    Private Sub LoadTodayAttendance()
        ' Load today's attendance record from database
        ' This is a placeholder - implement your database logic here
        Dim today As DateTime = DateTime.Today
        ' Check if employee already checked in today
        ' checkInTime = GetCheckInTimeFromDatabase(employeeId, today)
    End Sub

End Class