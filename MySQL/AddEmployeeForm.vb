Imports Microsoft.Office.Interop.Excel
Imports MySQL.Data.MySqlClient

Public Class AddEmployeeForm
    ' Database connection
    Private db As New DatabaseConnection()

    ' Store position rates
    Private positionRates As New Dictionary(Of String, Decimal)()

    ' Form close result
    Public Property DialogResult As DialogResult = DialogResult.Cancel

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm() Then
            If SaveEmployee() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidateForm() As Boolean
        ' Required fields validation
        If String.IsNullOrWhiteSpace(txtFName.Text) Then
            MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLName.Text) Then
            MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLName.Focus()
            Return False
        End If

        If cmbPosition.SelectedIndex = -1 Then
            MessageBox.Show("Position is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPosition.Focus()
            Return False
        End If

        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbGender.Focus()
            Return False
        End If

        If cmbCivilStatus.SelectedIndex = -1 Then
            MessageBox.Show("Civil status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCivilStatus.Focus()
            Return False
        End If

        ' Age validation (now calculated automatically)
        Dim age As Integer
        If Not Integer.TryParse(txtAge.Text, age) OrElse age < 18 OrElse age > 65 Then
            MessageBox.Show("Employee must be between 18 and 65 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpBirthday.Focus()
            Return False
        End If

        ' Contact validation
        If txtContact.Text.Length <> 10 OrElse Not txtContact.Text.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Contact must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContact.Focus()
            Return False
        End If

        ' Email validation
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function SaveEmployee() As Boolean
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            ' Generate employee ID using the same logic as Form1
            Dim employeeId As String = GenerateEmployeeID()

            ' Get hourly rate for selected position
            Dim selectedPosition As String = cmbPosition.SelectedItem.ToString()
            Dim hourlyRate As Decimal = positionRates(selectedPosition)

            ' Calculate salary based on hourly rate (assuming 160 hours/month)
            Dim monthlySalary As Decimal = hourlyRate * 160

            Dim query As String = "INSERT INTO employees (
                id, position, salary, fname, mname, lname, bday, gender, 
                contact, email, suffix, age, cstatus, hourlyrate, password, deleted
            ) VALUES (
                @id, @position, @salary, @fname, @mname, @lname, @bday, @gender,
                @contact, @email, @suffix, @age, @cstatus, @hourlyrate, @password, 0
            )"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@id", employeeId)
                command.Parameters.AddWithValue("@position", selectedPosition)
                command.Parameters.AddWithValue("@salary", monthlySalary)
                command.Parameters.AddWithValue("@fname", txtFName.Text.Trim())
                command.Parameters.AddWithValue("@mname", If(String.IsNullOrWhiteSpace(txtMName.Text), DBNull.Value, txtMName.Text.Trim()))
                command.Parameters.AddWithValue("@lname", txtLName.Text.Trim())
                command.Parameters.AddWithValue("@bday", dtpBirthday.Value)
                command.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString())
                command.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
                command.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                command.Parameters.AddWithValue("@suffix", If(cmbSuffix.SelectedIndex = -1, DBNull.Value, cmbSuffix.SelectedItem.ToString()))
                command.Parameters.AddWithValue("@age", Integer.Parse(txtAge.Text))
                command.Parameters.AddWithValue("@cstatus", cmbCivilStatus.SelectedItem.ToString())
                command.Parameters.AddWithValue("@hourlyrate", hourlyRate)
                command.Parameters.AddWithValue("@password", "default123") ' Default password

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show($"Employee added successfully!{vbCrLf}Employee ID: {employeeId}{vbCrLf}Position: {selectedPosition}{vbCrLf}Hourly Rate: ₱{hourlyRate:F2}{vbCrLf}Default Password: default123",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Duplicate entry
                MessageBox.Show("An employee with this information already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Function GenerateEmployeeID() As String
        Dim newID As String = "EM-0001" ' default if no rows exist
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()
            Dim query As String = "SELECT MAX(CAST(SUBSTRING(id, 4, 4) AS UNSIGNED)) FROM employees"
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                Dim nextNum As Integer = Convert.ToInt32(result) + 1
                newID = "EM-" & nextNum.ToString("D4") ' format as 4-digit with leading zeros
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating Employee ID: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return newID
    End Function

    Private Sub LoadPositionRates()
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            Dim query As String = "SELECT position, hourly_rate FROM position_rates"
            Using command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim positionName As String = reader.GetString("position")
                        Dim hourlyRate As Decimal = reader.GetDecimal("hourly_rate")
                        positionRates(positionName) = hourlyRate
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading position rates: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Fallback to default rates if database fails
            SetDefaultRates()
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SetDefaultRates()
        ' Default rates in Philippine Peso
        positionRates.Clear()
        positionRates.Add("Cashier", 85.5D)
        positionRates.Add("Stock Clerk", 88D)
        positionRates.Add("Department Manager", 124.5D)
        positionRates.Add("Custodian", 81.25D)
        positionRates.Add("Food Preparation Worker", 84D)
        positionRates.Add("Shopping Cart Attendant", 80D)
        positionRates.Add("Pharmacist", 248D)
        positionRates.Add("Front-End Manager", 132D)
        positionRates.Add("Produce Clerk", 86.75D)
        positionRates.Add("Meat and Seafood Clerk", 95D)
        positionRates.Add("Bakery Clerk", 91D)
    End Sub

    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load position rates from database
        LoadPositionRates()

        ' Populate position dropdown with available positions
        cmbPosition.Items.Clear()
        For Each position As String In positionRates.Keys
            cmbPosition.Items.Add(position)
        Next

        cmbGender.Items.AddRange({"Male", "Female", "I prefer not to say"})
        cmbCivilStatus.Items.AddRange({"Single", "Married", "Widowed", "Divorced"})
        cmbSuffix.Items.AddRange({"Jr.", "Sr.", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"})

        ' Set default date (18 years ago) and calculate initial age
        dtpBirthday.Value = DateTime.Now.AddYears(-18)
        CalculateAge()

        ' Set focus to first name
        txtFName.Focus()
    End Sub

    ' Calculate age based on birthdate
    Private Sub CalculateAge()
        Dim birthDate As DateTime = dtpBirthday.Value
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust age if birthday hasn't occurred this year yet
        If birthDate.Date > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub

    ' Recalculate age when birthdate changes
    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        CalculateAge()
    End Sub

    ' Input validation for numeric fields
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Show hourly rate when position is selected
    Private Sub cmbPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPosition.SelectedIndexChanged
        If cmbPosition.SelectedIndex <> -1 Then
            Dim selectedPosition As String = cmbPosition.SelectedItem.ToString()
            Dim hourlyRate As Decimal = positionRates(selectedPosition)
            lblHourlyRate.Text = $"Hourly Rate: ₱{hourlyRate:F2}"
        End If
    End Sub
End Class