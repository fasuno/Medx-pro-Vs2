
Imports System.Data.SqlClient

Public Class frmAllwaitingList

    Public Sub LoadAllPendLIst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from VwPendingConsult WHERE Date BETWEEN @datfrom AND @datto", con)

        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = dtfrom.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = dtto.Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgAllPendWaitlist.DataSource = tbl
        lblCountPend.Text = DtgAllPendWaitlist.RowCount
    End Sub

    Public Sub LoadAllTreatedList()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from VwTreatedConsult WHERE  Date BETWEEN @datfrom AND @datto", con)

        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = from.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = dto.Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgTreatWaitlist.DataSource = tbl
        LblcountTreat.Text = DtgTreatWaitlist.RowCount


    End Sub

    Private Sub Btnref_Click(sender As Object, e As EventArgs) Handles Btnref.Click
        LoadAllTreatedList()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        LoadAllPendLIst()
    End Sub

    Private Sub BtnsearchPend_Click(sender As Object, e As EventArgs) Handles BtnsearchPend.Click

        cmd = New SqlCommand("Select * from VwPendingConsult WHERE Hospital_No=@HospNum", con)

        cmd.Parameters.Add("@HospNum", SqlDbType.VarChar).Value = txtSrchPend.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgAllPendWaitlist.DataSource = tbl
            lblCountPend.Text = DtgAllPendWaitlist.RowCount

        Else
            MessageBox.Show("Patient Is Not found In The Pending List", "Medx-Pro", MessageBoxButtons.OK)
            txtSrchPend.Text = ""
            txtSrchPend.Focus()
        End If
    End Sub

    Private Sub btnfindTreat_Click(sender As Object, e As EventArgs) Handles btnfindTreat.Click

        cmd = New SqlCommand("Select * from VwTreatedCOnsult WHERE Hospital_Num=@HNum", con)

        cmd.Parameters.Add("@HNum", SqlDbType.VarChar).Value = Txtfindpt.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then
            DtgTreatWaitlist.DataSource = tbl
            LblcountTreat.Text = DtgTreatWaitlist.RowCount

        Else
            MessageBox.Show("Patient Is Not In Your Treated List Check General list", "Medx-pro", MessageBoxButtons.OK)
            Txtfindpt.Text = ""
            Txtfindpt.Focus()
        End If


    End Sub

    Private Sub Cboclinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cboclinic.SelectedIndexChanged

        cmd = New SqlCommand("Select * from VwTreatedConsult WHERE Clinic=@clinic AND date BETWEEN @datfrom AND @datto", con)

        cmd.Parameters.Add("clinic", SqlDbType.VarChar).Value = Cboclinic.SelectedItem

        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = from.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = dto.Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgTreatWaitlist.DataSource = tbl


            LblcountTreat.Text = DtgTreatWaitlist.RowCount

        Else
            MessageBox.Show("No Treated Appointment for This Clinic", "Medx-pro", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub DtgAllPendWaitlist_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgAllPendWaitlist.CellMouseDoubleClick
        ' Dim frms = New FrmPtRecords

        FrmPtRecords.TxtApptDate.Text = DtgAllPendWaitlist.CurrentRow.Cells(0).Value
        FrmPtRecords.Lblsurname.Text = DtgAllPendWaitlist.CurrentRow.Cells(2).Value.ToString
        FrmPtRecords.Lblothernmaes.Text = DtgAllPendWaitlist.CurrentRow.Cells(3).Value.ToString
        FrmPtRecords.Lblhopnum.Text = DtgAllPendWaitlist.CurrentRow.Cells(4).Value.ToString
        FrmPtRecords.Txtbp.Text = DtgAllPendWaitlist.CurrentRow.Cells(9).Value.ToString
        FrmPtRecords.txttemp.Text = DtgAllPendWaitlist.CurrentRow.Cells(10).Value.ToString
        FrmPtRecords.txtheight.Text = DtgAllPendWaitlist.CurrentRow.Cells(13).Value.ToString
        FrmPtRecords.txtpulse.Text = DtgAllPendWaitlist.CurrentRow.Cells(11).Value.ToString
        FrmPtRecords.txtweight.Text = DtgAllPendWaitlist.CurrentRow.Cells(12).Value.ToString
        FrmPtRecords.txtresp.Text = DtgAllPendWaitlist.CurrentRow.Cells(14).Value.ToString
        FrmPtRecords.lblage.Text = DtgAllPendWaitlist.CurrentRow.Cells(5).Value.ToString
        FrmPtRecords.lblsex.Text = DtgAllPendWaitlist.CurrentRow.Cells(6).Value.ToString
        FrmPtRecords.lblacct.Text = DtgAllPendWaitlist.CurrentRow.Cells(7).Value.ToString
        FrmPtRecords.lbldocid.Text = DtgAllPendWaitlist.CurrentRow.Cells(19).Value.ToString

        FrmPtRecords.ShowDialog()
    End Sub
    Private Sub DtgTreatWaitlist_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgTreatWaitlist.CellMouseDoubleClick
        ' Dim frm = New FrmPtRecords

        FrmPtRecords.Lblsurname.Text = DtgTreatWaitlist.CurrentRow.Cells(2).Value.ToString
        FrmPtRecords.Lblothernmaes.Text = DtgTreatWaitlist.CurrentRow.Cells(3).Value.ToString
        FrmPtRecords.Lblhopnum.Text = DtgTreatWaitlist.CurrentRow.Cells(4).Value.ToString
        FrmPtRecords.lblage.Text = DtgTreatWaitlist.CurrentRow.Cells(5).Value.ToString
        FrmPtRecords.lblsex.Text = DtgTreatWaitlist.CurrentRow.Cells(6).Value.ToString
        FrmPtRecords.lblacct.Text = DtgTreatWaitlist.CurrentRow.Cells(7).Value.ToString
        FrmPtRecords.lbldocid.Text = DtgTreatWaitlist.CurrentRow.Cells(11).Value.ToString

        FrmPtRecords.ShowDialog()
    End Sub

End Class