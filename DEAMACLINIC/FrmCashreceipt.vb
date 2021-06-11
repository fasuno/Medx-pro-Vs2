Imports System.Data.SqlClient

Public Class FrmCashreceipt
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub loadServices()
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Service, Amount from Services", con)

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        'Dtgaddservices.DataSource = tbl
        'Dtgaddservices.AutoResizeColumns()

    End Sub

    Public Sub Loadservice()

        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Service from Services", con)
            adapt = New SqlDataAdapter(cmd)

            'con.Open()   ' Open connection
            adapt.Fill(tbl)

            Dim rw As DataRow

            txtservice.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                txtservice.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub FrmCashreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' loadServices()

        Loadservice()
        lbldate.Text = Now.Date

        ' lbltime.Text = TimeOfDay
        DtgServices.Rows.Clear()
        'Dtgaddservices.Columns(0).ReadOnly = True
        Txtfullname.Text = ""
        Txtpassw.Text = ""
        lblBill.Text = 0
        LblTidnum.Text = ""
        lblreceiptnum.Text = ""

    End Sub

    Private Sub BtnAddservice_Click(sender As Object, e As EventArgs) Handles BtnAddservice.Click
        '// This was to add the value of a selected row in one dataggrid to another datagridview
        'Dim dr As New DataGridViewRow

        'For Each dr In Me.Dtgaddservices.SelectedRows
        'Dtgaddservices.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DtgServices.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value)
        'Next

        If Txtfullname.Text = "" Then
            MsgBox("PLEASE ENTER PATIENT NAME", MsgBoxStyle.Critical, "CASH RECEIPT")
        ElseIf txtservice.Text = "" Then
            MsgBox("PLEASE SELECT SERVICE", MsgBoxStyle.Critical, "Medx-pro")
        Else
            '// Check if the service is already added, if yes restrict from adding another
            Dim check As Boolean = False

        For Each row In DtgServices.Rows

            If txtservice.Text = row.cells("Service").value Then
                check = True
                Exit For

            End If
        Next
            If check = False Then

                DtgServices.Rows.Add(txtservice.Text, txtamount.Text)
                txtservice.Text = ""
                txtamount.Text = 0
                GetTotalCost()
            Else
                MsgBox("ITEM IS ALREADY ADDED", MsgBoxStyle.Information, "Medx-pro")
                txtservice.Focus()
            End If
        End If

    End Sub

    Private Sub Btnremoveserv_Click(sender As Object, e As EventArgs) Handles Btnremoveserv.Click
        If DtgServices.SelectedRows.Count > 0 Then
            For i As Integer = DtgServices.SelectedRows.Count - 1 To 0 Step +1
                DtgServices.Rows.RemoveAt(DtgServices.SelectedRows(i).Index)
                'Dtgaddservices.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Next
        Else
            MessageBox.Show("No Item Seleted")
        End If

        GetTotalCost()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = Txtpassw.Text

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

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            Txtpassw.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpassw_Leave(sender As Object, e As EventArgs) Handles Txtpassw.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub generateTIDnum()

        Try

            '// This code will automatically generate prescription number from the database and show it in the textbox
            '// It picks the maximum value in the table and increment it by one.

            con.Open()

            cmd = New SqlCommand("Select  MAX(ID) from Temporary_ID", con)

            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then


                '// The for statement will fill all cells in presc number column with the same value that the above sql statement genegrate

                For Col As Integer = 0 To DtgServices.Rows.Count() - 1
                    DtgServices.Rows(Col).Cells(2).Value = dt.Item(0) + 1
                Next

                Me.LblTidnum.Text = dt.Item(0) + 1
                dt.Close()
            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub generateReceiptnum()

        Try

            '// This code will automatically generate prescription number from the database and show it in the textbox
            '// It picks the maximum value in the table and increment it by one.

            'con.Open()

            cmd = New SqlCommand("Select  MAX(Receipt_No) from RECEIPTS", con)

            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then

                Me.lblreceiptnum.Text = dt.Item(0) + 1
                dt.Close()
            Else

                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SaveToReceipt()
        generateReceiptnum()

        Try
            For Each row As DataGridViewRow In DtgServices.Rows

                ' Dim Constring As String = "Data source = localhost; initial catalog=PROMEDDB; Integrated Security=true"
                Using con As New SqlConnection(Constring)

                    Using cmd As New SqlCommand("INSERT INTO RECEIPTS VALUES(@Dat, @Tim, @Rnum, @Fname, @Hnum, @Amnt, @Serv, @CollBY, @Servno, @Accttype, @Paymd)", con)

                        cmd.Parameters.Add("@Dat", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
                        cmd.Parameters.Add("@Tim", SqlDbType.DateTime).Value = dtIme.Value
                        cmd.Parameters.Add("@Rnum", SqlDbType.Int).Value = lblreceiptnum.Text
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = Txtfullname.Text
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = lblTID.Text + "/" + LblTidnum.Text
                        cmd.Parameters.AddWithValue("@Amnt", row.Cells("Amount").Value)
                        cmd.Parameters.AddWithValue("@Serv", row.Cells("Service").Value)
                        cmd.Parameters.Add("@CollBy", SqlDbType.VarChar).Value = lblcashiername.Text
                        cmd.Parameters.AddWithValue("@Servno", row.Cells("ServID").Value)
                        ' cmd.Parameters.Add("@Amnt", SqlDbType.Int).Value = lblBill.Text
                        cmd.Parameters.Add("@AcctType", SqlDbType.VarChar).Value = lblTID.Text
                        cmd.Parameters.Add("@Paymd", SqlDbType.VarChar).Value = Cbopaymode.Text


                        'cmd.Parameters.Add("@Servs", SqlDbType.VarChar).Value = DtgServices.Rows.Item.Cells(0).Value

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RECEIPT GENERATED SUCCESSFULLY, CLICK ON TO PRINT", vbOKOnly, "Medx-pro")

            frmCashier.LoadReceipts()   '//Refresh Receipts 

            '//PLACE THE PRINT METHOD HERE, AFTER THE MSGBOX

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SaveToTempID()
        generateTIDnum()

        Try

            For Each row As DataGridViewRow In DtgServices.Rows

                ' Dim Constring As String = "Data source = localhost; initial catalog=PROMEDDB; Integrated Security=true"

                Using con As New SqlConnection(Constring)
                    Using cmd As New SqlCommand("INSERT INTO Temporary_ID VALUES(@IDs, @Dte, @Time, @Pname, @TemID, @Serv, @Amt, @RsBy, @Paym )", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        cmd.Parameters.AddWithValue("@IDs", row.Cells("ServID").Value)
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
                        cmd.Parameters.Add("@Time", SqlDbType.DateTime).Value = dtIme.Value
                        cmd.Parameters.Add("@Pname", SqlDbType.VarChar).Value = Txtfullname.Text
                        cmd.Parameters.Add("@TemID", SqlDbType.VarChar).Value = lblTID.Text + "/" + LblTidnum.Text

                        cmd.Parameters.AddWithValue("@Serv", row.Cells("Service").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Amt", row.Cells("Amount").Value) '// Insert the value in the Datagridview Prescription cell
                        cmd.Parameters.Add("@RsBy", SqlDbType.VarChar).Value = lblcashiername.Text
                        cmd.Parameters.Add("@Paym", SqlDbType.NVarChar).Value = Cbopaymode.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            'MsgBox("RECEIPT GENERATED SUCCESSFULLY, CLICK ON TO PRINT", vbOKOnly, "CASH RECEIPT")

            '//PLACE THE PRINT METHOD HERE, AFTER THE MSGBOX

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        SaveToTempID()
        SaveToReceipt()
        frmCashier.LoadReceipts()
        'FrmReport.Show()
        con.Close()
    End Sub

    Public Sub GetTotalCost()

        Dim Bill As Integer = 0
        For s As Integer = 0 To DtgServices.Rows.Count() - 1
            Bill = Bill + DtgServices.Rows(s).Cells(1).Value

        Next

        lblBill.Text = Bill.ToString
    End Sub

    Public Sub PrintOPtion()

        ' Dim Resp =
        ' MessageBox.Show("PRINT RECEIPT")MessageBoxButtons.YesNo, MessageBoxIcon.Question
    End Sub

    Private Sub txtamount_GotFocus(sender As Object, e As EventArgs) Handles txtamount.GotFocus
        txtamount.Text = 0
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class