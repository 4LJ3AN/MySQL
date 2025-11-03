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
        components = New ComponentModel.Container()
        RoundedPanel2 = New RoundedPanel()
        checkInbtn = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        currentsalary = New RoundedPanel()
        Label4 = New Label()
        current_net_pay = New Label()
        lblNetPay = New Label()
        cur_month_sal = New Label()
        RoundedPanel3 = New RoundedPanel()
        Label5 = New Label()
        att = New Label()
        lblDays = New Label()
        days_present = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label6 = New Label()
        total_hours = New Label()
        lblHoursWorked = New Label()
        hours_worked = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label7 = New Label()
        Label3 = New Label()
        lblOTHours = New Label()
        ot_hrs = New Label()
        RoundedPanel6 = New RoundedPanel()
        WeeklyHoursChart1 = New WeeklyHoursChart()
        DatabaseConnectionBindingSource = New BindingSource(components)
        btnBack = New Button()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        DatabaseConnectionBindingSource1 = New BindingSource(components)
        Label2 = New Label()
        RoundedPanel2.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
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
        checkInbtn.Font = New Font("Berlin Sans FB", 12.0F)
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
        profile.Font = New Font("Berlin Sans FB", 12.0F)
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
        attendance.Font = New Font("Berlin Sans FB", 12.0F)
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
        payslip.Font = New Font("Berlin Sans FB", 12.0F)
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
        dashb.Font = New Font("Berlin Sans FB", 12.0F)
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
        currentsalary.Controls.Add(lblNetPay)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(90, 187)
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
        current_net_pay.Size = New Size(101, 15)
        current_net_pay.TabIndex = 6
        current_net_pay.Text = "Current Gross Pay"
        ' 
        ' lblNetPay
        ' 
        lblNetPay.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNetPay.ForeColor = Color.YellowGreen
        lblNetPay.Location = New Point(12, 41)
        lblNetPay.Name = "lblNetPay"
        lblNetPay.Size = New Size(100, 29)
        lblNetPay.TabIndex = 7
        lblNetPay.Text = "₱69,000"
        ' 
        ' cur_month_sal
        ' 
        cur_month_sal.Font = New Font("Segoe UI", 11.0F)
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
        RoundedPanel3.Controls.Add(lblDays)
        RoundedPanel3.Controls.Add(days_present)
        RoundedPanel3.Location = New Point(306, 187)
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
        Label5.Size = New Size(33, 25)
        Label5.TabIndex = 8
        Label5.Text = "📅"
        ' 
        ' att
        ' 
        att.AutoSize = True
        att.Location = New Point(9, 77)
        att.Name = "att"
        att.Size = New Size(140, 15)
        att.TabIndex = 7
        att.Text = "This Month's Attendance"
        ' 
        ' lblDays
        ' 
        lblDays.AutoSize = True
        lblDays.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDays.ForeColor = Color.SteelBlue
        lblDays.Location = New Point(9, 41)
        lblDays.Name = "lblDays"
        lblDays.Size = New Size(65, 30)
        lblDays.TabIndex = 7
        lblDays.Text = "28/31"
        ' 
        ' days_present
        ' 
        days_present.Font = New Font("Segoe UI", 11.0F)
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
        RoundedPanel4.Controls.Add(lblHoursWorked)
        RoundedPanel4.Controls.Add(hours_worked)
        RoundedPanel4.Location = New Point(521, 187)
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
        total_hours.Size = New Size(129, 15)
        total_hours.TabIndex = 7
        total_hours.Text = "Total Hours this Month"
        ' 
        ' lblHoursWorked
        ' 
        lblHoursWorked.AutoSize = True
        lblHoursWorked.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHoursWorked.ForeColor = Color.DarkViolet
        lblHoursWorked.Location = New Point(9, 41)
        lblHoursWorked.Name = "lblHoursWorked"
        lblHoursWorked.Size = New Size(58, 30)
        lblHoursWorked.TabIndex = 7
        lblHoursWorked.Text = "144h"
        ' 
        ' hours_worked
        ' 
        hours_worked.Font = New Font("Segoe UI", 11.0F)
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
        RoundedPanel5.Controls.Add(lblOTHours)
        RoundedPanel5.Controls.Add(ot_hrs)
        RoundedPanel5.Location = New Point(736, 187)
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
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 10
        Label7.Text = "⏱️📈"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 15)
        Label3.TabIndex = 7
        Label3.Text = "Total OT for the Month"
        ' 
        ' lblOTHours
        ' 
        lblOTHours.AutoSize = True
        lblOTHours.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOTHours.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblOTHours.Location = New Point(9, 41)
        lblOTHours.Name = "lblOTHours"
        lblOTHours.Size = New Size(47, 30)
        lblOTHours.TabIndex = 7
        lblOTHours.Text = "10h"
        ' 
        ' ot_hrs
        ' 
        ot_hrs.Font = New Font("Segoe UI", 11.0F)
        ot_hrs.Location = New Point(12, 13)
        ot_hrs.Name = "ot_hrs"
        ot_hrs.Size = New Size(166, 27)
        ot_hrs.TabIndex = 6
        ot_hrs.Text = "Overtime Hours"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(Label2)
        RoundedPanel6.Controls.Add(WeeklyHoursChart1)
        RoundedPanel6.Location = New Point(90, 293)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(846, 328)
        RoundedPanel6.TabIndex = 6
        ' 
        ' WeeklyHoursChart1
        ' 
        WeeklyHoursChart1.AutoScale = True
        WeeklyHoursChart1.AxisColor = Color.Black
        WeeklyHoursChart1.BarColor = Color.SteelBlue
        WeeklyHoursChart1.Location = New Point(94, 40)
        WeeklyHoursChart1.Name = "WeeklyHoursChart1"
        WeeklyHoursChart1.Size = New Size(658, 277)
        WeeklyHoursChart1.TabIndex = 1
        WeeklyHoursChart1.TextColor = Color.Black
        WeeklyHoursChart1.YStep = 2.0R
        ' 
        ' DatabaseConnectionBindingSource
        ' 
        DatabaseConnectionBindingSource.DataSource = GetType(DatabaseConnection)
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
        ' DatabaseConnectionBindingSource1
        ' 
        DatabaseConnectionBindingSource1.DataSource = GetType(DatabaseConnection)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 7
        Label2.Text = "Weekly Report"
        ' 
        ' EmployeeDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents profile As RoundedButton
    Friend WithEvents currentsalary As RoundedPanel
    Friend WithEvents cur_month_sal As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents current_net_pay As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents att As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents days_present As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents total_hours As Label
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents hours_worked As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOTHours As Label
    Friend WithEvents ot_hrs As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents checkInbtn As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseConnectionBindingSource As BindingSource
    Friend WithEvents DatabaseConnectionBindingSource1 As BindingSource
    Friend WithEvents WeeklyHoursChart1 As WeeklyHoursChart
    Friend WithEvents Label2 As Label
End Class
