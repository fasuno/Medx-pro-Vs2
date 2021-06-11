Imports System.Data.SqlClient

Public Class frmNursing

    Public Sub sortvitalssigns()
        '// This code will sort the Vitals signs by date seletected
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from Pending_Vitals WHERE Appointment_date BETWEEN @datfrom AND @datto", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = PenVitFrm.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = PenVitTo.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        dtgpendingvitals.DataSource = tbl
        dtgpendingvitals.AutoResizeColumns()
        Label2.Text = dtgpendingvitals.RowCount

    End Sub

    Public Sub sorttreatvitals()
        '// This code will sort the Vitals signs by date seletected
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from Treated_Vitals WHERE Date BETWEEN @datfrom AND @datto", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = TreatVitDtFrm.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = TreatVitDtto.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        dtgtreatedvitals.DataSource = tbl
        dtgpendingvitals.AutoResizeColumns()

        Label5.Text = dtgtreatedvitals.RowCount

    End Sub

    Private Sub btnrefvitals_Click(sender As Object, e As EventArgs) Handles btnrefvitals.Click

        sortvitalssigns()
    End Sub

    Private Sub chkAllPendVitals_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllPendVitals.CheckedChanged

        If chkAllPendVitals.Checked = True Then
            txtpendVit.Enabled = False
            sortvitalssigns()

        Else

            txtpendVit.Enabled = True
            txtpendVit.Text = ""
            sortvitalssigns()
        End If

    End Sub

    Private Sub btnfindpendvit_Click(sender As Object, e As EventArgs) Handles btnfindpendvit.Click
        cmd = New SqlCommand("Select * from Pending_Vitals where Hospital_No=@Hospital_Num", con)
        cmd.Parameters.Add("@Hospital_Num", SqlDbType.VarChar).Value = txtpendVit.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            dtgpendingvitals.DataSource = tbl

        Else
            MessageBox.Show("PATIENT NOT FOUND IN PENDING VITALS", "VITAL SIGNS", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub cbopenvitals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopenvitals.SelectedIndexChanged

        cmd = New SqlCommand("Select * from Pending_Vitals WHERE Clinic=@clini", con)
        cmd.Parameters.Add("@clini", SqlDbType.VarChar).Value = cbopenvitals.SelectedItem

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            dtgpendingvitals.DataSource = tbl


            Label2.Text = dtgpendingvitals.RowCount

        Else
            MessageBox.Show("No Pending Appointment for This Clinic", "Nurse Station", MessageBoxButtons.OK)

            sortvitalssigns()


        End If


    End Sub

    Private Sub frmNursing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sortvitalssigns()
        sorttreatvitals()
        Label2.Text = dtgpendingvitals.RowCount
        Label5.Text = dtgtreatedvitals.RowCount
    End Sub

    Private Sub dtgpendingvitals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgpendingvitals.CellDoubleClick


        If dtgpendingvitals.CurrentRow.Cells(8).Value = "ANC" Then

            Dim frms = New FrmANCform
            FrmANCform.lblhospnum.Text = dtgpendingvitals.CurrentRow.Cells(4).Value

            FrmANCform.ShowDialog()
        Else

            Dim frm = New Frmvitals

            frm.lblsurname.Text = dtgpendingvitals.CurrentRow.Cells(2).Value.ToString()
            frm.lblothernames.Text = dtgpendingvitals.CurrentRow.Cells(3).Value.ToString()
            frm.lblhospnum.Text = dtgpendingvitals.CurrentRow.Cells(4).Value.ToString()
            frm.lblage.Text = dtgpendingvitals.CurrentRow.Cells(5).Value.ToString()
            frm.lblsex.Text = dtgpendingvitals.CurrentRow.Cells(6).Value.ToString()
            frm.lblaccounttype.Text = dtgpendingvitals.CurrentRow.Cells(7).Value.ToString()
            frm.lblclinic.Text = dtgpendingvitals.CurrentRow.Cells(8).Value.ToString()
            frm.lblcat.Text = dtgpendingvitals.CurrentRow.Cells(9).Value.ToString()

            frm.ShowDialog()
            frm.cleartxt()
            frm.BtnChng.Enabled = False
        End If
    End Sub

    Private Sub btnreftrtvital_Click(sender As Object, e As EventArgs) Handles btnreftrtvital.Click

        '// refresh treated vitals signs grid by date

        sorttreatvitals()
    End Sub

    Private Sub btntrtvitals_Click(sender As Object, e As EventArgs) Handles btnFindtrtvitals.Click

        cmd = New SqlCommand("Select * from Treated_Vitals where Hospital_No=@Hosp_Num", con)
        cmd.Parameters.Add("Hosp_Num", SqlDbType.VarChar).Value = txttrtvitals.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            dtgtreatedvitals.DataSource = tbl
            Label5.Text = dtgtreatedvitals.RowCount

        Else
            MessageBox.Show("PATIENT NOT FOUND IN TREATED VITALS", "VITAL SIGNS", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub chkviewalltreatedvitals_CheckedChanged(sender As Object, e As EventArgs) Handles chkviewalltreatedvitals.CheckedChanged
        If chkviewalltreatedvitals.Checked = True Then
            txttrtvitals.Enabled = False
            txttrtvitals.Text = ""

        Else
            txttrtvitals.Enabled = True
        End If
        sorttreatvitals()
    End Sub

    Private Sub cbotreatedvit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotreatedvit.SelectedIndexChanged

        cmd = New SqlCommand("Select * from Treated_Vitals WHERE Clinic=@clinic and date BETWEEN @dfrom AND @dtto", con)
        cmd.Parameters.Add("@clinic", SqlDbType.VarChar).Value = cbotreatedvit.SelectedItem
        cmd.Parameters.Add("@dfrom", SqlDbType.Date).Value = TreatVitDtFrm.Value
        cmd.Parameters.Add("@dtto", SqlDbType.Date).Value = TreatVitDtto.Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            dtgtreatedvitals.DataSource = tbl


            Label5.Text = dtgtreatedvitals.RowCount

        Else
            MessageBox.Show("No treated Appointment for This Clinic", "Nurse station", MessageBoxButtons.OK)

            sorttreatvitals()

        End If


    End Sub

    Private Sub dtgtreatedvitals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgtreatedvitals.CellDoubleClick

        If dtgtreatedvitals.CurrentRow.Cells(14).Value = "ANC" Then

            Dim frms = New FrmANCform
            FrmANCform.lblhospnum.Text = dtgtreatedvitals.CurrentRow.Cells(4).Value

            FrmANCform.Show()
        Else


            Dim frm = New Frmvitals

            Frmvitals.Datetaken.Text = dtgtreatedvitals.CurrentRow.Cells(0).Value.ToString()
            Frmvitals.timetaken.Text = dtgtreatedvitals.CurrentRow.Cells(1).Value.ToString()
            Frmvitals.lblsurname.Text = dtgtreatedvitals.CurrentRow.Cells(2).Value.ToString()
            Frmvitals.lblothernames.Text = dtgtreatedvitals.CurrentRow.Cells(3).Value.ToString()
            Frmvitals.lblhospnum.Text = dtgtreatedvitals.CurrentRow.Cells(4).Value.ToString()
            Frmvitals.lblage.Text = dtgtreatedvitals.CurrentRow.Cells(5).Value.ToString()
            Frmvitals.lblsex.Text = dtgtreatedvitals.CurrentRow.Cells(6).Value.ToString()
            Frmvitals.lblaccounttype.Text = dtgtreatedvitals.CurrentRow.Cells(7).Value.ToString()
            Frmvitals.TxtBp.Text = dtgtreatedvitals.CurrentRow.Cells(8).Value
            Frmvitals.txtTemp.Text = dtgtreatedvitals.CurrentRow.Cells(9).Value.ToString()
            Frmvitals.txtPulse.Text = dtgtreatedvitals.CurrentRow.Cells(10).Value.ToString()
            Frmvitals.txtWeight.Text = dtgtreatedvitals.CurrentRow.Cells(11).Value.ToString()
            Frmvitals.txtHeight.Text = dtgtreatedvitals.CurrentRow.Cells(12).Value.ToString()
            Frmvitals.txtResp.Text = dtgtreatedvitals.CurrentRow.Cells(13).Value.ToString()
            Frmvitals.lblclinic.Text = dtgtreatedvitals.CurrentRow.Cells(14).Value.ToString()
            Frmvitals.cbodoctor.Text = dtgtreatedvitals.CurrentRow.Cells(15).Value.ToString()
            Frmvitals.cborooms.Text = dtgtreatedvitals.CurrentRow.Cells(16).Value.ToString()


            Frmvitals.BtnSend.Enabled = False
            Frmvitals.BtnChng.Enabled = True

            Frmvitals.ShowDialog()

        End If
    End Sub


End Class