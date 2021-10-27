Public Class Form1
    Friend WithEvents miReloj As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        miReloj = New Timer
        miReloj.Interval = 1000
        miReloj.Enabled = True

    End Sub

    Private Sub miReloj_Tick(sender As Object, e As EventArgs) Handles miReloj.Tick
        Label1.Text = Now().ToLongTimeString

    End Sub

    Private Sub btn_abrirArchivo_Click(sender As Object, e As EventArgs) Handles btn_abrirArchivo.Click
        fileAbrir.ShowDialog()
    End Sub
End Class
