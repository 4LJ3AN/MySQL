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
        btnBack = New Button()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel2.SuspendLayout()
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
        RoundedPanel6.Location = New Point(86, 227)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(846, 366)
        RoundedPanel6.TabIndex = 6
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
        positionlbl.Location = New Point(812, 52)
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
        empIDlbl.Location = New Point(810, 19)
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
End Class
