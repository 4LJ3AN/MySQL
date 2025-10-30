<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeCheckIn
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
        RoundedPanel1 = New RoundedPanel()
        position = New Label()
        empIDlbl = New Label()
        greetings = New Label()
        Label1 = New Label()
        RoundedPanel2 = New RoundedPanel()
        RoundedButton1 = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel6 = New RoundedPanel()
        btnCheckIn = New Button()
        lblHoursWorked = New Label()
        lblCheckOutTime = New Label()
        lblCheckInTime = New Label()
        lblStatus = New Label()
        lblCurrentTime = New Label()
        lblCurrentDate = New Label()
        btnBack = New Button()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(position)
        RoundedPanel1.Controls.Add(empIDlbl)
        RoundedPanel1.Controls.Add(greetings)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Location = New Point(12, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(994, 97)
        RoundedPanel1.TabIndex = 0
        ' 
        ' position
        ' 
        position.Enabled = False
        position.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        position.Location = New Point(812, 52)
        position.Name = "position"
        position.Size = New Size(142, 23)
        position.TabIndex = 1
        position.Text = "Position: Employee"
        ' 
        ' empIDlbl
        ' 
        empIDlbl.AccessibleDescription = ""
        empIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbl.Location = New Point(810, 19)
        empIDlbl.Name = "empIDlbl"
        empIDlbl.Size = New Size(167, 23)
        empIDlbl.TabIndex = 3
        empIDlbl.Text = "Employee ID: EM-1234"
        ' 
        ' greetings
        ' 
        greetings.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        greetings.Location = New Point(19, 52)
        greetings.Name = "greetings"
        greetings.Size = New Size(100, 22)
        greetings.TabIndex = 2
        greetings.Text = "Welcome Back!"
        greetings.TextAlign = ContentAlignment.MiddleLeft
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
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(RoundedButton1)
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(80, 126)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(858, 49)
        RoundedPanel2.TabIndex = 1
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
        RoundedButton1.Location = New Point(6, 5)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.SelectedColor = Color.Silver
        RoundedButton1.Size = New Size(168, 37)
        RoundedButton1.TabIndex = 8
        RoundedButton1.TabStop = False
        RoundedButton1.Text = "☑   Check In"
        RoundedButton1.UseVisualStyleBackColor = True
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
        RoundedPanel6.Controls.Add(btnCheckIn)
        RoundedPanel6.Controls.Add(lblHoursWorked)
        RoundedPanel6.Controls.Add(lblCheckOutTime)
        RoundedPanel6.Controls.Add(lblCheckInTime)
        RoundedPanel6.Controls.Add(lblStatus)
        RoundedPanel6.Controls.Add(lblCurrentTime)
        RoundedPanel6.Controls.Add(lblCurrentDate)
        RoundedPanel6.Location = New Point(137, 209)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(744, 365)
        RoundedPanel6.TabIndex = 6
        ' 
        ' btnCheckIn
        ' 
        btnCheckIn.BackColor = Color.LawnGreen
        btnCheckIn.FlatStyle = FlatStyle.Popup
        btnCheckIn.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCheckIn.Location = New Point(258, 290)
        btnCheckIn.Name = "btnCheckIn"
        btnCheckIn.Size = New Size(229, 52)
        btnCheckIn.TabIndex = 6
        btnCheckIn.TabStop = False
        btnCheckIn.Text = "Check-In"
        btnCheckIn.UseVisualStyleBackColor = False
        ' 
        ' lblHoursWorked
        ' 
        lblHoursWorked.Location = New Point(35, 298)
        lblHoursWorked.Name = "lblHoursWorked"
        lblHoursWorked.Size = New Size(82, 22)
        lblHoursWorked.TabIndex = 5
        lblHoursWorked.Text = "hrsWorked"
        lblHoursWorked.Visible = False
        ' 
        ' lblCheckOutTime
        ' 
        lblCheckOutTime.Location = New Point(35, 276)
        lblCheckOutTime.Name = "lblCheckOutTime"
        lblCheckOutTime.Size = New Size(138, 22)
        lblCheckOutTime.TabIndex = 4
        lblCheckOutTime.Text = "checkOutTime"
        lblCheckOutTime.Visible = False
        ' 
        ' lblCheckInTime
        ' 
        lblCheckInTime.Location = New Point(35, 254)
        lblCheckInTime.Name = "lblCheckInTime"
        lblCheckInTime.Size = New Size(96, 22)
        lblCheckInTime.TabIndex = 3
        lblCheckInTime.Text = "checkInTime"
        lblCheckInTime.Visible = False
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(35, 320)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(61, 22)
        lblStatus.TabIndex = 2
        lblStatus.Text = "status"
        lblStatus.Visible = False
        ' 
        ' lblCurrentTime
        ' 
        lblCurrentTime.AutoSize = True
        lblCurrentTime.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCurrentTime.Location = New Point(19, 63)
        lblCurrentTime.Name = "lblCurrentTime"
        lblCurrentTime.Size = New Size(215, 39)
        lblCurrentTime.TabIndex = 1
        lblCurrentTime.Text = "currentTime"
        ' 
        ' lblCurrentDate
        ' 
        lblCurrentDate.AutoSize = True
        lblCurrentDate.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCurrentDate.Location = New Point(19, 20)
        lblCurrentDate.Name = "lblCurrentDate"
        lblCurrentDate.Size = New Size(210, 39)
        lblCurrentDate.TabIndex = 0
        lblCurrentDate.Text = "currentDate"
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
        ' EmployeeCheckIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Name = "EmployeeCheckIn"
        Text = "Check-In"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        ResumeLayout(False)


    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents greetings As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents position As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents profile As RoundedButton
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents btnBack As Button
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents lblCheckOutTime As Label
    Friend WithEvents lblCheckInTime As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents lblCurrentTime As Label
End Class
