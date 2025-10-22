<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payslip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RoundedPanel1 = New RoundedPanel()
        position = New Label()
        Label2 = New Label()
        greetings = New Label()
        Label1 = New Label()
        RoundedPanel2 = New RoundedPanel()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel3 = New RoundedPanel()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        pays = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label30 = New Label()
        Label31 = New Label()
        Label29 = New Label()
        Label27 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label26 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        RoundedPanel6 = New RoundedPanel()
        Label33 = New Label()
        Label32 = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label12 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label20 = New Label()
        Label28 = New Label()
        Label14 = New Label()
        Label4 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label5 = New Label()
        btnBack = New Button()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(position)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(greetings)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.ImeMode = ImeMode.Off
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1040, 89)
        RoundedPanel1.TabIndex = 1
        ' 
        ' position
        ' 
        position.Enabled = False
        position.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        position.Location = New Point(847, 46)
        position.Name = "position"
        position.Size = New Size(142, 23)
        position.TabIndex = 1
        position.Text = "Position: Employee"
        ' 
        ' Label2
        ' 
        Label2.AccessibleDescription = ""
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(844, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 23)
        Label2.TabIndex = 3
        Label2.Text = "Employee ID:  EMP-1234"
        ' 
        ' greetings
        ' 
        greetings.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        greetings.Location = New Point(22, 48)
        greetings.Name = "greetings"
        greetings.Size = New Size(106, 22)
        greetings.TabIndex = 2
        greetings.Text = "Welcome Back!"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 23)
        Label1.TabIndex = 1
        Label1.Text = "Employee Portal"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(RoundedButton1)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(179, 131)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(694, 49)
        RoundedPanel2.TabIndex = 2
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
        profile.Location = New Point(518, 5)
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
        attendance.Location = New Point(349, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(168, 37)
        attendance.TabIndex = 2
        attendance.TabStop = False
        attendance.Text = "📆  Attendance"
        attendance.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BorderColor = Color.Gray
        RoundedButton1.BorderRadius = 20
        RoundedButton1.BorderSize = 2
        RoundedButton1.ClickColor = Color.DarkGray
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton1.HoverColor = Color.LightGray
        RoundedButton1.Location = New Point(180, 6)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.SelectedColor = Color.Silver
        RoundedButton1.Size = New Size(168, 37)
        RoundedButton1.TabIndex = 1
        RoundedButton1.TabStop = False
        RoundedButton1.Text = "📄  Payslip"
        RoundedButton1.UseVisualStyleBackColor = True
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
        dashb.Location = New Point(10, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(168, 37)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(DateTimePicker1)
        RoundedPanel3.Controls.Add(Label3)
        RoundedPanel3.Controls.Add(pays)
        RoundedPanel3.Location = New Point(179, 205)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(694, 100)
        RoundedPanel3.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(10, 58)
        DateTimePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonShadow
        Label3.Location = New Point(10, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 23)
        Label3.TabIndex = 5
        Label3.Text = "Choose a month to view your payslip"
        ' 
        ' pays
        ' 
        pays.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pays.Location = New Point(10, 13)
        pays.Name = "pays"
        pays.Size = New Size(174, 23)
        pays.TabIndex = 5
        pays.Text = "Select Payslip Month"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(Label30)
        RoundedPanel4.Controls.Add(Label31)
        RoundedPanel4.Controls.Add(Label29)
        RoundedPanel4.Controls.Add(Label27)
        RoundedPanel4.Controls.Add(Label21)
        RoundedPanel4.Controls.Add(Label22)
        RoundedPanel4.Controls.Add(Label26)
        RoundedPanel4.Controls.Add(Label23)
        RoundedPanel4.Controls.Add(Label24)
        RoundedPanel4.Controls.Add(Label25)
        RoundedPanel4.Controls.Add(Label19)
        RoundedPanel4.Controls.Add(Label18)
        RoundedPanel4.Controls.Add(RoundedPanel6)
        RoundedPanel4.Controls.Add(RoundedPanel5)
        RoundedPanel4.Controls.Add(Label20)
        RoundedPanel4.Controls.Add(Label28)
        RoundedPanel4.Controls.Add(Label14)
        RoundedPanel4.Controls.Add(Label4)
        RoundedPanel4.Controls.Add(Label17)
        RoundedPanel4.Controls.Add(Label15)
        RoundedPanel4.Controls.Add(Label16)
        RoundedPanel4.Controls.Add(Label5)
        RoundedPanel4.Location = New Point(179, 311)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(694, 361)
        RoundedPanel4.TabIndex = 5
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(627, 277)
        Label30.Name = "Label30"
        Label30.Size = New Size(56, 16)
        Label30.TabIndex = 18
        Label30.Text = "₱ 1,571"
        ' 
        ' Label31
        ' 
        Label31.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(438, 275)
        Label31.Name = "Label31"
        Label31.Size = New Size(174, 23)
        Label31.TabIndex = 17
        Label31.Text = "Total Deductions:"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(203, 277)
        Label29.Name = "Label29"
        Label29.Size = New Size(56, 16)
        Label29.TabIndex = 16
        Label29.Text = "₱ 7,700"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(626, 244)
        Label27.Name = "Label27"
        Label27.Size = New Size(44, 16)
        Label27.TabIndex = 15
        Label27.Text = "₱ 567"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(626, 221)
        Label21.Name = "Label21"
        Label21.Size = New Size(44, 16)
        Label21.TabIndex = 14
        Label21.Text = "₱ 234"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(626, 198)
        Label22.Name = "Label22"
        Label22.Size = New Size(44, 16)
        Label22.TabIndex = 13
        Label22.Text = "₱ 770"
        ' 
        ' Label26
        ' 
        Label26.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.ButtonShadow
        Label26.Location = New Point(447, 241)
        Label26.Name = "Label26"
        Label26.Size = New Size(154, 23)
        Label26.TabIndex = 10
        Label26.Text = "Pagibig:"
        ' 
        ' Label23
        ' 
        Label23.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ButtonShadow
        Label23.Location = New Point(447, 218)
        Label23.Name = "Label23"
        Label23.Size = New Size(154, 23)
        Label23.TabIndex = 10
        Label23.Text = "SSS:"
        ' 
        ' Label24
        ' 
        Label24.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.ButtonShadow
        Label24.Location = New Point(448, 196)
        Label24.Name = "Label24"
        Label24.Size = New Size(104, 23)
        Label24.TabIndex = 11
        Label24.Text = "Income Tax :"
        ' 
        ' Label25
        ' 
        Label25.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = SystemColors.ActiveCaptionText
        Label25.Location = New Point(448, 198)
        Label25.Name = "Label25"
        Label25.Size = New Size(153, 23)
        Label25.TabIndex = 12
        Label25.Text = "Basic Earnings"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(203, 218)
        Label19.Name = "Label19"
        Label19.Size = New Size(44, 16)
        Label19.TabIndex = 9
        Label19.Text = "₱ 800"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(203, 195)
        Label18.Name = "Label18"
        Label18.Size = New Size(56, 16)
        Label18.TabIndex = 8
        Label18.Text = "₱ 6,900"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        RoundedPanel6.Controls.Add(Label33)
        RoundedPanel6.Controls.Add(Label32)
        RoundedPanel6.Location = New Point(10, 301)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(672, 37)
        RoundedPanel6.TabIndex = 7
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Century", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(581, 7)
        Label33.Name = "Label33"
        Label33.Size = New Size(74, 21)
        Label33.TabIndex = 18
        Label33.Text = "₱ 6,129"
        ' 
        ' Label32
        ' 
        Label32.Font = New Font("Century", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(26, 7)
        Label32.Name = "Label32"
        Label32.Size = New Size(159, 21)
        Label32.TabIndex = 0
        Label32.Text = "Net Pay"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = SystemColors.ControlLight
        RoundedPanel5.Controls.Add(Label12)
        RoundedPanel5.Controls.Add(Label13)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label11)
        RoundedPanel5.Controls.Add(Label8)
        RoundedPanel5.Controls.Add(Label6)
        RoundedPanel5.Controls.Add(Label9)
        RoundedPanel5.Controls.Add(Label7)
        RoundedPanel5.Location = New Point(9, 57)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(676, 112)
        RoundedPanel5.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonShadow
        Label12.Location = New Point(499, 56)
        Label12.Name = "Label12"
        Label12.Size = New Size(113, 23)
        Label12.TabIndex = 8
        Label12.Text = "Sex:"
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(499, 75)
        Label13.Name = "Label13"
        Label13.Size = New Size(174, 23)
        Label13.TabIndex = 9
        Label13.Text = "Male"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonShadow
        Label10.Location = New Point(499, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 23)
        Label10.TabIndex = 6
        Label10.Text = "Employee Name:"
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(499, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(174, 23)
        Label11.TabIndex = 7
        Label11.Text = "Gian Dela Torre"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonShadow
        Label8.Location = New Point(11, 54)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 23)
        Label8.TabIndex = 5
        Label8.Text = "Position: "
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonShadow
        Label6.Location = New Point(11, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 23)
        Label6.TabIndex = 5
        Label6.Text = "Employee ID:"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(11, 75)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 23)
        Label9.TabIndex = 5
        Label9.Text = "Employee"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(11, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(174, 23)
        Label7.TabIndex = 5
        Label7.Text = "EMP - 1234"
        ' 
        ' Label20
        ' 
        Label20.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(438, 172)
        Label20.Name = "Label20"
        Label20.Size = New Size(174, 23)
        Label20.TabIndex = 5
        Label20.Text = "Deductions"
        ' 
        ' Label28
        ' 
        Label28.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(14, 275)
        Label28.Name = "Label28"
        Label28.Size = New Size(174, 23)
        Label28.TabIndex = 5
        Label28.Text = "Total Earnings:"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(14, 172)
        Label14.Name = "Label14"
        Label14.Size = New Size(174, 23)
        Label14.TabIndex = 5
        Label14.Text = "Earnings"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(14, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 23)
        Label4.TabIndex = 5
        Label4.Text = "Payslip for"
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ButtonShadow
        Label17.Location = New Point(24, 215)
        Label17.Name = "Label17"
        Label17.Size = New Size(154, 23)
        Label17.TabIndex = 5
        Label17.Text = "Overtime Pay:"
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ButtonShadow
        Label15.Location = New Point(25, 193)
        Label15.Name = "Label15"
        Label15.Size = New Size(104, 23)
        Label15.TabIndex = 5
        Label15.Text = "Basic Salary :"
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(25, 195)
        Label16.Name = "Label16"
        Label16.Size = New Size(153, 23)
        Label16.TabIndex = 5
        Label16.Text = "Basic Earnings"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonShadow
        Label5.Location = New Point(12, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(209, 23)
        Label5.TabIndex = 5
        Label5.Text = "Employee Payment Details"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Left
        btnBack.Location = New Point(12, 625)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 8
        btnBack.Text = "Sign Out"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' payslip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Name = "payslip"
        Text = "payslip"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents position As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents greetings As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents pays As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents btnBack As Button
End Class
