Imports MySQL.Data.MySqlClient

Public Class Form1
    Dim connStr As String = "server=localhost;user id=root;password=;database=oopdb;SslMode=none"
    Dim conn As New MySqlConnection(connStr)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If sbybox.Items.Count > 0 Then
            sbybox.SelectedIndex = 1   ' or whichever index you prefer
        End If

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
        InputChanged(sufbox, EventArgs.Empty)
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

            'MessageBox.Show("Employee inserted successfully!")
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
            idbox.Text = GenerateEmployeeID()
            clearDetails()
            mncb.Checked = False
            sufcb.Checked = False
        Else
            InsertEmployee()
            MessageBox.Show("Employee added successfully!")

            ' Generate next ID only after insert
            idbox.Text = GenerateEmployeeID()
            clearDetails()
            mncb.Checked = False
            sufcb.Checked = False
        End If
    End Sub

    Private Sub clearDetails()
        idbox.Text = GenerateEmployeeID()
        posbox.SelectedIndex = -1
        salbox.Clear()
        fnbox.Clear()
        mnbox.Clear()
        lnbox.Clear()
        bdybox.Value = Date.Today
        genbox.SelectedIndex = -1
        conbox.Clear()
        emabox.Clear()
        addbox.Clear()
        sufbox.SelectedIndex = -1
        cstbox.SelectedIndex = -1
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clebtn.Click
        clearDetails()
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

                dgvEmployees.Columns("id").HeaderText = "Employee ID"
                dgvEmployees.Columns("position").HeaderText = "Position"
                dgvEmployees.Columns("salary").HeaderText = "Salary"
                dgvEmployees.Columns("fname").HeaderText = "First Name"
                dgvEmployees.Columns("mname").HeaderText = "Middle Name"
                dgvEmployees.Columns("lname").HeaderText = "Last Name"
                dgvEmployees.Columns("bday").HeaderText = "Birthday"
                dgvEmployees.Columns("gender").HeaderText = "Gender"
                dgvEmployees.Columns("contact").HeaderText = "Contact #"
                dgvEmployees.Columns("email").HeaderText = "Email"
                dgvEmployees.Columns("address").HeaderText = "Address"
                dgvEmployees.Columns("suffix").HeaderText = "Suffix"
                dgvEmployees.Columns("age").HeaderText = "Age"
                dgvEmployees.Columns("cstatus").HeaderText = "Civil Status"

                For Each col As DataGridViewColumn In dgvEmployees.Columns
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Next

                ' Optional: prevent resizing making it too narrow later
                dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                ' Ensure headers don't wrap
                dgvEmployees.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

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
        TabControl.SelectedTab = detailstab
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

            'MessageBox.Show("Employee updated successfully!")
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

        ' Save caret position
        Dim selStart As Integer = tb.SelectionStart

        Dim newText As String = tb.Text

        ' Enforce max length = 20
        If newText.Length > 20 Then
            newText = newText.Substring(0, 20)
        End If

        ' Remove double spaces
        newText = System.Text.RegularExpressions.Regex.Replace(newText, "\s{2,}", " ")

        ' Capitalize each word
        Dim words = newText.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next
        newText = String.Join(" ", words)

        ' Apply changes only if different
        If tb.Text <> newText Then
            tb.Text = newText

            ' Restore caret position (clamped to valid range)
            If selStart > tb.Text.Length Then selStart = tb.Text.Length
            tb.SelectionStart = selStart
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

        ' Strip non-digits
        Dim selStart As Integer = tb.SelectionStart
        Dim originalLength As Integer = tb.Text.Length

        Dim newText As String = System.Text.RegularExpressions.Regex.Replace(tb.Text, "[^\d]", "")

        ' Handle "09" case → drop first 0
        If newText.StartsWith("09") Then
            newText = newText.Substring(1)
        End If

        ' Limit to 10 digits
        If newText.Length > 10 Then
            newText = newText.Substring(0, 10)
        End If

        If tb.Text <> newText Then
            tb.Text = newText
            Dim diff As Integer = tb.Text.Length - originalLength
            selStart += diff
            If selStart < 0 Then selStart = 0
            If selStart > tb.Text.Length Then selStart = tb.Text.Length
        End If

        tb.SelectionStart = selStart
    End Sub

    Private Sub addbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addbox.KeyPress
        ' Allow letters, digits, space, and symbols (# - + ,), plus backspace
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse " #+-,.".Contains(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddBox_TextChanged(sender As Object, e As EventArgs) Handles addbox.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Save caret position
        Dim selStart As Integer = tb.SelectionStart

        Dim newText As String = tb.Text

        ' Enforce max length = 55
        If newText.Length > 55 Then
            newText = newText.Substring(0, 55)
        End If

        ' Remove double spaces
        newText = System.Text.RegularExpressions.Regex.Replace(newText, "\s{2,}", " ")

        ' Capitalize each word
        Dim words = newText.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1)
            End If
        Next
        newText = String.Join(" ", words)

        ' Apply only if different
        If tb.Text <> newText Then
            tb.Text = newText
            If selStart > tb.Text.Length Then selStart = tb.Text.Length
            tb.SelectionStart = selStart
        End If
    End Sub

    Private Sub EmaBox_TextChanged(sender As Object, e As EventArgs) Handles emabox.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Save caret position
        Dim selStart As Integer = tb.SelectionStart

        Dim newText As String = tb.Text

        ' Enforce allowed characters only
        newText = System.Text.RegularExpressions.Regex.Replace(newText, "[^a-zA-Z0-9@._]", "")

        ' Force lowercase (common convention for emails)
        newText = newText.ToLower()

        ' Apply only if different
        If tb.Text <> newText Then
            tb.Text = newText
            If selStart > tb.Text.Length Then selStart = tb.Text.Length
            tb.SelectionStart = selStart
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim errors As New List(Of String)()

        ' First Name
        If String.IsNullOrWhiteSpace(fnbox.Text) Then
            errors.Add("First name cannot be empty.")
        End If

        ' Middle Name (optional if mncb is checked)
        If Not mncb.Checked AndAlso String.IsNullOrWhiteSpace(mnbox.Text) Then
            errors.Add("Middle name cannot be empty unless the 'No Middle Name' box is checked.")
        End If

        ' Last Name
        If String.IsNullOrWhiteSpace(lnbox.Text) Then
            errors.Add("Last name cannot be empty.")
        End If

        ' Suffix (optional if sufcb is checked)
        If Not sufcb.Checked AndAlso String.IsNullOrWhiteSpace(sufbox.Text) Then
            errors.Add("Suffix cannot be empty unless the 'No Suffix' box is checked.")
        End If

        ' Birthday + Age validation
        If String.IsNullOrWhiteSpace(bdybox.Text) Then
            errors.Add("Birthday must be provided.")
        Else
            Dim bday As Date
            If Date.TryParse(bdybox.Text, bday) Then
                Dim today As Date = Date.Today
                Dim age As Integer = today.Year - bday.Year
                If bday > today.AddYears(-age) Then
                    age -= 1
                End If

                If age < 18 Then
                    errors.Add("Employee must be at least 18 years old.")
                End If

                If age > 80 Then
                    errors.Add("Employee must not exceed 80 years old.")
                End If
            Else
                errors.Add("Invalid birthday format.")
            End If
        End If

        ' Contact validation
        If String.IsNullOrWhiteSpace(conbox.Text) Then
            errors.Add("Contact number cannot be empty.")
        Else
            If conbox.Text.Length <> 10 Then
                errors.Add("Contact number must be exactly 10 digits.")
            End If
            If Not conbox.Text.StartsWith("9") Then
                errors.Add("Contact number must start with 9 (valid PH number).")
            End If
        End If

        ' Email validation
        If String.IsNullOrWhiteSpace(emabox.Text) Then
            errors.Add("Email cannot be empty.")
        Else
            ' Split into local-part and domain
            Dim parts = emabox.Text.Split("@"c)
            If parts.Length <> 2 Then
                errors.Add("Email format is invalid.")
            Else
                Dim localPart As String = parts(0)
                Dim domainPart As String = "@" & parts(1).ToLower()

                ' Local part must be at least 6 characters
                If localPart.Length < 6 Then
                    errors.Add("Email username (before @) must be at least 6 characters long.")
                End If

                ' Only allow specific domains
                Dim validDomains As String() = {"@gmail.com", "@yahoo.com", "@email.com", "@outlook.com", "@hotmail.com"}
                Dim isValidDomain As Boolean = validDomains.Any(Function(d) domainPart = d)
                If Not isValidDomain Then
                    errors.Add("Email must end with a valid domain (gmail.com, yahoo.com, email.com, outlook.com, hotmail.com).")
                End If
            End If
        End If

        ' Address
        If String.IsNullOrWhiteSpace(addbox.Text) Then
            errors.Add("Address cannot be empty.")
        End If

        ' Salary
        If String.IsNullOrWhiteSpace(salbox.Text) Then
            errors.Add("Salary cannot be empty.")
        End If

        ' Civil Status
        If String.IsNullOrWhiteSpace(cstbox.Text) Then
            errors.Add("Civil status must be selected.")
        End If

        ' Show errors if any
        If errors.Count > 0 Then
            MessageBox.Show(String.Join(Environment.NewLine, errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Private Sub refbtn_Click(sender As Object, e As EventArgs) Handles refbtn.Click
        sbybox.SelectedIndex = -1
        seabox.Clear()
        LoadEmployees()
    End Sub

    ' Reset search box when search-by option changes
    Private Sub sbybox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sbybox.SelectedIndexChanged
        seabox.Text = "" ' clear old search text

        If sbybox.SelectedIndex >= 0 Then
            seabox.Enabled = True   ' enable when valid option selected
        Else
            seabox.Enabled = False  ' disable when nothing selected
        End If
    End Sub


    ' Validation depending on selected search option
    Private Sub seaboxValidation(sender As Object, e As EventArgs) Handles seabox.TextChanged
        If sbybox.SelectedIndex < 0 Then Exit Sub

        Dim tb As TextBox = seabox
        Dim selStart As Integer = tb.SelectionStart
        Dim newText As String = tb.Text

        Select Case sbybox.SelectedItem.ToString()
            Case "Employee ID", "Contact #"
                ' Allow only digits
                newText = System.Text.RegularExpressions.Regex.Replace(newText, "[^\d]", "")

                ' Treat leading "09" as "9"
                If newText.StartsWith("09") Then
                    newText = newText.Substring(1)
                End If

            Case "Name (search in all three field names)"
                ' Same rules as your name fields
                ' Max length = 20
                If newText.Length > 20 Then newText = newText.Substring(0, 20)

                ' Remove double spaces
                newText = System.Text.RegularExpressions.Regex.Replace(newText, "\s{2,}", " ")

                ' Capitalize each word
                Dim words = newText.Split(" "c)
                For i As Integer = 0 To words.Length - 1
                    If words(i).Length > 0 Then
                        words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
                    End If
                Next
                newText = String.Join(" ", words)

            Case "Email"
                ' Allow letters, numbers, @, ., _
                newText = System.Text.RegularExpressions.Regex.Replace(newText, "[^a-zA-Z0-9@._]", "")
        End Select

        ' Apply changes only if different
        If tb.Text <> newText Then
            tb.Text = newText
            ' Restore caret position
            If selStart > tb.Text.Length Then selStart = tb.Text.Length
            tb.SelectionStart = selStart
        End If
    End Sub

    Private Sub seabox_TextChanged(sender As Object, e As EventArgs) Handles seabox.TextChanged
        If sbybox.SelectedIndex < 0 Then Exit Sub
        PerformSearch()
    End Sub

    ' Run search dynamically as user types
    Private Sub PerformSearch()
        If sbybox.SelectedIndex < 0 Then Return

        Dim searchBy As String = sbybox.SelectedItem.ToString()
        Dim searchText As String = seabox.Text.Trim()

        ' If empty, show all rows
        If String.IsNullOrEmpty(searchText) Then
            LoadEmployees()
            Return
        End If

        Dim query As String = ""
        Select Case searchBy
            Case "Employee ID"
                query = "SELECT * FROM employees WHERE id LIKE @search"
            Case "Name"
                ' CONCAT_WS skips NULL values; TRIM removes leading/trailing spaces
                query = "SELECT * FROM employees " &
                        "WHERE LOWER(TRIM(CONCAT_WS(' ', fname, mname, lname))) LIKE @search"
            Case "Email"
                query = "SELECT * FROM employees WHERE LOWER(email) LIKE @search"
            Case "Contact #"
                query = "SELECT * FROM employees WHERE contact LIKE @search"
            Case Else
                Return
        End Select

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' parameter is already lowercased for case-insensitive comparisons where we use LOWER(...)
                    If searchBy = "Email" OrElse searchBy = "Name (search in all three field names)" Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchText.ToLower() & "%")
                    Else
                        cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvEmployees.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while searching: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        'seaboxDisable()
        ' Only clear fields when leaving the details tab
        If TabControl.SelectedTab IsNot detailstab Then
            clearDetails()
            mncb.Checked = False
            sufcb.Checked = False
            sbybox.SelectedIndex = -1
            seabox.Clear()
            LoadEmployees()
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployees.SelectionChanged
        ' Enable buttons only if exactly 1 row is selected and it's not the new row
        If dgvEmployees.SelectedRows.Count = 1 AndAlso Not dgvEmployees.SelectedRows(0).IsNewRow Then
            updbtn.Enabled = True
            delbtn.Enabled = True
        Else
            updbtn.Enabled = False
            delbtn.Enabled = False
        End If
    End Sub

    Private Sub seaboxDisable()
        If sbybox.SelectedIndex = -1 Then
            seabox.Clear()
            seabox.Enabled = False
        End If
    End Sub


End Class
