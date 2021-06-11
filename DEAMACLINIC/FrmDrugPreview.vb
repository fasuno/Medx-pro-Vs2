Imports System.Data.SqlClient

Public Class FrmDrugPreview
    Public Sub ShowDrugs()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Drug_name, Prescription from VWALLDRUGSPRESC WHERE Presc_Num = @pnum", con)

        cmd.Parameters.Add("@pnum", SqlDbType.Int).Value = FrmPtRecords.PtDrugs11.DtgDrugshx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.Dtgdrugprev.DataSource = tbl
        Dtgdrugprev.AutoResizeColumns()
    End Sub

    Public Sub ShowDrugsForTheatre()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Drug_name, Prescription from AllDrugPresc WHERE Presc_Num = @pnom", con)

        cmd.Parameters.Add("@pnom", SqlDbType.Int).Value = FrmSurgery.TheatreDrugs1.DtgDrugshx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.Dtgdrugprev.DataSource = tbl
        Dtgdrugprev.AutoResizeColumns()
    End Sub

    Public Sub ShowDrugsForInpatient()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Drug_name, Prescription from AllDrugPresc WHERE Presc_Num = @pnum", con)

        cmd.Parameters.Add("@pnum", SqlDbType.Int).Value = FrmAdmitFolder.InpatientDrugsHx1.DtgDrugshx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.Dtgdrugprev.DataSource = tbl
        Dtgdrugprev.AutoResizeColumns()
    End Sub

    Private Sub BtnChart_Click(sender As Object, e As EventArgs) Handles BtnChart.Click
        Try


            For Each row As DataGridViewRow In Dtgdrugprev.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO DrugsChart VALUES(@AdmID, @Dte, @Drg, @Pre, @Dos, @Qty, @Tim, @Rout, @Dgvn)", con)


                        cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        cmd.Parameters.AddWithValue("@Drg", row.Cells(0).Value)
                        cmd.Parameters.AddWithValue("@Pre", row.Cells(1).Value)

                        '// Send Null values

                        cmd.Parameters.Add("@Dos", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Qty", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Tim", SqlDbType.Time).Value = DBNull.Value
                        cmd.Parameters.Add("@Rout", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Dgvn", SqlDbType.Date).Value = DBNull.Value
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("DRUGS CHART SUCCESSFULLY CREATED", vbOKOnly, "Medx-pro")

            Me.Close()
            ' Dtgdrugprev.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class