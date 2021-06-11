Imports System.Data.SqlClient

Public Class InpatientRadHx
    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.BtnSaveWard.BringToFront()
        FrmRadrequest.ShowDialog()
    End Sub

    Public Sub LoadRAdilogicalHx()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested, Requested_by, Date_Reported from VwRadRequestAndResult WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.DtgRadHx.DataSource = tbl

    End Sub

    Private Sub DtgRadHx_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgRadHx.CellMouseDoubleClick
        FrmRadTreatResult.TxtRqstdate.Text = DtgRadHx.CurrentRow.Cells(1).Value
        FrmRadTreatResult.txtRqstby.Text = DtgRadHx.CurrentRow.Cells(2).Value.ToString

        FrmRadTreatResult.Lblrqstnum.Text = FrmAdmitFolder.InpatientRadHx1.DtgRadHx.CurrentRow.Cells(0).Value

        FrmRadTreatResult.LoadPtRadInForInpatient()
        FrmRadTreatResult.ShowDialog()
    End Sub

End Class
