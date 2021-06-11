Imports System.Data.SqlClient

Public Class ANCfollowup

    Public Sub ShowPregBookingdetails()

        cmd = New SqlCommand("Select * from ANCBooking where Hospital_Num=@Hosp_Num and Booking_ID=@Bkid", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
        cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = FrmANCform.lblbkid.Text
        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            FrmANCfollowUp.dtbook.Value = tbl.Rows(0)(2)
            FrmANCfollowUp.dtlmp.Value = tbl.Rows(0)(3)
            FrmANCfollowUp.dtedd.Value = tbl.Rows(0)(4)
            FrmANCfollowUp.txtgravs.Text = tbl.Rows(0)(5)
            FrmANCfollowUp.txtpar.Text = tbl.Rows(0)(6)


        End If

    End Sub

    Public Sub ShowFolwupvitals()

        cmd = New SqlCommand("Select * from ANCVitals where Booking_ID=@Bkid AND Date=@Dte", con)

        cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = FrmANCform.lblbkid.Text
        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = dtgfflwup.CurrentRow.Cells(0).Value


        adapt = New SqlDataAdapter(cmd)
        Dim tbls As New DataTable

        adapt.Fill(tbls)
        If tbls.Rows.Count() > 0 Then

            FrmANCfollowUp.dtfolwup.Value = tbls.Rows(0)(2)
            FrmANCfollowUp.txtga.Text = tbls.Rows(0)(4)
            FrmANCfollowUp.txtheght.Text = tbls.Rows(0)(5)
            FrmANCfollowUp.txtprepos.Text = tbls.Rows(0)(6)
            FrmANCfollowUp.txtlie.Text = tbls.Rows(0)(7)
            FrmANCfollowUp.txtfh.Text = tbls.Rows(0)(8)
            FrmANCfollowUp.txtbp.Text = tbls.Rows(0)(9)
            FrmANCfollowUp.txturine.Text = tbls.Rows(0)(10)
            FrmANCfollowUp.txtwght.Text = tbls.Rows(0)(11)
            FrmANCfollowUp.cboappnmnt.Text = tbls.Rows(0)(12)
            FrmANCfollowUp.Txtremark.Text = tbls.Rows(0)(14)


        End If

    End Sub

    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        'ShowFolwupvitals()

        ShowPregBookingdetails()

        FrmANCfollowUp.txtga.Text = ""
        FrmANCfollowUp.txtlie.Text = ""
        FrmANCfollowUp.txturine.Text = ""
        FrmANCfollowUp.txtwght.Text = ""
        FrmANCfollowUp.txtheght.Text = ""
        FrmANCfollowUp.txtbp.Text = ""
        FrmANCfollowUp.txtfh.Text = ""
        FrmANCfollowUp.txtprepos.Text = ""
        FrmANCfollowUp.cboappnmnt.Text = ""
        FrmANCfollowUp.Txtremark.Text = ""
        FrmANCfollowUp.btnsave.BringToFront()

        FrmANCfollowUp.ShowDialog()
    End Sub

    Private Sub dtgfflwup_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgfflwup.CellDoubleClick
        ShowFolwupvitals()

        ShowPregBookingdetails()
        FrmANCfollowUp.btnupdate.BringToFront()

        FrmANCfollowUp.ShowDialog()
    End Sub


End Class
