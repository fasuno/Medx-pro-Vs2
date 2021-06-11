Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmLabResult

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        'con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub LoadPatientTest()
        '// I have to call this function from FRMLABORATORY to enable me handle review
        '// SO that request number is loaded first and i can use it to query test

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Test_Name FROM LabRequest WHERE Request_Num=@Rqnum", con)
        ' cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = frmLABORATORY.Dtgbiiled.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = lblrqstnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        DtgTest.DataSource = tbls
        DtgTest.AutoResizeColumns()

    End Sub

    Private Sub frmLabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPatientTest()
        Dtgresults.DataSource = Nothing
        lbltestname.Text = ""
        lbldte.Text = Date.Now.Date
        lbltim.Text = TimeOfDay
        lbltestname.Text = ""
        txtpassw.Text = ""
        Txtnote.Text = ""
        lblreportby.Text = ""
        LoadNotes()
        LoadWhoReview()
    End Sub

    Private Sub DtgTest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgTest.CellClick

        lbltestname.Text = DtgTest.CurrentRow.Cells(0).Value

        cmd = New SqlCommand("Select Test, Result, Ref_value, Measure from VwLabTestDetails Where Test_Name=@Test", con)
        cmd.Parameters.Add("@Test", SqlDbType.VarChar).Value = DtgTest.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgresults.DataSource = tbl


            Dtgresults.Columns(0).DefaultCellStyle.ForeColor = Color.Navy
            Dtgresults.Columns(2).DefaultCellStyle.ForeColor = Color.Navy
            Dtgresults.Columns(0).ReadOnly = True
            Dtgresults.Columns(2).ReadOnly = True
            Dtgresults.Columns(3).ReadOnly = True

        End If

        con.Close()
        Dtgresults.Columns(1).Width = 355
        Dtgresults.Columns(2).Width = 150


        loadcurrentresult()
        ' LoadWhoreport()
    End Sub

    Public Sub UpdateResultentry()

        Try
            Dim Updat As String = "Update LABRESULTS Set Result='" & Dtgresults.CurrentRow.Cells(1).Value & "' Where Request_Num='" & lblrqstnum.Text & "' AND Test_Parameters='" & Dtgresults.CurrentRow.Cells(0).Value & "'"

            'con.Open()
            ExecuteQuery(Updat)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub SaveLabresults()

        Try

            For Each row As DataGridViewRow In Dtgresults.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO LABRESULTS VALUES(@RqstNum, @Daterpt, @Timerpt, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Accntcat, @TestName, @Testpara, @Rslt, @Rnge, @Meas, @Reportby, @Daterqst, @RqstBy, @Note, @revwBy)", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxe and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once

                        cmd.Parameters.Add("@RqstNum", SqlDbType.Int).Value = lblrqstnum.Text
                        cmd.Parameters.Add("@Daterpt", SqlDbType.Date).Value = lbldte.Text
                        cmd.Parameters.Add("@Timerpt", SqlDbType.VarChar).Value = lbltim.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = txtHnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = TxtSname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = txtOname.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = txtage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = txtacct.Text
                        cmd.Parameters.Add("@Accntcat", SqlDbType.VarChar).Value = Txtactcat.Text

                        cmd.Parameters.Add("@TestName", SqlDbType.VarChar).Value = DtgTest.CurrentRow.Cells(0).Value
                        ' cmd.Parameters.AddWithValue("@TestName", row.Cells("Test_Name").Value) '// Insert the value in the Datagridview test name cell
                        cmd.Parameters.AddWithValue("@Testpara", row.Cells("Test").Value)
                        cmd.Parameters.AddWithValue("@Rslt", row.Cells("Result").Value)
                        cmd.Parameters.AddWithValue("@Rnge", row.Cells("Ref_Value").Value)
                        cmd.Parameters.AddWithValue("@Meas", row.Cells("Measure").Value)
                        cmd.Parameters.Add("@Reportby", SqlDbType.VarChar).Value = lblreportby.Text
                        cmd.Parameters.Add("@Daterqst", SqlDbType.Date).Value = TxtRqstdate.Text
                        cmd.Parameters.Add("@RqstBy", SqlDbType.VarChar).Value = txtRqstby.Text
                        cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = Txtnote.Text
                        cmd.Parameters.Add("@revwBy", SqlDbType.VarChar).Value = lblreviewby.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        ' con.Close()
                    End Using
                End Using
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub ConfirmAndSAVETESt() '// Dominion Method is breaktru method, i use it to avoid saving a test multiple times

        con.Open()

        cmd = New SqlCommand("Select * from LABRESULTS where Request_Num=@RqNum AND Test_Name=@Testname", con)


        cmd.Parameters.Add("@RqNum", SqlDbType.Int).Value = lblrqstnum.Text
        cmd.Parameters.Add("@Testname", SqlDbType.VarChar).Value = lbltestname.Text

        Using dtr As SqlDataReader = cmd.ExecuteReader

            If dtr.HasRows Then

                Dtgresults.Focus()

            Else

                dtr.Close()

                SaveLabresults()

                ' con.Close()

            End If
        End Using


    End Sub

    Private Sub Dtgresults_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgresults.CellEndEdit

        txtpassw.Enabled = True
        btnsave.Enabled = True

        ConfirmAndSAVETESt()
        UpdateResultentry()

    End Sub

    Public Sub loadcurrentresult()

        cmd = New SqlCommand("Select Test_Parameters,Result,Ref_Value,Measure from LABRESULTS where Request_Num=@RqsNum AND Test_Name=@Tname", con)

        cmd.Parameters.Add("@RqsNum", SqlDbType.Int).Value = lblrqstnum.Text
        cmd.Parameters.Add("@Tname", SqlDbType.VarChar).Value = DtgTest.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tabl As New DataTable

        adapt.Fill(tabl)
        If tabl.Rows.Count() > 0 Then
            Dtgresults.DataSource = tabl
            Dtgresults.Columns(0).DefaultCellStyle.ForeColor = Color.DarkBlue
        Else

        End If
        LoadWhoreport()
        LoadNotes()
    End Sub

    Public Sub LoadNotes()
        '// I have to call this function from FRMLABORATORY to enable me handle review
        '// SO that request number is loaded first and i can use it to query test

        cmd = New SqlCommand("Select * from LABRESULTS where Request_Num=@pRqsNum", con)
        ' cmd.Parameters.Add("@pRqsNum", SqlDbType.Int).Value = frmLABORATORY.Dtgbiiled.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("@pRqsNum", SqlDbType.Int).Value = lblrqstnum.Text


        Dim adpt As New SqlDataAdapter(cmd)
        Dim tabls As New DataTable()

        adpt.Fill(tabls)

        If tabls.Rows.Count() > 0 Then

            Txtnote.Text = tabls.Rows(0)(18).ToString()
            'lblreportby.Text = tabls.Rows(0)(14).ToString()

        Else
        End If

    End Sub

    Public Sub LoadWhoreport()

        cmd = New SqlCommand("Select * from LABRESULTS where Request_Num=@RqstsNum AND Test_Name=@Tnames", con)

        cmd.Parameters.Add("@RqstsNum", SqlDbType.Int).Value = lblrqstnum.Text
        cmd.Parameters.Add("@Tnames", SqlDbType.VarChar).Value = DtgTest.CurrentRow.Cells(0).Value

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tabls As New DataTable()

        adpt.Fill(tabls)

        If tabls.Rows.Count() > 0 Then


            lblreportby.Text = tabls.Rows(0)(15).ToString()

        Else
        End If

    End Sub

    Public Sub LoadWhoReview()

        cmd = New SqlCommand("Select * from LABRESULTS where Request_Num=@RqstsNum", con)

        cmd.Parameters.Add("@RqstsNum", SqlDbType.Int).Value = lblrqstnum.Text
        ' cmd.Parameters.Add("@Tnames", SqlDbType.VarChar).Value = DtgTest.CurrentRow.Cells(0).Value

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tabls As New DataTable()

        adpt.Fill(tabls)

        If tabls.Rows.Count() > 0 Then


            lblreviewby.Text = tabls.Rows(0)(19).ToString()

        Else
        End If

    End Sub

    Public Sub Updatereportby()

        Try
            Dim Updat As String = "Update LABRESULTS Set Reported_By='" & lblreportby.Text & "' Where Request_Num='" & lblrqstnum.Text & "'AND Test_Name='" & DtgTest.CurrentRow.Cells(0).Value & "' "

            con.Open()
            ExecuteQuery(Updat)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub UpdateReviewby() '// Place in Review Button

        Try
            Dim Updat As String = "Update LABRESULTS Set Reviewed_By='" & lblreviewby.Text & "' Where Request_Num='" & lblrqstnum.Text & "'"

            con.Open()
            ExecuteQuery(Updat)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub showReviewer()

        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpwordrev.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            lblreviewby.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

    End Sub '// Place in txtrev 

    Public Sub showScientistname()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            lblreportby.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

    End Sub

    Public Sub RemoveFromPendLabRqst()

        Dim Delquery As String = " Delete From Pend_LABBill Where Hospital_Num = '" & txtHnum.Text & "' AND Request_Num='" & lblrqstnum.Text & "'"

        con.Open()
        ExecuteQuery(Delquery)

    End Sub ' //Place in SAve button

    Public Sub PopulateLABTestReview()
        Try
            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into LabTestReview Values ('" & lblrqstnum.Text & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHnum.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "',  '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtacct.Text & "', '" & Txtactcat.Text & "',   '" & txtRqstby.Text & "', '" & TxtRqstdate.Text & "','" & lblreportby.Text & "')"

            cmd = New SqlCommand("INSERT INTO LabTestReview VALUES(@Rno, @Dte, @tim, @Hnum, @Sname, @Oname, @Age, @Sex, @Acct, @Cat, @Rby,  @Rdte, @Rptby)", con)

            cmd.Parameters.Add("@Rno", SqlDbType.Int).Value = lblrqstnum.Text
            cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldte.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
            cmd.Parameters.Add("@Hnum", SqlDbType.NVarChar).Value = txtHnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = txtage.Text
            cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = Txtactcat.Text
            cmd.Parameters.Add("@Rby", SqlDbType.VarChar).Value = txtRqstby.Text
            cmd.Parameters.Add("@Rdte", SqlDbType.Date).Value = Convert.ToDateTime(TxtRqstdate.Text).Date
            cmd.Parameters.Add("@Rptby", SqlDbType.VarChar).Value = lblreportby.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        con.Close()
    End Sub '// Place in SAve button

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpassw.Text = "" Then

            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "USER VALIDATION")
            txtpassw.Focus()
        Else

            CheckPassowrd()

            If chkcompl.Checked = True Then
                Updatereportby()
                PopulateLABTestReview()
                RemoveFromPendLabRqst()

                Me.Close()

            Else

                Updatereportby()
                Me.Close()

            End If
        End If
        frmLABORATORY.SortPendlabBill()
        frmLABORATORY.SortLAbTreated()
        frmLABORATORY.LoadLAbtestReview()
    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @Passw", con)

        cmd.Parameters.Add("@Passw", SqlDbType.VarChar).Value = txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpassw.Focus()

        Else

        End If
    End Sub

    Public Sub CheckPassowrdrev()

        cmd = New SqlCommand("Select * from UsersReg where Password = @Passw", con)

        cmd.Parameters.Add("@Passw", SqlDbType.VarChar).Value = txtpwordrev.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpwordrev.Focus()

        Else

        End If
    End Sub

    Private Sub Txtnote_Leave(sender As Object, e As EventArgs) Handles Txtnote.Leave
        Try
            Dim Updates As String = "Update LABRESULTS Set Note='" & Txtnote.Text & "' Where Request_Num='" & lblrqstnum.Text & "' "

            con.Open()
            ExecuteQuery(Updates)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub frmLabResult_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If txtpassw.Enabled = True And txtpassw.Text = "" Then

            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "USER VALIDATION")
            e.Cancel = True
            txtpassw.Focus()
        ElseIf txtpassw.Enabled = False Then
            e.Cancel = False


        End If
    End Sub

    Private Sub BtnReview_Click(sender As Object, e As EventArgs) Handles BtnReview.Click
        If txtpwordrev.Text = "" Then

            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpwordrev.Focus()
        Else

            'CheckPassowrd()
            UpdateReviewby()
            PopulateLABTreated()
            RemoveFromPreview()
            Me.Close()
        End If

        frmLABORATORY.SortPendlabBill()
        frmLABORATORY.SortLAbTreated()
        frmLABORATORY.LoadLAbtestReview()
    End Sub

    Private Sub txtpassw_Leave(sender As Object, e As EventArgs) Handles txtpassw.Leave
        CheckPassowrd()
        showScientistname()

    End Sub

    Private Sub txtpwordrev_Leave(sender As Object, e As EventArgs) Handles txtpwordrev.Leave
        CheckPassowrdrev()
        showReviewer()
        ' txtpassw.Enabled = False
    End Sub

    Public Sub RemoveFromPreview()

        Dim Delquery As String = " Delete From LabTestReview Where Hospital_Num = '" & txtHnum.Text & "' AND Request_Num='" & lblrqstnum.Text & "'"

        con.Open()
        ExecuteQuery(Delquery)

    End Sub

    Public Sub PopulateLABTreated()
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into LabTreated Values ('" & lblrqstnum.Text & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHnum.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "',  '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtacct.Text & "', '" & Txtactcat.Text & "',  '" & txtRqstby.Text & "', '" & TxtRqstdate.Text & "','" & lblreportby.Text & "')"

            cmd = New SqlCommand("INSERT INTO LabTreated VALUES(@Rnos, @Dtes, @tims, @Hnums, @Snam, @Onam, @Ages, @Sexs, @Acct, @Cat, @Rby,  @Rdte, @Rptby)", con)

            cmd.Parameters.Add("@Rnos", SqlDbType.Int).Value = lblrqstnum.Text
            cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldte.Text).Date
            cmd.Parameters.Add("@Tims", SqlDbType.VarChar).Value = lbltim.Text
            cmd.Parameters.Add("@Hnums", SqlDbType.NVarChar).Value = txtHnum.Text
            cmd.Parameters.Add("@snam", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@onam", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@Ages", SqlDbType.Int).Value = txtage.Text
            cmd.Parameters.Add("@sexs", SqlDbType.NVarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = Txtactcat.Text
            cmd.Parameters.Add("@Rby", SqlDbType.VarChar).Value = txtRqstby.Text
            cmd.Parameters.Add("@Rdte", SqlDbType.Date).Value = Convert.ToDateTime(TxtRqstdate.Text).Date
            cmd.Parameters.Add("@Rptby", SqlDbType.VarChar).Value = lblreportby.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        con.Close()
    End Sub

    Private Sub BtnBill_Click(sender As Object, e As EventArgs) Handles BtnBill.Click
        FrmBiller.txtSname.Text = TxtSname.Text
        FrmBiller.TxtOname.Text = txtOname.Text
        FrmBiller.Txthnum.Text = txtHnum.Text
        FrmBiller.txtaccnt.Text = txtacct.Text
        FrmBiller.TxtAcctCat.Text = Txtactcat.Text
        FrmBiller.ShowDialog()
    End Sub
End Class