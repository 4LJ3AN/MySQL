<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        RoundedPanel6 = New RoundedPanel()
        cmbPosition = New ComboBox()
        Label1 = New Label()
        btnCancel = New Button()
        Label11 = New Label()
        btnSave = New Button()
        Label13 = New Label()
        Label12 = New Label()
        cmbSuffix = New ComboBox()
        cmbCivilStatus = New ComboBox()
        cmbGender = New ComboBox()
        Label21 = New Label()
        sufcb = New CheckBox()
        mncb = New CheckBox()
        txtAge = New TextBox()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        dtpBirthday = New DateTimePicker()
        txtLName = New TextBox()
        txtMName = New TextBox()
        txtFName = New TextBox()
        Label15 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        lblHourlyRate = New Label()
        Label10 = New Label()
        RoundedPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(Label10)
        RoundedPanel6.Controls.Add(lblHourlyRate)
        RoundedPanel6.Controls.Add(cmbPosition)
        RoundedPanel6.Controls.Add(Label1)
        RoundedPanel6.Controls.Add(btnCancel)
        RoundedPanel6.Controls.Add(Label11)
        RoundedPanel6.Controls.Add(btnSave)
        RoundedPanel6.Controls.Add(Label13)
        RoundedPanel6.Controls.Add(Label12)
        RoundedPanel6.Controls.Add(cmbSuffix)
        RoundedPanel6.Controls.Add(cmbCivilStatus)
        RoundedPanel6.Controls.Add(cmbGender)
        RoundedPanel6.Controls.Add(Label21)
        RoundedPanel6.Controls.Add(sufcb)
        RoundedPanel6.Controls.Add(mncb)
        RoundedPanel6.Controls.Add(txtAge)
        RoundedPanel6.Controls.Add(txtEmail)
        RoundedPanel6.Controls.Add(txtContact)
        RoundedPanel6.Controls.Add(dtpBirthday)
        RoundedPanel6.Controls.Add(txtLName)
        RoundedPanel6.Controls.Add(txtMName)
        RoundedPanel6.Controls.Add(txtFName)
        RoundedPanel6.Controls.Add(Label15)
        RoundedPanel6.Controls.Add(Label9)
        RoundedPanel6.Controls.Add(Label8)
        RoundedPanel6.Controls.Add(Label7)
        RoundedPanel6.Controls.Add(Label6)
        RoundedPanel6.Controls.Add(Label5)
        RoundedPanel6.Controls.Add(Label4)
        RoundedPanel6.Controls.Add(Label3)
        RoundedPanel6.Controls.Add(Label2)
        RoundedPanel6.Location = New Point(12, 12)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(760, 550)
        RoundedPanel6.TabIndex = 0
        ' 
        ' cmbPosition
        ' 
        cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPosition.Font = New Font("Microsoft Sans Serif", 12F)
        cmbPosition.FormattingEnabled = True
        cmbPosition.Items.AddRange(New Object() {"Cashier", "Stock Clerk", "Department Manager", "Custodian", "Food Preparation Worker", "Shopping Cart Attendant", "Pharmacist", "Front-End Manager", "Produce Clerk", "Meat and Seafood Clerk", "Bakery Clerk"})
        cmbPosition.Location = New Point(520, 20)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(200, 28)
        cmbPosition.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label1.Location = New Point(150, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 24)
        Label1.TabIndex = 95
        Label1.Text = "(Auto-generated ID)"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.OrangeRed
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(400, 480)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 40)
        btnCancel.TabIndex = 15
        btnCancel.Text = "❌  Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label11.Location = New Point(400, 20)
        Label11.Name = "Label11"
        Label11.Size = New Size(76, 24)
        Label11.TabIndex = 92
        Label11.Text = "Position"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.PaleGreen
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(200, 480)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 40)
        btnSave.TabIndex = 14
        btnSave.Text = "💾  Add"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label13.Location = New Point(20, 20)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 24)
        Label13.TabIndex = 85
        Label13.Text = "Employee  ID"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(200, 329)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 23)
        Label12.TabIndex = 84
        Label12.Text = "+63"
        ' 
        ' cmbSuffix
        ' 
        cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSuffix.Font = New Font("Microsoft Sans Serif", 12F)
        cmbSuffix.FormattingEnabled = True
        cmbSuffix.Items.AddRange(New Object() {"Sr.", "Jr.", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"})
        cmbSuffix.Location = New Point(150, 240)
        cmbSuffix.Name = "cmbSuffix"
        cmbSuffix.Size = New Size(200, 28)
        cmbSuffix.TabIndex = 6
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.Font = New Font("Microsoft Sans Serif", 12F)
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        cmbCivilStatus.Location = New Point(520, 200)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(200, 28)
        cmbCivilStatus.TabIndex = 10
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Microsoft Sans Serif", 12F)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "I prefer not to say"})
        cmbGender.Location = New Point(520, 160)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(200, 28)
        cmbGender.TabIndex = 9
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label21.Location = New Point(400, 200)
        Label21.Name = "Label21"
        Label21.Size = New Size(99, 24)
        Label21.TabIndex = 71
        Label21.Text = "Civil Status"
        ' 
        ' sufcb
        ' 
        sufcb.AutoSize = True
        sufcb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sufcb.Location = New Point(360, 248)
        sufcb.Name = "sufcb"
        sufcb.Size = New Size(105, 17)
        sufcb.TabIndex = 7
        sufcb.Text = "I have no Suffix"
        sufcb.UseVisualStyleBackColor = True
        ' 
        ' mncb
        ' 
        mncb.AutoSize = True
        mncb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mncb.Location = New Point(360, 128)
        mncb.Name = "mncb"
        mncb.Size = New Size(144, 17)
        mncb.TabIndex = 3
        mncb.Text = "I have no Middle Name"
        mncb.UseVisualStyleBackColor = True
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Microsoft Sans Serif", 12F)
        txtAge.Location = New Point(571, 120)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(149, 26)
        txtAge.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Microsoft Sans Serif", 12F)
        txtEmail.Location = New Point(150, 280)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(290, 26)
        txtEmail.TabIndex = 11
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Microsoft Sans Serif", 12F)
        txtContact.Location = New Point(240, 326)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(200, 26)
        txtContact.TabIndex = 13
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Font = New Font("Microsoft Sans Serif", 12F)
        dtpBirthday.Location = New Point(520, 80)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(200, 26)
        dtpBirthday.TabIndex = 5
        ' 
        ' txtLName
        ' 
        txtLName.Font = New Font("Microsoft Sans Serif", 12F)
        txtLName.Location = New Point(150, 200)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(200, 26)
        txtLName.TabIndex = 4
        ' 
        ' txtMName
        ' 
        txtMName.Font = New Font("Microsoft Sans Serif", 12F)
        txtMName.Location = New Point(150, 160)
        txtMName.Name = "txtMName"
        txtMName.Size = New Size(200, 26)
        txtMName.TabIndex = 2
        ' 
        ' txtFName
        ' 
        txtFName.Font = New Font("Microsoft Sans Serif", 12F)
        txtFName.Location = New Point(150, 120)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(200, 26)
        txtFName.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label15.Location = New Point(520, 120)
        Label15.Name = "Label15"
        Label15.Size = New Size(45, 24)
        Label15.TabIndex = 58
        Label15.Text = "Age"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label9.Location = New Point(80, 280)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 24)
        Label9.TabIndex = 57
        Label9.Text = "E-mail"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label8.Location = New Point(42, 326)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 24)
        Label8.TabIndex = 56
        Label8.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label7.Location = New Point(80, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 24)
        Label7.TabIndex = 55
        Label7.Text = "Suffix"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label6.Location = New Point(440, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 24)
        Label6.TabIndex = 54
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label5.Location = New Point(430, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 24)
        Label5.TabIndex = 53
        Label5.Text = "Birthdate"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label4.Location = New Point(44, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 24)
        Label4.TabIndex = 52
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label3.Location = New Point(20, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 24)
        Label3.TabIndex = 51
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label2.Location = New Point(42, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 24)
        Label2.TabIndex = 50
        Label2.Text = "First Name"
        ' 
        ' lblHourlyRate
        ' 
        lblHourlyRate.AutoSize = True
        lblHourlyRate.Font = New Font("Microsoft Sans Serif", 14.25F)
        lblHourlyRate.Location = New Point(150, 61)
        lblHourlyRate.Name = "lblHourlyRate"
        lblHourlyRate.Size = New Size(175, 24)
        lblHourlyRate.TabIndex = 96
        lblHourlyRate.Text = "(Auto-generated ID)"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label10.Location = New Point(31, 61)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 24)
        Label10.TabIndex = 97
        Label10.Text = "Base Rates"
        ' 
        ' AddEmployeeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 574)
        Controls.Add(RoundedPanel6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEmployeeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Employee"
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents sufcb As CheckBox
    Friend WithEvents mncb As CheckBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHourlyRate As Label
End Class