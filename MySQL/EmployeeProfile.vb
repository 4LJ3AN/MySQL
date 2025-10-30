Public Class EmployeeProfile

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

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        attendanceForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        attendanceForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
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