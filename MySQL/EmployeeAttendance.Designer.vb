<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeAttendance
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
        Label2 = New Label()
        greetings = New Label()
        Label1 = New Label()
        RoundedPanel2 = New RoundedPanel()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        currentsalary = New RoundedPanel()
        current_net_pay = New Label()
        money = New Label()
        cur_month_sal = New Label()
        RoundedPanel3 = New RoundedPanel()
        att = New Label()
        days = New Label()
        days_present = New Label()
        RoundedPanel4 = New RoundedPanel()
        total_hours = New Label()
        hours = New Label()
        hours_worked = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label3 = New Label()
        ot = New Label()
        ot_hrs = New Label()
        RoundedPanel6 = New RoundedPanel()
        MonthCalendar1 = New MonthCalendar()
        Label4 = New Label()
        btnBack = New Button()
        RoundedPanel7 = New RoundedPanel()
        Label6 = New Label()
        Label5 = New Label()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(position)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(greetings)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Location = New Point(4, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1014, 97)
        RoundedPanel1.TabIndex = 0
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
        Label2.Size = New Size(167, 23)
        Label2.TabIndex = 3
        Label2.Text = "Employee ID: EMP1234"
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
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(179, 131)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(694, 49)
        RoundedPanel2.TabIndex = 1
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
        ' payslip
        ' 
        payslip.BorderColor = Color.Gray
        payslip.BorderRadius = 20
        payslip.BorderSize = 2
        payslip.ClickColor = Color.DarkGray
        payslip.FlatStyle = FlatStyle.Flat
        payslip.Font = New Font("Berlin Sans FB", 12F)
        payslip.HoverColor = Color.LightGray
        payslip.Location = New Point(180, 6)
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
        dashb.Location = New Point(10, 6)
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
        currentsalary.Controls.Add(current_net_pay)
        currentsalary.Controls.Add(money)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(90, 214)
        currentsalary.Name = "currentsalary"
        currentsalary.Size = New Size(200, 100)
        currentsalary.TabIndex = 2
        ' 
        ' current_net_pay
        ' 
        current_net_pay.AutoSize = True
        current_net_pay.Location = New Point(13, 77)
        current_net_pay.Name = "current_net_pay"
        current_net_pay.Size = New Size(102, 15)
        current_net_pay.TabIndex = 6
        current_net_pay.Text = "Total Present Days"
        ' 
        ' money
        ' 
        money.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        money.ForeColor = Color.YellowGreen
        money.Location = New Point(12, 41)
        money.Name = "money"
        money.Size = New Size(100, 29)
        money.TabIndex = 7
        money.Text = "74"
        ' 
        ' cur_month_sal
        ' 
        cur_month_sal.Font = New Font("Segoe UI", 11F)
        cur_month_sal.Location = New Point(12, 14)
        cur_month_sal.Name = "cur_month_sal"
        cur_month_sal.Size = New Size(166, 27)
        cur_month_sal.TabIndex = 6
        cur_month_sal.Text = "Present"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(att)
        RoundedPanel3.Controls.Add(days)
        RoundedPanel3.Controls.Add(days_present)
        RoundedPanel3.Location = New Point(306, 214)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(200, 100)
        RoundedPanel3.TabIndex = 3
        ' 
        ' att
        ' 
        att.AutoSize = True
        att.Location = New Point(9, 77)
        att.Name = "att"
        att.Size = New Size(131, 15)
        att.TabIndex = 7
        att.Text = "Leaves used this month"
        ' 
        ' days
        ' 
        days.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        days.ForeColor = Color.SteelBlue
        days.Location = New Point(9, 41)
        days.Name = "days"
        days.Size = New Size(100, 29)
        days.TabIndex = 7
        days.Text = "1"
        ' 
        ' days_present
        ' 
        days_present.Font = New Font("Segoe UI", 11F)
        days_present.Location = New Point(11, 14)
        days_present.Name = "days_present"
        days_present.Size = New Size(166, 27)
        days_present.TabIndex = 6
        days_present.Text = "Leaves"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(total_hours)
        RoundedPanel4.Controls.Add(hours)
        RoundedPanel4.Controls.Add(hours_worked)
        RoundedPanel4.Location = New Point(521, 214)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(200, 100)
        RoundedPanel4.TabIndex = 4
        ' 
        ' total_hours
        ' 
        total_hours.AutoSize = True
        total_hours.Location = New Point(9, 77)
        total_hours.Name = "total_hours"
        total_hours.Size = New Size(108, 15)
        total_hours.TabIndex = 7
        total_hours.Text = "Total late check-ins"
        ' 
        ' hours
        ' 
        hours.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hours.ForeColor = Color.DarkViolet
        hours.Location = New Point(9, 41)
        hours.Name = "hours"
        hours.Size = New Size(100, 29)
        hours.TabIndex = 7
        hours.Text = "4"
        ' 
        ' hours_worked
        ' 
        hours_worked.Font = New Font("Segoe UI", 11F)
        hours_worked.Location = New Point(10, 15)
        hours_worked.Name = "hours_worked"
        hours_worked.Size = New Size(166, 27)
        hours_worked.TabIndex = 6
        hours_worked.Text = "Lates"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(Label3)
        RoundedPanel5.Controls.Add(ot)
        RoundedPanel5.Controls.Add(ot_hrs)
        RoundedPanel5.Location = New Point(736, 214)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(200, 100)
        RoundedPanel5.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 7
        Label3.Text = "Total Absences"
        ' 
        ' ot
        ' 
        ot.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ot.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ot.Location = New Point(9, 41)
        ot.Name = "ot"
        ot.Size = New Size(100, 29)
        ot.TabIndex = 7
        ot.Text = "2"
        ' 
        ' ot_hrs
        ' 
        ot_hrs.Font = New Font("Segoe UI", 11F)
        ot_hrs.Location = New Point(12, 13)
        ot_hrs.Name = "ot_hrs"
        ot_hrs.Size = New Size(166, 27)
        ot_hrs.TabIndex = 6
        ot_hrs.Text = "Absences"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(MonthCalendar1)
        RoundedPanel6.Controls.Add(Label4)
        RoundedPanel6.Location = New Point(90, 332)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(416, 291)
        RoundedPanel6.TabIndex = 6
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(95, 70)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(17, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 27)
        Label4.TabIndex = 7
        Label4.Text = "Calendar"
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
        ' RoundedPanel7
        ' 
        RoundedPanel7.Controls.Add(Label6)
        RoundedPanel7.Controls.Add(Label5)
        RoundedPanel7.Location = New Point(521, 332)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(416, 291)
        RoundedPanel7.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonShadow
        Label6.Location = New Point(19, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 23)
        Label6.TabIndex = 9
        Label6.Text = "Last 8 days of Attendance Records"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(19, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 27)
        Label5.TabIndex = 8
        Label5.Text = "Attendance for this Week"
        ' 
        ' EmployeeAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel7)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(currentsalary)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Name = "EmployeeAttendance"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        currentsalary.ResumeLayout(False)
        currentsalary.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents greetings As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents position As Label
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
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label6 As Label
End Class
