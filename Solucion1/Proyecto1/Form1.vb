Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_primerBoton.Click, Lbl_primeraEtiqueta.Click
        'Dim miBoton As Button = sender
        MessageBox.Show("Hola buenas tardes " & sender.name.ToString & Chr(13) & "Cuyo texto  es: " & sender.text & Chr(13) & " Y su tipo es " & sender.GetType.ToString())
    End Sub
    Private Sub Btn_segundoBoton_Click(sender As Object, e As EventArgs) Handles Btn_segundoBoton.Click
        MessageBox.Show("Hola buenos dias: " & sender.name.ToString & Chr(13) & "Cuyo texto  es: " & sender.text)
    End Sub
    Private Sub Lbl_primeraEtiqueta_Click(sender As Object, e As EventArgs) Handles Lbl_primeraEtiqueta.Click
        MessageBox.Show("Hola buenas noches " & sender.name.ToString & Chr(13) & "Cuyo texto  es: " & sender.text & Chr(13) & " Y su tipo es " & sender.GetType.ToString())
    End Sub
End Class
