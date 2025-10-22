Public Class payslip

    Private Sub dashb_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.StartPosition = FormStartPosition.Manual
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
        Me.Hide()
    End Sub
End Class