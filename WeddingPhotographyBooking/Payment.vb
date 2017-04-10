Imports System.Data.OleDb
Public Class Payment
    Dim connect As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim command As OleDbCommand
    Dim dataset As DataSet
    Dim datarow As DataRow
    Dim cash As Double

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = WeddingPhotographyBookingSystem1.accdb")
        connect.Open()

        If connect.State = ConnectionState.Open Then
            Exit Sub

        Else
            MsgBox("CONNECTION DOESN'T EXIST")

        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim cash As Double

        txt_amount.Text = 10000
        cash = 10000 - txt_balance.Text

    End Sub

    Private Sub txt_balance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_balance.TextChanged
        txt_amount.Text = 10000

    End Sub
End Class