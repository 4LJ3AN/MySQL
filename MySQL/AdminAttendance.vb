Imports System.Drawing.Drawing2D

Partial Public Class AdminAttendance
    Private Sub employees_Click(sender As Object, e As EventArgs) Handles employees.Click
        Dim empForm As New AdminEmployees()
        empForm.lblAdminId.Text = Me.lblAdminId.Text
        empForm.welcomelbl.Text = Me.welcomelbl.Text
        empForm.StartPosition = FormStartPosition.Manual
        empForm.Location = Me.Location
        empForm.Show()
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

    Private Sub dashb_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim dashForm As New AdminDashboard()
        dashForm.lblAdminId.Text = Me.lblAdminId.Text
        dashForm.welcomelbl.Text = Me.welcomelbl.Text
        dashForm.StartPosition = FormStartPosition.Manual
        dashForm.Location = Me.Location
        dashForm.Show()
        Me.Hide()
    End Sub
End Class