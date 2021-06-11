<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnbed = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnserv = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btnaddrole = New System.Windows.Forms.Button()
        Me.Addroles1 = New DEAMACLINIC.Addroles()
        Me.BedManager1 = New DEAMACLINIC.BedManager()
        Me.CompanyInfo1 = New DEAMACLINIC.CompanyInfo()
        Me.ServiceSetings1 = New DEAMACLINIC.ServiceSetings()
        Me.AccountSet1 = New DEAMACLINIC.AccountSet()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btnaddrole)
        Me.Panel1.Controls.Add(Me.Btnbed)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnserv)
        Me.Panel1.Controls.Add(Me.BtnAccount)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 284)
        Me.Panel1.TabIndex = 0
        '
        'Btnbed
        '
        Me.Btnbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbed.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbed.ForeColor = System.Drawing.Color.Blue
        Me.Btnbed.Location = New System.Drawing.Point(8, 144)
        Me.Btnbed.Name = "Btnbed"
        Me.Btnbed.Size = New System.Drawing.Size(143, 29)
        Me.Btnbed.TabIndex = 3
        Me.Btnbed.Text = "Ward Bed List"
        Me.Btnbed.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(8, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hospital Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnserv
        '
        Me.btnserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnserv.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserv.ForeColor = System.Drawing.Color.Blue
        Me.btnserv.Location = New System.Drawing.Point(8, 82)
        Me.btnserv.Name = "btnserv"
        Me.btnserv.Size = New System.Drawing.Size(143, 29)
        Me.btnserv.TabIndex = 1
        Me.btnserv.Text = "Services"
        Me.btnserv.UseVisualStyleBackColor = True
        '
        'BtnAccount
        '
        Me.BtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccount.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.ForeColor = System.Drawing.Color.Blue
        Me.BtnAccount.Location = New System.Drawing.Point(8, 113)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(143, 29)
        Me.BtnAccount.TabIndex = 0
        Me.BtnAccount.Text = "Account Type"
        Me.BtnAccount.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Addroles1)
        Me.Panel2.Controls.Add(Me.BedManager1)
        Me.Panel2.Controls.Add(Me.CompanyInfo1)
        Me.Panel2.Controls.Add(Me.ServiceSetings1)
        Me.Panel2.Controls.Add(Me.AccountSet1)
        Me.Panel2.Location = New System.Drawing.Point(170, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 282)
        Me.Panel2.TabIndex = 1
        '
        'Btnaddrole
        '
        Me.Btnaddrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnaddrole.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddrole.ForeColor = System.Drawing.Color.Blue
        Me.Btnaddrole.Location = New System.Drawing.Point(8, 176)
        Me.Btnaddrole.Name = "Btnaddrole"
        Me.Btnaddrole.Size = New System.Drawing.Size(143, 29)
        Me.Btnaddrole.TabIndex = 4
        Me.Btnaddrole.Text = "Add User Role"
        Me.Btnaddrole.UseVisualStyleBackColor = True
        '
        'Addroles1
        '
        Me.Addroles1.BackColor = System.Drawing.Color.White
        Me.Addroles1.Location = New System.Drawing.Point(0, 0)
        Me.Addroles1.Name = "Addroles1"
        Me.Addroles1.Size = New System.Drawing.Size(486, 283)
        Me.Addroles1.TabIndex = 4
        '
        'BedManager1
        '
        Me.BedManager1.BackColor = System.Drawing.Color.White
        Me.BedManager1.Location = New System.Drawing.Point(-1, -4)
        Me.BedManager1.Name = "BedManager1"
        Me.BedManager1.Size = New System.Drawing.Size(487, 281)
        Me.BedManager1.TabIndex = 3
        '
        'CompanyInfo1
        '
        Me.CompanyInfo1.BackColor = System.Drawing.Color.White
        Me.CompanyInfo1.Location = New System.Drawing.Point(-4, -2)
        Me.CompanyInfo1.Name = "CompanyInfo1"
        Me.CompanyInfo1.Size = New System.Drawing.Size(490, 276)
        Me.CompanyInfo1.TabIndex = 2
        '
        'ServiceSetings1
        '
        Me.ServiceSetings1.BackColor = System.Drawing.Color.White
        Me.ServiceSetings1.Location = New System.Drawing.Point(-1, 3)
        Me.ServiceSetings1.Name = "ServiceSetings1"
        Me.ServiceSetings1.Size = New System.Drawing.Size(483, 273)
        Me.ServiceSetings1.TabIndex = 1
        '
        'AccountSet1
        '
        Me.AccountSet1.BackColor = System.Drawing.Color.Transparent
        Me.AccountSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountSet1.Location = New System.Drawing.Point(3, 4)
        Me.AccountSet1.Name = "AccountSet1"
        Me.AccountSet1.Size = New System.Drawing.Size(479, 273)
        Me.AccountSet1.TabIndex = 0
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 290)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " SETTINGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAccount As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AccountSet1 As AccountSet
    Friend WithEvents btnserv As Button
    Friend WithEvents ServiceSetings1 As ServiceSetings
    Friend WithEvents Button1 As Button
    Friend WithEvents CompanyInfo1 As CompanyInfo
    Friend WithEvents Btnbed As Button
    Friend WithEvents BedManager1 As BedManager
    Friend WithEvents Btnaddrole As Button
    Friend WithEvents Addroles1 As Addroles
End Class
