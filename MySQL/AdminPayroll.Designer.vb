<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPayroll
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
    '<System.Diagnostics.DebuggerStepThrough()>

    Private Sub InitializeComponent()
        RoundedPanel2 = New RoundedPanel()
        RoundedButton3 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        cur_month_sal = New Label()
        money = New Label()
        currentsalary = New RoundedPanel()
        Label2 = New Label()
        RoundedPanel3 = New RoundedPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label11 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        RoundedPanel2.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(RoundedButton3)
        RoundedPanel2.Controls.Add(RoundedButton2)
        RoundedPanel2.Controls.Add(RoundedButton1)
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(60, 117)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(889, 44)
        RoundedPanel2.TabIndex = 2
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BorderColor = Color.Gray
        RoundedButton3.BorderRadius = 20
        RoundedButton3.BorderSize = 2
        RoundedButton3.ClickColor = Color.DarkGray
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton3.HoverColor = Color.LightGray
        RoundedButton3.Location = New Point(760, 6)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.SelectedColor = Color.Silver
        RoundedButton3.Size = New Size(119, 32)
        RoundedButton3.TabIndex = 6
        RoundedButton3.TabStop = False
        RoundedButton3.Text = "⚙️ Settings"
        RoundedButton3.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BorderColor = Color.Gray
        RoundedButton2.BorderRadius = 20
        RoundedButton2.BorderSize = 2
        RoundedButton2.ClickColor = Color.DarkGray
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton2.HoverColor = Color.LightGray
        RoundedButton2.Location = New Point(635, 6)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.SelectedColor = Color.Silver
        RoundedButton2.Size = New Size(119, 32)
        RoundedButton2.TabIndex = 5
        RoundedButton2.TabStop = False
        RoundedButton2.Text = "🚨 Reports"
        RoundedButton2.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BorderColor = Color.Gray
        RoundedButton1.BorderRadius = 20
        RoundedButton1.BorderSize = 2
        RoundedButton1.ClickColor = Color.DarkGray
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton1.HoverColor = Color.LightGray
        RoundedButton1.Location = New Point(510, 6)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.SelectedColor = Color.Silver
        RoundedButton1.Size = New Size(119, 32)
        RoundedButton1.TabIndex = 4
        RoundedButton1.TabStop = False
        RoundedButton1.Text = " 🚫 Deduction"
        RoundedButton1.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        profile.BorderColor = Color.Gray
        profile.BorderRadius = 20
        profile.BorderSize = 2
        profile.ClickColor = Color.DarkGray
        profile.FlatStyle = FlatStyle.Flat
        profile.Font = New Font("Berlin Sans FB", 12.0F)
        profile.HoverColor = Color.LightGray
        profile.Location = New Point(135, 6)
        profile.Name = "profile"
        profile.SelectedColor = Color.Silver
        profile.Size = New Size(119, 32)
        profile.TabIndex = 3
        profile.TabStop = False
        profile.Text = "👤  Employees"
        profile.UseVisualStyleBackColor = True
        ' 
        ' attendance
        ' 
        attendance.BorderColor = Color.Gray
        attendance.BorderRadius = 20
        attendance.BorderSize = 2
        attendance.ClickColor = Color.DarkGray
        attendance.FlatStyle = FlatStyle.Flat
        attendance.Font = New Font("Berlin Sans FB", 12.0F)
        attendance.HoverColor = Color.LightGray
        attendance.Location = New Point(260, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(119, 32)
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
        payslip.Font = New Font("Berlin Sans FB", 12.0F)
        payslip.HoverColor = Color.LightGray
        payslip.Location = New Point(385, 6)
        payslip.Name = "payslip"
        payslip.SelectedColor = Color.Silver
        payslip.Size = New Size(119, 32)
        payslip.TabIndex = 1
        payslip.TabStop = False
        payslip.Text = "📄  Payroll"
        payslip.UseVisualStyleBackColor = True
        ' 
        ' dashb
        ' 
        dashb.BorderColor = Color.Gray
        dashb.BorderRadius = 20
        dashb.BorderSize = 2
        dashb.ClickColor = Color.DarkGray
        dashb.FlatStyle = FlatStyle.Flat
        dashb.Font = New Font("Berlin Sans FB", 12.0F)
        dashb.HoverColor = Color.LightGray
        dashb.Location = New Point(10, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(119, 32)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = True
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
        RoundedPanel1.TabIndex = 10
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
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 23)
        Label1.TabIndex = 1
        Label1.Text = "Admin Portal"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cur_month_sal
        ' 
        cur_month_sal.Font = New Font("Segoe UI", 11.0F)
        cur_month_sal.Location = New Point(12, 14)
        cur_month_sal.Name = "cur_month_sal"
        cur_month_sal.Size = New Size(166, 27)
        cur_month_sal.TabIndex = 6
        cur_month_sal.Text = "Total Employees"
        ' 
        ' money
        ' 
        money.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        money.ForeColor = Color.MediumTurquoise
        money.Location = New Point(230, 6)
        money.Name = "money"
        money.Size = New Size(40, 29)
        money.TabIndex = 7
        money.Text = "👥"
        ' 
        ' currentsalary
        ' 
        currentsalary.Controls.Add(Label2)
        currentsalary.Controls.Add(money)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(60, 198)
        currentsalary.Name = "currentsalary"
        currentsalary.Size = New Size(283, 128)
        currentsalary.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(14, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 29)
        Label2.TabIndex = 8
        Label2.Text = "67"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(Label3)
        RoundedPanel3.Controls.Add(Label4)
        RoundedPanel3.Controls.Add(Label5)
        RoundedPanel3.Location = New Point(363, 198)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(283, 128)
        RoundedPanel3.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(14, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 29)
        Label3.TabIndex = 8
        Label3.Text = "15/11/2025"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.YellowGreen
        Label4.Location = New Point(230, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 29)
        Label4.TabIndex = 7
        Label4.Text = "📆"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 11.0F)
        Label5.Location = New Point(12, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 27)
        Label5.TabIndex = 6
        Label5.Text = "Payroll peroid"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(Label6)
        RoundedPanel4.Controls.Add(Label7)
        RoundedPanel4.Controls.Add(Label8)
        RoundedPanel4.Location = New Point(666, 198)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(283, 128)
        RoundedPanel4.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(14, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 29)
        Label6.TabIndex = 8
        Label6.Text = "₱290,999.00"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.MediumBlue
        Label7.Location = New Point(248, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 29)
        Label7.TabIndex = 7
        Label7.Text = "₱"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 11.0F)
        Label8.Location = New Point(12, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(166, 27)
        Label8.TabIndex = 6
        Label8.Text = "Net Pay"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(TextBox1)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label11)
        RoundedPanel5.Location = New Point(60, 348)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(889, 290)
        RoundedPanel5.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(14, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(166, 27)
        Label11.TabIndex = 6
        Label11.Text = "Quick Actions"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(209, 27)
        Label10.TabIndex = 9
        Label10.Text = "Search and manage your data"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(21, 61)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(846, 40)
        TextBox1.TabIndex = 10
        TextBox1.Text = "Search employees, payroll, attendance...."
        ' 
        ' AdminPayroll
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(currentsalary)
        Controls.Add(RoundedPanel1)
        Controls.Add(RoundedPanel2)
        Name = "AdminPayroll"
        Text = "Payroll"
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        currentsalary.ResumeLayout(False)
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click

    End Sub

    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cur_month_sal As Label
    Friend WithEvents money As Label
    Friend WithEvents currentsalary As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
End Class