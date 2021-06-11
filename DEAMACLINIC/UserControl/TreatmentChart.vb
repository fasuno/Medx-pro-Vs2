Imports System.Data.SqlClient
Public Class TreatmentChart
    Public Sub LoadchartedDrugs()

        cmd = New SqlCommand("Select Drug_Name As 'Drug Name', Prescription, Dosage, Qty_Given As 'Quantity Given', Route, Date_Given As 'Date Given', Time_Given As 'Time given' from DrugsChart where AdmissionID=@AdmId", con)
        cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgChartdrugs.DataSource = tbl
            DtgChartdrugs.Columns(0).ReadOnly = True
            DtgChartdrugs.Columns(1).ReadOnly = True

            For sa As Integer = 0 To DtgChartdrugs.Rows.Count() - 1
                DtgChartdrugs.Rows(sa).Cells(5).Value = Now.ToShortDateString
                DtgChartdrugs.Rows(sa).Cells(6).Value = Now.ToShortTimeString
            Next
        End If
    End Sub

    Public Sub LoadDrugsChartHX()

        cmd = New SqlCommand("Select DISTINCT Chart_ID, Admit_ID, Date_Given As 'Date Given', Time_Given As 'Time given', Nurse FROM TreatmentChart WHERE Admit_ID=@AId", con)
        cmd.Parameters.Add("@AId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tb As New DataTable

        adapt.Fill(tb)
        DtgDrugsChartHx.DataSource = tb

        DtgDrugsChartHx.Columns(0).Visible = False
        DtgDrugsChartHx.Columns(1).Visible = False

    End Sub

    Sub generateChartID()

        Try
            con.Open()

            cmd = New SqlCommand("Select  MAX(Chart_ID) from TreatmentChart", con)
            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then

                Me.LblChartID.Text = dt.Item(0) + 1
                dt.Close()
            Else

                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Txtnurse.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
        Else

            generateChartID()

            Try

                For Each row As DataGridViewRow In DtgChartdrugs.Rows

                    Using con As New SqlConnection(constring)
                        Using cmd As New SqlCommand("INSERT INTO TreatmentChart VALUES(@Chatno, @AdID, @Hno, @Diag, @Dgname, @Presc, @Dsg, @Qgiv, @Rte, @Dgiv, @Tgiv, @Nurs)", con)

                            cmd.Parameters.Add("@Chatno", SqlDbType.Int).Value = LblChartID.Text
                            cmd.Parameters.Add("@AdID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                            cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = FrmAdmitFolder.Lbldiag.Text
                            cmd.Parameters.AddWithValue("@Dgname", row.Cells("Drug Name").Value)
                            cmd.Parameters.AddWithValue("@Presc", row.Cells("Prescription").Value)
                            cmd.Parameters.AddWithValue("@Dsg", row.Cells("Dosage").Value)
                            cmd.Parameters.AddWithValue("@Qgiv", row.Cells("Quantity Given").Value)
                            cmd.Parameters.AddWithValue("@Rte", row.Cells("Route").Value)
                            cmd.Parameters.AddWithValue("@Dgiv", row.Cells("Date Given").Value)
                            cmd.Parameters.AddWithValue("@Tgiv", row.Cells("Time Given").Value)

                            cmd.Parameters.Add("@Nurs", SqlDbType.VarChar).Value = Lblnurse.Text

                            cmd.Connection = con
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                Next
                MsgBox("DRUGS CHART SAVED SUCCEFULLY", MsgBoxStyle.Information, "Medx-pro")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            con.Close()
            LoadDrugsChartHX()
        End If
    End Sub

    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)
        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtnurse.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            Txtnurse.Focus()

        Else

        End If
    End Sub

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtnurse.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            Lblnurse.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Private Sub Txtnurse_Leave(sender As Object, e As EventArgs) Handles Txtnurse.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Private Sub DtgDrugsChartHx_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DtgDrugsChartHx.CellMouseDoubleClick

        DtgChartdrugs.DataSource = Nothing

        cmd = New SqlCommand("Select Drug_Name As 'Drug Name', Prescription, Dosage, Qty_Given As 'Quantity Given', Route, Date_Given As 'Date Given', Time_Given As 'Time given' from TreatmentChart where  Chart_ID=@Cid AND Admit_ID=@AdtId", con)

        cmd.Parameters.Add("@CId", SqlDbType.Int).Value = DtgDrugsChartHx.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("@AdtID", SqlDbType.Int).Value = DtgDrugsChartHx.CurrentRow.Cells(1).Value
        adapt = New SqlDataAdapter(cmd)

        Dim tbls As New DataTable

        adapt.Fill(tbls)
        DtgChartdrugs.DataSource = tbls

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadchartedDrugs()
    End Sub

End Class
