Imports Org.BouncyCastle.Asn1.Cmp

Public Class EmployeeCheckIn
    Private timer As Timer
    Private checkInTime As DateTime?
    Private checkOutTime As DateTime?
    Private currentStatus As String = "Not Checked In"

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