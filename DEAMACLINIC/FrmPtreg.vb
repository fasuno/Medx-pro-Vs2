Imports System.Data.SqlClient

Public Class FrmPtreg

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        '// This will check if an hospital number already exist in the database

        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)

        cmd.Parameters.Add("@hosp_num", SqlDbType.VarChar).Value = txthospnum.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim ctbl As New DataTable()
        adpt.Fill(ctbl)

        '// If it Then exist show message Erase hospital number textbox For New entry

        If ctbl.Rows.Count() > 0 Then
            MsgBox("HOSPITAL NUMBER HAS BEEN ASSIGNED", MsgBoxStyle.Information, "Medx-pro")
            txthospnum.Text = ""
            txthospnum.Focus()

        ElseIf txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Exclamation, "Medx-pro")
            txtpass.Focus()

        ElseIf txthospnum.Text = "" Then
            MsgBox("PLEASE ENTER HOSPITAL NUMBER", MsgBoxStyle.Exclamation, "Medx-pro")
            txthospnum.Focus()

        Else

            Dim msg = MsgBox("ARE YOU SURE YOU WANT TO SAVE ?", MsgBoxStyle.YesNo, "Medx-pro")
            If msg = MsgBoxResult.Yes Then

                '// Call the Checkuser method   

                SavePtProfile()     '// See the method to view code

            Else
                txtpass.Focus()
            End If
        End If
        '// Call the reloaddtgfolder method to Refresh the folder datagrid
        Frmrecords.sortPatientfolder()
        ' reloaddtgfolder()
        FrmAppointment.ShowDialog()

    End Sub

    Private Sub FrmPtreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/ Automatically Set Expired date to 10 years advance from the date of registration
        Dim d As Date = regdate.Value
        Dim b As Date
        d = d.AddDays(+3650)
        b = d.AddDays(2)
        Expdate.Value = b
        ' Me.MdiParent = frmMain
        agecalc()
        ' Populateacct()
    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Me.Close()
    End Sub

    Private Sub btncaution_Click(sender As Object, e As EventArgs) Handles btncaution.Click

        txtcaution.ReadOnly = False
        txtcaution.Focus()
        BtnSaveCaut.BringToFront()
        ' Dim input As String

        'Try
        'Input = InputBox("Enter Special Precauition / Allegies", "Precaution", "")
        'txtcaution.Text = txtcaution.Text + "," + (input.ToString)
        'Catch ex As Exception
        'MessageBox.Show("Invalid", "error", MessageBoxButtons.OK)

        'End Try
    End Sub

    Private Sub BtnSaveCaut_Click(sender As Object, e As EventArgs) Handles BtnSaveCaut.Click
        UpdatePrecaution()
        btncaution.BringToFront()
        txtcaution.ReadOnly = True
    End Sub

    Sub UpdatePrecaution()
        Try
            cmd = New SqlCommand("UPDATE Pt_Profile SET Precaution=@Pcaut WHERE Hospital_Num=@Hnop")

            cmd.Parameters.Add("@Pcaut", SqlDbType.VarChar).Value = txtcaution.Text
            cmd.Parameters.Add("@Hnop", SqlDbType.VarChar).Value = txthospnum.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("PRECAUTION/ALLERGIES SAVED SUCCESSFULLY", "Medx-pro", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Error Updating Preacaution/Allergies", "Medx-pro", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click

        If txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Exclamation, "Medx-pro")
            txtpass.Focus()

        Else

            Try
                cmd = New SqlCommand("UPDATE Pt_Profile Set  Surname=@snam, Other_Names=@onam, Date_of_birth=@dtob,Account_Type=@Acttyp, Account_Category=@Prov, Date_registered=@RegDt, Sex=@Sx, Marital_Status=@Marst, Religion=@Relg, Occupation=@Ocp, LGA=@locl, State_of_origin =@Stat, Nationality=@Natnl, Tribe=@Tri, Home_address =@Adr, District=@Dstr, Phone =@Phon, Email=@eml, Date_Expired=@Expdat, Enrollee_Type =@Enrol, Employer =@Emp, Enrolle_Number =@Eno, Kin_Name =@Knm, Kin_Address =@Kadr, Kin_relationship =@Krl, Kin_phone =@Kphon, NIN =@Ninno, Non_Nigerian =@Nnig, Precaution=@PCaut WHERE Hospital_Num='" & txthospnum.Text & "'")


                cmd.Parameters.Add("@snam", SqlDbType.NVarChar).Value = txtsurname.Text
                cmd.Parameters.Add("@onam", SqlDbType.NVarChar).Value = txtothernames.Text
                cmd.Parameters.Add("@dtob", SqlDbType.Date).Value = dbo.Value.Date

                cmd.Parameters.Add("@Acttyp", SqlDbType.NVarChar).Value = cboacct.Text
                cmd.Parameters.Add("@Prov", SqlDbType.NVarChar).Value = Txtprovi.Text
                cmd.Parameters.Add("@RegDt", SqlDbType.Date).Value = regdate.Value.Date
                cmd.Parameters.Add("@Sx", SqlDbType.NVarChar).Value = cbosex.Text
                cmd.Parameters.Add("@Marst", SqlDbType.NVarChar).Value = cbomarital.Text
                cmd.Parameters.Add("@Relg", SqlDbType.NVarChar).Value = cborelig.Text
                cmd.Parameters.Add("@Ocp", SqlDbType.NVarChar).Value = cbooccup.Text
                cmd.Parameters.Add("@locl", SqlDbType.NVarChar).Value = CboLga.Text
                cmd.Parameters.Add("@Stat", SqlDbType.NVarChar).Value = cbostate.Text
                cmd.Parameters.Add("@Natnl", SqlDbType.NVarChar).Value = cbonat.Text
                cmd.Parameters.Add("@Tri", SqlDbType.NVarChar).Value = Txttribe.Text
                cmd.Parameters.Add("@Adr", SqlDbType.NVarChar).Value = txtadd.Text
                cmd.Parameters.Add("@Dstr", SqlDbType.NVarChar).Value = CboDistrct.Text
                cmd.Parameters.Add("@Phon", SqlDbType.NVarChar).Value = txtphone.Text
                cmd.Parameters.Add("@eml", SqlDbType.VarChar).Value = txtemail.Text
                cmd.Parameters.Add("@ExpDat", SqlDbType.VarChar).Value = Expdate.Value.Date
                cmd.Parameters.Add("@Enrol", SqlDbType.VarChar).Value = cboenrol.Text
                cmd.Parameters.Add("@Emp", SqlDbType.VarChar).Value = txtemployer.Text
                cmd.Parameters.Add("@Eno", SqlDbType.VarChar).Value = txtenrolnum.Text

                cmd.Parameters.Add("@Knm", SqlDbType.VarChar).Value = txtkinname.Text
                cmd.Parameters.Add("@Kadr", SqlDbType.VarChar).Value = txtkinadd.Text
                cmd.Parameters.Add("@Krl", SqlDbType.VarChar).Value = cborelat.Text
                cmd.Parameters.Add("@Kphon", SqlDbType.VarChar).Value = txtkinphone.Text

                cmd.Parameters.Add("@Ninno", SqlDbType.VarChar).Value = txtnin.Text
                cmd.Parameters.Add("@Nnig", SqlDbType.VarChar).Value = txtstate.Text
                cmd.Parameters.Add("@Pcaut", SqlDbType.VarChar).Value = txtcaution.Text
                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("PATIENT PROFILE SUCCESSFULLY  EDITED", "Medx-pro", MessageBoxButtons.OK)

                'Call the reload method for folder datagrid to refresh datagrid
                ' reloaddtgfolder()
                Call Frmrecords.btnfindfolder.PerformClick()

            Catch ex As Exception
                MessageBox.Show("Error Updating patient profile", "Medx-pro", MessageBoxButtons.OK)

            End Try


            Me.Close()
        End If

    End Sub

    Public Sub LoadAccountype()

        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Account_Category from BillSetting", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            Txtprovi.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                Txtprovi.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Public Sub Populateacct()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Account_Type from BillSetting ", con)


        adapt = New SqlDataAdapter(cmd)

        con.Open()   ' Open connection

        adapt.Fill(tbl)
        cboacct.DataSource = tbl
        cboacct.DisplayMember = "Account_Type"


        con.Close()

    End Sub

    Private Sub cboacct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboacct.SelectedIndexChanged
        If Me.cboacct.SelectedIndex = 1 Then

            Me.cboenrol.Enabled = True
            ' Me.Txtprovi.Enabled = True
            Me.txtenrolnum.Enabled = True
            Me.txtemployer.Enabled = True

        ElseIf Me.cboacct.SelectedIndex = 0 Then

            ' Txtprovi.Text = "Private"
            Me.cboenrol.Enabled = False
            'Me.Txtprovi.Enabled = False
            Me.txtenrolnum.Enabled = False
            Me.txtemployer.Enabled = False

        End If
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloaddtgfolder()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from VwPtProfile", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Frmrecords.Dtgfolder.DataSource = tbl
        con.Close()     '   I disable the close connection bcos i'm calling it in the save button where a connection is already open

    End Sub

    Public Sub SavePtProfile()


        Try

            cmd = New SqlCommand("INSERT INTO Pt_Profile VALUES(@Hnum, @Sname, @Oname, @dbo, @Act, @RegD, @Pro, @Sexx, @MarS, @Rel, @Occ, @loc, @Sta, @Nat, @Trib, @Add, @Dist, @Pho, @ema, @ExpDt, @EnrT, @Empl, @Enum, @Knam, @Kadd, @Kph, @Krel, @Nino, @nsta, @User, @Cau )", con)

            cmd.Parameters.Add("@Hnum", SqlDbType.NVarChar).Value = txthospnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = txtsurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtothernames.Text
            cmd.Parameters.Add("@dbo", SqlDbType.Date).Value = dbo.Value.Date

            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = cboacct.Text
            cmd.Parameters.Add("@Pro", SqlDbType.NVarChar).Value = Txtprovi.Text
            cmd.Parameters.Add("@RegD", SqlDbType.Date).Value = regdate.Value.Date
            cmd.Parameters.Add("@Sexx", SqlDbType.NVarChar).Value = cbosex.Text
            cmd.Parameters.Add("@Mars", SqlDbType.NVarChar).Value = cbomarital.Text
            cmd.Parameters.Add("@Rel", SqlDbType.NVarChar).Value = cborelig.Text
            cmd.Parameters.Add("@Occ", SqlDbType.NVarChar).Value = cbooccup.Text
            cmd.Parameters.Add("@loc", SqlDbType.NVarChar).Value = CboLga.Text
            cmd.Parameters.Add("@Sta", SqlDbType.NVarChar).Value = cbostate.Text
            cmd.Parameters.Add("@Nat", SqlDbType.NVarChar).Value = cbonat.Text
            cmd.Parameters.Add("@Trib", SqlDbType.NVarChar).Value = Txttribe.Text
            cmd.Parameters.Add("@Add", SqlDbType.NVarChar).Value = txtadd.Text
            cmd.Parameters.Add("@Dist", SqlDbType.NVarChar).Value = CboDistrct.Text
            cmd.Parameters.Add("@Pho", SqlDbType.NVarChar).Value = txtphone.Text
            cmd.Parameters.Add("@ema", SqlDbType.VarChar).Value = txtemail.Text
            cmd.Parameters.Add("@ExpDt", SqlDbType.VarChar).Value = Expdate.Value.Date
            cmd.Parameters.Add("@EnrT", SqlDbType.VarChar).Value = cboenrol.Text
            cmd.Parameters.Add("@Empl", SqlDbType.VarChar).Value = txtemployer.Text
            cmd.Parameters.Add("@Enum", SqlDbType.VarChar).Value = txtenrolnum.Text

            cmd.Parameters.Add("@Knam", SqlDbType.VarChar).Value = txtkinname.Text
            cmd.Parameters.Add("@Kadd", SqlDbType.VarChar).Value = txtkinadd.Text
            cmd.Parameters.Add("@Krel", SqlDbType.VarChar).Value = cborelat.Text
            cmd.Parameters.Add("@Kph", SqlDbType.VarChar).Value = txtkinphone.Text

            cmd.Parameters.Add("@nino", SqlDbType.VarChar).Value = txtnin.Text
            cmd.Parameters.Add("@nsta", SqlDbType.VarChar).Value = txtstate.Text
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Lbluser.Text
            cmd.Parameters.Add("@cau", SqlDbType.VarChar).Value = txtcaution.Text


            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()

            MsgBox("PATIENT HAS BEEN REGISTERED SUCCESSFULLY", MsgBoxStyle.Information, "Medx-pro")


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
        ' // Clear all textboxes for new entry
        dbo.Value = Now.Date
        txthospnum.Text = ""
        txtsurname.Text = ""
        txtothernames.Text = ""
        cboacct.Text = ""
        cboenrol.Text = ""
        Txttribe.Text = ""
        cbomarital.Text = ""
            cbonat.Text = ""
            cbooccup.Text = ""
            Txtprovi.Text = ""
            cborelat.Text = ""
            cborelig.Text = ""
            cbosex.Text = ""
            cbostate.Text = ""
            cbonat.Text = ""
            txtadd.Text = ""
            txtemail.Text = ""
        CboDistrct.Text = ""
        CboLga.Text = ""
        txtemployer.Text = ""
            txtenrolnum.Text = ""
            txthospnum.Text = ""
            txtkinadd.Text = ""
            txtkinname.Text = ""
            txtkinphone.Text = ""
            txtnin.Text = ""
            txtpass.Text = ""
            txtphone.Text = ""
            txtrecptnum.Text = ""
            txtstate.Text = ""
            txtcaution.Text = ""
            txtmonths.Text = ""
            txtyear.Text = ""
            txthospnum.Focus()



    End Sub

    Public Sub agecalc()

        Dim birthday As DateTime = dbo.Value.Date

        Dim intYears As Integer = DateDiff(DateInterval.Year, birthday, Today())
        If DateAdd(DateInterval.Year, intYears, birthday) > Today() Then intYears -= 1

        birthday = DateAdd(DateInterval.Year, intYears, birthday)

        Dim intMonths As Integer = DateDiff(DateInterval.Month, birthday, Today)
        If DateAdd(DateInterval.Month, intMonths, birthday) > Today Then intMonths -= 1

        birthday = DateAdd(DateInterval.Month, intMonths, birthday)

        Dim intDays As Integer = DateDiff(DateInterval.Day, birthday, Today)

        txtyear.Text = intYears.ToString
        'Txtdays.Text = intDays.ToString
        txtmonths.Text = intMonths.ToString


        ' Convertion of datime to age in years and months

        ' Dim ageyr As Integer
        'Dim agemnt As Integer
        'ageyr = DateTime.Today.Year - dbo.Value.Year
        'agemnt = DateTime.Today.Month - dbo.Value.Month
        'txtyear.Text = ageyr.ToString()
        'txtmonths.Text = agemnt.ToString()

    End Sub

    Private Sub dbo_ValueChanged(sender As Object, e As EventArgs) Handles dbo.ValueChanged
        '   If dbo.Value > DateTime.Today Then
        '  MsgBox("YOU CANNOT CHOOSE FUTURE DATE", MsgBoxStyle.Critical, "INVALID DATE")
        ' dbo.MaxDate = DateTime.Today
        'Else
        'call the age calculator method
        agecalc()
        'End If
    End Sub

    Private Sub txthospnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthospnum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtrecptnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrecptnum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub regdate_ValueChanged(sender As Object, e As EventArgs) Handles regdate.ValueChanged
        'If regdate.Value > DateTime.Today Then
        'MsgBox("YOU CANNOT CHOOSE FUTURE DATE", MsgBoxStyle.Critical, "Medx-pro")
        'regdate.MaxDate = DateTime.Today
        'ElseIf regdate.Value < DateTime.Today Then
        '   MsgBox("YOU CANNOT BACKDATE", MsgBoxStyle.Critical, "Medx-pro")
        '  regdate.MinDate = DateTime.Today
        ' End If


    End Sub

    Public Sub showUserName()

        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            Lbluser.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpass.Focus()
        Else

            showUserName()
        End If
    End Sub

    Private Sub Btnupload_Click(sender As Object, e As EventArgs) Handles Btnupload.Click
        FrmDocUpload.txthospnum.Text = txthospnum.Text
        FrmDocUpload.Txtname.Text = txtsurname.Text + " " + txtothernames.Text
        FrmDocUpload.BtnUpload.BringToFront()
        FrmDocUpload.LoadScannefile()

        FrmDocUpload.ShowDialog()
    End Sub

    Private Sub BtnViewConslt_Click(sender As Object, e As EventArgs) Handles BtnViewConslt.Click

        FrmPtRecords.Lblsurname.Text = txtsurname.Text
        FrmPtRecords.Lblothernmaes.Text = txtothernames.Text
        FrmPtRecords.Lblhopnum.Text = txthospnum.Text

        FrmPtRecords.lblage.Text = txtyear.Text
        FrmPtRecords.lblsex.Text = cbosex.Text
        FrmPtRecords.lblacct.Text = cboacct.Text
        ' FrmPtRecords.lbldocid.Text = 

        Me.Hide()
        FrmPtRecords.ShowDialog()

    End Sub






    '
End Class




