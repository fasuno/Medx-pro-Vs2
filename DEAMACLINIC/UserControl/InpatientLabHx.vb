Imports System.Data.SqlClient

Public Class InpatientLabHx
    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        FrmLabrequest.LoadLAbTest()
        FrmLabrequest.BtnSaveWard.BringToFront()
        FrmLabrequest.ShowDialog()

    End Sub

    Public Sub LoadLabReqstHx()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_Num, Date, Clinic, Diagnosis, Requested_By from LabRequest WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.DtgLabhx.DataSource = tbl

    End Sub

    Private Sub DtgLabhx_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgLabhx.CellMouseDoubleClick

        FrmLabResultpreview.Txtdatrqst.Text = DtgLabhx.CurrentRow.Cells(1).Value
        FrmLabResultpreview.Lblrqstnum.Text = DtgLabhx.CurrentRow.Cells(0).Value
        FrmLabResultpreview.txtclinic.Text = DtgLabhx.CurrentRow.Cells(2).Value
        FrmLabResultpreview.Txtdiag.Text = DtgLabhx.CurrentRow.Cells(3).Value
        FrmLabResultpreview.TxtRqstBy.Text = DtgLabhx.CurrentRow.Cells(4).Value

        FrmLabResultpreview.LoadPtForWard()

        FrmLabResultpreview.ShowDialog()
    End Sub


End Class
