Imports System.Data.SqlClient

Public Class Frmrecords

    Private Sub BtnNewAppt_Click(sender As Object, e As EventArgs) Handles BtnNewAppt.Click
        Dim frmapt = New FrmAppointment
        frmapt.ShowDialog()
        frmapt.BtnReschedule.Enabled = False

    End Sub

    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        Dim frm = New FrmPtreg
        frm.Btnupload.Visible = False
        frm.Populateacct()

        frm.ShowDialog()
        frm.Btnupdate.SendToBack()

    End Sub

    Private Sub Tabrec_TabIndexChanged(sender As Object, e As EventArgs) Handles Tabrec.TabIndexChanged

        ' //Load data to grids when each tabpage is clicked

        ' //load data to patient profile grid
        sortPatientfolder()
        'FrmPtreg.agecalc()
        Label9.Text = Dtgfolder.RowCount

        '// Load the current appointment using the bellow method

        sortApptfolder()



    End Sub

    Private Sub Dtgfolder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgfolder.CellDoubleClick

        Dim cmd As New SqlCommand("Select * from Pt_profile where Hospital_Num = @id_no", con)

        cmd.Parameters.Add("@id_no", SqlDbType.VarChar).Value = Dtgfolder.CurrentRow.Cells(0).Value

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            ' Dim frm = New FrmPtreg

            FrmPtreg.txthospnum.Text = tbl.Rows(0)(0).ToString()
            FrmPtreg.txtsurname.Text = tbl.Rows(0)(1).ToString()
            FrmPtreg.txtothernames.Text = tbl.Rows(0)(2).ToString()
            FrmPtreg.dbo.Text = tbl.Rows(0)(3).ToString()
            FrmPtreg.cboacct.Text = tbl.Rows(0)(4).ToString()
            FrmPtreg.Txtprovi.Text = tbl.Rows(0)(5).ToString()
            FrmPtreg.regdate.Value = tbl.Rows(0)(6)
            'FrmPtreg.txtmonths.Text = Dtgfolder.CurrentRow.Cells(6).Value.ToString()

            FrmPtreg.cbosex.Text = tbl.Rows(0)(7).ToString()
            FrmPtreg.cbomarital.Text = tbl.Rows(0)(8).ToString()
            FrmPtreg.cborelig.Text = tbl.Rows(0)(9).ToString()
            FrmPtreg.cbooccup.Text = tbl.Rows(0)(10).ToString()
            FrmPtreg.CboLga.Text = tbl.Rows(0)(11).ToString()
            FrmPtreg.cbostate.Text = tbl.Rows(0)(12).ToString()
            FrmPtreg.cbonat.Text = tbl.Rows(0)(13).ToString()
            FrmPtreg.Txttribe.Text = tbl.Rows(0)(14).ToString()

            FrmPtreg.txtadd.Text = tbl.Rows(0)(15).ToString()
            FrmPtreg.CboDistrct.Text = tbl.Rows(0)(16).ToString()

            FrmPtreg.txtphone.Text = tbl.Rows(0)(17).ToString()
            FrmPtreg.txtemail.Text = tbl.Rows(0)(18).ToString()
            FrmPtreg.Expdate.Value = tbl.Rows(0)(19).ToString()

            FrmPtreg.cboenrol.Text = tbl.Rows(0)(20).ToString()
            FrmPtreg.txtemployer.Text = tbl.Rows(0)(21).ToString()
            FrmPtreg.txtenrolnum.Text = tbl.Rows(0)(22).ToString()

            FrmPtreg.txtkinname.Text = tbl.Rows(0)(23).ToString()
            FrmPtreg.txtkinadd.Text = tbl.Rows(0)(24).ToString()
            FrmPtreg.txtkinphone.Text = tbl.Rows(0)(26).ToString()
            FrmPtreg.cborelat.Text = tbl.Rows(0)(25).ToString()


            FrmPtreg.txtnin.Text = tbl.Rows(0)(27).ToString()
            FrmPtreg.txtstate.Text = tbl.Rows(0)(28).ToString()
            FrmPtreg.txtcaution.Text = tbl.Rows(0)(30).ToString()

        End If

        FrmPtreg.Show()

        FrmPtreg.MinimizeBox = False
        FrmPtreg.regdate.Enabled = False
        FrmPtreg.btnsave.SendToBack()
        'FrmPtreg.txthospnum.Enabled = False
    End Sub

    Public Sub sortPatientfolder()

        '// This code will show all patients
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from VwPtProfile WHERE Date_Registered BETWEEN @datfrom AND @datto", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = dtfrom.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = dtto.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        Dtgfolder.DataSource = tbl
        Dtgfolder.AutoResizeColumns()
        Label9.Text = Dtgfolder.RowCount

    End Sub

    Public Sub sortApptfolder()

        '// This code will sort the Appointment by date seletected
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from Appntmnt WHERE Appointment_date BETWEEN @dfrom AND @dtto", con)
        cmd.Parameters.Add("@dfrom", SqlDbType.Date).Value = from.Value
        cmd.Parameters.Add("@dtto", SqlDbType.Date).Value = dto.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        DtgApt.DataSource = tbl

        Label1.Text = DtgApt.RowCount

    End Sub

    Private Sub Btnref_Click(sender As Object, e As EventArgs) Handles Btnref.Click
        sortApptfolder()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        '//retrive data base on the selected date
        sortPatientfolder()
        Label9.Text = Dtgfolder.RowCount
    End Sub

    Private Sub DtgApt_DoubleClick(sender As Object, e As EventArgs) Handles DtgApt.DoubleClick
        'Dim frm As New FrmAppointment

        FrmAppointment.Apptdate.Text = DtgApt.CurrentRow.Cells(0).Value.ToString()
        FrmAppointment.Apptime.Text = DtgApt.CurrentRow.Cells(1).Value.ToString()
        FrmAppointment.txtsurname.Text = DtgApt.CurrentRow.Cells(2).Value.ToString
        FrmAppointment.txtothernames.Text = DtgApt.CurrentRow.Cells(3).Value.ToString
        FrmAppointment.txtsearch.Text = DtgApt.CurrentRow.Cells(4).Value.ToString
        FrmAppointment.txtage.Text = DtgApt.CurrentRow.Cells(5).Value.ToString
        FrmAppointment.txtsex.Text = DtgApt.CurrentRow.Cells(6).Value.ToString
        FrmAppointment.txtaccount.Text = DtgApt.CurrentRow.Cells(7).Value.ToString
        FrmAppointment.cboClinic.Text = DtgApt.CurrentRow.Cells(8).Value.ToString
        FrmAppointment.Txtcat.Text = DtgApt.CurrentRow.Cells(9).Value.ToString


        FrmAppointment.Show()
        FrmAppointment.cboClinic.Enabled = True
        FrmAppointment.txtsearch.Enabled = False
        FrmAppointment.btnSend.Enabled = False
        FrmAppointment.Apptdate.Enabled = False


    End Sub

    Public Sub SearchbySurname()

        cmd = New SqlCommand("Select * from VwPtProfile where Surname like @Name", con)
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtfind.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgfolder.DataSource = tbl

        Else
            MessageBox.Show("NAME DOES NOT EXIST", "Medx-pro", MessageBoxButtons.OK)
            txtfind.Focus()

        End If

    End Sub

    Public Sub searchbyHospitalnum()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtfind.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgfolder.DataSource = tbl

        Else

            MessageBox.Show("THE FOLDER NUMBER DOES NOT EXIST", "Medx-pro", MessageBoxButtons.OK)
            txtfind.Focus()
        End If
    End Sub

    Public Sub searchbyPhone()

        cmd = New SqlCommand("Select * from VwPtProfile where Phone=@phn OR Next_of_Kin_Phone=@Kpho", con)
        cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = txtfind.Text
        cmd.Parameters.Add("@Kpho", SqlDbType.VarChar).Value = txtfind.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgfolder.DataSource = tbl

        Else

            MessageBox.Show("PHONE NUMBER DOES NOT MATCH ANY RECORD", "Medx-pro", MessageBoxButtons.OK)
            txtfind.Focus()
        End If
    End Sub

    Private Sub btnfindfolder_Click(sender As Object, e As EventArgs) Handles btnfindfolder.Click
        If CboSearch.Text = "Hospital No" Then
            searchbyHospitalnum()
            Label9.Text = Dtgfolder.RowCount

        ElseIf CboSearch.Text = "Surname" Then
            SearchbySurname()
            Label9.Text = Dtgfolder.RowCount
        ElseIf CboSearch.Text = "Phone No" Then
            searchbyPhone()
            Label9.Text = Dtgfolder.RowCount
        Else
            txtfind.Focus()
        End If



    End Sub

    Private Sub btnsearchAppt_Click(sender As Object, e As EventArgs) Handles btnsearchAppt.Click

        cmd = New SqlCommand("Select * from Appntmnt where Hospital_Num=@Hospital_Num", con)
        cmd.Parameters.Add("Hospital_Num", SqlDbType.VarChar).Value = Txtsearchappt.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbls As New DataTable

        adapt.Fill(tbls)
        If tbls.Rows.Count() > 0 Then
            DtgApt.DataSource = tbls

        Else
            MessageBox.Show("THE FOLDER NUMBER DOES NOT EXIST", "Appointment", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub viewallappt_CheckedChanged_1(sender As Object, e As EventArgs) Handles viewallappt.CheckedChanged

        If viewallappt.Checked = True Then

            Txtsearchappt.Enabled = False

            Dim tbl As New DataTable

            cmd = New SqlCommand("Select * from Appntmnt", con)
            adapt = New SqlDataAdapter(cmd)


            adapt.Fill(tbl)
            DtgApt.DataSource = tbl
            Label1.Text = DtgApt.RowCount

        Else

            Txtsearchappt.Enabled = True
            Txtsearchappt.Text = ""
            ' sortApptfolder()

            con.Close()

        End If

    End Sub

    ' Private Sub viewallfolder_CheckStateChanged(sender As Object, e As EventArgs)
    '
    'If viewallfolder.Checked = True Then
    '
    '       txtfind.Enabled = False

    'Dim ntbl As New DataTable
    'Dim tbl As New DataTable
    '
    '       cmd = New SqlCommand("Select * from VwPtProfile", con)
    '      adapt = New SqlDataAdapter(cmd)

    '     con.Open()

    '    adapt.Fill(tbl)
    '   Dtgfolder.DataSource = tbl

    '  Dtgfolder.AutoResizeColumns()
    ' ShowAges()
    'Else
    '       txtfind.Enabled = True
    '      Dtgfolder.DataSource = Nothing

    ' sortPatientfolder()
    '     con.Close()
    'End If

    '   con.Close()
    'End Sub

    Private Sub CBOaptclinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOaptclinic.SelectedIndexChanged

        cmd = New SqlCommand("Select * from Appntmnt WHERE Clinic=@clinic and Appointment_date BETWEEN @dfrom AND @dtto", con)
        cmd.Parameters.Add("clinic", SqlDbType.VarChar).Value = CBOaptclinic.SelectedItem

        cmd.Parameters.Add("@dfrom", SqlDbType.Date).Value = from.Value
        cmd.Parameters.Add("@dtto", SqlDbType.Date).Value = dto.Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgApt.DataSource = tbl


            Label1.Text = DtgApt.RowCount

        Else
            MessageBox.Show("No Appointment for This Clinic On the selected date", "Appointment", MessageBoxButtons.OK)


            sortApptfolder()

        End If
    End Sub

    Public Sub ShowAges()
        '// This Will show the AGe in Years and Age in Months and DAys
        '// This method Target the Folder Datagrid.
        Dim s As Integer

        For s = 0 To Dtgfolder.Rows.Count() - 1


            Dim birthday As DateTime = Dtgfolder.Rows(s).Cells(4).Value

            Dim intYears As Integer = DateDiff(DateInterval.Year, birthday, Today())
            If DateAdd(DateInterval.Year, intYears, birthday) > Today() Then intYears -= 1

            birthday = DateAdd(DateInterval.Year, intYears, birthday)

            Dim intMonths As Integer = DateDiff(DateInterval.Month, birthday, Today)
            If DateAdd(DateInterval.Month, intMonths, birthday) > Today Then intMonths -= 1

            birthday = DateAdd(DateInterval.Month, intMonths, birthday)

            Dim intDays As Integer = DateDiff(DateInterval.Day, birthday, Today)


            Dtgfolder.Rows(s).Cells(5).Value = intYears.ToString
            Dtgfolder.Rows(s).Cells(6).Value = intMonths.ToString

        Next
    End Sub

    Public Sub ConvertAge()
        '// This Will show the AGe in Years and Age in Months and DAys
        '// This method Target the Appointment  Datagrid.
        Dim s As Integer

        For s = 0 To Dtgfolder.Rows.Count() - 1


            Dim birthday As DateTime = Dtgfolder.Rows(s).Cells(4).Value

            Dim intYears As Integer = DateDiff(DateInterval.Year, birthday, Today())
            If DateAdd(DateInterval.Year, intYears, birthday) > Today() Then intYears -= 1

            birthday = DateAdd(DateInterval.Year, intYears, birthday)

            Dim intMonths As Integer = DateDiff(DateInterval.Month, birthday, Today)
            If DateAdd(DateInterval.Month, intMonths, birthday) > Today Then intMonths -= 1

            birthday = DateAdd(DateInterval.Month, intMonths, birthday)

            Dim intDays As Integer = DateDiff(DateInterval.Day, birthday, Today)


            Dtgfolder.Rows(s).Cells(5).Value = intYears.ToString
            Dtgfolder.Rows(s).Cells(6).Value = intMonths.ToString

        Next
    End Sub

    Private Sub LOADPTAGe()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        ' cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = DtgANC.CurrentRow.Cells(1).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            FrmANCreg.txtyear.Text = tbl.Rows(0)(4).ToString()
            FrmANCreg.Txtdob.Text = tbl.Rows(0)(3)
        End If
    End Sub

    Private Sub DtgANC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim frmanc = New FrmANCreg

        frmanc.BtnUpdate.BringToFront()
        FrmANCreg.Show()
    End Sub

    Private Sub BtnNewAnc_Click(sender As Object, e As EventArgs)
        FrmANCreg.Btnsave.BringToFront()
        FrmANCreg.ShowDialog()
    End Sub


End Class
