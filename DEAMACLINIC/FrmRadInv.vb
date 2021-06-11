Imports System.Data.SqlClient
Public Class FrmRadInv

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub ShowPAtientIn()

        Dim adapt As New SqlDataAdapter
        Dim Utbl As New DataTable

        With Me
            cmd = New SqlCommand("Select RadRequestAndResult.Investigation, RadRequestAndResult.Comment, Xray_ScanList.COST FROM RadRequestAndResult INNER JOIN Xray_ScanList On RadRequestAndResult.Investigation =  Xray_ScanList.INVESTIGATION WHERE RadRequestAndResult.Request_Num=@RqstId", con)


            ' cmd.Parameters.Add("@RqstId", SqlDbType.Int).Value = FrmRadiology.Dtgpendrad.CurrentRow.Cells(0).Value


            adapt = New SqlDataAdapter(cmd)


            adapt.Fill(Utbl)
            DtgPtRadInv.DataSource = Utbl
            DtgPtRadInv.AutoResizeColumns()
            DtgPtRadInv.ReadOnly = True

            '''''''''''''''''''''''''''''

        End With

    End Sub

    Public Sub BillPercentages()

        cmd = New SqlCommand("Select * from BillSetting where Account_type=@Acct And Account_Category=@Actcat", con)
        cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = txtacct.Text
        cmd.Parameters.Add("@Actcat", SqlDbType.NVarChar).Value = Txtactcat.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the percentage

            txtpercent.Text = tbl.Rows(0)(1).ToString()

            For s As Integer = 0 To DtgPtRadInv.Rows.Count() - 1
                DtgPtRadInv.Rows(s).Cells(2).Value = DtgPtRadInv.Rows(s).Cells(2).Value * Val(txtpercent.Text) / 100
                ' LblTotalcost.Text = DtgPtRadInv.CurrentRow.Cells(2).Value
            Next
        Else
        End If


    End Sub

    Private Sub FrmRadInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblRepdate.Text = Date.Now.Date 'i use this to hold a date value in tthe FB "ALLRADBILL"  for the date reported field
        lbldate.Text = Date.Now.Date
        lbltime.Text = TimeOfDay
        ShowPAtientIn()
        BillPercentages()
        GetTotalCost()
        txtpword.Text = ""
    End Sub

    Public Sub GetTotalCost()

        Dim Biller As Integer = 0
        For s As Integer = 0 To DtgPtRadInv.Rows.Count() - 1
            Biller += Val(DtgPtRadInv.Rows(s).Cells(2).Value)

        Next

        LblTotalcost.Text = Biller.ToString '//("#,#"
    End Sub

    Public Sub showAttendatName()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            lblbilledby.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @Pass", con)

        cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpword_Leave(sender As Object, e As EventArgs) Handles txtpword.Leave
        showAttendatName()
        CheckPassowrd()
    End Sub

    Public Sub PopulatePendRADBill()
        Try

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_RADBill Values ('" & Txtrqstid.Text & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "',  '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtacct.Text & "', '" & Txtactcat.Text & "', '" & LblTotalcost.Text & "', '" & lblbilledby.Text & "', '" & LblPayStat.Text & "', '" & txtrqstby.Text & "', '" & txtdate.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_RADBill VALUES(@Rno, @Dte, @Tim, @Hno, @Sname, @Oname, @Age, @Sex, @Act, @Cat, @Ttc, @Bby, @PStat, @Rby, @RDte)", con)

            cmd.Parameters.Add("@Rno", SqlDbType.Int).Value = Txtrqstid.Text
            cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.Time).Value = Convert.ToDateTime(lbltime.Text).TimeOfDay
            cmd.Parameters.Add("@Hno", SqlDbType.NVarChar).Value = txtHno.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = txtage.Text
            cmd.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = Txtactcat.Text
            cmd.Parameters.Add("@Ttc", SqlDbType.Int).Value = LblTotalcost.Text
            cmd.Parameters.Add("@Bby", SqlDbType.NVarChar).Value = lblbilledby.Text
            cmd.Parameters.Add("@Pstat", SqlDbType.VarChar).Value = LblPayStat.Text
            cmd.Parameters.Add("@Rby", SqlDbType.VarChar).Value = txtrqstby.Text
            cmd.Parameters.Add("@RDte", SqlDbType.Date).Value = Convert.ToDateTime(txtdate.Text).Date


            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub PopulatePendingBills()
        Try

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into PendingBills Values ('" & Txtrqstid.Text & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "', '" & LblTotalcost.Text & "',  '" & lblrad.Text & "', '" & txtacct.Text & "', '" & lblbilledby.Text & "', '" & Txtactcat.Text & "')"

            cmd = New SqlCommand("INSERT INTO PendingBills VALUES(@RqsId, @Dtes, @Tm, @Hnu, @Sname, @Oname, @Totc, @Ser, @ActT, @Bilby, @ActC)", con)

            cmd.Parameters.Add("@RqsId", SqlDbType.Int).Value = Txtrqstid.Text
            cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tm", SqlDbType.Time).Value = Convert.ToDateTime(lbltime.Text).TimeOfDay
            cmd.Parameters.Add("@Hnu", SqlDbType.VarChar).Value = txtHno.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@TotC", SqlDbType.Int).Value = LblTotalcost.Text
            cmd.Parameters.Add("@Ser", SqlDbType.NVarChar).Value = lblrad.Text
            cmd.Parameters.Add("@ActT", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Bilby", SqlDbType.NVarChar).Value = lblbilledby.Text
            cmd.Parameters.Add("@ActC", SqlDbType.VarChar).Value = Txtactcat.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveToAllRADBill()

        '//Thhis will save to AllRADBilled table
        Try

            For Each row As DataGridViewRow In DtgPtRadInv.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllRADBilled VALUES(@RqstID, @Dte, @Tim, @Hnum, @Sname, @Onames, @InvstgName, @Comm, @Age, @Sex, @Acnt, @Acntcat, @cost, @BBy, @Rby, @Service, @PayStat)", con)

                        cmd.Parameters.Add("@RqstID", SqlDbType.Int).Value = Txtrqstid.Text
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = txtdate.Text
                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = txtHno.Text
                        cmd.Parameters.Add("@Sname", SqlDbType.VarChar).Value = TxtSname.Text
                        cmd.Parameters.Add("@Onames", SqlDbType.VarChar).Value = txtOname.Text
                        cmd.Parameters.AddWithValue("@InvstgName", row.Cells("Investigation").Value)
                        cmd.Parameters.AddWithValue("@Comm", row.Cells("Comment").Value)
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = txtage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                        cmd.Parameters.Add("@Acnt", SqlDbType.VarChar).Value = txtacct.Text
                        cmd.Parameters.Add("@Acntcat", SqlDbType.VarChar).Value = Txtactcat.Text
                        cmd.Parameters.AddWithValue("@cost", row.Cells("COST").Value)

                        ' cmd.Parameters.AddWithValue("@Tcost", row.Cells("Total_Cost").Value)
                        cmd.Parameters.Add("@BBY", SqlDbType.VarChar).Value = lblbilledby.Text
                        cmd.Parameters.Add("@RBY", SqlDbType.VarChar).Value = txtrqstby.Text
                        cmd.Parameters.Add("@Service", SqlDbType.VarChar).Value = lblrad.Text
                        cmd.Parameters.Add("@PayStat", SqlDbType.VarChar).Value = LblPayStat.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PATIENT BILL HAVE BEEN SENT", vbOKOnly, "RADIOLOGY REQUEST")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub RemoveFromPendLabRqst()

        Dim Delquery As String = " Delete From Pend_RadRequest Where Hospital_No = '" & txtHno.Text & "' AND Request_Num='" & Txtrqstid.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        PopulatePendRADBill()
        PopulatePendingBills()
        SaveToAllRADBill()
        RemoveFromPendLabRqst()
        FrmRadiology.SortPendRadRqst()
        FrmRadiology.SortPendRADBill()
        frmCashier.sortPendingBilss()

        txtpword.Text = ""
        Me.Close()

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        frmPrinRAdrqst.Lblptname.Text = TxtSname.Text + " " + txtOname.Text
        frmPrinRAdrqst.Lblaccount.Text = txtacct.Text + " | " + Txtactcat.Text
        frmPrinRAdrqst.lblhospnum.Text = txtHno.Text
        frmPrinRAdrqst.lblsex.Text = txtsex.Text
        frmPrinRAdrqst.lblage.Text = txtage.Text
        frmPrinRAdrqst.lblpresby.Text = txtrqstby.Text
        frmPrinRAdrqst.lblbillby.Text = lblbilledby.Text
        frmPrinRAdrqst.lbltotbill.Text = LblTotalcost.Text
        frmPrinRAdrqst.LBLID.Text = Txtrqstid.Text

        frmPrinRAdrqst.Show()
    End Sub
End Class