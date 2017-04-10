Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide()
            Home.Show()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.ForeColor() = Color.DeepPink
    End Sub
End Class
