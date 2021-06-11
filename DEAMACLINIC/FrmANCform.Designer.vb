<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmANCform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmANCform))
        Me.dtndelivreg = New System.Windows.Forms.Button()
        Me.btnbooking = New System.Windows.Forms.Button()
        Me.btndrug = New System.Windows.Forms.Button()
        Me.btnrad = New System.Windows.Forms.Button()
        Me.btnlab = New System.Windows.Forms.Button()
        Me.btnfolwup = New System.Windows.Forms.Button()
        Me.Btnprof = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btnseedoc = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhospnum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblbkid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AncBooking1 = New DEAMACLINIC.ANCBooking()
        Me.AnCfollowup1 = New DEAMACLINIC.ANCfollowup()
        Me.AncProfile2 = New DEAMACLINIC.AncProfile()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtndelivreg
        '
        Me.dtndelivreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtndelivreg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtndelivreg.ForeColor = System.Drawing.Color.White
        Me.dtndelivreg.Location = New System.Drawing.Point(10, 266)
        Me.dtndelivreg.Name = "dtndelivreg"
        Me.dtndelivreg.Size = New System.Drawing.Size(115, 28)
        Me.dtndelivreg.TabIndex = 24
        Me.dtndelivreg.Text = "DELIVERY REG."
        Me.dtndelivreg.UseVisualStyleBackColor = True
        '
        'btnbooking
        '
        Me.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbooking.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbooking.ForeColor = System.Drawing.Color.White
        Me.btnbooking.Location = New System.Drawing.Point(10, 78)
        Me.btnbooking.Name = "btnbooking"
        Me.btnbooking.Size = New System.Drawing.Size(115, 28)
        Me.btnbooking.TabIndex = 23
        Me.btnbooking.Text = "BOOKING"
        Me.btnbooking.UseVisualStyleBackColor = True
        '
        'btndrug
        '
        Me.btndrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndrug.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrug.ForeColor = System.Drawing.Color.White
        Me.btndrug.Location = New System.Drawing.Point(10, 235)
        Me.btndrug.Name = "btndrug"
        Me.btndrug.Size = New System.Drawing.Size(115, 28)
        Me.btndrug.TabIndex = 22
        Me.btndrug.Text = "DRUGS"
        Me.btndrug.UseVisualStyleBackColor = True
        '
        'btnrad
        '
        Me.btnrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrad.ForeColor = System.Drawing.Color.White
        Me.btnrad.Location = New System.Drawing.Point(10, 204)
        Me.btnrad.Name = "btnrad"
        Me.btnrad.Size = New System.Drawing.Size(115, 28)
        Me.btnrad.TabIndex = 21
        Me.btnrad.Text = "RADIOLOGY"
        Me.btnrad.UseVisualStyleBackColor = True
        '
        'btnlab
        '
        Me.btnlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlab.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlab.ForeColor = System.Drawing.Color.White
        Me.btnlab.Location = New System.Drawing.Point(10, 172)
        Me.btnlab.Name = "btnlab"
        Me.btnlab.Size = New System.Drawing.Size(115, 28)
        Me.btnlab.TabIndex = 20
        Me.btnlab.Text = "LAB"
        Me.btnlab.UseVisualStyleBackColor = True
        '
        'btnfolwup
        '
        Me.btnfolwup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfolwup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfolwup.ForeColor = System.Drawing.Color.White
        Me.btnfolwup.Location = New System.Drawing.Point(10, 109)
        Me.btnfolwup.Name = "btnfolwup"
        Me.btnfolwup.Size = New System.Drawing.Size(115, 28)
        Me.btnfolwup.TabIndex = 19
        Me.btnfolwup.Text = "FOLLOW-UP"
        Me.btnfolwup.UseVisualStyleBackColor = True
        '
        'Btnprof
        '
        Me.Btnprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnprof.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprof.ForeColor = System.Drawing.Color.White
        Me.Btnprof.Location = New System.Drawing.Point(10, 47)
        Me.Btnprof.Name = "Btnprof"
        Me.Btnprof.Size = New System.Drawing.Size(115, 28)
        Me.Btnprof.TabIndex = 18
        Me.Btnprof.Text = "PROFILE"
        Me.Btnprof.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Btnseedoc)
        Me.Panel2.Controls.Add(Me.btnlab)
        Me.Panel2.Controls.Add(Me.Btnprof)
        Me.Panel2.Controls.Add(Me.dtndelivreg)
        Me.Panel2.Controls.Add(Me.btnfolwup)
        Me.Panel2.Controls.Add(Me.btnbooking)
        Me.Panel2.Controls.Add(Me.btnrad)
        Me.Panel2.Controls.Add(Me.btndrug)
        Me.Panel2.Location = New System.Drawing.Point(2, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 422)
        Me.Panel2.TabIndex = 26
        '
        'Btnseedoc
        '
        Me.Btnseedoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnseedoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnseedoc.ForeColor = System.Drawing.Color.White
        Me.Btnseedoc.Location = New System.Drawing.Point(10, 141)
        Me.Btnseedoc.Name = "Btnseedoc"
        Me.Btnseedoc.Size = New System.Drawing.Size(115, 28)
        Me.Btnseedoc.TabIndex = 25
        Me.Btnseedoc.Text = "SEE DOCTOR"
        Me.Btnseedoc.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblhospnum)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblbkid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 35)
        Me.Panel1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(458, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ANTE-NATAL CARE CARD"
        '
        'lblhospnum
        '
        Me.lblhospnum.AutoSize = True
        Me.lblhospnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhospnum.Location = New System.Drawing.Point(236, 11)
        Me.lblhospnum.Name = "lblhospnum"
        Me.lblhospnum.Size = New System.Drawing.Size(10, 15)
        Me.lblhospnum.TabIndex = 3
        Me.lblhospnum.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hospital No.:"
        '
        'lblbkid
        '
        Me.lblbkid.AutoSize = True
        Me.lblbkid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbkid.Location = New System.Drawing.Point(72, 11)
        Me.lblbkid.Name = "lblbkid"
        Me.lblbkid.Size = New System.Drawing.Size(10, 15)
        Me.lblbkid.TabIndex = 1
        Me.lblbkid.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking ID:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.AncBooking1)
        Me.Panel3.Controls.Add(Me.AnCfollowup1)
        Me.Panel3.Controls.Add(Me.AncProfile2)
        Me.Panel3.Location = New System.Drawing.Point(133, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(703, 422)
        Me.Panel3.TabIndex = 27
        '
        'AncBooking1
        '
        Me.AncBooking1.Location = New System.Drawing.Point(4, 0)
        Me.AncBooking1.Name = "AncBooking1"
        Me.AncBooking1.Size = New System.Drawing.Size(699, 416)
        Me.AncBooking1.TabIndex = 3
        '
        'AnCfollowup1
        '
        Me.AnCfollowup1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AnCfollowup1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnCfollowup1.ForeColor = System.Drawing.Color.Black
        Me.AnCfollowup1.Location = New System.Drawing.Point(3, 2)
        Me.AnCfollowup1.Name = "AnCfollowup1"
        Me.AnCfollowup1.Size = New System.Drawing.Size(697, 414)
        Me.AnCfollowup1.TabIndex = 2
        '
        'AncProfile2
        '
        Me.AncProfile2.BackColor = System.Drawing.Color.White
        Me.AncProfile2.Location = New System.Drawing.Point(4, 2)
        Me.AncProfile2.Name = "AncProfile2"
        Me.AncProfile2.Size = New System.Drawing.Size(697, 419)
        Me.AncProfile2.TabIndex = 0
        '
        'FrmANCform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmANCform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  ANTE-NATAL "
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtndelivreg As Button
    Friend WithEvents btnbooking As Button
    Friend WithEvents btndrug As Button
    Friend WithEvents btnrad As Button
    Friend WithEvents btnlab As Button
    Friend WithEvents btnfolwup As Button
    Friend WithEvents Btnprof As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AncProfile1 As AncProfile
    Friend WithEvents Btnseedoc As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblhospnum As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblbkid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AncBooking1 As ANCBooking
    Friend WithEvents AnCfollowup1 As ANCfollowup
    Friend WithEvents AncProfile2 As AncProfile
End Class
