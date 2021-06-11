Imports System.Data.SqlClient

Public Class PostOpOrder
    Public Sub LoadSurgTeam()

        cmd = New SqlCommand("Select * from OperationNotes where Surgery_ID=@SurID ", con)
        'cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmSurgery.TxthospNo.Text
        cmd.Parameters.Add("@SurID", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            Txtpostop.Text = tbl.Rows(0)(11).ToString()

            FrmSurgery.BtnUpdate.Visible = True
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = False
            FrmSurgery.Label10.Visible = True

        Else

            FrmSurgery.BtnUpdate.Visible = False
            FrmSurgery.txtpass.Visible = True
            FrmSurgery.BtnSAve.Visible = True
            FrmSurgery.Label10.Visible = True

            '   Txtpostop.Text = ""

        End If

    End Sub

End Class
