Public Class FrmPtRecords
    Private Sub FrmPtRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultations1.LoadConsultationgrid()

        Profile1.LoadProfile()
        Consultations1.BringToFront()

    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        Profile1.LoadProfile()
        Profile1.BringToFront()
    End Sub

    Private Sub Btnconsult_Click(sender As Object, e As EventArgs) Handles Btnconsult.Click
        Consultations1.LoadConsultationgrid()
        Consultations1.BringToFront()
    End Sub

    Private Sub btnLab_Click(sender As Object, e As EventArgs) Handles btnLab.Click
        PtLabHist1.LoadLabReqstHx()
        PtLabHist1.BringToFront()
    End Sub

    Private Sub BtnRad_Click(sender As Object, e As EventArgs) Handles BtnRad.Click
        PtRadHist1.LoadRAdilogicalHx()
        PtRadHist1.BringToFront()
    End Sub

    Private Sub BtbnPharm_Click(sender As Object, e As EventArgs) Handles BtbnPharm.Click
        PtDrugs11.LoadDrugsHx()
        PtDrugs11.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnAdm_Click(sender As Object, e As EventArgs) Handles BtnAdm.Click
        AdmissionHX1.LoadAdmitHx()
        AdmissionHX1.BringToFront()

    End Sub

    Private Sub Btnrefer_Click(sender As Object, e As EventArgs) Handles Btnrefer.Click
        FrmRefer.ShowDialog()

    End Sub

    Private Sub BtnBill_Click(sender As Object, e As EventArgs) Handles BtnBill.Click
        FrmBiller.txtSname.Text = Lblsurname.Text
        FrmBiller.TxtOname.Text = Lblothernmaes.Text
        FrmBiller.Txthnum.Text = Lblhopnum.Text
        FrmBiller.txtaccnt.Text = lblacct.Text
        FrmBiller.TxtAcctCat.Text = Profile1.txtprov.Text

        FrmBiller.ShowDialog()
    End Sub
End Class