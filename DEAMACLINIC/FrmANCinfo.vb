Imports System.Data.SqlClient
Public Class FrmANCinfo

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Btnaddentry_Click(sender As Object, e As EventArgs) Handles Btnaddentry.Click
        If DtDeliv.Value.Date >= Now.Date Then
            MsgBox("PLEASE CHOOSE A CORRECT DELIVERY DATE", MsgBoxStyle.Critical, "Medx-pro: ANC")
        Else

            DTgpreg.Rows.Add(FrmANCform.lblbkid.Text, FrmANCform.lblhospnum.Text, DtDeliv.Value.ToShortDateString, txtduration.Text, txtcompl.Text, txtlabor.Text, cbosex.Text, txtppm.Text, txtweight.Text)

            txtweight.Text = ""
            txtcompl.Text = ""
            txtlabor.Text = ""
            cbosex.Text = ""
            txtppm.Text = ""
            txtweight.Text = ""
            txtduration.Text = ""


        End If
    End Sub

    Public Sub SavePrevPregnancyHX()

        Try
            For Each row As DataGridViewRow In DTgpreg.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO ANCPREVPREG VALUES(@Bid, @Hnum, @DelDt, @Dura, @Com, @Labr, @Sexx, @Puepn, @Bw, @user)", con)

                        cmd.Parameters.AddWithValue("@Bid", row.Cells("Bkid").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.AddWithValue("@Hnum", row.Cells("HospNo").Value)
                        cmd.Parameters.AddWithValue("@Deldt", row.Cells("Delvdate").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Dura", row.Cells("Dur").Value)
                        cmd.Parameters.AddWithValue("@Com", row.Cells("Comp").Value)
                        cmd.Parameters.AddWithValue("@Labr", row.Cells("Lab").Value)
                        cmd.Parameters.AddWithValue("@Sexx", row.Cells("Sex").Value)
                        cmd.Parameters.AddWithValue("@Puepn", row.Cells("Puep").Value)
                        cmd.Parameters.AddWithValue("@Bw", row.Cells("Bthw").Value)
                        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = lbluser.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        ' con.Close()
                    End Using
                End Using
            Next

            DTgpreg.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SAveBooking()
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into ANCBooking Values ('" & FrmANCform.lblbkid.Text & "','" & FrmANCform.lblhospnum.Text & "',  '" & DtBooked.Value & "', '" & DtLMP.Value & "', '" & DtEDD.Value & "', '" & txtGrav.Text & "', '" & TxtPar.Text & "', '" & txtindication.Text & "', 
            '" & Txtspecpoint.Text & "', '" & Txtconsultant.Text & "', '" & txtbleed.Text & "', '" & Txtdisch.Text & "', '" & TxtSwell.Text & "', '" & TxtUsymp.Text & "', '" & TxtOsympt.Text & "', '" & TxtGencond.Text & "', '" & TxtBres.Text & "', '" & Txtcvc.Text & "', '" & TxtAbdom.Text & "', '" & TxtxRs.Text & "', '" & Txtpelvis.Text & "', '" & Txtothers.Text & "', '" & cbogen.Text & "', '" & CboBldgp.Text & "', '" & CboGrpRH.Text & "', '" & Txtretrov.Text & "','" & TxtVdrl.Text & "','" & TxtHb.Text & "', '" & txtBP.Text & "', '" & Txturin.Text & "', '" & Txtheight.Text & "', '" & Txtwght.Text & "', '" & TxtPeupInstr.Text & "', '" & TxtHtDis.Text & "', '" & TxtChestDis.Text & "', '" & TxtKidnDis.Text & "', '" & TxtBldTrans.Text & "', '" & TxtOper.Text & "', '" & TxtMultPre.Text & "', '" & Txttuber.Text & "', '" & TxtHyper.Text & "', '" & Txtothers.Text & "', '" & lbluser.Text & "', '" & txtdelivsta.Text & "')"
            cmd = New SqlCommand("INSERT INTO ANCBooking VALUES(@Bkid, @Hnum, @Bkdte, @LmpDte, @Eddte, @Grv, @Par, @ind, @Spec, @Con, @Ble, @Disch, @Swe, @UrS, @Os, @GenC, @Brs, @Cv, @Abd, @Rs, @Pel, @Oth, @GenT, @BG, @Grh, @Ret, @Vdr, @Hb, @Bpp, @Uri, @hgt, @Wgt, @Pin, @HrtD, @ChD, @Kid, @BlT, @Opr, @Mul, @Tub, @Hyp, @Ohx, @EntB, @DSt)", con)

            cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = FrmANCform.lblbkid.Text
            cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
            cmd.Parameters.Add("@Bkdte", SqlDbType.Date).Value = DtBooked.Value.Date
            cmd.Parameters.Add("@LmpDte", SqlDbType.Date).Value = DtLMP.Value.Date
            cmd.Parameters.Add("@Eddte", SqlDbType.Date).Value = DtEDD.Value.Date
            cmd.Parameters.Add("@Grv", SqlDbType.Int).Value = txtGrav.Text
            cmd.Parameters.Add("@Par", SqlDbType.Int).Value = TxtPar.Text
            cmd.Parameters.Add("@Ind", SqlDbType.NVarChar).Value = txtindication.Text
            cmd.Parameters.Add("@Spec", SqlDbType.NVarChar).Value = Txtspecpoint.Text
            cmd.Parameters.Add("@Con", SqlDbType.VarChar).Value = Txtconsultant.Text
            cmd.Parameters.Add("@Ble", SqlDbType.NChar).Value = txtbleed.Text
            cmd.Parameters.Add("@Disch", SqlDbType.NChar).Value = Txtdisch.Text
            cmd.Parameters.Add("@Swe", SqlDbType.NChar).Value = TxtSwell.Text
            cmd.Parameters.Add("@Urs", SqlDbType.VarChar).Value = TxtUsymp.Text
            cmd.Parameters.Add("@Os", SqlDbType.VarChar).Value = TxtOsympt.Text
            cmd.Parameters.Add("@GenC", SqlDbType.VarChar).Value = TxtGencond.Text
            cmd.Parameters.Add("@Brs", SqlDbType.NChar).Value = TxtBres.Text
            cmd.Parameters.Add("@Cv", SqlDbType.VarChar).Value = Txtcvc.Text
            cmd.Parameters.Add("@Abd", SqlDbType.VarChar).Value = TxtAbdom.Text
            cmd.Parameters.Add("@Rs", SqlDbType.VarChar).Value = TxtxRs.Text
            cmd.Parameters.Add("@Pel", SqlDbType.VarChar).Value = Txtpelvis.Text
            cmd.Parameters.Add("@Oth", SqlDbType.VarChar).Value = Txtothers.Text
            cmd.Parameters.Add("@GenT", SqlDbType.VarChar).Value = cbogen.Text
            cmd.Parameters.Add("@BG", SqlDbType.VarChar).Value = CboBldgp.Text
            cmd.Parameters.Add("@Grh", SqlDbType.VarChar).Value = CboGrpRH.Text
            cmd.Parameters.Add("@Ret", SqlDbType.VarChar).Value = Txtretrov.Text
            cmd.Parameters.Add("@Vdr", SqlDbType.VarChar).Value = TxtVdrl.Text
            cmd.Parameters.Add("@Hb", SqlDbType.VarChar).Value = TxtHb.Text
            cmd.Parameters.Add("@Bpp", SqlDbType.VarChar).Value = txtBP.Text
            cmd.Parameters.Add("@Uri", SqlDbType.VarChar).Value = Txturin.Text
            cmd.Parameters.Add("@Hgt", SqlDbType.VarChar).Value = Txtheight.Text
            cmd.Parameters.Add("@Wgt", SqlDbType.VarChar).Value = Txtwght.Text
            cmd.Parameters.Add("@Pin", SqlDbType.VarChar).Value = TxtPeupInstr.Text
            cmd.Parameters.Add("@HrtD", SqlDbType.VarChar).Value = TxtHtDis.Text
            cmd.Parameters.Add("@Chd", SqlDbType.VarChar).Value = TxtChestDis.Text
            cmd.Parameters.Add("@Kid", SqlDbType.VarChar).Value = TxtKidnDis.Text
            cmd.Parameters.Add("@BlT", SqlDbType.VarChar).Value = TxtBldTrans.Text
            cmd.Parameters.Add("@Opr", SqlDbType.VarChar).Value = TxtOper.Text
            cmd.Parameters.Add("@Mul", SqlDbType.VarChar).Value = TxtMultPre.Text
            cmd.Parameters.Add("@Tub", SqlDbType.VarChar).Value = Txttuber.Text
            cmd.Parameters.Add("@Hyp", SqlDbType.VarChar).Value = TxtHyper.Text
            cmd.Parameters.Add("@Ohx", SqlDbType.VarChar).Value = Txtothers.Text
            cmd.Parameters.Add("@EntB", SqlDbType.VarChar).Value = lbluser.Text
            cmd.Parameters.Add("@Dst", SqlDbType.VarChar).Value = txtdelivsta.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub DtLMP_ValueChanged(sender As Object, e As EventArgs) Handles DtLMP.ValueChanged
        '// To Compute the expeted delivery date, Oxford handbook suugest this callculation
        '//Usual cycle length; LMP (a normal period?); Naegele's rule: expected delivery date â‰ˆ1yr and 7 days after LMP minus 3 months”
        '//(not if last period a Pill withdrawal bleed; for cycles shorter than 28 days subtract the difference from 28; 
        '//If longer Then, add the difference from 28). 
        '// A revised rule suggests the addition Of 10 days rather than 7 Is more accurate.
        '// I adopt the revise rule here.

        '====Prevent Users from selecting future date for LMP.

        If DtLMP.Value > DateTime.Today Then
            MsgBox("YOU CANNOT CHOOSE FUTURE DATE", MsgBoxStyle.Critical, "Medx-pro : INVALID LMP DATE")
            DtLMP.MaxDate = DateTime.Today
            DtLMP.Focus()
        Else
            '=======================
            Dim d As Date = DtLMP.Value
            Dim b As Date
            d = d.AddDays(+375)
            b = d.AddDays(-90)
            DtEDD.Value = b

            '// Now To get the Geatstational  Age, is the age of the pregnancy from the last normal menstrual period (LMP)
            '// I also Add this to the LOad event of the ANCbooking form, so the it will be gotten base on the LMP date loaded

            Dim d1, d2 As Date
            Dim tt As TimeSpan
            Dim ga As Integer
            d1 = DtLMP.Value
            d2 = Now.Date
            tt = d2 - d1
            ga = tt.Days / 7

            Txtgest.Text = ga

        End If
    End Sub

    Private Sub FrmANCinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// Now To get the Geatstational  Age, is the age of the pregnancy from the last normal menstrual period (LMP)

        Me.MdiParent = frmMain

        Dim d1, d2 As Date
        Dim tt As TimeSpan
        Dim ga As Integer
        d1 = DtLMP.Value
        d2 = Now.Date
        tt = d2 - d1
        ga = tt.Days / 7

        Txtgest.Text = ga

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lbluser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpass.Focus()


        Else

        End If
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs)
        CheckPassowrd()
        showusername()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "ANC")

        Else

            Dim msg As String

            msg = MsgBox("ARE YOU SURE YOU WANT TO SAVE DETAILS ?", vbYesNo, "ANC")

            If msg = vbYes Then

                SAveBooking()
                SavePrevPregnancyHX()

                MsgBox("PATIENT BOOKING DETAILS SAVED SUCCESSFULLY", MsgBoxStyle.Information, "ANC")
                Me.Close()
            Else
                TxtPar.Focus()

            End If
        End If

    End Sub

    '//

End Class