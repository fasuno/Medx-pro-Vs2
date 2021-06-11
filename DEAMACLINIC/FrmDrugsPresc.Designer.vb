<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDrugsPresc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrugsPresc))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnadddrug = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprescription = New System.Windows.Forms.TextBox()
        Me.txtdrugname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgprescription = New System.Windows.Forms.DataGridView()
        Me.Presc_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drugid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnsendpresc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdiag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.cboclinic = New System.Windows.Forms.ComboBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtdrugid = New System.Windows.Forms.TextBox()
        Me.lblprescno = New System.Windows.Forms.Label()
        Me.BtnANCdrugs = New System.Windows.Forms.Button()
        Me.BtnSaveWard = New System.Windows.Forms.Button()
        Me.BtnSAveTheatre = New System.Windows.Forms.Button()
        Me.BtnSaveFlwUp = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnadddrug)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtprescription)
        Me.Panel1.Controls.Add(Me.txtdrugname)
        Me.Panel1.Location = New System.Drawing.Point(4, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 68)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(0, -39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(594, 33)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(322, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prescription"
        '
        'btnadddrug
        '
        Me.btnadddrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadddrug.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadddrug.Location = New System.Drawing.Point(490, 30)
        Me.btnadddrug.Name = "btnadddrug"
        Me.btnadddrug.Size = New System.Drawing.Size(85, 25)
        Me.btnadddrug.TabIndex = 2
        Me.btnadddrug.Text = "ADD"
        Me.btnadddrug.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Drugs"
        '
        'txtprescription
        '
        Me.txtprescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprescription.Location = New System.Drawing.Point(307, 34)
        Me.txtprescription.Name = "txtprescription"
        Me.txtprescription.Size = New System.Drawing.Size(180, 20)
        Me.txtprescription.TabIndex = 1
        '
        'txtdrugname
        '
        Me.txtdrugname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtdrugname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtdrugname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdrugname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdrugname.Location = New System.Drawing.Point(18, 34)
        Me.txtdrugname.Name = "txtdrugname"
        Me.txtdrugname.Size = New System.Drawing.Size(283, 20)
        Me.txtdrugname.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgprescription)
        Me.Panel2.Location = New System.Drawing.Point(29, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(551, 159)
        Me.Panel2.TabIndex = 1
        '
        'dgprescription
        '
        Me.dgprescription.AllowUserToAddRows = False
        Me.dgprescription.BackgroundColor = System.Drawing.Color.White
        Me.dgprescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgprescription.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Presc_Num, Me.Drugid, Me.Drug_name, Me.prescription})
        Me.dgprescription.Location = New System.Drawing.Point(3, 1)
        Me.dgprescription.Name = "dgprescription"
        Me.dgprescription.Size = New System.Drawing.Size(547, 156)
        Me.dgprescription.TabIndex = 0
        '
        'Presc_Num
        '
        Me.Presc_Num.HeaderText = "PRESC_NUM"
        Me.Presc_Num.Name = "Presc_Num"
        Me.Presc_Num.Visible = False
        '
        'Drugid
        '
        Me.Drugid.HeaderText = "DRUG ID"
        Me.Drugid.Name = "Drugid"
        Me.Drugid.Visible = False
        '
        'Drug_name
        '
        Me.Drug_name.HeaderText = "DRUG NAME"
        Me.Drug_name.Name = "Drug_name"
        Me.Drug_name.Width = 300
        '
        'prescription
        '
        Me.prescription.HeaderText = "PRESCRIPTION"
        Me.prescription.Name = "prescription"
        Me.prescription.Width = 200
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(237, 313)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassword.Size = New System.Drawing.Size(167, 20)
        Me.txtpassword.TabIndex = 2
        '
        'btnsendpresc
        '
        Me.btnsendpresc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendpresc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendpresc.ForeColor = System.Drawing.Color.Green
        Me.btnsendpresc.Location = New System.Drawing.Point(411, 307)
        Me.btnsendpresc.Name = "btnsendpresc"
        Me.btnsendpresc.Size = New System.Drawing.Size(170, 28)
        Me.btnsendpresc.TabIndex = 3
        Me.btnsendpresc.Text = "SEND PRESCRIPTION"
        Me.btnsendpresc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(131, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter Password:"
        '
        'txtdiag
        '
        Me.txtdiag.BackColor = System.Drawing.Color.White
        Me.txtdiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdiag.ForeColor = System.Drawing.Color.Black
        Me.txtdiag.Location = New System.Drawing.Point(120, 42)
        Me.txtdiag.Name = "txtdiag"
        Me.txtdiag.Size = New System.Drawing.Size(275, 20)
        Me.txtdiag.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(57, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Diagnosis:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(27, 317)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(39, 13)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Label9"
        Me.lblname.Visible = False
        '
        'cboclinic
        '
        Me.cboclinic.FormattingEnabled = True
        Me.cboclinic.Location = New System.Drawing.Point(91, 3)
        Me.cboclinic.Name = "cboclinic"
        Me.cboclinic.Size = New System.Drawing.Size(158, 21)
        Me.cboclinic.TabIndex = 4
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(417, 6)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(32, 15)
        Me.lbldate.TabIndex = 4
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(514, 6)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(35, 15)
        Me.lbltime.TabIndex = 5
        Me.lbltime.Text = "Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Select Clinic:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lbltime)
        Me.Panel4.Controls.Add(Me.lbldate)
        Me.Panel4.Controls.Add(Me.cboclinic)
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(595, 29)
        Me.Panel4.TabIndex = 10
        '
        'txtdrugid
        '
        Me.txtdrugid.BackColor = System.Drawing.Color.White
        Me.txtdrugid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdrugid.ForeColor = System.Drawing.Color.Black
        Me.txtdrugid.Location = New System.Drawing.Point(489, 39)
        Me.txtdrugid.Name = "txtdrugid"
        Me.txtdrugid.ReadOnly = True
        Me.txtdrugid.Size = New System.Drawing.Size(92, 20)
        Me.txtdrugid.TabIndex = 9
        Me.txtdrugid.Text = " "
        Me.txtdrugid.Visible = False
        '
        'lblprescno
        '
        Me.lblprescno.AutoSize = True
        Me.lblprescno.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprescno.ForeColor = System.Drawing.Color.Navy
        Me.lblprescno.Location = New System.Drawing.Point(403, 44)
        Me.lblprescno.Name = "lblprescno"
        Me.lblprescno.Size = New System.Drawing.Size(10, 15)
        Me.lblprescno.TabIndex = 8
        Me.lblprescno.Text = " "
        '
        'BtnANCdrugs
        '
        Me.BtnANCdrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnANCdrugs.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnANCdrugs.ForeColor = System.Drawing.Color.Navy
        Me.BtnANCdrugs.Location = New System.Drawing.Point(411, 307)
        Me.BtnANCdrugs.Name = "BtnANCdrugs"
        Me.BtnANCdrugs.Size = New System.Drawing.Size(170, 28)
        Me.BtnANCdrugs.TabIndex = 11
        Me.BtnANCdrugs.Text = "SEND PRESCRIPTION"
        Me.BtnANCdrugs.UseVisualStyleBackColor = True
        '
        'BtnSaveWard
        '
        Me.BtnSaveWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveWard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveWard.ForeColor = System.Drawing.Color.Green
        Me.BtnSaveWard.Location = New System.Drawing.Point(411, 307)
        Me.BtnSaveWard.Name = "BtnSaveWard"
        Me.BtnSaveWard.Size = New System.Drawing.Size(170, 28)
        Me.BtnSaveWard.TabIndex = 12
        Me.BtnSaveWard.Text = "SEND PRESCRIPTION"
        Me.BtnSaveWard.UseVisualStyleBackColor = True
        '
        'BtnSAveTheatre
        '
        Me.BtnSAveTheatre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSAveTheatre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAveTheatre.ForeColor = System.Drawing.Color.Green
        Me.BtnSAveTheatre.Location = New System.Drawing.Point(411, 307)
        Me.BtnSAveTheatre.Name = "BtnSAveTheatre"
        Me.BtnSAveTheatre.Size = New System.Drawing.Size(170, 28)
        Me.BtnSAveTheatre.TabIndex = 13
        Me.BtnSAveTheatre.Text = "SEND PRESCRIPTION"
        Me.BtnSAveTheatre.UseVisualStyleBackColor = True
        '
        'BtnSaveFlwUp
        '
        Me.BtnSaveFlwUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveFlwUp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveFlwUp.ForeColor = System.Drawing.Color.Green
        Me.BtnSaveFlwUp.Location = New System.Drawing.Point(411, 307)
        Me.BtnSaveFlwUp.Name = "BtnSaveFlwUp"
        Me.BtnSaveFlwUp.Size = New System.Drawing.Size(170, 28)
        Me.BtnSaveFlwUp.TabIndex = 15
        Me.BtnSaveFlwUp.Text = "SEND PRESCRIPTION"
        Me.BtnSaveFlwUp.UseVisualStyleBackColor = True
        '
        'FrmDrugsPresc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(599, 337)
        Me.Controls.Add(Me.BtnSaveFlwUp)
        Me.Controls.Add(Me.BtnSAveTheatre)
        Me.Controls.Add(Me.BtnSaveWard)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtdrugid)
        Me.Controls.Add(Me.lblprescno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsendpresc)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnANCdrugs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDrugsPresc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "        DRUGS  PRESCRIPTION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgprescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnadddrug As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprescription As TextBox
    Friend WithEvents txtdrugname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgprescription As DataGridView
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnsendpresc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtdiag As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents cboclinic As ComboBox
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtdrugid As TextBox
    Friend WithEvents lblprescno As Label
    Friend WithEvents Presc_Num As DataGridViewTextBoxColumn
    Friend WithEvents Drugid As DataGridViewTextBoxColumn
    Friend WithEvents Drug_name As DataGridViewTextBoxColumn
    Friend WithEvents prescription As DataGridViewTextBoxColumn
    Friend WithEvents BtnANCdrugs As Button
    Friend WithEvents BtnSaveWard As Button
    Friend WithEvents BtnSAveTheatre As Button
    Friend WithEvents BtnSaveFlwUp As Button
End Class
