<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppointment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtcat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.txtothernames = New System.Windows.Forms.TextBox()
        Me.txtaccount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.cboClinic = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Apptdate = New System.Windows.Forms.DateTimePicker()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Btnsend = New System.Windows.Forms.Button()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Apptime = New System.Windows.Forms.DateTimePicker()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnReschedule = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Txtcat)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtage)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtsex)
        Me.Panel1.Controls.Add(Me.txtothernames)
        Me.Panel1.Controls.Add(Me.txtaccount)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtsurname)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 154)
        Me.Panel1.TabIndex = 0
        '
        'Txtcat
        '
        Me.Txtcat.Enabled = False
        Me.Txtcat.Location = New System.Drawing.Point(392, 103)
        Me.Txtcat.Name = "Txtcat"
        Me.Txtcat.Size = New System.Drawing.Size(149, 20)
        Me.Txtcat.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(280, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Account Category:"
        '
        'txtage
        '
        Me.txtage.Enabled = False
        Me.txtage.Location = New System.Drawing.Point(356, 131)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(71, 20)
        Me.txtage.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(317, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Age:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btnsearch)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(85, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 63)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " FIND PATIENT"
        '
        'Btnsearch
        '
        Me.Btnsearch.BackColor = System.Drawing.Color.White
        Me.Btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnsearch.Location = New System.Drawing.Point(319, 22)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(83, 31)
        Me.Btnsearch.TabIndex = 19
        Me.Btnsearch.Text = "Search"
        Me.Btnsearch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(13, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Hospital Number:"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(122, 27)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(191, 21)
        Me.txtsearch.TabIndex = 15
        '
        'txtsex
        '
        Me.txtsex.Enabled = False
        Me.txtsex.Location = New System.Drawing.Point(227, 131)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.Size = New System.Drawing.Size(84, 20)
        Me.txtsex.TabIndex = 17
        '
        'txtothernames
        '
        Me.txtothernames.Enabled = False
        Me.txtothernames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtothernames.Location = New System.Drawing.Point(392, 79)
        Me.txtothernames.Name = "txtothernames"
        Me.txtothernames.Size = New System.Drawing.Size(235, 20)
        Me.txtothernames.TabIndex = 16
        '
        'txtaccount
        '
        Me.txtaccount.Enabled = False
        Me.txtaccount.Location = New System.Drawing.Point(88, 104)
        Me.txtaccount.Name = "txtaccount"
        Me.txtaccount.Size = New System.Drawing.Size(189, 20)
        Me.txtaccount.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(1, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Account Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(24, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Surname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(303, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Other Names:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(190, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sex:"
        '
        'txtsurname
        '
        Me.txtsurname.Enabled = False
        Me.txtsurname.Location = New System.Drawing.Point(88, 79)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(203, 20)
        Me.txtsurname.TabIndex = 6
        '
        'cboClinic
        '
        Me.cboClinic.FormattingEnabled = True
        Me.cboClinic.Items.AddRange(New Object() {"GOPD", "ORTHOPEDIC"})
        Me.cboClinic.Location = New System.Drawing.Point(256, 36)
        Me.cboClinic.Name = "cboClinic"
        Me.cboClinic.Size = New System.Drawing.Size(171, 21)
        Me.cboClinic.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(203, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clinic:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(163, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(327, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Time:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Apptdate)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Controls.Add(Me.Btnsend)
        Me.Panel2.Controls.Add(Me.lbltime)
        Me.Panel2.Controls.Add(Me.Apptime)
        Me.Panel2.Controls.Add(Me.BtnCancel)
        Me.Panel2.Controls.Add(Me.BtnReschedule)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboClinic)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 101)
        Me.Panel2.TabIndex = 1
        '
        'Apptdate
        '
        Me.Apptdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Apptdate.Location = New System.Drawing.Point(207, 10)
        Me.Apptdate.Name = "Apptdate"
        Me.Apptdate.Size = New System.Drawing.Size(105, 20)
        Me.Apptdate.TabIndex = 27
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldate.Location = New System.Drawing.Point(546, 60)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(10, 15)
        Me.lbldate.TabIndex = 26
        Me.lbldate.Text = " "
        Me.lbldate.Visible = False
        '
        'Btnsend
        '
        Me.Btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsend.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnsend.Location = New System.Drawing.Point(193, 60)
        Me.Btnsend.Name = "Btnsend"
        Me.Btnsend.Size = New System.Drawing.Size(85, 25)
        Me.Btnsend.TabIndex = 25
        Me.Btnsend.Text = "Send"
        Me.Btnsend.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltime.Location = New System.Drawing.Point(493, 30)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(10, 15)
        Me.lbltime.TabIndex = 24
        Me.lbltime.Text = " "
        Me.lbltime.Visible = False
        '
        'Apptime
        '
        Me.Apptime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Apptime.Location = New System.Drawing.Point(372, 10)
        Me.Apptime.Name = "Apptime"
        Me.Apptime.ShowUpDown = True
        Me.Apptime.Size = New System.Drawing.Size(115, 20)
        Me.Apptime.TabIndex = 23
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Red
        Me.BtnCancel.Location = New System.Drawing.Point(388, 60)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 25)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnReschedule
        '
        Me.BtnReschedule.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReschedule.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReschedule.ForeColor = System.Drawing.Color.Blue
        Me.BtnReschedule.Location = New System.Drawing.Point(280, 60)
        Me.BtnReschedule.Name = "BtnReschedule"
        Me.BtnReschedule.Size = New System.Drawing.Size(106, 25)
        Me.BtnReschedule.TabIndex = 21
        Me.BtnReschedule.Text = "Reschedule"
        Me.BtnReschedule.UseVisualStyleBackColor = False
        '
        'FrmAppointment
        '
        Me.AcceptButton = Me.Btnsearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(638, 256)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APPOINTMENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboClinic As ComboBox
    Friend WithEvents txtothernames As TextBox
    Friend WithEvents txtaccount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsex As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Btnsearch As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnReschedule As Button
    Friend WithEvents Apptime As DateTimePicker
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtcat As TextBox
    Friend WithEvents Btnsend As Button
    Friend WithEvents lbldate As Label
    Friend WithEvents Apptdate As DateTimePicker
End Class
