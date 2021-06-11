Imports System.Data.SqlClient

Public Class FrmMywaitinglist

    Public Sub LoadDocPendLIst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from VwPendingConsult WHERE Doctor_ID=@Docid AND Date BETWEEN @datfrom AND @datto", con)

        cmd.Parameters.Add("@Docid", SqlDbType.VarChar).Value = frmMain.Lbluserid.Text

        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = dtfrmpend.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = dttopend.Value

        adapt = New SqlDataAdapter(cmd)

        ' con.Open()

        adapt.Fill(tbl)
        Dtgmypendlist.DataSource = tbl
        ' Dtgmypendlist.Columns(20).Visible = False
        Label13.Text = Dtgmypendlist.RowCount

        ' con.Close()

    End Sub
    Public Sub LoadDocTreatedList()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from VwTreatedConsult WHERE Doctor_ID = @Doc AND Date BETWEEN @datfrom AND @datto", con)

        cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = frmMain.Lbluserid.Text

        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = Dttrtedfrom.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = Dttrtedto.Value

        adapt = New SqlDataAdapter(cmd)

        ' con.Open()

        adapt.Fill(tbl)
        DtgMyconsultation.DataSource = tbl
        '  DtgMyconsultation.Columns(11).Visible = False
        Label15.Text = DtgMyconsultation.RowCount
        'con.Close()
    End Sub
    Private Sub btnfindpt_Click(sender As Object, e As EventArgs) Handles btnfindpt.Click

        cmd = New SqlCommand("Select * from VwPendingConsult where Hospital_No=@Hospi_No", con)
        cmd.Parameters.Add("@Hospi_No", SqlDbType.VarChar).Value = txtfindpt.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgmypendlist.DataSource = tbl
            Label13.Text = Dtgmypendlist.RowCount

        Else
            MessageBox.Show("The Folder Number has not Been Assigned", "My Waiting List", MessageBoxButtons.OK)
            txtfindpt.Text = ""
            txtfindpt.Focus()
        End If
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        LoadDocPendLIst()
        txtfindpt.Text = ""
    End Sub

    Private Sub FrmMywaitinglist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = Dtgmypendlist.RowCount
        Label15.Text = DtgMyconsultation.RowCount
    End Sub

    Private Sub btngetpt_Click(sender As Object, e As EventArgs) Handles btngetpt.Click

        cmd = New SqlCommand("Select * from VwTreatedConsult where Hospital_No=@Hospital_Num", con)
        cmd.Parameters.Add("@Hospital_Num", SqlDbType.VarChar).Value = txtgetpt.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgMyconsultation.DataSource = tbl
            Label15.Text = DtgMyconsultation.RowCount

        Else
            MessageBox.Show("Patient Is Not In Your Treated List Check General list", "My Treated List", MessageBoxButtons.OK)
            txtgetpt.Text = ""
            txtgetpt.Focus()
        End If

    End Sub

    Private Sub btnrefreshconsult_Click(sender As Object, e As EventArgs) Handles btnrefreshconsult.Click
        LoadDocTreatedList()
        txtgetpt.Text = ""
    End Sub

    Private Sub DtgMyconsultation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgMyconsultation.CellDoubleClick
        Dim frm = New FrmPtRecords

        FrmPtRecords.Lblsurname.Text = DtgMyconsultation.CurrentRow.Cells(2).Value.ToString
        FrmPtRecords.Lblothernmaes.Text = DtgMyconsultation.CurrentRow.Cells(3).Value.ToString
        FrmPtRecords.Lblhopnum.Text = DtgMyconsultation.CurrentRow.Cells(4).Value.ToString
        FrmPtRecords.lblage.Text = DtgMyconsultation.CurrentRow.Cells(5).Value.ToString
        FrmPtRecords.lblsex.Text = DtgMyconsultation.CurrentRow.Cells(6).Value.ToString
        FrmPtRecords.lblacct.Text = DtgMyconsultation.CurrentRow.Cells(7).Value.ToString
        FrmPtRecords.lbldocid.Text = DtgMyconsultation.CurrentRow.Cells(11).Value.ToString

        FrmPtRecords.ShowDialog()
    End Sub

    Private Sub Dtgmypendlist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgmypendlist.CellDoubleClick
        Dim frm = New FrmPtRecords


        FrmPtRecords.TxtApptdate.Text = Dtgmypendlist.CurrentRow.Cells(0).Value
        FrmPtRecords.Lblsurname.Text = Dtgmypendlist.CurrentRow.Cells(2).Value.ToString
        FrmPtRecords.Lblothernmaes.Text = Dtgmypendlist.CurrentRow.Cells(3).Value.ToString
        FrmPtRecords.Lblhopnum.Text = Dtgmypendlist.CurrentRow.Cells(4).Value.ToString
        FrmPtRecords.Txtbp.Text = Dtgmypendlist.CurrentRow.Cells(9).Value.ToString
        FrmPtRecords.txttemp.Text = Dtgmypendlist.CurrentRow.Cells(10).Value.ToString
        FrmPtRecords.txtheight.Text = Dtgmypendlist.CurrentRow.Cells(13).Value.ToString
        FrmPtRecords.txtpulse.Text = Dtgmypendlist.CurrentRow.Cells(11).Value.ToString
        FrmPtRecords.txtweight.Text = Dtgmypendlist.CurrentRow.Cells(12).Value.ToString
        FrmPtRecords.txtresp.Text = Dtgmypendlist.CurrentRow.Cells(14).Value.ToString
        FrmPtRecords.lblage.Text = Dtgmypendlist.CurrentRow.Cells(5).Value.ToString
        FrmPtRecords.lblsex.Text = Dtgmypendlist.CurrentRow.Cells(6).Value.ToString
        FrmPtRecords.lblacct.Text = Dtgmypendlist.CurrentRow.Cells(7).Value.ToString
        FrmPtRecords.lbldocid.Text = Dtgmypendlist.CurrentRow.Cells(19).Value.ToString

        FrmPtRecords.ShowDialog()
    End Sub

End Class