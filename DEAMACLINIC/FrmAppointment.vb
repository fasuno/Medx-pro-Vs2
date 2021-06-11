
Imports System.Data.SqlClient

Public Class FrmAppointment
    Private Sub FrmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = frmMain
        lbltime.Text = Apptime.Text
        lbldate.Text = Apptdate.Text
    End Sub

    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click

        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtsurname.Text = tbl.Rows(0)(1).ToString()
            txtothernames.Text = tbl.Rows(0)(2).ToString()
            txtsex.Text = tbl.Rows(0)(8).ToString()
            txtaccount.Text = tbl.Rows(0)(6).ToString()
            Txtcat.Text = tbl.Rows(0)(7).ToString()
            txtage.Text = tbl.Rows(0)(4).ToString()

        Else

            MsgBox("THE HOSPITAL NUMBER DOES NOT EXIST", MsgBoxStyle.Information, "Medx-pro")

        End If


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        'con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloadApptmntfolder()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Appntmnt", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Frmrecords.DtgApt.DataSource = tbl
        con.Close()     '   I disable the close connection bcos i'm calling it in the save button where a connection is already open

    End Sub

    Public Sub reloadVitalsigns()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Pending_Vitals", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        frmNursing.dtgpendingvitals.DataSource = tbl
        con.Close()     '
    End Sub

    Public Sub Checkappointment()


        If cboClinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "Medx-pro")
            cboClinic.Focus()

        Else

            ''// First check if the appointment hass been booked for the selected date

            Dim cmd As New SqlCommand("Select * from Appntmnt where Appointment_date= @Date AND Hospital_num=@hospID", con)

            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Apptdate.Value
            cmd.Parameters.Add("@hospID", SqlDbType.VarChar).Value = txtsearch.Text

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            '// if the appointment date exist for the patient then
            If tbl.Rows.Count() > 0 Then
                MsgBox("PATIENT HAD BEEN BOOKED", MsgBoxStyle.Critical, "Medx-pro")
                txtsearch.Focus()

                txtaccount.Text = ""
                txtothernames.Text = ""
                Txtcat.Text = ""
                txtsex.Text = ""
                txtage.Text = ""
                txtsurname.Text = ""
                txtsearch.Focus()

            Else

                Try

                    cmd = New SqlCommand("INSERT INTO Appntmnt VALUES(@Aptdate, @Apttime, @Sname, @Oname, @hno, @Age, @Sex, @Act, @Cli, @Cat)", con)
                    ' cmd.CommandType = System.Data.CommandType.Text
                    'cmd.CommandText = "insert into Appntmnt values ('" & Apptdate.Value.Date & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & cboClinic.SelectedItem & "', '" & Txtcat.Text & "')"

                    cmd.Parameters.Add("@Aptdate", SqlDbType.Date).Value = Apptdate.Value.Date
                    cmd.Parameters.Add("@Apttime", SqlDbType.VarChar).Value = lbltime.Text
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtsurname.Text
                    cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = txtothernames.Text
                    cmd.Parameters.Add("@hno", SqlDbType.VarChar).Value = txtsearch.Text
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = txtage.Text
                    cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                    cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = txtaccount.Text
                    cmd.Parameters.Add("@cli", SqlDbType.VarChar).Value = cboClinic.Text
                    cmd.Parameters.Add("@cat", SqlDbType.VarChar).Value = Txtcat.Text


                    cmd.Connection = con

                    con.Open()

                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("SUCCESSFUL BOOKED", MsgBoxStyle.Information, "Medx-pro")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

                '--------------------------------------------------------------
                '// SAve the same data to the pending vital signs table
                '----------------------------------------------------
                populatevitals()

                txtaccount.Text = ""
                txtothernames.Text = ""
                txtsearch.Text = ""
                txtsex.Text = ""
                txtage.Text = ""
                txtsurname.Text = ""
                cboClinic.Text = ""
                Txtcat.Text = ""

                '  Me.Close()

                reloadApptmntfolder()

                reloadVitalsigns()

            End If
        End If
        con.Close()
    End Sub

    Private Sub BtnReschedule_Click(sender As Object, e As EventArgs) Handles BtnReschedule.Click
        Try

            cmd = New SqlCommand("UPDATE Appntmnt SET Appointment_date=@Apdat, Appointment_time= @Aptim, Clinic= @Clinix WHERE Hospital_Num='" & txtsearch.Text & "' AND  Appointment_date=@Apdat")

            'Dim Updat As String = "Update Appntmnt Set Appntmnt ='" & Apptdate.Value & "', Appointment_time='" & lbltime.Text & "', Surname='" & txtsurname.Text & "', Other_names='" & txtothernames.Text & "', Age='" & txtage.Text & "', Sex='" & txtsex.Text & "',Account_type='" & txtaccount.Text & "', Clinic='" & cboClinic.Text & "', Account_Category='" & Txtcat.Text & "' WHERE Hospital_Num='" & txtsearch.Text & "' AND  Appointment_date='" & Apptdate.Value & "'"

            cmd.Parameters.Add("@Apdat", SqlDbType.Date).Value = Apptdate.Value.Date
            cmd.Parameters.Add("@Aptim", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@clinix", SqlDbType.VarChar).Value = cboClinic.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("APPOINTMENT RESCHEDULED SUCCESSFULLY", "Medx-pro", MessageBoxButtons.OK)

            'Call the reload method for folder datagrid to refresh datagrid
            reloadApptmntfolder()
            updatevitalsafterreschedule()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Me.Close()

        '// Call the refresh appointment grid method from the records form

        Frmrecords.sortApptfolder()
        frmNursing.sortvitalssigns()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub populatevitals()

        '//  Populate the Pending vital signs table
        Try

            ' cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "insert into Pending_Vitals values ('" & Apptdate.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & cboClinic.SelectedItem & "', '" & Txtcat.Text & "')"

            cmd = New SqlCommand("INSERT INTO Pending_Vitals VALUES(@Apdate, @Aptime, @Snme, @Onme, @hnu, @Ag, @Sx, @Acct, @Clin, @Cate)", con)

            cmd.Parameters.Add("@Apdate", SqlDbType.Date).Value = Apptdate.Value.Date
            cmd.Parameters.Add("@Aptime", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@snme", SqlDbType.VarChar).Value = txtsurname.Text
            cmd.Parameters.Add("@onme", SqlDbType.VarChar).Value = txtothernames.Text
            cmd.Parameters.Add("@hnu", SqlDbType.VarChar).Value = txtsearch.Text
            cmd.Parameters.Add("@Ag", SqlDbType.Int).Value = txtage.Text
            cmd.Parameters.Add("@Sx", SqlDbType.VarChar).Value = txtsex.Text
            cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = txtaccount.Text
            cmd.Parameters.Add("@clin", SqlDbType.VarChar).Value = cboClinic.Text
            cmd.Parameters.Add("@cate", SqlDbType.VarChar).Value = Txtcat.Text

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Public Sub updatevitalsafterreschedule()

        Try

            cmd = New SqlCommand("UPDATE Pending_Vitals SET Appointment_date=@Appdat, Appointment_time= @Apptim, Clinic= @Clinx WHERE Hospital_No='" & txtsearch.Text & "'")

            'Dim Updat As String = "Update Appntmnt Set Appntmnt Set='" & Apptdate.Value & "', Appointment_time='" & lbltime.Text & "', Surname='" & txtsurname.Text & "', Other_names='" & txtothernames.Text & "', Age='" & txtage.Text & "', Sex='" & txtsex.Text & "',Account_type='" & txtaccount.Text & "', Clinic='" & cboClinic.Text & "', Account_Category='" & Txtcat.Text & "' WHERE Hospital_Num='" & txtsearch.Text & "' AND  Appointment_date='" & Apptdate.Value & "'"

            cmd.Parameters.Add("@Appdat", SqlDbType.Date).Value = Apptdate.Value.Date
            cmd.Parameters.Add("@Apptim", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Clinx", SqlDbType.VarChar).Value = cboClinic.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            reloadVitalsigns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Me.Close()


    End Sub

    Private Sub Apptime_ValueChanged(sender As Object, e As EventArgs) Handles Apptime.ValueChanged
        lbltime.Text = Apptime.Text
    End Sub

    Private Sub Btnsend_Click(sender As Object, e As EventArgs) Handles Btnsend.Click
        If txtsex.Text = "Male" And cboClinic.Text = "ANC" Then
            MsgBox("NOT ALLOWED, PATIENT IS MALE", MsgBoxStyle.Critical, "Medx-pro")
            cboClinic.Text = ""
        ElseIf txtsex.Text = "Male" And cboClinic.Text = "GYNAE" Then
            MsgBox("NOT ALLOWED, PATIENT IS MALE", MsgBoxStyle.Critical, "Medx-pro")
            cboClinic.Text = ""
        End If


        If cboClinic.Text = "ANC" Then

            CheckANC()

        Else
            '// CAll the Checkappointment method
            Checkappointment() '// See Checkappointment method
            Frmrecords.sortApptfolder()
            frmNursing.sortvitalssigns() '// Refresh the vital signs to the current date
            ' con.Close()
        End If
        ' End If
    End Sub

    Public Sub CheckANC()

        cmd = New SqlCommand("Select * from VwANCPending where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() <= 0 Then
            MsgBox("PATIENT DOES NOT HAVE ANY CURRENT ANTE-NATAL BOOKING", MsgBoxStyle.Information, "Medx-pro")

            txtsearch.Focus()

        Else

            Checkappointment() '// See Checkappointment method
            Frmrecords.sortApptfolder()
            frmNursing.sortvitalssigns()
        End If

    End Sub

    Private Sub Apptdate_ValueChanged(sender As Object, e As EventArgs)
        If Apptdate.Value < DateTime.Today Then
            MsgBox("YOU CANNOT BACKDATE", MsgBoxStyle.Critical, "INVALID DATE")
            Apptdate.MinDate = DateTime.Today
        Else
        End If
    End Sub

End Class


