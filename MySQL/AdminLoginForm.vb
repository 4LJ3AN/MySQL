Imports System.Data.SqlClient
Imports MySQL.Data.MySqlClient

Public Class AdminLoginForm
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = userbox.Text.Trim()
        Dim password As String = passbox.Text.Trim()

        ' Validate inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            lblError.Text = "Please enter both username and password"
            lblError.Visible = True
            Return
        End If

        ' Database connection string - update with your actual connection string
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection

        Try
            conn = db.GetConnection()
            conn.Open()

            ' Query to check admin credentials
            Dim query As String = "SELECT admin_id, username, full_name FROM admins WHERE username = @username AND password = @password"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' Login successful
                        reader.Read()

                        ' Store admin info (you can use these later)
                        Dim adminId As String = reader("admin_id").ToString()
                        Dim adminUsername As String = reader("username").ToString()
                        Dim adminFullName As String = reader("full_name").ToString()

                        ' Hide error message
                        lblError.Visible = False

                        ' Show success message
                        MessageBox.Show($"Login successful! Welcome {adminFullName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)



                        Dim adminDashboard As New AdminDashboard()
                        adminDashboard.lblAdminId.Text = "Admin ID: " & adminId
                        adminDashboard.welcomelbl.Text = "Logged in as " & adminFullName
                        adminDashboard.StartPosition = FormStartPosition.Manual
                        adminDashboard.Location = Me.Location
                        adminDashboard.Show()
                        Me.Close()

                    Else
                        ' Login failed
                        lblError.Text = "Invalid username or password"
                        lblError.Visible = True
                        passbox.Clear()
                        passbox.Focus()
                    End If
                End Using
            End Using

        Catch ex As Exception
            lblError.Text = "Database error: " & ex.Message
            lblError.Visible = True
        End Try
    End Sub

    Private Sub hidepass_CheckedChanged(sender As Object, e As EventArgs) Handles hidepass.CheckedChanged
        ' Toggle password visibility
        If hidepass.Checked Then
            passbox.PasswordChar = Char.MinValue ' Show text
        Else
            passbox.PasswordChar = "●" ' Hide text with bullet character
        End If
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up initial form state
        lblError.Visible = False
        ' Set up initial form state
        passbox.PasswordChar = "●" ' Set initial password character
        hidepass.Text = "Show Password"
    End Sub

    ' Optional: Allow pressing Enter to login
    Private Sub userbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles userbox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogIn.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub passbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passbox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogIn.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub


End Class
