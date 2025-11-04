Imports System.Drawing.Drawing2D

Public Class AdminPayroll
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