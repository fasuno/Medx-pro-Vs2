<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarePlan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtEval = New System.Windows.Forms.TextBox()
        Me.TxtNursOrd = New System.Windows.Forms.TextBox()
        Me.TxtObjec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.lblnursename = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtgcareplan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgcareplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblnursename)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Btnclear)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Btnedit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 295)
        Me.Panel1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(667, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtEval)
        Me.Panel4.Controls.Add(Me.TxtNursOrd)
        Me.Panel4.Controls.Add(Me.TxtObjec)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtDiagnosis)
        Me.Panel4.Location = New System.Drawing.Point(3, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(658, 257)
        Me.Panel4.TabIndex = 7
        '
        'TxtEval
        '
        Me.TxtEval.Location = New System.Drawing.Point(324, 144)
        Me.TxtEval.Multiline = True
        Me.TxtEval.Name = "TxtEval"
        Me.TxtEval.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtEval.Size = New System.Drawing.Size(273, 76)
        Me.TxtEval.TabIndex = 7
        '
        'TxtNursOrd
        '
        Me.TxtNursOrd.Location = New System.Drawing.Point(12, 144)
        Me.TxtNursOrd.Multiline = True
        Me.TxtNursOrd.Name = "TxtNursOrd"
        Me.TxtNursOrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNursOrd.Size = New System.Drawing.Size(273, 76)
        Me.TxtNursOrd.TabIndex = 6
        '
        'TxtObjec
        '
        Me.TxtObjec.Location = New System.Drawing.Point(324, 38)
        Me.TxtObjec.Multiline = True
        Me.TxtObjec.Name = "TxtObjec"
        Me.TxtObjec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObjec.Size = New System.Drawing.Size(273, 76)
        Me.TxtObjec.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Evaluation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nursing Order:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Objectives:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnosis:"
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.Location = New System.Drawing.Point(12, 38)
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDiagnosis.Size = New System.Drawing.Size(273, 76)
        Me.TxtDiagnosis.TabIndex = 0
        '
        'lblnursename
        '
        Me.lblnursename.AutoSize = True
        Me.lblnursename.Location = New System.Drawing.Point(680, 128)
        Me.lblnursename.Name = "lblnursename"
        Me.lblnursename.Size = New System.Drawing.Size(10, 13)
        Me.lblnursename.TabIndex = 6
        Me.lblnursename.Text = " "
        Me.lblnursename.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.Blue
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(827, 27)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(297, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NURSING CARE PLAN"
        '
        'Txtpass
        '
        Me.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpass.Location = New System.Drawing.Point(667, 230)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(156, 20)
        Me.Txtpass.TabIndex = 3
        '
        'Btnclear
        '
        Me.Btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclear.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnclear.Location = New System.Drawing.Point(748, 256)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(72, 23)
        Me.Btnclear.TabIndex = 2
        Me.Btnclear.Text = "CLEAR"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnsave.Location = New System.Drawing.Point(667, 257)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 1
        Me.Btnsave.Text = "SAVE"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Btnedit
        '
        Me.Btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnedit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnedit.Location = New System.Drawing.Point(667, 257)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(75, 23)
        Me.Btnedit.TabIndex = 5
        Me.Btnedit.Text = "EDIT"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Dtgcareplan)
        Me.Panel2.Location = New System.Drawing.Point(13, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 154)
        Me.Panel2.TabIndex = 3
        '
        'Dtgcareplan
        '
        Me.Dtgcareplan.AllowUserToAddRows = False
        Me.Dtgcareplan.AllowUserToDeleteRows = False
        Me.Dtgcareplan.AllowUserToResizeColumns = False
        Me.Dtgcareplan.AllowUserToResizeRows = False
        Me.Dtgcareplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtgcareplan.BackgroundColor = System.Drawing.Color.White
        Me.Dtgcareplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgcareplan.Location = New System.Drawing.Point(3, 3)
        Me.Dtgcareplan.Name = "Dtgcareplan"
        Me.Dtgcareplan.ReadOnly = True
        Me.Dtgcareplan.Size = New System.Drawing.Size(798, 146)
        Me.Dtgcareplan.TabIndex = 0
        '
        'CarePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CarePlan"
        Me.Size = New System.Drawing.Size(829, 452)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dtgcareplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblnursename As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents Btnedit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dtgcareplan As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtDiagnosis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEval As TextBox
    Friend WithEvents TxtNursOrd As TextBox
    Friend WithEvents TxtObjec As TextBox
End Class
