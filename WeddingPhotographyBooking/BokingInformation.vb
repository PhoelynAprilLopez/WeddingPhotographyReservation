Imports System.Data.OleDb

Public Class BokingInformation

    Dim connect As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim command As OleDbCommand
    Dim dataset As DataSet
    Dim datarow As DataRow
    Private Sub BokingInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = WeddingPhotographyBookingSystem1.accdb")
        connect.Open()

        If connect.State = ConnectionState.Open Then
            Exit Sub

        Else
            MsgBox("CONNECTION DOESN'T EXIST")

        End If
    End Sub
    Private Sub btn_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_done.Click

        command = New OleDbCommand("insert into BookingInformation values ('" & Me.txt_bookername.Text & "','" & Me.txt_dateofwedding.Text & "','" & Me.txt_fullnameofbride.Text & "','" & Me.txt_fullnameofgroom.Text & "','" & Me.txt_address.Text & "','" & Me.txt_contactnumber.Text & "','" & Me.cmb_gtime.Text & "', '" & Me.txt_glocation.Text & "','" & Me.cmb_ctime.Text & "','" & Me.txt_clocation.Text & "','" & Me.cmb_ptime.Text & "','" & Me.txt_plocation.Text & "','" & Me.cmb_rtime.Text & "','" & Me.txt_rlocation.Text & "'," & Me.txt_numberofguest.Text & ",'" & Me.cmb_status.Text & "','" & Me.rtb_srn.Text & "')", connect)
        command.ExecuteNonQuery()

            MsgBox("SAVED SUCCESSFULLY!")

        txt_bookername.Text = ""
        txt_dateofwedding.Text = ""
        txt_fullnameofbride.Text = ""
        txt_fullnameofgroom.Text = ""
        txt_address.Text = ""
        txt_contactnumber.Text = ""

        cmb_gtime.Text = ""
        txt_glocation.Text = ""
        cmb_ctime.Text = ""
        txt_clocation.Text = ""
        cmb_ptime.Text = ""
        txt_plocation.Text = ""
        cmb_rtime.Text = ""
        txt_rlocation.Text = ""

        cmb_status.Text = ""
        txt_numberofguest.Text = ""
        rtb_srn.Text = ""

        Me.Hide()
        Reports.Show()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btn_pcnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pcnext.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
        Reports.Show()

    End Sub
End Class