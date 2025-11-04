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
        employees = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        lblAdminId = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel5 = New RoundedPanel()
        seeDeleted = New CheckBox()
        btnAdd = New RoundedButton()
        txtsearch = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        dgvEmployees = New DataGridView()
        RoundedPanel3 = New RoundedPanel()
        btnRestore = New RoundedButton()
        btnExport = New RoundedButton()
        btnRefresh = New RoundedButton()
        btnDelete = New RoundedButton()
        RoundedPanel2.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(employees)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(60, 117)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(889, 44)
        RoundedPanel2.TabIndex = 2
        ' 
        ' employees
        ' 
        employees.BackColor = Color.White
        employees.BorderColor = Color.Gray
        employees.BorderRadius = 20
        employees.BorderSize = 2
        employees.ClickColor = Color.DarkGray
        employees.FlatStyle = FlatStyle.Flat
        employees.Font = New Font("Berlin Sans FB", 12.0F)
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
        attendance.Font = New Font("Berlin Sans FB", 12.0F)
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
        payslip.Font = New Font("Berlin Sans FB", 12.0F)
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
        dashb.Font = New Font("Berlin Sans FB", 12.0F)
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
        RoundedPanel1.Controls.Add(lblAdminId)
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
        RoundedPanel5.Controls.Add(seeDeleted)
        RoundedPanel5.Controls.Add(btnAdd)
        RoundedPanel5.Controls.Add(txtsearch)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label11)
        RoundedPanel5.Location = New Point(60, 178)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(889, 118)
        RoundedPanel5.TabIndex = 13
        ' 
        ' seeDeleted
        ' 
        seeDeleted.AutoSize = True
        seeDeleted.Location = New Point(710, 74)
        seeDeleted.Name = "seeDeleted"
        seeDeleted.Size = New Size(93, 19)
        seeDeleted.TabIndex = 4
        seeDeleted.Text = "Archive view"
        seeDeleted.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ControlText
        btnAdd.BorderColor = Color.Gray
        btnAdd.BorderRadius = 20
        btnAdd.BorderSize = 2
        btnAdd.ClickColor = Color.DimGray
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Berlin Sans FB", 12.0F)
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.HoverColor = Color.DimGray
        btnAdd.Location = New Point(678, 12)
        btnAdd.Name = "btnAdd"
        btnAdd.SelectedColor = Color.DimGray
        btnAdd.Size = New Size(165, 32)
        btnAdd.TabIndex = 11
        btnAdd.TabStop = False
        btnAdd.Text = "✚   Add Employee"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsearch.Location = New Point(15, 61)
        txtsearch.Multiline = True
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(420, 32)
        txtsearch.TabIndex = 10
        txtsearch.Text = "Search by name or ID"
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
        ' dgvEmployees
        ' 
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(60, 302)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.Size = New Size(889, 290)
        dgvEmployees.TabIndex = 14
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(btnRestore)
        RoundedPanel3.Controls.Add(btnExport)
        RoundedPanel3.Controls.Add(btnRefresh)
        RoundedPanel3.Controls.Add(btnDelete)
        RoundedPanel3.Location = New Point(60, 598)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(889, 59)
        RoundedPanel3.TabIndex = 15
        ' 
        ' btnRestore
        ' 
        btnRestore.BorderColor = Color.Gray
        btnRestore.BorderRadius = 20
        btnRestore.BorderSize = 2
        btnRestore.ClickColor = Color.DarkGray
        btnRestore.FlatStyle = FlatStyle.Flat
        btnRestore.Font = New Font("Berlin Sans FB", 12.0F)
        btnRestore.HoverColor = Color.LightGray
        btnRestore.Location = New Point(120, 14)
        btnRestore.Name = "btnRestore"
        btnRestore.SelectedColor = Color.Silver
        btnRestore.Size = New Size(90, 32)
        btnRestore.TabIndex = 4
        btnRestore.TabStop = False
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.BorderColor = Color.Gray
        btnExport.BorderRadius = 20
        btnExport.BorderSize = 2
        btnExport.ClickColor = Color.DarkGray
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Berlin Sans FB", 12.0F)
        btnExport.HoverColor = Color.LightGray
        btnExport.Location = New Point(226, 14)
        btnExport.Name = "btnExport"
        btnExport.SelectedColor = Color.Silver
        btnExport.Size = New Size(90, 32)
        btnExport.TabIndex = 3
        btnExport.TabStop = False
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BorderColor = Color.Gray
        btnRefresh.BorderRadius = 20
        btnRefresh.BorderSize = 2
        btnRefresh.ClickColor = Color.DarkGray
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Berlin Sans FB", 12.0F)
        btnRefresh.HoverColor = Color.LightGray
        btnRefresh.Location = New Point(14, 14)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.SelectedColor = Color.Silver
        btnRefresh.Size = New Size(90, 32)
        btnRefresh.TabIndex = 2
        btnRefresh.TabStop = False
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BorderColor = Color.Gray
        btnDelete.BorderRadius = 20
        btnDelete.BorderSize = 2
        btnDelete.ClickColor = Color.DarkGray
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Berlin Sans FB", 12.0F)
        btnDelete.HoverColor = Color.LightGray
        btnDelete.Location = New Point(120, 14)
        btnDelete.Name = "btnDelete"
        btnDelete.SelectedColor = Color.Silver
        btnDelete.Size = New Size(90, 32)
        btnDelete.TabIndex = 1
        btnDelete.TabStop = False
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' AdminEmployees
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel3)
        Controls.Add(dgvEmployees)
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
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents employees As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles employees.Click

    End Sub
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents lblAdminId As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnAdd As RoundedButton
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents btnDelete As RoundedButton
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents btnExport As RoundedButton
    Friend WithEvents seeDeleted As CheckBox
    Friend WithEvents btnRestore As RoundedButton
End Class