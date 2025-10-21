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
        ' EmployeeLoginForm
        ' 
        BackColor = Color.LightSteelBlue
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(btnBack)
        Name = "EmployeeLoginForm"
        Text = "EmployeeLoginvb"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
End Class
