<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabrequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabrequest))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboclinic = New System.Windows.Forms.ComboBox()
        Me.lblsendername = New System.Windows.Forms.Label()
        Me.txttestID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiagn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsendrequest = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.dtgLabrequest = New System.Windows.Forms.DataGridView()
        Me.Request_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabTestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnaddtest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txttestname = New System.Windows.Forms.TextBox()
        Me.txtrqstno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSndAncLab = New System.Windows.Forms.Button()
        Me.BtnSaveWard = New System.Windows.Forms.Button()
        Me.BtnSaveTheatre = New System.Windows.Forms.Button()
        Me.BtnsaveFlwup = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgLabrequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lbltime.Location = New System.Drawing.Point(473, 6)
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lbltime)
        Me.Panel4.Controls.Add(Me.lbldate)
        Me.Panel4.Controls.Add(Me.cboclinic)
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(550, 29)
        Me.Panel4.TabIndex = 21
        '
        'cboclinic
        '
        Me.cboclinic.BackColor = System.Drawing.Color.White
        Me.cboclinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboclinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboclinic.FormattingEnabled = True
        Me.cboclinic.Location = New System.Drawing.Point(91, 3)
        Me.cboclinic.Name = "cboclinic"
        Me.cboclinic.Size = New System.Drawing.Size(152, 21)
        Me.cboclinic.TabIndex = 4
        '
        'lblsendername
        '
        Me.lblsendername.AutoSize = True
        Me.lblsendername.Location = New System.Drawing.Point(12, 316)
        Me.lblsendername.Name = "lblsendername"
        Me.lblsendername.Size = New System.Drawing.Size(39, 13)
        Me.lblsendername.TabIndex = 12
        Me.lblsendername.Text = "Label9"
        Me.lblsendername.Visible = False
        '
        'txttestID
        '
        Me.txttestID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttestID.Location = New System.Drawing.Point(464, 70)
        Me.txttestID.Name = "txttestID"
        Me.txttestID.ReadOnly = True
        Me.txttestID.Size = New System.Drawing.Size(64, 20)
        Me.txttestID.TabIndex = 20
        Me.txttestID.Text = " "
        Me.txttestID.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(398, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Reqst. No."
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(55, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Diagnosis:"
        '
        'txtdiagn
        '
        Me.txtdiagn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiagn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdiagn.Location = New System.Drawing.Point(118, 42)
        Me.txtdiagn.Name = "txtdiagn"
        Me.txtdiagn.Size = New System.Drawing.Size(269, 20)
        Me.txtdiagn.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(84, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter Password:"
        '
        'btnsendrequest
        '
        Me.btnsendrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendrequest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendrequest.ForeColor = System.Drawing.Color.Green
        Me.btnsendrequest.Location = New System.Drawing.Point(352, 308)
        Me.btnsendrequest.Name = "btnsendrequest"
        Me.btnsendrequest.Size = New System.Drawing.Size(115, 28)
        Me.btnsendrequest.TabIndex = 16
        Me.btnsendrequest.Text = "SEND REQUEST"
        Me.btnsendrequest.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(177, 313)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassword.Size = New System.Drawing.Size(161, 20)
        Me.txtpassword.TabIndex = 14
        '
        'dtgLabrequest
        '
        Me.dtgLabrequest.AllowUserToAddRows = False
        Me.dtgLabrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLabrequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Request_Num, Me.LabTestID, Me.Test_name})
        Me.dtgLabrequest.Location = New System.Drawing.Point(3, 0)
        Me.dtgLabrequest.Name = "dtgLabrequest"
        Me.dtgLabrequest.Size = New System.Drawing.Size(469, 156)
        Me.dtgLabrequest.TabIndex = 0
        '
        'Request_Num
        '
        Me.Request_Num.HeaderText = "Request_Num"
        Me.Request_Num.Name = "Request_Num"
        Me.Request_Num.ReadOnly = True
        Me.Request_Num.Visible = False
        '
        'LabTestID
        '
        Me.LabTestID.HeaderText = "TESTID"
        Me.LabTestID.Name = "LabTestID"
        Me.LabTestID.ReadOnly = True
        Me.LabTestID.Visible = False
        '
        'Test_name
        '
        Me.Test_name.HeaderText = "TEST NAME"
        Me.Test_name.Name = "Test_name"
        Me.Test_name.ReadOnly = True
        Me.Test_name.Width = 420
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgLabrequest)
        Me.Panel2.Location = New System.Drawing.Point(27, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 159)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(53, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comment:"
        '
        'btnaddtest
        '
        Me.btnaddtest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtest.Location = New System.Drawing.Point(446, 8)
        Me.btnaddtest.Name = "btnaddtest"
        Me.btnaddtest.Size = New System.Drawing.Size(79, 25)
        Me.btnaddtest.TabIndex = 2
        Me.btnaddtest.Text = "ADD"
        Me.btnaddtest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Test:"
        '
        'txtcomment
        '
        Me.txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomment.Location = New System.Drawing.Point(118, 71)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(269, 20)
        Me.txtcomment.TabIndex = 1
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
        Me.Panel3.Location = New System.Drawing.Point(0, -63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(542, 57)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txttestname)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnaddtest)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 42)
        Me.Panel1.TabIndex = 11
        '
        'txttestname
        '
        Me.txttestname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txttestname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txttestname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttestname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttestname.Location = New System.Drawing.Point(91, 11)
        Me.txttestname.Name = "txttestname"
        Me.txttestname.Size = New System.Drawing.Size(350, 20)
        Me.txttestname.TabIndex = 22
        '
        'txtrqstno
        '
        Me.txtrqstno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrqstno.Location = New System.Drawing.Point(464, 40)
        Me.txtrqstno.Name = "txtrqstno"
        Me.txtrqstno.ReadOnly = True
        Me.txtrqstno.Size = New System.Drawing.Size(64, 20)
        Me.txtrqstno.TabIndex = 22
        Me.txtrqstno.Text = " "
        Me.txtrqstno.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(422, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "testid"
        Me.Label7.Visible = False
        '
        'BtnSndAncLab
        '
        Me.BtnSndAncLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSndAncLab.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSndAncLab.ForeColor = System.Drawing.Color.Green
        Me.BtnSndAncLab.Location = New System.Drawing.Point(352, 308)
        Me.BtnSndAncLab.Name = "BtnSndAncLab"
        Me.BtnSndAncLab.Size = New System.Drawing.Size(115, 28)
        Me.BtnSndAncLab.TabIndex = 24
        Me.BtnSndAncLab.Text = "SEND REQUEST"
        Me.BtnSndAncLab.UseVisualStyleBackColor = True
        '
        'BtnSaveWard
        '
        Me.BtnSaveWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveWard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveWard.ForeColor = System.Drawing.Color.Green
        Me.BtnSaveWard.Location = New System.Drawing.Point(352, 308)
        Me.BtnSaveWard.Name = "BtnSaveWard"
        Me.BtnSaveWard.Size = New System.Drawing.Size(115, 28)
        Me.BtnSaveWard.TabIndex = 25
        Me.BtnSaveWard.Text = "SEND REQUEST"
        Me.BtnSaveWard.UseVisualStyleBackColor = True
        '
        'BtnSaveTheatre
        '
        Me.BtnSaveTheatre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveTheatre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveTheatre.ForeColor = System.Drawing.Color.Green
        Me.BtnSaveTheatre.Location = New System.Drawing.Point(352, 308)
        Me.BtnSaveTheatre.Name = "BtnSaveTheatre"
        Me.BtnSaveTheatre.Size = New System.Drawing.Size(115, 28)
        Me.BtnSaveTheatre.TabIndex = 26
        Me.BtnSaveTheatre.Text = "SEND REQUEST"
        Me.BtnSaveTheatre.UseVisualStyleBackColor = True
        '
        'BtnsaveFlwup
        '
        Me.BtnsaveFlwup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnsaveFlwup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnsaveFlwup.ForeColor = System.Drawing.Color.Green
        Me.BtnsaveFlwup.Location = New System.Drawing.Point(352, 308)
        Me.BtnsaveFlwup.Name = "BtnsaveFlwup"
        Me.BtnsaveFlwup.Size = New System.Drawing.Size(115, 28)
        Me.BtnsaveFlwup.TabIndex = 27
        Me.BtnsaveFlwup.Text = "SEND REQUEST"
        Me.BtnsaveFlwup.UseVisualStyleBackColor = True
        '
        'FrmLabrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 339)
        Me.Controls.Add(Me.BtnsaveFlwup)
        Me.Controls.Add(Me.BtnSaveTheatre)
        Me.Controls.Add(Me.BtnSaveWard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtrqstno)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblsendername)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.txttestID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiagn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsendrequest)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSndAncLab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLabrequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "       LABORATORY INVESTIGATION REQUEST"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgLabrequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cboclinic As ComboBox
    Friend WithEvents lblsendername As Label
    Friend WithEvents txttestID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdiagn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsendrequest As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents dtgLabrequest As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnaddtest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txttestname As TextBox
    Friend WithEvents txtrqstno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Request_Num As DataGridViewTextBoxColumn
    Friend WithEvents LabTestID As DataGridViewTextBoxColumn
    Friend WithEvents Test_name As DataGridViewTextBoxColumn
    Friend WithEvents BtnSndAncLab As Button
    Friend WithEvents BtnSaveWard As Button
    Friend WithEvents BtnSaveTheatre As Button
    Friend WithEvents BtnsaveFlwup As Button
End Class
