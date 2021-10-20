Public Class Form1
    Private Sub Btn_pulsar_Click(sender As Object, e As EventArgs) Handles Btn_pulsar.Click

        If Btn_pulsar.Text = "Pulsado" Then
            MessageBox.Show("Ya pulsado")
            Exit Sub
        Else
            Btn_pulsar.Text = "Pulsado"
        End If
    End Sub

    Private Sub aumentar(sender As Object, e As EventArgs) Handles Lbl_text.DoubleClick
        Dim lblText As Label = sender
        lblText.Text &= "P"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click

        Dim radio As RadioButton = sender

        MessageBox.Show(radio.Text & " Selecionado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_contador.Click

        Dim botonContador As Button = sender
        Dim contador As Integer = 0

        contador = contador + 1
        botonContador.Text = botonContador.Text + contador
    End Sub

    Private Sub Btn_concatenar_Click(sender As Object, e As EventArgs) Handles Btn_concatenar.Click
        Me.Text = TextBox1.Text + " " + TextBox2.Text
    End Sub
End Class
