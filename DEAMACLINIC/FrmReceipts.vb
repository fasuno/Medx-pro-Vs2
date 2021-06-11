Imports System.Data.SqlClient

Public Class FrmReceipts

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
        Showdrugdetails()
        ShowLabdetails()
        ShowLRADdetails()
        DtgDetails.AutoResizeColumns()
        BtnSave.Enabled = True
    End Sub

    Private Sub FrmReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgDetails.DataSource = Nothing
        lbldate.Text = Now.Date
        lbltime.Text = TimeOfDay
        'BtnSave.Enabled = False
        Txtpassword.Text = ""
    End Sub

    Public Sub Showdrugdetails()
        If Txtserv.Text = "Pharmacy" Then

            Dim tbl As New DataTable()
            cmd = New SqlCommand("Select Drug_Name, Total_cost, Prescription from AllDrugsBilled WHERE Presc_num=@Pnum", con)
            cmd.Parameters.Add("@Pnum", SqlDbType.Int).Value = Txtservno.Text

            Dim adpter As New SqlDataAdapter(cmd)
            adpter.Fill(tbl)

            DtgDetails.DataSource = tbl
            DtgDetails.AutoResizeColumns()
        End If
    End Sub

    Public Sub ShowLRADdetails()
        If Txtserv.Text = "Radiology" Then

            Dim tbl As New DataTable()
            cmd = New SqlCommand("Select Investigation,Cost,Comment from AllRADBilled WHERE Request_num=@Rnum", con)
            cmd.Parameters.Add("@Rnum", SqlDbType.Int).Value = Txtservno.Text
            'cmd.Parameters.Add("@datto", SqlDbType.Date).Value = PenVitTo.Value

            Dim adpter As New SqlDataAdapter(cmd)
            adpter.Fill(tbl)

            DtgDetails.DataSource = tbl
            DtgDetails.AutoResizeColumns()
        End If
    End Sub

    Public Sub ShowLabdetails()
        If Txtserv.Text = "Laboratory" Then

            Dim tbl As New DataTable()
            cmd = New SqlCommand("Select Test_Name,Total_Cost from AllLABBilled WHERE Request_num=@Rnum", con)
            cmd.Parameters.Add("@Rnum", SqlDbType.Int).Value = Txtservno.Text
            'cmd.Parameters.Add("@datto", SqlDbType.Date).Value = PenVitTo.Value

            Dim adpter As New SqlDataAdapter(cmd)
            adpter.Fill(tbl)

            DtgDetails.DataSource = tbl
            DtgDetails.AutoResizeColumns()
        End If
    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblcashiername.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            Txtpassword.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpassword_Leave(sender As Object, e As EventArgs) Handles Txtpassword.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub generatenum()

        Try

            con.Open()

            cmd = New SqlCommand("Select  MAX(Receipt_No) from RECEIPTS", con)

            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then


                '// The for statement will fill all cells in presc number column with the same value that the above sql statement genegrate

                'For Col As Integer = 0 To dgprescription.Rows.Count() - 1
                ' dgprescription.Rows(Col).Cells(0).Value = dt.Item(0) + 1
                ' Next

                Me.LblReceiptnum.Text = dt.Item(0) + 1
                dt.Close()
            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SaveReceipt()
        generatenum()

        Try

            Using cmd As New SqlCommand("INSERT INTO RECEIPTS VALUES(@Dat, @Tim, @Rnum, @Fname, @Hnum, @Amnt, @Serv, @CollBY, @Sno, @Act, @Paym)", con)

                cmd.Parameters.Add("@Dat", SqlDbType.Date).Value = lbldate.Text
                cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltime.Text
                cmd.Parameters.Add("@Rnum", SqlDbType.VarChar).Value = LblReceiptnum.Text
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = Txthnum.Text
                cmd.Parameters.Add("@Amnt", SqlDbType.VarChar).Value = lblBill.Text
                cmd.Parameters.Add("@Serv", SqlDbType.VarChar).Value = Txtserv.Text
                cmd.Parameters.Add("@CollBy", SqlDbType.VarChar).Value = lblcashiername.Text
                cmd.Parameters.Add("@Sno", SqlDbType.VarChar).Value = Txtservno.Text
                cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = txtaccnt.Text
                cmd.Parameters.Add("@Paym", SqlDbType.VarChar).Value = Cbopaymode.Text

                ' con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MsgBox("RECEIPT GENERATED SUCCESSFULLY, CLICK ON TO PRINT", vbOKOnly, "CASH RECEIPT")

            UpdateLabBilled() '// Update payment status to paid
            UpdateDrugBilled() '// Update payment status to paid
            UpdatePendPharmBilled()
            UpdateAllRadBilled() '//Update radiology payment status
            frmCashier.LoadReceipts()   '//Refresh Receipts 
            FrmPharmacy.SortBiiled()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        SaveReceipt()
        removefrompending()
        frmCashier.sortPendingBilss()

        Dim FRMRCPT As New FrmPrintreceipt

        FRMRCPT.ShowDialog()

        Me.Close()

    End Sub

    Public Sub UpdateLabBilled()
        If Txtserv.Text = "Laboratory" Then

            Try
                Dim Updat As String = "Update AllLABBilled Set Payment_Status='" & lblpaystat.Text.ToString & "' WHERE Request_Num= '" & Txtservno.Text & "'"

                con.Open()
                ExecuteQuery(Updat)
                'con.Close()

                'reloadLAbbilled()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Public Sub UpdateDrugBilled()
        If Txtserv.Text = "Pharmacy" Then

            Try
                Dim Updat As String = "Update AllDrugsBilled Set Payment_Status='" & lblpaystat.Text.ToString & "' WHERE Presc_Num= '" & Txtservno.Text & "'"

                con.Open()
                ExecuteQuery(Updat)


                'reloadLAbbilled()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Public Sub UpdatePendPharmBilled()

        If Txtserv.Text = "Pharmacy" Then

            Try
                Dim Updat As String = "Update PharmPend_Bill Set Payment_Status='" & lblpaystat.Text.ToString & "' WHERE Presc_Num= '" & Txtservno.Text & "'"

                con.Open()
                ExecuteQuery(Updat)


                'reloadLAbbilled()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Public Sub UpdateAllRadBilled()
        If Txtserv.Text = "Radiology" Then

            Try
                Dim Updat As String = "Update AllRADBilled Set Payment_Status='" & lblpaystat.Text.ToString & "' WHERE Request_Num= '" & Txtservno.Text & "'"

                con.Open()
                ExecuteQuery(Updat)


                'reloadLAbbilled()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From PendingBills WHERE Service_No = '" & Txtservno.Text & "'"
        con.Open()
        ExecuteQuery(Delquery)

    End Sub

    Private Sub btnreprint_Click(sender As Object, e As EventArgs) Handles btnreprint.Click
        Dim frmprint As New FrmPrintreceipt
        frmprint.ShowDialog()
    End Sub
End Class