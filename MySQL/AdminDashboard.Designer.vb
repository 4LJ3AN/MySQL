<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        RoundedButton3 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(RoundedButton3)
        RoundedPanel2.Controls.Add(RoundedButton2)
        RoundedPanel2.Controls.Add(RoundedButton1)
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(60, 117)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(889, 44)
        RoundedPanel2.TabIndex = 2
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BorderColor = Color.Gray
        RoundedButton3.BorderRadius = 20
        RoundedButton3.BorderSize = 2
        RoundedButton3.ClickColor = Color.DarkGray
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton3.HoverColor = Color.LightGray
        RoundedButton3.Location = New Point(760, 6)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.SelectedColor = Color.Silver
        RoundedButton3.Size = New Size(119, 32)
        RoundedButton3.TabIndex = 6
        RoundedButton3.TabStop = False
        RoundedButton3.Text = "⚙️ Settings"
        RoundedButton3.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BorderColor = Color.Gray
        RoundedButton2.BorderRadius = 20
        RoundedButton2.BorderSize = 2
        RoundedButton2.ClickColor = Color.DarkGray
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton2.HoverColor = Color.LightGray
        RoundedButton2.Location = New Point(635, 6)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.SelectedColor = Color.Silver
        RoundedButton2.Size = New Size(119, 32)
        RoundedButton2.TabIndex = 5
        RoundedButton2.TabStop = False
        RoundedButton2.Text = "🚨 Reports"
        RoundedButton2.UseVisualStyleBackColor = True
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BorderColor = Color.Gray
        RoundedButton1.BorderRadius = 20
        RoundedButton1.BorderSize = 2
        RoundedButton1.ClickColor = Color.DarkGray
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Berlin Sans FB", 12.0F)
        RoundedButton1.HoverColor = Color.LightGray
        RoundedButton1.Location = New Point(510, 6)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.SelectedColor = Color.Silver
        RoundedButton1.Size = New Size(119, 32)
        RoundedButton1.TabIndex = 4
        RoundedButton1.TabStop = False
        RoundedButton1.Text = " 🚫 Deduction"
        RoundedButton1.UseVisualStyleBackColor = True
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
        profile.Location = New Point(135, 6)
        profile.Name = "profile"
        profile.SelectedColor = Color.Silver
        profile.Size = New Size(119, 32)
        profile.TabIndex = 3
        profile.TabStop = False
        profile.Text = "👤  Employees"
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
        attendance.Location = New Point(260, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(119, 32)
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
        payslip.Location = New Point(385, 6)
        payslip.Name = "payslip"
        payslip.SelectedColor = Color.Silver
        payslip.Size = New Size(119, 32)
        payslip.TabIndex = 1
        payslip.TabStop = False
        payslip.Text = "📄  Payroll"
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
        dashb.Location = New Point(10, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(119, 32)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboard
        ' 
        BackColor = Color.Linen
        ClientSize = New Size(1018, 660)
        Controls.Add(RoundedPanel2)
        Name = "AdminDashboard"
        Text = "Dashboard"
        RoundedPanel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click

    End Sub

    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
End Class