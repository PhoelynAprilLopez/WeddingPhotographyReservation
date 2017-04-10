Imports System.Data.OleDb

Public Class Reports
    Dim connect As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim commnd As OleDbCommand
    Dim dataset As DataSet
    Dim datatable As DataTable
    Dim table As DataTableCollection
    Dim binding As New BindingSource
   
    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = WeddingPhotographyBookingSystem1.accdb")
        connect.Open()

        If connect.State = ConnectionState.Open Then
            ShowDatatoTable()
            Exit Sub

        Else
            MsgBox("CONNECTION DOESN'T EXIST")

        End If
    End Sub
    Public Sub ShowDatatoTable()

        adapter = New OleDbDataAdapter("Select * from [BookingInformation]", connect)
        dataset = New DataSet
        table = dataset.Tables
        adapter.Fill(dataset, "BookingInformation")
        Dim view As New DataView(table(0))
        binding.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)

        txt_rbookername.Text = selectedrow.Cells(0).Value.ToString
        txt_rdateofwedding.Text = selectedrow.Cells(1).Value.ToString
        txt_rfullnameofbride.Text = selectedrow.Cells(2).Value.ToString
        txt_rfullnameofgroom.Text = selectedrow.Cells(3).Value.ToString
        txt_address.Text = selectedrow.Cells(4).Value.ToString
        txt_rcontactnumber.Text = selectedrow.Cells(5).Value.ToString

        cmb_rgtime.Text = selectedrow.Cells(6).Value.ToString
        txt_rglocation.Text = selectedrow.Cells(7).Value.ToString
        cmb_rctime.Text = selectedrow.Cells(8).Value.ToString
        txt_rclocation.Text = selectedrow.Cells(9).Value.ToString
        cmb_rptime.Text = selectedrow.Cells(10).Value.ToString
        txt_rplocation.Text = selectedrow.Cells(11).Value.ToString
        cmb_rrtime.Text = selectedrow.Cells(12).Value.ToString
        txt_rrlocation.Text = selectedrow.Cells(13).Value.ToString

        txt_rnumberofguest.Text = selectedrow.Cells(14).Value.ToString
        cmb_rstatus.Text = selectedrow.Cells(15).Value.ToString
        txt_rspecialrequestnotes.Text = selectedrow.Cells(16).Value.ToString


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        Home.Show()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        commnd = New OleDbCommand("update BookingInformation set BookerName = '" + txt_rbookername.Text + "', DateOfWedding = '" + txt_rdateofwedding.Text + "', FullNameOfBride = '" + txt_rfullnameofbride.Text + "', FullNameOfGroom = '" + txt_rfullnameofgroom.Text + "', Address = '" + txt_address.Text + "',ContactNo = " + txt_rcontactnumber.Text + ", GettingReadyTime = '" + cmb_rctime.Text + "',GettingReadyLocation ='" + txt_rglocation.Text + "',CeremonyTime = '" + cmb_rctime.Text + "',CeremonyLocation ='" + txt_rclocation.Text + "', PhotoshootTime ='" + cmb_rptime.Text + "', PhotoshootLocation ='" + txt_rplocation.Text + "', ReceptionTime ='" + cmb_rrtime.Text + "',ReceptionLocation ='" + txt_rrlocation.Text + "', NumberOfGuest =" + txt_rnumberofguest.Text + ", Status ='" + cmb_rstatus.Text + "',SpecialNotesRequest ='" + txt_rspecialrequestnotes.Text + "' where DateOfWedding = '" + txt_rdateofwedding.Text + "'", connect)
        commnd.ExecuteNonQuery()
        Me.ShowDatatoTable()
        MsgBox("Successfully updated!")
    End Sub

    Private Sub btn_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Payment.Show()
    End Sub
End Class