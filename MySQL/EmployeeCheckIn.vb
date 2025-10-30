Imports MySQL.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class EmployeeCheckIn
    Private timer As Timer
    Private checkInTime As DateTime?
    Private checkOutTime As DateTime?
    Private currentStatus As String = "Not Checked In"

    Dim db As New DatabaseConnection()
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Try
            conn = db.GetConnection()
            conn.Open()

            Dim empId As String = empIDlbl.Text
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Prevent duplicate check-in for same day
            Dim checkQuery As String = "SELECT * FROM attendance WHERE employeeid=@empid AND date=@date"
            cmd = New MySqlCommand(checkQuery, conn)
            cmd.Parameters.AddWithValue("@empid", empId)
            cmd.Parameters.AddWithValue("@date", currentDate)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("You already checked in today.")
                reader.Close()
            Else
                reader.Close()
                Dim insertQuery As String = "INSERT INTO attendance (employeeid, date, timein) VALUES (@empid, @date, @timein)"
                cmd = New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@empid", empId)
                cmd.Parameters.AddWithValue("@date", currentDate)
                cmd.Parameters.AddWithValue("@timein", currentTime)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Check-in recorded successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub EmployeeCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTimer()
        SetupUI()
    End Sub

    Private Sub SetupUI()
        ' Set up initial display
        lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        ' Initialize check-in/out status
        UpdateCheckInOutStatus()
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
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payslipForm As New EmployeePayslip()
        payslipForm.StartPosition = FormStartPosition.Manual
        payslipForm.Location = Me.Location
        payslipForm.Show()
        Me.Hide()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.StartPosition = FormStartPosition.Manual
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Dim profileForm As New EmployeeProfile()
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

    Private Sub UpdateCheckInOutStatus()
        ' This method would be called to refresh the status from database
        LoadTodayAttendance()
    End Sub
End Class