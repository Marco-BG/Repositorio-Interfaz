Public Class Form1
    Dim contadorImagen As Integer = 0
    Dim contadorTexto As Integer = 0

    Private Sub SalirDeLaAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicaciónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim miFormImagen As New imagenForm

        miFormImagen.MdiParent = Me
        contadorImagen += 1
        miFormImagen.Text = "Formulario Hijo para Imagen BMP --" + Str(contadorImagen)
        miFormImagen.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim miFormImagen As New imagenForm
        miFormImagen.MdiParent = Me
        contadorImagen += 1
        miFormImagen.Text = "Formulario Hijo para Imagen BMP --" + Str(contadorImagen)
        miFormImagen.Show()
    End Sub

    Private Sub CerrarVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaToolStripMenuItem.Click

        If Me.MdiChildren.Length = 0 Then
            Exit Sub
        End If
        ActiveMdiChild.Close()
    End Sub

    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cerrarTodo.Click

        For index As Integer = 1 To contadorImagen
            If Me.MdiChildren.Length = 0 Then
                Exit Sub
            End If
            ActiveMdiChild.Close()
        Next
        For index As Integer = 1 To contadorTexto
            If Me.MdiChildren.Length = 0 Then
                Exit Sub
            End If
            ActiveMdiChild.Close()
        Next


    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        For index As Integer = 1 To contadorImagen
            If Me.MdiChildren.Length = 0 Then
                Exit Sub
            End If
            ActiveMdiChild.Close()
        Next
    End Sub

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        Dim miFormTexto As New formTexto

        miFormTexto.MdiParent = Me
        contadorTexto += 1

        miFormTexto.Text = "Formulario Hijo para Imagen BMP --" + Str(contadorTexto)
        miFormTexto.Show()


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim miFormInformacion As New formInformacion


        miFormInformacion.ShowDialog()


    End Sub
End Class
