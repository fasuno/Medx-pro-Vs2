<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLABORATORY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLABORATORY))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabLaboratory = New System.Windows.Forms.TabControl()
        Me.TabBilled = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkAllbill = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtbillto = New System.Windows.Forms.DateTimePicker()
        Me.dtbillfrom = New System.Windows.Forms.DateTimePicker()
        Me.txtfindbill = New System.Windows.Forms.TextBox()
        Me.Btnrefbill = New System.Windows.Forms.Button()
        Me.btnfindbill = New System.Windows.Forms.Button()
        Me.Dtgbiiled = New System.Windows.Forms.DataGridView()
        Me.TabPaid = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkallrev = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datrevto = New System.Windows.Forms.DateTimePicker()
        Me.datrevfrm = New System.Windows.Forms.DateTimePicker()
        Me.txtserchrev = New System.Windows.Forms.TextBox()
        Me.BtnLoadRevw = New System.Windows.Forms.Button()
        Me.btnserchrev = New System.Windows.Forms.Button()
        Me.DtgReview = New System.Windows.Forms.DataGridView()
        Me.TabTreated = New System.Windows.Forms.TabPage()
        Me.DtgLabtrt = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtlabTo = New System.Windows.Forms.DateTimePicker()
        Me.DtLabfrm = New System.Windows.Forms.DateTimePicker()
        Me.txttreatlab = New System.Windows.Forms.TextBox()
        Me.BtnLoadTreat = New System.Windows.Forms.Button()
        Me.btnsrchtreat = New System.Windows.Forms.Button()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabLaboratory.SuspendLayout()
        Me.TabBilled.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPaid.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DtgReview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTreated.SuspendLayout()
        CType(Me.DtgLabtrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabLaboratory
        '
        Me.tabLaboratory.Controls.Add(Me.TabBilled)
        Me.tabLaboratory.Controls.Add(Me.TabPaid)
        Me.tabLaboratory.Controls.Add(Me.TabTreated)
        Me.tabLaboratory.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLaboratory.Location = New System.Drawing.Point(0, 7)
        Me.tabLaboratory.Name = "tabLaboratory"
        Me.tabLaboratory.SelectedIndex = 0
        Me.tabLaboratory.Size = New System.Drawing.Size(1136, 452)
        Me.tabLaboratory.TabIndex = 2
        '
        'TabBilled
        '
        Me.TabBilled.Controls.Add(Me.Panel3)
        Me.TabBilled.Controls.Add(Me.Dtgbiiled)
        Me.TabBilled.Location = New System.Drawing.Point(4, 24)
        Me.TabBilled.Name = "TabBilled"
        Me.TabBilled.Size = New System.Drawing.Size(1128, 424)
        Me.TabBilled.TabIndex = 2
        Me.TabBilled.Text = "TEST REQUEST"
        Me.TabBilled.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ChkAllbill)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtbillto)
        Me.Panel3.Controls.Add(Me.dtbillfrom)
        Me.Panel3.Controls.Add(Me.txtfindbill)
        Me.Panel3.Controls.Add(Me.Btnrefbill)
        Me.Panel3.Controls.Add(Me.btnfindbill)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 40)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "To"
        '
        'ChkAllbill
        '
        Me.ChkAllbill.AutoSize = True
        Me.ChkAllbill.ForeColor = System.Drawing.Color.Maroon
        Me.ChkAllbill.Location = New System.Drawing.Point(778, 14)
        Me.ChkAllbill.Name = "ChkAllbill"
        Me.ChkAllbill.Size = New System.Drawing.Size(70, 19)
        Me.ChkAllbill.TabIndex = 17
        Me.ChkAllbill.Text = "View All"
        Me.ChkAllbill.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(431, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To"
        '
        'dtbillto
        '
        Me.dtbillto.Location = New System.Drawing.Point(249, 13)
        Me.dtbillto.Name = "dtbillto"
        Me.dtbillto.Size = New System.Drawing.Size(210, 21)
        Me.dtbillto.TabIndex = 15
        '
        'dtbillfrom
        '
        Me.dtbillfrom.Location = New System.Drawing.Point(7, 13)
        Me.dtbillfrom.Name = "dtbillfrom"
        Me.dtbillfrom.Size = New System.Drawing.Size(211, 21)
        Me.dtbillfrom.TabIndex = 14
        '
        'txtfindbill
        '
        Me.txtfindbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfindbill.Location = New System.Drawing.Point(854, 13)
        Me.txtfindbill.Name = "txtfindbill"
        Me.txtfindbill.Size = New System.Drawing.Size(153, 21)
        Me.txtfindbill.TabIndex = 12
        '
        'Btnrefbill
        '
        Me.Btnrefbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnrefbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnrefbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrefbill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnrefbill.Image = CType(resources.GetObject("Btnrefbill.Image"), System.Drawing.Image)
        Me.Btnrefbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnrefbill.Location = New System.Drawing.Point(468, 12)
        Me.Btnrefbill.Name = "Btnrefbill"
        Me.Btnrefbill.Size = New System.Drawing.Size(95, 23)
        Me.Btnrefbill.TabIndex = 11
        Me.Btnrefbill.Text = "    Refresh"
        Me.Btnrefbill.UseVisualStyleBackColor = False
        '
        'btnfindbill
        '
        Me.btnfindbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindbill.ForeColor = System.Drawing.Color.Green
        Me.btnfindbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfindbill.Location = New System.Drawing.Point(1026, 11)
        Me.btnfindbill.Name = "btnfindbill"
        Me.btnfindbill.Size = New System.Drawing.Size(84, 24)
        Me.btnfindbill.TabIndex = 13
        Me.btnfindbill.Text = "Search"
        Me.btnfindbill.UseVisualStyleBackColor = False
        '
        'Dtgbiiled
        '
        Me.Dtgbiiled.AllowUserToAddRows = False
        Me.Dtgbiiled.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.Dtgbiiled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dtgbiiled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgbiiled.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dtgbiiled.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dtgbiiled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dtgbiiled.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dtgbiiled.GridColor = System.Drawing.Color.LightGray
        Me.Dtgbiiled.Location = New System.Drawing.Point(5, 49)
        Me.Dtgbiiled.Name = "Dtgbiiled"
        Me.Dtgbiiled.ReadOnly = True
        Me.Dtgbiiled.Size = New System.Drawing.Size(1120, 372)
        Me.Dtgbiiled.TabIndex = 0
        '
        'TabPaid
        '
        Me.TabPaid.Controls.Add(Me.Panel4)
        Me.TabPaid.Controls.Add(Me.DtgReview)
        Me.TabPaid.Location = New System.Drawing.Point(4, 24)
        Me.TabPaid.Name = "TabPaid"
        Me.TabPaid.Size = New System.Drawing.Size(1128, 424)
        Me.TabPaid.TabIndex = 3
        Me.TabPaid.Text = "REVIEW"
        Me.TabPaid.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.chkallrev)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.datrevto)
        Me.Panel4.Controls.Add(Me.datrevfrm)
        Me.Panel4.Controls.Add(Me.txtserchrev)
        Me.Panel4.Controls.Add(Me.BtnLoadRevw)
        Me.Panel4.Controls.Add(Me.btnserchrev)
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1128, 40)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "To"
        '
        'chkallrev
        '
        Me.chkallrev.AutoSize = True
        Me.chkallrev.ForeColor = System.Drawing.Color.Maroon
        Me.chkallrev.Location = New System.Drawing.Point(804, 13)
        Me.chkallrev.Name = "chkallrev"
        Me.chkallrev.Size = New System.Drawing.Size(70, 19)
        Me.chkallrev.TabIndex = 17
        Me.chkallrev.Text = "View All"
        Me.chkallrev.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(431, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "To"
        '
        'datrevto
        '
        Me.datrevto.Location = New System.Drawing.Point(249, 13)
        Me.datrevto.Name = "datrevto"
        Me.datrevto.Size = New System.Drawing.Size(229, 21)
        Me.datrevto.TabIndex = 15
        '
        'datrevfrm
        '
        Me.datrevfrm.Location = New System.Drawing.Point(7, 13)
        Me.datrevfrm.Name = "datrevfrm"
        Me.datrevfrm.Size = New System.Drawing.Size(211, 21)
        Me.datrevfrm.TabIndex = 14
        '
        'txtserchrev
        '
        Me.txtserchrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserchrev.Location = New System.Drawing.Point(880, 13)
        Me.txtserchrev.Name = "txtserchrev"
        Me.txtserchrev.Size = New System.Drawing.Size(153, 21)
        Me.txtserchrev.TabIndex = 12
        '
        'BtnLoadRevw
        '
        Me.BtnLoadRevw.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLoadRevw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadRevw.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadRevw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLoadRevw.Image = CType(resources.GetObject("BtnLoadRevw.Image"), System.Drawing.Image)
        Me.BtnLoadRevw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoadRevw.Location = New System.Drawing.Point(484, 12)
        Me.BtnLoadRevw.Name = "BtnLoadRevw"
        Me.BtnLoadRevw.Size = New System.Drawing.Size(89, 23)
        Me.BtnLoadRevw.TabIndex = 11
        Me.BtnLoadRevw.Text = "     Refresh"
        Me.BtnLoadRevw.UseVisualStyleBackColor = False
        '
        'btnserchrev
        '
        Me.btnserchrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnserchrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnserchrev.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserchrev.ForeColor = System.Drawing.Color.Green
        Me.btnserchrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnserchrev.Location = New System.Drawing.Point(1039, 11)
        Me.btnserchrev.Name = "btnserchrev"
        Me.btnserchrev.Size = New System.Drawing.Size(82, 24)
        Me.btnserchrev.TabIndex = 13
        Me.btnserchrev.Text = "Search"
        Me.btnserchrev.UseVisualStyleBackColor = False
        '
        'DtgReview
        '
        Me.DtgReview.AllowUserToAddRows = False
        Me.DtgReview.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DtgReview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgReview.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgReview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgReview.DefaultCellStyle = DataGridViewCellStyle6
        Me.DtgReview.GridColor = System.Drawing.Color.LightGray
        Me.DtgReview.Location = New System.Drawing.Point(4, 48)
        Me.DtgReview.Name = "DtgReview"
        Me.DtgReview.ReadOnly = True
        Me.DtgReview.Size = New System.Drawing.Size(1120, 373)
        Me.DtgReview.TabIndex = 2
        '
        'TabTreated
        '
        Me.TabTreated.Controls.Add(Me.DtgLabtrt)
        Me.TabTreated.Controls.Add(Me.Label4)
        Me.TabTreated.Controls.Add(Me.Label5)
        Me.TabTreated.Controls.Add(Me.Panel2)
        Me.TabTreated.ForeColor = System.Drawing.Color.Transparent
        Me.TabTreated.Location = New System.Drawing.Point(4, 24)
        Me.TabTreated.Name = "TabTreated"
        Me.TabTreated.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTreated.Size = New System.Drawing.Size(1128, 424)
        Me.TabTreated.TabIndex = 1
        Me.TabTreated.Text = "  TREATED"
        Me.TabTreated.UseVisualStyleBackColor = True
        '
        'DtgLabtrt
        '
        Me.DtgLabtrt.AllowUserToAddRows = False
        Me.DtgLabtrt.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue
        Me.DtgLabtrt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DtgLabtrt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgLabtrt.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgLabtrt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DtgLabtrt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgLabtrt.DefaultCellStyle = DataGridViewCellStyle9
        Me.DtgLabtrt.GridColor = System.Drawing.Color.Maroon
        Me.DtgLabtrt.Location = New System.Drawing.Point(3, 51)
        Me.DtgLabtrt.Name = "DtgLabtrt"
        Me.DtgLabtrt.ReadOnly = True
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.DtgLabtrt.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DtgLabtrt.Size = New System.Drawing.Size(1119, 367)
        Me.DtgLabtrt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(111, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " Records found."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DtlabTo)
        Me.Panel2.Controls.Add(Me.DtLabfrm)
        Me.Panel2.Controls.Add(Me.txttreatlab)
        Me.Panel2.Controls.Add(Me.BtnLoadTreat)
        Me.Panel2.Controls.Add(Me.btnsrchtreat)
        Me.Panel2.Location = New System.Drawing.Point(4, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1128, 40)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(232, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "To"
        '
        'DtlabTo
        '
        Me.DtlabTo.Location = New System.Drawing.Point(266, 13)
        Me.DtlabTo.Name = "DtlabTo"
        Me.DtlabTo.Size = New System.Drawing.Size(210, 21)
        Me.DtlabTo.TabIndex = 15
        '
        'DtLabfrm
        '
        Me.DtLabfrm.Location = New System.Drawing.Point(12, 13)
        Me.DtLabfrm.Name = "DtLabfrm"
        Me.DtLabfrm.Size = New System.Drawing.Size(211, 21)
        Me.DtLabfrm.TabIndex = 14
        '
        'txttreatlab
        '
        Me.txttreatlab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttreatlab.Location = New System.Drawing.Point(795, 13)
        Me.txttreatlab.Name = "txttreatlab"
        Me.txttreatlab.Size = New System.Drawing.Size(153, 21)
        Me.txttreatlab.TabIndex = 12
        '
        'BtnLoadTreat
        '
        Me.BtnLoadTreat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLoadTreat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadTreat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTreat.ForeColor = System.Drawing.Color.Blue
        Me.BtnLoadTreat.Image = CType(resources.GetObject("BtnLoadTreat.Image"), System.Drawing.Image)
        Me.BtnLoadTreat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoadTreat.Location = New System.Drawing.Point(485, 12)
        Me.BtnLoadTreat.Name = "BtnLoadTreat"
        Me.BtnLoadTreat.Size = New System.Drawing.Size(89, 23)
        Me.BtnLoadTreat.TabIndex = 11
        Me.BtnLoadTreat.Text = "     Refresh"
        Me.BtnLoadTreat.UseVisualStyleBackColor = False
        '
        'btnsrchtreat
        '
        Me.btnsrchtreat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsrchtreat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsrchtreat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrchtreat.ForeColor = System.Drawing.Color.Green
        Me.btnsrchtreat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsrchtreat.Location = New System.Drawing.Point(954, 10)
        Me.btnsrchtreat.Name = "btnsrchtreat"
        Me.btnsrchtreat.Size = New System.Drawing.Size(85, 24)
        Me.btnsrchtreat.TabIndex = 13
        Me.btnsrchtreat.Text = "Search"
        Me.btnsrchtreat.UseVisualStyleBackColor = False
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(20, 461)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(16, 16)
        Me.lblcount.TabIndex = 3
        Me.lblcount.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(71, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Records"
        '
        'frmLABORATORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 486)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.tabLaboratory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLABORATORY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "    LABORATORY INVESTIGATION REQUEST"
        Me.tabLaboratory.ResumeLayout(False)
        Me.TabBilled.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPaid.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DtgReview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTreated.ResumeLayout(False)
        Me.TabTreated.PerformLayout()
        CType(Me.DtgLabtrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabLaboratory As TabControl
    Friend WithEvents TabBilled As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkAllbill As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtbillto As DateTimePicker
    Friend WithEvents dtbillfrom As DateTimePicker
    Friend WithEvents txtfindbill As TextBox
    Friend WithEvents Btnrefbill As Button
    Friend WithEvents btnfindbill As Button
    Friend WithEvents Dtgbiiled As DataGridView
    Friend WithEvents TabPaid As TabPage
    Friend WithEvents TabTreated As TabPage
    Friend WithEvents DtgLabtrt As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DtlabTo As DateTimePicker
    Friend WithEvents DtLabfrm As DateTimePicker
    Friend WithEvents txttreatlab As TextBox
    Friend WithEvents BtnLoadTreat As Button
    Friend WithEvents btnsrchtreat As Button
    Friend WithEvents lblcount As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents chkallrev As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents datrevto As DateTimePicker
    Friend WithEvents datrevfrm As DateTimePicker
    Friend WithEvents txtserchrev As TextBox
    Friend WithEvents BtnLoadRevw As Button
    Friend WithEvents btnserchrev As Button
    Friend WithEvents DtgReview As DataGridView
End Class
