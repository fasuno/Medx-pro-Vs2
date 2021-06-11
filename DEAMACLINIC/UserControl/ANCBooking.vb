
Imports System.Data.SqlClient

Public Class ANCBooking

    Private Sub BtnNewBook_Click(sender As Object, e As EventArgs) Handles BtnNewBook.Click
        Dim frm = New FrmANCinfo
        frm.ShowDialog()

    End Sub

    Sub ShowprevPreg()

        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Date_of_Delivery, Duration, Complication, Labour, Sex, Peuperium, Birth_Weight from ANCPREVPREG WHERE Booking_ID=@BknID ", con)
        cmd.Parameters.Add("@BknID", SqlDbType.Int).Value = DtgAncbook.CurrentRow.Cells(1).Value
        ' cmd.Parameters.Add("@Hno", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)
        FrmANCinfo.dtgprepreg.DataSource = tbl
        FrmANCinfo.dtgprepreg.AutoResizeColumns()

    End Sub

    Public Sub Showbookingdetails()

        cmd = New SqlCommand("Select * from ANCBooking where Booking_ID=@Bkid", con)
        'cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text
        cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = DtgAncbook.CurrentRow.Cells(1).Value


        adapt = New SqlDataAdapter(cmd)
        Dim tbls As New DataTable

        adapt.Fill(tbls)
        If tbls.Rows.Count() > 0 Then

            FrmANCinfo.DtBooked.Value = tbls.Rows(0)(2)
            FrmANCinfo.DtLMP.Value = tbls.Rows(0)(3)
            FrmANCinfo.DtEDD.Value = tbls.Rows(0)(4)
            FrmANCinfo.txtGrav.Text = tbls.Rows(0)(5)
            FrmANCinfo.TxtPar.Text = tbls.Rows(0)(6)
            FrmANCinfo.txtindication.Text = tbls.Rows(0)(7)
            FrmANCinfo.Txtspecpoint.Text = tbls.Rows(0)(8)
            FrmANCinfo.Txtconsultant.Text = tbls.Rows(0)(9)
            FrmANCinfo.txtbleed.Text = tbls.Rows(0)(10)
            FrmANCinfo.Txtdisch.Text = tbls.Rows(0)(11)
            FrmANCinfo.TxtUsymp.Text = tbls.Rows(0)(13)
            FrmANCinfo.TxtOsympt.Text = tbls.Rows(0)(14)
            FrmANCinfo.TxtGencond.Text = tbls.Rows(0)(15)
            FrmANCinfo.TxtBres.Text = tbls.Rows(0)(16)
            FrmANCinfo.Txtcvc.Text = tbls.Rows(0)(17)
            FrmANCinfo.TxtAbdom.Text = tbls.Rows(0)(18)
            FrmANCinfo.TxtxRs.Text = tbls.Rows(0)(19)
            FrmANCinfo.Txtpelvis.Text = tbls.Rows(0)(20)
            FrmANCinfo.cbogen.Text = tbls.Rows(0)(22)
            FrmANCinfo.CboBldgp.Text = tbls.Rows(0)(23)
            FrmANCinfo.CboGrpRH.Text = tbls.Rows(0)(24)
            FrmANCinfo.Txtretrov.Text = tbls.Rows(0)(25)
            FrmANCinfo.TxtVdrl.Text = tbls.Rows(0)(26)
            FrmANCinfo.TxtHb.Text = tbls.Rows(0)(27)
            FrmANCinfo.txtBP.Text = tbls.Rows(0)(28)
            FrmANCinfo.Txturin.Text = tbls.Rows(0)(29)
            FrmANCinfo.Txtheight.Text = tbls.Rows(0)(30)
            FrmANCinfo.Txtwght.Text = tbls.Rows(0)(31)
            FrmANCinfo.TxtPeupInstr.Text = tbls.Rows(0)(32)
            FrmANCinfo.TxtHtDis.Text = tbls.Rows(0)(33)
            FrmANCinfo.TxtChestDis.Text = tbls.Rows(0)(34)
            FrmANCinfo.TxtKidnDis.Text = tbls.Rows(0)(35)
            FrmANCinfo.TxtBldTrans.Text = tbls.Rows(0)(36)
            FrmANCinfo.TxtMultPre.Text = tbls.Rows(0)(38)
            FrmANCinfo.Txttuber.Text = tbls.Rows(0)(39)
            FrmANCinfo.TxtHyper.Text = tbls.Rows(0)(40)
            FrmANCinfo.Txtothers.Text = tbls.Rows(0)(41)
            FrmANCinfo.txtdelivsta.Text = tbls.Rows(0)(43)

        End If
        ShowprevPreg()
    End Sub

    Private Sub DtgAncBook_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgAncbook.CellDoubleClick

        FrmANCinfo.dtgprepreg.BringToFront()
        FrmANCinfo.btnsave.Enabled = False
        FrmANCinfo.txtpass.ReadOnly = True

        Showbookingdetails()
        FrmANCinfo.Show()

    End Sub

End Class
