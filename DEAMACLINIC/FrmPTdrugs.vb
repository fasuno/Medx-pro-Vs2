Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmPTdrugs

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmPTdrugs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTotalcost.Text = ""
        lbldte.Text = Date.Now.Date
        lbltim.Text = TimeOfDay
        BillPercentages()
        Dgvconsult.Columns(7).Visible = False
        Dgvconsult.Columns(0).Visible = False
        '// This will load the following data when a selected row is double click on the Pending precription form
    End Sub

    Public Sub BillPercentages()

        cmd = New SqlCommand("Select * from BillSetting where Account_type=@Acct And Account_Category=@Actcat", con)
        cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = txtacct.Text
        cmd.Parameters.Add("@Actcat", SqlDbType.NVarChar).Value = Txtacctcat.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the percentage

            txtpercent.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

        '   For sa As Integer = 0 To DtgPtDrugs.Rows.Count() - 1
        '  DtgPtDrugs.Rows(sa).Cells(3).Value = DtgPtDrugs.Rows(sa).Cells(3).Value * Val(txtpercent.Text) / 100

        'Next
    End Sub

    Public Sub setDtgtoreadonly()

        'Dgvconsult.Columns(0).Visible = False

        Dgvconsult.Columns(0).ReadOnly = True
        Dgvconsult.Columns(1).ReadOnly = True
        Dgvconsult.Columns(2).ReadOnly = True
        Dgvconsult.Columns(3).ReadOnly = True
        Dgvconsult.Columns(4).ReadOnly = True
        Dgvconsult.Columns(5).ReadOnly = False
        Dgvconsult.Columns(6).ReadOnly = True

    End Sub

    Public Sub GetTotalCost()

        Dim Bill As Integer = 0
        '  For s As Integer = 0 To DtgPtDrugs.Rows.Count() - 1

        ' Bill += Val(DtgPtDrugs.Rows(s).Cells(6).Value)
        ' Next

        LblTotalcost.Text = Bill.ToString
    End Sub

    Public Sub ShowDrugsDetails()
        '// i ahve to add qty_given, total_cost column to enable me use it on the drugs grid for calculating price
        '// the colums are redundant in drug_list table but will be added to bill table
        '// also the columns were made NOT NULL value for easy conversion at runtime.

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * FROM VwPrescDetails WHERE Presc_Num=@Prescid", con)
        ' cmd = New SqlCommand("Select AllDrugPresc.Presc_num, AllDrugPresc.Drug_Name, AllDrugPresc.Prescription, Drug_List.Unit_cost, Drug_List.Stock_Bal, Drug_List.Qty_given, Drug_List.Total_cost, Drug_List.Drug_Id FROM AllDrugPresc INNER JOIN Drug_List On AllDrugPresc.Drug_id=Drug_List.Drug_id WHERE AllDrugPresc.Presc_Num=@Prescid AND AllDrugPresc.Hospital_No=@HospId", con)
        cmd.Parameters.Add("@PrescId", SqlDbType.Int).Value = txtpresnum.Text 'FrmPharmacy.DtgPendDrugrqst.CurrentRow.Cells(0).Value
        ' cmd.Parameters.Add("@HospId", SqlDbType.Int).Value = FrmPharmacy.DtgPendDrugrqst.CurrentRow.Cells(3).Value
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Dgvconsult.DataSource = tbl

        ' Dgvconsult.Columns(0).ReadOnly = True
        Dgvconsult.Columns(1).ReadOnly = True
        Dgvconsult.Columns(2).ReadOnly = True
        Dgvconsult.Columns(3).ReadOnly = True
        Dgvconsult.Columns(4).ReadOnly = True
        Dgvconsult.Columns(5).ReadOnly = False
        Dgvconsult.Columns(6).ReadOnly = True

        Dgvconsult.AutoResizeColumns()

    End Sub

    Public Sub ShowDrugDetails()
        '// i ahve to add qty_given, total_cost column to enable me use it on the drugs grid for calculating price
        '// the colums are redundant in drug_list table but will be added to bill table
        '// also the columns were made NOT NULL value for easy conversion at runtime.

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select AllDrugPresc.Presc_num, AllDrugPresc.Drug_Name, AllDrugPresc.Prescription, Drug_List.Unit_cost, Drug_List.Stock_Bal, Drug_List.Qty_given, Drug_List.Total_cost, Drug_List.Drug_Id FROM AllDrugPresc INNER JOIN Drug_List On AllDrugPresc.Drug_id=Drug_List.Drug_id WHERE AllDrugPresc.Presc_Num=@Prescid AND AllDrugPresc.Hospital_No=@HospId", con)

        cmd.Parameters.Add("@PrescId", SqlDbType.Int).Value = FrmPharmacy.DtgPendDrugrqst.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("@HospId", SqlDbType.Int).Value = FrmPharmacy.DtgPendDrugrqst.CurrentRow.Cells(3).Value


        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        '  DtgPtDrugs.DataSource = tbl

        'DtgPtDrugs.AutoResizeColumns()

    End Sub

    Public Sub showPharmacistName()
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

    Public Sub PopulatePendPharmBill()
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into PharmPend_Bill Values ('" & DtgPtDrugs.Rows(0).Cells(0).Value & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "',  '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtacct.Text & "', '" & Txtacctcat.Text & "', '" & LblTotalcost.Text & "', '" & lblbilledby.Text & "', '" & LblPayStatus.Text & "','" & txtprescby.Text & "' )"

            cmd = New SqlCommand("INSERT INTO PharmPend_Bill VALUES(@Pno, @Dte, @Tim, @Hno, @Sname, @Oname, @Age, @Sex, @Act, @Cat, @Ttc, @Bby, @PStat, @Pby)", con)

            cmd.Parameters.Add("@Pno", SqlDbType.Int).Value = Dgvconsult.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldte.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
            cmd.Parameters.Add("@Hno", SqlDbType.NVarChar).Value = txtHno.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@Age", SqlDbType.NVarChar).Value = txtage.Text
            cmd.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Cat", SqlDbType.VarChar).Value = Txtacctcat.Text
            cmd.Parameters.Add("@Ttc", SqlDbType.Int).Value = LblTotalcost.Text
            cmd.Parameters.Add("@Bby", SqlDbType.NVarChar).Value = lblbilledby.Text
            cmd.Parameters.Add("@Pstat", SqlDbType.VarChar).Value = LblPayStatus.Text
            cmd.Parameters.Add("@Pby", SqlDbType.VarChar).Value = txtprescby.Text


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
            'cmd.CommandText = "insert into PendingBills Values ('" & DtgPtDrugs.Rows(0).Cells(0).Value & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "', '" & LblTotalcost.Text & "',  '" & lblpharm.Text & "', '" & txtacct.Text & "', '" & Txtacctcat.Text & "', '" & lblbilledby.Text & "')"

            cmd = New SqlCommand("INSERT INTO PendingBills VALUES(@RqsId, @Dtes, @Tm, @Hnu, @Sname, @Oname, @Totc, @Ser, @ActT, @Bilby, @ActC)", con)

            ' cmd.Parameters.Add("@RqsId", SqlDbType.Int).Value = DtgPtDrugs.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldte.Text).Date
            cmd.Parameters.Add("@Tm", SqlDbType.Time).Value = Convert.ToDateTime(lbltim.Text).TimeOfDay
            cmd.Parameters.Add("@Hnu", SqlDbType.Int).Value = txtHno.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOname.Text
            cmd.Parameters.Add("@TotC", SqlDbType.Int).Value = LblTotalcost.Text
            cmd.Parameters.Add("@Ser", SqlDbType.NVarChar).Value = lblpharm.Text
            cmd.Parameters.Add("@ActT", SqlDbType.NVarChar).Value = txtacct.Text
            cmd.Parameters.Add("@Bilby", SqlDbType.NVarChar).Value = lblbilledby.Text
            cmd.Parameters.Add("@ActC", SqlDbType.VarChar).Value = Txtacctcat.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveToAllDrugsBill()

        '//Thhis will save to AllDrugsBill table

        Try

            For Each row As DataGridViewRow In Dgvconsult.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllDrugsBilled VALUES(@PresNum, @Dte, @Tim, @Hnum, @Sname, @Onames, @DrugName, @Presc, @Age, @Sex, @Acnt, @Acntcat, @Qtygvn, @Ucost, @Tcost, @BBy, @Pby, @Service, @PayStat)", con)

                        cmd.Parameters.AddWithValue("@PresNum", row.Cells("Presc_Num").Value)
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = lbldte.Text
                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = txtHno.Text
                        cmd.Parameters.Add("@Sname", SqlDbType.VarChar).Value = TxtSname.Text
                        cmd.Parameters.Add("@Onames", SqlDbType.VarChar).Value = txtOname.Text
                        cmd.Parameters.AddWithValue("@DrugName", row.Cells("Drug_Name").Value)
                        cmd.Parameters.AddWithValue("@Presc", row.Cells("Prescription").Value)
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = txtage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                        cmd.Parameters.Add("@Acnt", SqlDbType.VarChar).Value = txtacct.Text
                        cmd.Parameters.Add("@Acntcat", SqlDbType.VarChar).Value = Txtacctcat.Text
                        cmd.Parameters.AddWithValue("@Qtygvn", row.Cells("Qty_given").Value)
                        cmd.Parameters.AddWithValue("@Ucost", row.Cells(3).Value) ''/// Means Insert the value in all the cells under column 4, instead of using the name
                        cmd.Parameters.AddWithValue("@Tcost", row.Cells("Total_Cost").Value)
                        cmd.Parameters.Add("@BBY", SqlDbType.VarChar).Value = lblbilledby.Text
                        cmd.Parameters.Add("@PBY", SqlDbType.VarChar).Value = txtprescby.Text
                        cmd.Parameters.Add("@Service", SqlDbType.VarChar).Value = lblpharm.Text
                        cmd.Parameters.Add("@PayStat", SqlDbType.VarChar).Value = LblPayStatus.Text


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("DRUGS HAS BEEN DISPENSED", vbOKOnly, "Medx-pro")

            ' dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub RemoveFromPendPresc()

        Dim Delquery As String = " Delete From Pend_DrugPresc Where Hospital_No = '" & txtHno.Text & "' AND Presc_num= '" & FrmPharmacy.DtgPendDrugrqst.CurrentRow.Cells(0).Value & "'"

        ExecuteQuery(Delquery)

    End Sub

    Private Sub txtpword_Leave(sender As Object, e As EventArgs) Handles txtpword.Leave
        GetStockBAl()
        CheckPassowrd()
        showPharmacistName()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        con.Close()
        If txtpword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", vbOKOnly, "DRUGS PRESCRIPTION")


        Else
            PopulatePendPharmBill()
            '  PopulatePendingBills()
            UpdateStockBal()
            SaveToAllDrugsBill()
            RemoveFromPendPresc()
            FrmPharmacy.SortBiiled()
            FrmPharmacy.SortPendlist()

            'frmCashier.sortPendingBilss()
            txtpword.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub FrmPTdrugs_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        '  DtgPtDrugs.Columns.Clear()

        Dgvconsult.DataSource = Nothing
    End Sub

    Sub UpdateStockBal()

        '// I use this Function to update Tbl with datadrid rows (Thnks to The HolyGhost)
        Try
            'For Each row As DataGridViewRow In Dgvconsult.Rows
            For sas As Integer = 0 To Dgvconsult.Rows.Count() - 1
                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("UPDATE Drug_List SET Stock_bal='" & Dgvconsult.Rows(sas).Cells(4).Value & "' WHERE Drug_Id=@Id", con)

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Dgvconsult.Rows(sas).Cells(7).Value


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                    End Using
                End Using
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        FrmPrintDrugPresc.Lblptname.Text = TxtSname.Text + " " + txtOname.Text
        FrmPrintDrugPresc.Lblaccount.Text = txtacct.Text + " | " + Txtacctcat.Text
        FrmPrintDrugPresc.lblhospnum.Text = txtHno.Text
        FrmPrintDrugPresc.lblsex.Text = txtsex.Text
        FrmPrintDrugPresc.lblage.Text = txtage.Text
        FrmPrintDrugPresc.lblpresby.Text = txtprescby.Text
        FrmPrintDrugPresc.lblbillby.Text = lblbilledby.Text
        FrmPrintDrugPresc.lbltotbill.Text = LblTotalcost.Text
        FrmPrintDrugPresc.LBLID.Text = txtpresnum.Text

        FrmPrintDrugPresc.Show()
    End Sub

    Private Sub Dgvconsult_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvconsult.CellEndEdit
        Try
            Dim iCell1 As Integer
            Dim icell2 As Integer
            Dim icellResult As Integer

            '//Get the total cost of the each drug

            icell2 = Convert.ToDouble(Dgvconsult.CurrentRow.Cells(5).Value) ' //qty given
            iCell1 = Convert.ToDouble(Dgvconsult.CurrentRow.Cells(3).Value) '// unit cost
            icellResult = icell2 * iCell1
            Dgvconsult.CurrentRow.Cells(6).Value = icellResult '// * Val(txtpercent.Text) / 100  '// refer to billsetting 
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        GetTotalCost()
    End Sub

    Public Sub GetStockBAl()
        Dim bal1 As Integer
        Dim bal2 As Integer
        Dim stbal As Integer

        '// CAlculate stock balance
        For sa As Integer = 0 To Dgvconsult.Rows.Count() - 1

            bal1 = Convert.ToDouble(Dgvconsult.Rows(sa).Cells(4).Value) '// Qty in stock
            bal2 = Convert.ToDouble(Dgvconsult.Rows(sa).Cells(5).Value) '// qty given
            stbal = bal1 - bal2

            Dgvconsult.Rows(sa).Cells(4).Value = stbal
        Next
    End Sub

    Private Sub BtnBill_Click(sender As Object, e As EventArgs) Handles BtnBill.Click
        FrmBiller.txtSname.Text = TxtSname.Text
        FrmBiller.TxtOname.Text = txtOname.Text
        FrmBiller.Txthnum.Text = txtHno.Text
        FrmBiller.txtaccnt.Text = txtacct.Text
        FrmBiller.TxtAcctCat.Text = Txtacctcat.Text

        FrmBiller.ShowDialog()
    End Sub

End Class

