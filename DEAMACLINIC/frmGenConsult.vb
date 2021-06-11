
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmGenConsult
    Dim FlwupCollapse As Boolean = True


    Sub Clinics()

        Me.Cboclinic.Items.Add("GOPD")
        Me.Cboclinic.Items.Add("ORTHOPEDIC")
        Me.Cboclinic.Items.Add("PRIVATE WARD")
        Me.Cboclinic.Items.Add("GENERAL WARD")
    End Sub

    Private Sub frmGenConsult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = frmMain
        'lbldate.Text = Date.Now.Date
        'lbltime.Text = TimeOfDay
        Clinics()
        FlwupPanel.Size = FlwupPanel.MinimumSize
        Panel2.Size = Panel2.MinimumSize
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub checkuserAndSave()

        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", con)
        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "USER VALIDATION")
            txtPword.Focus()
        Else

            '// Else if password is right, Commit the entry to datatbase

            Dim res As MsgBoxResult
            res = MsgBox("SAVE CONSULTAION TO DATABASE?", MsgBoxStyle.YesNo, "Medx-pro")
            If (res = MsgBoxResult.Yes) Then


                Try


                    cmd = New SqlCommand("INSERT INTO Consultations VALUES(@Date, @Time, @SName, @Oname, @Hnum, @Age, @Sex, @Clinic, @Doc, @Comp,  @Pcomp,  @Assmt,  @Exam, @Pmhx,  @ImmHx,  @FamHx,  @SocHx,  @Lab,  @Rad,  @Treat,  @Summ,  @Bp,  @Temp,  @Pulse,  @Weight,  @Height,  @Resp)", con)

                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                    cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                    cmd.Parameters.Add("@SName", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                    cmd.Parameters.Add("@Oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                    cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                    cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                    cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = Cboclinic.Text.ToString
                    cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = lblusrrname.Text.ToString

                    cmd.Parameters.Add("@Comp", SqlDbType.NVarChar).Value = TxtComp.Text.ToString
                    cmd.Parameters.Add("@Pcomp", SqlDbType.NVarChar).Value = TxtPresComp.Text.ToString
                    cmd.Parameters.Add("@Assmt", SqlDbType.NVarChar).Value = TxtDiag.Text.ToString
                    cmd.Parameters.Add("@Exam", SqlDbType.NVarChar).Value = TxtExam.Text.ToString
                    cmd.Parameters.Add("@Pmhx", SqlDbType.NVarChar).Value = TxtPastmed.Text.ToString
                    cmd.Parameters.Add("@Immhx", SqlDbType.NVarChar).Value = TxtImmun.Text.ToString
                    cmd.Parameters.Add("@FamHx", SqlDbType.NVarChar).Value = TxtFamhx.Text.ToString
                    cmd.Parameters.Add("@SocHx", SqlDbType.NVarChar).Value = TxtSocial.Text.ToString

                    ' cmd.Parameters.Add(" @Assmt", SqlDbType.NVarChar).Value = Txtas.Text.ToString
                    cmd.Parameters.Add("@Lab", SqlDbType.NVarChar).Value = Txtlabinv.Text.ToString
                    cmd.Parameters.Add("@Rad", SqlDbType.NVarChar).Value = TxtRadinv.Text.ToString
                    cmd.Parameters.Add("@Treat", SqlDbType.NVarChar).Value = TxtTreatmnt.Text.ToString
                    cmd.Parameters.Add("@Summ", SqlDbType.NVarChar).Value = txtSumm.Text.ToString
                    cmd.Parameters.Add("@Bp", SqlDbType.NVarChar).Value = FrmPtRecords.Txtbp.Text.ToString
                    cmd.Parameters.Add("@Temp", SqlDbType.NVarChar).Value = FrmPtRecords.txttemp.Text.ToString
                    cmd.Parameters.Add("@Pulse", SqlDbType.NVarChar).Value = FrmPtRecords.txtpulse.Text.ToString
                    cmd.Parameters.Add("@Weight", SqlDbType.NVarChar).Value = FrmPtRecords.txtheight.Text.ToString
                    cmd.Parameters.Add("@Height", SqlDbType.NVarChar).Value = FrmPtRecords.txtweight.Text.ToString
                    cmd.Parameters.Add("@Resp", SqlDbType.NVarChar).Value = FrmPtRecords.txtresp.Text.ToString

                    cmd.Connection = con

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()

                    '  MsgBox("SAVE CONSULTATION", MsgBoxStyle.OkOnly, "CONSULTATION")


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try


                '//....................
                FrmPtRecords.Consultations1.LoadConsultationgrid()
                FrmPtRecords.PtDrugs11.LoadDrugsHx()
                FrmPtRecords.PtLabHist1.LoadLabReqstHx()
                FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()


                Me.Close()
            Else
                TxtDiag.Focus()
            End If
        End If

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Cboclinic.Text = "" Then

            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
        Else

            populateTreatedwaitinglist()

            checkuserAndSave()
            frmAllwaitingList.LoadAllPendLIst()
            frmAllwaitingList.LoadAllTreatedList()
            FrmMywaitinglist.LoadDocPendLIst()
            FrmMywaitinglist.LoadDocTreatedList()
            ' Reloadtreatedwaitinlist()
            con.Close()
        End If

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtPword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblusrrname.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub showusernameFlwup()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = TxtFlwupPassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            LblFlwupUser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub populateTreatedwaitinglist()


        Try
            cmd = New SqlCommand("UPDATE Pend_WaitingList Set Status=@sts WHERE Hospital_Num=@hno AND Date=@Cnsdt")

            cmd.Parameters.Add("@sts", SqlDbType.VarChar).Value = LblTreat.Text

            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            cmd.Parameters.Add("@Cnsdt", SqlDbType.Date).Value = FrmPtRecords.TxtApptdate.Text

            ' cmd = New SqlCommand("INSERT INTO Treated_Waitinglist VALUES(@Regdte, @tim, @Sname, @Oname, @Hnum, @Age, @Sex, @Act, @Actcat, @Clin, @Cons, @Did)", con)

            ' cmd.Parameters.Add("@Regdte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            '  cmd.Parameters.Add("@tim", SqlDbType.VarChar).Value = lbltime.Text
            ' cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
            'cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
            'cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            'cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
            'cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
            'cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = FrmPtRecords.lblacct.Text
            'cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
            ' cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = Cboclinic.Text
            'cmd.Parameters.Add("@Cons", SqlDbType.VarChar).Value = lblusrrname.Text
            'cmd.Parameters.Add("@Did", SqlDbType.Int).Value = FrmPtRecords.lbldocid.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
        'con.Close()

    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtPword.Leave
        '// I use this trick to save the actual name of the user performing this tack instead of targeting the password textbox
        '// I place a labelbox beside the password textbox which will be invible at runtime
        '// So once the user enter his/her passowrd and the cusor is taking away from the txtpassword, the user's FULL name will show on the label box
        '// So i am inserting the full name and not the password

        showusername()
    End Sub

    Private Sub btnLAB_Click(sender As Object, e As EventArgs) Handles btnLAB.Click
        ' Dim form As New FrmLabrequest
        FrmLabrequest.LoadLAbTest()
        FrmLabrequest.btnsendrequest.BringToFront()
        FrmLabrequest.ShowDialog()

        FrmLabrequest.txttestname.Focus()

    End Sub

    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click

        ' Dim form As New FrmDrugsPresc
        FrmDrugsPresc.LoadDrugs()
        FrmDrugsPresc.btnsendpresc.BringToFront()
        FrmDrugsPresc.ShowDialog()
        FrmDrugsPresc.txtdrugname.Focus()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click

        ' Dim form As New FrmRadrequest

        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.btnsendrequest.BringToFront()
        FrmRadrequest.ShowDialog()

        FrmRadrequest.txtInvType.Focus()
    End Sub

    Private Sub frmGenConsult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TxtComp.Text = ""
        TxtPresComp.Text = ""
        TxtExam.Text = ""
        txtPword.Text = ""
        TxtPastmed.Text = ""
        TxtImmun.Text = ""
        TxtFamhx.Text = ""
        TxtRadinv.Text = ""
        TxtSocial.Text = ""
        txtSumm.Text = ""
        TxtTreatmnt.Text = ""
        Txtlabinv.Text = ""
        TxtDiag.Text = ""


    End Sub

    Public Sub Clearall()
        TxtExam.Text = ""
        TxtFamhx.Text = ""
        TxtImmun.Text = ""
        Txtlabinv.Text = ""
        TxtPastmed.Text = ""
        TxtPresComp.Text = ""
        txtPword.Text = ""
        TxtRadinv.Text = ""
        TxtSocial.Text = ""
        txtSumm.Text = ""
        TxtTreatmnt.Text = ""
        TxtComp.Text = ""
        TxtDiag.Text = ""
        Btnsave.Enabled = True
        btnLAB.Enabled = True
        BtnDrugs.Enabled = True
        BtnScan.Enabled = True
        Btnadmit.Enabled = True
        lbldate.Text = ""
        lbltime.Text = ""
    End Sub

    Private Sub Btnadmit_Click(sender As Object, e As EventArgs) Handles Btnadmit.Click
        Dim frad As New FrmAdmitpt
        frad.btnsend.BringToFront()
        ' frad.LoadDiagnosis()
        frad.ShowDialog()
    End Sub

    Private Sub Timflwup_Tick(sender As Object, e As EventArgs) Handles Timflwup.Tick
        If FlwupCollapse Then

            FlwupPanel.Height += 10
            If FlwupPanel.Size = FlwupPanel.MaximumSize Then
                Panel2.Size = Panel2.MaximumSize
                Timflwup.Stop()
                FlwupCollapse = False

            End If
        Else

            FlwupPanel.Height -= 10
            If FlwupPanel.Size = FlwupPanel.MinimumSize Then
                Panel2.Size = Panel2.MinimumSize
                Timflwup.Stop()
                FlwupCollapse = True

            End If
            BtnSaveFlwup.Enabled = True
            TxtFlwupNote.Text = ""
        End If
    End Sub

    Private Sub BtnFolwUp_Click(sender As Object, e As EventArgs) Handles BtnFolwUp.Click
        'FlwupCollapse = False
        ' LoadFollowups()

        Timflwup.Start()
    End Sub

    Private Sub BtnFlwupLab_Click(sender As Object, e As EventArgs) Handles BtnFlwupLab.Click
        FrmLabrequest.LoadLAbTest()
        FrmLabrequest.BtnsaveFlwup.BringToFront()
        FrmLabrequest.ShowDialog()
        FrmLabrequest.txttestname.Focus()
    End Sub

    Private Sub BtnFlwupRad_Click(sender As Object, e As EventArgs) Handles BtnFlwupRad.Click
        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.BtnSAveFlwup.BringToFront()
        FrmRadrequest.ShowDialog()
        FrmRadrequest.txtInvType.Focus()
    End Sub

    Private Sub BtnFlwupDrug_Click(sender As Object, e As EventArgs) Handles BtnFlwupDrug.Click
        FrmDrugsPresc.LoadDrugs()
        FrmDrugsPresc.BtnSaveFlwUp.BringToFront()
        FrmDrugsPresc.ShowDialog()
        FrmDrugsPresc.txtdrugname.Focus()
    End Sub

    Private Sub BtnCear_Click(sender As Object, e As EventArgs) Handles BtnCear.Click
        TxtFlwupNote.Text = ""
        BtnSaveFlwup.Enabled = True
    End Sub

    Private Sub BtnSaveFlwup_Click(sender As Object, e As EventArgs) Handles BtnSaveFlwup.Click
        If TxtFlwupPassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
        Else

            If TxtFlwupNote.Text = "" Then
                MsgBox("NO FOLLOW-UP ENTRY MADE", MsgBoxStyle.Critical, "Medx-pro")
            Else

                Dim res As MsgBoxResult
                res = MsgBox("ARE YOU SURE YOU WANT TO SAVE?", MsgBoxStyle.YesNo)
                If (res = MsgBoxResult.Yes) Then

                    Try

                        cmd = New SqlCommand("INSERT INTO FollowupNotes VALUES(@Dats, @Tims, @Hnos, @Not, @Docs, @ConDt)", con)

                        cmd.Parameters.Add("@Dats", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        cmd.Parameters.Add("@Tims", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                        cmd.Parameters.Add("@Hnos", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@Not", SqlDbType.NVarChar).Value = TxtFlwupNote.Text
                        cmd.Parameters.Add("@Docs", SqlDbType.VarChar).Value = LblFlwupUser.Text
                        cmd.Parameters.Add("@ConDT", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date

                        cmd.Connection = con

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MsgBox("FOLLOW-UP NOTES SAVED SUCCESSFULLY", MsgBoxStyle.OkOnly, "Medx-pro")

                        TxtFlwupNote.Text = ""
                        TxtFlwupPassw.Text = ""
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try

                    LoadFollowups()
                    LoadLabHx()
                    LoadRADHx()
                    LoadDrugsHx()
                    FlwupPanel.Size = FlwupPanel.MinimumSize
                    Panel2.Size = Panel2.MinimumSize

                End If
            End If
        End If

    End Sub

    Private Sub TxtFlwupPassw_Leave(sender As Object, e As EventArgs) Handles TxtFlwupPassw.Leave
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", con)
        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TxtFlwupPassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtFlwupPassw.Focus()
        Else
            showusernameFlwup()
        End If
    End Sub

    Public Sub LoadFollowups()
        Dim tbal As New DataTable

        cmd = New SqlCommand("Select Date, Time, NOte, Doctor from FollowupNotes WHERE Hospital_No = @hospno AND Consultaion_Date=@ConDte", con)

        cmd.Parameters.Add("@hospno", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
        cmd.Parameters.Add("@ConDte", SqlDbType.Date).Value = FrmPtRecords.Consultations1.Dtggenconsult.CurrentRow.Cells(0).Value     'lbldate.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbal)
        DtgFolwup.DataSource = tbal
    End Sub

    Private Sub DtgFolwup_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgFolwup.CellMouseClick
        TxtFlwupNote.Text = DtgFolwup.CurrentRow.Cells(2).Value.ToString
        BtnSaveFlwup.Enabled = False
    End Sub

    Public Sub LoadLabHx()

        Dim tblab As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_Num, Date, Clinic, Diagnosis, Requested_By from LabRequest WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.NVarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tblab)

        DtgLab.DataSource = tblab

    End Sub

    Private Sub DtgLab_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgLab.CellMouseDoubleClick
        ' Dim frms = New FrmLabResultpreview

        FrmLabResultpreview.Txtdatrqst.Text = DtgLab.CurrentRow.Cells(1).Value
        FrmLabResultpreview.Lblrqstnum.Text = DtgLab.CurrentRow.Cells(0).Value
        FrmLabResultpreview.txtclinic.Text = DtgLab.CurrentRow.Cells(2).Value
        FrmLabResultpreview.Txtdiag.Text = DtgLab.CurrentRow.Cells(3).Value
        FrmLabResultpreview.TxtRqstBy.Text = DtgLab.CurrentRow.Cells(4).Value

        FrmLabResultpreview.LoadPtForConsult()

        FrmLabResultpreview.ShowDialog()
    End Sub

    Public Sub LoadRADHx()

        Dim tblrad As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested As Date, Requested_by, Date_Reported from VwRadRequestAndResult WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tblrad)
        DtgRad.DataSource = tblrad

    End Sub

    Private Sub DtgRad_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgRad.CellMouseDoubleClick
        FrmRadTreatResult.TxtRqstdate.Text = DtgRad.CurrentRow.Cells(1).Value
        FrmRadTreatResult.txtRqstby.Text = DtgRad.CurrentRow.Cells(2).Value.ToString
        FrmRadTreatResult.Lblrqstnum.Text = DtgRad.CurrentRow.Cells(0).Value

        FrmRadTreatResult.LoadPtRadInForConsult()
        FrmRadTreatResult.ShowDialog()
    End Sub

    Public Sub LoadDrugsHx()

        Dim tbldrg As New DataTable

        cmd = New SqlCommand("Select DISTINCT Presc_Num, Date, Time, Clinic, Diagnosis, Prescribed_By from AllDrugPresc WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbldrg)

        DtgDrugs.DataSource = tbldrg

    End Sub

    Private Sub DtgDrugs_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgDrugs.CellMouseDoubleClick
        FrmDrugPreview.Txtdate.Text = DtgDrugs.CurrentRow.Cells(1).Value
        FrmDrugPreview.txtprescby.Text = DtgDrugs.CurrentRow.Cells(5).Value
        FrmDrugPreview.txtid.Text = DtgDrugs.CurrentRow.Cells(0).Value
        FrmDrugPreview.txtdiagn.Text = DtgDrugs.CurrentRow.Cells(4).Value

        LoadDrugs()
        FrmDrugPreview.ShowDialog()
    End Sub

    Sub LoadDrugs()
        Dim tbld As New DataTable

        cmd = New SqlCommand("Select DISTINCT Drug_name, Prescription from AllDrugPresc WHERE Presc_Num = @pnum", con)

        cmd.Parameters.Add("@pnum", SqlDbType.VarChar).Value = Me.DtgDrugs.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbld)

        FrmDrugPreview.Dtgdrugprev.DataSource = tbld
        FrmDrugPreview.Dtgdrugprev.AutoResizeColumns()
    End Sub

    '// LOAD FOR WARD MANAGER

    Public Sub LoadLabHxForWard()

        Dim tblab As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_Num, Date, Clinic, Diagnosis, Requested_By from LabRequest WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tblab)

        DtgLab.DataSource = tblab

    End Sub

    Public Sub LoadDrugsHxForWard()

        Dim tbldrg As New DataTable

        cmd = New SqlCommand("Select DISTINCT Presc_Num, Date, Time, Clinic, Diagnosis, Prescribed_By from AllDrugPresc WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbldrg)

        DtgDrugs.DataSource = tbldrg

    End Sub

    Public Sub LoadRADHxForward()

        Dim tblrad As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested As Date, Requested_by, Date_Reported from VwRadRequestAndResult WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tblrad)
        DtgRad.DataSource = tblrad

    End Sub


End Class