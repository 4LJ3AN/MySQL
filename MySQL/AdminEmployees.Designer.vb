<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminEmployees
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
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel5 = New RoundedPanel()
        RoundedButton4 = New RoundedButton()
        TextBox1 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        DataGridView1 = New DataGridView()
        RoundedPanel3 = New RoundedPanel()
        RoundedButton5 = New RoundedButton()
        RoundedButton11 = New RoundedButton()
        RoundedPanel2.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(60, 117)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(889, 44)
        RoundedPanel2.TabIndex = 2
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
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(RoundedButton4)
        RoundedPanel5.Controls.Add(TextBox1)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label11)
        RoundedPanel5.Location = New Point(60, 178)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(889, 118)
        RoundedPanel5.TabIndex = 13
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = SystemColors.ControlText
        RoundedButton4.BorderColor = Color.Gray
        RoundedButton4.BorderRadius = 20
        RoundedButton4.BorderSize = 2
        RoundedButton4.ClickColor = Color.DarkGray
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton4.ForeColor = SystemColors.Control
        RoundedButton4.HoverColor = Color.LightGray
        RoundedButton4.Location = New Point(678, 12)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.SelectedColor = Color.Silver
        RoundedButton4.Size = New Size(165, 32)
        RoundedButton4.TabIndex = 11
        RoundedButton4.TabStop = False
        RoundedButton4.Text = "✚   Add Employee"
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(21, 61)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(846, 40)
        TextBox1.TabIndex = 10
        TextBox1.Text = "Search by name, ID, or department..."
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(271, 27)
        Label10.TabIndex = 9
        Label10.Text = "Manage employee information and records"
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(14, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(166, 27)
        Label11.TabIndex = 6
        Label11.Text = "Employees"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(60, 302)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(889, 290)
        DataGridView1.TabIndex = 14
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(RoundedButton5)
        RoundedPanel3.Controls.Add(RoundedButton11)
        RoundedPanel3.Location = New Point(60, 598)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(889, 59)
        RoundedPanel3.TabIndex = 15
        ' 
        ' RoundedButton5
        ' 
        RoundedButton5.BorderColor = Color.Gray
        RoundedButton5.BorderRadius = 20
        RoundedButton5.BorderSize = 2
        RoundedButton5.ClickColor = Color.DarkGray
        RoundedButton5.FlatStyle = FlatStyle.Flat
        RoundedButton5.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton5.HoverColor = Color.LightGray
        RoundedButton5.Location = New Point(120, 14)
        RoundedButton5.Name = "RoundedButton5"
        RoundedButton5.SelectedColor = Color.Silver
        RoundedButton5.Size = New Size(90, 32)
        RoundedButton5.TabIndex = 1
        RoundedButton5.TabStop = False
        RoundedButton5.Text = "Delete"
        RoundedButton5.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton11
        ' 
        RoundedButton11.BorderColor = Color.Gray
        RoundedButton11.BorderRadius = 20
        RoundedButton11.BorderSize = 2
        RoundedButton11.ClickColor = Color.DarkGray
        RoundedButton11.FlatStyle = FlatStyle.Flat
        RoundedButton11.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton11.HoverColor = Color.LightGray
        RoundedButton11.Location = New Point(14, 14)
        RoundedButton11.Name = "RoundedButton11"
        RoundedButton11.SelectedColor = Color.Silver
        RoundedButton11.Size = New Size(90, 32)
        RoundedButton11.TabIndex = 0
        RoundedButton11.TabStop = False
        RoundedButton11.Text = "Edit"
        RoundedButton11.UseVisualStyleBackColor = True
        ' 
        ' AdminEmployees
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel3)
        Controls.Add(DataGridView1)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel1)
        Controls.Add(RoundedPanel2)
        Name = "AdminEmployees"
        Text = "Dashboard"
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click

    End Sub
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RoundedButton4 As RoundedButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents RoundedButton5 As RoundedButton
    Friend WithEvents RoundedButton11 As RoundedButton
End Class