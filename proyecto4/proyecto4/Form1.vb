Public Class Form1
    Private Sub btn_boton_Click(sender As Object, e As EventArgs) Handles btn_color.Click, btn_ingresaMarcas.Click

        Dim miBoton As Button = sender
        Dim miTexto As TextBox = miBoton.Tag
        Dim miLista As ListBox = miTexto.Tag

        If (miTexto.Text.Trim = "") Or Not (miLista.Items.IndexOf(miTexto.Text) = -1) Then Exit Sub
        'Si no lo encuentra que me lo añada
        miLista.Items.Add(miTexto.Text)
        miTexto.Text = ""
        miTexto.Focus()
    End Sub

    'Crear procedimientos
    Private Sub RelacionaListas()
        btn_color.Tag = txt_color
        txt_color.Tag = ltb_color

        'Relacionar la otra lista =>
        btn_ingresaMarcas.Tag = txt_marcas
        txt_marcas.Tag = ltb_marcas

        btn_borrarColor.Tag = ltb_color
        btn_borrarMarcas.Tag = ltb_marcas

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        RelacionaListas()
    End Sub
    Private Sub btn_borrarColor_Click(sender As Object, e As EventArgs) Handles btn_borrarColor.Click, btn_borrarMarcas.Click

        Dim miBoton As Button = sender
        Dim miLista As ListBox = miBoton.Tag

        miLista.Items.Remove(miLista.SelectedItem)


    End Sub

    Private Sub txt_color_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_color.KeyPress, txt_marcas.KeyPress

        Dim miTexto As TextBox = sender
        Dim miBoton As Button = miTexto.Tag.Tag
        If e.KeyChar = Chr(13) Then
            btn_boton_Click(miBoton, New EventArgs)
        End If
    End Sub
End Class
