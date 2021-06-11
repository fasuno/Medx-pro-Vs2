Imports System.Data.SqlClient
Public Class FluidBalChart
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub LoadTimeIn()
        Dim tb As New DataTable
        cmd = New SqlCommand("Select Time, Type, Tube, Oral, IV FROM FluidTime", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        DtgFluidIn.DataSource = tb

        DtgFluidIn.Columns(0).Width = 50
        DtgFluidIn.Columns(1).Width = 180
        DtgFluidIn.Columns(2).Width = 50
        DtgFluidIn.Columns(3).Width = 50
        DtgFluidIn.Columns(4).Width = 50
        DtgFluidIn.Columns(0).ReadOnly = True

    End Sub
    Public Sub LoadTimeOut()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Time, Type, Urine, Vomitus, Feases FROM FluidTime", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgFluidOut.DataSource = tbl

        DtgFluidOut.Columns(0).Width = 50
        DtgFluidOut.Columns(1).Width = 180
        DtgFluidOut.Columns(2).Width = 50
        DtgFluidOut.Columns(3).Width = 100
        DtgFluidOut.Columns(4).Width = 50
        DtgFluidOut.Columns(0).ReadOnly = True

    End Sub
    Public Sub LoadFluidBAl()

        Dim tbls As New DataTable
        cmd = New SqlCommand("Select * FROM FluidBalance WHERE Admit_ID=@Did", con)
        cmd.Parameters.Add("@DId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtgfluidbal.DataSource = tbls
        Dtgfluidbal.Columns(0).Visible = False
        Dtgfluidbal.Columns(5).Visible = False
        Dtgfluidbal.AutoResizeColumns()


    End Sub
    Private Sub FluidBalChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgFluidIn.DataSource = Nothing
        DtgFluidOut.DataSource = Nothing
    End Sub
    Sub generateChartID()

        Try
            con.Open()

            cmd = New SqlCommand("Select  MAX(Chart_Id) FROM FluidBalance", con)
            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then

                Me.Lblchartid.Text = dt.Item(0) + 1
                dt.Close()
            Else

                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub DtgFluidIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtgFluidIn.KeyPress
        '  If Asc(e.KeyChar) <> 8 Then
        ' If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        'e.Handled = True
        'End If
        'End If
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        generateChartID()
        LoadTimeOut()
        LoadTimeIn()
        BalForward()

        TxtFeases.Text = 0
        TxtIV.Text = 0
        TxtOral.Text = 0
        TxtTotOut.Text = 0
        TxtTotIn.Text = 0
        TxtTube.Text = 0
        TxtUrine.Text = 0
        TxtVomit.Text = 0


        SaveFluidBalIN()
        SaveFluidBalOUT()
        SaveTofluidBAl()
    End Sub
    Public Sub GetTotalsIN()

        Dim TotTub As Integer = 0
        Dim TotOrl As Integer = 0
        Dim TotIv As Integer = 0
        'Dim TotUrn As Integer = 0
        'Dim TotVom As Integer = 0
        'Dim TotFeas As Integer = 0

        For sa As Integer = 0 To DtgFluidIn.Rows.Count() - 1

            TotTub += Val(DtgFluidIn.Rows(sa).Cells(2).Value)
            TotOrl += Val(DtgFluidIn.Rows(sa).Cells(3).Value)
            TotIv += Val(DtgFluidIn.Rows(sa).Cells(4).Value)

        Next

        TxtTube.Text = TotTub
        TxtOral.Text = TotOrl
        TxtIV.Text = TotIv

        TxtTotIn.Text = Val(TxtTube.Text) + Val(TxtOral.Text) + Val(TxtIV.Text)

    End Sub
    Public Sub GetTotalsOUT()

        Dim TotUrn As Integer = 0
        Dim TotVom As Integer = 0
        Dim TotFeas As Integer = 0

        For s As Integer = 0 To DtgFluidOut.Rows.Count() - 1

            TotUrn += Val(DtgFluidOut.Rows(s).Cells(2).Value)
            TotVom += Val(DtgFluidOut.Rows(s).Cells(3).Value)
            TotFeas += Val(DtgFluidOut.Rows(s).Cells(4).Value)

        Next

        TxtUrine.Text = TotUrn
        TxtVomit.Text = TotVom
        TxtFeases.Text = TotFeas

        TxtTotOut.Text = Val(TxtUrine.Text) + Val(TxtVomit.Text) + Val(TxtFeases.Text)

    End Sub
    Private Sub DtgFluidIn_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DtgFluidIn.CellEndEdit
        GetTotalsIN()

        UpdateFluidBalIn()
        UpdateResultentry()
        LoadFluidBAl()
    End Sub
    Private Sub DtgFluidOut_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DtgFluidOut.CellEndEdit
        GetTotalsOUT()
        TxtBal.Text = Val(TxtTotIn.Text) - Val(TxtTotOut.Text) + Val(TxtBal.Text)
        UpdateFluidBalOut()
        UpdateResultentry()
        LoadFluidBAl()
    End Sub
    Public Sub SaveFluidBalIN()

        Try

            For Each row As DataGridViewRow In DtgFluidIn.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO FluidBalanceIN VALUES(@ChrtId, @Date, @Tim, @Tp, @Tub, @Orl, @IVs, @Tottub, @TotOrl, @TotIv, @TotIn, @FluidRet, @AdmID)", con)

                        cmd.Parameters.Add("@ChrtId", SqlDbType.Int).Value = Lblchartid.Text
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        cmd.Parameters.AddWithValue("@Tim", row.Cells("Time").Value)
                        cmd.Parameters.AddWithValue("@Tp", row.Cells("Type").Value)
                        cmd.Parameters.AddWithValue("@Tub", row.Cells("Tube").Value)
                        cmd.Parameters.AddWithValue("@Orl", row.Cells("Oral").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@IVs", row.Cells("IV").Value) '// Insert the value in the Datagridview Prescription cell

                        cmd.Parameters.Add("@Tottub", SqlDbType.Int).Value = TxtTube.Text
                        cmd.Parameters.Add("@TotOrl", SqlDbType.Int).Value = TxtOral.Text
                        cmd.Parameters.Add("@TotIv", SqlDbType.Int).Value = TxtIV.Text

                        cmd.Parameters.Add("@TotIn", SqlDbType.Int).Value = TxtTotIn.Text
                        cmd.Parameters.Add("@FluidRet", SqlDbType.Int).Value = TxtBal.Text
                        cmd.Parameters.Add("@AdmID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            '  MsgBox("PRESCRIPTION SENT", vbOKOnly, "Medx-pro")

            ' dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveFluidBalOUT()

        Try

            For Each row As DataGridViewRow In DtgFluidOut.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO FluidBalanceOUT VALUES(@ChtId, @Dte, @Tim, @Typ, @Urin, @Vom, @Feas, @TotUrin, @TotVom, @TotFeas, @TotOut, @FldRet, @Admtid)", con)

                        cmd.Parameters.Add("@ChtId", SqlDbType.Int).Value = Lblchartid.Text
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        cmd.Parameters.AddWithValue("@Tim", row.Cells("Time").Value)
                        cmd.Parameters.AddWithValue("@Typ", row.Cells("Type").Value)
                        cmd.Parameters.AddWithValue("@Urin", row.Cells("Urine").Value)
                        cmd.Parameters.AddWithValue("@Vom", row.Cells("Vomitus").Value)
                        cmd.Parameters.AddWithValue("@Feas", row.Cells("Feases").Value)
                        cmd.Parameters.Add("@TotUrin", SqlDbType.Int).Value = TxtUrine.Text
                        cmd.Parameters.Add("@TotVom", SqlDbType.Int).Value = TxtVomit.Text
                        cmd.Parameters.Add("@TotFeas", SqlDbType.Int).Value = TxtFeases.Text

                        cmd.Parameters.Add("@TotOut", SqlDbType.Int).Value = TxtTotOut.Text
                        cmd.Parameters.Add("@FldRet", SqlDbType.Int).Value = TxtBal.Text
                        cmd.Parameters.Add("@AdmtID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

                        cmd.Connection = con

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            '  MsgBox("PRESCRIPTION SENT", vbOKOnly, "Medx-pro")

            ' dgprescription.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveTofluidBAl()

        Try
            cmd = New SqlCommand("INSERT INTO FluidBalance VALUES(@ChatId, @Dtes, @TotIn, @TotOut, @FldRet, @Admtid, @Entby)", con)

            cmd.Parameters.Add("@ChatId", SqlDbType.Int).Value = Lblchartid.Text
            cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
            cmd.Parameters.Add("@Totin", SqlDbType.Int).Value = TxtTotIn.Text
            cmd.Parameters.Add("@TotOut", SqlDbType.Int).Value = TxtTotOut.Text
            cmd.Parameters.Add("@FldRet", SqlDbType.Int).Value = TxtBal.Text

            cmd.Parameters.Add("@Admtid", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
            cmd.Parameters.Add("@EntBy", SqlDbType.VarChar).Value = LblUser.Text

            cmd.Connection = con

            con.Close()
            con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub UpdateFluidBalIn()

        Try

            For Each row As DataGridViewRow In DtgFluidIn.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("UPDATE FluidBalanceIN Set Type=@Tp, Tube=@tub, Oral=@Orl, IV=@Ivs, Total_Tube=@Tottub, Total_Oral=@Totorl, Total_IV=@TotIv, Total_In=@Totin, Fluid_retained=@FluidRet WHERE Time=@Tim AND Chart_ID=@Chrtid And Admit_Id=@AdmID", con)


                        ' cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        'cmd.Parameters.AddWithValue("@Tim", row.Cells("Time").Value)
                        cmd.Parameters.Add("@Tp", SqlDbType.VarChar).Value = DtgFluidIn.CurrentRow.Cells(1).Value
                        cmd.Parameters.Add("@Tub", SqlDbType.Int).Value = DtgFluidIn.CurrentRow.Cells(2).Value
                        cmd.Parameters.Add("@Orl", SqlDbType.Int).Value = DtgFluidIn.CurrentRow.Cells(3).Value
                        cmd.Parameters.Add("@IVs", SqlDbType.Int).Value = DtgFluidIn.CurrentRow.Cells(4).Value
                        ' cmd.Parameters.AddWithValue("@Tp", row.Cells("Type").Value)
                        'cmd.Parameters.AddWithValue("@Tub", row.Cells("Tube").Value)
                        ' cmd.Parameters.AddWithValue("@Orl", row.Cells("Oral").Value) '// Insert the value in the Datagridview Drug name cell
                        'cmd.Parameters.AddWithValue("@IVs", row.Cells("IV").Value) '// Insert the value in the Datagridview Prescription cell

                        cmd.Parameters.Add("@Tottub", SqlDbType.Int).Value = TxtTube.Text
                        cmd.Parameters.Add("@TotOrl", SqlDbType.Int).Value = TxtOral.Text
                        cmd.Parameters.Add("@TotIv", SqlDbType.Int).Value = TxtIV.Text
                        cmd.Parameters.Add("@TotIn", SqlDbType.Int).Value = TxtTotIn.Text
                        cmd.Parameters.Add("@FluidRet", SqlDbType.Int).Value = TxtBal.Text

                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = DtgFluidIn.CurrentRow.Cells(0).Value
                        cmd.Parameters.Add("@ChrtId", SqlDbType.Int).Value = Lblchartid.Text
                        cmd.Parameters.Add("@AdmID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text


                        cmd.Connection = con
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next
            ' MsgBox("DRUGS CHART SAVED SUCCEFULLY", MsgBoxStyle.Information, "Medx-pro")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        con.Close()

    End Sub
    Sub UpdateFluidBalOut()

        Try

            For Each row As DataGridViewRow In DtgFluidOut.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("UPDATE FluidBalanceOUT Set Type=@typ, Urine=@Urin, Vomitus=@Vom, Feases=@Feas, Total_Urine=@TotUrin, Total_Vomitus=@TotVom, Total_Feases=@TotFeas, Total_Out=@TotOut, Fluid_retained=@FldRet WHERE Time=@Tim AND Chart_ID=@Chrtid And  Admit_Id=@AdmtID", con)

                        cmd.Parameters.Add("@Typ", SqlDbType.VarChar).Value = DtgFluidOut.CurrentRow.Cells(1).Value
                        cmd.Parameters.Add("@Urin", SqlDbType.Int).Value = DtgFluidOut.CurrentRow.Cells(2).Value
                        cmd.Parameters.Add("@Vom", SqlDbType.Int).Value = DtgFluidOut.CurrentRow.Cells(3).Value
                        cmd.Parameters.Add("@Feas", SqlDbType.Int).Value = DtgFluidOut.CurrentRow.Cells(4).Value

                        'cmd.Parameters.AddWithValue("@Typ", row.Cells("Type").Value)
                        ' cmd.Parameters.AddWithValue("@Urin", row.Cells("Urine").Value)
                        'cmd.Parameters.AddWithValue("@Vom", row.Cells("Vomitus").Value)
                        'cmd.Parameters.AddWithValue("@Feas", row.Cells("Feases").Value)

                        cmd.Parameters.Add("@TotUrin", SqlDbType.Int).Value = TxtUrine.Text
                        cmd.Parameters.Add("@TotVom", SqlDbType.Int).Value = TxtVomit.Text
                        cmd.Parameters.Add("@TotFeas", SqlDbType.Int).Value = TxtFeases.Text

                        cmd.Parameters.Add("@TotOut", SqlDbType.Int).Value = TxtTotOut.Text
                        cmd.Parameters.Add("@FldRet", SqlDbType.Int).Value = TxtBal.Text

                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = DtgFluidOut.CurrentRow.Cells(0).Value
                        cmd.Parameters.Add("@ChrtId", SqlDbType.Int).Value = Lblchartid.Text
                        cmd.Parameters.Add("@AdmtID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text


                        cmd.Connection = con
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next
            ' MsgBox("DRUGS CHART SAVED SUCCEFULLY", MsgBoxStyle.Information, "Medx-pro")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        con.Close()

    End Sub
    Public Sub LoadChartOut()

        Dim tabl As New DataTable
        cmd = New SqlCommand("Select Time, Type, Urine, Vomitus, Feases FROM FluidBalanceOUT", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tabl)
        DtgFluidOut.DataSource = tabl

        DtgFluidOut.Columns(0).Width = 50
        DtgFluidOut.Columns(1).Width = 180
        DtgFluidOut.Columns(2).Width = 50
        DtgFluidOut.Columns(3).Width = 100
        DtgFluidOut.Columns(4).Width = 50
        DtgFluidOut.Columns(0).ReadOnly = True

    End Sub
    Public Sub LoadChartIn()

        Dim tbs As New DataTable
        cmd = New SqlCommand("Select Time, Type, Tube, Oral, IV FROM FluidBalanceIN", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbs)
        DtgFluidIn.DataSource = tbs

        DtgFluidIn.Columns(0).Width = 50
        DtgFluidIn.Columns(1).Width = 180
        DtgFluidIn.Columns(2).Width = 50
        DtgFluidIn.Columns(3).Width = 50
        DtgFluidIn.Columns(4).Width = 50
        DtgFluidIn.Columns(0).ReadOnly = True


    End Sub
    Public Sub UpdatefluidBAl()


        Try
            cmd = New SqlCommand("UPDATE FluidBalance SET Total_In=@TotIn, Total_out=@TotOut, Fluid_Retained=@FldRet, Entry_By=@Entby WHERE Chart_ID=@Cid", con)


            'cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
            cmd.Parameters.Add("@Totin", SqlDbType.Int).Value = TxtTotIn.Text
            cmd.Parameters.Add("@TotOut", SqlDbType.Int).Value = TxtTotOut.Text
            cmd.Parameters.Add("@FldRet", SqlDbType.Int).Value = TxtBal.Text
            cmd.Parameters.Add("@CId", SqlDbType.Int).Value = Lblchartid.Text
            ' cmd.Parameters.Add("@Admtid", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
            cmd.Parameters.Add("@EntBy", SqlDbType.VarChar).Value = LblUser.Text

            cmd.Connection = con

            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub UpdateResultentry()

        Try
            Dim Updat As String = "Update FluidBalance Set Total_In='" & TxtTotIn.Text & "', Total_Out='" & TxtTotOut.Text & "' WHERE Chart_ID='" & Lblchartid.Text & "' And  Admit_Id='" & FrmAdmitFolder.LbladmitID.Text & "'"

            'con.Open()
            ExecuteQuery(Updat)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub Dtgfluidbal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Dtgfluidbal.MouseDoubleClick

        LoadChartOut()
        LoadChartIn()
        GetTotalsIN()
        GetTotalsOUT()

        TxtBal.Text = Val(TxtTotIn.Text) - Val(TxtTotOut.Text)

        Lblchartid.Text = Dtgfluidbal.CurrentRow.Cells(0).Value

    End Sub
    Sub BalForward()

        cmd = New SqlCommand("Select TOP 1 Fluid_Retained from FluidBalance ORDER BY Chart_Id DESC", con)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)


        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            txtfldbal.Text = tbl.Rows(0)(0)
        End If
    End Sub
    Private Sub TxtPass_Leave(sender As Object, e As EventArgs) Handles TxtPass.Leave

        cmd = New SqlCommand("Select * from UsersReg where Password = @Passw", con)
        cmd.Parameters.Add("@Passw", SqlDbType.VarChar).Value = TxtPass.Text
        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtPass.Focus()

        Else
            LblUser.Text = tbl.Rows(0)(1).ToString()

        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtPass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtBal.Focus()
        Else

            UpdatefluidBAl()

            UpdateFluidBalIn()
            UpdateFluidBalOut()

            MsgBox("FLUID BALANCE SAVED SUCCESSFULLY", MsgBoxStyle.Information, "Medx-pro")

            TxtBal.Text = ""
            TxtFeases.Text = ""
            TxtIV.Text = ""
            TxtOral.Text = ""
            TxtPass.Text = ""
            TxtTotIn.Text = ""
            TxtTotOut.Text = ""
            TxtTube.Text = ""
            TxtVomit.Text = ""
            TxtUrine.Text = ""

            DtgFluidIn.DataSource = Nothing
            DtgFluidOut.DataSource = Nothing
            LoadFluidBAl()
        End If
    End Sub


End Class