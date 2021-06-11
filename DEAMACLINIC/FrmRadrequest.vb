Imports System.Data.SqlClient

Public Class FrmRadrequest

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub CboclinicItems()
        Me.cboclinic.Items.Add("GOPD")
        Me.cboclinic.Items.Add("ORTHOPEDIC")
        Me.cboclinic.Items.Add("PRIVATE WARD")
        Me.cboclinic.Items.Add("GENERAL WARD")
    End Sub

    Public Sub generatenum()

        Try

            '// This code will automatically generate Request number from the database and show it in the textbox
            '// It picks the maximum value in the table and increment it by one.
            con.Open()

            cmd = New SqlCommand("Select  MAX(Request_Num) from RadRequestAndResult", con)


            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then
                'Me.txtRqstNum.Text = dt.Item(0) + 1

                For Cols As Integer = 0 To dtgRadrequest.Rows.Count() - 1
                    dtgRadrequest.Rows(Cols).Cells(0).Value = dt.Item(0) + 1
                Next

                dt.Close()

            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblsendername.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpassword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub PopulatePendRadRequest()
        Try

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmPtRecords.Lblhopnum.Text & "', '" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "',  '" & FrmPtRecords.lblage.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblacct.Text & "','" & FrmPtRecords.Profile1.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_RadRequest VALUES(@Rnum, @Dte, @tim, @Hnum, @Sname, @Oname, @Age, @Sex, @Acct, @ActCAt, @Clin, @Dia, @Rqby)", con)

            cmd.Parameters.Add("@Rnum", SqlDbType.Int).Value = dtgRadrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltime.Text.ToString
            cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = FrmPtRecords.lblacct.Text
            cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
            cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Dia", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@Rqby", SqlDbType.VarChar).Value = lblsendername.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveRadRequest()
        generatenum()
        PopulatePendRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@RqstNum, @Date, @Time, @InvName, @Comm, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Accntcat, @Clinic, @Diag, @PrescBY, @dtrprt, @timrprt, @rptdBy, @stat, @Imp, @Not)", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@RqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@InvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@Comm", SqlDbType.NVarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.NVarChar).Value = FrmPtRecords.lblacct.Text
                        cmd.Parameters.Add("@Accntcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@Dtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@timrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@rptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Stat", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Imp", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Not", SqlDbType.NVarChar).Value = DBNull.Value



                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnsendrequest_Click(sender As Object, e As EventArgs) Handles btnsendrequest.Click

        '// This code is a really breakthru for me and I thank God The father for The gift Of the Holy Spirit who taught me
        '// This code will export all the datat in a datagridview to a textbox all at once.

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            For cols As Integer = 0 To dtgRadrequest.Rows.Count - 1 Step ++1

                frmGenConsult.TxtRadinv.Text = frmGenConsult.TxtRadinv.Text + "\\" + dtgRadrequest.Rows(cols).Cells(1).Value '// This target cell 1 only

                frmGenConsult.TxtRadinv.Text = frmGenConsult.TxtRadinv.Text + "."
            Next

            SaveRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        FrmAdmitFolder.InpatientRadHx1.LoadRAdilogicalHx()
        FrmSurgery.TheatreScan1.LoadRAdilogicalHx()
        frmGenConsult.LoadRADHx()
        con.Close()
    End Sub

    Private Sub btnaddInv_Click(sender As Object, e As EventArgs) Handles btnaddInv.Click

        dtgRadrequest.Rows.Add(txtRqstNum.Text, txtInvType.Text) '//txtnul is to hold empty values for the colums

        txtInvType.Text = ""
        txtInvType.Focus()

    End Sub

    Private Sub FrmRadrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now.Date
        lbltime.Text = TimeOfDay

        CboclinicItems() '// loads clinic to combobox at form load event

    End Sub

    Public Sub LoadRAdlist()
        '// This code loads the drugs list to the textbox and allow the textbox to perform autocomplete function
        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select INVESTIGATION from Xray_ScanList", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            txtInvType.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                txtInvType.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            'generatenum()

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

        Me.dtgRadrequest.Rows.Clear()
    End Sub


    '//SAVE ANC RADIOLOGY REQUEST
    Public Sub PopulateANCRadRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_RadRequest VALUES(@Rqnum, @Dtes, @tims, @Hnums, @Snames, @Onames, @Ags, @Sexs, @Accts, @ActCAts, @Clins, @Dias, @Rqbys)", con)

            cmd.Parameters.Add("@Rqnum", SqlDbType.Int).Value = dtgRadrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tims", SqlDbType.VarChar).Value = lbltime.Text.ToString
            cmd.Parameters.Add("@Hnums", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
            cmd.Parameters.Add("@snames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
            cmd.Parameters.Add("@onames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
            cmd.Parameters.Add("@Ags", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
            cmd.Parameters.Add("@Sexs", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
            cmd.Parameters.Add("@Accts", SqlDbType.NVarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
            cmd.Parameters.Add("@Actcats", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
            cmd.Parameters.Add("@Clins", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Dias", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@Rqbys", SqlDbType.VarChar).Value = lblsendername.Text


            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveANCRadRequest()

        generatenum()

        PopulateANCRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@ARqstNum, @ADate, @ATime, @AInvName, @AComm, @AHospnum, @ASurname, @AOthernames, @AAge, @ASex, @AAccount, @AAccntcat, @AClinic, @ADiag, @APrescBY, @Adtrprt, @Atimrprt, @ArptdBy, @Astat, @AImp, @ANot)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@ARqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@ADate", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@ATime", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@AInvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@AComm", SqlDbType.NVarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@AHospnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
                        cmd.Parameters.Add("@ASurname", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
                        cmd.Parameters.Add("@AOthernames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
                        cmd.Parameters.Add("@AAge", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
                        cmd.Parameters.Add("@ASex", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
                        cmd.Parameters.Add("@AAccount", SqlDbType.NVarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
                        cmd.Parameters.Add("@AAcctcat", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
                        cmd.Parameters.Add("@AClinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@ADiag", SqlDbType.NVarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@APrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@ADtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@Atimrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Arptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@AStat", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@AImp", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@ANot", SqlDbType.NVarChar).Value = DBNull.Value

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSndAncRad_Click(sender As Object, e As EventArgs) Handles BtnSndAncRad.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveANCRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        FrmAdmitFolder.InpatientRadHx1.LoadRAdilogicalHx()
        FrmSurgery.TheatreScan1.LoadRAdilogicalHx()
        frmGenConsult.LoadRADHx()
        con.Close()

    End Sub

    '// SAVE WARD RADIOLOGY REQUEST

    Public Sub PopulateWARDRadRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_RadRequest VALUES(@wRqnum, @wDtes, @wtims, @wHnums, @wSnames, @wOnames, @wAgs, @wSexs, @wAccts, @wActCAts, @wClins, @wDias, @wRqbys)", con)

            cmd.Parameters.Add("@wRqnum", SqlDbType.Int).Value = dtgRadrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@wdtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@wTims", SqlDbType.VarChar).Value = lbltime.Text.ToString
            cmd.Parameters.Add("@wHnums", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
            cmd.Parameters.Add("@wsnames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
            cmd.Parameters.Add("@wonames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
            cmd.Parameters.Add("@wAgs", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
            cmd.Parameters.Add("@wSexs", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
            cmd.Parameters.Add("@wAccts", SqlDbType.NVarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
            cmd.Parameters.Add("@wActcats", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
            cmd.Parameters.Add("@wClins", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@wDias", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@wRqbys", SqlDbType.VarChar).Value = lblsendername.Text


            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveWARDRadRequest()

        generatenum()
        PopulateWARDRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@wRqstNum, @wDate, @wTime, @wInvName, @wComm, @wHospnum, @wSurname, @wOthernames, @wAge, @wSex, @wAccount, @wAcctcat, @wClinic, @wDiag, @wPrescBY, @Adtrprt, @Wtimrprt, @WrptdBy, @Wstat, @WImp, @WNot)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@wRqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@wDate", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@wTime", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@wInvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@wComm", SqlDbType.NVarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@wHospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                        cmd.Parameters.Add("@wSurname", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
                        cmd.Parameters.Add("@wOthernames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
                        cmd.Parameters.Add("@wAge", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
                        cmd.Parameters.Add("@wSex", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
                        cmd.Parameters.Add("@wAccount", SqlDbType.NVarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
                        cmd.Parameters.Add("@wAcctcat", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
                        cmd.Parameters.Add("@wClinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@wDiag", SqlDbType.NVarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@wPrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@wDtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@wtimrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@wrptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@wStat", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@wImp", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@wNot", SqlDbType.NVarChar).Value = DBNull.Value


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "Medx-Pro")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSaveWard_Click(sender As Object, e As EventArgs) Handles BtnSaveWard.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveWARDRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        FrmAdmitFolder.InpatientRadHx1.LoadRAdilogicalHx()
        FrmSurgery.TheatreScan1.LoadRAdilogicalHx()
        frmGenConsult.LoadRADHx()
        con.Close()

    End Sub

    '// SAVE THEATRE RADIOLOGY REQUEST

    Public Sub PopulateTheatreRadRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_RadRequest VALUES(@ThRqnum, @ThDtes, @Thtims, @ThHnums, @Thsnams, @ThOnams, @ThAgs, @ThSxs, @ThActs, @ThActcts, @ThClins, @ThDias, @ThRqbys)", con)

            cmd.Parameters.Add("@ThRqnum", SqlDbType.Int).Value = dtgRadrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Thdtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@ThTims", SqlDbType.VarChar).Value = lbltime.Text.ToString
            cmd.Parameters.Add("@ThHnums", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
            cmd.Parameters.Add("@Thsnams", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
            cmd.Parameters.Add("@Thonams", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
            cmd.Parameters.Add("@ThAgs", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
            cmd.Parameters.Add("@ThSxs", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
            cmd.Parameters.Add("@ThActs", SqlDbType.NVarChar).Value = FrmSurgery.TxtAcct.Text
            cmd.Parameters.Add("@THActcts", SqlDbType.VarChar).Value = FrmSurgery.TxtAccTyp.Text
            cmd.Parameters.Add("@ThClins", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@ThDias", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@ThRqbys", SqlDbType.VarChar).Value = lblsendername.Text


            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub
    Public Sub SaveTheatreRadRequest()

        generatenum()
        PopulateTheatreRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@TRqstNum, @TDate, @TTime, @TInvName, @TComm, @THnu, @Tsnams, @Tonams, @TAgs, @TSxs, @TActs, @TActcts, @TClinic, @TDiag, @TPrescBY, @TDtrprt, @Ttimrprt, @TrptdBy, @Tstat, @TImp, @TNot)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@TRqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@TDate", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@TTime", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@TInvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@TComm", SqlDbType.NVarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@THnu", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
                        cmd.Parameters.Add("@Tsnams", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
                        cmd.Parameters.Add("@Tonams", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
                        cmd.Parameters.Add("@TAgs", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
                        cmd.Parameters.Add("@TSxs", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
                        cmd.Parameters.Add("@TActs", SqlDbType.NVarChar).Value = FrmSurgery.TxtAcct.Text
                        cmd.Parameters.Add("@TActcts", SqlDbType.NVarChar).Value = FrmSurgery.TxtAccTyp.Text
                        cmd.Parameters.Add("@TClinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@TDiag", SqlDbType.NVarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@TPrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@TDtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@Ttimrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Trptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@TStat", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@TImp", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@TNot", SqlDbType.NVarChar).Value = DBNull.Value


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "Medx-Pro")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BtnSavetheatre_Click(sender As Object, e As EventArgs) Handles BtnSavetheatre.Click
        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveTheatreRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        FrmAdmitFolder.InpatientRadHx1.LoadRAdilogicalHx()
        FrmSurgery.TheatreScan1.LoadRAdilogicalHx()
        frmGenConsult.LoadRADHx()
        con.Close()
    End Sub

    '// SAve Request from followup visit
    Private Sub BtnSAveFlwup_Click(sender As Object, e As EventArgs) Handles BtnSAveFlwup.Click
        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        FrmAdmitFolder.InpatientRadHx1.LoadRAdilogicalHx()
        FrmSurgery.TheatreScan1.LoadRAdilogicalHx()
        frmGenConsult.LoadRADHx()
        con.Close()
    End Sub

End Class