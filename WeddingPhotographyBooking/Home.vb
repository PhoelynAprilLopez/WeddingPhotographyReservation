Imports System.Data.OleDb

Public Class Home
    Dim connect As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim command As OleDbCommand
    Dim dataset As DataSet
    Dim datarow As DataRow

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = WeddingPhotographyBookingSystem1.accdb")
        connect.Open()

        If connect.State = ConnectionState.Open Then
            Exit Sub

        Else
            MsgBox("CONNECTION DOESN'T EXIST")

        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        adapter = New OleDbDataAdapter("SELECT * FROM LogIn Where Username ='" & Me.txt_username.Text & "' and Password ='" & Me.txt_password.Text & "'", connect)
        dataset = New DataSet()
        dataset.Clear()
        adapter.Fill(dataset, "LogIn")



        If dataset.Tables(0).Rows.Count > 0 Then
            Me.Hide()
            BokingInformation.Show()
        Else
            MsgBox("INVALID USER/PASSWORD!")

        End If
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Close()
        Reports.Show()

    End Sub
End Class