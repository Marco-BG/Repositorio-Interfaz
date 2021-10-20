Public Class Form1
    Dim miListaOrigen As ListBox
    Dim miListaDestino As ListBox


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarControles()
    End Sub

    Private Sub inicializarControles()
        entradaLista.Tag = ltb_listaIzquierda
        btn_borrarLista.Tag = ltb_listaIzquierda

        entradaListaDerecha.Tag = ltb_listaDerecha
        btn_borrarDerecha.Tag = ltb_listaDerecha

        btn_envia.Tag = ltb_listaIzquierda


    End Sub
    Private Sub entradaLista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles entradaLista.KeyPress
        Dim miTexto As TextBox = sender
        Dim miListaEntrada As ListBox = miTexto.Tag
        If Asc(e.KeyChar) = Keys.Enter Then
            If (miTexto.Text.Trim = "") Or Not (miListaEntrada.Items.IndexOf(miTexto.Text) = -1) Then
                e.Handled = True 'quito el beep
                miTexto.Text = ""
                Exit Sub
            End If
            miListaEntrada.Items.Add(miTexto.Text)
            miTexto.Text = ""
            miTexto.Focus()
        End If
    End Sub
    Private Sub btn_borrarLista_Click(sender As Object, e As EventArgs) Handles btn_borrarLista.Click
        Dim miBoton As Button = sender
        Dim miLista As ListBox = miBoton.Tag

        miLista.Items.Clear()

    End Sub

    Private Sub entradaListaDerecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles entradaListaDerecha.KeyPress
        Dim textoEntradaDerecha As TextBox = sender
        Dim miListaEntrada As ListBox = textoEntradaDerecha.Tag
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quito el beep
            If (textoEntradaDerecha.Text.Trim = "") Or Not (miListaEntrada.Items.IndexOf(textoEntradaDerecha.Text) = -1) Then
                'Si no lo encuentra que me lo añada
                textoEntradaDerecha.Text = ""
                Exit Sub
            End If

            miListaEntrada.Items.Add(textoEntradaDerecha.Text)
            textoEntradaDerecha.Text = ""
            textoEntradaDerecha.Focus()
        End If
    End Sub

    Private Sub btn_borrarDerecha_Click(sender As Object, e As EventArgs) Handles btn_borrarDerecha.Click
        Dim miBotonDerecha As Button = sender
        Dim miListaDerecha As ListBox = miBotonDerecha.Tag

        miListaDerecha.Items.Clear()
    End Sub

    Private Sub intercambioListas()

        ' If miListaDestino.Items.IndexOf(miListaDestino.Items) <> -1 Then
        'Exit Sub
        'End If


        Do While miListaOrigen.SelectedItems.Count
            miListaDestino.Items.Add(miListaOrigen.SelectedItems(0))
            miListaOrigen.Items.Remove(miListaOrigen.SelectedItems(0))
        Loop

    End Sub

    Private Sub ltb_listaIzquierda_DoubleClick(sender As Object, e As EventArgs) Handles ltb_listaIzquierda.DoubleClick, ltb_listaDerecha.DoubleClick
        MessageBox.Show("a")
        Dim miLista As ListBox = sender

        If miLista.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        Select Case miLista.Name.ToString
            Case "ltb_listaIzquierda"
                miListaOrigen = ltb_listaIzquierda
                miListaDestino = ltb_listaDerecha

            Case "ltb_listaDerecha"
                miListaOrigen = ltb_listaDerecha
                miListaDestino = ltb_listaIzquierda
        End Select

        intercambioListas()

    End Sub

    Private Sub btn_envia_Click(sender As Object, e As EventArgs) Handles btn_envia.Click, btn_regresa.Click

        Dim miBoton As Button = sender
        Select Case miBoton.Name
            Case "btn_envia"
                miListaOrigen = ltb_listaIzquierda
                miListaDestino = ltb_listaDerecha

            Case "btn_regresa"
                miListaOrigen = ltb_listaDerecha
                miListaDestino = ltb_listaIzquierda
        End Select
        intercambiolistas()
    End Sub
    Private Sub Listas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltb_listaIzquierda.MouseDown, ltb_listaDerecha.MouseDown
        miListaOrigen = sender

        Select Case miListaOrigen.Name
            Case ltb_listaIzquierda.Name
                miListaDestino = ltb_listaDerecha
            Case ltb_listaDerecha.Name
                miListaDestino = ltb_listaIzquierda
        End Select
        'intercambioListas()
        If e.Clicks = 2 Then
            intercambioListas()
            Exit Sub
        End If
        miListaOrigen.DoDragDrop(miListaOrigen.Text, DragDropEffects.Move)
    End Sub
    Private Sub Listas_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ltb_listaDerecha.DragOver, ltb_listaIzquierda.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub Listas_dragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ltb_listaIzquierda.DragDrop, ltb_listaDerecha.DragDrop
        miListaDestino = sender
        intercambioListas()
    End Sub
End Class
