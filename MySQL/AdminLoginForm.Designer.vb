<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        btnBack = New Button()
        adminlbl = New Label()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(931, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' adminlbl
        ' 
        adminlbl.Font = New Font("Microsoft YaHei", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminlbl.Location = New Point(396, 102)
        adminlbl.Name = "adminlbl"
        adminlbl.Size = New Size(255, 45)
        adminlbl.TabIndex = 2
        adminlbl.Text = "Admin Portal"
        adminlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(367, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 45)
        Label1.TabIndex = 3
        Label1.Text = "DailyDing Employee Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Location = New Point(338, 239)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(389, 400)
        RoundedPanel1.TabIndex = 4
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Controls.Add(adminlbl)
        Controls.Add(btnBack)
        Name = "AdminLoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents adminlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
End Class
