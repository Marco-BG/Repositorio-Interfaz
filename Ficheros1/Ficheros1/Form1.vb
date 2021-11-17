Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCargarFichero.Click
        Dim miFichero As New StreamReader("fichero.txt")

        cajaTexto.Text = miFichero.ReadToEnd
        miFichero.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim miDialogGuardar As New OpenFileDialog

        miDialogGuardar.InitialDirectory = My.Application.Info.DirectoryPath
        miDialogGuardar.ShowDialog()
        Dim miFichero As New StreamWriter(miDialogGuardar.FileName)
        miFichero.Write(cajaTexto.Text)
        miFichero.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        cajaTexto.Clear()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim canal As Integer = FreeFile()
        Dim miFichero As String = "fichero.txt"
        'miFichero = Dir(miFichero)
        'MessageBox.Show(miFichero)
        Dim texto As String = ""
        Try
            FileOpen(canal, miFichero, OpenMode.Input, OpenAccess.Read)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Do While Not EOF(canal)
            texto += LineInput(canal) + vbCrLf
        Loop
        cajaTexto.Text = texto
        FileClose(canal)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim canal As Integer = FreeFile()
        Dim miFichero As String = "fichero.txt"

        FileOpen(canal, miFichero, OpenMode.Output, OpenAccess.Write)

        Write(canal, cajaTexto.Text)
        FileClose(canal)

    End Sub
End Class
