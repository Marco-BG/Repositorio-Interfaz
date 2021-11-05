Public Class Form1
    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim miFormImagen As New Form_Imagen
        Dim miImagen As Image = Nothing

        miFormImagen.MdiParent = Me
        abrirFichero.ShowDialog()

        'MessageBox.Show(abrirFichero.FileName)

        miImagen = Image.FromFile(abrirFichero.FileName)
        miFormImagen.pictureBoxImagen.Image = miImagen
        miFormImagen.Show()


    End Sub

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        Dim miFicheroLector As New leerTexto



        miFicheroLector.MdiParent = Me
        abrirFichero.ShowDialog()

        'MessageBox.Show(abrirFichero.FileName)

        miFicheroLector.richTextFichero.LoadFile(abrirFichero.FileName)
        miFicheroLector.MdiParent = Me
        miFicheroLector.Show()

    End Sub
End Class
