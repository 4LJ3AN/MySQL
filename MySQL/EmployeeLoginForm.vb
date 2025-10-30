Imports MySQL.Data.MySqlClient

Public Class EmployeeLoginForm
    Dim db As New DatabaseConnection()
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            conn = db.GetConnection()
            conn.Open()

            Dim username As String = usernametxt.Text
            Dim password As String = passwordtxt.Text

            Dim query As String = "SELECT id FROM employees WHERE email=@username AND password=@password"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Get employee id from database
                Dim empId As String = reader("id").ToString()

                ' Open the main form and pass the employee id
                Dim main As New EmployeeCheckIn()
                main.empIDlbl.Text = "Employee ID: " + empId
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid credentials.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class