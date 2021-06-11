
Imports System.Data.SqlClient

Public Class frmAllDrugs

    Public Sub LoadAllDrugLIst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM Drug_List ", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Dtgdrugitems.DataSource = tbl
        Dtgdrugitems.AutoResizeColumns()

        ' Cbocategory.DataSource = tbl
        ' Cbocategory.DisplayMember = "Category"

    End Sub

    Private Sub frmAllDrugs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllDrugLIst()

    End Sub

    Private Sub Dtgdrugitems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgdrugitems.CellDoubleClick

        Dim frm As New FrmNewdrugs

        FrmNewdrugs.txtdrugid.Text = Dtgdrugitems.CurrentRow.Cells(2).Value.ToString
        FrmNewdrugs.txtdrugname.Text = Dtgdrugitems.CurrentRow.Cells(0).Value.ToString
        FrmNewdrugs.cbodrugcat.Text = Dtgdrugitems.CurrentRow.Cells(1).Value.ToString
        FrmNewdrugs.Expdat.Text = Dtgdrugitems.CurrentRow.Cells(10).Value.ToString
        FrmNewdrugs.cbounit.Text = Dtgdrugitems.CurrentRow.Cells(4).Value.ToString
        FrmNewdrugs.txtstockbal.Text = Dtgdrugitems.CurrentRow.Cells(5).Value.ToString
        FrmNewdrugs.txtnewstock.Text = Dtgdrugitems.CurrentRow.Cells(6).Value.ToString
        FrmNewdrugs.TxtBatchno.Text = Dtgdrugitems.CurrentRow.Cells(7).Value.ToString
        FrmNewdrugs.TxtLocat.Text = Dtgdrugitems.CurrentRow.Cells(8).Value.ToString
        FrmNewdrugs.txtRoderlev.Text = Dtgdrugitems.CurrentRow.Cells(9).Value.ToString
        FrmNewdrugs.txtcostperunit.Text = Dtgdrugitems.CurrentRow.Cells(11).Value.ToString

        FrmNewdrugs.BtnSavedrug.SendToBack()

        FrmNewdrugs.ShowDialog()

        'FrmNewdrugs.txtstockbal.ReadOnly = True
        'FrmNewdrugs.txtqtygiven.ReadOnly = True

    End Sub

    Private Sub Btnreload_Click(sender As Object, e As EventArgs) Handles Btnreload.Click
        cmd = New SqlCommand("Select * from Drug_List WHERE Category=@cat", con)
        cmd.Parameters.Add("@cat", SqlDbType.NVarChar).Value = Cbocategory.SelectedItem.ToString

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgdrugitems.DataSource = tbl

        End If
    End Sub


End Class