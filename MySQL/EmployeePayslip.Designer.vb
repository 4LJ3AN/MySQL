<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeePayslip
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
        RoundedPanel3 = New RoundedPanel()
        btnGeneratePDF = New Button()
        cmbPayslipRecords = New ComboBox()
        Label3 = New Label()
        pays = New Label()
        RoundedPanel4 = New RoundedPanel()
        lblOTPay = New Label()
        Label9 = New Label()
        lblBasicPay = New Label()
        Label7 = New Label()
        lblTotalDeductions = New Label()
        Label31 = New Label()
        lblGrossPay = New Label()
        lblPagibig = New Label()
        lblSSS = New Label()
        lblIncomeTax = New Label()
        Label26 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        lblOTHours = New Label()
        lblBasicHours = New Label()
        RoundedPanel6 = New RoundedPanel()
        lblNetPay = New Label()
        Label32 = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label2 = New Label()
        lblPayPeriodEnd = New Label()
        Label12 = New Label()
        lblPayPeriodStart = New Label()
        Label10 = New Label()
        namelbl = New Label()
        Label8 = New Label()
        Label6 = New Label()
        poslbl = New Label()
        idlbl = New Label()
        Label20 = New Label()
        Label28 = New Label()
        Label14 = New Label()
        Label4 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        btnBack = New Button()
        RoundedPanel2 = New RoundedPanel()
        checkInbtn = New RoundedButton()
        profile = New RoundedButton()
        attendance = New RoundedButton()
        payslip = New RoundedButton()
        dashb = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        positionlbl = New Label()
        empIDlbl = New Label()
        welcomelbl = New Label()
        Label1 = New Label()
        lblPayslipId = New Label()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Controls.Add(btnGeneratePDF)
        RoundedPanel3.Controls.Add(cmbPayslipRecords)
        RoundedPanel3.Controls.Add(Label3)
        RoundedPanel3.Controls.Add(pays)
        RoundedPanel3.Location = New Point(162, 205)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(694, 100)
        RoundedPanel3.TabIndex = 4
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.FlatStyle = FlatStyle.Flat
        btnGeneratePDF.Location = New Point(576, 58)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(90, 23)
        btnGeneratePDF.TabIndex = 7
        btnGeneratePDF.Text = "Generate PDF"
        btnGeneratePDF.UseVisualStyleBackColor = True
        ' 
        ' cmbPayslipRecords
        ' 
        cmbPayslipRecords.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPayslipRecords.FormattingEnabled = True
        cmbPayslipRecords.Location = New Point(20, 58)
        cmbPayslipRecords.Name = "cmbPayslipRecords"
        cmbPayslipRecords.Size = New Size(242, 23)
        cmbPayslipRecords.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonShadow
        Label3.Location = New Point(10, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 23)
        Label3.TabIndex = 5
        Label3.Text = "Choose a month to view your payslip"
        ' 
        ' pays
        ' 
        pays.AutoSize = True
        pays.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pays.Location = New Point(10, 13)
        pays.Name = "pays"
        pays.Size = New Size(183, 18)
        pays.TabIndex = 5
        pays.Text = "Select Payslip Record"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(lblOTPay)
        RoundedPanel4.Controls.Add(Label9)
        RoundedPanel4.Controls.Add(lblBasicPay)
        RoundedPanel4.Controls.Add(Label7)
        RoundedPanel4.Controls.Add(lblTotalDeductions)
        RoundedPanel4.Controls.Add(Label31)
        RoundedPanel4.Controls.Add(lblGrossPay)
        RoundedPanel4.Controls.Add(lblPagibig)
        RoundedPanel4.Controls.Add(lblSSS)
        RoundedPanel4.Controls.Add(lblIncomeTax)
        RoundedPanel4.Controls.Add(Label26)
        RoundedPanel4.Controls.Add(Label23)
        RoundedPanel4.Controls.Add(Label24)
        RoundedPanel4.Controls.Add(lblOTHours)
        RoundedPanel4.Controls.Add(lblBasicHours)
        RoundedPanel4.Controls.Add(RoundedPanel6)
        RoundedPanel4.Controls.Add(RoundedPanel5)
        RoundedPanel4.Controls.Add(Label20)
        RoundedPanel4.Controls.Add(Label28)
        RoundedPanel4.Controls.Add(Label14)
        RoundedPanel4.Controls.Add(Label4)
        RoundedPanel4.Controls.Add(Label17)
        RoundedPanel4.Controls.Add(Label15)
        RoundedPanel4.Location = New Point(133, 311)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(753, 361)
        RoundedPanel4.TabIndex = 5
        ' 
        ' lblOTPay
        ' 
        lblOTPay.AutoSize = True
        lblOTPay.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOTPay.Location = New Point(203, 251)
        lblOTPay.Name = "lblOTPay"
        lblOTPay.Size = New Size(56, 16)
        lblOTPay.TabIndex = 22
        lblOTPay.Text = "₱ 6,900"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonShadow
        Label9.Location = New Point(25, 226)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 20)
        Label9.TabIndex = 21
        Label9.Text = "Overtime Hours:"
        ' 
        ' lblBasicPay
        ' 
        lblBasicPay.AutoSize = True
        lblBasicPay.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBasicPay.Location = New Point(203, 205)
        lblBasicPay.Name = "lblBasicPay"
        lblBasicPay.Size = New Size(56, 16)
        lblBasicPay.TabIndex = 20
        lblBasicPay.Text = "₱ 6,900"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonShadow
        Label7.Location = New Point(25, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 19
        Label7.Text = "Basic Hours:"
        ' 
        ' lblTotalDeductions
        ' 
        lblTotalDeductions.AutoSize = True
        lblTotalDeductions.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDeductions.Location = New Point(627, 278)
        lblTotalDeductions.Name = "lblTotalDeductions"
        lblTotalDeductions.Size = New Size(56, 16)
        lblTotalDeductions.TabIndex = 18
        lblTotalDeductions.Text = "₱ 1,571"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(438, 278)
        Label31.Name = "Label31"
        Label31.Size = New Size(148, 18)
        Label31.TabIndex = 17
        Label31.Text = "Total Deductions:"
        ' 
        ' lblGrossPay
        ' 
        lblGrossPay.AutoSize = True
        lblGrossPay.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrossPay.Location = New Point(203, 278)
        lblGrossPay.Name = "lblGrossPay"
        lblGrossPay.Size = New Size(56, 16)
        lblGrossPay.TabIndex = 16
        lblGrossPay.Text = "₱ 7,700"
        ' 
        ' lblPagibig
        ' 
        lblPagibig.AutoSize = True
        lblPagibig.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagibig.Location = New Point(626, 226)
        lblPagibig.Name = "lblPagibig"
        lblPagibig.Size = New Size(44, 16)
        lblPagibig.TabIndex = 15
        lblPagibig.Text = "₱ 567"
        ' 
        ' lblSSS
        ' 
        lblSSS.AutoSize = True
        lblSSS.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSSS.Location = New Point(626, 203)
        lblSSS.Name = "lblSSS"
        lblSSS.Size = New Size(44, 16)
        lblSSS.TabIndex = 14
        lblSSS.Text = "₱ 234"
        ' 
        ' lblIncomeTax
        ' 
        lblIncomeTax.AutoSize = True
        lblIncomeTax.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIncomeTax.Location = New Point(626, 180)
        lblIncomeTax.Name = "lblIncomeTax"
        lblIncomeTax.Size = New Size(44, 16)
        lblIncomeTax.TabIndex = 13
        lblIncomeTax.Text = "₱ 770"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.ButtonShadow
        Label26.Location = New Point(447, 226)
        Label26.Name = "Label26"
        Label26.Size = New Size(54, 20)
        Label26.TabIndex = 10
        Label26.Text = "Pagibig:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ButtonShadow
        Label23.Location = New Point(447, 203)
        Label23.Name = "Label23"
        Label23.Size = New Size(36, 20)
        Label23.TabIndex = 10
        Label23.Text = "SSS:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.ButtonShadow
        Label24.Location = New Point(448, 180)
        Label24.Name = "Label24"
        Label24.Size = New Size(82, 20)
        Label24.TabIndex = 11
        Label24.Text = "Income Tax :"
        ' 
        ' lblOTHours
        ' 
        lblOTHours.AutoSize = True
        lblOTHours.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOTHours.Location = New Point(203, 228)
        lblOTHours.Name = "lblOTHours"
        lblOTHours.Size = New Size(72, 16)
        lblOTHours.TabIndex = 9
        lblOTHours.Text = "69420 hrs"
        ' 
        ' lblBasicHours
        ' 
        lblBasicHours.AutoSize = True
        lblBasicHours.Font = New Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBasicHours.Location = New Point(203, 182)
        lblBasicHours.Name = "lblBasicHours"
        lblBasicHours.Size = New Size(72, 16)
        lblBasicHours.TabIndex = 8
        lblBasicHours.Text = "69420 hrs"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        RoundedPanel6.Controls.Add(lblNetPay)
        RoundedPanel6.Controls.Add(Label32)
        RoundedPanel6.Location = New Point(10, 301)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(731, 37)
        RoundedPanel6.TabIndex = 7
        ' 
        ' lblNetPay
        ' 
        lblNetPay.AutoSize = True
        lblNetPay.Font = New Font("Century", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNetPay.Location = New Point(595, 8)
        lblNetPay.Name = "lblNetPay"
        lblNetPay.Size = New Size(74, 21)
        lblNetPay.TabIndex = 18
        lblNetPay.Text = "₱ 6,129"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(26, 7)
        Label32.Name = "Label32"
        Label32.Size = New Size(87, 22)
        Label32.TabIndex = 0
        Label32.Text = "Net Pay:"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = SystemColors.ControlLight
        RoundedPanel5.Controls.Add(Label2)
        RoundedPanel5.Controls.Add(lblPayPeriodEnd)
        RoundedPanel5.Controls.Add(Label12)
        RoundedPanel5.Controls.Add(lblPayPeriodStart)
        RoundedPanel5.Controls.Add(Label10)
        RoundedPanel5.Controls.Add(namelbl)
        RoundedPanel5.Controls.Add(Label8)
        RoundedPanel5.Controls.Add(Label6)
        RoundedPanel5.Controls.Add(poslbl)
        RoundedPanel5.Controls.Add(idlbl)
        RoundedPanel5.Location = New Point(11, 42)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(730, 112)
        RoundedPanel5.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(252, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 10
        Label2.Text = "End of Pay Period:"
        ' 
        ' lblPayPeriodEnd
        ' 
        lblPayPeriodEnd.AutoSize = True
        lblPayPeriodEnd.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPayPeriodEnd.Location = New Point(252, 75)
        lblPayPeriodEnd.Name = "lblPayPeriodEnd"
        lblPayPeriodEnd.Size = New Size(53, 19)
        lblPayPeriodEnd.TabIndex = 11
        lblPayPeriodEnd.Text = "bukas"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonShadow
        Label12.Location = New Point(14, 56)
        Label12.Name = "Label12"
        Label12.Size = New Size(112, 20)
        Label12.TabIndex = 8
        Label12.Text = "Start of Pay Period:"
        ' 
        ' lblPayPeriodStart
        ' 
        lblPayPeriodStart.AutoSize = True
        lblPayPeriodStart.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPayPeriodStart.Location = New Point(14, 75)
        lblPayPeriodStart.Name = "lblPayPeriodStart"
        lblPayPeriodStart.Size = New Size(75, 19)
        lblPayPeriodStart.TabIndex = 9
        lblPayPeriodStart.Text = "kahapon"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonShadow
        Label10.Location = New Point(252, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 23)
        Label10.TabIndex = 6
        Label10.Text = "Employee Name:"
        ' 
        ' namelbl
        ' 
        namelbl.AutoSize = True
        namelbl.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        namelbl.Location = New Point(252, 29)
        namelbl.Name = "namelbl"
        namelbl.Size = New Size(124, 19)
        namelbl.TabIndex = 7
        namelbl.Text = "Gian Dela Torre"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonShadow
        Label8.Location = New Point(528, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 23)
        Label8.TabIndex = 5
        Label8.Text = "Position: "
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonShadow
        Label6.Location = New Point(14, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 23)
        Label6.TabIndex = 5
        Label6.Text = "Employee ID:"
        ' 
        ' poslbl
        ' 
        poslbl.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        poslbl.Location = New Point(528, 29)
        poslbl.Name = "poslbl"
        poslbl.Size = New Size(179, 65)
        poslbl.TabIndex = 5
        poslbl.Text = "Employee"
        ' 
        ' idlbl
        ' 
        idlbl.AutoSize = True
        idlbl.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        idlbl.Location = New Point(14, 29)
        idlbl.Name = "idlbl"
        idlbl.Size = New Size(73, 19)
        idlbl.TabIndex = 5
        idlbl.Text = "EM-1234"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(438, 157)
        Label20.Name = "Label20"
        Label20.Size = New Size(99, 18)
        Label20.TabIndex = 5
        Label20.Text = "Deductions"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(14, 278)
        Label28.Name = "Label28"
        Label28.Size = New Size(128, 18)
        Label28.TabIndex = 5
        Label28.Text = "Total Earnings:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(25, 157)
        Label14.Name = "Label14"
        Label14.Size = New Size(79, 18)
        Label14.TabIndex = 5
        Label14.Text = "Earnings"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(14, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 23)
        Label4.TabIndex = 5
        Label4.Text = "Payslip"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ButtonShadow
        Label17.Location = New Point(25, 249)
        Label17.Name = "Label17"
        Label17.Size = New Size(85, 20)
        Label17.TabIndex = 5
        Label17.Text = "Overtime Pay:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ButtonShadow
        Label15.Location = New Point(25, 203)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 20)
        Label15.TabIndex = 5
        Label15.Text = "Basic Salary :"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Left
        btnBack.Location = New Point(12, 625)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 8
        btnBack.Text = "Sign Out"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(checkInbtn)
        RoundedPanel2.Controls.Add(profile)
        RoundedPanel2.Controls.Add(attendance)
        RoundedPanel2.Controls.Add(payslip)
        RoundedPanel2.Controls.Add(dashb)
        RoundedPanel2.Location = New Point(80, 126)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(858, 49)
        RoundedPanel2.TabIndex = 9
        ' 
        ' checkInbtn
        ' 
        checkInbtn.BorderColor = Color.Gray
        checkInbtn.BorderRadius = 20
        checkInbtn.BorderSize = 2
        checkInbtn.ClickColor = Color.DarkGray
        checkInbtn.FlatStyle = FlatStyle.Flat
        checkInbtn.Font = New Font("Berlin Sans FB", 12F)
        checkInbtn.HoverColor = Color.LightGray
        checkInbtn.Location = New Point(6, 5)
        checkInbtn.Name = "checkInbtn"
        checkInbtn.SelectedColor = Color.Silver
        checkInbtn.Size = New Size(168, 37)
        checkInbtn.TabIndex = 8
        checkInbtn.TabStop = False
        checkInbtn.Text = "☑   Check In"
        checkInbtn.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        profile.BorderColor = Color.Gray
        profile.BorderRadius = 20
        profile.BorderSize = 2
        profile.ClickColor = Color.DarkGray
        profile.FlatStyle = FlatStyle.Flat
        profile.Font = New Font("Berlin Sans FB", 12F)
        profile.HoverColor = Color.LightGray
        profile.Location = New Point(684, 5)
        profile.Name = "profile"
        profile.SelectedColor = Color.Silver
        profile.Size = New Size(168, 37)
        profile.TabIndex = 3
        profile.TabStop = False
        profile.Text = "👤  Profile"
        profile.UseVisualStyleBackColor = True
        ' 
        ' attendance
        ' 
        attendance.BorderColor = Color.Gray
        attendance.BorderRadius = 20
        attendance.BorderSize = 2
        attendance.ClickColor = Color.DarkGray
        attendance.FlatStyle = FlatStyle.Flat
        attendance.Font = New Font("Berlin Sans FB", 12F)
        attendance.HoverColor = Color.LightGray
        attendance.Location = New Point(515, 6)
        attendance.Name = "attendance"
        attendance.SelectedColor = Color.Silver
        attendance.Size = New Size(168, 37)
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
        payslip.Font = New Font("Berlin Sans FB", 12F)
        payslip.HoverColor = Color.LightGray
        payslip.Location = New Point(346, 6)
        payslip.Name = "payslip"
        payslip.SelectedColor = Color.Silver
        payslip.Size = New Size(168, 37)
        payslip.TabIndex = 1
        payslip.TabStop = False
        payslip.Text = "📄  Payslip"
        payslip.UseVisualStyleBackColor = True
        ' 
        ' dashb
        ' 
        dashb.BorderColor = Color.Gray
        dashb.BorderRadius = 20
        dashb.BorderSize = 2
        dashb.ClickColor = Color.DarkGray
        dashb.FlatStyle = FlatStyle.Flat
        dashb.Font = New Font("Berlin Sans FB", 12F)
        dashb.HoverColor = Color.LightGray
        dashb.Location = New Point(176, 6)
        dashb.Name = "dashb"
        dashb.SelectedColor = Color.Silver
        dashb.Size = New Size(168, 37)
        dashb.TabIndex = 0
        dashb.TabStop = False
        dashb.Text = "📊  Dashboard"
        dashb.UseVisualStyleBackColor = True
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
        positionlbl.Size = New Size(123, 17)
        positionlbl.TabIndex = 1
        positionlbl.Text = "Position: Employee"
        ' 
        ' empIDlbl
        ' 
        empIDlbl.AccessibleDescription = ""
        empIDlbl.AutoSize = True
        empIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        empIDlbl.Location = New Point(770, 19)
        empIDlbl.Name = "empIDlbl"
        empIDlbl.Size = New Size(165, 20)
        empIDlbl.TabIndex = 3
        empIDlbl.Text = "Employee ID: EMP1234"
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
        Label1.Text = "Employee Portal"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPayslipId
        ' 
        lblPayslipId.AutoSize = True
        lblPayslipId.Location = New Point(950, 625)
        lblPayslipId.Name = "lblPayslipId"
        lblPayslipId.Size = New Size(41, 15)
        lblPayslipId.TabIndex = 11
        lblPayslipId.Text = "Label5"
        lblPayslipId.Visible = False
        ' 
        ' EmployeePayslip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 660)
        Controls.Add(lblPayslipId)
        Controls.Add(RoundedPanel1)
        Controls.Add(RoundedPanel2)
        Controls.Add(btnBack)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Name = "EmployeePayslip"
        Text = "Payslip"
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents pays As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents idlbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents poslbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPayPeriodStart As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblBasicHours As Label
    Friend WithEvents lblOTHours As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblPagibig As Label
    Friend WithEvents lblSSS As Label
    Friend WithEvents lblIncomeTax As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblTotalDeductions As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents checkInbtn As RoundedButton
    Friend WithEvents profile As RoundedButton
    Friend WithEvents attendance As RoundedButton
    Friend WithEvents payslip As RoundedButton
    Friend WithEvents dashb As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents positionlbl As Label
    Friend WithEvents empIDlbl As Label
    Friend WithEvents welcomelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPayslipRecords As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPayPeriodEnd As Label
    Friend WithEvents lblBasicPay As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblOTPay As Label
    Friend WithEvents lblPayslipId As Label
    Friend WithEvents btnGeneratePDF As Button
End Class
