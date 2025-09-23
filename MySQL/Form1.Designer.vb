<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TabControl1 = New TabControl()
        detailstab = New TabPage()
        Button2 = New Button()
        savbtn = New Button()
        GroupBox2 = New GroupBox()
        Label12 = New Label()
        sufbox = New ComboBox()
        cstlbl = New Label()
        suflbl = New Label()
        addlbl = New Label()
        emalbl = New Label()
        conlbl = New Label()
        genlbl = New Label()
        bdylbl = New Label()
        lnlbl = New Label()
        mnlbl = New Label()
        fnlbl = New Label()
        addbox = New TextBox()
        Label10 = New Label()
        cstbox = New ComboBox()
        genbox = New ComboBox()
        Label21 = New Label()
        sufcb = New CheckBox()
        mncb = New CheckBox()
        agebox = New TextBox()
        emabox = New TextBox()
        conbox = New TextBox()
        bdybox = New DateTimePicker()
        lnbox = New TextBox()
        mnbox = New TextBox()
        fnbox = New TextBox()
        Label15 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        sallbl = New Label()
        Label11 = New Label()
        poslbl = New Label()
        posbox = New ComboBox()
        salbox = New TextBox()
        idbox = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Label1 = New Label()
        dgvtab = New TabPage()
        delbtn = New Button()
        updbtn = New Button()
        dgvEmployees = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        refbtn = New Button()
        TabControl1.SuspendLayout()
        detailstab.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        dgvtab.SuspendLayout()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(detailstab)
        TabControl1.Controls.Add(dgvtab)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1018, 660)
        TabControl1.TabIndex = 0
        ' 
        ' detailstab
        ' 
        detailstab.Controls.Add(Button2)
        detailstab.Controls.Add(savbtn)
        detailstab.Controls.Add(GroupBox2)
        detailstab.Controls.Add(GroupBox1)
        detailstab.Location = New Point(4, 26)
        detailstab.Name = "detailstab"
        detailstab.Padding = New Padding(3)
        detailstab.Size = New Size(1010, 630)
        detailstab.TabIndex = 0
        detailstab.Text = "TabPage1"
        detailstab.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(509, 589)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 24
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' savbtn
        ' 
        savbtn.Location = New Point(388, 589)
        savbtn.Name = "savbtn"
        savbtn.Size = New Size(75, 23)
        savbtn.TabIndex = 23
        savbtn.Text = "Save"
        savbtn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(sufbox)
        GroupBox2.Controls.Add(cstlbl)
        GroupBox2.Controls.Add(suflbl)
        GroupBox2.Controls.Add(addlbl)
        GroupBox2.Controls.Add(emalbl)
        GroupBox2.Controls.Add(conlbl)
        GroupBox2.Controls.Add(genlbl)
        GroupBox2.Controls.Add(bdylbl)
        GroupBox2.Controls.Add(lnlbl)
        GroupBox2.Controls.Add(mnlbl)
        GroupBox2.Controls.Add(fnlbl)
        GroupBox2.Controls.Add(addbox)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(cstbox)
        GroupBox2.Controls.Add(genbox)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Controls.Add(sufcb)
        GroupBox2.Controls.Add(mncb)
        GroupBox2.Controls.Add(agebox)
        GroupBox2.Controls.Add(emabox)
        GroupBox2.Controls.Add(conbox)
        GroupBox2.Controls.Add(bdybox)
        GroupBox2.Controls.Add(lnbox)
        GroupBox2.Controls.Add(mnbox)
        GroupBox2.Controls.Add(fnbox)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Segoe UI", 9F)
        GroupBox2.Location = New Point(6, 234)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(996, 349)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        GroupBox2.Text = "Save"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(171, 209)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 23)
        Label12.TabIndex = 49
        Label12.Text = "+63"
        ' 
        ' sufbox
        ' 
        sufbox.DropDownStyle = ComboBoxStyle.DropDownList
        sufbox.Font = New Font("Microsoft Sans Serif", 12F)
        sufbox.FormattingEnabled = True
        sufbox.Items.AddRange(New Object() {"Sr.", "Jr.", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"})
        sufbox.Location = New Point(645, 109)
        sufbox.Name = "sufbox"
        sufbox.Size = New Size(224, 28)
        sufbox.TabIndex = 27
        ' 
        ' cstlbl
        ' 
        cstlbl.AutoSize = True
        cstlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cstlbl.ForeColor = Color.Red
        cstlbl.Location = New Point(624, 175)
        cstlbl.Name = "cstlbl"
        cstlbl.Size = New Size(21, 25)
        cstlbl.TabIndex = 48
        cstlbl.Text = "*"
        ' 
        ' suflbl
        ' 
        suflbl.AutoSize = True
        suflbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        suflbl.ForeColor = Color.Red
        suflbl.Location = New Point(624, 109)
        suflbl.Name = "suflbl"
        suflbl.Size = New Size(21, 25)
        suflbl.TabIndex = 47
        suflbl.Text = "*"
        ' 
        ' addlbl
        ' 
        addlbl.AutoSize = True
        addlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addlbl.ForeColor = Color.Red
        addlbl.Location = New Point(149, 280)
        addlbl.Name = "addlbl"
        addlbl.Size = New Size(21, 25)
        addlbl.TabIndex = 46
        addlbl.Text = "*"
        ' 
        ' emalbl
        ' 
        emalbl.AutoSize = True
        emalbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emalbl.ForeColor = Color.Red
        emalbl.Location = New Point(149, 243)
        emalbl.Name = "emalbl"
        emalbl.Size = New Size(21, 25)
        emalbl.TabIndex = 45
        emalbl.Text = "*"
        ' 
        ' conlbl
        ' 
        conlbl.AutoSize = True
        conlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        conlbl.ForeColor = Color.Red
        conlbl.Location = New Point(149, 205)
        conlbl.Name = "conlbl"
        conlbl.Size = New Size(21, 25)
        conlbl.TabIndex = 44
        conlbl.Text = "*"
        ' 
        ' genlbl
        ' 
        genlbl.AutoSize = True
        genlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genlbl.ForeColor = Color.Red
        genlbl.Location = New Point(149, 169)
        genlbl.Name = "genlbl"
        genlbl.Size = New Size(21, 25)
        genlbl.TabIndex = 43
        genlbl.Text = "*"
        ' 
        ' bdylbl
        ' 
        bdylbl.AutoSize = True
        bdylbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bdylbl.ForeColor = Color.Red
        bdylbl.Location = New Point(149, 137)
        bdylbl.Name = "bdylbl"
        bdylbl.Size = New Size(21, 25)
        bdylbl.TabIndex = 27
        bdylbl.Text = "*"
        ' 
        ' lnlbl
        ' 
        lnlbl.AutoSize = True
        lnlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnlbl.ForeColor = Color.Red
        lnlbl.Location = New Point(149, 107)
        lnlbl.Name = "lnlbl"
        lnlbl.Size = New Size(21, 25)
        lnlbl.TabIndex = 42
        lnlbl.Text = "*"
        ' 
        ' mnlbl
        ' 
        mnlbl.AutoSize = True
        mnlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnlbl.ForeColor = Color.Red
        mnlbl.Location = New Point(149, 70)
        mnlbl.Name = "mnlbl"
        mnlbl.Size = New Size(21, 25)
        mnlbl.TabIndex = 41
        mnlbl.Text = "*"
        ' 
        ' fnlbl
        ' 
        fnlbl.AutoSize = True
        fnlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fnlbl.ForeColor = Color.Red
        fnlbl.Location = New Point(149, 39)
        fnlbl.Name = "fnlbl"
        fnlbl.Size = New Size(21, 25)
        fnlbl.TabIndex = 27
        fnlbl.Text = "*"
        ' 
        ' addbox
        ' 
        addbox.Font = New Font("Microsoft Sans Serif", 12F)
        addbox.Location = New Point(171, 279)
        addbox.Name = "addbox"
        addbox.Size = New Size(698, 26)
        addbox.TabIndex = 40
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label10.Location = New Point(26, 280)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 39
        Label10.Text = "Address"
        ' 
        ' cstbox
        ' 
        cstbox.DropDownStyle = ComboBoxStyle.DropDownList
        cstbox.Font = New Font("Microsoft Sans Serif", 12F)
        cstbox.FormattingEnabled = True
        cstbox.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        cstbox.Location = New Point(645, 176)
        cstbox.Name = "cstbox"
        cstbox.Size = New Size(224, 28)
        cstbox.TabIndex = 38
        ' 
        ' genbox
        ' 
        genbox.DropDownStyle = ComboBoxStyle.DropDownList
        genbox.Font = New Font("Microsoft Sans Serif", 12F)
        genbox.FormattingEnabled = True
        genbox.Items.AddRange(New Object() {"Male", "Female", "I prefer not to say"})
        genbox.Location = New Point(171, 171)
        genbox.Name = "genbox"
        genbox.Size = New Size(265, 28)
        genbox.TabIndex = 37
        ' 
        ' Label21
        ' 
        Label21.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label21.Location = New Point(524, 177)
        Label21.Name = "Label21"
        Label21.Size = New Size(111, 23)
        Label21.TabIndex = 36
        Label21.Text = "Civil Status"
        ' 
        ' sufcb
        ' 
        sufcb.AutoEllipsis = True
        sufcb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sufcb.Location = New Point(875, 110)
        sufcb.Name = "sufcb"
        sufcb.Size = New Size(108, 28)
        sufcb.TabIndex = 35
        sufcb.Text = "I have no Suffix"
        sufcb.UseVisualStyleBackColor = True
        ' 
        ' mncb
        ' 
        mncb.AutoEllipsis = True
        mncb.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mncb.Location = New Point(442, 71)
        mncb.Name = "mncb"
        mncb.Size = New Size(147, 28)
        mncb.TabIndex = 34
        mncb.Text = "I have no Middle Name"
        mncb.UseVisualStyleBackColor = True
        ' 
        ' agebox
        ' 
        agebox.Enabled = False
        agebox.Font = New Font("Microsoft Sans Serif", 12F)
        agebox.Location = New Point(645, 143)
        agebox.Name = "agebox"
        agebox.ReadOnly = True
        agebox.Size = New Size(224, 26)
        agebox.TabIndex = 33
        agebox.TabStop = False
        ' 
        ' emabox
        ' 
        emabox.Font = New Font("Microsoft Sans Serif", 12F)
        emabox.Location = New Point(171, 242)
        emabox.Name = "emabox"
        emabox.Size = New Size(265, 26)
        emabox.TabIndex = 31
        ' 
        ' conbox
        ' 
        conbox.Font = New Font("Microsoft Sans Serif", 12F)
        conbox.Location = New Point(206, 206)
        conbox.Name = "conbox"
        conbox.Size = New Size(230, 26)
        conbox.TabIndex = 30
        ' 
        ' bdybox
        ' 
        bdybox.Font = New Font("Microsoft Sans Serif", 12F)
        bdybox.Location = New Point(171, 139)
        bdybox.Name = "bdybox"
        bdybox.Size = New Size(265, 26)
        bdybox.TabIndex = 28
        ' 
        ' lnbox
        ' 
        lnbox.Font = New Font("Microsoft Sans Serif", 12F)
        lnbox.Location = New Point(171, 105)
        lnbox.Name = "lnbox"
        lnbox.Size = New Size(265, 26)
        lnbox.TabIndex = 26
        ' 
        ' mnbox
        ' 
        mnbox.Font = New Font("Microsoft Sans Serif", 12F)
        mnbox.Location = New Point(171, 71)
        mnbox.Name = "mnbox"
        mnbox.Size = New Size(265, 26)
        mnbox.TabIndex = 25
        ' 
        ' fnbox
        ' 
        fnbox.Font = New Font("Microsoft Sans Serif", 12F)
        fnbox.Location = New Point(171, 39)
        fnbox.Name = "fnbox"
        fnbox.Size = New Size(265, 26)
        fnbox.TabIndex = 24
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label15.Location = New Point(528, 141)
        Label15.Name = "Label15"
        Label15.Size = New Size(70, 34)
        Label15.TabIndex = 23
        Label15.Text = "Age"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label9.Location = New Point(26, 243)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 22
        Label9.Text = "E-mail"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label8.Location = New Point(26, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 21
        Label8.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label7.Location = New Point(528, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 23)
        Label7.TabIndex = 20
        Label7.Text = "Suffix"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label6.Location = New Point(26, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 19
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label5.Location = New Point(26, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 18
        Label5.Text = "Birthdate"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label4.Location = New Point(26, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 17
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label3.Location = New Point(26, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 23)
        Label3.TabIndex = 16
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label2.Location = New Point(26, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 23)
        Label2.TabIndex = 15
        Label2.Text = "First Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(sallbl)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(poslbl)
        GroupBox1.Controls.Add(posbox)
        GroupBox1.Controls.Add(salbox)
        GroupBox1.Controls.Add(idbox)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9F)
        GroupBox1.Location = New Point(6, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(996, 205)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employment Details"
        ' 
        ' sallbl
        ' 
        sallbl.AutoSize = True
        sallbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sallbl.ForeColor = Color.Red
        sallbl.Location = New Point(371, 120)
        sallbl.Name = "sallbl"
        sallbl.Size = New Size(21, 25)
        sallbl.TabIndex = 26
        sallbl.Text = "*"
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(395, 118)
        Label11.Name = "Label11"
        Label11.Size = New Size(25, 30)
        Label11.TabIndex = 27
        Label11.Text = "₱"
        ' 
        ' poslbl
        ' 
        poslbl.AutoSize = True
        poslbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        poslbl.ForeColor = Color.Red
        poslbl.Location = New Point(370, 85)
        poslbl.Name = "poslbl"
        poslbl.Size = New Size(21, 25)
        poslbl.TabIndex = 25
        poslbl.Text = "*"
        ' 
        ' posbox
        ' 
        posbox.DropDownStyle = ComboBoxStyle.DropDownList
        posbox.Font = New Font("Microsoft Sans Serif", 12F)
        posbox.FormattingEnabled = True
        posbox.Items.AddRange(New Object() {"Cashier", "Stock Clerk", "Department Manager", "Custodian", "Food Preparation Worker", "Shopping Cart Attendant", "Pharmacist", "Front-End Manager", "Produce Clerk", "Meat and Seafood Clerk", "Bakery Clerk"})
        posbox.Location = New Point(403, 86)
        posbox.Name = "posbox"
        posbox.Size = New Size(404, 28)
        posbox.TabIndex = 23
        ' 
        ' salbox
        ' 
        salbox.Font = New Font("Microsoft Sans Serif", 12F)
        salbox.Location = New Point(418, 121)
        salbox.Name = "salbox"
        salbox.Size = New Size(389, 26)
        salbox.TabIndex = 22
        ' 
        ' idbox
        ' 
        idbox.Enabled = False
        idbox.Font = New Font("Microsoft Sans Serif", 12F)
        idbox.Location = New Point(403, 49)
        idbox.Name = "idbox"
        idbox.ReadOnly = True
        idbox.Size = New Size(404, 26)
        idbox.TabIndex = 20
        idbox.TabStop = False
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label18.Location = New Point(253, 84)
        Label18.Name = "Label18"
        Label18.Size = New Size(169, 37)
        Label18.TabIndex = 17
        Label18.Text = "Position"
        ' 
        ' Label19
        ' 
        Label19.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label19.Location = New Point(253, 121)
        Label19.Name = "Label19"
        Label19.Size = New Size(169, 37)
        Label19.TabIndex = 18
        Label19.Text = "Salary"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label1.Location = New Point(253, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 37)
        Label1.TabIndex = 0
        Label1.Text = "Employee  ID"
        ' 
        ' dgvtab
        ' 
        dgvtab.Controls.Add(refbtn)
        dgvtab.Controls.Add(delbtn)
        dgvtab.Controls.Add(updbtn)
        dgvtab.Controls.Add(dgvEmployees)
        dgvtab.Location = New Point(4, 26)
        dgvtab.Name = "dgvtab"
        dgvtab.Padding = New Padding(3)
        dgvtab.Size = New Size(1010, 630)
        dgvtab.TabIndex = 1
        dgvtab.Text = "TabPage2"
        dgvtab.UseVisualStyleBackColor = True
        ' 
        ' delbtn
        ' 
        delbtn.Location = New Point(543, 586)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(75, 41)
        delbtn.TabIndex = 2
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = True
        ' 
        ' updbtn
        ' 
        updbtn.Location = New Point(373, 586)
        updbtn.Name = "updbtn"
        updbtn.Size = New Size(75, 41)
        updbtn.TabIndex = 1
        updbtn.Text = "Update"
        updbtn.UseVisualStyleBackColor = True
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(0, 45)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.ReadOnly = True
        dgvEmployees.Size = New Size(1010, 535)
        dgvEmployees.TabIndex = 0
        ' 
        ' refbtn
        ' 
        refbtn.Location = New Point(925, 2)
        refbtn.Name = "refbtn"
        refbtn.Size = New Size(75, 41)
        refbtn.TabIndex = 3
        refbtn.Text = "Refresh"
        refbtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(800, 600)
        ClientSize = New Size(1018, 660)
        Controls.Add(TabControl1)
        KeyPreview = True
        Name = "Form1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        detailstab.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        dgvtab.ResumeLayout(False)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents detailstab As TabPage
    Friend WithEvents dgvtab As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idbox As TextBox
    Friend WithEvents lnbox As TextBox
    Friend WithEvents mnbox As TextBox
    Friend WithEvents fnbox As TextBox
    Friend WithEvents salbox As TextBox
    Friend WithEvents emabox As TextBox
    Friend WithEvents conbox As TextBox
    Friend WithEvents bdybox As DateTimePicker
    Friend WithEvents agebox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents sufcb As CheckBox
    Friend WithEvents mncb As CheckBox
    Friend WithEvents cstbox As ComboBox
    Friend WithEvents genbox As ComboBox
    Friend WithEvents posbox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents savbtn As Button
    Friend WithEvents addbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents genlbl As Label
    Friend WithEvents bdylbl As Label
    Friend WithEvents lnlbl As Label
    Friend WithEvents mnlbl As Label
    Friend WithEvents fnlbl As Label
    Friend WithEvents sallbl As Label
    Friend WithEvents poslbl As Label
    Friend WithEvents cstlbl As Label
    Friend WithEvents addlbl As Label
    Friend WithEvents emalbl As Label
    Friend WithEvents conlbl As Label
    Friend WithEvents sufbox As ComboBox
    Friend WithEvents suflbl As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents updbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents refbtn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
