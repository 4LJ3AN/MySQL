<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDashboard
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
        RoundedPanel2 = New RoundedPanel()
        checkInbtn = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        currentsalary = New RoundedPanel()
        Label4 = New Label()
        current_net_pay = New Label()
        money = New Label()
        cur_month_sal = New Label()
        RoundedPanel3 = New RoundedPanel()
        Label5 = New Label()
        att = New Label()
        days = New Label()
        days_present = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label6 = New Label()
        total_hours = New Label()
        hours = New Label()
        hours_worked = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label7 = New Label()
        Label3 = New Label()
        ot = New Label()
        ot_hrs = New Label()
        RoundedPanel6 = New RoundedPanel()
        btnBack = New Button()
        RoundedPanel1 = New RoundedPanel()
        position = New Label()
        Label2 = New Label()
        greetings = New Label()
        Label1 = New Label()
        RoundedPanel2.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
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
        ' currentsalary
        ' 
        currentsalary.Controls.Add(Label4)
        currentsalary.Controls.Add(current_net_pay)
        currentsalary.Controls.Add(money)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(90, 214)
        currentsalary.Name = "currentsalary"
        currentsalary.Size = New Size(200, 100)
        currentsalary.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.PaleGreen
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkOliveGreen
        Label4.Location = New Point(163, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 25)
        Label4.TabIndex = 7
        Label4.Text = "₱"
        ' 
        ' current_net_pay
        ' 
        current_net_pay.AutoSize = True
        current_net_pay.Location = New Point(13, 77)
        current_net_pay.Name = "current_net_pay"
        current_net_pay.Size = New Size(91, 15)
        current_net_pay.TabIndex = 6
        current_net_pay.Text = "Current Net Pay"
        ' 
        ' money
        ' 
        money.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        money.ForeColor = Color.YellowGreen
        money.Location = New Point(12, 41)
        money.Name = "money"
        money.Size = New Size(100, 29)
        money.TabIndex = 7
        money.Text = "₱69,000"
        ' 
        ' cur_month_sal
        ' 
        cur_month_sal.Font = New Font("Segoe UI", 11F)
        cur_month_sal.Location = New Point(12, 14)
        cur_month_sal.Name = "cur_month_sal"
        cur_month_sal.Size = New Size(166, 27)
        cur_month_sal.TabIndex = 6
        cur_month_sal.Text = "Current Month Salary"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(Label5)
        RoundedPanel3.Controls.Add(att)
        RoundedPanel3.Controls.Add(days)
        RoundedPanel3.Controls.Add(days_present)
        RoundedPanel3.Location = New Point(306, 214)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(200, 100)
        RoundedPanel3.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.PowderBlue
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SteelBlue
        Label5.Location = New Point(154, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 25)
        Label5.TabIndex = 8
        Label5.Text = "📅"
        ' 
        ' att
        ' 
        att.AutoSize = True
        att.Location = New Point(9, 77)
        att.Name = "att"
        att.Size = New Size(139, 15)
        att.TabIndex = 7
        att.Text = "This Month's Attendance"
        ' 
        ' days
        ' 
        days.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        days.ForeColor = Color.SteelBlue
        days.Location = New Point(9, 41)
        days.Name = "days"
        days.Size = New Size(100, 29)
        days.TabIndex = 7
        days.Text = "28/31"
        ' 
        ' days_present
        ' 
        days_present.Font = New Font("Segoe UI", 11F)
        days_present.Location = New Point(11, 14)
        days_present.Name = "days_present"
        days_present.Size = New Size(166, 27)
        days_present.TabIndex = 6
        days_present.Text = "Days Present"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(Label6)
        RoundedPanel4.Controls.Add(total_hours)
        RoundedPanel4.Controls.Add(hours)
        RoundedPanel4.Controls.Add(hours_worked)
        RoundedPanel4.Location = New Point(521, 214)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(200, 100)
        RoundedPanel4.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Plum
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkViolet
        Label6.Location = New Point(156, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 25)
        Label6.TabIndex = 9
        Label6.Text = "⏲️"
        ' 
        ' total_hours
        ' 
        total_hours.AutoSize = True
        total_hours.Location = New Point(9, 77)
        total_hours.Name = "total_hours"
        total_hours.Size = New Size(128, 15)
        total_hours.TabIndex = 7
        total_hours.Text = "Total Hours this Month"
        ' 
        ' hours
        ' 
        hours.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hours.ForeColor = Color.DarkViolet
        hours.Location = New Point(9, 41)
        hours.Name = "hours"
        hours.Size = New Size(100, 29)
        hours.TabIndex = 7
        hours.Text = "144h"
        ' 
        ' hours_worked
        ' 
        hours_worked.Font = New Font("Segoe UI", 11F)
        hours_worked.Location = New Point(10, 15)
        hours_worked.Name = "hours_worked"
        hours_worked.Size = New Size(166, 27)
        hours_worked.TabIndex = 6
        hours_worked.Text = "Total Hours Worked"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(Label7)
        RoundedPanel5.Controls.Add(Label3)
        RoundedPanel5.Controls.Add(ot)
        RoundedPanel5.Controls.Add(ot_hrs)
        RoundedPanel5.Location = New Point(736, 214)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(200, 100)
        RoundedPanel5.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label7.Location = New Point(136, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 25)
        Label7.TabIndex = 10
        Label7.Text = "⏱️📈"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 15)
        Label3.TabIndex = 7
        Label3.Text = "Total OT for the Month"
        ' 
        ' ot
        ' 
        ot.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ot.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ot.Location = New Point(9, 41)
        ot.Name = "ot"
        ot.Size = New Size(100, 29)
        ot.TabIndex = 7
        ot.Text = "10h"
        ' 
        ' ot_hrs
        ' 
        ot_hrs.Font = New Font("Segoe UI", 11F)
        ot_hrs.Location = New Point(12, 13)
        ot_hrs.Name = "ot_hrs"
        ot_hrs.Size = New Size(166, 27)
        ot_hrs.TabIndex = 6
        ot_hrs.Text = "Overtime Hours"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Location = New Point(90, 364)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(846, 210)
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
        RoundedPanel1.Controls.Add(position)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(greetings)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Location = New Point(12, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(994, 97)
        RoundedPanel1.TabIndex = 8
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
        ' Label2
        ' 
        Label2.AccessibleDescription = ""
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(810, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 23)
        Label2.TabIndex = 3
        Label2.Text = "Employee ID: EMP1234"
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
        ' EmployeeDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(currentsalary)
        Controls.Add(RoundedPanel2)
        Name = "EmployeeDashboard"
        Text = "Dashboard"
        RoundedPanel2.ResumeLayout(False)
        currentsalary.ResumeLayout(False)
        currentsalary.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents profile As RoundedButton
    Friend WithEvents currentsalary As RoundedPanel
    Friend WithEvents cur_month_sal As Label
    Friend WithEvents money As Label
    Friend WithEvents current_net_pay As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents att As Label
    Friend WithEvents days As Label
    Friend WithEvents days_present As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents total_hours As Label
    Friend WithEvents hours As Label
    Friend WithEvents hours_worked As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents ot As Label
    Friend WithEvents ot_hrs As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents checkInbtn As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents position As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents greetings As Label
    Friend WithEvents Label1 As Label
End Class
