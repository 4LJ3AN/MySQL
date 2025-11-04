Imports MySQL.Data.MySqlClient

Public Class EmployeeProfile
    Private originalData As New Dictionary(Of String, Object)()

    Private Sub EmployeeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idbox.Text = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        LoadEmployeeData()
        InitializePasswordVisibility()
        SetEditMode(False) ' Start in read-only mode
    End Sub

    ' ===========================================================
    ' = EDIT/SAVE/CANCEL FUNCTIONALITY (UPDATED)
    ' ===========================================================
    Private Sub SetEditMode(editMode As Boolean)
        ' TextBoxes
        fnbox.Enabled = editMode
        mnbox.Enabled = editMode AndAlso Not mncb.Checked
        lnbox.Enabled = editMode
        agebox.Enabled = editMode
        emabox.Enabled = editMode
        conbox.Enabled = editMode
        passbox.Enabled = editMode

        ' ComboBoxes
        sufbox.Enabled = editMode AndAlso Not sufcb.Checked
        genbox.Enabled = editMode
        cstbox.Enabled = editMode

        ' DatePicker
        bdybox.Enabled = editMode

        ' CheckBoxes
        mncb.Enabled = editMode
        sufcb.Enabled = editMode
        hidepass.Enabled = editMode

        ' Button visibility
        btnEdit.Visible = Not editMode
        btnSave.Visible = editMode
        btnCancel.Visible = editMode

        ' Set background colors to indicate edit mode
        Dim backColor As Color = If(editMode, SystemColors.Window, SystemColors.Control)
        fnbox.BackColor = backColor
        If mnbox.Enabled Then mnbox.BackColor = backColor
        lnbox.BackColor = backColor
        agebox.BackColor = backColor
        emabox.BackColor = backColor
        conbox.BackColor = backColor
        passbox.BackColor = backColor
        sufbox.BackColor = backColor
        genbox.BackColor = backColor
        cstbox.BackColor = backColor
        bdybox.BackColor = backColor

        ' Reset password visibility when entering edit mode
        If editMode Then
            passbox.PasswordChar = "●" ' Ensure password is hidden when starting to edit
            hidepass.Checked = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Save original data for cancel operation
        SaveOriginalData()
        SetEditMode(True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateAllFields() Then
            Exit Sub
        End If

        If UpdateEmployeeData() Then
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetEditMode(False)
            ResetPasswordVisibility()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Restore original data
        RestoreOriginalData()
        SetEditMode(False)
        ResetPasswordVisibility()
    End Sub

    ' ===========================================================
    ' = RESET PASSWORD VISIBILITY
    ' ===========================================================
    Private Sub ResetPasswordVisibility()
        ' Always hide password when not in edit mode
        If Not btnEdit.Visible Then ' If we're in view mode
            passbox.PasswordChar = "●" ' Hide password
            hidepass.Checked = False
        End If
    End Sub

    Private Sub SaveOriginalData()
        originalData.Clear()
        originalData("fname") = fnbox.Text
        originalData("mname") = mnbox.Text
        originalData("lname") = lnbox.Text
        originalData("suffix") = If(sufbox.SelectedItem IsNot Nothing, sufbox.SelectedItem.ToString(), "")
        originalData("bday") = bdybox.Value
        originalData("age") = agebox.Text
        originalData("gender") = If(genbox.SelectedItem IsNot Nothing, genbox.SelectedItem.ToString(), "")
        originalData("cstatus") = If(cstbox.SelectedItem IsNot Nothing, cstbox.SelectedItem.ToString(), "")
        originalData("email") = emabox.Text
        originalData("contact") = conbox.Text
        originalData("password") = passbox.Text
        originalData("mncb") = mncb.Checked
        originalData("sufcb") = sufcb.Checked
    End Sub

    Private Sub RestoreOriginalData()
        If originalData.Count > 0 Then
            fnbox.Text = originalData("fname").ToString()
            mnbox.Text = originalData("mname").ToString()
            lnbox.Text = originalData("lname").ToString()

            ' Restore suffix
            If Not String.IsNullOrEmpty(originalData("suffix").ToString()) Then
                sufbox.SelectedItem = originalData("suffix").ToString()
            Else
                sufbox.SelectedIndex = -1
            End If

            bdybox.Value = Convert.ToDateTime(originalData("bday"))
            agebox.Text = originalData("age").ToString()

            ' Restore gender
            If Not String.IsNullOrEmpty(originalData("gender").ToString()) Then
                genbox.SelectedItem = originalData("gender").ToString()
            End If

            ' Restore civil status
            If Not String.IsNullOrEmpty(originalData("cstatus").ToString()) Then
                cstbox.SelectedItem = originalData("cstatus").ToString()
            End If

            emabox.Text = originalData("email").ToString()
            conbox.Text = originalData("contact").ToString()
            passbox.Text = originalData("password").ToString()

            ' Restore checkbox states
            mncb.Checked = Convert.ToBoolean(originalData("mncb"))
            sufcb.Checked = Convert.ToBoolean(originalData("sufcb"))
        End If
    End Sub

    ' ===========================================================
    ' = SUFFIX CHECKBOX LOGIC (FIXED)
    ' ===========================================================
    Private Sub sufcb_CheckedChanged(sender As Object, e As EventArgs) Handles sufcb.CheckedChanged
        If sufcb.Checked Then
            sufbox.Enabled = False
            sufbox.SelectedIndex = -1 ' Clear selection
            sufbox.BackColor = SystemColors.Control
        Else
            sufbox.Enabled = True
            sufbox.BackColor = SystemColors.Window
        End If
    End Sub

    ' ===========================================================
    ' = LOAD EMPLOYEE DATA
    ' ===========================================================
    Private Sub LoadEmployeeData()
        Dim employeeId As String = idbox.Text.Trim()

        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                    SELECT fname, mname, lname, suffix, bday, age, gender, cstatus, email, contact, password
                    FROM employees 
                    WHERE id = @empid;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empid", employeeId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Load basic information
                            fnbox.Text = If(Not IsDBNull(reader("fname")), reader("fname").ToString(), "")
                            mnbox.Text = If(Not IsDBNull(reader("mname")), reader("mname").ToString(), "")
                            lnbox.Text = If(Not IsDBNull(reader("lname")), reader("lname").ToString(), "")

                            ' Handle suffix and suffix checkbox
                            If Not IsDBNull(reader("suffix")) AndAlso Not String.IsNullOrEmpty(reader("suffix").ToString()) Then
                                sufbox.SelectedItem = reader("suffix").ToString()
                                sufcb.Checked = False ' Has suffix, so checkbox unchecked
                            Else
                                sufbox.SelectedIndex = -1
                                sufcb.Checked = True ' No suffix, so checkbox checked
                            End If

                            ' Handle middle name checkbox
                            If String.IsNullOrEmpty(mnbox.Text) Then
                                mncb.Checked = True
                                mnbox.Enabled = False
                                mnbox.Text = ""
                            Else
                                mncb.Checked = False
                            End If

                            ' Load personal information
                            If Not IsDBNull(reader("bday")) Then
                                bdybox.Value = Convert.ToDateTime(reader("bday"))
                            End If

                            agebox.Text = If(Not IsDBNull(reader("age")), reader("age").ToString(), "")

                            ' Load gender
                            If Not IsDBNull(reader("gender")) Then
                                For Each item As Object In genbox.Items
                                    If item.ToString() = reader("gender").ToString() Then
                                        genbox.SelectedItem = item
                                        Exit For
                                    End If
                                Next
                            End If

                            ' Load civil status
                            If Not IsDBNull(reader("cstatus")) Then
                                For Each item As Object In cstbox.Items
                                    If item.ToString() = reader("cstatus").ToString() Then
                                        cstbox.SelectedItem = item
                                        Exit For
                                    End If
                                Next
                            End If

                            ' Load contact information
                            emabox.Text = If(Not IsDBNull(reader("email")), reader("email").ToString(), "")
                            conbox.Text = If(Not IsDBNull(reader("contact")), reader("contact").ToString(), "")

                            ' Load password
                            passbox.Text = If(Not IsDBNull(reader("password")), reader("password").ToString(), "")
                        Else
                            MessageBox.Show("Employee data not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================================================
    ' = PASSWORD VISIBILITY TOGGLE
    ' ===========================================================
    Private Sub InitializePasswordVisibility()
        passbox.PasswordChar = "●" ' Bullet character for password
        hidepass.Checked = False
    End Sub

    Private Sub hidepass_CheckedChanged(sender As Object, e As EventArgs) Handles hidepass.CheckedChanged
        If hidepass.Checked Then
            passbox.PasswordChar = ControlChars.NullChar ' Show password
        Else
            passbox.PasswordChar = "●" ' Hide password
        End If
    End Sub

    ' ===========================================================
    ' = MIDDLE NAME CHECKBOX LOGIC
    ' ===========================================================
    Private Sub mncb_CheckedChanged(sender As Object, e As EventArgs) Handles mncb.CheckedChanged
        If mncb.Checked Then
            mnbox.Enabled = False
            mnbox.Text = ""
            mnbox.BackColor = SystemColors.Control
        Else
            mnbox.Enabled = True
            mnbox.BackColor = SystemColors.Window
        End If
    End Sub

    ' ===========================================================
    ' = VALIDATION FUNCTIONS
    ' ===========================================================
    Private Function ValidateNames() As Boolean
        ' First Name validation
        If String.IsNullOrWhiteSpace(fnbox.Text) Then
            MessageBox.Show("Please enter first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fnbox.Focus()
            Return False
        End If

        If fnbox.Text.Length < 2 Then
            MessageBox.Show("First name must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fnbox.Focus()
            Return False
        End If

        ' Check if first name contains only valid characters
        If Not ContainsOnlyValidNameCharacters(fnbox.Text) Then
            MessageBox.Show("First name can only contain letters, spaces, apostrophes, and hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fnbox.Focus()
            Return False
        End If

        ' Last Name validation
        If String.IsNullOrWhiteSpace(lnbox.Text) Then
            MessageBox.Show("Please enter last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lnbox.Focus()
            Return False
        End If

        If lnbox.Text.Length < 2 Then
            MessageBox.Show("Last name must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lnbox.Focus()
            Return False
        End If

        ' Check if last name contains only valid characters
        If Not ContainsOnlyValidNameCharacters(lnbox.Text) Then
            MessageBox.Show("Last name can only contain letters, spaces, apostrophes, and hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lnbox.Focus()
            Return False
        End If

        ' Middle Name validation (only if provided)
        If mnbox.Enabled AndAlso Not String.IsNullOrWhiteSpace(mnbox.Text) Then
            If mnbox.Text.Length < 2 Then
                MessageBox.Show("Middle name must be at least 2 characters long if provided.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mnbox.Focus()
                Return False
            End If

            ' Check if middle name contains only valid characters
            If Not ContainsOnlyValidNameCharacters(mnbox.Text) Then
                MessageBox.Show("Middle name can only contain letters, spaces, apostrophes, and hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mnbox.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function ContainsOnlyValidNameCharacters(text As String) As Boolean
        For Each c As Char In text
            If Not (Char.IsLetter(c) OrElse c = " "c OrElse c = "'"c OrElse c = "-"c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ValidateEmail() As Boolean
        If String.IsNullOrWhiteSpace(emabox.Text) Then
            MessageBox.Show("Please enter email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            emabox.Focus()
            Return False
        End If

        Try
            Dim email As New System.Net.Mail.MailAddress(emabox.Text)
            If email.Address <> emabox.Text.Trim() Then
                Throw New FormatException()
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            emabox.Focus()
            Return False
        End Try

        Return True
    End Function

    ' ===========================================================
    ' = NAME FIELD VALIDATION AND CAPITALIZATION
    ' ===========================================================
    Private Sub NameField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fnbox.KeyPress, mnbox.KeyPress, lnbox.KeyPress
        ' Allow only letters, spaces, apostrophes, hyphens, and backspace
        If Not Char.IsLetter(e.KeyChar) AndAlso
       e.KeyChar <> " "c AndAlso
       e.KeyChar <> "'"c AndAlso
       e.KeyChar <> "-"c AndAlso
       e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub NameField_Leave(sender As Object, e As EventArgs) Handles fnbox.Leave, mnbox.Leave, lnbox.Leave
        ' Auto-capitalize each word when leaving the field
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If textBox.Enabled AndAlso Not String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Text = CapitalizeWords(textBox.Text.Trim())
        End If
    End Sub

    Private Function CapitalizeWords(input As String) As String
        If String.IsNullOrWhiteSpace(input) Then Return input

        Dim words As String() = input.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim capitalizedWords As New List(Of String)()

        For Each word As String In words
            If word.Length > 0 Then
                ' Capitalize first letter, keep the rest as-is
                Dim capitalizedWord As String = Char.ToUpper(word(0)) & word.Substring(1).ToLower()
                capitalizedWords.Add(capitalizedWord)
            End If
        Next

        Return String.Join(" ", capitalizedWords)
    End Function

    ' ===========================================================
    ' = CONTACT NUMBER INPUT VALIDATION (SIMPLIFIED)
    ' ===========================================================

    Private Sub conbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conbox.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            Return
        End If

        ' Limit to 10 digits
        If Char.IsDigit(e.KeyChar) AndAlso conbox.Text.Length >= 10 Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub conbox_TextChanged(sender As Object, e As EventArgs) Handles conbox.TextChanged
        ' No auto-formatting, just plain digits
    End Sub

    Private Function ValidatePhoneNumber() As Boolean
        If String.IsNullOrWhiteSpace(conbox.Text) Then
            MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conbox.Focus()
            Return False
        End If

        ' Check if it's exactly 10 digits
        If conbox.Text.Length <> 10 Then
            MessageBox.Show("Phone number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conbox.Focus()
            Return False
        End If

        ' Check if it starts with 9
        If Not conbox.Text.StartsWith("9") Then
            MessageBox.Show("Phone number must start with 9.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conbox.Focus()
            Return False
        End If

        ' Check if all characters are digits
        If Not conbox.Text.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Phone number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conbox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ValidatePassword() As Boolean
        If String.IsNullOrWhiteSpace(passbox.Text) Then
            MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            passbox.Focus()
            Return False
        End If

        If passbox.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            passbox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ValidateAllFields() As Boolean
        Return ValidateNames() AndAlso ValidateEmail() AndAlso ValidatePhoneNumber() AndAlso ValidatePassword()
    End Function

    ' ===========================================================
    ' = UPDATE EMPLOYEE DATA IN DATABASE
    ' ===========================================================
    Private Function UpdateEmployeeData() As Boolean
        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                    UPDATE employees 
                    SET fname = @fname, 
                        mname = @mname, 
                        lname = @lname, 
                        suffix = @suffix, 
                        bday = @bday, 
                        age = @age, 
                        gender = @gender, 
                        cstatus = @cstatus, 
                        email = @email, 
                        contact = @contact, 
                        password = @password
                    WHERE id = @empid;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empid", idbox.Text.Trim())
                    cmd.Parameters.AddWithValue("@fname", fnbox.Text.Trim())

                    ' Handle middle name (null if checkbox is checked or empty)
                    If mncb.Checked OrElse String.IsNullOrWhiteSpace(mnbox.Text) Then
                        cmd.Parameters.AddWithValue("@mname", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@mname", mnbox.Text.Trim())
                    End If

                    cmd.Parameters.AddWithValue("@lname", lnbox.Text.Trim())

                    ' Handle suffix (null if checkbox is checked or not selected)
                    If sufcb.Checked OrElse sufbox.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(sufbox.SelectedItem.ToString()) Then
                        cmd.Parameters.AddWithValue("@suffix", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@suffix", sufbox.SelectedItem.ToString())
                    End If

                    cmd.Parameters.AddWithValue("@bday", bdybox.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(agebox.Text))
                    cmd.Parameters.AddWithValue("@gender", If(genbox.SelectedItem IsNot Nothing, genbox.SelectedItem.ToString(), ""))
                    cmd.Parameters.AddWithValue("@cstatus", If(cstbox.SelectedItem IsNot Nothing, cstbox.SelectedItem.ToString(), ""))
                    cmd.Parameters.AddWithValue("@email", emabox.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", conbox.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", passbox.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ===========================================================
    ' = AUTO-CALCULATE AGE FROM BIRTHDAY
    ' ===========================================================
    Private Sub bdybox_ValueChanged(sender As Object, e As EventArgs) Handles bdybox.ValueChanged
        CalculateAge()
    End Sub

    Private Sub CalculateAge()
        Dim today As Date = Date.Today
        Dim birthDate As Date = bdybox.Value
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust age if birthday hasn't occurred this year
        If today.Month < birthDate.Month OrElse (today.Month = birthDate.Month AndAlso today.Day < birthDate.Day) Then
            age -= 1
        End If

        agebox.Text = age.ToString()
    End Sub

    ' ===========================================================
    ' = FORM NAVIGATION
    ' ===========================================================
    Private Sub payslip_Click(sender As Object, e As EventArgs) Handles payslip.Click
        Dim payslipForm As New EmployeePayslip()
        payslipForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        payslipForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        payslipForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        payslipForm.StartPosition = FormStartPosition.Manual
        payslipForm.Location = Me.Location
        payslipForm.Show()
        Me.Hide()
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empDashboardForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empDashboardForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        attendanceForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        attendanceForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub checkInbtn_Click_1(sender As Object, e As EventArgs) Handles checkInbtn.Click
        Dim empCheckInForm As New EmployeeCheckIn()
        empCheckInForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empCheckInForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empCheckInForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empCheckInForm.StartPosition = FormStartPosition.Manual
        empCheckInForm.Location = Me.Location
        empCheckInForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location
        landing.Show()
        Close()
    End Sub
End Class