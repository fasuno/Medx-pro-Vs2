<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmitpt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmitpt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgvbedlist = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbltim = New System.Windows.Forms.Label()
        Me.lbldat = New System.Windows.Forms.Label()
        Me.cboward = New System.Windows.Forms.ComboBox()
        Me.Cboadmtyp = New System.Windows.Forms.ComboBox()
        Me.txtinstr = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.txtdiagnosis = New System.Windows.Forms.TextBox()
        Me.Cboclinic = New System.Windows.Forms.ComboBox()
        Me.Btnorderadmit = New System.Windows.Forms.Button()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Txtoper = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lblstat = New System.Windows.Forms.Label()
        Me.DtSurg = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvbedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Dgvbedlist)
        Me.Panel1.Location = New System.Drawing.Point(300, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 286)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(27, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NO. OF FREE BED SPACE"
        '
        'Dgvbedlist
        '
        Me.Dgvbedlist.AllowUserToAddRows = False
        Me.Dgvbedlist.AllowUserToDeleteRows = False
        Me.Dgvbedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvbedlist.BackgroundColor = System.Drawing.Color.White
        Me.Dgvbedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvbedlist.DefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvbedlist.Location = New System.Drawing.Point(-1, 30)
        Me.Dgvbedlist.Name = "Dgvbedlist"
        Me.Dgvbedlist.ReadOnly = True
        Me.Dgvbedlist.RowHeadersVisible = False
        Me.Dgvbedlist.Size = New System.Drawing.Size(244, 253)
        Me.Dgvbedlist.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Ward:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Admission Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Diagnosis:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Instruction:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbltim)
        Me.Panel2.Controls.Add(Me.lbldat)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 25)
        Me.Panel2.TabIndex = 5
        '
        'lbltim
        '
        Me.lbltim.AutoSize = True
        Me.lbltim.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltim.Location = New System.Drawing.Point(172, 6)
        Me.lbltim.Name = "lbltim"
        Me.lbltim.Size = New System.Drawing.Size(35, 15)
        Me.lbltim.TabIndex = 6
        Me.lbltim.Text = "Time"
        '
        'lbldat
        '
        Me.lbldat.AutoSize = True
        Me.lbldat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldat.Location = New System.Drawing.Point(37, 6)
        Me.lbldat.Name = "lbldat"
        Me.lbldat.Size = New System.Drawing.Size(32, 15)
        Me.lbldat.TabIndex = 7
        Me.lbldat.Text = "Date"
        '
        'cboward
        '
        Me.cboward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboward.FormattingEnabled = True
        Me.cboward.Items.AddRange(New Object() {"PRIVATE WARD", "GENERAL WARD"})
        Me.cboward.Location = New System.Drawing.Point(107, 107)
        Me.cboward.Name = "cboward"
        Me.cboward.Size = New System.Drawing.Size(187, 21)
        Me.cboward.TabIndex = 7
        '
        'Cboadmtyp
        '
        Me.Cboadmtyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cboadmtyp.FormattingEnabled = True
        Me.Cboadmtyp.Items.AddRange(New Object() {"ADMIT ONLY", "ADMISSION/SURGERY", "SURGERY ONLY"})
        Me.Cboadmtyp.Location = New System.Drawing.Point(107, 81)
        Me.Cboadmtyp.Name = "Cboadmtyp"
        Me.Cboadmtyp.Size = New System.Drawing.Size(187, 21)
        Me.Cboadmtyp.TabIndex = 8
        '
        'txtinstr
        '
        Me.txtinstr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinstr.Location = New System.Drawing.Point(2, 308)
        Me.txtinstr.Multiline = True
        Me.txtinstr.Name = "txtinstr"
        Me.txtinstr.Size = New System.Drawing.Size(292, 49)
        Me.txtinstr.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 359)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(550, 7)
        Me.Panel5.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Location = New System.Drawing.Point(1, 159)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(299, 3)
        Me.Panel3.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.Location = New System.Drawing.Point(-1, 26)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(302, 6)
        Me.Panel6.TabIndex = 12
        '
        'btnsend
        '
        Me.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsend.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.ForeColor = System.Drawing.Color.Green
        Me.btnsend.Location = New System.Drawing.Point(395, 332)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(150, 23)
        Me.btnsend.TabIndex = 13
        Me.btnsend.Text = "ORDER ADMISSION"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'txtdiagnosis
        '
        Me.txtdiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtdiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtdiagnosis.Location = New System.Drawing.Point(7, 55)
        Me.txtdiagnosis.Name = "txtdiagnosis"
        Me.txtdiagnosis.Size = New System.Drawing.Size(287, 20)
        Me.txtdiagnosis.TabIndex = 15
        '
        'Cboclinic
        '
        Me.Cboclinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cboclinic.FormattingEnabled = True
        Me.Cboclinic.Location = New System.Drawing.Point(107, 134)
        Me.Cboclinic.Name = "Cboclinic"
        Me.Cboclinic.Size = New System.Drawing.Size(187, 21)
        Me.Cboclinic.TabIndex = 17
        '
        'Btnorderadmit
        '
        Me.Btnorderadmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnorderadmit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnorderadmit.ForeColor = System.Drawing.Color.Green
        Me.Btnorderadmit.Location = New System.Drawing.Point(395, 332)
        Me.Btnorderadmit.Name = "Btnorderadmit"
        Me.Btnorderadmit.Size = New System.Drawing.Size(150, 23)
        Me.Btnorderadmit.TabIndex = 18
        Me.Btnorderadmit.Text = "ORDER ADMISSION"
        Me.Btnorderadmit.UseVisualStyleBackColor = True
        '
        'Txtpass
        '
        Me.Txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpass.Location = New System.Drawing.Point(395, 308)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(150, 20)
        Me.Txtpass.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Clinic:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(399, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Password:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(115, 36)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(10, 15)
        Me.lblname.TabIndex = 21
        Me.lblname.Text = " "
        Me.lblname.Visible = False
        '
        'Txtoper
        '
        Me.Txtoper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtoper.Location = New System.Drawing.Point(2, 185)
        Me.Txtoper.Multiline = True
        Me.Txtoper.Name = "Txtoper"
        Me.Txtoper.Size = New System.Drawing.Size(292, 51)
        Me.Txtoper.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Operation / Procedure:"
        '
        'Lblstat
        '
        Me.Lblstat.AutoSize = True
        Me.Lblstat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstat.Location = New System.Drawing.Point(307, 300)
        Me.Lblstat.Name = "Lblstat"
        Me.Lblstat.Size = New System.Drawing.Size(52, 15)
        Me.Lblstat.TabIndex = 24
        Me.Lblstat.Text = "Pending"
        Me.Lblstat.Visible = False
        '
        'DtSurg
        '
        Me.DtSurg.Location = New System.Drawing.Point(4, 263)
        Me.DtSurg.Name = "DtSurg"
        Me.DtSurg.Size = New System.Drawing.Size(199, 20)
        Me.DtSurg.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Surgery Date:"
        '
        'FrmAdmitpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 366)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DtSurg)
        Me.Controls.Add(Me.Lblstat)
        Me.Controls.Add(Me.Txtoper)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Btnorderadmit)
        Me.Controls.Add(Me.Cboclinic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiagnosis)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtinstr)
        Me.Controls.Add(Me.Cboadmtyp)
        Me.Controls.Add(Me.cboward)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmitpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  ADMISSION REQUEST FORM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgvbedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgvbedlist As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltim As Label
    Friend WithEvents lbldat As Label
    Friend WithEvents cboward As ComboBox
    Friend WithEvents Cboadmtyp As ComboBox
    Friend WithEvents txtinstr As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnsend As Button
    Friend WithEvents txtdiagnosis As TextBox
    Friend WithEvents Cboclinic As ComboBox
    Friend WithEvents Btnorderadmit As Button
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Txtoper As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Lblstat As Label
    Friend WithEvents DtSurg As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
