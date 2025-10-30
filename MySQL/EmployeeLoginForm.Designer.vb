<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeLoginForm
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
        RoundedPanel1 = New RoundedPanel()
        loginbtn = New RoundedButton()
        passwordtxt = New TextBox()
        pwlbl = New Label()
        usernametxt = New TextBox()
        Label1 = New Label()
        welcomelbl = New Label()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(931, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(239), CByte(236), CByte(231))
        RoundedPanel1.Controls.Add(loginbtn)
        RoundedPanel1.Controls.Add(passwordtxt)
        RoundedPanel1.Controls.Add(pwlbl)
        RoundedPanel1.Controls.Add(usernametxt)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(welcomelbl)
        RoundedPanel1.Location = New Point(195, 117)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(629, 427)
        RoundedPanel1.TabIndex = 1
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.White
        loginbtn.BorderColor = Color.Transparent
        loginbtn.BorderRadius = 20
        loginbtn.BorderSize = 1
        loginbtn.ClickColor = Color.DarkGray
        loginbtn.FlatAppearance.BorderSize = 0
        loginbtn.FlatStyle = FlatStyle.Flat
        loginbtn.Font = New Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.HoverColor = Color.LightGray
        loginbtn.Location = New Point(246, 301)
        loginbtn.Name = "loginbtn"
        loginbtn.SelectedColor = Color.Silver
        loginbtn.Size = New Size(137, 41)
        loginbtn.TabIndex = 7
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' passwordtxt
        ' 
        passwordtxt.Font = New Font("Microsoft Sans Serif", 15.75F)
        passwordtxt.Location = New Point(208, 221)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.Size = New Size(335, 31)
        passwordtxt.TabIndex = 6
        ' 
        ' pwlbl
        ' 
        pwlbl.AutoSize = True
        pwlbl.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pwlbl.Location = New Point(86, 224)
        pwlbl.Name = "pwlbl"
        pwlbl.Size = New Size(112, 25)
        pwlbl.TabIndex = 5
        pwlbl.Text = "Password:"
        ' 
        ' usernametxt
        ' 
        usernametxt.Font = New Font("Microsoft Sans Serif", 15.75F)
        usernametxt.Location = New Point(208, 158)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(335, 31)
        usernametxt.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(86, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' welcomelbl
        ' 
        welcomelbl.AccessibleName = ""
        welcomelbl.Anchor = AnchorStyles.Top
        welcomelbl.AutoSize = True
        welcomelbl.BackColor = Color.Transparent
        welcomelbl.Font = New Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcomelbl.Location = New Point(197, 30)
        welcomelbl.Name = "welcomelbl"
        welcomelbl.Size = New Size(234, 36)
        welcomelbl.TabIndex = 2
        welcomelbl.Text = "Employee Login"
        welcomelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmployeeLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnBack)
        Name = "EmployeeLoginForm"
        Text = "EmployeeLoginvb"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents pwlbl As Label
    Friend WithEvents loginbtn As RoundedButton
End Class
