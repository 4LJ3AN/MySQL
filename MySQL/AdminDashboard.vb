Public Class AdminDashboard
    Private Sub employees_Click(sender As Object, e As EventArgs) Handles employees.Click
        Dim empForm As New AdminEmployees()
        empForm.lblAdminId.Text = Me.lblAdminId.Text
        empForm.welcomelbl.Text = Me.welcomelbl.Text
        empForm.StartPosition = FormStartPosition.Manual
        empForm.Location = Me.Location
        empForm.Show()
        Me.Hide()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attForm As New AdminAttendance()
        attForm.lblAdminId.Text = Me.lblAdminId.Text
        attForm.welcomelbl.Text = Me.welcomelbl.Text
        attForm.StartPosition = FormStartPosition.Manual
        attForm.Location = Me.Location
        attForm.Show()
        Me.Hide()
    End Sub

    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payForm As New AdminPayroll()
        payForm.lblAdminId.Text = Me.lblAdminId.Text
        payForm.welcomelbl.Text = Me.welcomelbl.Text
        payForm.StartPosition = FormStartPosition.Manual
        payForm.Location = Me.Location
        payForm.Show()
        Me.Hide()
    End Sub

End Class