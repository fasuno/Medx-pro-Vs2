
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmDrugsPresc

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub generatenum()

        Try
            '// Nte. The DB is not set to genarate auto number, just enter the first row as a dummy row and use it as a seed
            '// This code will automatically generate prescription number from the database 
            '// It picks the maximum value in the table and increment it by one.

            con.Open()

            cmd = New SqlCommand("Select  MAX(Presc_Num) from  AllDrugPresc", con)

            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then


                '// The for statement will fill all cells in presc number column with the same value that the above sql statement genegrate

                For Col As Integer = 0 To dgprescription.Rows.Count() - 1
                    dgprescription.Rows(Col).Cells(0).Value = dt.Item(0) + 1
                Next

                'Me.txtpresNum.Text = dt.Item(0) + 1
                dt.Close()
            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub CboclinicItems()
        Me.cboclinic.Items.Add("GOPD")
        Me.cboclinic.Items.Add("ORTHOPEDIC")
        Me.cboclinic.Items.Add("PRIVATE WARD")
        Me.cboclinic.Items.Add("GENERAL WARD")


    End Sub

    Public Sub LoadDrugs()
        lbldate.Text = Date.Now.Date
        lbltime.Text = TimeOfDay

        CboclinicItems() '// loads clinic to combobox at form load event

        '// This code loads the drugs list to the textbox and allow the textbox to perform autocomplete function
        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Drug_Name from Drug_List", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            txtdrugname.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                txtdrugname.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            'generatenum()

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

        Me.dgprescription.Rows.Clear()

    End Sub ' // This Function will be called from FrmGEnConsult Drug Button

    Private Sub btnadddrug_Click(sender As Object, e As EventArgs) Handles btnadddrug.Click

        '// Add the value of the textboxes to the drud datagrid

        dgprescription.Rows.Add(lblprescno.Text, txtdrugid.Text, txtdrugname.Text, txtprescription.Text)

        txtdrugid.Text = ""
        txtdrugname.Text = ""
        txtprescription.Text = ""
        txtdrugname.Focus()

    End Sub

    Private Sub btnsendpresc_Click(sender As Object, e As EventArgs) Handles btnsendpresc.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiag.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiag.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else
            '// This code is a really breakthru for me and I thank God The father for The gift Of the Holy Spirit who taught me
            '// This code will export all the data in a datagridview to a textbox all at once.
            '//Send all the rows to a to the treatment textbox on the consultstion form

            For cols As Integer = 0 To dgprescription.Rows.Count - 1 Step ++1
                frmGenConsult.TxtTreatmnt.Text = frmGenConsult.TxtTreatmnt.Text + "/" + dgprescription.Rows(cols).Cells(2).Value + "||" + dgprescription.Rows(cols).Cells(3).Value '// This target cell 2 adn 3 only

                '// THIS ONE BELOW WILL ADD ALL THE COLUMS IN THE DATAGRID

                ' For I As Integer = 0 To dgprescription.Rows.Count - 1 Step ++1
                ' For J As Integer = 1 To dgprescription.Columns.Count - 1 Step ++1

                ' frmGenConsult.TxtTreatmnt.Text = frmGenConsult.TxtTreatmnt.Text + "\" + dgprescription.Rows(I).Cells(J).Value.ToString() + "\"

                'Next

                frmGenConsult.TxtTreatmnt.Text = frmGenConsult.TxtTreatmnt.Text + ".."
            Next

            Saveprescription()

            Me.Close()
            txtpassword.Text = ""
            lblname.Text = ""
            txtdiag.Text = ""


        End If
        FrmPharmacy.SortPendlist()
        FrmPtRecords.PtDrugs11.LoadDrugsHx()
        FrmAdmitFolder.InpatientDrugsHx1.LoadDrugsHx()
        FrmSurgery.TheatreDrugs1.LoadDrugsHx()
        frmGenConsult.LoadDrugsHx()
        con.Close()
    End Sub

    Public Sub Saveprescription()
        generatenum()
        PopulatePendDrugPresc()
        '//Thhis will save to AllDrugprescrition table
        Try

            For Each row As DataGridViewRow In dgprescription.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllDrugPresc VALUES(@Prescid, @Date, @Time, @Did, @DrgName, @Presc, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Accntcat, @Clinic, @Diag, @PrescBY)", con)
                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@PrescId", row.Cells("Presc_Num").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Did", row.Cells("Drugid").Value)
                        cmd.Parameters.AddWithValue("@DrgName", row.Cells("Drug_Name").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Presc", row.Cells("Prescription").Value) '// Insert the value in the Datagridview Prescription cell
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmPtRecords.lblacct.Text
                        cmd.Parameters.Add("@Accntcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiag.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblname.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PRESCRIPTION SENT", vbOKOnly, "Medx-pro")

            dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub '// SAve to AllDrug Prescription table

    Public Sub PopulatePendDrugPresc()
        Try

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_DrugPresc Values ('" & dgprescription.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmPtRecords.Lblhopnum.Text & "','" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "',  '" & FrmPtRecords.lblage.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblacct.Text & "','" & FrmPtRecords.Profile1.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiag.Text & "', '" & lblname.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_DrugPresc VALUES(@Pnum, @Dte, @tim, @Hnum, @Sname, @Oname, @Age, @Sex, @Acct, @ActCAt, @Clin, @Dia, @Preby)", con)

            cmd.Parameters.Add("@Pnum", SqlDbType.Int).Value = dgprescription.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dte", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltime.Text.ToString
            cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
            cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = FrmPtRecords.lblacct.Text
            cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
            cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Dia", SqlDbType.NVarChar).Value = txtdiag.Text
            cmd.Parameters.Add("@Preby", SqlDbType.VarChar).Value = lblname.Text


            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpassword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblname.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Private Sub FrmDrugsPresc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        cboclinic.Text = ""
        txtdiag.Text = ""
        txtdrugname.Text = ""
        txtpassword.Text = ""
        txtprescription.Text = ""
        txtdrugid.Text = ""

    End Sub

    Private Sub txtdrugname_Leave(sender As Object, e As EventArgs) Handles txtdrugname.Leave
        cmd = New SqlCommand("Select * from Drug_List where Drug_Name=@Dname", con)
        cmd.Parameters.Add("@Dname", SqlDbType.NVarChar).Value = txtdrugname.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the drug id

            txtdrugid.Text = tbl.Rows(0)(2).ToString()

        Else


        End If
    End Sub

    ''/// This will be use on ANC form
    Public Sub PopulatePendDrugPrescANC()

        Try

            '' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_DrugPresc Values ('" & dgprescription.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', 
            '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiag.Text & "', '" & lblname.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_DrugPresc VALUES(@Pno, @Dtes, @tims, @Hno, @Snam, @Onam, @Ag, @Sx, @Act, @ActCt, @Cli, @Diag, @Prby)", con)

            cmd.Parameters.Add("@Pno", SqlDbType.Int).Value = dgprescription.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dtes", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tims", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
            cmd.Parameters.Add("@snam", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
            cmd.Parameters.Add("@onam", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
            cmd.Parameters.Add("@Ag", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
            cmd.Parameters.Add("@Sx", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.NVarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
            cmd.Parameters.Add("@Actct", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
            cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtdiag.Text
            cmd.Parameters.Add("@Prby", SqlDbType.VarChar).Value = lblname.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveANCprescription()

        generatenum()
        PopulatePendDrugPrescANC()
        '//Thhis will save to AllDrugprescrition table
        Try


            For Each row As DataGridViewRow In dgprescription.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllDrugPresc VALUES(@Prescid, @Date, @Time, @Did, @DrgName, @Presc, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Actcat, @Clinic, @Diag, @PrescBY)", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@PrescId", row.Cells("Presc_Num").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Did", row.Cells("Drugid").Value)
                        cmd.Parameters.AddWithValue("@DrgName", row.Cells("Drug_Name").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Presc", row.Cells("Prescription").Value) '// Insert the value in the Datagridview Prescription cell
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
                        cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiag.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblname.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PRESCRIPTION SENT", vbOKOnly, "DRUGS PRESCRIPTION")

            dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnANCdrugs_Click(sender As Object, e As EventArgs) Handles BtnANCdrugs.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "DRUGS PRESC.")
            cboclinic.Focus()

        ElseIf txtdiag.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "DRUGS PRESC.")
            txtdiag.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "DRUGS PRESC.")
            txtpassword.Focus()

        Else

            SaveANCprescription()

            Me.Close()
            txtpassword.Text = ""
            lblname.Text = ""
            txtdiag.Text = ""


        End If
        FrmPharmacy.SortPendlist()
        FrmPtRecords.PtDrugs11.LoadDrugsHx()
        FrmAdmitFolder.InpatientDrugsHx1.LoadDrugsHx()
        FrmSurgery.TheatreDrugs1.LoadDrugsHx()
        frmGenConsult.LoadDrugsHx()
        con.Close()

    End Sub


    '//THIS WILL SAVE FOR DRUGS REQUESTED FROM THE WARD

    Public Sub SaveWARDprescription()

        generatenum()
        PopulatePendDrugPrescWARD()
        '//Thhis will save to AllDrugprescrition table
        Try


            For Each row As DataGridViewRow In dgprescription.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllDrugPresc VALUES(@Prid, @Dates, @Times, @Dids, @DrgNames, @Prescs, @Hospnums, @Surnames, @Onames, @Ages, @Sexs, @Accounts, @Actcats, @Clinics, @Diags, @PrescBYs)", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@PrId", row.Cells("Presc_Num").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.Add("@Dates", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Times", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Dids", row.Cells("Drugid").Value)
                        cmd.Parameters.AddWithValue("@DrgNames", row.Cells("Drug_Name").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Prescs", row.Cells("Prescription").Value) '// Insert the value in the Datagridview Prescription cell
                        cmd.Parameters.Add("@Hospnums", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                        cmd.Parameters.Add("@Surnames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
                        cmd.Parameters.Add("@Onames", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
                        cmd.Parameters.Add("@Ages", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
                        cmd.Parameters.Add("@Sexs", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
                        cmd.Parameters.Add("@Accounts", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
                        cmd.Parameters.Add("@Actcats", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
                        cmd.Parameters.Add("@Clinics", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diags", SqlDbType.VarChar).Value = txtdiag.Text
                        cmd.Parameters.Add("@PrescBYs", SqlDbType.VarChar).Value = lblname.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PRESCRIPTION SENT", vbOKOnly, "Medx-pro")

            dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub PopulatePendDrugPrescWARD()

        Try

            '' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_DrugPresc Values ('" & dgprescription.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', 
            '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiag.Text & "', '" & lblname.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_DrugPresc VALUES(@Pnos, @Dts, @tms, @Hnu, @Snams, @Onams, @Ags, @Sxs, @Acts, @ActCts, @Clis, @Diags, @Prbys)", con)

            cmd.Parameters.Add("@Pnos", SqlDbType.Int).Value = dgprescription.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dts", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tms", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Hnu", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
            cmd.Parameters.Add("@snams", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsurname.Text
            cmd.Parameters.Add("@onams", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtothernames.Text
            cmd.Parameters.Add("@Ags", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtyear.Text
            cmd.Parameters.Add("@Sxs", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtsex.Text
            cmd.Parameters.Add("@Acts", SqlDbType.NVarChar).Value = FrmAdmitFolder.Profile1.txtaccount.Text
            cmd.Parameters.Add("@Actcts", SqlDbType.VarChar).Value = FrmAdmitFolder.Profile1.txtprov.Text
            cmd.Parameters.Add("@Clis", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Diags", SqlDbType.NVarChar).Value = txtdiag.Text
            cmd.Parameters.Add("@Prbys", SqlDbType.VarChar).Value = lblname.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub BtnSaveWard_Click(sender As Object, e As EventArgs) Handles BtnSaveWard.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiag.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiag.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveWARDprescription()

            Me.Close()
            txtpassword.Text = ""
            lblname.Text = ""
            txtdiag.Text = ""


        End If
        FrmPharmacy.SortPendlist()
        FrmPtRecords.PtDrugs11.LoadDrugsHx()
        FrmAdmitFolder.InpatientDrugsHx1.LoadDrugsHx()
        FrmSurgery.TheatreDrugs1.LoadDrugsHx()
        frmGenConsult.LoadDrugsHx()
        con.Close()


    End Sub

    '//THIS WILL SAVE FOR DRUGS REQUESTED FROM THE THEATRE

    Public Sub SaveTheatrePresc()

        generatenum()
        PopulatePendTheatrePresc()
        '//Thhis will save to AllDrugprescrition table
        Try


            For Each row As DataGridViewRow In dgprescription.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllDrugPresc VALUES(@Pid, @Dats, @Tims, @Did, @DNames, @Precs, @Hpnums, @Sunames, @Othnames, @Ags, @Sxs, @Acounts, @Actcts, @Clnics, @Digs, @PreBYs)", con)

                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.

                        cmd.Parameters.AddWithValue("@PId", row.Cells("Presc_Num").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.Add("@Dats", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Tims", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@Did", row.Cells("Drugid").Value)
                        cmd.Parameters.AddWithValue("@DNames", row.Cells("Drug_Name").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Precs", row.Cells("Prescription").Value) '// Insert the value in the Datagridview Prescription cell
                        cmd.Parameters.Add("@Hpnums", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
                        cmd.Parameters.Add("@Sunames", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
                        cmd.Parameters.Add("@Othnames", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
                        cmd.Parameters.Add("@Ags", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
                        cmd.Parameters.Add("@Sxs", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
                        cmd.Parameters.Add("@Acounts", SqlDbType.VarChar).Value = FrmSurgery.TxtAcct.Text
                        cmd.Parameters.Add("@Actcts", SqlDbType.VarChar).Value = FrmSurgery.TxtAccTyp.Text
                        cmd.Parameters.Add("@Clnics", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Digs", SqlDbType.VarChar).Value = txtdiag.Text
                        cmd.Parameters.Add("@PreBYs", SqlDbType.VarChar).Value = lblname.Text

                        '// Insert also the other objects values

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PRESCRIPTION SENT", vbOKOnly, "Medx-pro")

            dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub PopulatePendTheatrePresc()

        Try

            '' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pend_DrugPresc Values ('" & dgprescription.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', 
            '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiag.Text & "', '" & lblname.Text.ToString & "')"

            cmd = New SqlCommand("INSERT INTO Pend_DrugPresc VALUES(@Pnos, @Dts, @tms, @Hnu, @Snams, @Onams, @Ags, @Sxs, @Acts, @ActCts, @Clis, @Diags, @Prbys)", con)

            cmd.Parameters.Add("@Pnos", SqlDbType.Int).Value = dgprescription.Rows(0).Cells(0).Value
            cmd.Parameters.Add("@dts", SqlDbType.Date).Value = Convert.ToDateTime(lbldate.Text).Date
            cmd.Parameters.Add("@Tms", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Hnu", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
            cmd.Parameters.Add("@snams", SqlDbType.VarChar).Value = FrmSurgery.TxtSurname.Text
            cmd.Parameters.Add("@onams", SqlDbType.VarChar).Value = FrmSurgery.TxtOname.Text
            cmd.Parameters.Add("@Ags", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
            cmd.Parameters.Add("@Sxs", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
            cmd.Parameters.Add("@Acts", SqlDbType.NVarChar).Value = FrmSurgery.TxtAcct.Text
            cmd.Parameters.Add("@Actcts", SqlDbType.VarChar).Value = FrmSurgery.TxtAccTyp.Text
            cmd.Parameters.Add("@Clis", SqlDbType.VarChar).Value = cboclinic.Text
            cmd.Parameters.Add("@Diags", SqlDbType.NVarChar).Value = txtdiag.Text
            cmd.Parameters.Add("@Prbys", SqlDbType.VarChar).Value = lblname.Text

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub BtnSAveTheatre_Click(sender As Object, e As EventArgs) Handles BtnSAveTheatre.Click
        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiag.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiag.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            SaveTheatrePresc()

            Me.Close()
            txtpassword.Text = ""
            lblname.Text = ""
            txtdiag.Text = ""


        End If
        FrmPharmacy.SortPendlist()
        FrmPtRecords.PtDrugs11.LoadDrugsHx()
        FrmAdmitFolder.InpatientDrugsHx1.LoadDrugsHx()
        FrmSurgery.TheatreDrugs1.LoadDrugsHx()
        frmGenConsult.LoadDrugsHx()
        con.Close()
    End Sub


    '// SAVE DRUGS PRESCRIBE FROM FOLLOWUP
    Private Sub BtnSaveFlwUp_Click(sender As Object, e As EventArgs) Handles BtnSaveFlwUp.Click
        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboclinic.Focus()

        ElseIf txtdiag.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "Medx-pro")
            txtdiag.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Focus()

        Else

            Saveprescription()  '/ USED FRO SAVING DRUGS FROM FOLLOWUP

            Me.Close()
            txtpassword.Text = ""
            lblname.Text = ""
            txtdiag.Text = ""


        End If
        FrmPharmacy.SortPendlist()
        FrmPtRecords.PtDrugs11.LoadDrugsHx()
        FrmAdmitFolder.InpatientDrugsHx1.LoadDrugsHx()
        FrmSurgery.TheatreDrugs1.LoadDrugsHx()
        frmGenConsult.LoadDrugsHx()
        con.Close()
    End Sub





    '// note i added Presc_num column to the gridview and i made invisible
    ' so i need to code to save all the 
End Class