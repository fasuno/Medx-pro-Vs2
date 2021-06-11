Imports System.Data.SqlClient

Public Class PtDrugs1

    Public Sub LoadDrugsHx()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Presc_Num, Date, Time, Clinic, Diagnosis, Prescribed_By from AllDrugPresc WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.DtgDrugshx.DataSource = tbl

    End Sub

    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        FrmDrugsPresc.LoadDrugs()
        FrmDrugsPresc.ShowDialog()
    End Sub

    Private Sub PtDrugs1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadDrugsHx()
    End Sub

    Private Sub DtgDrugshx_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgDrugshx.CellMouseDoubleClick
        ' Dim frms = New FrmDrugPreview

        FrmDrugPreview.Txtdate.Text = DtgDrugshx.CurrentRow.Cells(1).Value
        FrmDrugPreview.txtprescby.Text = DtgDrugshx.CurrentRow.Cells(5).Value
        FrmDrugPreview.txtid.Text = DtgDrugshx.CurrentRow.Cells(0).Value
        FrmDrugPreview.txtdiagn.Text = DtgDrugshx.CurrentRow.Cells(4).Value

        FrmDrugPreview.ShowDrugs()
        FrmDrugPreview.ShowDialog()

    End Sub


End Class
