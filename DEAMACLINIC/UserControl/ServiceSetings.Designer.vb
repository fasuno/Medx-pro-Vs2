<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceSetings
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
        Me.Btnaddserv = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgservice = New System.Windows.Forms.DataGridView()
        Me.txtserv = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgservice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnaddserv
        '
        Me.Btnaddserv.BackColor = System.Drawing.Color.White
        Me.Btnaddserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnaddserv.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddserv.ForeColor = System.Drawing.Color.Green
        Me.Btnaddserv.Location = New System.Drawing.Point(225, 65)
        Me.Btnaddserv.Name = "Btnaddserv"
        Me.Btnaddserv.Size = New System.Drawing.Size(107, 23)
        Me.Btnaddserv.TabIndex = 0
        Me.Btnaddserv.Text = "ADD SERVICE"
        Me.Btnaddserv.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Service:"
        '
        'dtgservice
        '
        Me.dtgservice.BackgroundColor = System.Drawing.Color.White
        Me.dtgservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgservice.Location = New System.Drawing.Point(3, 94)
        Me.dtgservice.Name = "dtgservice"
        Me.dtgservice.Size = New System.Drawing.Size(390, 107)
        Me.dtgservice.TabIndex = 3
        '
        'txtserv
        '
        Me.txtserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserv.Location = New System.Drawing.Point(66, 39)
        Me.txtserv.Name = "txtserv"
        Me.txtserv.Size = New System.Drawing.Size(266, 20)
        Me.txtserv.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 33)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(104, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NEW SERVICE ENTRY FORM"
        '
        'ServiceSetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtserv)
        Me.Controls.Add(Me.dtgservice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnaddserv)
        Me.Name = "ServiceSetings"
        Me.Size = New System.Drawing.Size(396, 205)
        CType(Me.dtgservice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnaddserv As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgservice As DataGridView
    Friend WithEvents txtserv As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
