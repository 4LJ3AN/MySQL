<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeProfile
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
        RoundedPanel2 = New RoundedPanel()
        checkInbtn = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel6 = New RoundedPanel()
        btnCancel = New Button()
        TextBox1 = New TextBox()
        Label11 = New Label()
        btnSave = New Button()
        btnEdit = New Button()
        hidepass = New CheckBox()
        idbox = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        sufbox = New ComboBox()
        passbox = New TextBox()
        Label10 = New Label()
        cstbox = New ComboBox()
        genbox = New ComboBox()
        Label21 = New Label()
        sufcb = New CheckBox()
        mncb = New CheckBox()
        agebox = New TextBox()
        emabox = New TextBox()
        conbox = New TextBox()
        bdybox = New DateTimePicker()
        lnbox = New TextBox()
        mnbox = New TextBox()
        fnbox = New TextBox()
        Label15 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnBack = New Button()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel2.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(checkInbtn)
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(80, 126)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(858, 49)
        RoundedPanel2.TabIndex = 1
        ' 
        ' checkInbtn
        ' 
        checkInbtn.BorderColor = Color.Gray
        checkInbtn.BorderRadius = 20
        checkInbtn.BorderSize = 2
        checkInbtn.ClickColor = Color.DarkGray
        checkInbtn.FlatStyle = FlatStyle.Flat
        checkInbtn.Font = New Font("Berlin Sans FB", 12F)
        checkInbtn.HoverColor = Color.LightGray
        checkInbtn.Location = New Point(6, 5)
        checkInbtn.Name = "checkInbtn"
        checkInbtn.SelectedColor = Color.Silver
        checkInbtn.Size = New Size(168, 37)
        checkInbtn.TabIndex = 8
        checkInbtn.TabStop = False
        checkInbtn.Text = "☑   Check In"
        checkInbtn.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        profile.BorderColor = Color.Gray
        profile.BorderRadius = 20
        profile.BorderSize = 2
        profile.ClickColor = Color.DarkGray
        profile.FlatStyle = FlatStyle.Flat
        profile.Font = New Font("Berlin Sans FB", 12F)
        profile.HoverColor = Color.LightGray
        profile.Location = New Point(684, 5)
        profile.Name = "profile"
        profile.SelectedColor = Color.Silver
        profile.Size = New Size(168, 37)
        profile.TabIndex = 3
        profile.TabStop = False
        profile.Text = "👤  Profile"
        profile.UseVisualStyleBackColor = True
        ' 
        ' attendance
        ' 
        attendance.BorderColor = Color.Gray
        attendance.BorderRadius = 20
        attendance.BorderSize = 2
        attendance.ClickColor = Color.DarkGray
        attendance.FlatStyle = FlatStyle.Flat
        attendance.Font = New Font("Berlin Sans FB", 12F)
        attendance.HoverColor = Color.LightGray
        attendance.Location = New Point(515, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(168, 37)
        attendance.TabIndex = 2
        attendance.TabStop = False
        attendance.Text = "📆  Attendance"
        attendance.UseVisualStyleBackColor = True
        ' 
        ' payslip
        ' 
        payslip.BorderColor = Color.Gray
        payslip.BorderRadius = 20
        payslip.BorderSize = 2
        payslip.ClickColor = Color.DarkGray
        payslip.FlatStyle = FlatStyle.Flat
        payslip.Font = New Font("Berlin Sans FB", 12F)
        payslip.HoverColor = Color.LightGray
        payslip.Location = New Point(346, 6)
        payslip.Name = "payslip"
        payslip.SelectedColor = Color.Silver
        payslip.Size = New Size(168, 37)
        payslip.TabIndex = 1
        payslip.TabStop = False
        payslip.Text = "📄  Payslip"
        payslip.UseVisualStyleBackColor = True
        ' 
        ' dashb
        ' 
        dashb.BorderColor = Color.Gray
        dashb.BorderRadius = 20
        dashb.BorderSize = 2
        dashb.ClickColor = Color.DarkGray
        dashb.FlatStyle = FlatStyle.Flat
        dashb.Font = New Font("Berlin Sans FB", 12F)
        dashb.HoverColor = Color.LightGray
        dashb.Location = New Point(176, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(168, 37)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(btnCancel)
        RoundedPanel6.Controls.Add(TextBox1)
        RoundedPanel6.Controls.Add(Label11)
        RoundedPanel6.Controls.Add(btnSave)
        RoundedPanel6.Controls.Add(btnEdit)
        RoundedPanel6.Controls.Add(hidepass)
        RoundedPanel6.Controls.Add(idbox)
        RoundedPanel6.Controls.Add(Label13)
        RoundedPanel6.Controls.Add(Label12)
        RoundedPanel6.Controls.Add(sufbox)
        RoundedPanel6.Controls.Add(passbox)
        RoundedPanel6.Controls.Add(Label10)
        RoundedPanel6.Controls.Add(cstbox)
        RoundedPanel6.Controls.Add(genbox)
        RoundedPanel6.Controls.Add(Label21)
        RoundedPanel6.Controls.Add(sufcb)
        RoundedPanel6.Controls.Add(mncb)
        RoundedPanel6.Controls.Add(agebox)
        RoundedPanel6.Controls.Add(emabox)
        RoundedPanel6.Controls.Add(conbox)
        RoundedPanel6.Controls.Add(bdybox)
        RoundedPanel6.Controls.Add(lnbox)
        RoundedPanel6.Controls.Add(mnbox)
        RoundedPanel6.Controls.Add(fnbox)
        RoundedPanel6.Controls.Add(Label15)
        RoundedPanel6.Controls.Add(Label9)
        RoundedPanel6.Controls.Add(Label8)
        RoundedPanel6.Controls.Add(Label7)
        RoundedPanel6.Controls.Add(Label6)
        RoundedPanel6.Controls.Add(Label5)
        RoundedPanel6.Controls.Add(Label4)
        RoundedPanel6.Controls.Add(Label3)
        RoundedPanel6.Controls.Add(Label2)
        RoundedPanel6.Location = New Point(12, 194)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(994, 425)
        RoundedPanel6.TabIndex = 6
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.OrangeRed
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(309, 327)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(174, 48)
        btnCancel.TabIndex = 94
        btnCancel.Text = "❌  Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox1.Location = New Point(671, 19)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(290, 26)
        TextBox1.TabIndex = 93
        TextBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label11.Location = New Point(579, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(76, 24)
        Label11.TabIndex = 92
        Label11.Text = "Position"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.PaleGreen
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(511, 327)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(174, 48)
        btnSave.TabIndex = 91
        btnSave.Text = "💾  Save Info"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.PaleGreen
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(410, 327)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(174, 48)
        btnEdit.TabIndex = 90
        btnEdit.Text = "📝  Edit Info"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' hidepass
        ' 
        hidepass.AutoSize = True
        hidepass.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hidepass.Location = New Point(906, 249)
        hidepass.Name = "hidepass"
        hidepass.Size = New Size(55, 17)
        hidepass.TabIndex = 89
        hidepass.Text = "Show"
        hidepass.UseVisualStyleBackColor = True
        ' 
        ' idbox
        ' 
        idbox.Enabled = False
        idbox.Font = New Font("Microsoft Sans Serif", 12F)
        idbox.Location = New Point(165, 17)
        idbox.Name = "idbox"
        idbox.ReadOnly = True
        idbox.Size = New Size(195, 26)
        idbox.TabIndex = 88
        idbox.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label13.Location = New Point(20, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 24)
        Label13.TabIndex = 85
        Label13.Text = "Employee  ID"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(456, 260)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 23)
        Label12.TabIndex = 84
        Label12.Text = "+63"
        ' 
        ' sufbox
        ' 
        sufbox.DropDownStyle = ComboBoxStyle.DropDownList
        sufbox.Font = New Font("Microsoft Sans Serif", 12F)
        sufbox.FormattingEnabled = True
        sufbox.Items.AddRange(New Object() {"Sr.", "Jr.", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"})
        sufbox.Location = New Point(165, 177)
        sufbox.Name = "sufbox"
        sufbox.Size = New Size(224, 28)
        sufbox.TabIndex = 63
        ' 
        ' passbox
        ' 
        passbox.Font = New Font("Microsoft Sans Serif", 12F)
        passbox.Location = New Point(671, 217)
        passbox.Name = "passbox"
        passbox.Size = New Size(290, 26)
        passbox.TabIndex = 75
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label10.Location = New Point(563, 217)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 24)
        Label10.TabIndex = 74
        Label10.Text = "Password"
        ' 
        ' cstbox
        ' 
        cstbox.DropDownStyle = ComboBoxStyle.DropDownList
        cstbox.Font = New Font("Microsoft Sans Serif", 12F)
        cstbox.FormattingEnabled = True
        cstbox.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        cstbox.Location = New Point(671, 137)
        cstbox.Name = "cstbox"
        cstbox.Size = New Size(224, 28)
        cstbox.TabIndex = 73
        ' 
        ' genbox
        ' 
        genbox.DropDownStyle = ComboBoxStyle.DropDownList
        genbox.Font = New Font("Microsoft Sans Serif", 12F)
        genbox.FormattingEnabled = True
        genbox.Items.AddRange(New Object() {"Male", "Female", "I prefer not to say"})
        genbox.Location = New Point(671, 175)
        genbox.Name = "genbox"
        genbox.Size = New Size(224, 28)
        genbox.TabIndex = 72
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label21.Location = New Point(556, 137)
        Label21.Name = "Label21"
        Label21.Size = New Size(99, 24)
        Label21.TabIndex = 71
        Label21.Text = "Civil Status"
        ' 
        ' sufcb
        ' 
        sufcb.AutoSize = True
        sufcb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sufcb.Location = New Point(395, 188)
        sufcb.Name = "sufcb"
        sufcb.Size = New Size(105, 17)
        sufcb.TabIndex = 70
        sufcb.Text = "I have no Suffix"
        sufcb.UseVisualStyleBackColor = True
        ' 
        ' mncb
        ' 
        mncb.AutoSize = True
        mncb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mncb.Location = New Point(457, 106)
        mncb.Name = "mncb"
        mncb.Size = New Size(144, 17)
        mncb.TabIndex = 69
        mncb.Text = "I have no Middle Name"
        mncb.UseVisualStyleBackColor = True
        ' 
        ' agebox
        ' 
        agebox.Enabled = False
        agebox.Font = New Font("Microsoft Sans Serif", 12F)
        agebox.Location = New Point(671, 97)
        agebox.Name = "agebox"
        agebox.ReadOnly = True
        agebox.Size = New Size(224, 26)
        agebox.TabIndex = 68
        agebox.TabStop = False
        ' 
        ' emabox
        ' 
        emabox.Font = New Font("Microsoft Sans Serif", 12F)
        emabox.Location = New Point(165, 217)
        emabox.Name = "emabox"
        emabox.Size = New Size(290, 26)
        emabox.TabIndex = 67
        ' 
        ' conbox
        ' 
        conbox.Font = New Font("Microsoft Sans Serif", 12F)
        conbox.Location = New Point(495, 257)
        conbox.Name = "conbox"
        conbox.Size = New Size(215, 26)
        conbox.TabIndex = 66
        ' 
        ' bdybox
        ' 
        bdybox.Font = New Font("Microsoft Sans Serif", 12F)
        bdybox.Location = New Point(671, 57)
        bdybox.Name = "bdybox"
        bdybox.Size = New Size(290, 26)
        bdybox.TabIndex = 65
        ' 
        ' lnbox
        ' 
        lnbox.Font = New Font("Microsoft Sans Serif", 12F)
        lnbox.Location = New Point(165, 137)
        lnbox.Name = "lnbox"
        lnbox.Size = New Size(290, 26)
        lnbox.TabIndex = 61
        ' 
        ' mnbox
        ' 
        mnbox.Font = New Font("Microsoft Sans Serif", 12F)
        mnbox.Location = New Point(165, 97)
        mnbox.Name = "mnbox"
        mnbox.Size = New Size(290, 26)
        mnbox.TabIndex = 60
        ' 
        ' fnbox
        ' 
        fnbox.Font = New Font("Microsoft Sans Serif", 12F)
        fnbox.Location = New Point(165, 57)
        fnbox.Name = "fnbox"
        fnbox.Size = New Size(290, 26)
        fnbox.TabIndex = 59
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label15.Location = New Point(610, 97)
        Label15.Name = "Label15"
        Label15.Size = New Size(45, 24)
        Label15.TabIndex = 58
        Label15.Text = "Age"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label9.Location = New Point(80, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 24)
        Label9.TabIndex = 57
        Label9.Text = "E-mail"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label8.Location = New Point(285, 259)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 24)
        Label8.TabIndex = 56
        Label8.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label7.Location = New Point(88, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 24)
        Label7.TabIndex = 55
        Label7.Text = "Suffix"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label6.Location = New Point(581, 175)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 24)
        Label6.TabIndex = 54
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label5.Location = New Point(572, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 24)
        Label5.TabIndex = 53
        Label5.Text = "Birthdate"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label4.Location = New Point(44, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 24)
        Label4.TabIndex = 52
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label3.Location = New Point(20, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 24)
        Label3.TabIndex = 51
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label2.Location = New Point(42, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 24)
        Label2.TabIndex = 50
        Label2.Text = "First Name"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Left
        btnBack.Location = New Point(12, 625)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 7
        btnBack.Text = "Sign Out"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(positionlbl)
        RoundedPanel1.Controls.Add(empIDlbl)
        RoundedPanel1.Controls.Add(welcomelbl)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Location = New Point(12, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(994, 97)
        RoundedPanel1.TabIndex = 8
        ' 
        ' positionlbl
        ' 
        positionlbl.AutoSize = True
        positionlbl.Enabled = False
        positionlbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        positionlbl.Location = New Point(772, 52)
        positionlbl.Name = "positionlbl"
        positionlbl.Size = New Size(123, 17)
        positionlbl.TabIndex = 1
        positionlbl.Text = "Position: Employee"
        ' 
        ' empIDlbl
        ' 
        empIDlbl.AccessibleDescription = ""
        empIDlbl.AutoSize = True
        empIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbl.Location = New Point(770, 19)
        empIDlbl.Name = "empIDlbl"
        empIDlbl.Size = New Size(165, 20)
        empIDlbl.TabIndex = 3
        empIDlbl.Text = "Employee ID: EMP1234"
        ' 
        ' welcomelbl
        ' 
        welcomelbl.AutoSize = True
        welcomelbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        welcomelbl.Location = New Point(19, 52)
        welcomelbl.Name = "welcomelbl"
        welcomelbl.Size = New Size(100, 17)
        welcomelbl.TabIndex = 2
        welcomelbl.Text = "Welcome Back!"
        welcomelbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 23)
        Label1.TabIndex = 1
        Label1.Text = "Employee Portal"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EmployeeProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel2)
        Name = "EmployeeProfile"
        Text = "Dashboard"
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents profile As RoundedButton
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents btnBack As Button
    Friend WithEvents checkInbtn As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents sufbox As ComboBox
    Friend WithEvents passbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cstbox As ComboBox
    Friend WithEvents genbox As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents sufcb As CheckBox
    Friend WithEvents mncb As CheckBox
    Friend WithEvents agebox As TextBox
    Friend WithEvents emabox As TextBox
    Friend WithEvents conbox As TextBox
    Friend WithEvents bdybox As DateTimePicker
    Friend WithEvents lnbox As TextBox
    Friend WithEvents mnbox As TextBox
    Friend WithEvents fnbox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idbox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents hidepass As CheckBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As Button
End Class
