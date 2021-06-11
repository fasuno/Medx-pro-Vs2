<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRadrequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadrequest))
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.cboclinic = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblsendername = New System.Windows.Forms.Label()
        Me.txtRqstNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiagn = New System.Windows.Forms.TextBox()
        Me.btnsendrequest = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtInvType = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgRadrequest = New System.Windows.Forms.DataGridView()
        Me.Request_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Investgtn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnaddInv = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSndAncRad = New System.Windows.Forms.Button()
        Me.BtnSaveWard = New System.Windows.Forms.Button()
        Me.BtnSavetheatre = New System.Windows.Forms.Button()
        Me.BtnSAveFlwup = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgRadrequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcomment
        '
        Me.txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomment.Location = New System.Drawing.Point(118, 73)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(269, 20)
        Me.txtcomment.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(322, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Prescription"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lbltime)
        Me.Panel4.Controls.Add(Me.lbldate)
        Me.Panel4.Controls.Add(Me.cboclinic)
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(553, 29)
        Me.Panel4.TabIndex = 34
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
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(470, 6)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(35, 15)
        Me.lbltime.TabIndex = 5
        Me.lbltime.Text = "Time"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(376, 6)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(32, 15)
        Me.lbldate.TabIndex = 4
        Me.lbldate.Text = "Date"
        '
        'cboclinic
        '
        Me.cboclinic.FormattingEnabled = True
        Me.cboclinic.Location = New System.Drawing.Point(91, 3)
        Me.cboclinic.Name = "cboclinic"
        Me.cboclinic.Size = New System.Drawing.Size(152, 21)
        Me.cboclinic.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Comment:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(490, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblsendername
        '
        Me.lblsendername.AutoSize = True
        Me.lblsendername.Location = New System.Drawing.Point(52, 309)
        Me.lblsendername.Name = "lblsendername"
        Me.lblsendername.Size = New System.Drawing.Size(10, 13)
        Me.lblsendername.TabIndex = 25
        Me.lblsendername.Text = " "
        Me.lblsendername.Visible = False
        '
        'txtRqstNum
        '
        Me.txtRqstNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRqstNum.Location = New System.Drawing.Point(476, 73)
        Me.txtRqstNum.Name = "txtRqstNum"
        Me.txtRqstNum.ReadOnly = True
        Me.txtRqstNum.Size = New System.Drawing.Size(64, 20)
        Me.txtRqstNum.TabIndex = 33
        Me.txtRqstNum.Text = " "
        Me.txtRqstNum.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(401, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Request No."
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(55, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Diagnosis:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select Drugs"
        '
        'txtdiagn
        '
        Me.txtdiagn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiagn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdiagn.Location = New System.Drawing.Point(118, 44)
        Me.txtdiagn.Name = "txtdiagn"
        Me.txtdiagn.Size = New System.Drawing.Size(422, 20)
        Me.txtdiagn.TabIndex = 30
        '
        'btnsendrequest
        '
        Me.btnsendrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendrequest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendrequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsendrequest.Location = New System.Drawing.Point(344, 309)
        Me.btnsendrequest.Name = "btnsendrequest"
        Me.btnsendrequest.Size = New System.Drawing.Size(118, 28)
        Me.btnsendrequest.TabIndex = 29
        Me.btnsendrequest.Text = "SEND REQUEST"
        Me.btnsendrequest.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(169, 315)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassword.Size = New System.Drawing.Size(161, 20)
        Me.txtpassword.TabIndex = 27
        '
        'txtInvType
        '
        Me.txtInvType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtInvType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInvType.Location = New System.Drawing.Point(124, 12)
        Me.txtInvType.Name = "txtInvType"
        Me.txtInvType.Size = New System.Drawing.Size(325, 20)
        Me.txtInvType.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(307, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(18, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(277, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Location = New System.Drawing.Point(0, -47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 41)
        Me.Panel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(76, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Enter Password:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgRadrequest)
        Me.Panel2.Location = New System.Drawing.Point(49, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 159)
        Me.Panel2.TabIndex = 26
        '
        'dtgRadrequest
        '
        Me.dtgRadrequest.AllowUserToAddRows = False
        Me.dtgRadrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRadrequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Request_Num, Me.Investgtn})
        Me.dtgRadrequest.Location = New System.Drawing.Point(2, 2)
        Me.dtgRadrequest.Name = "dtgRadrequest"
        Me.dtgRadrequest.Size = New System.Drawing.Size(464, 156)
        Me.dtgRadrequest.TabIndex = 0
        '
        'Request_Num
        '
        Me.Request_Num.HeaderText = "REQUEST_NUM"
        Me.Request_Num.Name = "Request_Num"
        Me.Request_Num.Visible = False
        '
        'Investgtn
        '
        Me.Investgtn.HeaderText = "INVESTIGATION"
        Me.Investgtn.Name = "Investgtn"
        Me.Investgtn.Width = 420
        '
        'btnaddInv
        '
        Me.btnaddInv.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddInv.Location = New System.Drawing.Point(458, 8)
        Me.btnaddInv.Name = "btnaddInv"
        Me.btnaddInv.Size = New System.Drawing.Size(79, 25)
        Me.btnaddInv.TabIndex = 2
        Me.btnaddInv.Text = "ADD"
        Me.btnaddInv.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnaddInv)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtInvType)
        Me.Panel1.Location = New System.Drawing.Point(2, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 42)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Investigation:"
        '
        'BtnSndAncRad
        '
        Me.BtnSndAncRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSndAncRad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSndAncRad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSndAncRad.Location = New System.Drawing.Point(344, 309)
        Me.BtnSndAncRad.Name = "BtnSndAncRad"
        Me.BtnSndAncRad.Size = New System.Drawing.Size(118, 28)
        Me.BtnSndAncRad.TabIndex = 35
        Me.BtnSndAncRad.Text = "SEND REQUEST"
        Me.BtnSndAncRad.UseVisualStyleBackColor = True
        '
        'BtnSaveWard
        '
        Me.BtnSaveWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveWard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveWard.ForeColor = System.Drawing.Color.Green
        Me.BtnSaveWard.Location = New System.Drawing.Point(344, 309)
        Me.BtnSaveWard.Name = "BtnSaveWard"
        Me.BtnSaveWard.Size = New System.Drawing.Size(118, 28)
        Me.BtnSaveWard.TabIndex = 36
        Me.BtnSaveWard.Text = "SEND REQUEST"
        Me.BtnSaveWard.UseVisualStyleBackColor = True
        '
        'BtnSavetheatre
        '
        Me.BtnSavetheatre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavetheatre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavetheatre.ForeColor = System.Drawing.Color.Green
        Me.BtnSavetheatre.Location = New System.Drawing.Point(344, 309)
        Me.BtnSavetheatre.Name = "BtnSavetheatre"
        Me.BtnSavetheatre.Size = New System.Drawing.Size(118, 28)
        Me.BtnSavetheatre.TabIndex = 37
        Me.BtnSavetheatre.Text = "SEND REQUEST"
        Me.BtnSavetheatre.UseVisualStyleBackColor = True
        '
        'BtnSAveFlwup
        '
        Me.BtnSAveFlwup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSAveFlwup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAveFlwup.ForeColor = System.Drawing.Color.Green
        Me.BtnSAveFlwup.Location = New System.Drawing.Point(344, 309)
        Me.BtnSAveFlwup.Name = "BtnSAveFlwup"
        Me.BtnSAveFlwup.Size = New System.Drawing.Size(118, 28)
        Me.BtnSAveFlwup.TabIndex = 38
        Me.BtnSAveFlwup.Text = "SEND REQUEST"
        Me.BtnSAveFlwup.UseVisualStyleBackColor = True
        '
        'FrmRadrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 342)
        Me.Controls.Add(Me.BtnSAveFlwup)
        Me.Controls.Add(Me.BtnSavetheatre)
        Me.Controls.Add(Me.BtnSaveWard)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblsendername)
        Me.Controls.Add(Me.txtRqstNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiagn)
        Me.Controls.Add(Me.btnsendrequest)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSndAncRad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRadrequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "       RADIOLOGY INVESTIGATION REQUEST"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgRadrequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcomment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents cboclinic As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblsendername As Label
    Friend WithEvents txtRqstNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdiagn As TextBox
    Friend WithEvents btnsendrequest As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtInvType As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgRadrequest As DataGridView
    Friend WithEvents btnaddInv As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Request_Num As DataGridViewTextBoxColumn
    Friend WithEvents Investgtn As DataGridViewTextBoxColumn
    Friend WithEvents BtnSndAncRad As Button
    Friend WithEvents BtnSaveWard As Button
    Friend WithEvents BtnSavetheatre As Button
    Friend WithEvents BtnSAveFlwup As Button
End Class
