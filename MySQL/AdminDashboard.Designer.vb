<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        RoundedPanel7 = New RoundedPanel()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel6 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label13 = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label8 = New Label()
        Label9 = New Label()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        Label3 = New Label()
        currentsalary = New RoundedPanel()
        money = New Label()
        cur_month_sal = New Label()
        RoundedPanel7.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        currentsalary.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Controls.Add(profile)
        RoundedPanel7.Controls.Add(attendance)
        RoundedPanel7.Controls.Add(payslip)
        RoundedPanel7.Controls.Add(dashb)
        RoundedPanel7.Location = New Point(59, 111)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(889, 44)
        RoundedPanel7.TabIndex = 18
        ' 
        ' profile
        ' 
        profile.BackColor = Color.White
        profile.BorderColor = Color.Gray
        profile.BorderRadius = 20
        profile.BorderSize = 2
        profile.ClickColor = Color.DarkGray
        profile.FlatStyle = FlatStyle.Flat
        profile.Font = New Font("Berlin Sans FB", 12F)
        profile.HoverColor = Color.LightGray
        profile.Location = New Point(258, 6)
        profile.Name = "profile"
        profile.SelectedColor = Color.Silver
        profile.Size = New Size(177, 32)
        profile.TabIndex = 3
        profile.TabStop = False
        profile.Text = "👤  Employees"
        profile.UseVisualStyleBackColor = False
        ' 
        ' attendance
        ' 
        attendance.BackColor = Color.White
        attendance.BorderColor = Color.Gray
        attendance.BorderRadius = 20
        attendance.BorderSize = 2
        attendance.ClickColor = Color.DarkGray
        attendance.FlatStyle = FlatStyle.Flat
        attendance.Font = New Font("Berlin Sans FB", 12F)
        attendance.HoverColor = Color.LightGray
        attendance.Location = New Point(469, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(177, 32)
        attendance.TabIndex = 2
        attendance.TabStop = False
        attendance.Text = "📆  Attendance"
        attendance.UseVisualStyleBackColor = False
        ' 
        ' payslip
        ' 
        payslip.BackColor = Color.White
        payslip.BorderColor = Color.Gray
        payslip.BorderRadius = 20
        payslip.BorderSize = 2
        payslip.ClickColor = Color.DarkGray
        payslip.FlatStyle = FlatStyle.Flat
        payslip.Font = New Font("Berlin Sans FB", 12F)
        payslip.HoverColor = Color.LightGray
        payslip.Location = New Point(674, 6)
        payslip.Name = "payslip"
        payslip.SelectedColor = Color.Silver
        payslip.Size = New Size(177, 32)
        payslip.TabIndex = 1
        payslip.TabStop = False
        payslip.Text = "📄  Payroll"
        payslip.UseVisualStyleBackColor = False
        ' 
        ' dashb
        ' 
        dashb.BackColor = Color.White
        dashb.BorderColor = Color.Gray
        dashb.BorderRadius = 20
        dashb.BorderSize = 2
        dashb.ClickColor = Color.DarkGray
        dashb.FlatStyle = FlatStyle.Flat
        dashb.Font = New Font("Berlin Sans FB", 12F)
        dashb.HoverColor = Color.LightGray
        dashb.Location = New Point(49, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(177, 32)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(positionlbl)
        RoundedPanel6.Controls.Add(empIDlbl)
        RoundedPanel6.Controls.Add(welcomelbl)
        RoundedPanel6.Controls.Add(Label13)
        RoundedPanel6.Location = New Point(11, 3)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(994, 97)
        RoundedPanel6.TabIndex = 23
        ' 
        ' positionlbl
        ' 
        positionlbl.AutoSize = True
        positionlbl.Enabled = False
        positionlbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        positionlbl.Location = New Point(772, 52)
        positionlbl.Name = "positionlbl"
        positionlbl.Size = New Size(174, 17)
        positionlbl.TabIndex = 1
        positionlbl.Text = "Position: Human Resources"
        ' 
        ' empIDlbl
        ' 
        empIDlbl.AccessibleDescription = ""
        empIDlbl.AutoSize = True
        empIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbl.Location = New Point(770, 19)
        empIDlbl.Name = "empIDlbl"
        empIDlbl.Size = New Size(118, 20)
        empIDlbl.TabIndex = 3
        empIDlbl.Text = "Admin ID: AD69"
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
        ' Label13
        ' 
        Label13.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(16, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(157, 23)
        Label13.TabIndex = 1
        Label13.Text = "Admin Portal"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(Label8)
        RoundedPanel4.Controls.Add(Label9)
        RoundedPanel4.Location = New Point(383, 167)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(255, 100)
        RoundedPanel4.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SteelBlue
        Label8.Location = New Point(12, 41)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 29)
        Label8.TabIndex = 7
        Label8.Text = "1"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 11F)
        Label9.Location = New Point(12, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(166, 27)
        Label9.TabIndex = 6
        Label9.Text = "Payroll period"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(Label3)
        RoundedPanel2.Location = New Point(693, 167)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(255, 100)
        RoundedPanel2.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkViolet
        Label2.Location = New Point(12, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 29)
        Label2.TabIndex = 7
        Label2.Text = "1"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(12, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 27)
        Label3.TabIndex = 6
        Label3.Text = "Netpay"
        ' 
        ' currentsalary
        ' 
        currentsalary.Controls.Add(money)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(59, 167)
        currentsalary.Name = "currentsalary"
        currentsalary.Size = New Size(255, 100)
        currentsalary.TabIndex = 19
        ' 
        ' money
        ' 
        money.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        money.ForeColor = Color.YellowGreen
        money.Location = New Point(12, 41)
        money.Name = "money"
        money.Size = New Size(100, 29)
        money.TabIndex = 7
        money.Text = "5"
        ' 
        ' cur_month_sal
        ' 
        cur_month_sal.Font = New Font("Segoe UI", 11F)
        cur_month_sal.Location = New Point(12, 14)
        cur_month_sal.Name = "cur_month_sal"
        cur_month_sal.Size = New Size(166, 27)
        cur_month_sal.TabIndex = 6
        cur_month_sal.Text = "Total Employees"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel7)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel4)
        Controls.Add(currentsalary)
        Name = "AdminDashboard"
        Text = "S"
        RoundedPanel7.ResumeLayout(False)
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        currentsalary.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents currentsalary As RoundedPanel
    Friend WithEvents money As Label
    Friend WithEvents cur_month_sal As Label
End Class
