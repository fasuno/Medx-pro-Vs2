Imports System.Data.SqlClient
Public Class OperatioNote
    Public Sub SaveOPNote()
        Try

            cmd = New SqlCommand("INSERT INTO OperationNotes VALUES(@SurgId, @SurgDat, @TimSp, @Diag, @Opr, @Find, @Proc, @Pos, @Proph, @CloTech, @Anas, @PostOp)", con)

            cmd.Parameters.Add("@SurgId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
            cmd.Parameters.Add("@SurgDat", SqlDbType.Date).Value = DtSurgDat.Value.Date
            cmd.Parameters.Add("@Timsp", SqlDbType.VarChar).Value = TxtTimespent.Text
            cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = TxtDiag.Text
            cmd.Parameters.Add("@Opr", SqlDbType.VarChar).Value = TxtOPer.Text
            cmd.Parameters.Add("@Find", SqlDbType.VarChar).Value = TxtFindings.Text
            cmd.Parameters.Add("@Proc", SqlDbType.VarChar).Value = Txtproced.Text
            cmd.Parameters.Add("@Pos", SqlDbType.VarChar).Value = TxtPosition.Text
            cmd.Parameters.Add("@Proph", SqlDbType.VarChar).Value = TxtProph.Text
            cmd.Parameters.Add("@Clotech", SqlDbType.VarChar).Value = TxtClose.Text
            cmd.Parameters.Add("@Anas", SqlDbType.VarChar).Value = TxtAnaes.Text
            cmd.Parameters.Add("@PostOp", SqlDbType.NVarChar).Value = FrmSurgery.PostOpOrder1.Txtpostop.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ' MsgBox("SUCCESSFUL", MsgBoxStyle.Information, "APPOINTMENT")
            CLearOPnOte()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub LoadOpNotes()

        cmd = New SqlCommand("Select * from OperationNotes Where Surgery_ID=@SurID ", con)
        'cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmSurgery.TxthospNo.Text
        cmd.Parameters.Add("@SurID", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            DtSurgDat.Value = tbl.Rows(0)(1)
            TxtTimespent.Text = tbl.Rows(0)(2).ToString()
            TxtDiag.Text = tbl.Rows(0)(3).ToString()
            TxtOPer.Text = tbl.Rows(0)(4).ToString()
            TxtFindings.Text = tbl.Rows(0)(5).ToString()
            Txtproced.Text = tbl.Rows(0)(6).ToString()
            TxtPosition.Text = tbl.Rows(0)(7).ToString()
            TxtProph.Text = tbl.Rows(0)(8).ToString()
            TxtClose.Text = tbl.Rows(0)(9).ToString()
            TxtAnaes.Text = tbl.Rows(0)(10).ToString()

            FrmSurgery.BtnUpdate.Visible = True
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = False
            FrmSurgery.Label10.Visible = True

        Else

            'CLearOPnOte()

            FrmSurgery.BtnUpdate.Visible = False
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = True
            FrmSurgery.Label10.Visible = True

        End If
    End Sub
    Public Sub UpdateOpNotes()

        Try

            cmd = New SqlCommand("UPDATE OperationNotes SET Surgery_Date=@SDat, Time_Spent=@TSpnt, Diagnosis=@Diagn, Operation=@Oprt, Findings=@Findgs, Procedures=@Procd, Positioning=@Posn, Prophylaxis=@Prophx, Closure_Technique=@CTech, Anaesthesia=@Anast, Post_OpOrder=@PosOp WHERE Surgery_ID=@Sid")

            cmd.Parameters.Add("@SDat", SqlDbType.Date).Value = DtSurgDat.Value.Date
            cmd.Parameters.Add("@Tspnt", SqlDbType.VarChar).Value = TxtTimespent.Text
            cmd.Parameters.Add("@Diagn", SqlDbType.VarChar).Value = TxtDiag.Text
            cmd.Parameters.Add("@Oprt", SqlDbType.VarChar).Value = TxtOPer.Text
            cmd.Parameters.Add("@Findgs", SqlDbType.VarChar).Value = TxtFindings.Text
            cmd.Parameters.Add("@Procd", SqlDbType.VarChar).Value = Txtproced.Text
            cmd.Parameters.Add("@Posn", SqlDbType.VarChar).Value = TxtPosition.Text
            cmd.Parameters.Add("@Prophx", SqlDbType.VarChar).Value = TxtProph.Text
            cmd.Parameters.Add("@Ctech", SqlDbType.VarChar).Value = TxtClose.Text
            cmd.Parameters.Add("@Anast", SqlDbType.VarChar).Value = TxtAnaes.Text
            cmd.Parameters.Add("@PosOp", SqlDbType.NVarChar).Value = FrmSurgery.PostOpOrder1.Txtpostop.Text

            cmd.Parameters.Add("@SId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            CLearOPnOte()
        Catch ex As Exception
            MessageBox.Show("Error, while updating OpNote ", "Medx-pro", MessageBoxButtons.OK)

        End Try

    End Sub
    Public Sub CLearOPnOte()
        TxtTimespent.Text = ""
        TxtProph.Text = ""
        Txtproced.Text = ""
        TxtPosition.Text = ""
        TxtOPer.Text = ""
        TxtFindings.Text = ""
        TxtDiag.Text = ""
        TxtClose.Text = ""
        TxtAnaes.Text = ""

    End Sub


End Class
