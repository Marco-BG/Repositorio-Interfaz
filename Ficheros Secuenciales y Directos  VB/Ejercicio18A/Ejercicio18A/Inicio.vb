Public Class Inicio
    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        Secuenciales.ShowDialog()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Registrar.ShowDialog()
    End Sub
End Class