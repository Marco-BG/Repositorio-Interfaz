Public Class VentanaEliminarMaterial
    Private Sub buttonRegresarInicio_Click(sender As Object, e As EventArgs) Handles buttonRegresarInicio.Click
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
        Me.Close()
    End Sub
End Class