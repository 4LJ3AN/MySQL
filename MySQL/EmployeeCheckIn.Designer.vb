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
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel2 = New RoundedPanel()
        RoundedButton1 = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel6 = New RoundedPanel()
        btnCheckOut = New Button()
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
        RoundedPanel1.Controls.Add(positionlbl)
        RoundedPanel1.Controls.Add(empIDlbl)
        RoundedPanel1.Controls.Add(welcomelbl)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Location = New Point(12, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(994, 97)
        RoundedPanel1.TabIndex = 0
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
        empIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbl.Location = New Point(770, 19)
        empIDlbl.Name = "empIDlbl"
        empIDlbl.Size = New Size(167, 23)
        empIDlbl.TabIndex = 3
        empIDlbl.Text = "Employee ID: EM-1234"
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
        RoundedPanel6.Controls.Add(btnCheckOut)
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
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.IndianRed
        btnCheckOut.FlatStyle = FlatStyle.Popup
        btnCheckOut.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCheckOut.Location = New Point(258, 290)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(229, 52)
        btnCheckOut.TabIndex = 7
        btnCheckOut.TabStop = False
        btnCheckOut.Text = "Check out"
        btnCheckOut.UseVisualStyleBackColor = False
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
        btnCheckIn.Text = "Check in"
        btnCheckIn.UseVisualStyleBackColor = False
        ' 
        ' lblHoursWorked
        ' 
        lblHoursWorked.AutoSize = True
        lblHoursWorked.Font = New Font("Microsoft Sans Serif", 20.25F)
        lblHoursWorked.Location = New Point(392, 89)
        lblHoursWorked.Name = "lblHoursWorked"
        lblHoursWorked.Size = New Size(310, 31)
        lblHoursWorked.TabIndex = 5
        lblHoursWorked.Text = "Hours worked: 12.67 hrs"
        ' 
        ' lblCheckOutTime
        ' 
        lblCheckOutTime.AutoSize = True
        lblCheckOutTime.Font = New Font("Microsoft Sans Serif", 20.25F)
        lblCheckOutTime.Location = New Point(202, 217)
        lblCheckOutTime.Name = "lblCheckOutTime"
        lblCheckOutTime.Size = New Size(340, 31)
        lblCheckOutTime.TabIndex = 4
        lblCheckOutTime.Text = "Check Out Time: 01:08 PM"
        ' 
        ' lblCheckInTime
        ' 
        lblCheckInTime.AutoSize = True
        lblCheckInTime.Font = New Font("Microsoft Sans Serif", 20.25F)
        lblCheckInTime.Location = New Point(202, 177)
        lblCheckInTime.Name = "lblCheckInTime"
        lblCheckInTime.Size = New Size(319, 31)
        lblCheckInTime.TabIndex = 3
        lblCheckInTime.Text = "Check In Time: 01:07 PM"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Microsoft Sans Serif", 20.25F)
        lblStatus.Location = New Point(42, 89)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(260, 31)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Status: Checked out"
        ' 
        ' lblCurrentTime
        ' 
        lblCurrentTime.AutoSize = True
        lblCurrentTime.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        lblCurrentTime.Location = New Point(513, 20)
        lblCurrentTime.Name = "lblCurrentTime"
        lblCurrentTime.Size = New Size(199, 37)
        lblCurrentTime.TabIndex = 1
        lblCurrentTime.Text = "currentTime"
        ' 
        ' lblCurrentDate
        ' 
        lblCurrentDate.AutoSize = True
        lblCurrentDate.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        lblCurrentDate.Location = New Point(27, 20)
        lblCurrentDate.Name = "lblCurrentDate"
        lblCurrentDate.Size = New Size(195, 37)
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
        RoundedPanel1.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        ResumeLayout(False)


    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents positionlbl As Label
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
    Friend WithEvents btnCheckOut As Button
End Class
