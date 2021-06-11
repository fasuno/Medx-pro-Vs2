<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRefer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRefer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtnote = New System.Windows.Forms.TextBox()
        Me.BtnRefer = New System.Windows.Forms.Button()
        Me.CboDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblDocid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cboclinic = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REFER TO:"
        '
        'Txtnote
        '
        Me.Txtnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnote.Location = New System.Drawing.Point(81, 223)
        Me.Txtnote.Multiline = True
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtnote.Size = New System.Drawing.Size(317, 21)
        Me.Txtnote.TabIndex = 1
        '
        'BtnRefer
        '
        Me.BtnRefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefer.Location = New System.Drawing.Point(256, 78)
        Me.BtnRefer.Name = "BtnRefer"
        Me.BtnRefer.Size = New System.Drawing.Size(135, 26)
        Me.BtnRefer.TabIndex = 2
        Me.BtnRefer.Text = "REFER PATIENT"
        Me.BtnRefer.UseVisualStyleBackColor = True
        '
        'CboDoc
        '
        Me.CboDoc.FormattingEnabled = True
        Me.CboDoc.Location = New System.Drawing.Point(89, 37)
        Me.CboDoc.Name = "CboDoc"
        Me.CboDoc.Size = New System.Drawing.Size(302, 21)
        Me.CboDoc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOTE:"
        '
        'Txtpass
        '
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpass.Location = New System.Drawing.Point(91, 81)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(162, 22)
        Me.Txtpass.TabIndex = 5
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbluser.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Black
        Me.lbluser.Location = New System.Drawing.Point(12, 252)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(12, 17)
        Me.lbluser.TabIndex = 6
        Me.lbluser.Text = " "
        Me.lbluser.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(93, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter Password:"
        '
        'LblDocid
        '
        Me.LblDocid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDocid.Location = New System.Drawing.Point(12, 57)
        Me.LblDocid.Name = "LblDocid"
        Me.LblDocid.Size = New System.Drawing.Size(43, 22)
        Me.LblDocid.TabIndex = 8
        Me.LblDocid.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "REFERING FROM:"
        '
        'Cboclinic
        '
        Me.Cboclinic.FormattingEnabled = True
        Me.Cboclinic.Items.AddRange(New Object() {"GOPD", "ORTHOPEDIC"})
        Me.Cboclinic.Location = New System.Drawing.Point(127, 9)
        Me.Cboclinic.Name = "Cboclinic"
        Me.Cboclinic.Size = New System.Drawing.Size(264, 21)
        Me.Cboclinic.TabIndex = 9
        '
        'FrmRefer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 110)
        Me.Controls.Add(Me.Cboclinic)
        Me.Controls.Add(Me.LblDocid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboDoc)
        Me.Controls.Add(Me.BtnRefer)
        Me.Controls.Add(Me.Txtnote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRefer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " INTERNAL REFERAL FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtnote As TextBox
    Friend WithEvents BtnRefer As Button
    Friend WithEvents CboDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents lbluser As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblDocid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cboclinic As ComboBox
End Class
