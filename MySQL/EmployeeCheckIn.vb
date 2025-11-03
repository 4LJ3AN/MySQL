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

            ' Verify if the employee has checked in today but not yet checked out
            Dim checkQuery As String = "SELECT attendanceid FROM attendance WHERE employeeid=@empid AND date=@date AND timeout IS NULL LIMIT 1"
            Using checkCmd As New MySqlCommand(checkQuery, connLocal)
                checkCmd.Parameters.AddWithValue("@empid", empId)
                checkCmd.Parameters.AddWithValue("@date", currentDate)

                Dim result As Object = checkCmd.ExecuteScalar()

                If result Is Nothing OrElse Convert.ToInt32(result) <= 0 Then
                    MessageBox.Show("You have not checked in today or have already checked out.", "Check-Out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Perform the update (set timeout to a proper DateTime)
            Dim updateQuery As String = "UPDATE attendance SET timeout=@timeout WHERE employeeid=@empid AND date=@date"
            Using updateCmd As New MySqlCommand(updateQuery, connLocal)
                ' Pass a DateTime object so the connector stores a proper DATETIME
                updateCmd.Parameters.AddWithValue("@timeout", nowDt)
                updateCmd.Parameters.AddWithValue("@empid", empId)
                updateCmd.Parameters.AddWithValue("@date", currentDate)

                updateCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Check-out recorded successfully at " & nowDt.ToString("hh:mm:ss tt"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateCheckButtons()

        Catch ex As Exception
            MessageBox.Show("Error during check-out: " & ex.Message)
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
                        ' Safely handle potential NULL or zero-datetime issues
                        Dim timeInValue As Object = reader("timein")
                        Dim timeOutValue As Object = reader("timeout")

                        Dim hasTimeIn As Boolean = Not IsDBNull(timeInValue)
                        Dim hasTimeOut As Boolean = False

                        ' Check for NULL or invalid timeout values
                        If Not IsDBNull(timeOutValue) Then
                            Dim timeoutStr As String = timeOutValue.ToString()
                            If Not (String.IsNullOrWhiteSpace(timeoutStr) OrElse timeoutStr = "0" OrElse timeoutStr.StartsWith("0000-00-00")) Then
                                hasTimeOut = True
                            End If
                        End If

                        If Not hasTimeIn Then
                            btnCheckIn.Visible = True
                            btnCheckOut.Visible = False
                        ElseIf hasTimeIn AndAlso Not hasTimeOut Then
                            btnCheckIn.Visible = False
                            btnCheckOut.Visible = True
                        ElseIf hasTimeIn AndAlso hasTimeOut Then
                            btnCheckIn.Visible = False
                            btnCheckOut.Visible = False
                        End If
                    Else
                        btnCheckIn.Visible = True
                        btnCheckOut.Visible = False
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating button state: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connLocal IsNot Nothing Then connLocal.Close()
        End Try
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