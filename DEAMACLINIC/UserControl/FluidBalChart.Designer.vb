<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FluidBalChart
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DtgFluidIn = New System.Windows.Forms.DataGridView()
        Me.DtgFluidOut = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTube = New System.Windows.Forms.TextBox()
        Me.TxtOral = New System.Windows.Forms.TextBox()
        Me.TxtIV = New System.Windows.Forms.TextBox()
        Me.TxtTotIn = New System.Windows.Forms.TextBox()
        Me.TxtUrine = New System.Windows.Forms.TextBox()
        Me.TxtVomit = New System.Windows.Forms.TextBox()
        Me.TxtFeases = New System.Windows.Forms.TextBox()
        Me.TxtTotOut = New System.Windows.Forms.TextBox()
        Me.TxtBal = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dtgfluidbal = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Lblchartid = New System.Windows.Forms.Label()
        Me.txtfldbal = New System.Windows.Forms.TextBox()
        CType(Me.DtgFluidIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgFluidOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dtgfluidbal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgFluidIn
        '
        Me.DtgFluidIn.AllowUserToAddRows = False
        Me.DtgFluidIn.AllowUserToDeleteRows = False
        Me.DtgFluidIn.AllowUserToResizeColumns = False
        Me.DtgFluidIn.AllowUserToResizeRows = False
        Me.DtgFluidIn.BackgroundColor = System.Drawing.Color.White
        Me.DtgFluidIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgFluidIn.Location = New System.Drawing.Point(3, 29)
        Me.DtgFluidIn.Name = "DtgFluidIn"
        Me.DtgFluidIn.RowHeadersVisible = False
        Me.DtgFluidIn.Size = New System.Drawing.Size(397, 180)
        Me.DtgFluidIn.TabIndex = 0
        '
        'DtgFluidOut
        '
        Me.DtgFluidOut.AllowUserToAddRows = False
        Me.DtgFluidOut.AllowUserToDeleteRows = False
        Me.DtgFluidOut.AllowUserToResizeColumns = False
        Me.DtgFluidOut.AllowUserToResizeRows = False
        Me.DtgFluidOut.BackgroundColor = System.Drawing.Color.White
        Me.DtgFluidOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgFluidOut.Location = New System.Drawing.Point(422, 29)
        Me.DtgFluidOut.Name = "DtgFluidOut"
        Me.DtgFluidOut.RowHeadersVisible = False
        Me.DtgFluidOut.Size = New System.Drawing.Size(403, 180)
        Me.DtgFluidOut.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 27)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(561, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OUTPUT (mL)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(140, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT (mL)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(405, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 34)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Location = New System.Drawing.Point(406, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 182)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Tube:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Oral:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total IV:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total Urine:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(659, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Vomit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(651, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Feases:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(220, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total In:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(419, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Total Out:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(329, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 19)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Fluid Retained:"
        '
        'TxtTube
        '
        Me.TxtTube.BackColor = System.Drawing.Color.White
        Me.TxtTube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTube.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTube.ForeColor = System.Drawing.Color.Black
        Me.TxtTube.Location = New System.Drawing.Point(98, 214)
        Me.TxtTube.Name = "TxtTube"
        Me.TxtTube.ReadOnly = True
        Me.TxtTube.Size = New System.Drawing.Size(59, 21)
        Me.TxtTube.TabIndex = 12
        Me.TxtTube.Text = "0"
        '
        'TxtOral
        '
        Me.TxtOral.BackColor = System.Drawing.Color.White
        Me.TxtOral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOral.ForeColor = System.Drawing.Color.Black
        Me.TxtOral.Location = New System.Drawing.Point(98, 238)
        Me.TxtOral.Name = "TxtOral"
        Me.TxtOral.ReadOnly = True
        Me.TxtOral.Size = New System.Drawing.Size(59, 21)
        Me.TxtOral.TabIndex = 13
        Me.TxtOral.Text = "0"
        '
        'TxtIV
        '
        Me.TxtIV.BackColor = System.Drawing.Color.White
        Me.TxtIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIV.ForeColor = System.Drawing.Color.Black
        Me.TxtIV.Location = New System.Drawing.Point(98, 262)
        Me.TxtIV.Name = "TxtIV"
        Me.TxtIV.ReadOnly = True
        Me.TxtIV.Size = New System.Drawing.Size(59, 21)
        Me.TxtIV.TabIndex = 14
        Me.TxtIV.Text = "0"
        '
        'TxtTotIn
        '
        Me.TxtTotIn.BackColor = System.Drawing.Color.White
        Me.TxtTotIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotIn.ForeColor = System.Drawing.Color.Black
        Me.TxtTotIn.Location = New System.Drawing.Point(293, 223)
        Me.TxtTotIn.Name = "TxtTotIn"
        Me.TxtTotIn.ReadOnly = True
        Me.TxtTotIn.Size = New System.Drawing.Size(106, 21)
        Me.TxtTotIn.TabIndex = 15
        Me.TxtTotIn.Text = "0"
        '
        'TxtUrine
        '
        Me.TxtUrine.BackColor = System.Drawing.Color.White
        Me.TxtUrine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUrine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUrine.ForeColor = System.Drawing.Color.Black
        Me.TxtUrine.Location = New System.Drawing.Point(753, 213)
        Me.TxtUrine.Name = "TxtUrine"
        Me.TxtUrine.ReadOnly = True
        Me.TxtUrine.Size = New System.Drawing.Size(59, 21)
        Me.TxtUrine.TabIndex = 16
        Me.TxtUrine.Text = "0"
        '
        'TxtVomit
        '
        Me.TxtVomit.BackColor = System.Drawing.Color.White
        Me.TxtVomit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVomit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVomit.ForeColor = System.Drawing.Color.Black
        Me.TxtVomit.Location = New System.Drawing.Point(753, 237)
        Me.TxtVomit.Name = "TxtVomit"
        Me.TxtVomit.ReadOnly = True
        Me.TxtVomit.Size = New System.Drawing.Size(59, 21)
        Me.TxtVomit.TabIndex = 17
        Me.TxtVomit.Text = "0"
        '
        'TxtFeases
        '
        Me.TxtFeases.BackColor = System.Drawing.Color.White
        Me.TxtFeases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFeases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFeases.ForeColor = System.Drawing.Color.Black
        Me.TxtFeases.Location = New System.Drawing.Point(753, 262)
        Me.TxtFeases.Name = "TxtFeases"
        Me.TxtFeases.ReadOnly = True
        Me.TxtFeases.Size = New System.Drawing.Size(59, 21)
        Me.TxtFeases.TabIndex = 18
        Me.TxtFeases.Text = "0"
        '
        'TxtTotOut
        '
        Me.TxtTotOut.BackColor = System.Drawing.Color.White
        Me.TxtTotOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotOut.ForeColor = System.Drawing.Color.Black
        Me.TxtTotOut.Location = New System.Drawing.Point(500, 222)
        Me.TxtTotOut.Name = "TxtTotOut"
        Me.TxtTotOut.ReadOnly = True
        Me.TxtTotOut.Size = New System.Drawing.Size(106, 21)
        Me.TxtTotOut.TabIndex = 19
        Me.TxtTotOut.Text = "0"
        '
        'TxtBal
        '
        Me.TxtBal.BackColor = System.Drawing.Color.White
        Me.TxtBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBal.ForeColor = System.Drawing.Color.Black
        Me.TxtBal.Location = New System.Drawing.Point(447, 254)
        Me.TxtBal.Name = "TxtBal"
        Me.TxtBal.ReadOnly = True
        Me.TxtBal.Size = New System.Drawing.Size(106, 24)
        Me.TxtBal.TabIndex = 20
        Me.TxtBal.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(2, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(824, 5)
        Me.Panel4.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(725, 293)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(87, 25)
        Me.BtnSave.TabIndex = 22
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtPass.ForeColor = System.Drawing.Color.Red
        Me.TxtPass.Location = New System.Drawing.Point(557, 297)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.TxtPass.Size = New System.Drawing.Size(166, 20)
        Me.TxtPass.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(469, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Enter Password"
        '
        'Dtgfluidbal
        '
        Me.Dtgfluidbal.AllowUserToAddRows = False
        Me.Dtgfluidbal.AllowUserToDeleteRows = False
        Me.Dtgfluidbal.AllowUserToResizeColumns = False
        Me.Dtgfluidbal.BackgroundColor = System.Drawing.Color.White
        Me.Dtgfluidbal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgfluidbal.Location = New System.Drawing.Point(2, 333)
        Me.Dtgfluidbal.Name = "Dtgfluidbal"
        Me.Dtgfluidbal.ReadOnly = True
        Me.Dtgfluidbal.RowHeadersVisible = False
        Me.Dtgfluidbal.Size = New System.Drawing.Size(823, 117)
        Me.Dtgfluidbal.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Location = New System.Drawing.Point(2, 322)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(824, 5)
        Me.Panel5.TabIndex = 3
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Blue
        Me.BtnNew.Location = New System.Drawing.Point(13, 295)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(115, 25)
        Me.BtnNew.TabIndex = 27
        Me.BtnNew.Text = "NEW SHEET"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUser.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.Blue
        Me.LblUser.Location = New System.Drawing.Point(247, 298)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(14, 19)
        Me.LblUser.TabIndex = 28
        Me.LblUser.Text = " "
        Me.LblUser.Visible = False
        '
        'Lblchartid
        '
        Me.Lblchartid.AutoSize = True
        Me.Lblchartid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblchartid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblchartid.ForeColor = System.Drawing.Color.Blue
        Me.Lblchartid.Location = New System.Drawing.Point(185, 261)
        Me.Lblchartid.Name = "Lblchartid"
        Me.Lblchartid.Size = New System.Drawing.Size(14, 19)
        Me.Lblchartid.TabIndex = 29
        Me.Lblchartid.Text = " "
        Me.Lblchartid.Visible = False
        '
        'txtfldbal
        '
        Me.txtfldbal.BackColor = System.Drawing.Color.White
        Me.txtfldbal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfldbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfldbal.ForeColor = System.Drawing.Color.Black
        Me.txtfldbal.Location = New System.Drawing.Point(256, 254)
        Me.txtfldbal.Name = "txtfldbal"
        Me.txtfldbal.ReadOnly = True
        Me.txtfldbal.Size = New System.Drawing.Size(67, 24)
        Me.txtfldbal.TabIndex = 30
        Me.txtfldbal.Text = "0"
        Me.txtfldbal.WordWrap = False
        '
        'FluidBalChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtfldbal)
        Me.Controls.Add(Me.Lblchartid)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Dtgfluidbal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtBal)
        Me.Controls.Add(Me.TxtTotOut)
        Me.Controls.Add(Me.TxtFeases)
        Me.Controls.Add(Me.TxtVomit)
        Me.Controls.Add(Me.TxtUrine)
        Me.Controls.Add(Me.TxtTotIn)
        Me.Controls.Add(Me.TxtIV)
        Me.Controls.Add(Me.TxtOral)
        Me.Controls.Add(Me.TxtTube)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DtgFluidOut)
        Me.Controls.Add(Me.DtgFluidIn)
        Me.Name = "FluidBalChart"
        Me.Size = New System.Drawing.Size(828, 453)
        CType(Me.DtgFluidIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgFluidOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dtgfluidbal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtgFluidIn As DataGridView
    Friend WithEvents DtgFluidOut As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTube As TextBox
    Friend WithEvents TxtOral As TextBox
    Friend WithEvents TxtIV As TextBox
    Friend WithEvents TxtTotIn As TextBox
    Friend WithEvents TxtUrine As TextBox
    Friend WithEvents TxtVomit As TextBox
    Friend WithEvents TxtFeases As TextBox
    Friend WithEvents TxtTotOut As TextBox
    Friend WithEvents TxtBal As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Dtgfluidbal As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnNew As Button
    Friend WithEvents LblUser As Label
    Friend WithEvents Lblchartid As Label
    Friend WithEvents txtfldbal As TextBox
End Class
