Public Class EmployeeAttendance
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles greetings.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles position.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles profile.Click

    End Sub

    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payslipForm As New payslip()
        payslipForm.StartPosition = FormStartPosition.Manual
        payslipForm.Location = Me.Location
        payslipForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles cur_month_sal.Click

    End Sub

    Private Sub dashb_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click

    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click

    End Sub

    Private Sub Label3_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub


End Class