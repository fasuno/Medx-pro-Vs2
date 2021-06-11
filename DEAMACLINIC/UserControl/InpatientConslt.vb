Imports System.Data.SqlClient

Public Class InpatientConslt

    Public Sub LoadANCtogrid()

        Dim tb As New DataTable

        cmd = New SqlCommand("Select * from ANCVitals WHERE Hospital_Num=@hopnum", con)

        cmd.Parameters.Add("@hopnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        'Me.Dgvanc.DataSource = tb

    End Sub

    Public Sub LoadConsultationgrid()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select Date, Time, Complaint, Pres_Complain, Assessment, Examination, Past_MedHx, Immunization, Family_Hx, Social_Hx, Lab_Investigation, Rad_Investigation, Treatment, Summary, Clinic, Doctor, BP, Temp, Pulse, Weight, Height, Respiration from Consultations WHERE Hospital_Num=@hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.Dtggenconsult.DataSource = tbl

    End Sub

    Private Sub BtnNewcons_Click(sender As Object, e As EventArgs) Handles BtnNewcons.Click
        frmGenConsult.Clearall()

        frmGenConsult.lbldate.Text = Date.Now.Date
        frmGenConsult.lbltime.Text = TimeOfDay

        frmGenConsult.TxtExam.ReadOnly = False
        frmGenConsult.TxtComp.ReadOnly = False
        frmGenConsult.TxtPresComp.ReadOnly = False
        frmGenConsult.TxtPastmed.ReadOnly = False
        frmGenConsult.TxtDiag.ReadOnly = False
        frmGenConsult.TxtFamhx.ReadOnly = False
        frmGenConsult.TxtImmun.ReadOnly = False
        frmGenConsult.Txtlabinv.ReadOnly = True
        frmGenConsult.TxtRadinv.ReadOnly = True
        frmGenConsult.TxtSocial.ReadOnly = False
        frmGenConsult.txtSumm.ReadOnly = False
        frmGenConsult.TxtTreatmnt.ReadOnly = True
        frmGenConsult.BtnFolwUp.Enabled = False

        '//load Lab History

        frmGenConsult.LoadLabHxForWard()
        frmGenConsult.DtgLab.Columns(0).Visible = False
        frmGenConsult.DtgLab.Columns(2).Visible = False
        frmGenConsult.DtgLab.Columns(4).Visible = False

        '//Load Radilogy History

        frmGenConsult.LoadRADHxForward()

        frmGenConsult.DtgRad.Columns(0).Visible = False
        frmGenConsult.DtgRad.Columns(3).Visible = False

        '//Load Radilogy History
        frmGenConsult.LoadDrugsHxForWard()

        frmGenConsult.DtgDrugs.Columns(0).Visible = False
        frmGenConsult.DtgDrugs.Columns(2).Visible = False
        frmGenConsult.DtgDrugs.Columns(3).Visible = False
        frmGenConsult.DtgDrugs.Columns(5).Visible = False


        '////////

        frmGenConsult.ShowDialog()


    End Sub

    Private Sub BtnNewanc_Click(sender As Object, e As EventArgs)

        ShowPregBookingdetails()
        FrmANCfollowUp.Btnsendvitals.BringToFront()
        FrmANCfollowUp.Btnsendvitals.Enabled = True

        FrmANCfollowUp.txtga.Text = ""
        FrmANCfollowUp.txtprepos.Text = ""
        FrmANCfollowUp.txtlie.Text = ""
        FrmANCfollowUp.txtfh.Text = ""
        FrmANCfollowUp.txturine.Text = ""
        FrmANCfollowUp.txtbp.Text = ""
        FrmANCfollowUp.txtwght.Text = ""
        FrmANCfollowUp.txtheght.Text = ""
        FrmANCfollowUp.txtpassw.Text = ""
        FrmANCfollowUp.Txtremark.Text = ""

        FrmANCfollowUp.BtnScan.Enabled = True
        FrmANCfollowUp.BtnDrugs.Enabled = True
        FrmANCfollowUp.Btnadmit.Enabled = True
        FrmANCfollowUp.btnLAB.Enabled = True

        FrmANCfollowUp.ShowDialog()

        'FrmANCform.lblhospnum.Text = Dgvanc.CurrentRow.Cells(1).Value
        'FrmANCform.ShowDialog()
    End Sub

    Public Sub ShowPregBookingdetails()

        cmd = New SqlCommand("Select * from ANCBooking where Hospital_Num=@Hosp_Num and Booking_ID=@Bkid", con)
        '  cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = Dgvanc.CurrentRow.Cells(1).Value
        ' cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = Dgvanc.CurrentRow.Cells(0).Value
        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            FrmANCfollowUp.dtbook.Value = tbl.Rows(0)(2)
            FrmANCfollowUp.dtlmp.Value = tbl.Rows(0)(3)
            FrmANCfollowUp.dtedd.Value = tbl.Rows(0)(4)
            FrmANCfollowUp.txtgravs.Text = tbl.Rows(0)(5)
            FrmANCfollowUp.txtpar.Text = tbl.Rows(0)(6)
            FrmANCfollowUp.lblbkid.Text = tbl.Rows(0)(0)

        End If

    End Sub

    Public Sub ShowFolwupvitals()

        cmd = New SqlCommand("Select * from ANCVitals where Booking_ID=@Bkid AND Date=@Dte", con)

        '  cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = Dgvanc.CurrentRow.Cells(0).Value
        ' cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Dgvanc.CurrentRow.Cells(2).Value


        adapt = New SqlDataAdapter(cmd)
        Dim tbls As New DataTable

        adapt.Fill(tbls)
        If tbls.Rows.Count() > 0 Then

            'FrmANCfollowUp.dtfolwup.Value = tbls.Rows(0)(2)
            FrmANCfollowUp.txtga.Text = tbls.Rows(0)(4)
            FrmANCfollowUp.txtheght.Text = tbls.Rows(0)(5)
            FrmANCfollowUp.txtprepos.Text = tbls.Rows(0)(6)
            FrmANCfollowUp.txtlie.Text = tbls.Rows(0)(7)
            FrmANCfollowUp.txtfh.Text = tbls.Rows(0)(8)
            FrmANCfollowUp.txtbp.Text = tbls.Rows(0)(9)
            FrmANCfollowUp.txturine.Text = tbls.Rows(0)(10)
            FrmANCfollowUp.txtwght.Text = tbls.Rows(0)(11)
            FrmANCfollowUp.cboappnmnt.Text = tbls.Rows(0)(12)
            FrmANCfollowUp.Txtremark.Text = tbls.Rows(0)(14)


        End If

    End Sub

    Public Sub LoadFollowupsConslt()

        Dim tbal As New DataTable

        cmd = New SqlCommand("Select Date, Time, NOte, Doctor from FollowupNotes WHERE Hospital_No = @hospno AND Consultaion_Date=@ConDte", con)

        cmd.Parameters.Add("@hospno", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
        cmd.Parameters.Add("@ConDte", SqlDbType.Date).Value = Dtggenconsult.CurrentRow.Cells(0).Value
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbal)
        frmGenConsult.DtgFolwup.DataSource = tbal
    End Sub

    Private Sub Dtggenconsult_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dtggenconsult.CellMouseDoubleClick
        '    Dim frm = New frmGenConsult

        ' frmGenConsult.lbldate.Text = Dtggenconsult.CurrentRow.Cells(0).Value.ToString()
        ' frmGenConsult.lbltime.Text = Dtggenconsult.CurrentRow.Cells(1).Value.ToString()
        frmGenConsult.Cboclinic.Text = Dtggenconsult.CurrentRow.Cells(14).Value.ToString()
        frmGenConsult.TxtComp.Text = Dtggenconsult.CurrentRow.Cells(2).Value.ToString()
        frmGenConsult.TxtPresComp.Text = Dtggenconsult.CurrentRow.Cells(3).Value.ToString()
        frmGenConsult.TxtPastmed.Text = Dtggenconsult.CurrentRow.Cells(6).Value.ToString()
        frmGenConsult.TxtImmun.Text = Dtggenconsult.CurrentRow.Cells(7).Value.ToString()
        frmGenConsult.TxtFamhx.Text = Dtggenconsult.CurrentRow.Cells(8).Value.ToString()
        frmGenConsult.TxtSocial.Text = Dtggenconsult.CurrentRow.Cells(9).Value.ToString()
        frmGenConsult.TxtExam.Text = Dtggenconsult.CurrentRow.Cells(5).Value.ToString()
        frmGenConsult.TxtDiag.Text = Dtggenconsult.CurrentRow.Cells(4).Value.ToString()
        frmGenConsult.Txtlabinv.Text = Dtggenconsult.CurrentRow.Cells(10).Value.ToString()
        frmGenConsult.TxtRadinv.Text = Dtggenconsult.CurrentRow.Cells(11).Value.ToString()
        frmGenConsult.TxtTreatmnt.Text = Dtggenconsult.CurrentRow.Cells(12).Value.ToString()
        frmGenConsult.txtSumm.Text = Dtggenconsult.CurrentRow.Cells(13).Value.ToString()
        FrmPtRecords.Txtbp.Text = Dtggenconsult.CurrentRow.Cells(16).Value.ToString()
        FrmPtRecords.txtheight.Text = Dtggenconsult.CurrentRow.Cells(20).Value.ToString()
        FrmPtRecords.txtweight.Text = Dtggenconsult.CurrentRow.Cells(19).Value.ToString()
        FrmPtRecords.txtpulse.Text = Dtggenconsult.CurrentRow.Cells(18).Value.ToString()
        FrmPtRecords.txttemp.Text = Dtggenconsult.CurrentRow.Cells(17).Value.ToString() ''//this label shows temperature
        FrmPtRecords.txtresp.Text = Dtggenconsult.CurrentRow.Cells(21).Value.ToString()


        '//Disable all the buttons to avoid user making changes to the consultation
        frmGenConsult.Btnsave.Enabled = False
        frmGenConsult.btnLAB.Enabled = False
        frmGenConsult.BtnScan.Enabled = False
        frmGenConsult.BtnDrugs.Enabled = False
        frmGenConsult.Btnadmit.Enabled = False

        '// Make all the textboxes readonly

        frmGenConsult.TxtExam.ReadOnly = True
        frmGenConsult.TxtComp.ReadOnly = True
        frmGenConsult.TxtPresComp.ReadOnly = True
        frmGenConsult.TxtPastmed.ReadOnly = True
        frmGenConsult.TxtDiag.ReadOnly = True
        frmGenConsult.TxtFamhx.ReadOnly = True
        frmGenConsult.TxtImmun.ReadOnly = True
        frmGenConsult.Txtlabinv.ReadOnly = True
        frmGenConsult.TxtRadinv.ReadOnly = True
        frmGenConsult.TxtSocial.ReadOnly = True
        frmGenConsult.txtSumm.ReadOnly = True
        frmGenConsult.TxtTreatmnt.ReadOnly = True
        frmGenConsult.BtnFolwUp.Enabled = True

        '// Have to bring this to down bcos i have already make the label boxes to show current date and time on the formload event
        '// So by doing this, it will pick the date on the grid
        frmGenConsult.lbldate.Text = Dtggenconsult.CurrentRow.Cells(0).Value
        frmGenConsult.lbltime.Text = Dtggenconsult.CurrentRow.Cells(1).Value

        '//load Lab History

        frmGenConsult.LoadLabHxForWard()
        frmGenConsult.DtgLab.Columns(0).Visible = False
        frmGenConsult.DtgLab.Columns(2).Visible = False
        frmGenConsult.DtgLab.Columns(4).Visible = False

        '//Load Radilogy History

        frmGenConsult.LoadRADHxForward()

        frmGenConsult.DtgRad.Columns(0).Visible = False
        frmGenConsult.DtgRad.Columns(3).Visible = False

        '//Load Radilogy History
        frmGenConsult.LoadDrugsHxForWard()

        frmGenConsult.DtgDrugs.Columns(0).Visible = False
        frmGenConsult.DtgDrugs.Columns(2).Visible = False
        frmGenConsult.DtgDrugs.Columns(3).Visible = False
        frmGenConsult.DtgDrugs.Columns(5).Visible = False


        '////////
        LoadFollowupsConslt()
        frmGenConsult.ShowDialog()

    End Sub

    Private Sub Dgvanc_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        ShowFolwupvitals()
        ShowPregBookingdetails()
        FrmANCfollowUp.btnupdate.BringToFront()
        FrmANCfollowUp.BtnScan.Enabled = False
        FrmANCfollowUp.BtnDrugs.Enabled = False
        FrmANCfollowUp.Btnadmit.Enabled = False
        FrmANCfollowUp.btnLAB.Enabled = False
        FrmANCfollowUp.btnupdate.Enabled = False

        FrmANCfollowUp.ShowDialog()
    End Sub

End Class
