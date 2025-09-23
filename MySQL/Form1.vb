Imports MySQL.Data.MySqlClient

Public Class Form1
    Dim connStr As String = "server=localhost;user id=root;password=;database=oopdb;SslMode=none"
    Dim conn As New MySqlConnection(connStr)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set defaults
        bdybox.Value = Date.Today
        agebox.Text = "0"

        ' List of input controls to track
        Dim boxNames As String() = {
            "posbox", "salbox",
            "fnbox", "mnbox", "lnbox",
            "bdybox", "genbox", "conbox",
            "addbox", "emabox", "sufbox", "cstbox"
        }

        ' Attach handlers and run initial check
        For Each boxName In boxNames
            Dim ctrl As Control = FindControlRecursive(Me, boxName)
            If ctrl Is Nothing Then Continue For

            If TypeOf ctrl Is TextBox Then
                AddHandler DirectCast(ctrl, TextBox).TextChanged, AddressOf InputChanged

            ElseIf TypeOf ctrl Is ComboBox Then
                AddHandler DirectCast(ctrl, ComboBox).SelectedIndexChanged, AddressOf InputChanged
                AddHandler DirectCast(ctrl, ComboBox).TextChanged, AddressOf InputChanged

            ElseIf TypeOf ctrl Is DateTimePicker Then
                AddHandler DirectCast(ctrl, DateTimePicker).ValueChanged, AddressOf InputChanged
            End If

            ' Middle name checkbox
            AddHandler mncb.CheckedChanged,
    Sub()
        If mncb.Checked Then
            mnbox.Clear()
            mnbox.Enabled = False
        Else
            mnbox.Enabled = True
        End If
        InputChanged(mnbox, EventArgs.Empty) ' refresh validation
    End Sub

            ' Suffix checkbox
            AddHandler sufcb.CheckedChanged,
    Sub()
        If sufcb.Checked Then
            sufbox.SelectedIndex = -1
            sufbox.Enabled = False
        Else
            sufbox.Enabled = True
        End If
        InputChanged(sufbox, EventArgs.Empty) ' refresh validation
    End Sub


            ' Run first validation immediately
            InputChanged(ctrl, EventArgs.Empty)
            LoadEmployees()
            idbox.Text = GenerateEmployeeID()
        Next
    End Sub

    Private Function GenerateEmployeeID() As String
        Dim newID As String = "EM-0001" ' default if no rows exist
        Try
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
            conn.Close()
        End Try
        Return newID
    End Function

    Private Sub InsertEmployee()
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "INSERT INTO employees " &
                "(id, position, salary, fname, mname, lname, bday, gender, contact, email, address, suffix, age, cstatus) " &
                "VALUES (@id, @position, @salary, @fname, @mname, @lname, @bday, @gender, @contact, @email, @address, @suffix, @age, @cstatus)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idbox.Text)
                    cmd.Parameters.AddWithValue("@position", posbox.Text)
                    cmd.Parameters.AddWithValue("@salary", salbox.Text)
                    cmd.Parameters.AddWithValue("@fname", fnbox.Text)
                    cmd.Parameters.AddWithValue("@mname", If(String.IsNullOrWhiteSpace(mnbox.Text), DBNull.Value, mnbox.Text))
                    cmd.Parameters.AddWithValue("@lname", lnbox.Text)
                    cmd.Parameters.AddWithValue("@bday", bdybox.Value)
                    cmd.Parameters.AddWithValue("@gender", genbox.Text)
                    cmd.Parameters.AddWithValue("@contact", conbox.Text)
                    cmd.Parameters.AddWithValue("@email", emabox.Text)
                    cmd.Parameters.AddWithValue("@address", addbox.Text)
                    cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(sufbox.Text), DBNull.Value, sufbox.Text))
                    cmd.Parameters.AddWithValue("@age", agebox.Text)
                    cmd.Parameters.AddWithValue("@cstatus", cstbox.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee inserted successfully!")
            LoadEmployees()
        Catch ex As Exception
            MessageBox.Show("Error inserting employee: " & ex.Message)
        End Try
    End Sub

    Private Sub savBtn_Click(sender As Object, e As EventArgs) Handles savbtn.Click

        If Not ValidateInputs() Then
            Exit Sub
        End If

        If EmployeeExists(idbox.Text) Then
            UpdateEmployee()
            MessageBox.Show("Employee updated successfully!")
        Else
            InsertEmployee()
            MessageBox.Show("Employee added successfully!")

            ' Generate next ID only after insert
            idbox.Text = GenerateEmployeeID()
        End If
    End Sub

    Private Sub LoadEmployees()
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT id, position, salary, fname, mname, lname, bday, gender, contact, email, address, suffix, age, cstatus FROM employees"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvEmployees.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
        End If
    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updbtn.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvEmployees.SelectedRows(0)

        ' Fill fields
        idbox.Text = selectedRow.Cells("id").Value.ToString()
        posbox.Text = selectedRow.Cells("position").Value.ToString()
        salbox.Text = selectedRow.Cells("salary").Value.ToString()
        fnbox.Text = selectedRow.Cells("fname").Value.ToString()
        lnbox.Text = selectedRow.Cells("lname").Value.ToString()
        conbox.Text = selectedRow.Cells("contact").Value.ToString()
        emabox.Text = selectedRow.Cells("email").Value.ToString()
        addbox.Text = selectedRow.Cells("address").Value.ToString()
        agebox.Text = selectedRow.Cells("age").Value.ToString()

        ' DateTimePicker (must parse date properly)
        Dim bday As Date
        If Date.TryParse(selectedRow.Cells("bday").Value.ToString(), bday) Then
            bdybox.Value = bday
        End If

        ' Combos
        genbox.Text = selectedRow.Cells("gender").Value.ToString()
        cstbox.Text = selectedRow.Cells("cstatus").Value.ToString()

        ' Handle optional middle name
        If selectedRow.Cells("mname").Value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(selectedRow.Cells("mname").Value.ToString()) Then
            mncb.Checked = True
            mnbox.Clear()
            mnbox.Enabled = False
        Else
            mncb.Checked = False
            mnbox.Text = selectedRow.Cells("mname").Value.ToString()
            mnbox.Enabled = True
        End If

        ' Handle optional suffix
        If selectedRow.Cells("suffix").Value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(selectedRow.Cells("suffix").Value.ToString()) Then
            sufcb.Checked = True
            sufbox.SelectedIndex = -1
            sufbox.Enabled = False
        Else
            sufcb.Checked = False
            sufbox.Text = selectedRow.Cells("suffix").Value.ToString()
            sufbox.Enabled = True
        End If

        ' Switch to details tab
        TabControl1.SelectedTab = detailstab
    End Sub

    Private Sub UpdateEmployee()
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "UPDATE employees SET " &
                "position=@position, salary=@salary, fname=@fname, mname=@mname, lname=@lname, " &
                "bday=@bday, gender=@gender, contact=@contact, email=@email, address=@address, " &
                "suffix=@suffix, age=@age, cstatus=@cstatus WHERE id=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idbox.Text)
                    cmd.Parameters.AddWithValue("@position", posbox.Text)
                    cmd.Parameters.AddWithValue("@salary", salbox.Text)
                    cmd.Parameters.AddWithValue("@fname", fnbox.Text)
                    cmd.Parameters.AddWithValue("@mname", If(String.IsNullOrWhiteSpace(mnbox.Text), DBNull.Value, mnbox.Text))
                    cmd.Parameters.AddWithValue("@lname", lnbox.Text)
                    cmd.Parameters.AddWithValue("@bday", bdybox.Value)
                    cmd.Parameters.AddWithValue("@gender", genbox.Text)
                    cmd.Parameters.AddWithValue("@contact", conbox.Text)
                    cmd.Parameters.AddWithValue("@email", emabox.Text)
                    cmd.Parameters.AddWithValue("@address", addbox.Text)
                    cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(sufbox.Text), DBNull.Value, sufbox.Text))
                    cmd.Parameters.AddWithValue("@age", agebox.Text)
                    cmd.Parameters.AddWithValue("@cstatus", cstbox.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee updated successfully!")
            LoadEmployees()
        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteEmployee(empId As String)
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "DELETE FROM employees WHERE id=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", empId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee deleted successfully!")
            LoadEmployees()
        Catch ex As Exception
            MessageBox.Show("Error deleting employee: " & ex.Message)
        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected employee ID
        Dim empId As String = dgvEmployees.SelectedRows(0).Cells("id").Value.ToString()

        ' Confirm before deleting
        Dim confirm = MessageBox.Show($"Are you sure you want to delete Employee {empId}?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            DeleteEmployee(empId)
        End If
    End Sub

    Private Function EmployeeExists(empId As String) As Boolean
        Dim exists As Boolean = False
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM employees WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", empId)
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
        Return exists
    End Function

    ' Handle Enter key to go to next input
    Private Sub nextItem(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    ' Auto update age when birthday changes
    Private Sub bdybox_ValueChanged(sender As Object, e As EventArgs) Handles bdybox.ValueChanged
        agebox.Text = CalculateAge(bdybox.Value).ToString()
    End Sub

    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If (birthDate > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub InputChanged(sender As Object, e As EventArgs)
        Dim ctrl As Control = TryCast(sender, Control)
        If ctrl Is Nothing Then Return

        Dim lblName As String = ctrl.Name.Replace("box", "lbl")
        Dim lbl As Label = TryCast(FindControlRecursive(Me, lblName), Label)
        If lbl Is Nothing Then Return

        Dim hasValue As Boolean = False

        If TypeOf ctrl Is TextBox Then
            hasValue = Not String.IsNullOrWhiteSpace(DirectCast(ctrl, TextBox).Text)

        ElseIf TypeOf ctrl Is ComboBox Then
            Dim cb = DirectCast(ctrl, ComboBox)
            hasValue = (cb.SelectedIndex >= 0) OrElse (Not String.IsNullOrWhiteSpace(cb.Text))

        ElseIf TypeOf ctrl Is DateTimePicker Then
            Dim dtp = DirectCast(ctrl, DateTimePicker)
            If dtp.ShowCheckBox Then
                hasValue = dtp.Checked
            Else
                hasValue = True
            End If
        End If

        If ctrl.Name = "mnbox" Then
            If mncb.Checked Then
                lbl.Visible = False
                Return
            End If
        End If

        If ctrl.Name = "sufbox" Then
            If sufcb.Checked Then
                lbl.Visible = False
                Return
            End If
        End If

        lbl.Visible = Not hasValue
    End Sub

    Private Function FindControlRecursive(parent As Control, name As String) As Control
        For Each c As Control In parent.Controls
            If String.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase) Then
                Return c
            End If
            If c.HasChildren Then
                Dim found = FindControlRecursive(c, name)
                If found IsNot Nothing Then Return found
            End If
        Next
        Return Nothing
    End Function

    Private Sub salbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salbox.KeyPress
        Dim tb As TextBox = DirectCast(sender, TextBox)

        If tb.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso tb.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub NameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fnbox.KeyPress, mnbox.KeyPress, lnbox.KeyPress
        ' Allow letters, backspace, and space
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = ControlChars.Back OrElse e.KeyChar = " "c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles fnbox.TextChanged, mnbox.TextChanged, lnbox.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Enforce max length = 20
        If tb.Text.Length > 20 Then
            tb.Text = tb.Text.Substring(0, 20)
            tb.SelectionStart = tb.Text.Length
        End If

        ' Remove double spaces
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "\s{2,}", " ")
        tb.SelectionStart = tb.Text.Length

        ' Capitalize each word
        Dim words = tb.Text.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next
        Dim formatted = String.Join(" ", words)
        If tb.Text <> formatted Then
            tb.Text = formatted
            tb.SelectionStart = tb.Text.Length
        End If
    End Sub

    Private Sub conbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conbox.KeyPress
        ' Allow digits and backspace only
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub conbox_TextChanged(sender As Object, e As EventArgs) Handles conbox.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Remove any non-digit just in case
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "[^\d]", "")
        tb.SelectionStart = tb.Text.Length

        ' Handle "09..." case → remove first 0
        If tb.Text.StartsWith("09") Then
            tb.Text = tb.Text.Substring(1) ' cut leading 0
            tb.SelectionStart = tb.Text.Length
        End If

        ' Limit to 10 digits
        If tb.Text.Length > 10 Then
            tb.Text = tb.Text.Substring(0, 10)
            tb.SelectionStart = tb.Text.Length
        End If
    End Sub

    Private Sub addbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addbox.KeyPress
        ' Allow letters, digits, space, and symbols (# - + ,), plus backspace
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse " #+-,.".Contains(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub addbox_TextChanged(sender As Object, e As EventArgs) Handles addbox.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Enforce max length
        If tb.Text.Length > 55 Then
            tb.Text = tb.Text.Substring(0, 55)
            tb.SelectionStart = tb.Text.Length
        End If

        ' Remove chained spaces
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "\s{2,}", " ")
        tb.SelectionStart = tb.Text.Length

        ' Capitalize each word
        Dim words = tb.Text.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1)
            End If
        Next
        Dim formatted = String.Join(" ", words)
        If tb.Text <> formatted Then
            tb.Text = formatted
            tb.SelectionStart = tb.Text.Length
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Contact validation
        If String.IsNullOrWhiteSpace(conbox.Text) OrElse conbox.Text.Length <> 10 Then
            MessageBox.Show("Contact number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not conbox.Text.StartsWith("9") Then
            MessageBox.Show("Contact number must start with 9 (valid PH number).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Email validation
        If String.IsNullOrWhiteSpace(emabox.Text) Then
            MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Allow only specific domains
        Dim validDomains As String() = {"@gmail.com", "@yahoo.com", "@email.com", "@outlook.com", "@hotmail.com"}
        Dim isValidDomain As Boolean = validDomains.Any(Function(d) emabox.Text.ToLower().EndsWith(d))

        If Not isValidDomain Then
            MessageBox.Show("Email must end with a valid domain (gmail.com, yahoo.com, email.com, outlook.com, hotmail.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub refbtn_Click(sender As Object, e As EventArgs) Handles refbtn.Click
        LoadEmployees()
    End Sub
End Class
