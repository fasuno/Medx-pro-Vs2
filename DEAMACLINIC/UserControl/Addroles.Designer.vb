<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addroles
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrole = New System.Windows.Forms.TextBox()
        Me.dgvrole = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnaddrole = New System.Windows.Forms.Button()
        Me.txtdecr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvrole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 33)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ADD ACCESS ROLES"
        '
        'txtrole
        '
        Me.txtrole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrole.Location = New System.Drawing.Point(83, 42)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(224, 20)
        Me.txtrole.TabIndex = 9
        '
        'dgvrole
        '
        Me.dgvrole.AllowUserToAddRows = False
        Me.dgvrole.AllowUserToDeleteRows = False
        Me.dgvrole.BackgroundColor = System.Drawing.Color.White
        Me.dgvrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrole.Location = New System.Drawing.Point(3, 96)
        Me.dgvrole.Name = "dgvrole"
        Me.dgvrole.Size = New System.Drawing.Size(390, 107)
        Me.dgvrole.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Role:"
        '
        'Btnaddrole
        '
        Me.Btnaddrole.BackColor = System.Drawing.Color.White
        Me.Btnaddrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnaddrole.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddrole.ForeColor = System.Drawing.Color.Green
        Me.Btnaddrole.Location = New System.Drawing.Point(310, 64)
        Me.Btnaddrole.Name = "Btnaddrole"
        Me.Btnaddrole.Size = New System.Drawing.Size(80, 23)
        Me.Btnaddrole.TabIndex = 6
        Me.Btnaddrole.Text = "ADD ROLE"
        Me.Btnaddrole.UseVisualStyleBackColor = False
        '
        'txtdecr
        '
        Me.txtdecr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdecr.Location = New System.Drawing.Point(83, 67)
        Me.txtdecr.Name = "txtdecr"
        Me.txtdecr.Size = New System.Drawing.Size(224, 20)
        Me.txtdecr.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Description:"
        '
        'Addroles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtdecr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.dgvrole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnaddrole)
        Me.Name = "Addroles"
        Me.Size = New System.Drawing.Size(396, 205)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvrole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrole As TextBox
    Friend WithEvents dgvrole As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnaddrole As Button
    Friend WithEvents txtdecr As TextBox
    Friend WithEvents Label3 As Label
End Class
