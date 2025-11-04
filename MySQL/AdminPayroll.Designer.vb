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
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        RoundedPanel3 = New RoundedPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        RoundedPanel4 = New RoundedPanel()
        Label9 = New Label()
        RoundedPanel5 = New RoundedPanel()
        RoundedPanel6 = New RoundedPanel()
        Label7 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        DataGridView1 = New DataGridView()
        RoundedPanel7 = New RoundedPanel()
        RoundedButton4 = New RoundedButton()
        RoundedButton5 = New RoundedButton()
        RoundedButton6 = New RoundedButton()
        RoundedButton7 = New RoundedButton()
        RoundedPanel1.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel7.SuspendLayout()
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
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(Button2)
        RoundedPanel3.Controls.Add(Button1)
        RoundedPanel3.Controls.Add(TextBox1)
        RoundedPanel3.Controls.Add(ComboBox2)
        RoundedPanel3.Controls.Add(ComboBox1)
        RoundedPanel3.Controls.Add(Label6)
        RoundedPanel3.Controls.Add(Label2)
        RoundedPanel3.Controls.Add(Label3)
        RoundedPanel3.Controls.Add(Label4)
        RoundedPanel3.Controls.Add(Label5)
        RoundedPanel3.Location = New Point(35, 169)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(948, 209)
        RoundedPanel3.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AccessibleDescription = ""
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 20)
        Label3.TabIndex = 3
        Label3.Text = "Payroll Period"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(15, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(311, 19)
        Label4.TabIndex = 2
        Label4.Text = "Manage employee payroll and compensation"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(15, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 23)
        Label5.TabIndex = 1
        Label5.Text = "Admin Portal"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AccessibleDescription = ""
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(320, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 20)
        Label2.TabIndex = 4
        Label2.Text = "Position"
        ' 
        ' Label6
        ' 
        Label6.AccessibleDescription = ""
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(621, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 20)
        Label6.TabIndex = 5
        Label6.Text = "Search Employee"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(16, 110)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(263, 23)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "November 2025"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(320, 110)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(250, 23)
        ComboBox2.TabIndex = 7
        ComboBox2.Text = "All Position"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(622, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search...."
        TextBox1.Size = New Size(292, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(14, 148)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 37)
        Button1.TabIndex = 9
        Button1.Text = "Generate Payroll"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(159, 148)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 37)
        Button2.TabIndex = 10
        Button2.Text = "Lock Period"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Controls.Add(Label12)
        RoundedPanel4.Controls.Add(Label9)
        RoundedPanel4.Location = New Point(45, 395)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(294, 118)
        RoundedPanel4.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AccessibleDescription = ""
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(15, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 20)
        Label9.TabIndex = 3
        Label9.Text = "Payroll Period"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(Label7)
        RoundedPanel5.Location = New Point(361, 395)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(294, 118)
        RoundedPanel5.TabIndex = 13
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Controls.Add(Label11)
        RoundedPanel6.Controls.Add(Label8)
        RoundedPanel6.Location = New Point(679, 395)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(294, 118)
        RoundedPanel6.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AccessibleDescription = ""
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(18, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 20)
        Label7.TabIndex = 4
        Label7.Text = "Total Gross Pay"
        ' 
        ' Label8
        ' 
        Label8.AccessibleDescription = ""
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(16, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 20)
        Label8.TabIndex = 5
        Label8.Text = "Total Net Pay"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Blue
        Label10.Location = New Point(18, 54)
        Label10.Name = "Label10"
        Label10.Size = New Size(144, 40)
        Label10.TabIndex = 5
        Label10.Text = "₱ 4759.00"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(16, 54)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 40)
        Label11.TabIndex = 6
        Label11.Text = "₱ 4739.00"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(15, 54)
        Label12.Name = "Label12"
        Label12.Size = New Size(167, 40)
        Label12.TabIndex = 6
        Label12.Text = "11/05/2025"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(65, 536)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(889, 290)
        DataGridView1.TabIndex = 15
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Controls.Add(RoundedButton4)
        RoundedPanel7.Controls.Add(RoundedButton5)
        RoundedPanel7.Controls.Add(RoundedButton6)
        RoundedPanel7.Controls.Add(RoundedButton7)
        RoundedPanel7.Location = New Point(60, 111)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(889, 44)
        RoundedPanel7.TabIndex = 11
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = Color.White
        RoundedButton4.BorderColor = Color.Gray
        RoundedButton4.BorderRadius = 20
        RoundedButton4.BorderSize = 2
        RoundedButton4.ClickColor = Color.DarkGray
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton4.HoverColor = Color.LightGray
        RoundedButton4.Location = New Point(257, 6)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.SelectedColor = Color.Silver
        RoundedButton4.Size = New Size(177, 32)
        RoundedButton4.TabIndex = 3
        RoundedButton4.TabStop = False
        RoundedButton4.Text = "👤  Employees"
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton5
        ' 
        RoundedButton5.BackColor = Color.White
        RoundedButton5.BorderColor = Color.Gray
        RoundedButton5.BorderRadius = 20
        RoundedButton5.BorderSize = 2
        RoundedButton5.ClickColor = Color.DarkGray
        RoundedButton5.FlatStyle = FlatStyle.Flat
        RoundedButton5.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton5.HoverColor = Color.LightGray
        RoundedButton5.Location = New Point(468, 6)
        RoundedButton5.Name = "RoundedButton5"
        RoundedButton5.SelectedColor = Color.Silver
        RoundedButton5.Size = New Size(177, 32)
        RoundedButton5.TabIndex = 2
        RoundedButton5.TabStop = False
        RoundedButton5.Text = "📆  Attendance"
        RoundedButton5.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton6
        ' 
        RoundedButton6.BackColor = Color.White
        RoundedButton6.BorderColor = Color.Gray
        RoundedButton6.BorderRadius = 20
        RoundedButton6.BorderSize = 2
        RoundedButton6.ClickColor = Color.DarkGray
        RoundedButton6.FlatStyle = FlatStyle.Flat
        RoundedButton6.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton6.HoverColor = Color.LightGray
        RoundedButton6.Location = New Point(674, 6)
        RoundedButton6.Name = "RoundedButton6"
        RoundedButton6.SelectedColor = Color.Silver
        RoundedButton6.Size = New Size(177, 32)
        RoundedButton6.TabIndex = 1
        RoundedButton6.TabStop = False
        RoundedButton6.Text = "📄  Payroll"
        RoundedButton6.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton7
        ' 
        RoundedButton7.BackColor = Color.White
        RoundedButton7.BorderColor = Color.Gray
        RoundedButton7.BorderRadius = 20
        RoundedButton7.BorderSize = 2
        RoundedButton7.ClickColor = Color.DarkGray
        RoundedButton7.FlatStyle = FlatStyle.Flat
        RoundedButton7.Font = New Font("Berlin Sans FB", 12F)
        RoundedButton7.HoverColor = Color.LightGray
        RoundedButton7.Location = New Point(47, 6)
        RoundedButton7.Name = "RoundedButton7"
        RoundedButton7.SelectedColor = Color.Silver
        RoundedButton7.Size = New Size(177, 32)
        RoundedButton7.TabIndex = 0
        RoundedButton7.TabStop = False
        RoundedButton7.Text = "📊  Dashboard"
        RoundedButton7.UseVisualStyleBackColor = False
        ' 
        ' AdminPayroll
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel7)
        Controls.Add(DataGridView1)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel1)
        Name = "AdminPayroll"
        Text = "Payroll"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel7.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents RoundedButton4 As RoundedButton
    Friend WithEvents RoundedButton5 As RoundedButton
    Friend WithEvents RoundedButton6 As RoundedButton
    Friend WithEvents RoundedButton7 As RoundedButton
End Class