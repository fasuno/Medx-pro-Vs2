<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewdrugs
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Expdat = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtBatchno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRoderlev = New System.Windows.Forms.TextBox()
        Me.TxtLocat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcostperunit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdrugid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbounit = New System.Windows.Forms.ComboBox()
        Me.cbodrugcat = New System.Windows.Forms.ComboBox()
        Me.txtstockbal = New System.Windows.Forms.TextBox()
        Me.txtnewstock = New System.Windows.Forms.TextBox()
        Me.txtdrugname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSavedrug = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.txtpassw = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbldate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Expdat)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtBatchno)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtRoderlev)
        Me.Panel1.Controls.Add(Me.TxtLocat)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtdrugid)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbounit)
        Me.Panel1.Controls.Add(Me.cbodrugcat)
        Me.Panel1.Controls.Add(Me.txtstockbal)
        Me.Panel1.Controls.Add(Me.txtnewstock)
        Me.Panel1.Controls.Add(Me.txtdrugname)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 220)
        Me.Panel1.TabIndex = 1
        '
        'Expdat
        '
        Me.Expdat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expdat.Location = New System.Drawing.Point(198, 122)
        Me.Expdat.Name = "Expdat"
        Me.Expdat.Size = New System.Drawing.Size(203, 21)
        Me.Expdat.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(119, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 15)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Expiry Date:"
        '
        'TxtBatchno
        '
        Me.TxtBatchno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBatchno.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBatchno.Location = New System.Drawing.Point(379, 63)
        Me.TxtBatchno.Name = "TxtBatchno"
        Me.TxtBatchno.Size = New System.Drawing.Size(90, 21)
        Me.TxtBatchno.TabIndex = 27
        Me.TxtBatchno.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Batch No.:"
        '
        'txtRoderlev
        '
        Me.txtRoderlev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoderlev.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoderlev.Location = New System.Drawing.Point(356, 94)
        Me.txtRoderlev.Name = "txtRoderlev"
        Me.txtRoderlev.Size = New System.Drawing.Size(90, 21)
        Me.txtRoderlev.TabIndex = 25
        Me.txtRoderlev.Text = "0"
        '
        'TxtLocat
        '
        Me.TxtLocat.BackColor = System.Drawing.Color.White
        Me.TxtLocat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocat.Location = New System.Drawing.Point(99, 95)
        Me.TxtLocat.Name = "TxtLocat"
        Me.TxtLocat.Size = New System.Drawing.Size(155, 21)
        Me.TxtLocat.TabIndex = 24
        Me.TxtLocat.Text = " "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(262, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Re-order Level:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Location:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcostperunit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(43, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 65)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COST PER UNIT"
        '
        'txtcostperunit
        '
        Me.txtcostperunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcostperunit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcostperunit.ForeColor = System.Drawing.Color.Black
        Me.txtcostperunit.Location = New System.Drawing.Point(58, 32)
        Me.txtcostperunit.Name = "txtcostperunit"
        Me.txtcostperunit.Size = New System.Drawing.Size(65, 21)
        Me.txtcostperunit.TabIndex = 11
        Me.txtcostperunit.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Private:"
        '
        'txtdrugid
        '
        Me.txtdrugid.BackColor = System.Drawing.Color.White
        Me.txtdrugid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdrugid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrugid.Location = New System.Drawing.Point(391, 8)
        Me.txtdrugid.Name = "txtdrugid"
        Me.txtdrugid.ReadOnly = True
        Me.txtdrugid.Size = New System.Drawing.Size(79, 21)
        Me.txtdrugid.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(361, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID:"
        '
        'cbounit
        '
        Me.cbounit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbounit.BackColor = System.Drawing.Color.White
        Me.cbounit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbounit.ForeColor = System.Drawing.Color.Black
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {"Ampoule", "Assortment", "Assembly", "Ball", "Bundle", "Bale", "Board Foot", "Bag", "Book", "Barrel", "Bolt", "Bar", "Bottle", "Box", "Cartridge", "Carboy", "Cubic Yard", "Cone", "Cubic Foot", "Cake", "Coil", "Can", "Container", "Cylinder", "Cubic Meter", "Drum", "Dozen", "Each", "Foot", "Five", "Fifty", "Gallon", "Group", "Gross", "Hundred", "Carton", "Hank", "Inch", "Jar", "Kit", "Pound", "Length", "Liter", "Thousand Cubic Foot", "Meal", "Meter", "Thousand", "Outfit", "Ounce", "Pad", "Package", "Plate", "Pair", "Pieces", "Pint", "Packet", "Quart", "Ration", "Reel", "Ream", "Roll", "Sachets", "Skid", "Set", "Square Foot", "Sheet", "Skein", "Spool", "Shot", "Strip", "Stick", "Square Yard", "Twenty-four", "Ten", "Twenty-five", "Ton", "Troy Ounce", "Thirty-six", "Tube", "Vial", "Yard"})
        Me.cbounit.Location = New System.Drawing.Point(334, 35)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(136, 23)
        Me.cbounit.TabIndex = 14
        '
        'cbodrugcat
        '
        Me.cbodrugcat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodrugcat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodrugcat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbodrugcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodrugcat.FormattingEnabled = True
        Me.cbodrugcat.Items.AddRange(New Object() {"ANALGESICS", "ANTI-MALARIA", "HAEMATINICS/MULTIVITAMINS", "ANTI-BIOTICS", "ANTI-ULCER", "ANTI-SPASMODIC", "ANTI-DIARRHOEA", "ANTI-ASTHMATIC", "ANTI-HYPERTENSIVE", "ANTI-EMETIC", "ANTI-FUNGAL", "ANTI-ALLERGIC", "ANTI-TUSSIVE", "EYE AND EAR PREPARATIONS", "INFUSIONS", "SURGICALS", "STEROIDS", "ANTI-DIABETICS", "ANTI-HELMINTHIC", "EMERGENCY DRUGS", "SUPPLEMENTARY", "CONSUMABLE"})
        Me.cbodrugcat.Location = New System.Drawing.Point(101, 35)
        Me.cbodrugcat.Name = "cbodrugcat"
        Me.cbodrugcat.Size = New System.Drawing.Size(187, 23)
        Me.cbodrugcat.TabIndex = 13
        '
        'txtstockbal
        '
        Me.txtstockbal.BackColor = System.Drawing.Color.White
        Me.txtstockbal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstockbal.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstockbal.Location = New System.Drawing.Point(99, 63)
        Me.txtstockbal.Name = "txtstockbal"
        Me.txtstockbal.ReadOnly = True
        Me.txtstockbal.Size = New System.Drawing.Size(67, 21)
        Me.txtstockbal.TabIndex = 10
        Me.txtstockbal.Text = "0"
        '
        'txtnewstock
        '
        Me.txtnewstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnewstock.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewstock.Location = New System.Drawing.Point(245, 62)
        Me.txtnewstock.Name = "txtnewstock"
        Me.txtnewstock.Size = New System.Drawing.Size(60, 21)
        Me.txtnewstock.TabIndex = 9
        Me.txtnewstock.Text = "0"
        '
        'txtdrugname
        '
        Me.txtdrugname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdrugname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdrugname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrugname.Location = New System.Drawing.Point(100, 8)
        Me.txtdrugname.Name = "txtdrugname"
        Me.txtdrugname.Size = New System.Drawing.Size(258, 21)
        Me.txtdrugname.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "New Stock:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Stock Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(294, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Unit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Drug Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Drug Name:"
        '
        'BtnSavedrug
        '
        Me.BtnSavedrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavedrug.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavedrug.Location = New System.Drawing.Point(322, 268)
        Me.BtnSavedrug.Name = "BtnSavedrug"
        Me.BtnSavedrug.Size = New System.Drawing.Size(76, 31)
        Me.BtnSavedrug.TabIndex = 17
        Me.BtnSavedrug.Text = "SAVE"
        Me.BtnSavedrug.UseVisualStyleBackColor = True
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(478, 277)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(13, 13)
        Me.lblusername.TabIndex = 18
        Me.lblusername.Text = "0"
        Me.lblusername.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(245, 268)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(74, 31)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(322, 268)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 31)
        Me.BtnUpdate.TabIndex = 16
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'txtpassw
        '
        Me.txtpassw.BackColor = System.Drawing.Color.White
        Me.txtpassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassw.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassw.Location = New System.Drawing.Point(80, 278)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassw.Size = New System.Drawing.Size(155, 21)
        Me.txtpassw.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Password:"
        '
        'Btnclose
        '
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.Location = New System.Drawing.Point(400, 268)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(74, 31)
        Me.Btnclose.TabIndex = 27
        Me.Btnclose.Text = "CLOSE"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Lbldate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 36)
        Me.Panel2.TabIndex = 28
        '
        'Lbldate
        '
        Me.Lbldate.AutoSize = True
        Me.Lbldate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldate.ForeColor = System.Drawing.Color.White
        Me.Lbldate.Location = New System.Drawing.Point(392, 9)
        Me.Lbldate.Name = "Lbldate"
        Me.Lbldate.Size = New System.Drawing.Size(32, 15)
        Me.Lbldate.TabIndex = 25
        Me.Lbldate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(113, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "DRUG ENTRY FORM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Location = New System.Drawing.Point(1, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(504, 12)
        Me.Panel3.TabIndex = 29
        '
        'FrmNewdrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 319)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.txtpassw)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.BtnSavedrug)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewdrugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DRUGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbounit As ComboBox
    Friend WithEvents cbodrugcat As ComboBox
    Friend WithEvents txtcostperunit As TextBox
    Friend WithEvents txtstockbal As TextBox
    Friend WithEvents txtnewstock As TextBox
    Friend WithEvents txtdrugname As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSavedrug As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdrugid As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtLocat As TextBox
    Friend WithEvents txtRoderlev As TextBox
    Friend WithEvents TxtBatchno As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Expdat As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtpassw As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Btnclose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbldate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
End Class
