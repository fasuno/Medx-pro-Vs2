Imports System.Data.SqlClient

Public Class FrmDrugsbill
    Private Sub FrmDrugsbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBilledPatient()
        lbldte.Text = Now.Date
        DtgDrugbill.Columns(7).Visible = False
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub ShowBilledPatient()


        Dim adapt As New SqlDataAdapter
        Dim Ntbl As New DataTable
        '''''''''''''''''''''''''''''''
        With Me

            cmd = New SqlCommand("Select AllDrugsBilled.Presc_num, AllDrugsBilled.Drug_Name, AllDrugsBilled.Prescription, AllDrugsBilled.Qty_given, AllDrugsBilled.Unit_cost, AllDrugsBilled.Total_Cost, Drug_List.Stock_Bal, Drug_List.Drug_Id FROM  AllDrugsBilled INNER JOIN Drug_List On AllDrugsBilled.Drug_Name=Drug_List.Drug_Name WHERE AllDrugsBilled.Presc_Num=@PrescId", con)

            cmd.Parameters.Add("@PrescId", SqlDbType.VarChar).Value = FrmPharmacy.Dtgbiiled.CurrentRow.Cells(0).Value


            adapt = New SqlDataAdapter(cmd)


            adapt.Fill(Ntbl)
            DtgDrugbill.DataSource = Ntbl
            DtgDrugbill.AutoResizeColumns()

            DtgDrugbill.Columns(0).Visible = False
            ''''''''''''''''''''''''''''

        End With

        'End If
    End Sub

    Public Sub GetStockBAl()
        Dim bal1 As Integer
        Dim bal2 As Integer
        Dim stbal As Integer

        '// CAlculate stock balance
        For sa As Integer = 0 To DtgDrugbill.Rows.Count() - 1

            bal1 = Convert.ToDouble(DtgDrugbill.Rows(sa).Cells(6).Value) '// Qty in stock
            bal2 = Convert.ToDouble(DtgDrugbill.Rows(sa).Cells(3).Value) '// qty given
            stbal = bal1 - bal2

            DtgDrugbill.Rows(sa).Cells(6).Value = stbal
        Next
    End Sub

    Public Sub RemoveFromPendPresc()

        Dim Delquery As String = " Delete From PharmPend_Bill Where Hospital_Num = '" & txtHnum.Text & "' AND Presc_num= '" & FrmPharmacy.Dtgbiiled.CurrentRow.Cells(0).Value & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub PopulateTreatedRequest()

        Try

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Treated_Pharm Values ('" & DtgDrugbill.Rows(0).Cells(0).Value & "', '" & lbldte.Text & "', '" & txtHnum.Text & "', '" & TxtSurname.Text & "', '" & txtOthername.Text & "','" & txtsex.Text & "', '" & txtage.Text & "', '" & txtaccnt.Text & "', '" & Txtacctcat.Text & "', '" & txtdatebill.Text & "', '" & lblbilledby.Text & "', '" & LblTotalcost.Text & "', '" & lblconfirmby.Text & "', '" & txtpresby.Text & "')"

            cmd = New SqlCommand("INSERT INTO Treated_Pharm VALUES(@Prno, @Dte, @Hno, @Sname, @Oname, @Sex, @Age, @Act, @Actcat, @Dtbil, @Bilby, @Ttc, @Con, @Pres)", con)

            cmd.Parameters.Add("@Prno", SqlDbType.Int).Value = DtgDrugbill.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldte.Text).Date
            cmd.Parameters.Add("@Hno", SqlDbType.NVarChar).Value = txtHnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = TxtSurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.NVarChar).Value = txtOthername.Text
            cmd.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Age", SqlDbType.NVarChar).Value = txtage.Text
            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = txtaccnt.Text
            cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = Txtacctcat.Text
            cmd.Parameters.Add("@Dtbil", SqlDbType.Date).Value = Convert.ToDateTime(txtdatebill.Text).Date
            cmd.Parameters.Add("@Bilby", SqlDbType.NVarChar).Value = lblbilledby.Text
            cmd.Parameters.Add("@Ttc", SqlDbType.Int).Value = LblTotalcost.Text
            cmd.Parameters.Add("@Con", SqlDbType.VarChar).Value = lblconfirmby.Text
            cmd.Parameters.Add("@Pres", SqlDbType.VarChar).Value = txtpresby.Text


            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @Pass", con)

        cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "USER VALIDATION")
            txtpword.Focus()


        Else
            lblconfirmby.Text = tbl.Rows(0)(1).ToString()
        End If
    End Sub

    Private Sub txtpword_Leave(sender As Object, e As EventArgs) Handles txtpword.Leave
        CheckPassowrd()
        GetStockBAl()
    End Sub

    Private Sub UpdateStockBal()

        '// I use this Function to update Tbl with datadrid rows (Thnks to The HolyGhost)
        Try
            For Each row As DataGridViewRow In DtgDrugbill.Rows

                Using con As New SqlConnection(constring)
                    Using upd As New SqlCommand("UPDATE Drug_List SET Stock_bal='" & DtgDrugbill.CurrentRow.Cells(6).Value & "' WHERE Drug_Id='" & DtgDrugbill.CurrentRow.Cells(7).Value & "'", con)

                        ' upd.Parameters.Add("@Id", SqlDbType.Int).Value = DtgPtDrugs.CurrentRow.Cells(7).Value
                        'upd.Parameters.AddWithValue("@Id", row.Cells("Stockid").Value)

                        con.Open()
                        upd.ExecuteNonQuery()
                        con.Close()

                    End Using
                End Using
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If txtpword.Text = "" Then

            MsgBox("PLEASE ENTER YOUR PASSWORD", vbOKOnly, "Medx-pro: PHARMACY")
        Else

            PopulateTreatedRequest()
            UpdateStockBal()
            RemoveFromPendPresc()
            FrmPharmacy.SortBiiled()
            FrmPharmacy.SortPendlist()
            FrmPharmacy.SortTreatedlist()
            Me.Close()
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click


        FrmPrintDrugPresc.Lblptname.Text = TxtSurname.Text + " " + txtOthername.Text
        FrmPrintDrugPresc.Lblaccount.Text = txtaccnt.Text + " | " + Txtacctcat.Text
        FrmPrintDrugPresc.lblhospnum.Text = txtHnum.Text
        FrmPrintDrugPresc.lblsex.Text = txtsex.Text
        FrmPrintDrugPresc.lblage.Text = txtage.Text
        FrmPrintDrugPresc.lblpresby.Text = txtpresby.Text
        FrmPrintDrugPresc.lblbillby.Text = txtbilledby.Text
        FrmPrintDrugPresc.lbltotbill.Text = LblTotalcost.Text
        FrmPrintDrugPresc.LBLID.Text = lblrqstid.Text

        FrmPrintDrugPresc.showCompDetails()

        FrmPrintDrugPresc.Show()

    End Sub



End Class