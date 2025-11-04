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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        userbox = New TextBox()
        btnLogIn = New Button()
        passbox = New TextBox()
        hidepass = New CheckBox()
        lblError = New Label()
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
        adminlbl.Font = New Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminlbl.Location = New Point(420, 223)
        adminlbl.Name = "adminlbl"
        adminlbl.Size = New Size(225, 45)
        adminlbl.TabIndex = 2
        adminlbl.Text = "Admin Portal"
        adminlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(376, 258)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 25)
        Label1.TabIndex = 3
        Label1.Text = "DailyDing Employee Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft YaHei", 38.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(284, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(502, 101)
        Label2.TabIndex = 4
        Label2.Text = "DailyDing"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Edwardian Script ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(526, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 22)
        Label3.TabIndex = 5
        Label3.Text = "Grocery Store"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Eras Medium ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(295, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 25)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Eras Medium ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(293, 380)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 7
        Label5.Text = "Password"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' userbox
        ' 
        userbox.HideSelection = False
        userbox.Location = New Point(414, 337)
        userbox.Multiline = True
        userbox.Name = "userbox"
        userbox.Size = New Size(312, 25)
        userbox.TabIndex = 8
        userbox.TabStop = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.White
        btnLogIn.Font = New Font("Eras Medium ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogIn.Location = New Point(454, 475)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(110, 33)
        btnLogIn.TabIndex = 10
        btnLogIn.TabStop = False
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' passbox
        ' 
        passbox.BorderStyle = BorderStyle.FixedSingle
        passbox.HideSelection = False
        passbox.Location = New Point(414, 380)
        passbox.Multiline = True
        passbox.Name = "passbox"
        passbox.Size = New Size(312, 25)
        passbox.TabIndex = 11
        passbox.TabStop = False
        ' 
        ' hidepass
        ' 
        hidepass.AutoSize = True
        hidepass.Location = New Point(622, 411)
        hidepass.Name = "hidepass"
        hidepass.Size = New Size(108, 19)
        hidepass.TabIndex = 12
        hidepass.Text = "Show password"
        hidepass.UseVisualStyleBackColor = True
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.ForeColor = Color.Red
        lblError.Location = New Point(437, 438)
        lblError.Name = "lblError"
        lblError.Size = New Size(145, 15)
        lblError.TabIndex = 13
        lblError.Text = "Error fetching admin data."
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(1018, 660)
        Controls.Add(lblError)
        Controls.Add(hidepass)
        Controls.Add(passbox)
        Controls.Add(btnLogIn)
        Controls.Add(userbox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(adminlbl)
        Controls.Add(btnBack)
        Name = "AdminLoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents adminlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents userbox As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents passbox As TextBox
    Friend WithEvents hidepass As CheckBox
    Friend WithEvents lblError As Label
End Class
