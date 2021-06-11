Imports System.Data.SqlClient

Public Class FrmANCreg

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtsurname.Text = tbl.Rows(0)(1).ToString()
            txtothernames.Text = tbl.Rows(0)(2).ToString()
            txtaccount.Text = tbl.Rows(0)(7).ToString()
            txtsex.Text = tbl.Rows(0)(9).ToString()
            txtmarital.Text = tbl.Rows(0)(10).ToString()
            txtreli.Text = tbl.Rows(0)(11).ToString()
            txtoccup.Text = tbl.Rows(0)(12).ToString()
            txtlga.Text = tbl.Rows(0)(13).ToString()
            txtstate.Text = tbl.Rows(0)(14).ToString()
            txtnat.Text = tbl.Rows(0)(15).ToString()
            txtadd.Text = tbl.Rows(0)(16).ToString()
            txtphone.Text = tbl.Rows(0)(17).ToString()
            txtacctcat.Text = tbl.Rows(0)(23).ToString()
            txtenrolletype.Text = tbl.Rows(0)(24).ToString()
            txtemployer.Text = tbl.Rows(0)(25).ToString()
            txtenrolnum.Text = tbl.Rows(0)(26).ToString()

            LOADPTAGe()
        Else
            MsgBox("HOSPITAL NUMBER DOES NOT EXIST, PLEASE REGISTER", MsgBoxStyle.OkOnly, "ANC REGISTER")

        End If

    End Sub

    Private Sub LOADPTAGe()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtyear.Text = tbl.Rows(0)(4).ToString()
            Txtdob.Text = tbl.Rows(0)(3)
        End If
    End Sub

    Private Sub BtnCls_Click(sender As Object, e As EventArgs) Handles BtnCls.Click
        Me.Close()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If txtsex.Text = "Male" Then
            MsgBox("THIS IS A MALE PATIENT AND CANNOT BE BOOKED FOR ANC", MsgBoxStyle.Information, "Medx-pro")

            '// VAlidate Husband Info
        ElseIf txthusadd.Text = "" Or
            txthusempl.Text = "" Or
            txthusname.Text = "" Or
            txtHusoccup.Text = "" Or
            txthusphone.Text = "" Then

            MsgBox("PLEASE COMPLETE HER HUSBAND DETAILS", MsgBoxStyle.Information, "Medx-pro")

            txthusname.Focus()

        Else
            '// Check If pt has been register 
            Dim cmd As New SqlCommand("Select * from ANCRegister where Hospital_Num = '" & txtsearch.Text & "' AND Delivery_Status = '" & lblstatus.Text & "'", con)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then
                MsgBox("PATIENT HAS AN ACTIVE ANC BOOKING", MsgBoxStyle.Critical, "Medx-pro")
                txtsearch.Focus()
            Else
                '//Validate passord

                If Txtpword.Text = "" Then
                    MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
                    txtsearch.Focus()
                Else

                    '//Insert details 
                    Try

                        'cmd.CommandType = System.Data.CommandType.Text 
                        'cmd.CommandText = "insert into ANCRegister values ('" & dtreg.Value & "', '" & txtsearch.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & Txtdob.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtmarital.Text & "', '" & txtreli.Text & ", '" & txtoccup.Text & "', '" & txtlga.Text & "', '" & txtstate.Text & "', '" & txtnat.Text & "', '" & txtadd.Text & "', '" & txtphone.Text & "', '" & txtaccount.Text & "', '" & txtacctcat.Text & "', '" & txtenrolletype.Text & "', '" & txtemployer.Text & "', '" & txtenrolnum.Text & "', '" & txthusname.Text & "', '" & txthusadd.Text & "', '" & txthusphone.Text & "', '" & txtHusoccup.Text & "', '" & txthusempl.Text & "', '" & lbluser.Text & "','" & lblstatus.Text & "')"

                        cmd = New SqlCommand("INSERT INTO ANCRegister VALUES(@Regdte, @Hnum, @Sname, @Oname, @Dob, @Age,@Sex, @Mar, @Rel, @Occ, @lga, @Sta, @nat, @adr, @Pho, @Acct, @Cat, @Enr, @Empl, @EnrNo, @Hname, @Hadr, @Hpho, @Hocp, @Hempl, @User, @DStat)", con)

                        cmd.Parameters.Add("@Regdte", SqlDbType.Date).Value = dtreg.Value.Date
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = txtsearch.Text
                        cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsurname.Text
                        cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = txtothernames.Text
                        cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = Txtdob.Text
                        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = txtyear.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                        cmd.Parameters.Add("@Mar", SqlDbType.VarChar).Value = txtmarital.Text
                        cmd.Parameters.Add("@Rel", SqlDbType.VarChar).Value = txtreli.Text
                        cmd.Parameters.Add("@Occ", SqlDbType.VarChar).Value = txtoccup.Text
                        cmd.Parameters.Add("@lga", SqlDbType.VarChar).Value = txtlga.Text
                        cmd.Parameters.Add("@Sta", SqlDbType.VarChar).Value = txtstate.Text
                        cmd.Parameters.Add("@Nat", SqlDbType.VarChar).Value = txtnat.Text
                        cmd.Parameters.Add("@Adr", SqlDbType.VarChar).Value = txtadd.Text
                        cmd.Parameters.Add("@Pho", SqlDbType.VarChar).Value = txtphone.Text
                        cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = txtaccount.Text
                        cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = txtacctcat.Text
                        cmd.Parameters.Add("@Enr", SqlDbType.VarChar).Value = txtenrolletype.Text
                        cmd.Parameters.Add("@Empl", SqlDbType.VarChar).Value = txtemployer.Text
                        cmd.Parameters.Add("@Enrno", SqlDbType.VarChar).Value = txtenrolnum.Text
                        cmd.Parameters.Add("@Hname", SqlDbType.VarChar).Value = txthusname.Text
                        cmd.Parameters.Add("@Hadr", SqlDbType.VarChar).Value = txthusadd.Text
                        cmd.Parameters.Add("@Hpho", SqlDbType.VarChar).Value = txthusphone.Text
                        cmd.Parameters.Add("@Hocp", SqlDbType.VarChar).Value = txtHusoccup.Text
                        cmd.Parameters.Add("@Hempl", SqlDbType.VarChar).Value = txthusempl.Text
                        cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = lbluser.Text
                        cmd.Parameters.Add("@DStat", SqlDbType.VarChar).Value = lblstatus.Text

                        cmd.Connection = con

                        con.Open()
                        cmd.ExecuteNonQuery()

                        MsgBox("NEW ANC PATIENT REGISTERED", MsgBoxStyle.Information, "Medx-pro")



                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                    con.Close()

                    BookAncAppointmnt()
                    populatevitals()
                    Cleaentries()
                    Me.Close()
                End If
            End If
        End If

        Frmrecords.sortApptfolder()
        frmNursing.sortvitalssigns()



    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "ANC REGISTER")
            Txtpword.Focus()

        Else
            lbluser.Text = tbl.Rows(0)(1).ToString()

        End If
    End Sub

    Private Sub Txtpword_Leave(sender As Object, e As EventArgs) Handles Txtpword.Leave
        CheckPassowrd()
    End Sub

    Private Sub Cleaentries()
        txtsearch.Text = ""
        txtsurname.Text = ""
        txtothernames.Text = ""
        txtaccount.Text = ""
        txtyear.Text = ""
        txtsex.Text = ""
        txtmarital.Text = ""
        txtoccup.Text = ""
        txtemployer.Text = ""
        txtacctcat.Text = ""
        txtphone.Text = ""
        txtlga.Text = ""
        txtstate.Text = ""
        txtnat.Text = ""
        txtenrolletype.Text = ""
        txtenrolnum.Text = ""
        txthusadd.Text = ""
        txthusempl.Text = ""
        txthusname.Text = ""
        txtHusoccup.Text = ""
        txthusphone.Text = ""
        Txtpword.Text = ""
        lbluser.Text = ""
    End Sub

    Private Sub BookAncAppointmnt()
        Try
            'cmd.CommandText = "insert into Appntmnt values ('" & dtreg.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & lblclinic.Text & "', '" & txtacctcat.Text & "')"

            cmd = New SqlCommand("INSERT INTO Appntmnt VALUES(@Aptdate, @Apttime, @Sname, @Oname, @hno, @Age, @Sex, @Act, @Cli, @Cat)", con)

            cmd.Parameters.Add("@Aptdate", SqlDbType.Date).Value = dtreg.Value.Date
            cmd.Parameters.Add("@Apttime", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = txtothernames.Text
            cmd.Parameters.Add("@hno", SqlDbType.VarChar).Value = txtsearch.Text
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = txtyear.Text
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = txtaccount.Text
            cmd.Parameters.Add("@cli", SqlDbType.VarChar).Value = lblclinic.Text
            cmd.Parameters.Add("@cat", SqlDbType.VarChar).Value = txtacctcat.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            'MsgBox("SUCCESSFUL", MsgBoxStyle.Information, "APPOINTMENT")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub populatevitals()

        '//  Populate the Pending vital signs table
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pending_Vitals values ('" & dtreg.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & lblclinic.Text & "', '" & txtacctcat.Text & "')"
            cmd = New SqlCommand("INSERT INTO Pending_Vitals VALUES(@Apdate, @Aptime, @Snme, @Onme, @hnu, @Ag, @Sx, @Acct, @Clin, @Cate)", con)

            cmd.Parameters.Add("@Apdate", SqlDbType.Date).Value = dtreg.Value.Date
            cmd.Parameters.Add("@Aptime", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@snme", SqlDbType.VarChar).Value = txtsurname.Text
            cmd.Parameters.Add("@onme", SqlDbType.VarChar).Value = txtothernames.Text
            cmd.Parameters.Add("@hnu", SqlDbType.VarChar).Value = txtsearch.Text
            cmd.Parameters.Add("@Ag", SqlDbType.Int).Value = txtyear.Text
            cmd.Parameters.Add("@Sx", SqlDbType.VarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = txtaccount.Text
            cmd.Parameters.Add("@clin", SqlDbType.VarChar).Value = lblclinic.Text
            cmd.Parameters.Add("@cate", SqlDbType.VarChar).Value = txtacctcat.Text

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub FrmANCreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If Txtpword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medp-pro")
            txtsearch.Focus()
        Else

            Try
                'Dim Updat As String = "Update ANCRegister Set Husband_Name='" & txthusname.Text & "', Husband_Address='" & txthusadd.Text & "', Husband_Phone ='" & txthusphone.Text & "', Husband_Occupation='" & txtHusoccup.Text & "', Husband_Employer='" & txthusempl.Text & "', Registered_By= '" & lbluser.Text + " Edited Record " & "'  WHERE Hospital_Num='" & txtsearch.Text & "'"

                cmd = New SqlCommand("UPDATE ANCRegister SET Husband_Name=@Hname, Husband_Address=@Hadr, Husband_Phone=@Hphn, Husband_Occupation=@Hocc, Husband_Employer=@hEmpl, Registered_By=@edby WHERE Hospital_Num='" & txtsearch.Text & "'")

                cmd.Parameters.Add("@Hname", SqlDbType.VarChar).Value = txthusname.Text
                cmd.Parameters.Add("@Hadr", SqlDbType.VarChar).Value = txthusadd.Text
                cmd.Parameters.Add("@Hphn", SqlDbType.VarChar).Value = txthusphone.Text
                cmd.Parameters.Add("@Hocc", SqlDbType.VarChar).Value = txtHusoccup.Text
                cmd.Parameters.Add("@Hempl", SqlDbType.VarChar).Value = txthusempl.Text
                cmd.Parameters.Add("@Edby", SqlDbType.VarChar).Value = lbluser.Text + " Edited Patient Record"


                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("ANC REGISTERED HAS BEEN UPDATED", "Medx-pro", MessageBoxButtons.OK)


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Me.Close()
        End If
    End Sub


End Class