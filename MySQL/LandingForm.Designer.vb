<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LandingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingForm))
        Label1 = New Label()
        adminbtn = New Button()
        welcomelbl = New Label()
        empbtn = New Button()
        RoundedPanel1 = New RoundedPanel()
        PictureBox1 = New PictureBox()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(550, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' adminbtn
        ' 
        adminbtn.Font = New Font("Myanmar Text", 18.0F, FontStyle.Bold)
        adminbtn.Location = New Point(283, 274)
        adminbtn.Name = "adminbtn"
        adminbtn.Size = New Size(219, 63)
        adminbtn.TabIndex = 4
        adminbtn.TabStop = False
        adminbtn.Text = "Admin"
        adminbtn.TextAlign = ContentAlignment.BottomCenter
        adminbtn.UseVisualStyleBackColor = True
        ' 
        ' welcomelbl
        ' 
        welcomelbl.AccessibleName = ""
        welcomelbl.Anchor = AnchorStyles.Top
        welcomelbl.BackColor = Color.Transparent
        welcomelbl.Font = New Font("Microsoft YaHei", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcomelbl.Location = New Point(274, 59)
        welcomelbl.Name = "welcomelbl"
        welcomelbl.Size = New Size(404, 130)
        welcomelbl.TabIndex = 1
        welcomelbl.Text = "Welcome to Daily Ding Employee Management System!"
        welcomelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' empbtn
        ' 
        empbtn.Font = New Font("Myanmar Text", 18.0F, FontStyle.Bold)
        empbtn.Location = New Point(283, 380)
        empbtn.Name = "empbtn"
        empbtn.Size = New Size(219, 63)
        empbtn.TabIndex = 5
        empbtn.TabStop = False
        empbtn.Text = "Employee"
        empbtn.TextAlign = ContentAlignment.BottomCenter
        empbtn.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(239), CByte(236), CByte(231))
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Controls.Add(welcomelbl)
        RoundedPanel1.Controls.Add(empbtn)
        RoundedPanel1.Controls.Add(adminbtn)
        RoundedPanel1.Location = New Point(117, 73)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(785, 514)
        RoundedPanel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(60, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 152)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' LandingForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Name = "LandingForm"
        Text = "Form2"
        RoundedPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents adminbtn As Button
    Friend WithEvents welcomelbl As Label
    Friend WithEvents empbtn As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox


End Class
