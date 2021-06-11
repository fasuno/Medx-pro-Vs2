Imports System.Data.SqlClient
Public Class SurgicalTeam
    Public Sub SAVESURGTEAM()

        Try

            cmd = New SqlCommand("INSERT INTO Surgical_Team VALUES(@SurgId, @SurgDat, @Hno, @Sex, @Age, @Diag, @Opr, @Lsurg, @Rsurg, @PhyAss, @Oth, @Anas, @NurAnas, @ScrNur, @CirNur, @MedStd1, @MedStd2, @MedStd3, @MedStd4, @Stech1, @Stech2, @CompRep1, @CompRep2, @EntBy)", con)

            cmd.Parameters.Add("@SurgId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
            cmd.Parameters.Add("@SurgDat", SqlDbType.Date).Value = FrmSurgery.TxtSurgDate.Value.Date
            ' cmd.Parameters.Add("@SurgTim", SqlDbType.NChar).Value =
            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
            cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmSurgery.Txtsex.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmSurgery.TxtAge.Text
            cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = FrmSurgery.TxtDiag.Text
            cmd.Parameters.Add("@Opr", SqlDbType.VarChar).Value = FrmSurgery.TxtOper.Text
            cmd.Parameters.Add("@Lsurg", SqlDbType.VarChar).Value = TxtLeadSurg.Text
            cmd.Parameters.Add("@Rsurg", SqlDbType.VarChar).Value = TxtResSurg.Text
            cmd.Parameters.Add("@PhyAss", SqlDbType.VarChar).Value = TxtPhyAsst.Text
            cmd.Parameters.Add("@Oth", SqlDbType.VarChar).Value = TxtOthers.Text
            cmd.Parameters.Add("@Anas", SqlDbType.VarChar).Value = TxtAnesth.Text
            cmd.Parameters.Add("@NurAnas", SqlDbType.VarChar).Value = TxtAnesNurs.Text
            cmd.Parameters.Add("@ScrNur", SqlDbType.VarChar).Value = TxtScrubNurs.Text
            cmd.Parameters.Add("@CirNur", SqlDbType.VarChar).Value = TxtCircNur.Text
            cmd.Parameters.Add("@MedStd1", SqlDbType.VarChar).Value = TxtMedStd1.Text
            cmd.Parameters.Add("@MedStd2", SqlDbType.VarChar).Value = TxtMedStd2.Text
            cmd.Parameters.Add("@MedStd3", SqlDbType.VarChar).Value = TxtMedStd3.Text
            cmd.Parameters.Add("@MedStd4", SqlDbType.VarChar).Value = TxtMedStd4.Text
            cmd.Parameters.Add("@Stech1", SqlDbType.VarChar).Value = TxtSurTech1.Text
            cmd.Parameters.Add("@Stech2", SqlDbType.VarChar).Value = TxtSurTech2.Text
            cmd.Parameters.Add("@CompRep1", SqlDbType.VarChar).Value = TxtCompRep1.Text
            cmd.Parameters.Add("@CompRep2", SqlDbType.VarChar).Value = TxtCompRep2.Text
            cmd.Parameters.Add("@EntBy", SqlDbType.VarChar).Value = FrmSurgery.lbluser.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ' MsgBox("SUCCESSFUL", MsgBoxStyle.Information, "APPOINTMENT")
            ClearSurgTeam()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub LoadSurgTeam()

        cmd = New SqlCommand("Select * from Surgical_Team where Hospital_No=@Hosp_Num AND Surgery_ID=@SurID ", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
        cmd.Parameters.Add("@SurID", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            TxtLeadSurg.Text = tbl.Rows(0)(7).ToString()
            TxtResSurg.Text = tbl.Rows(0)(8).ToString()
            TxtPhyAsst.Text = tbl.Rows(0)(9).ToString()
            TxtOthers.Text = tbl.Rows(0)(10).ToString()
            TxtAnesth.Text = tbl.Rows(0)(11).ToString()
            TxtAnesNurs.Text = tbl.Rows(0)(12).ToString()
            TxtScrubNurs.Text = tbl.Rows(0)(13).ToString()
            TxtCircNur.Text = tbl.Rows(0)(14).ToString()
            TxtMedStd1.Text = tbl.Rows(0)(15).ToString()
            TxtMedStd2.Text = tbl.Rows(0)(16).ToString()
            TxtMedStd3.Text = tbl.Rows(0)(17).ToString()
            TxtMedStd4.Text = tbl.Rows(0)(18).ToString()
            TxtSurTech1.Text = tbl.Rows(0)(19).ToString()
            TxtSurTech2.Text = tbl.Rows(0)(20).ToString()
            TxtCompRep1.Text = tbl.Rows(0)(21).ToString()
            TxtCompRep2.Text = tbl.Rows(0)(22).ToString()

            FrmSurgery.BtnUpdate.Visible = True
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = False
            FrmSurgery.Label10.Visible = True

        Else

            ' ClearSurgTeam()

            FrmSurgery.BtnUpdate.Visible = False
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = True
            FrmSurgery.Label10.Visible = True

        End If
    End Sub
    Public Sub UpdateSurgTeam()
        Try
            cmd = New SqlCommand("UPDATE Surgical_Team SET Surgery_Date=@Sdat, Lead_Surgeon=@Ldsurg, Resident_Surgeon=@ResSurg, Physician_Assistant=@Passt, Others=@Other, Anesthesiologist=@Ans, Nurse_Anesthetist=@Nanas, Scrub_Nurse=@Snur, Circulating_Nurse=@CNur, Med_Student1=@MStd1, Med_Student2=@MStd2, Med_Student3=@MStd3, Med_Student4=@MStd4, Surgical_Tech1=@Tech1, Surgical_Tech2=@Tech2, Comp_Rep1=@CRep1, Comp_Rep2=@CRep2, Entry_By=@EnBy WHERE Surgery_ID=@Sid AND Hospital_No=@Hnum")

            cmd.Parameters.Add("@SDat", SqlDbType.Date).Value = FrmSurgery.TxtSurgDate.Value.Date
            cmd.Parameters.Add("@Ldsurg", SqlDbType.VarChar).Value = TxtLeadSurg.Text
            cmd.Parameters.Add("@ResSurg", SqlDbType.VarChar).Value = TxtResSurg.Text
            cmd.Parameters.Add("@Passt", SqlDbType.VarChar).Value = TxtPhyAsst.Text
            cmd.Parameters.Add("@Other", SqlDbType.VarChar).Value = TxtOthers.Text
            cmd.Parameters.Add("@Ans", SqlDbType.VarChar).Value = TxtAnesth.Text
            cmd.Parameters.Add("@Nanas", SqlDbType.VarChar).Value = TxtAnesNurs.Text
            cmd.Parameters.Add("@Snur", SqlDbType.VarChar).Value = TxtScrubNurs.Text
            cmd.Parameters.Add("@CNur", SqlDbType.VarChar).Value = TxtCircNur.Text
            cmd.Parameters.Add("@MStd1", SqlDbType.VarChar).Value = TxtMedStd1.Text
            cmd.Parameters.Add("@MStd2", SqlDbType.VarChar).Value = TxtMedStd2.Text
            cmd.Parameters.Add("@MStd3", SqlDbType.VarChar).Value = TxtMedStd3.Text
            cmd.Parameters.Add("@MStd4", SqlDbType.VarChar).Value = TxtMedStd4.Text
            cmd.Parameters.Add("@Tech1", SqlDbType.VarChar).Value = TxtSurTech1.Text
            cmd.Parameters.Add("@Tech2", SqlDbType.VarChar).Value = TxtSurTech2.Text
            cmd.Parameters.Add("@CRep1", SqlDbType.VarChar).Value = TxtCompRep1.Text
            cmd.Parameters.Add("@CRep2", SqlDbType.VarChar).Value = TxtCompRep2.Text
            cmd.Parameters.Add("@EnBy", SqlDbType.VarChar).Value = FrmSurgery.lbluser.Text

            cmd.Parameters.Add("@SId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
            cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            ClearSurgTeam()
        Catch ex As Exception
            MessageBox.Show("Error, while updating Surgery team ", "Medx-pro", MessageBoxButtons.OK)

        End Try

    End Sub
    Public Sub ClearSurgTeam()

        TxtAnesNurs.Text = ""
        TxtAnesth.Text = ""
        TxtCircNur.Text = ""
        TxtCompRep1.Text = ""
        TxtCompRep2.Text = ""
        TxtLeadSurg.Text = ""
        TxtMedStd1.Text = ""
        TxtMedStd2.Text = ""
        TxtMedStd3.Text = ""
        TxtMedStd4.Text = ""
        TxtOthers.Text = ""
        TxtPhyAsst.Text = ""
        TxtResSurg.Text = ""
        TxtScrubNurs.Text = ""
        TxtSurTech1.Text = ""
        TxtSurTech2.Text = ""
    End Sub

End Class
