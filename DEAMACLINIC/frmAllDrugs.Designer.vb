<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllDrugs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllDrugs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnreload = New System.Windows.Forms.Button()
        Me.Cbocategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtgdrugitems = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgdrugitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btnreload)
        Me.Panel1.Controls.Add(Me.Cbocategory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(6, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1152, 39)
        Me.Panel1.TabIndex = 1
        '
        'Btnreload
        '
        Me.Btnreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnreload.ForeColor = System.Drawing.Color.Blue
        Me.Btnreload.Image = CType(resources.GetObject("Btnreload.Image"), System.Drawing.Image)
        Me.Btnreload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnreload.Location = New System.Drawing.Point(339, 3)
        Me.Btnreload.Name = "Btnreload"
        Me.Btnreload.Size = New System.Drawing.Size(83, 29)
        Me.Btnreload.TabIndex = 2
        Me.Btnreload.Text = "      Reload"
        Me.Btnreload.UseVisualStyleBackColor = True
        '
        'Cbocategory
        '
        Me.Cbocategory.BackColor = System.Drawing.Color.White
        Me.Cbocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocategory.ForeColor = System.Drawing.Color.Black
        Me.Cbocategory.FormattingEnabled = True
        Me.Cbocategory.Items.AddRange(New Object() {"ANALGESICS", "ANTI-MALARIA", "HAEMATINICS/MULTIVITAMINS", "ANTI-BIOTICS", "ANTI-ULCER", "ANTI-SPASMODIC", "ANTI-DIARRHOEA", "ANTI-ASTHMATIC", "ANTI-HYPERTENSIVE", "ANTI-EMETIC", "ANTI-FUNGAL", "ANTI-ALLERGIC", "ANTI-TUSSIVE", "EYE AND EAR PREPARATIONS", "INFUSIONS", "SURGICALS", "STEROIDS", "ANTI-DIABETICS", "ANTI-HELMINTHIC", "EMERGENCY DRUGS", "SUPPLEMENTARY", "CONSUMABLE"})
        Me.Cbocategory.Location = New System.Drawing.Point(113, 6)
        Me.Cbocategory.Name = "Cbocategory"
        Me.Cbocategory.Size = New System.Drawing.Size(220, 23)
        Me.Cbocategory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sort by Category:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Dtgdrugitems)
        Me.Panel2.Location = New System.Drawing.Point(6, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1156, 341)
        Me.Panel2.TabIndex = 2
        '
        'Dtgdrugitems
        '
        Me.Dtgdrugitems.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.Dtgdrugitems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dtgdrugitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgdrugitems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dtgdrugitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dtgdrugitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgdrugitems.Location = New System.Drawing.Point(3, 3)
        Me.Dtgdrugitems.Name = "Dtgdrugitems"
        Me.Dtgdrugitems.ReadOnly = True
        Me.Dtgdrugitems.Size = New System.Drawing.Size(1146, 334)
        Me.Dtgdrugitems.TabIndex = 0
        '
        'frmAllDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1167, 393)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAllDrugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   ALL DRUG ITEMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dtgdrugitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cbocategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtgdrugitems As DataGridView
    Friend WithEvents Btnreload As Button
End Class
