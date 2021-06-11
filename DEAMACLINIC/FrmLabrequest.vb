Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmLabrequest

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub generatenum()

        Try
            '// This code will automatically generate Request number from the database and show it in the textbox
            '// It picks the maximum value in the table and increment it by one.
            con.Open()

            cmd = New SqlCommand("Select  MAX(Request_Num) from LabRequest", con)
            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then
                'Me.txtRqstNum.Text = dt.Item(0) + 1

                For Cols As Integer = 0 To dtgLabrequest.Rows.Count() - 1
                    dtgLabrequest.Rows(Cols).Cells(0).Value = dt.Item(0) + 1
                Next

                dt.Close()

            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnaddtest_Click(sender As Object, e As EventArgs) Handles btnaddtest.Click

        dtgLabrequest.Rows.Add(txtrqstno.Text, txttestID.Text, txttestname.Text)

        txttestname.Text = ""
        txttestID.Text = ""
        txttestname.Focus()
    End Sub

    Public Sub CboclinicItems()
        Me.cboclinic.Items.Add("GOPD")
        Me.cboclinic.Items.Add("ORTHOPEDIC")
        Me.cboclinic.Items.Add("PRIVATE WARD")
        Me.cboclinic.Items.Add("GENERAL WARD")

    End Sub

    Public Sub LoadLAbTest()
        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select TEST_NAME from LAB_LIST", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            txttestname.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                txttestname.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

        Me.dtgLabrequest.Rows.Clear()

    End Sub

    Private Sub FrmLabrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbldate.Text = Date.Now.Date
        lbltime.Text = TimeOfDay

        CboclinicItems() '// loads clinic to combobox at form load event

        '// This code loads the test list to the textbox and allow the textbox to perform autocomplete function

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
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "Medx-pro")
            txtpassword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub PopulatePendLabRequest()
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_LabRequest Values ('" & dtgLabrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "',  '" & lbltime.Text.ToString & "', '" & FrmPtRecords.Lblhopnum.Text & "', '" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "',  '" & FrmPtRecords.lblage.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblacct.Text & "', '" & FrmPtRecords.Profile1.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_LabRequest VALUES(@Rno, @Dte, @tim, @Hnum, @Sname, @Oname, @Age, @Sex, @Acct, @Cat, @Clin, @Diag, @Rby)", con)

            cmd.Parameters.Add("@Rno", SqlDbType.Int).Value = dtgLabrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
            cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = FrmPtRecords.lblacct.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
            cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@Rby", SqlDbType.VarChar).Value = lblsendername.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveLabRequest()
        generatenum()
        PopulatePendLabRequest()

        Try


            For Each row As DataGridViewRow In dtgLabrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO LabRequest VALUES(@RqstNum, @Date, @Time, @Tid, @TestName, @Comm, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Accntcat, @Clinic, @Diag, @PrescBY)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@RqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Tid", row.Cells("LabTestID").Value)
                        cmd.Parameters.AddWithValue("@TestName", row.Cells("Test_Name").Value) '// Insert the value in the Datagridview test name cell
                        cmd.Parameters.Add("@Comm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmPtRecords.lblacct.Text
                        cmd.Parameters.Add("@Accntcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("LABORATORY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgLabrequest.Rows.Clear()

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

            '//ADD ALL THE LAB TEST IN THE DATAGRID TO THE LAB REQUEST TEXTBOX IN CONSULTATION FORM

            For Cols As Integer = 0 To dtgLabrequest.Rows.Count() - 1 Step ++1
                frmGenConsult.Txtlabinv.Text = frmGenConsult.Txtlabinv.Text + "\\" + dtgLabrequest.Rows(Cols).Cells(2).Value '// This target cell 2 only

                '// THIS ONE BELOW WILL ADD ALL THE COLUMS IN THE DATAGRID

                'For I As Integer = 0 To dtgLabrequest.Rows.Count - 1 Step ++1
                'For J As Integer = 1 To dtgLabrequest.Columns.Count - 1 Step ++1
                'frmGenConsult.Txtlabinv.Text = frmGenConsult.Txtlabinv.Text + "\" + dtgLabrequest.Rows(I).Cells(J).Value.ToString() + "\"
                'Next

                frmGenConsult.Txtlabinv.Text = frmGenConsult.Txtlabinv.Text + "."
            Next

            SaveLabRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""

        End If
        frmLABORATORY.SortPendlabRqst()
        FrmPtRecords.PtLabHist1.LoadLabReqstHx()
        FrmAdmitFolder.InpatientLabHx1.LoadLabReqstHx()
        FrmSurgery.TheatreLAb1.LoadLabReqstHx()
        frmGenConsult.LoadLabHx()
        con.Close()
    End Sub

    Private Sub txttestname_Leave(sender As Object, e As EventArgs) Handles txttestname.Leave

        cmd = New SqlCommand("Select * from LAB_LIST where Test_Name=@Tname", con)
        cmd.Parameters.Add("@Tname", SqlDbType.NVarChar).Value = txttestname.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the test ID

            txttestID.Text = tbl.Rows(0)(6).ToString()

        Else


        End If

    End Sub

    Private Sub FrmLabrequest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cboclinic.Text = ""
        txttestname.Text = ""
        txtdiagn.Text = ""
        txtcomment.Text = ""
        txtrqstno.Text = ""
        txttestID.Text = ""
    End Sub


    '// This will be use on the ANC form
    Public Sub PopulateANCLabRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_LabRequest Values ('" & dtgLabrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_LabRequest VALUES(@Rnum, @Dtes, @tims, @Hnm, @Snam, @Onam, @Ag, @Sx, @Act, @Cat, @Cli, @Dia, @Rqby)", con)

            cmd.Parameters.Add("@Rnum", SqlDbType.Int).Value = dtgLabrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tims", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Hnm", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
            cmd.Parameters.Add("@snam", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
            cmd.Parameters.Add("@onam", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
            cmd.Parameters.Add("@Ag", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
            cmd.Parameters.Add("@sx", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
            cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = cboclinic.Text
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

    Public Sub SaveANCLabRequest()

        generatenum()
        PopulateANCLabRequest()

        Try


            For Each row As DataGridViewRow In dtgLabrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO LabRequest VALUES(@RqstNum, @Date, @Time, @Tid, @TestName, @Comm, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Acctcat, @Clinic, @Diag, @PrescBY)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.
                        cmd.Parameters.AddWithValue("@RqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Tid", row.Cells("LabTestID").Value)
                        cmd.Parameters.AddWithValue("@TestName", row.Cells("Test_Name").Value) '// Insert the value in the Datagridview test name cell
                        cmd.Parameters.Add("@Comm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
                        cmd.Parameters.Add("@Acctcat", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("LABORATORY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgLabrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSndAncLab_Click(sender As Object, e As EventArgs) Handles BtnSndAncLab.Click

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

            SaveANCLabRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        frmLABORATORY.SortPendlabRqst()
        FrmPtRecords.PtLabHist1.LoadLabReqstHx()
        FrmAdmitFolder.InpatientLabHx1.LoadLabReqstHx()
        FrmSurgery.TheatreLAb1.LoadLabReqstHx()
        frmGenConsult.LoadLabHx()
        con.Close()

    End Sub


    ''// SAVE LAB REQUEST FROM WARD

    Public Sub PopulateWARDLabRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_LabRequest Values ('" & dtgLabrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_LabRequest VALUES(@wRnum, @wDtes, @wtims, @wHnm, @wSnam, @wOnam, @wAg, @wSx, @wAct, @wCat, @wCli, @wDia, @wRqby)", con)

            cmd.Parameters.Add("@wRnum", SqlDbType.Int).Value = dtgLabrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@wDtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@wTims", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@wHnm", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
            cmd.Parameters.Add("@wsnam", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
            cmd.Parameters.Add("@wonam", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
            cmd.Parameters.Add("@wAg", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
            cmd.Parameters.Add("@wsx", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
            cmd.Parameters.Add("@wAct", SqlDbType.NVarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
            cmd.Parameters.Add("@wCat", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
            cmd.Parameters.Add("@wCli", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@wDia", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@wRqby", SqlDbType.VarChar).Value = lblsendername.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveWARDLabRequest()

        generatenum()
        PopulateWARDLabRequest()

        Try


            For Each row As DataGridViewRow In dtgLabrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO LabRequest VALUES(@WRqstNum, @WDate, @WTime, @WTid, @WTestName, @WComm, @WHospnum, @wSurname, @WOthernames, @WAge, @WSex, @WAccount, @WAcctcat, @WClinic, @WDiag, @WPrescBY)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@WRqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@WDate", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@WTime", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@WTid", row.Cells("LabTestID").Value)
                        cmd.Parameters.AddWithValue("@WTestName", row.Cells("Test_Name").Value) '// Insert the value in the Datagridview test name cell
                        cmd.Parameters.Add("@WComm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@WHospnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                        cmd.Parameters.Add("@WSurname", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
                        cmd.Parameters.Add("@WOthernames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
                        cmd.Parameters.Add("@WAge", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
                        cmd.Parameters.Add("@WSex", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
                        cmd.Parameters.Add("@WAccount", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
                        cmd.Parameters.Add("@WAcctcat", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
                        cmd.Parameters.Add("@WClinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@WDiag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@WPrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("LABORATORY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgLabrequest.Rows.Clear()

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

            SaveWARDLabRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        frmLABORATORY.SortPendlabRqst()
        FrmPtRecords.PtLabHist1.LoadLabReqstHx()
        FrmAdmitFolder.InpatientLabHx1.LoadLabReqstHx()
        FrmSurgery.TheatreLAb1.LoadLabReqstHx()
        frmGenConsult.LoadLabHx()
        con.Close()
    End Sub

    '/// SAVE LAB REQUEST FROM THETATRE

    Public Sub PopulateTheatreLabRequest()

        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_LabRequest Values ('" & dtgLabrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_LabRequest VALUES(@TRnum, @TDtes, @Ttims, @THnm, @TSnam, @TOnam, @TAg, @TSx, @TAct, @TCat, @TCli, @TDia, @TRqby)", con)

            cmd.Parameters.Add("@TRnum", SqlDbType.Int).Value = dtgLabrequest.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@TDtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@TTims", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@THnm", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
            cmd.Parameters.Add("@TSnam", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
            cmd.Parameters.Add("@TOnam", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
            cmd.Parameters.Add("@TAg", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
            cmd.Parameters.Add("@TSx", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
            cmd.Parameters.Add("@TAct", SqlDbType.NVarChar).Value = FrmSurgery.TxtAcct.Text
            cmd.Parameters.Add("@TCat", SqlDbType.VarChar).Value = FrmSurgery.TxtAccTyp.Text
            cmd.Parameters.Add("@TCli", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@TDia", SqlDbType.NVarChar).Value = txtdiagn.Text
            cmd.Parameters.Add("@TRqby", SqlDbType.VarChar).Value = lblsendername.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub
    Public Sub SaveTheatreLabRequest()

        generatenum()
        PopulateTheatreLabRequest()

        Try


            For Each row As DataGridViewRow In dtgLabrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO LabRequest VALUES(@ThRqstNum, @ThDate, @ThTime, @ThTid, @ThTestName, @ThComm, @ThHnm, @ThSnam, @ThOnams, @ThAg, @ThSx, @ThAct, @Thcat, @ThClinic, @ThDiag, @ThPrescBY)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@ThRqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@ThDate", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@ThTime", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@THTid", row.Cells("LabTestID").Value)
                        cmd.Parameters.AddWithValue("@ThTestName", row.Cells("Test_Name").Value) '// Insert the value in the Datagridview test name cell
                        cmd.Parameters.Add("@ThComm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@ThHnm", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
                        cmd.Parameters.Add("@ThSnam", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
                        cmd.Parameters.Add("@ThOnams", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
                        cmd.Parameters.Add("@ThAg", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
                        cmd.Parameters.Add("@ThSx", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
                        cmd.Parameters.Add("@ThAct", SqlDbType.NVarChar).Value = FrmSurgery.TxtAcct.Text
                        cmd.Parameters.Add("@ThCat", SqlDbType.VarChar).Value = FrmSurgery.TxtAccTyp.Text
                        cmd.Parameters.Add("@ThClinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@ThDiag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@ThPrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("LABORATORY REQUEST SENT", vbOKOnly, "Medx-pro")

            dtgLabrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BtnSaveTheatre_Click(sender As Object, e As EventArgs) Handles BtnSaveTheatre.Click

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

            SaveTheatreLabRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""

        End If

        frmLABORATORY.SortPendlabRqst()
        FrmPtRecords.PtLabHist1.LoadLabReqstHx()
        FrmAdmitFolder.InpatientLabHx1.LoadLabReqstHx()
        FrmSurgery.TheatreLAb1.LoadLabReqstHx()
        frmGenConsult.LoadLabHx()
        con.Close()
    End Sub

    '// SAve Test Request For Folloup Visit on consultaion
    Private Sub BtnsaveFlwup_Click(sender As Object, e As EventArgs) Handles BtnsaveFlwup.Click
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

            SaveLabRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""

        End If

        frmLABORATORY.SortPendlabRqst()
        FrmPtRecords.PtLabHist1.LoadLabReqstHx()
        FrmAdmitFolder.InpatientLabHx1.LoadLabReqstHx()
        FrmSurgery.TheatreLAb1.LoadLabReqstHx()
        frmGenConsult.LoadLabHx()

        con.Close()

    End Sub

End Class