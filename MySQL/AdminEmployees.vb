Imports System.IO
Imports System.Text
Imports MySQL.Data.MySqlClient

Partial Public Class AdminEmployees

    Private Sub AdminEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize button states
        btnRestore.Enabled = False
        btnRestore.Visible = False

        LoadEmployees()
        SetupComboBoxColumns()
        StyleDataGridView()

        ' Enable editing
        dgvEmployees.ReadOnly = False
        dgvEmployees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub LoadEmployees()
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            ' Determine which employees to load based on checkbox state
            Dim deletedFilter As Integer = If(seeDeleted.Checked, 1, 0)

            Dim query As String = "SELECT 
                            id AS 'Employee ID',
                            CONCAT(fname, ' ', COALESCE(mname, ''), ' ', lname, 
                                   CASE WHEN suffix IS NOT NULL THEN CONCAT(' ', suffix) ELSE '' END) AS 'Full Name',
                            position AS 'Position',
                            hourlyrate AS 'Hourly Rate',
                            age AS 'Age',
                            gender AS 'Gender',
                            cstatus AS 'Civil Status',
                            contact AS 'Contact',
                            email AS 'Email',
                            address AS 'Address',
                            bday AS 'Birthday'
                          FROM employees 
                          WHERE deleted = @deletedFilter
                          ORDER BY lname, fname"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@deletedFilter", deletedFilter)

                Using adapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind to DataGridView
                    dgvEmployees.DataSource = dataTable

                    ' Format columns
                    FormatDataGridViewColumns()

                    ' Update row styling based on view
                    ApplyArchiveViewStyling()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SetupComboBoxColumns()
        ' Set up Gender column as combobox
        If dgvEmployees.Columns.Contains("Gender") Then
            Dim genderColumn As New DataGridViewComboBoxColumn()
            genderColumn.HeaderText = "Gender"
            genderColumn.Name = "Gender"
            genderColumn.DataPropertyName = "Gender"
            genderColumn.Items.AddRange({"Male", "Female", "I prefer not to say"})
            genderColumn.FlatStyle = FlatStyle.Flat
            genderColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton

            ' Replace the existing column
            Dim oldIndex = dgvEmployees.Columns("Gender").Index
            dgvEmployees.Columns.Remove("Gender")
            dgvEmployees.Columns.Insert(oldIndex, genderColumn)
        End If

        ' Set up Civil Status column as combobox
        If dgvEmployees.Columns.Contains("Civil Status") Then
            Dim statusColumn As New DataGridViewComboBoxColumn()
            statusColumn.HeaderText = "Civil Status"
            statusColumn.Name = "Civil Status"
            statusColumn.DataPropertyName = "Civil Status"
            statusColumn.Items.AddRange({"Single", "Married", "Widowed", "Divorced"})
            statusColumn.FlatStyle = FlatStyle.Flat
            statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton

            ' Replace the existing column
            Dim oldIndex = dgvEmployees.Columns("Civil Status").Index
            dgvEmployees.Columns.Remove("Civil Status")
            dgvEmployees.Columns.Insert(oldIndex, statusColumn)
        End If

        ' Set up Position column as combobox
        If dgvEmployees.Columns.Contains("Position") Then
            Dim positionColumn As New DataGridViewComboBoxColumn()
            positionColumn.HeaderText = "Position"
            positionColumn.Name = "Position"
            positionColumn.DataPropertyName = "Position"
            positionColumn.Items.AddRange({
                "Cashier", "Stock Clerk", "Department Manager", "Custodian",
                "Food Preparation Worker", "Shopping Cart Attendant", "Pharmacist",
                "Front-End Manager", "Produce Clerk", "Meat and Seafood Clerk", "Bakery Clerk"
            })
            positionColumn.FlatStyle = FlatStyle.Flat
            positionColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton

            ' Replace the existing column
            Dim oldIndex = dgvEmployees.Columns("Position").Index
            dgvEmployees.Columns.Remove("Position")
            dgvEmployees.Columns.Insert(oldIndex, positionColumn)
        End If
    End Sub

    Private Sub FormatDataGridViewColumns()
        If dgvEmployees.Columns.Count > 0 Then
            ' Format hourly rate column only
            If dgvEmployees.Columns("Hourly Rate") IsNot Nothing Then
                dgvEmployees.Columns("Hourly Rate").DefaultCellStyle.Format = "C2"
                dgvEmployees.Columns("Hourly Rate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If

            ' Format numeric columns
            If dgvEmployees.Columns("Age") IsNot Nothing Then
                dgvEmployees.Columns("Age").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            ' Set column widths
            dgvEmployees.Columns("Employee ID").Width = 100
            dgvEmployees.Columns("Full Name").Width = 200
            dgvEmployees.Columns("Position").Width = 150
            dgvEmployees.Columns("Hourly Rate").Width = 100
            dgvEmployees.Columns("Age").Width = 60
            dgvEmployees.Columns("Gender").Width = 120
            dgvEmployees.Columns("Civil Status").Width = 120
            dgvEmployees.Columns("Contact").Width = 100
            dgvEmployees.Columns("Email").Width = 150
            dgvEmployees.Columns("Address").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            ' Hide birthday column
            dgvEmployees.Columns("Birthday").Visible = False
        End If
    End Sub

    Private Sub StyleDataGridView()
        ' Basic styling for better appearance
        dgvEmployees.BackgroundColor = Color.White
        dgvEmployees.BorderStyle = BorderStyle.None
        dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        dgvEmployees.RowHeadersVisible = False
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.MultiSelect = False
        dgvEmployees.ReadOnly = False
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvEmployees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
        dgvEmployees.AllowUserToAddRows = False

        ' Header styling
        dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvEmployees.ColumnHeadersDefaultCellStyle.Font = New Font(dgvEmployees.Font, FontStyle.Bold)
        dgvEmployees.EnableHeadersVisualStyles = False

        ' Row styling
        dgvEmployees.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvEmployees.DefaultCellStyle.Padding = New Padding(2)

        ' Make non-editable columns visually distinct
        dgvEmployees.Columns("Employee ID").ReadOnly = True
        dgvEmployees.Columns("Full Name").ReadOnly = True
        dgvEmployees.Columns("Employee ID").DefaultCellStyle.BackColor = Color.LightYellow
        dgvEmployees.Columns("Full Name").DefaultCellStyle.BackColor = Color.LightYellow
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadEmployees()
        SetupComboBoxColumns() ' Re-setup combobox columns after refresh
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FilterEmployees(txtsearch.Text.Trim())
    End Sub

    Private Sub FilterEmployees(searchText As String)
        If dgvEmployees.DataSource IsNot Nothing Then
            Dim dataTable As DataTable = DirectCast(dgvEmployees.DataSource, DataTable)

            If String.IsNullOrEmpty(searchText) Then
                dataTable.DefaultView.RowFilter = ""
            Else
                ' Search in multiple columns
                Dim filter As String = $"([Employee ID] LIKE '%{searchText}%' OR 
                                       [Full Name] LIKE '%{searchText}%' OR 
                                       [Position] LIKE '%{searchText}%' OR 
                                       [Email] LIKE '%{searchText}%' OR 
                                       [Contact] LIKE '%{searchText}%')"
                dataTable.DefaultView.RowFilter = filter
            End If
        End If
    End Sub

    ' ============ CSV EXPORT FUNCTIONALITY ============
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportToCSV()
    End Sub

    Private Sub ExportToCSV()
        If dgvEmployees.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files|*.csv"
        saveFileDialog.FileName = "Employees_List_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveFileDialog.FileName, False, Encoding.UTF8)
                    ' Write headers (exclude Birthday column)
                    Dim headers As New List(Of String)
                    For Each column As DataGridViewColumn In dgvEmployees.Columns
                        If column.Visible AndAlso column.HeaderText <> "Birthday" Then
                            headers.Add($"""{column.HeaderText.Replace("""", """""")}""")
                        End If
                    Next
                    writer.WriteLine(String.Join(",", headers))

                    ' Write data
                    For Each row As DataGridViewRow In dgvEmployees.Rows
                        If Not row.IsNewRow Then
                            Dim cells As New List(Of String)
                            For Each cell As DataGridViewCell In row.Cells
                                If dgvEmployees.Columns(cell.ColumnIndex).Visible AndAlso
                               dgvEmployees.Columns(cell.ColumnIndex).HeaderText <> "Birthday" Then

                                    Dim cellValue As String = If(cell.Value Is Nothing, "", cell.Value.ToString())
                                    ' Handle currency formatting for hourly rate
                                    If dgvEmployees.Columns(cell.ColumnIndex).HeaderText = "Hourly Rate" Then
                                        If Decimal.TryParse(cellValue, Nothing) Then
                                            cellValue = Decimal.Parse(cellValue).ToString("F2")
                                        End If
                                    End If
                                    cells.Add($"""{cellValue.Replace("""", """""")}""")
                                End If
                            Next
                            writer.WriteLine(String.Join(",", cells))
                        End If
                    Next
                End Using

                MessageBox.Show("Employee data exported to CSV successfully!" & vbCrLf &
                      "File: " & saveFileDialog.FileName,
                      "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error exporting to CSV: " & ex.Message, "Export Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    ' ============ END EXPORT FUNCTIONALITY ============

    ' Enable editing for specific columns
    Private Sub dgvEmployees_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvEmployees.CellBeginEdit
        ' Prevent editing of certain columns
        Dim columnName As String = dgvEmployees.Columns(e.ColumnIndex).Name

        ' Don't allow editing of Employee ID, Full Name, and Birthday
        If columnName = "Employee ID" OrElse columnName = "Full Name" OrElse columnName = "Birthday" Then
            e.Cancel = True
            MessageBox.Show("This field cannot be edited.", "Read Only", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Store original value in case user cancels
        If e.RowIndex >= 0 Then
            originalValue = dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
        End If
    End Sub

    ' Variable to store original value
    Private originalValue As String = ""

    ' Handle cell value changes
    Private Sub dgvEmployees_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        Dim columnName As String = dgvEmployees.Columns(e.ColumnIndex).Name
        Dim newValue As String = If(dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is Nothing,
                              "",
                              dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
        Dim employeeId As String = dgvEmployees.Rows(e.RowIndex).Cells("Employee ID").Value.ToString()

        ' If value didn't change, do nothing
        If newValue = originalValue Then Return

        ' Validate the input BEFORE showing confirmation (only for non-combobox fields)
        If Not ValidateFieldInput(columnName, newValue) Then
            ' Revert to original value if validation fails
            dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = originalValue
            Return
        End If

        ' Ask for confirmation
        Dim result As DialogResult = MessageBox.Show(
        $"Update {columnName} to '{newValue}' for employee {employeeId}?",
        "Confirm Update",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UpdateEmployeeField(employeeId, columnName, newValue)
        Else
            ' Revert to original value
            dgvEmployees.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = originalValue
        End If
    End Sub

    ' Simplified validation - combobox fields don't need validation since they only allow valid values
    Private Function ValidateFieldInput(fieldName As String, value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            MessageBox.Show($"{fieldName} cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Only validate non-combobox fields
        Select Case fieldName
            Case "Hourly Rate"
                If Not Decimal.TryParse(value, Nothing) OrElse Decimal.Parse(value) < 0 Then
                    MessageBox.Show("Hourly Rate must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

            Case "Age"
                Dim age As Integer
                If Not Integer.TryParse(value, age) OrElse age < 18 OrElse age > 65 Then
                    MessageBox.Show("Age must be a valid number between 18 and 65.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

            Case "Contact"
                ' Validate phone number (10 digits, numbers only)
                If value.Length <> 10 OrElse Not value.All(AddressOf Char.IsDigit) Then
                    MessageBox.Show("Contact must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

            Case "Email"
                ' Basic email validation
                If Not value.Contains("@") OrElse Not value.Contains(".") OrElse value.Length < 5 Then
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

                ' Gender, Civil Status, and Position are comboboxes - no validation needed
        End Select

        Return True
    End Function

    ' Update the field in database
    Private Sub UpdateEmployeeField(employeeId As String, fieldName As String, newValue As String)
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            ' Map display column names to actual database column names
            Dim dbFieldName As String = MapColumnToDatabase(fieldName)

            Dim query As String = $"UPDATE employees SET {dbFieldName} = @value WHERE id = @employeeId"

            Using command As New MySqlCommand(query, conn)
                ' Handle different data types properly
                Select Case fieldName
                    Case "Hourly Rate"
                        command.Parameters.AddWithValue("@value", Decimal.Parse(newValue))
                    Case "Age"
                        command.Parameters.AddWithValue("@value", Integer.Parse(newValue))
                    Case Else
                        command.Parameters.AddWithValue("@value", newValue)
                End Select

                command.Parameters.AddWithValue("@employeeId", employeeId)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Update failed. Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    LoadEmployees() ' Refresh to show original values
                    SetupComboBoxColumns() ' Re-setup combobox columns
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadEmployees() ' Refresh to show original values
            SetupComboBoxColumns() ' Re-setup combobox columns
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Map display column names to database column names
    Private Function MapColumnToDatabase(displayName As String) As String
        Dim mapping As New Dictionary(Of String, String) From {
        {"Position", "position"},
        {"Hourly Rate", "hourlyrate"},
        {"Age", "age"},
        {"Gender", "gender"},
        {"Civil Status", "cstatus"},
        {"Contact", "contact"},
        {"Email", "email"},
        {"Address", "address"}
    }

        Return If(mapping.ContainsKey(displayName), mapping(displayName), displayName.ToLower())
    End Function

    ' Input filtering for numeric fields only
    Private Sub dgvEmployees_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvEmployees.EditingControlShowing
        ' Only handle TextBox controls for specific columns
        If TypeOf e.Control IsNot TextBox Then Return

        Dim columnName As String = dgvEmployees.CurrentCell.OwningColumn.Name
        Dim textBox As TextBox = CType(e.Control, TextBox)

        ' Remove existing handlers to prevent duplicates
        RemoveHandler textBox.KeyPress, AddressOf ContactTextBox_KeyPress
        RemoveHandler textBox.KeyPress, AddressOf NumericTextBox_KeyPress
        RemoveHandler textBox.KeyPress, AddressOf AgeTextBox_KeyPress

        ' Add appropriate handler
        Select Case columnName
            Case "Contact"
                AddHandler textBox.KeyPress, AddressOf ContactTextBox_KeyPress
            Case "Hourly Rate"
                AddHandler textBox.KeyPress, AddressOf NumericTextBox_KeyPress
            Case "Age"
                AddHandler textBox.KeyPress, AddressOf AgeTextBox_KeyPress
        End Select
    End Sub

    Private Sub ContactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Only allow numbers and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limit to 10 digits
        Dim textBox As TextBox = CType(sender, TextBox)
        If textBox.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow numbers, decimal point, and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso CType(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub AgeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Only allow numbers and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Optional: Handle Enter key to move to next cell
    Private Sub dgvEmployees_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEmployees.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not dgvEmployees.CurrentCell.IsInEditMode Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SoftDeleteEmployee(employeeId As String)
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            Dim query As String = "UPDATE employees SET deleted = 1 WHERE id = @employeeId"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@employeeId", employeeId)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadEmployees() ' Refresh the grid to remove the deleted employee
                    SetupComboBoxColumns() ' Re-setup combobox columns
                Else
                    MessageBox.Show("Delete failed. Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvEmployees.SelectedRows(0)
        Dim employeeId As String = selectedRow.Cells("Employee ID").Value.ToString()
        Dim employeeName As String = selectedRow.Cells("Full Name").Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show(
        $"Are you sure you want to delete employee:{vbCrLf}{vbCrLf}{employeeName} ({employeeId})?{vbCrLf}{vbCrLf}This action can be reversed by an administrator.",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            SoftDeleteEmployee(employeeId)
        End If

        ' Clear button selection
        CType(sender, RoundedButton).ClearSelection()
    End Sub

    ' Add these at the class level
    Private Sub seeDeleted_CheckedChanged(sender As Object, e As EventArgs) Handles seeDeleted.CheckedChanged
        ToggleArchiveView(seeDeleted.Checked)
    End Sub

    Private Sub ToggleArchiveView(isArchiveView As Boolean)
        If isArchiveView Then
            ' Archive view - show deleted employees
            btnDelete.Enabled = False
            btnDelete.Visible = False
            btnRestore.Enabled = True
            btnRestore.Visible = True
        Else
            ' Normal view - show active employees
            btnDelete.Enabled = True
            btnDelete.Visible = True
            btnRestore.Enabled = False
            btnRestore.Visible = False
        End If

        LoadEmployees() ' Reload with appropriate filter
        SetupComboBoxColumns() ' Re-setup combobox columns
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        RestoreSelectedEmployees()
        ' Clear button selection
        CType(sender, RoundedButton).ClearSelection()
    End Sub

    Private Sub RestoreSelectedEmployees()
        ' Check if a row is selected
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to restore.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvEmployees.SelectedRows.Count = 1 Then
            ' Single employee restoration
            Dim selectedRow As DataGridViewRow = dgvEmployees.SelectedRows(0)
            Dim employeeId As String = selectedRow.Cells("Employee ID").Value.ToString()
            Dim employeeName As String = selectedRow.Cells("Full Name").Value.ToString()

            Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to restore employee:{vbCrLf}{vbCrLf}{employeeName} ({employeeId})?",
            "Confirm Restoration",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                RestoreEmployee(employeeId)
            End If
        Else
            ' Multiple employees restoration
            Dim employeeCount As Integer = dgvEmployees.SelectedRows.Count
            Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to restore {employeeCount} employees?",
            "Confirm Multiple Restorations",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                RestoreMultipleEmployees()
            End If
        End If
    End Sub

    Private Sub RestoreEmployee(employeeId As String)
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()

            Dim query As String = "UPDATE employees SET deleted = 0 WHERE id = @employeeId"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@employeeId", employeeId)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Employee restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadEmployees() ' Refresh the grid
                    SetupComboBoxColumns() ' Re-setup combobox columns
                Else
                    MessageBox.Show("Restore failed. Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error restoring employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub RestoreMultipleEmployees()
        Dim db As New DatabaseConnection()
        Dim conn As MySqlConnection = Nothing
        Dim transaction As MySqlTransaction = Nothing

        Try
            conn = db.GetConnection()
            conn.Open()
            transaction = conn.BeginTransaction()

            Dim successCount As Integer = 0

            For Each row As DataGridViewRow In dgvEmployees.SelectedRows
                Dim employeeId As String = row.Cells("Employee ID").Value.ToString()

                Dim query As String = "UPDATE employees SET deleted = 0 WHERE id = @employeeId"

                Using command As New MySqlCommand(query, conn, transaction)
                    command.Parameters.AddWithValue("@employeeId", employeeId)
                    successCount += command.ExecuteNonQuery()
                End Using
            Next

            transaction.Commit()

            MessageBox.Show($"Successfully restored {successCount} out of {dgvEmployees.SelectedRows.Count} employees.", "Restoration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEmployees() ' Refresh the grid
            SetupComboBoxColumns() ' Re-setup combobox columns

        Catch ex As Exception
            transaction?.Rollback()
            MessageBox.Show("Error restoring employees: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ApplyArchiveViewStyling()
        If seeDeleted.Checked Then
            ' Archive view - style deleted employees differently
            For Each row As DataGridViewRow In dgvEmployees.Rows
                If Not row.IsNewRow Then
                    row.DefaultCellStyle.BackColor = Color.LavenderBlush
                    row.DefaultCellStyle.ForeColor = Color.Gray
                    row.DefaultCellStyle.Font = New Font(dgvEmployees.Font, FontStyle.Italic)
                End If
            Next
        Else
            ' Normal view - reset styling
            For Each row As DataGridViewRow In dgvEmployees.Rows
                If Not row.IsNewRow Then
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.Black
                    row.DefaultCellStyle.Font = New Font(dgvEmployees.Font, FontStyle.Regular)
                End If
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using addForm As New AddEmployeeForm()
            addForm.StartPosition = FormStartPosition.CenterParent
            Dim result As DialogResult = addForm.ShowDialog(Me)

            If result = DialogResult.OK Then
                ' Refresh the employee list
                LoadEmployees()
                SetupComboBoxColumns()
                MessageBox.Show("New employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        ' Clear button selection
        CType(sender, RoundedButton).ClearSelection()
    End Sub

    ' Navigation methods
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

    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payForm As New AdminPayroll()
        payForm.lblAdminId.Text = Me.lblAdminId.Text
        payForm.welcomelbl.Text = Me.welcomelbl.Text
        payForm.StartPosition = FormStartPosition.Manual
        payForm.Location = Me.Location
        payForm.Show()
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