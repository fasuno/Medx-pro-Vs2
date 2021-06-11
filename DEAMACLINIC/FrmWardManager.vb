Imports System.Data.SqlClient

Public Class FrmWardManager
    Public Sub LoadAdmitreqst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM AdmissionRequest WHERE Date Between @Dfrm AND @Dto", con)
        cmd.Parameters.Add("@Dfrm", SqlDbType.Date).Value = Dtfrmpend.Value
        cmd.Parameters.Add("@Dto", SqlDbType.Date).Value = DttoPend.Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.Dgvpend.DataSource = tbl

        Dgvpend.Columns(0).Visible = False

    End Sub
    Public Sub LoadPTonadmission()

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Admit_Id, Date_Admitted, Time, Hospital_Num, Surname, Other_names, Sex, Age, Diagnosis, Ward, Bed_No, Consultant, Admitted_By, Admission_Status FROM Admitted WHERE Date_Admitted Between @Dafrm And @Dato AND Admission_Status='On admission' OR Admission_Status='Discharge Ordered'", con)

        cmd.Parameters.Add("@Dafrm", SqlDbType.Date).Value = DtAfrm.Value
        cmd.Parameters.Add("@Dato", SqlDbType.Date).Value = DtAto.Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Me.Dgvonadmision.DataSource = tbls

        Dgvonadmision.Columns(0).Visible = False

    End Sub
    Public Sub LoadDischargedPT()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select * FROM DischargePT WHERE Date_Discharged BETWEEN @disfrm AND @Disto", con)
        cmd.Parameters.Add("@Disfrm", SqlDbType.Date).Value = Disfrm.Value
        cmd.Parameters.Add("@Disto", SqlDbType.Date).Value = Disto.Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Me.DgvDischrged.DataSource = tb

        DgvDischrged.Columns(0).Visible = False

    End Sub
    Private Sub FrmWardManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// SET DATETIME TO A PARTICULAR DATE
        Dim dt = DateTime.Now
        Dim startDt = New DateTime(dt.Year, dt.Month, 1)
        Dim EndDt = startDt.AddMonths(1).AddDays(-1)

        '  Dtfrmpend.Value = startDt
        ' DttoPend.Value = EndDt
        DtAfrm.Value = startDt
        DtAto.Value = EndDt

        LoadAdmitreqst()
        LoadPTonadmission()
        LoadDischargedPT()
    End Sub
    Private Sub Dgvpend_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvpend.CellDoubleClick

        ' Dim frm = New FrmNewAdmit

        FrmNewAdmit.Lbladmitid.Text = Dgvpend.CurrentRow.Cells(0).Value
        FrmNewAdmit.Txthospnum.Text = Dgvpend.CurrentRow.Cells(3).Value
        FrmNewAdmit.txtsname.Text = Dgvpend.CurrentRow.Cells(4).Value
        FrmNewAdmit.TxtOname.Text = Dgvpend.CurrentRow.Cells(5).Value
        FrmNewAdmit.Txtsex.Text = Dgvpend.CurrentRow.Cells(6).Value
        FrmNewAdmit.Txtage.Text = Dgvpend.CurrentRow.Cells(7).Value
        FrmNewAdmit.Txtdiag.Text = Dgvpend.CurrentRow.Cells(8).Value
        FrmNewAdmit.Txtadmtyp.Text = Dgvpend.CurrentRow.Cells(9).Value
        FrmNewAdmit.Txtinstr.Text = Dgvpend.CurrentRow.Cells(11).Value
        FrmNewAdmit.Txtclinic.Text = Dgvpend.CurrentRow.Cells(13).Value

        FrmNewAdmit.cboward.Text = ""
        FrmNewAdmit.cbobedno.Text = ""

        FrmNewAdmit.ShowDialog()
    End Sub
    Private Sub Dgvonadmision_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvonadmision.CellDoubleClick

        If Dgvonadmision.CurrentRow.Cells(13).Value = "Discharge Ordered" Then

            Dim res As MsgBoxResult
            res = MsgBox("THIS PATIENT DISCHARGED HAS BEEN ORDERED ! DO YOU WISH TO CONTINUE MANAGEMENT ?", MsgBoxStyle.YesNo, "Medx-pro")
            If (res = MsgBoxResult.Yes) Then

                FrmAdmitFolder.Lblhospnum.Text = Dgvonadmision.CurrentRow.Cells(3).Value
                FrmAdmitFolder.Lblsex.Text = Dgvonadmision.CurrentRow.Cells(6).Value
                FrmAdmitFolder.Lblage.Text = Dgvonadmision.CurrentRow.Cells(7).Value
                FrmAdmitFolder.Lbldiag.Text = Dgvonadmision.CurrentRow.Cells(8).Value
                FrmAdmitFolder.LbladmitID.Text = Dgvonadmision.CurrentRow.Cells(0).Value


                FrmAdmitFolder.LoadProfile()
                FrmAdmitFolder.Show()

            Else

                FrmDischarge.TxtHospnum.Text = Dgvonadmision.CurrentRow.Cells(3).Value
                FrmDischarge.TxtAdmitID.Text = Dgvonadmision.CurrentRow.Cells(0).Value
                FrmDischarge.TxtSurname.Text = Dgvonadmision.CurrentRow.Cells(4).Value
                FrmDischarge.TxtOthername.Text = Dgvonadmision.CurrentRow.Cells(5).Value
                FrmDischarge.TxtSex.Text = Dgvonadmision.CurrentRow.Cells(6).Value
                FrmDischarge.TxtAge.Text = Dgvonadmision.CurrentRow.Cells(7).Value
                FrmDischarge.TxtDiag.Text = Dgvonadmision.CurrentRow.Cells(8).Value
                FrmDischarge.Txtward.Text = Dgvonadmision.CurrentRow.Cells(9).Value
                FrmDischarge.TxtBedNo.Text = Dgvonadmision.CurrentRow.Cells(10).Value
                FrmDischarge.TxtConsultant.Text = Dgvonadmision.CurrentRow.Cells(11).Value
                FrmDischarge.LblAdmitdate.Text = Dgvonadmision.CurrentRow.Cells(1).Value

                FrmDischarge.ShowDialog()

            End If

        Else

            FrmAdmitFolder.Lblhospnum.Text = Dgvonadmision.CurrentRow.Cells(3).Value
            FrmAdmitFolder.Lblsex.Text = Dgvonadmision.CurrentRow.Cells(6).Value
            FrmAdmitFolder.Lblage.Text = Dgvonadmision.CurrentRow.Cells(7).Value
            FrmAdmitFolder.Lbldiag.Text = Dgvonadmision.CurrentRow.Cells(8).Value
            FrmAdmitFolder.LbladmitID.Text = Dgvonadmision.CurrentRow.Cells(0).Value

            FrmAdmitFolder.LoadProfile()
            FrmAdmitFolder.ShowDialog()


        End If

    End Sub
    Private Sub BtnRelPend_Click(sender As Object, e As EventArgs) Handles BtnRelPend.Click
        LoadAdmitreqst()
    End Sub
    Private Sub BtnReLoadAdmit_Click(sender As Object, e As EventArgs) Handles BtnReLoadAdmit.Click
        LoadPTonadmission()
    End Sub
    Private Sub BtnFindon_Click(sender As Object, e As EventArgs) Handles BtnFindon.Click
        cmd = New SqlCommand("Select Admit_Id, Date_Admitted, Time, Hospital_Num, Surname, Other_names, Sex, Age, Diagnosis, Ward, Bed_No, Consultant, Admitted_By, Admission_Status FROM Admitted WHERE Hospital_Num=@Hno", con)

        cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = TxtFindon.Text
        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dgvonadmision.DataSource = tbl

        Else

            MessageBox.Show("PATIENT NOT FOUND ON ADMISSION LIST", "Medx-pro", MessageBoxButtons.OK)
            TxtFindon.Focus()
        End If
    End Sub
    Private Sub BtnFindpend_Click(sender As Object, e As EventArgs) Handles BtnFindpend.Click

        cmd = New SqlCommand("Select * FROM AdmissionRequest WHERE Hospital_Num=@Hnum", con)
        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = Txtfindpend.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbla As New DataTable

        adapt.Fill(tbla)
        If tbla.Rows.Count() > 0 Then
            Dgvpend.DataSource = tbla

        Else

            MessageBox.Show("PATIENT NOT FOUND", "Medx-pro", MessageBoxButtons.OK)
            Txtfindpend.Focus()
        End If
    End Sub
    Private Sub TxtFindon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFindon.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Txtfindpend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtfindpend.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub ReloadDis_Click(sender As Object, e As EventArgs) Handles ReloadDis.Click
        LoadDischargedPT()
    End Sub
    Private Sub TxtfindDischrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtfindDischrg.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub BtnfindDischrg_Click(sender As Object, e As EventArgs) Handles BtnfindDischrg.Click
        cmd = New SqlCommand("Select * FROM DischargePT WHERE Hospital_Num=@DHnum", con)
        cmd.Parameters.Add("@DHnum", SqlDbType.VarChar).Value = TxtfindDischrg.Text

        adapt = New SqlDataAdapter(cmd)
        Dim Dtbl As New DataTable

        adapt.Fill(Dtbl)
        If Dtbl.Rows.Count() > 0 Then
            DgvDischrged.DataSource = Dtbl

        Else

            MessageBox.Show("PATIENT NOT FOUND", "Medx-pro", MessageBoxButtons.OK)
            TxtfindDischrg.Focus()
        End If
    End Sub
    Private Sub DgvDischrged_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDischrged.CellDoubleClick
        FrmAdmitFolder.Lblhospnum.Text = DgvDischrged.CurrentRow.Cells(4).Value
        FrmAdmitFolder.Lblsex.Text = DgvDischrged.CurrentRow.Cells(7).Value
        FrmAdmitFolder.Lblage.Text = DgvDischrged.CurrentRow.Cells(8).Value
        FrmAdmitFolder.Lbldiag.Text = DgvDischrged.CurrentRow.Cells(9).Value
        FrmAdmitFolder.LbladmitID.Text = DgvDischrged.CurrentRow.Cells(0).Value

        FrmAdmitFolder.NurseReport1.Btnclear.Visible = False
        FrmAdmitFolder.NurseReport1.Btnedit.Visible = False
        FrmAdmitFolder.NurseReport1.Btnsave.Visible = False
        FrmAdmitFolder.NurseReport1.Txtpass.Visible = False
        FrmAdmitFolder.NurseReport1.Label6.Visible = False

        FrmAdmitFolder.RoundNotes1.Btnsave.Visible = False
        FrmAdmitFolder.RoundNotes1.Btnclear.Visible = False
        FrmAdmitFolder.RoundNotes1.BtnSaveSum.Visible = False
        FrmAdmitFolder.RoundNotes1.Txtpass.Visible = False
        FrmAdmitFolder.RoundNotes1.TxtPassword.Visible = False
        FrmAdmitFolder.RoundNotes1.Label2.Visible = False

        FrmAdmitFolder.Nursinghx1.Btnsave.Visible = False
        FrmAdmitFolder.Nursinghx1.Txtpassw.Visible = False
        FrmAdmitFolder.Nursinghx1.Label33.Visible = False


        FrmAdmitFolder.CarePlan1.Btnsave.Visible = False
        FrmAdmitFolder.CarePlan1.Btnclear.Visible = False
        FrmAdmitFolder.CarePlan1.Btnedit.Visible = False
        FrmAdmitFolder.CarePlan1.Txtpass.Visible = False
        FrmAdmitFolder.CarePlan1.Label6.Visible = False

        FrmAdmitFolder.InpatientRadHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientDrugsHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientLabHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientConslt1.BtnNewcons.Visible = False


        FrmAdmitFolder.TreatmentChart1.BtnSave.Visible = False
        FrmAdmitFolder.TreatmentChart1.Txtnurse.Visible = False
        FrmAdmitFolder.TreatmentChart1.Label4.Visible = False
        FrmAdmitFolder.ObservChart1.BtnSave.Visible = False
        FrmAdmitFolder.ObservChart1.BtnCls.Visible = False
        FrmAdmitFolder.ObservChart1.Txtpass.Visible = False
        FrmAdmitFolder.ObservChart1.Label5.Visible = False

        FrmAdmitFolder.LoadProfile()
        FrmAdmitFolder.ShowDialog()
    End Sub

End Class