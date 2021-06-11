Imports System.Data.SqlClient

Public Class FrmANCform

    Sub LoadANCProfile()

        cmd = New SqlCommand("Select * from ANCRegister where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            AncProfile2.dtreg.Value = tbl.Rows(0)(0)
            AncProfile2.Txtsurname.Text = tbl.Rows(0)(2).ToString()
            AncProfile2.txtothernames.Text = tbl.Rows(0)(3).ToString()
            'Txtdob.Text = tbl.Rows(0)(4).ToString()
            AncProfile2.txtsex.Text = tbl.Rows(0)(6).ToString()
            AncProfile2.txtmarital.Text = tbl.Rows(0)(7).ToString()
            AncProfile2.txtreli.Text = tbl.Rows(0)(8).ToString()
            AncProfile2.txtoccup.Text = tbl.Rows(0)(9).ToString()
            AncProfile2.txtlga.Text = tbl.Rows(0)(10).ToString()
            AncProfile2.txtstate.Text = tbl.Rows(0)(11).ToString()
            AncProfile2.txtnat.Text = tbl.Rows(0)(12).ToString()
            AncProfile2.txtadd.Text = tbl.Rows(0)(13).ToString()
            AncProfile2.txtphone.Text = tbl.Rows(0)(14).ToString()
            AncProfile2.txtaccount.Text = tbl.Rows(0)(15).ToString()
            AncProfile2.txtprov.Text = tbl.Rows(0)(16).ToString()
            AncProfile2.txtenrolletype.Text = tbl.Rows(0)(17).ToString()
            AncProfile2.txtemployer.Text = tbl.Rows(0)(18).ToString()
            AncProfile2.txtenrolnum.Text = tbl.Rows(0)(19).ToString()
            AncProfile2.txthusname.Text = tbl.Rows(0)(20).ToString()
            AncProfile2.txthusadd.Text = tbl.Rows(0)(21).ToString()
            AncProfile2.txthusphone.Text = tbl.Rows(0)(22).ToString()
            AncProfile2.txtHusoccup.Text = tbl.Rows(0)(23).ToString()
            AncProfile2.txthusempl.Text = tbl.Rows(0)(24)
            lblbkid.Text = tbl.Rows(0)(27)

        End If

        LOADPTAGes()

    End Sub

    Sub LOADPTAGes()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hop_Num", con)
        cmd.Parameters.Add("@Hop_Num", SqlDbType.Int).Value = lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            AncProfile2.txtyear.Text = tbl.Rows(0)(4).ToString
            AncProfile2.txtdob.Text = tbl.Rows(0)(3)
        End If
    End Sub

    Private Sub Btnprof_Click(sender As Object, e As EventArgs) Handles Btnprof.Click
        AncProfile2.BringToFront()
    End Sub

    Private Sub FrmANCform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadANCProfile()
        AncProfile2.BringToFront()
        Me.MdiParent = frmMain
    End Sub

    Private Sub Btnseedoc_Click(sender As Object, e As EventArgs) Handles Btnseedoc.Click
        Dim frms = New Frmvitals

        frms.lblsurname.Text = AncProfile2.Txtsurname.Text
        frms.lblothernames.Text = AncProfile2.txtothernames.Text
        frms.lblage.Text = AncProfile2.txtyear.Text
        frms.lblclinic.Text = "ANC"
        frms.lblaccounttype.Text = AncProfile2.txtaccount.Text
        frms.lblcat.Text = AncProfile2.txtprov.Text
        frms.lblhospnum.Text = lblhospnum.Text
        frms.lblsex.Text = AncProfile2.txtsex.Text


        frms.ShowDialog()
    End Sub

    Public Sub LoadAncBookings()
        '// This code will show all patients antenatal bokkings to grid
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Booking_Date, Booking_ID, LMP, EDD, Consultant, Delivery_Status from ANCBooking WHERE Hospital_Num=@Hnum", con)
        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = lblhospnum.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        AncBooking1.DtgAncbook.DataSource = tbl
        AncBooking1.DtgAncbook.AutoResizeColumns()


    End Sub

    Sub LoadAncVitals()
        '// This code will show all patients antenatal bokkings to grid
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Date, Time, GA, Fundal, Presentation, Lie, Foetal_Heart, BP, Weight  from ANCVitals WHERE Hospital_Num=@Hnum AND Booking_ID=@bokingID", con)
        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = lblhospnum.Text
        cmd.Parameters.Add("@bokingID", SqlDbType.Int).Value = lblbkid.Text


        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        AnCfollowup1.dtgfflwup.DataSource = tbl
        AnCfollowup1.dtgfflwup.AutoResizeColumns()


    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        LoadAncBookings()
        AncBooking1.BringToFront()
    End Sub

    Private Sub btnfolwup_Click(sender As Object, e As EventArgs) Handles btnfolwup.Click
        LoadAncVitals()
        AnCfollowup1.BringToFront()
    End Sub

    Private Sub btnlab_Click(sender As Object, e As EventArgs) Handles btnlab.Click
        Dim frm = New FrmLabrequest

        frm.BtnSndAncLab.BringToFront()
        frm.LoadLAbTest()
        frm.ShowDialog()
    End Sub

    Private Sub btnrad_Click(sender As Object, e As EventArgs) Handles btnrad.Click
        Dim fr = New FrmRadrequest

        fr.BtnSndAncRad.BringToFront()
        fr.LoadRAdlist()
        fr.ShowDialog()
    End Sub

    Private Sub btndrug_Click(sender As Object, e As EventArgs) Handles btndrug.Click
        Dim frrm = New FrmDrugsPresc

        frrm.BtnANCdrugs.BringToFront()
        frrm.LoadDrugs()
        frrm.ShowDialog()
    End Sub


End Class