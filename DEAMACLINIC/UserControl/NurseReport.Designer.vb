<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseReport
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
        Me.lblnursename = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Txtnote = New System.Windows.Forms.TextBox()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtgreport = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblnursename)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Btnclear)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Txtnote)
        Me.Panel1.Controls.Add(Me.Btnedit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 294)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(671, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Password:"
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
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(826, 27)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(297, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NURSING REPORT"
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
        'Txtnote
        '
        Me.Txtnote.BackColor = System.Drawing.Color.White
        Me.Txtnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnote.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnote.Location = New System.Drawing.Point(4, 33)
        Me.Txtnote.Multiline = True
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtnote.Size = New System.Drawing.Size(657, 253)
        Me.Txtnote.TabIndex = 0
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
        Me.Panel2.Controls.Add(Me.Dtgreport)
        Me.Panel2.Location = New System.Drawing.Point(13, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 154)
        Me.Panel2.TabIndex = 1
        '
        'Dtgreport
        '
        Me.Dtgreport.AllowUserToAddRows = False
        Me.Dtgreport.AllowUserToDeleteRows = False
        Me.Dtgreport.AllowUserToResizeColumns = False
        Me.Dtgreport.AllowUserToResizeRows = False
        Me.Dtgreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtgreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgreport.Location = New System.Drawing.Point(3, 3)
        Me.Dtgreport.Name = "Dtgreport"
        Me.Dtgreport.ReadOnly = True
        Me.Dtgreport.Size = New System.Drawing.Size(798, 146)
        Me.Dtgreport.TabIndex = 0
        '
        'NurseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NurseReport"
        Me.Size = New System.Drawing.Size(828, 453)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dtgreport As DataGridView
    Friend WithEvents Txtnote As TextBox
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btnedit As Button
    Friend WithEvents lblnursename As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
