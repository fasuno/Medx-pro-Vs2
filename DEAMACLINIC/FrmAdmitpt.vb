Imports System.Data.SqlClient
Public Class FrmAdmitpt
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub FrmAdmitpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboclinicItems()
        lbldat.Text = Now.Date
        lbltim.Text = TimeOfDay

        showAllwards()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Ward_Name, COUNT(Bed_status) AS Beds_Available From Bedlist WHERE Bed_Status= 'Free' GROUP BY Ward_name, Bed_Status", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Dgvbedlist.DataSource = tbl

        '===============
        'ShowWards()

    End Sub
    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click

        If Cboadmtyp.Text = "SURGERY ONLY" Then
            PopulateSUrgery()

        ElseIf Cboadmtyp.Text = "ADMISSION/SURGERY" Then
            ADmitAndSurgery()

        Else

            If Txtpass.Text = "" Then
                MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
                txtdiagnosis.Focus()

            Else

                Dim res As MsgBoxResult
                res = MsgBox("ARE YOU SURE YOU WANT TO ADMIT THIS PATIENT?", MsgBoxStyle.YesNo, "Medx-Pro")
                If (res = MsgBoxResult.Yes) Then

                    Try

                        cmd = New SqlCommand("INSERT INTO AdmissionRequest VALUES(@dte, @Tim, @Hnum, @Sname, @Oname,@Sex, @Age, @Diag, @Adt, @Wrd, @Ins, @Oby, @Cli)", con)

                        cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldat.Text).Date
                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                        cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiagnosis.Text
                        cmd.Parameters.Add("@Adt", SqlDbType.VarChar).Value = Cboadmtyp.Text
                        cmd.Parameters.Add("@Wrd", SqlDbType.VarChar).Value = cboward.Text
                        cmd.Parameters.Add("@Ins", SqlDbType.VarChar).Value = txtinstr.Text
                        cmd.Parameters.Add("@Oby", SqlDbType.VarChar).Value = lblname.Text
                        cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = Cboclinic.Text

                        cmd.Connection = con
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try

                    Me.Close()
                Else
                    txtdiagnosis.Focus()
                End If
            End If
        End If

    End Sub
    Sub ADmitAndSurgery()
        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
            txtdiagnosis.Focus()
        Else

            Try

                cmd = New SqlCommand("INSERT INTO AdmissionRequest VALUES(@dte, @Tim, @Hnum, @Sname, @Oname,@Sex, @Age, @Diag, @Adt, @Wrd, @Ins, @Oby, @Cli)", con)

                cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldat.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiagnosis.Text
                cmd.Parameters.Add("@Adt", SqlDbType.VarChar).Value = Cboadmtyp.Text
                cmd.Parameters.Add("@Wrd", SqlDbType.VarChar).Value = cboward.Text
                cmd.Parameters.Add("@Ins", SqlDbType.VarChar).Value = txtinstr.Text
                cmd.Parameters.Add("@Oby", SqlDbType.VarChar).Value = lblname.Text
                cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = Cboclinic.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                '////// Surgery
                PopulateSUrgery()

                MsgBox("ADMISSION AND SURGERY REQUEST SENT SUCCESFULLY?", MsgBoxStyle.YesNo, "Medx-Pro")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Me.Close()
        End If
    End Sub
    Sub PopulateSUrgery()
        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
            txtdiagnosis.Focus()

        Else

            Try

                cmd = New SqlCommand("INSERT INTO Surgery_Request VALUES(@dte, @Tim, @Hnum, @Sname, @Oname,@Sex, @Age, @Diag, @Opr, @Sdat, @Ins, @Oby, @Cli, @Stat, @Acct, @AcctTyp)", con)

                cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldat.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiagnosis.Text
                cmd.Parameters.Add("@Opr", SqlDbType.VarChar).Value = Txtoper.Text
                cmd.Parameters.Add("@Sdat", SqlDbType.Date).Value = DtSurg.Value.Date
                cmd.Parameters.Add("@Ins", SqlDbType.VarChar).Value = txtinstr.Text
                cmd.Parameters.Add("@Oby", SqlDbType.VarChar).Value = lblname.Text
                cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = Cboclinic.Text
                cmd.Parameters.Add("@Stat", SqlDbType.VarChar).Value = Lblstat.Text
                cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtaccount.Text
                cmd.Parameters.Add("@AcctTyp", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("SURGERY REQUEST SENT SUCCESFULLY?", MsgBoxStyle.YesNo, "Medx-Pro")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Me.Close()
        End If
    End Sub
    Public Sub showusername()

        '==============CHECK USER VALIDITY
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbls As New DataTable()

        adpt.Fill(tbls)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbls.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "User Validation")
            Txtpass.Focus()
        Else

            '// Show users name after log in, this method will be called on frmlogin LOGIN button
            cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = Txtpass.Text

            Dim adpts As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then

                'Display the person data

                lblname.Text = tbl.Rows(0)(1).ToString()

            Else
            End If

        End If

    End Sub
    Private Sub Btnorderadmit_Click(sender As Object, e As EventArgs) Handles Btnorderadmit.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO ADMIT THIS PATIENT?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd = New SqlCommand("INSERT INTO AdmissionRequest VALUES(@dt, @Tm, @Hnu, @Snam, @Onam, @Sx, @Ag, @Dig, @Adm, @Wd, @Inst, @Ob, @Clin)", con)

                    cmd.Parameters.Add("@dt", SqlDbType.Date).Value = Convert.ToDateTime(lbldat.Text).Date
                    cmd.Parameters.Add("@Tm", SqlDbType.VarChar).Value = lbltim.Text
                    cmd.Parameters.Add("@Hnu", SqlDbType.Int).Value = FrmPtRecords.Lblhopnum.Text
                    cmd.Parameters.Add("@snam", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                    cmd.Parameters.Add("@onam", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                    cmd.Parameters.Add("@Sx", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                    cmd.Parameters.Add("@Ag", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                    cmd.Parameters.Add("@Dig", SqlDbType.NVarChar).Value = txtdiagnosis.Text
                    cmd.Parameters.Add("@Adm", SqlDbType.VarChar).Value = Cboadmtyp.Text
                    cmd.Parameters.Add("@Wd", SqlDbType.VarChar).Value = cboward.Text
                    cmd.Parameters.Add("@Inst", SqlDbType.VarChar).Value = txtinstr.Text
                    cmd.Parameters.Add("@ob", SqlDbType.VarChar).Value = lblname.Text
                    cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = Cboclinic.Text

                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                Me.Close()
            Else
                txtdiagnosis.Focus()
            End If
        End If

    End Sub
    Public Sub showAllwards()
        Dim tb As New DataTable
        cmd = New SqlCommand("Select DISTINCT Ward_Name FROM Bedlist WHERE Bed_Status='Free'", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        cboward.DataSource = tb
        cboward.DisplayMember = "Ward_Name"

    End Sub
    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        showusername()
    End Sub
    Public Sub CboclinicItems()
        Me.Cboclinic.Items.Add("GOPD")
        Me.Cboclinic.Items.Add("ORTHOPEDIC")
        Me.Cboclinic.Items.Add("PRIVATE WARD")
        Me.Cboclinic.Items.Add("GENERAL WARD")

    End Sub

End Class