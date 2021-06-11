<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBiller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBiller))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtservno = New System.Windows.Forms.TextBox()
        Me.txtaccnt = New System.Windows.Forms.TextBox()
        Me.Txthnum = New System.Windows.Forms.TextBox()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAcctCat = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtService = New System.Windows.Forms.TextBox()
        Me.TxtTotcost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtOname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.Location = New System.Drawing.Point(304, 223)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(87, 24)
        Me.BtnSave.TabIndex = 22
        Me.BtnSave.Text = "SEND BILL"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(115, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Enter password:"
        '
        'Txtpassword
        '
        Me.Txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpassword.Location = New System.Drawing.Point(112, 227)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpassword.Size = New System.Drawing.Size(187, 20)
        Me.Txtpassword.TabIndex = 27
        '
        'Txtservno
        '
        Me.Txtservno.BackColor = System.Drawing.Color.White
        Me.Txtservno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtservno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtservno.ForeColor = System.Drawing.Color.Black
        Me.Txtservno.Location = New System.Drawing.Point(331, 58)
        Me.Txtservno.Name = "Txtservno"
        Me.Txtservno.ReadOnly = True
        Me.Txtservno.Size = New System.Drawing.Size(76, 22)
        Me.Txtservno.TabIndex = 26
        Me.Txtservno.Visible = False
        '
        'txtaccnt
        '
        Me.txtaccnt.BackColor = System.Drawing.Color.White
        Me.txtaccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccnt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccnt.ForeColor = System.Drawing.Color.Black
        Me.txtaccnt.Location = New System.Drawing.Point(94, 84)
        Me.txtaccnt.Name = "txtaccnt"
        Me.txtaccnt.ReadOnly = True
        Me.txtaccnt.Size = New System.Drawing.Size(241, 22)
        Me.txtaccnt.TabIndex = 24
        '
        'Txthnum
        '
        Me.Txthnum.BackColor = System.Drawing.Color.White
        Me.Txthnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txthnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txthnum.ForeColor = System.Drawing.Color.Black
        Me.Txthnum.Location = New System.Drawing.Point(94, 59)
        Me.Txthnum.Name = "Txthnum"
        Me.Txthnum.ReadOnly = True
        Me.Txthnum.Size = New System.Drawing.Size(150, 22)
        Me.Txthnum.TabIndex = 23
        '
        'txtSname
        '
        Me.txtSname.BackColor = System.Drawing.Color.White
        Me.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSname.ForeColor = System.Drawing.Color.Black
        Me.txtSname.Location = New System.Drawing.Point(94, 7)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.ReadOnly = True
        Me.txtSname.Size = New System.Drawing.Size(320, 22)
        Me.txtSname.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(259, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Service No."
        Me.Label9.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Account Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Select Service:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Hospital Num:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Account Type:"
        '
        'TxtAcctCat
        '
        Me.TxtAcctCat.BackColor = System.Drawing.Color.White
        Me.TxtAcctCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAcctCat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcctCat.ForeColor = System.Drawing.Color.Black
        Me.TxtAcctCat.Location = New System.Drawing.Point(94, 109)
        Me.TxtAcctCat.Name = "TxtAcctCat"
        Me.TxtAcctCat.ReadOnly = True
        Me.TxtAcctCat.Size = New System.Drawing.Size(241, 22)
        Me.TxtAcctCat.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(-4, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 10)
        Me.Panel1.TabIndex = 36
        '
        'TxtService
        '
        Me.TxtService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtService.BackColor = System.Drawing.Color.White
        Me.TxtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtService.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtService.ForeColor = System.Drawing.Color.Black
        Me.TxtService.Location = New System.Drawing.Point(94, 151)
        Me.TxtService.Name = "TxtService"
        Me.TxtService.Size = New System.Drawing.Size(241, 22)
        Me.TxtService.TabIndex = 37
        '
        'TxtTotcost
        '
        Me.TxtTotcost.BackColor = System.Drawing.Color.White
        Me.TxtTotcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotcost.ForeColor = System.Drawing.Color.Blue
        Me.TxtTotcost.Location = New System.Drawing.Point(192, 177)
        Me.TxtTotcost.Name = "TxtTotcost"
        Me.TxtTotcost.Size = New System.Drawing.Size(142, 24)
        Me.TxtTotcost.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Total Bill:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "N"
        '
        'TxtOname
        '
        Me.TxtOname.BackColor = System.Drawing.Color.White
        Me.TxtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOname.ForeColor = System.Drawing.Color.Black
        Me.TxtOname.Location = New System.Drawing.Point(94, 33)
        Me.TxtOname.Name = "TxtOname"
        Me.TxtOname.ReadOnly = True
        Me.TxtOname.Size = New System.Drawing.Size(320, 22)
        Me.TxtOname.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Other names:"
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbluser.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.Location = New System.Drawing.Point(9, 198)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(12, 17)
        Me.Lbluser.TabIndex = 43
        Me.Lbluser.Text = " "
        Me.Lbluser.Visible = False
        '
        'FrmBiller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 254)
        Me.Controls.Add(Me.Lbluser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtOname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTotcost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtService)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAcctCat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtservno)
        Me.Controls.Add(Me.txtaccnt)
        Me.Controls.Add(Me.Txthnum)
        Me.Controls.Add(Me.txtSname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBiller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " BILLING FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Txtservno As TextBox
    Friend WithEvents txtaccnt As TextBox
    Friend WithEvents Txthnum As TextBox
    Friend WithEvents txtSname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAcctCat As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtService As TextBox
    Friend WithEvents TxtTotcost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtOname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbluser As Label
End Class
