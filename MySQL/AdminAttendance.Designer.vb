<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAttendance
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
        RoundedPanel22 = New RoundedPanel()
        RoundedButton33 = New RoundedButton()
        RoundedButton22 = New RoundedButton()
        RoundedButton11 = New RoundedButton()
        profilee = New RoundedButton()
        attendancee = New RoundedButton()
        payslipp = New RoundedButton()
        dashbb = New RoundedButton()
        RoundedPanel11 = New RoundedPanel()
        positionlbll = New Label()
        empIDlbll = New Label()
        welcomelbll = New Label()
        Label11 = New Label()
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
        Label12 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        RoundedPanel22.SuspendLayout()
        RoundedPanel11.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel22
        ' 
        RoundedPanel22.Controls.Add(RoundedButton33)
        RoundedPanel22.Controls.Add(RoundedButton22)
        RoundedPanel22.Controls.Add(RoundedButton11)
        RoundedPanel22.Controls.Add(profilee)
        RoundedPanel22.Controls.Add(attendancee)
        RoundedPanel22.Controls.Add(payslipp)
        RoundedPanel22.Controls.Add(dashbb)
        RoundedPanel22.Location = New Point(60, 117)
        RoundedPanel22.Name = "RoundedPanel22"
        RoundedPanel22.Size = New Size(889, 44)
        RoundedPanel22.TabIndex = 2
        ' 
        ' RoundedButton33
        ' 
        RoundedButton33.BorderColor = Color.Gray
        RoundedButton33.BorderRadius = 20
        RoundedButton33.BorderSize = 2
        RoundedButton33.ClickColor = Color.DarkGray
        RoundedButton33.FlatStyle = FlatStyle.Flat
        RoundedButton33.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton33.HoverColor = Color.LightGray
        RoundedButton33.Location = New Point(760, 6)
        RoundedButton33.Name = "RoundedButton33"
        RoundedButton33.SelectedColor = Color.Silver
        RoundedButton33.Size = New Size(119, 32)
        RoundedButton33.TabIndex = 6
        RoundedButton33.TabStop = False
        RoundedButton33.Text = "⚙️ Settings"
        RoundedButton33.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton22
        ' 
        RoundedButton22.BorderColor = Color.Gray
        RoundedButton22.BorderRadius = 20
        RoundedButton22.BorderSize = 2
        RoundedButton22.ClickColor = Color.DarkGray
        RoundedButton22.FlatStyle = FlatStyle.Flat
        RoundedButton22.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton22.HoverColor = Color.LightGray
        RoundedButton22.Location = New Point(635, 6)
        RoundedButton22.Name = "RoundedButton22"
        RoundedButton22.SelectedColor = Color.Silver
        RoundedButton22.Size = New Size(119, 32)
        RoundedButton22.TabIndex = 5
        RoundedButton22.TabStop = False
        RoundedButton22.Text = "🚨 Reports"
        RoundedButton22.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton11
        ' 
        RoundedButton11.BorderColor = Color.Gray
        RoundedButton11.BorderRadius = 20
        RoundedButton11.BorderSize = 2
        RoundedButton11.ClickColor = Color.DarkGray
        RoundedButton11.FlatStyle = FlatStyle.Flat
        RoundedButton11.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton11.HoverColor = Color.LightGray
        RoundedButton11.Location = New Point(510, 6)
        RoundedButton11.Name = "RoundedButton11"
        RoundedButton11.SelectedColor = Color.Silver
        RoundedButton11.Size = New Size(119, 32)
        RoundedButton11.TabIndex = 4
        RoundedButton11.TabStop = False
        RoundedButton11.Text = " 🚫 Deduction"
        RoundedButton11.UseVisualStyleBackColor = True
        ' 
        ' profilee
        ' 
        profilee.BorderColor = Color.Gray
        profilee.BorderRadius = 20
        profilee.BorderSize = 2
        profilee.ClickColor = Color.DarkGray
        profilee.FlatStyle = FlatStyle.Flat
        profilee.Font = New Font("Berlin Sans FB", 12.0F)
        profilee.HoverColor = Color.LightGray
        profilee.Location = New Point(135, 6)
        profilee.Name = "profilee"
        profilee.SelectedColor = Color.Silver
        profilee.Size = New Size(119, 32)
        profilee.TabIndex = 3
        profilee.TabStop = False
        profilee.Text = "👤  Employees"
        profilee.UseVisualStyleBackColor = True
        ' 
        ' attendancee
        ' 
        attendancee.BorderColor = Color.Gray
        attendancee.BorderRadius = 20
        attendancee.BorderSize = 2
        attendancee.ClickColor = Color.DarkGray
        attendancee.FlatStyle = FlatStyle.Flat
        attendancee.Font = New Font("Berlin Sans FB", 12.0F)
        attendancee.HoverColor = Color.LightGray
        attendancee.Location = New Point(260, 6)
        attendancee.Name = "attendancee"
        attendancee.SelectedColor = Color.Silver
        attendancee.Size = New Size(119, 32)
        attendancee.TabIndex = 2
        attendancee.TabStop = False
        attendancee.Text = "📆  Attendance"
        attendancee.UseVisualStyleBackColor = True
        ' 
        ' payslipp
        ' 
        payslipp.BorderColor = Color.Gray
        payslipp.BorderRadius = 20
        payslipp.BorderSize = 2
        payslipp.ClickColor = Color.DarkGray
        payslipp.FlatStyle = FlatStyle.Flat
        payslipp.Font = New Font("Berlin Sans FB", 12.0F)
        payslipp.HoverColor = Color.LightGray
        payslipp.Location = New Point(385, 6)
        payslipp.Name = "payslipp"
        payslipp.SelectedColor = Color.Silver
        payslipp.Size = New Size(119, 32)
        payslipp.TabIndex = 1
        payslipp.TabStop = False
        payslipp.Text = "📄  Payroll"
        payslipp.UseVisualStyleBackColor = True
        ' 
        ' dashbb
        ' 
        dashbb.BorderColor = Color.Gray
        dashbb.BorderRadius = 20
        dashbb.BorderSize = 2
        dashbb.ClickColor = Color.DarkGray
        dashbb.FlatStyle = FlatStyle.Flat
        dashbb.Font = New Font("Berlin Sans FB", 12.0F)
        dashbb.HoverColor = Color.LightGray
        dashbb.Location = New Point(10, 6)
        dashbb.Name = "dashbb"
        dashbb.SelectedColor = Color.Silver
        dashbb.Size = New Size(119, 32)
        dashbb.TabIndex = 0
        dashbb.TabStop = False
        dashbb.Text = "📊  Dashboard"
        dashbb.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel11
        ' 
        RoundedPanel11.Controls.Add(positionlbll)
        RoundedPanel11.Controls.Add(empIDlbll)
        RoundedPanel11.Controls.Add(welcomelbll)
        RoundedPanel11.Controls.Add(Label11)
        RoundedPanel11.Location = New Point(12, 3)
        RoundedPanel11.Name = "RoundedPanel11"
        RoundedPanel11.Size = New Size(994, 97)
        RoundedPanel11.TabIndex = 10
        ' 
        ' positionlbll
        ' 
        positionlbll.AutoSize = True
        positionlbll.Enabled = False
        positionlbll.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        positionlbll.Location = New Point(772, 52)
        positionlbll.Name = "positionlbll"
        positionlbll.Size = New Size(174, 17)
        positionlbll.TabIndex = 1
        positionlbll.Text = "Position: Human Resources"
        ' 
        ' empIDlbll
        ' 
        empIDlbll.AccessibleDescription = ""
        empIDlbll.AutoSize = True
        empIDlbll.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbll.Location = New Point(770, 19)
        empIDlbll.Name = "empIDlbll"
        empIDlbll.Size = New Size(118, 20)
        empIDlbll.TabIndex = 3
        empIDlbll.Text = "Admin ID: AD69"
        ' 
        ' welcomelbll
        ' 
        welcomelbll.AutoSize = True
        welcomelbll.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        welcomelbll.Location = New Point(19, 52)
        welcomelbll.Name = "welcomelbll"
        welcomelbll.Size = New Size(100, 17)
        welcomelbll.TabIndex = 2
        welcomelbll.Text = "Welcome Back!"
        welcomelbll.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(16, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(157, 23)
        Label11.TabIndex = 1
        Label11.Text = "Admin Portal"
        Label11.TextAlign = ContentAlignment.MiddleLeft
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
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(14, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(166, 27)
        Label12.TabIndex = 6
        Label12.Text = "Quick Actions"
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
        TextBox1.Text = "Search employees, payroll, attendancee...."
        ' 
        ' AttendanceAdmin
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(currentsalary)
        Controls.Add(RoundedPanel11)
        Controls.Add(RoundedPanel22)
        Name = "AttendanceAdmin"
        Text = "Attendance"
        RoundedPanel22.ResumeLayout(False)
        RoundedPanel11.ResumeLayout(False)
        RoundedPanel11.PerformLayout()
        currentsalary.ResumeLayout(False)
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel22 As RoundedPanel
    Friend WithEvents profilee As RoundedButton
    Friend WithEvents attendancee As RoundedButton
    Friend WithEvents payslipp As RoundedButton
    Friend WithEvents dashbb As RoundedButton
    Friend WithEvents RoundedButton11 As RoundedButton
    Friend WithEvents RoundedButton33 As RoundedButton
    Friend WithEvents RoundedButton22 As RoundedButton
    Friend WithEvents RoundedPanel11 As RoundedPanel
    Friend WithEvents positionlbll As Label
    Friend WithEvents empIDlbll As Label
    Friend WithEvents welcomelbll As Label
    Friend WithEvents Label11 As Label
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
End Class