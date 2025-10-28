Public Class LandingForm
    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        Dim adminForm As New AdminLoginForm()

        ' Match location and size
        adminForm.StartPosition = FormStartPosition.Manual
        adminForm.Location = Me.Location

        adminForm.Show()
        Me.Hide()
    End Sub

    'Private Sub empbtn_Click(sender As Object, e As EventArgs) Handles empbtn.Click
    '   Dim empForm As New EmployeeLoginForm()
    '   ' Match location and size
    '   empForm.StartPosition = FormStartPosition.Manual
    '   empForm.Location = Me.Location
    '
    '   empForm.Show()
    'Me.Hide()
    'End Sub

    Private Sub empbtn_Click(sender As Object, e As EventArgs) Handles empbtn.Click
        Dim empCheckInForm As New EmployeeCheckIn()
        empCheckInForm.StartPosition = FormStartPosition.Manual
        empCheckInForm.Location = Me.Location
        empCheckInForm.Show()
        Me.Hide()
    End Sub

End Class