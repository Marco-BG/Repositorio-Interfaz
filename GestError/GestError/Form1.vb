Public Class Form1
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click

        On Error GoTo gestionError

        With AbrirArchivo
            .InitialDirectory = My.Application.Info.DirectoryPath
            .ShowDialog()
            .Filter = "Todos los Archivos(*.*)|*.*|Imágenes (*.BMP, *.jpg)| *.bmp; *.jpg|Iconos ()"
        End With

        pictureImagen.Image = Image.FromFile(AbrirArchivo.FileName)

        'Try
        '    pictureImagen.Image = Image.FromFile(AbrirArchivo.FileName)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Exit Sub
gestionError:
        MessageBox.Show("Error en la lectura")
    End Sub
End Class
