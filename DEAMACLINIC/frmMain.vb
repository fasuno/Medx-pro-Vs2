Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frmMain

    Dim MedRecCollapse As Boolean = True
    Dim NurseCollapse As Boolean = True
    Dim ConsCollapse As Boolean = True
    Dim MedLabCollapse As Boolean = True
    Dim PharmCollapse As Boolean = True
    Dim RadCollapse As Boolean = True
    Dim FinCollapse As Boolean = True
    Dim TherCollapse As Boolean = True
    Dim WardCollapse As Boolean = True
    Dim AdminCollapse As Boolean = True
    Dim ToolsCollapse As Boolean = True

    Public Sub RoleAcess()

        If lblroleid.Text = "11" Then

            BtnTools.Enabled = False
            BtnAdmin.Enabled = False
            BtnTools.Enabled = False
            BtnCashPnt.Enabled = False
            BtnRadReqst.Enabled = False
            BtnScanList.Enabled = False
            BtnDrugStore.Enabled = False
            BtnNewDrug.Enabled = False
            BtnAncbook.Enabled = False
            BtnRegisters.Enabled = False
            BtnFolder.Enabled = False
            BtnAppointment.Enabled = False
            FrmPharmacy.tabpharm.Enabled = False
            frmLABORATORY.tabLaboratory.Enabled = False
            Frmrecords.Btnnew.Enabled = False
            'Frmrecords.BtnNewAnc.Enabled = False
            BtnTestlist.Enabled = False

        ElseIf lblroleid.Text = "13" Then

            BtnTools.Enabled = False
            BtnAdmin.Enabled = False
            BtnTools.Enabled = False
            FrmPtRecords.Consultations1.BtnNewcons.Enabled = False

        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        frmlogin.MdiParent = Me
        frmlogin.Show()
        'lblmail.Visible = False
        RoleAcess()
        Timer1.Start()
        lbldate.Text = Now.Date


        '//RESIZE DROP PANELS TO MINIMUM SIZE

        RecPanel.Size = RecPanel.MinimumSize
        NursePanel.Size = NursePanel.MinimumSize
        ConsPanel.Size = ConsPanel.MinimumSize
        LabPanel.Size = LabPanel.MinimumSize
        PharmPanel.Size = PharmPanel.MinimumSize
        RadPanel.Size = RadPanel.MinimumSize
        WardPanel.Size = WardPanel.MinimumSize
        AcctPanel.Size = AcctPanel.MinimumSize
        'TherapyPanel.Size = TherapyPanel.MinimumSize
        AdminPanel.Size = AdminPanel.MinimumSize
        ToolsPanel.Size = ToolsPanel.MinimumSize


    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Username=@user", con)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = frmlogin.txtusername.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then
            Lbluserid.Text = tbl.Rows(0)(0).ToString()
            lblname.Text = tbl.Rows(0)(1).ToString()
            lblrole.Text = tbl.Rows(0)(5).ToString()
            lblroleid.Text = tbl.Rows(0)(4).ToString()

        Else
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub TimNurse_Tick(sender As Object, e As EventArgs) Handles TimNurse.Tick
        If NurseCollapse Then

            NursePanel.Height += 10
            If NursePanel.Size = NursePanel.MaximumSize Then
                TimNurse.Stop()
                NurseCollapse = False
            End If
        Else

            NursePanel.Height -= 10
            If NursePanel.Size = NursePanel.MinimumSize Then
                TimNurse.Stop()
                NurseCollapse = True
            End If

        End If
    End Sub

    Private Sub TImRec_Tick(sender As Object, e As EventArgs) Handles TImRec.Tick
        If MedRecCollapse Then

            RecPanel.Height += 10
            If RecPanel.Size = RecPanel.MaximumSize Then
                TImRec.Stop()
                MedRecCollapse = False
            End If
        Else

            RecPanel.Height -= 10
            If RecPanel.Size = RecPanel.MinimumSize Then
                TImRec.Stop()
                MedRecCollapse = True
            End If

        End If
    End Sub

    Private Sub TimConsl_Tick(sender As Object, e As EventArgs) Handles TimConsl.Tick
        If ConsCollapse Then

            ConsPanel.Height += 10
            If ConsPanel.Size = ConsPanel.MaximumSize Then
                TimConsl.Stop()
                ConsCollapse = False
            End If

        Else

            ConsPanel.Height -= 10
            If ConsPanel.Size = ConsPanel.MinimumSize Then
                TimConsl.Stop()
                ConsCollapse = True
            End If

        End If
    End Sub

    Private Sub TimLab_Tick(sender As Object, e As EventArgs) Handles TimLab.Tick
        If MedLabCollapse Then

            LabPanel.Height += 10
            If LabPanel.Size = LabPanel.MaximumSize Then
                TimLab.Stop()
                MedLabCollapse = False
            End If
        Else

            LabPanel.Height -= 10
            If LabPanel.Size = LabPanel.MinimumSize Then
                TimLab.Stop()
                MedLabCollapse = True
            End If

        End If
    End Sub

    Private Sub TimPharm_Tick(sender As Object, e As EventArgs) Handles TimPharm.Tick
        If PharmCollapse Then

            PharmPanel.Height += 10
            If PharmPanel.Size = PharmPanel.MaximumSize Then
                TimPharm.Stop()
                PharmCollapse = False
            End If
        Else

            PharmPanel.Height -= 10
            If PharmPanel.Size = PharmPanel.MinimumSize Then
                TimPharm.Stop()
                PharmCollapse = True
            End If

        End If
    End Sub

    Private Sub TimRad_Tick(sender As Object, e As EventArgs) Handles TimRad.Tick
        If RadCollapse Then

            RadPanel.Height += 10
            If RadPanel.Size = RadPanel.MaximumSize Then
                TimRad.Stop()
                RadCollapse = False
            End If
        Else

            RadPanel.Height -= 10
            If RadPanel.Size = RadPanel.MinimumSize Then
                TimRad.Stop()
                RadCollapse = True
            End If

        End If
    End Sub

    Private Sub TimFin_Tick(sender As Object, e As EventArgs) Handles TimFin.Tick
        If FinCollapse Then

            AcctPanel.Height += 10
            If AcctPanel.Size = AcctPanel.MaximumSize Then
                TimFin.Stop()
                FinCollapse = False
            End If
        Else

            AcctPanel.Height -= 10
            If AcctPanel.Size = AcctPanel.MinimumSize Then
                TimFin.Stop()
                FinCollapse = True
            End If

        End If
    End Sub

    Private Sub TimWard_Tick(sender As Object, e As EventArgs) Handles TimWard.Tick
        If WardCollapse Then

            WardPanel.Height += 10
            If WardPanel.Size = WardPanel.MaximumSize Then
                TimWard.Stop()
                WardCollapse = False
            End If
        Else

            WardPanel.Height -= 10
            If WardPanel.Size = WardPanel.MinimumSize Then
                TimWard.Stop()
                WardCollapse = True
            End If

        End If
    End Sub

    'Private Sub TimThera_Tick(sender As Object, e As EventArgs) Handles TimThera.Tick
    'If TherCollapse Then

    'TherapyPanel.Height += 10
    'If TherapyPanel.Size = TherapyPanel.MaximumSize Then
    '           TimThera.Stop()
    '          TherCollapse = False
    'End If

    'Else

    '       TherapyPanel.Height -= 10
    'If TherapyPanel.Size = TherapyPanel.MinimumSize Then
    '           TimThera.Stop()
    '          TherCollapse = True
    'End If

    'End If
    'End Sub

    Private Sub TimAdmin_Tick(sender As Object, e As EventArgs) Handles TimAdmin.Tick
        If AdminCollapse Then

            AdminPanel.Height += 10
            If AdminPanel.Size = AdminPanel.MaximumSize Then
                TimAdmin.Stop()
                AdminCollapse = False
            End If

        Else

            AdminPanel.Height -= 10
            If AdminPanel.Size = AdminPanel.MinimumSize Then
                TimAdmin.Stop()
                AdminCollapse = True
            End If

        End If
    End Sub

    Private Sub TimTools_Tick(sender As Object, e As EventArgs) Handles TimTools.Tick
        If ToolsCollapse Then

            ToolsPanel.Height += 10
            If ToolsPanel.Size = ToolsPanel.MaximumSize Then
                TimTools.Stop()
                ToolsCollapse = False
            End If

        Else

            ToolsPanel.Height -= 10
            If ToolsPanel.Size = ToolsPanel.MinimumSize Then
                TimTools.Stop()
                ToolsCollapse = True
            End If

        End If
    End Sub

    Private Sub Btnconsult_Click(sender As Object, e As EventArgs) Handles Btnconsult.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()

    End Sub

    Private Sub BtnMedRec_Click(sender As Object, e As EventArgs) Handles BtnMedRec.Click
        'MedRecCollapse = False
        PharmCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
    End Sub

    Private Sub BtnNurse_Click(sender As Object, e As EventArgs) Handles BtnNurse.Click
        MedRecCollapse = False
        ' NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()

    End Sub

    Private Sub BtnLab_Click(sender As Object, e As EventArgs) Handles BtnLab.Click
        MedRecCollapse = False
        NurseCollapse = False
        'MedLabCollapse = False
        PharmCollapse = False
        ConsCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
    End Sub

    Private Sub BtnPharm_Click(sender As Object, e As EventArgs) Handles BtnPharm.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
    End Sub

    Private Sub BtnRadiology_Click(sender As Object, e As EventArgs) Handles BtnRadiology.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        FinCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
    End Sub

    Private Sub BtnAcct_Click(sender As Object, e As EventArgs) Handles BtnAcct.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        WardCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimWard.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
        TimWard.Start()
    End Sub

    Private Sub BTnWardMang_Click(sender As Object, e As EventArgs) Handles BTnWardMang.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        TherCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
        TimWard.Start()
    End Sub

    Private Sub BtnTherapy_Click(sender As Object, e As EventArgs)
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        AdminCollapse = False
        ToolsCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
        TimWard.Start()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        TherCollapse = False
        WardCollapse = False
        ToolsCollapse = False

        TimAdmin.Start()
        TimTools.Start()
        TimWard.Start()
        TimThera.Start()
        TimFin.Start()
        TimRad.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
    End Sub

    Private Sub BtnTools_Click(sender As Object, e As EventArgs) Handles BtnTools.Click
        MedRecCollapse = False
        NurseCollapse = False
        MedLabCollapse = False
        ConsCollapse = False
        PharmCollapse = False
        RadCollapse = False
        FinCollapse = False
        WardCollapse = False
        AdminCollapse = False
        TherCollapse = False

        TimTools.Start()
        TimAdmin.Start()
        TimThera.Start()
        TimFin.Start()
        TimPharm.Start()
        TimLab.Start()
        TimConsl.Start()
        TimNurse.Start()
        TImRec.Start()
        TimRad.Start()
        TimWard.Start()
    End Sub

    Private Sub BtnRegisters_Click(sender As Object, e As EventArgs) Handles BtnRegisters.Click
        Frmrecords.MdiParent = Me
        Frmrecords.Show()
    End Sub

    Private Sub BtnAncbook_Click(sender As Object, e As EventArgs) Handles BtnAncbook.Click
        Dim frm = New FrmANCreg
        FrmANCreg.Btnsave.BringToFront()
        frm.ShowDialog()
    End Sub

    Private Sub BtnAppointment_Click(sender As Object, e As EventArgs) Handles BtnAppointment.Click
        Dim frmapt = New FrmAppointment

        frmapt.BtnReschedule.Enabled = False
        frmapt.ShowDialog()

    End Sub

    Private Sub BtnFolder_Click(sender As Object, e As EventArgs) Handles BtnFolder.Click
        Dim frm = New FrmPtreg
        frm.Btnupload.Visible = False
        frm.Populateacct()
        frm.Btnupdate.SendToBack()
        frm.ShowDialog()

    End Sub

    Private Sub BtnVsign_Click(sender As Object, e As EventArgs) Handles BtnVsign.Click
        frmNursing.Show()
        frmNursing.MdiParent = Me
    End Sub

    Private Sub BtnAdmissn_Click(sender As Object, e As EventArgs) Handles BtnAdmissn.Click
        FrmWardManager.MdiParent = Me
        FrmWardManager.Show()
    End Sub

    Private Sub BtnMyWList_Click(sender As Object, e As EventArgs) Handles BtnMyWList.Click
        FrmMywaitinglist.LoadDocPendLIst()

        FrmMywaitinglist.LoadDocTreatedList()
        FrmMywaitinglist.Dtgmypendlist.Columns(19).Visible = False
        FrmMywaitinglist.DtgMyconsultation.Columns(11).Visible = False
        FrmMywaitinglist.Show()
        FrmMywaitinglist.MdiParent = Me
    End Sub

    Private Sub BtnAllWList_Click(sender As Object, e As EventArgs) Handles BtnAllWList.Click
        frmAllwaitingList.LoadAllPendLIst()
        frmAllwaitingList.LoadAllTreatedList()
        frmAllwaitingList.DtgAllPendWaitlist.Columns(19).Visible = False
        frmAllwaitingList.DtgTreatWaitlist.Columns(11).Visible = False
        frmAllwaitingList.Show()
        frmAllwaitingList.MdiParent = Me
    End Sub

    Private Sub BtnReqst_Click(sender As Object, e As EventArgs) Handles BtnReqst.Click
        frmLABORATORY.Show()
        frmLABORATORY.MdiParent = Me
    End Sub

    Private Sub BtnTestlist_Click(sender As Object, e As EventArgs) Handles BtnTestlist.Click
        frmLabTestList.Show()
        frmLabTestList.MdiParent = Me
    End Sub

    Private Sub BtnDrugRqst_Click(sender As Object, e As EventArgs) Handles BtnDrugRqst.Click
        FrmPharmacy.Show()
        FrmPharmacy.MdiParent = Me
    End Sub

    Private Sub BtnNewDrug_Click(sender As Object, e As EventArgs) Handles BtnNewDrug.Click
        FrmNewdrugs.Show()
        FrmNewdrugs.MdiParent = Me
    End Sub

    Private Sub BtnDrugStore_Click(sender As Object, e As EventArgs) Handles BtnDrugStore.Click
        frmAllDrugs.Show()
        frmAllDrugs.MdiParent = Me
    End Sub

    Private Sub BtnRadReqst_Click(sender As Object, e As EventArgs) Handles BtnRadReqst.Click
        FrmRadiology.Show()
        FrmRadiology.MdiParent = Me
    End Sub

    Private Sub BtnScanList_Click(sender As Object, e As EventArgs) Handles BtnScanList.Click
        FrmScanlist.MdiParent = Me
        FrmScanlist.Show()
    End Sub

    Private Sub BtnCashPnt_Click(sender As Object, e As EventArgs) Handles BtnCashPnt.Click
        frmCashier.StartTime.Value = New DateTime(Now.Year, Now.Month, Now.Day).AddHours(7)
        frmCashier.EndTime.Value = New DateTime(Now.Year, Now.Month, Now.Day).AddHours(23).AddMinutes(59)
        ' Dtfrm.Value = New Date(Now.Year, Now.Month, 1)
        frmCashier.Dtfrm.Value = New DateTime(Now.Year, Now.Month, 1).AddHours(7)

        frmCashier.Show()
        frmCashier.MdiParent = Me


    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Dim frm = New frmusers
        ' frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        con.Close()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        lblroleid.Text = ""
        lblname.Text = ""
        ToolxPanel.Visible = False
        Panel1.Visible = False

        frmlogin.txtusername.Focus()
        frmlogin.WindowState = FormWindowState.Normal
        frmlogin.txtusername.Focus()
        frmlogin.ShowDialog()

        ' frmlogin.MdiParent = Me
        '/// Return Menu Panel To Normal

        RecPanel.Size = RecPanel.MinimumSize
        NursePanel.Size = NursePanel.MinimumSize
        ConsPanel.Size = ConsPanel.MinimumSize
        LabPanel.Size = LabPanel.MinimumSize
        PharmPanel.Size = PharmPanel.MinimumSize
        RadPanel.Size = RadPanel.MinimumSize
        WardPanel.Size = WardPanel.MinimumSize
        AcctPanel.Size = AcctPanel.MinimumSize
        'TherapyPanel.Size = TherapyPanel.MinimumSize
        AdminPanel.Size = AdminPanel.MinimumSize
        ToolsPanel.Size = ToolsPanel.MinimumSize

    End Sub

    Private Sub BtnLogoff_Click(sender As Object, e As EventArgs) Handles BtnLogoff.Click
        Me.Close()
    End Sub
    Private Sub BtnTheatre_Click(sender As Object, e As EventArgs) Handles BtnTheatre.Click
        'FrmTheartre.LoadSurgery()
        FrmTheartre.Show()
        FrmTheartre.MdiParent = Me

    End Sub
End Class
