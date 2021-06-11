Imports System.Data.SqlClient
Public Class FrmNewAdmit
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmNewAdmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAllwards()
    End Sub

    Public Sub ShowFreeBeds()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Bed_No FROM Bedlist WHERE Ward_Name = '" & cboward.Text & "' AND Bed_Status='Free'", con)

        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tb)
        cbobedno.DataSource = tb
        cbobedno.DisplayMember = "Bed_No"
        ' con.Close()

    End Sub

    Public Sub showAllwards()
        Dim tb As New DataTable
        cmd = New SqlCommand("Select DISTINCT Ward_Name FROM Bedlist WHERE Bed_Status='Free'", con)

        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tb)
        cboward.DataSource = tb
        cboward.DisplayMember = "Ward_Name"

        ShowFreeBeds()
        ' con.Close()
    End Sub

    Private Sub cboward_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboward.SelectedIndexChanged
        ShowFreeBeds()
    End Sub

    '==Note update all show users with the below method on every form where password is required
    Public Sub showusername()

        '==============CHECK USER VALIDITY
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "User Validation")
            Txtpass.Focus()
        Else

            '// Show users name after log in, this method will be called on frmlogin LOGIN button
            cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = Txtpass.Text

            Dim adpts As New SqlDataAdapter(cmd)
            Dim tbls As New DataTable()

            adpt.Fill(tbls)

            If tbls.Rows.Count() > 0 Then

                'Display the person data

                Lbluser.Text = tbls.Rows(0)(1).ToString()

            Else

            End If
        End If

    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        showusername()
    End Sub

    Private Sub BtnAdmit_Click(sender As Object, e As EventArgs) Handles BtnAdmit.Click

        If Txtsex.Text = "Female" And cboward.Text = "MALE WARD" Then
            MsgBox("PATIENT IS A FEMALE AND CANNOT BE ADMITTED INTO MALE WARD", MsgBoxStyle.Critical, "Medx-pro")
            Txthospnum.Focus()

        ElseIf Txtsex.Text = "Male" And cboward.Text = "FEMALE WARD" Then
            MsgBox("PATIENT IS A MALE AND CANNOT BE ADMITTED INTO FEMALE WARD", MsgBoxStyle.Critical, "Medx-pro")
            Txthospnum.Focus()

        ElseIf Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
            Else

                Dim res As MsgBoxResult
                res = MsgBox(" DO YOU WANT TO ADMIT" + " " + txtsname.Text + " " + TxtOname.Text + ", IN " + cboward.Text + " BED(" + cbobedno.Text + ")", MsgBoxStyle.YesNo, "Medx-Pro")
                If (res = MsgBoxResult.Yes) Then

                Try

                    ' cmd.CommandType = System.Data.CommandType.Text
                    'cmd.CommandText = "insert into Admitted values ('" & Lbladmitid.Text & "', '" & Dtdate.Value & "', '" & dtTime.Value.ToShortTimeString & "', '" & Txthospnum.Text & "', '" & txtsname.Text & "', '" & TxtOname.Text & "', '" & Txtsex.Text & "', '" & Txtage.Text & "', '" & Txtdiag.Text & "', '" & Txtinstr.Text & "', 
                    '" & Txtadmtyp.Text & "', '" & cboward.Text & "', '" & cbobedno.Text & "', '" & Lbluser.Text & "', '" & Txtcons.Text & "', '" & Txtclinic.Text & "', '" & Lblstatus.Text & "')"

                    cmd = New SqlCommand("INSERT INTO Admitted VALUES(@Aid, @Dte, @tim, @Hnum, @Sname, @Oname, @Sex, @Age, @Dia, @Ins, @AdT, @wrd, @bdno, @Adby, @con, @cli, @Sta, @Disdat)", con)

                    cmd.Parameters.Add("@Aid", SqlDbType.Int).Value = Lbladmitid.Text
                    cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Dtdate.Value.Date
                    cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = dtTime.Value.ToShortTimeString
                    cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = Txthospnum.Text
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsname.Text
                    cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = TxtOname.Text
                    cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = Txtsex.Text
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Txtage.Text
                    cmd.Parameters.Add("@Dia", SqlDbType.NVarChar).Value = Txtdiag.Text
                    cmd.Parameters.Add("@ins", SqlDbType.VarChar).Value = Txtinstr.Text
                    cmd.Parameters.Add("@AdT", SqlDbType.VarChar).Value = Txtadmtyp.Text
                    cmd.Parameters.Add("@Wrd", SqlDbType.VarChar).Value = cboward.Text
                    cmd.Parameters.Add("@Bdno", SqlDbType.Int).Value = cbobedno.Text
                    cmd.Parameters.Add("@Adby", SqlDbType.VarChar).Value = Lbluser.Text
                    cmd.Parameters.Add("@Con", SqlDbType.VarChar).Value = Txtcons.Text
                    cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = Txtclinic.Text
                    cmd.Parameters.Add("@Sta", SqlDbType.VarChar).Value = Lblstatus.Text
                    cmd.Parameters.Add("@Disdat", SqlDbType.VarChar).Value = DBNull.Value

                    cmd.Connection = con

                    con.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

                UpdateBedList()

                removefrompending()
                Me.Close()
                con.Close()
            Else
                    Txthospnum.Focus()
                End If
            End If

        FrmWardManager.LoadAdmitreqst()
        FrmWardManager.LoadPTonadmission()
        FrmWardManager.LoadDischargedPT()
    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From AdmissionRequest Where Hospital_Num = '" & Txthospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Sub UpdateBedList()
        cmd = New SqlCommand("UPDATE Bedlist SET Bed_Status='Occupied' WHERE Bed_No=@BdNo AND Ward_Name=@Wname")

        cmd.Parameters.Add("@Bdno", SqlDbType.Int).Value = cbobedno.Text
        cmd.Parameters.Add("@Wname", SqlDbType.NVarChar).Value = cboward.Text

        cmd.Connection = con
        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class

