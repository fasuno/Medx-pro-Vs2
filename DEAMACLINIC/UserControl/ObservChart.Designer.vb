<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ObservChart
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCls = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.TxtRem = New System.Windows.Forms.TextBox()
        Me.TxtBlad = New System.Windows.Forms.TextBox()
        Me.Txtbowel = New System.Windows.Forms.TextBox()
        Me.TxtResp = New System.Windows.Forms.TextBox()
        Me.TxtPulse = New System.Windows.Forms.TextBox()
        Me.TxtTemp = New System.Windows.Forms.TextBox()
        Me.TxtBp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtgObserv = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DtgObserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 25)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(314, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OBSERVATION  CHART"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Lbluser)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.BtnCls)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.Txtpass)
        Me.Panel2.Controls.Add(Me.TxtRem)
        Me.Panel2.Controls.Add(Me.TxtBlad)
        Me.Panel2.Controls.Add(Me.Txtbowel)
        Me.Panel2.Controls.Add(Me.TxtResp)
        Me.Panel2.Controls.Add(Me.TxtPulse)
        Me.Panel2.Controls.Add(Me.TxtTemp)
        Me.Panel2.Controls.Add(Me.TxtBp)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 171)
        Me.Panel2.TabIndex = 1
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.ForeColor = System.Drawing.Color.Blue
        Me.Lbluser.Location = New System.Drawing.Point(629, 16)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(10, 15)
        Me.Lbluser.TabIndex = 22
        Me.Lbluser.Text = " "
        Me.Lbluser.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Location = New System.Drawing.Point(89, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(6, 169)
        Me.Panel5.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(731, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(6, 169)
        Me.Panel4.TabIndex = 20
        '
        'BtnCls
        '
        Me.BtnCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCls.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCls.ForeColor = System.Drawing.Color.Red
        Me.BtnCls.Location = New System.Drawing.Point(617, 141)
        Me.BtnCls.Name = "BtnCls"
        Me.BtnCls.Size = New System.Drawing.Size(75, 23)
        Me.BtnCls.TabIndex = 19
        Me.BtnCls.Text = "CLEAR"
        Me.BtnCls.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(540, 141)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Txtpass
        '
        Me.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpass.ForeColor = System.Drawing.Color.Black
        Me.Txtpass.Location = New System.Drawing.Point(540, 114)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(152, 21)
        Me.Txtpass.TabIndex = 17
        '
        'TxtRem
        '
        Me.TxtRem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRem.ForeColor = System.Drawing.Color.Black
        Me.TxtRem.Location = New System.Drawing.Point(218, 93)
        Me.TxtRem.Multiline = True
        Me.TxtRem.Name = "TxtRem"
        Me.TxtRem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtRem.Size = New System.Drawing.Size(230, 71)
        Me.TxtRem.TabIndex = 16
        '
        'TxtBlad
        '
        Me.TxtBlad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBlad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBlad.ForeColor = System.Drawing.Color.Black
        Me.TxtBlad.Location = New System.Drawing.Point(366, 64)
        Me.TxtBlad.Name = "TxtBlad"
        Me.TxtBlad.Size = New System.Drawing.Size(82, 21)
        Me.TxtBlad.TabIndex = 15
        '
        'Txtbowel
        '
        Me.Txtbowel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtbowel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbowel.ForeColor = System.Drawing.Color.Black
        Me.Txtbowel.Location = New System.Drawing.Point(218, 63)
        Me.Txtbowel.Name = "Txtbowel"
        Me.Txtbowel.Size = New System.Drawing.Size(82, 21)
        Me.Txtbowel.TabIndex = 14
        '
        'TxtResp
        '
        Me.TxtResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResp.ForeColor = System.Drawing.Color.Black
        Me.TxtResp.Location = New System.Drawing.Point(366, 40)
        Me.TxtResp.Name = "TxtResp"
        Me.TxtResp.Size = New System.Drawing.Size(82, 21)
        Me.TxtResp.TabIndex = 13
        '
        'TxtPulse
        '
        Me.TxtPulse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPulse.ForeColor = System.Drawing.Color.Black
        Me.TxtPulse.Location = New System.Drawing.Point(218, 40)
        Me.TxtPulse.Name = "TxtPulse"
        Me.TxtPulse.Size = New System.Drawing.Size(82, 21)
        Me.TxtPulse.TabIndex = 12
        '
        'TxtTemp
        '
        Me.TxtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTemp.ForeColor = System.Drawing.Color.Black
        Me.TxtTemp.Location = New System.Drawing.Point(366, 16)
        Me.TxtTemp.Name = "TxtTemp"
        Me.TxtTemp.Size = New System.Drawing.Size(82, 21)
        Me.TxtTemp.TabIndex = 11
        '
        'TxtBp
        '
        Me.TxtBp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBp.ForeColor = System.Drawing.Color.Black
        Me.TxtBp.Location = New System.Drawing.Point(218, 17)
        Me.TxtBp.Name = "TxtBp"
        Me.TxtBp.Size = New System.Drawing.Size(82, 21)
        Me.TxtBp.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(158, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Remark:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(306, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Bladder:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(169, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Bowel:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(171, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Pulse:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(184, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "BP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(322, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Resp:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(537, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(320, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Temp:"
        '
        'DtgObserv
        '
        Me.DtgObserv.AllowUserToAddRows = False
        Me.DtgObserv.AllowUserToDeleteRows = False
        Me.DtgObserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgObserv.BackgroundColor = System.Drawing.Color.White
        Me.DtgObserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgObserv.Location = New System.Drawing.Point(15, 7)
        Me.DtgObserv.Name = "DtgObserv"
        Me.DtgObserv.Size = New System.Drawing.Size(787, 201)
        Me.DtgObserv.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DtgObserv)
        Me.Panel3.Location = New System.Drawing.Point(2, 227)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(822, 221)
        Me.Panel3.TabIndex = 2
        '
        'ObservChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ObservChart"
        Me.Size = New System.Drawing.Size(826, 449)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DtgObserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents TxtRem As TextBox
    Friend WithEvents TxtBlad As TextBox
    Friend WithEvents Txtbowel As TextBox
    Friend WithEvents TxtResp As TextBox
    Friend WithEvents TxtPulse As TextBox
    Friend WithEvents TxtTemp As TextBox
    Friend WithEvents TxtBp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCls As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DtgObserv As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbluser As Label
End Class
