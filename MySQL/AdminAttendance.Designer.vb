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
        Label12 = New Label()
        DataGridView1 = New DataGridView()
        RoundedPanel1 = New RoundedPanel()
        MonthCalendar1 = New MonthCalendar()
        currentsalary = New RoundedPanel()
        money = New Label()
        cur_month_sal = New Label()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        Label3 = New Label()
        RoundedPanel3 = New RoundedPanel()
        Label5 = New Label()
        Label6 = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label8 = New Label()
        Label9 = New Label()
        RoundedPanel5 = New RoundedPanel()
        TextBox1 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        RoundedPanel6 = New RoundedPanel()
        positionlbl = New Label()
        lblAdminId = New Label()
        welcomelbl = New Label()
        Label13 = New Label()
        RoundedPanel7 = New RoundedPanel()
        employees = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        currentsalary.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        SuspendLayout()
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(60, 397)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(572, 251)
        DataGridView1.TabIndex = 4
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(MonthCalendar1)
        RoundedPanel1.Location = New Point(648, 397)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(301, 251)
        RoundedPanel1.TabIndex = 11
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(34, 45)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 12
        ' 
        ' currentsalary
        ' 
        currentsalary.Controls.Add(money)
        currentsalary.Controls.Add(cur_month_sal)
        currentsalary.Location = New Point(60, 167)
        currentsalary.Name = "currentsalary"
        currentsalary.Size = New Size(200, 100)
        currentsalary.TabIndex = 12
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
        cur_month_sal.Text = "Present"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(Label3)
        RoundedPanel2.Location = New Point(522, 167)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(200, 100)
        RoundedPanel2.TabIndex = 13
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
        Label3.Text = "Late"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(Label5)
        RoundedPanel3.Controls.Add(Label6)
        RoundedPanel3.Location = New Point(749, 167)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(200, 100)
        RoundedPanel3.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label5.Location = New Point(12, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 29)
        Label5.TabIndex = 7
        Label5.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(12, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 27)
        Label6.TabIndex = 6
        Label6.Text = "Absent"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(Label8)
        RoundedPanel4.Controls.Add(Label9)
        RoundedPanel4.Location = New Point(290, 167)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(200, 100)
        RoundedPanel4.TabIndex = 8
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
        Label9.Text = "Leave"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(TextBox1)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label11)
        RoundedPanel5.Location = New Point(60, 273)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(889, 118)
        RoundedPanel5.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(21, 61)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(846, 40)
        TextBox1.TabIndex = 10
        TextBox1.Text = "Search by name, or ID..."
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(271, 27)
        Label10.TabIndex = 9
        Label10.Text = "View and manage employee attendance"
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(14, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(166, 27)
        Label11.TabIndex = 6
        Label11.Text = "Attendance Records"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(positionlbl)
        RoundedPanel6.Controls.Add(lblAdminId)
        RoundedPanel6.Controls.Add(welcomelbl)
        RoundedPanel6.Controls.Add(Label13)
        RoundedPanel6.Location = New Point(12, 3)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(994, 97)
        RoundedPanel6.TabIndex = 16
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
        ' lblAdminId
        ' 
        lblAdminId.AccessibleDescription = ""
        lblAdminId.AutoSize = True
        lblAdminId.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdminId.Location = New Point(770, 19)
        lblAdminId.Name = "lblAdminId"
        lblAdminId.Size = New Size(118, 20)
        lblAdminId.TabIndex = 3
        lblAdminId.Text = "Admin ID: AD69"
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
        ' RoundedPanel7
        ' 
        RoundedPanel7.Controls.Add(employees)
        RoundedPanel7.Controls.Add(attendance)
        RoundedPanel7.Controls.Add(payslip)
        RoundedPanel7.Controls.Add(dashb)
        RoundedPanel7.Location = New Point(60, 111)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(889, 44)
        RoundedPanel7.TabIndex = 11
        ' 
        ' employees
        ' 
        employees.BackColor = Color.White
        employees.BorderColor = Color.Gray
        employees.BorderRadius = 20
        employees.BorderSize = 2
        employees.ClickColor = Color.DarkGray
        employees.FlatStyle = FlatStyle.Flat
        employees.Font = New Font("Berlin Sans FB", 12F)
        employees.HoverColor = Color.LightGray
        employees.Location = New Point(258, 6)
        employees.Name = "employees"
        employees.SelectedColor = Color.Silver
        employees.Size = New Size(177, 32)
        employees.TabIndex = 3
        employees.TabStop = False
        employees.Text = "👤  Employees"
        employees.UseVisualStyleBackColor = False
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
        ' AdminAttendance
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel7)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel2)
        Controls.Add(currentsalary)
        Controls.Add(RoundedPanel1)
        Controls.Add(DataGridView1)
        Name = "AdminAttendance"
        Text = "Attendance"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        currentsalary.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel7.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents currentsalary As RoundedPanel
    Friend WithEvents money As Label
    Friend WithEvents cur_month_sal As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents lblAdminId As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents employees As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
End Class