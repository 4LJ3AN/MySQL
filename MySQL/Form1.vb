Imports MySQL.Data.MySqlClient

Public Class Form1
    Dim connStr As String = "server=localhost;user id=root;password=;database=oopdb;SslMode=none"
    Dim conn As New MySqlConnection(connStr)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBirthdate.Value = Date.Today
        lblAge.Text = "0"
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub mysqltest(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            MessageBox.Show("Connected successfully!")

            ' Example Query
            Dim query As String = "SELECT * FROM employees"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Console.WriteLine(reader("username").ToString())
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
