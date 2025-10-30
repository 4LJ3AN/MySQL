Imports MySQL.Data.MySqlClient

Public Class DatabaseConnection
    Private connectionString As String = "server=localhost;user id=root;password=;database=oopdb"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class
