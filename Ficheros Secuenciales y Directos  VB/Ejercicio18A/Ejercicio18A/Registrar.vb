Imports System.ComponentModel

Public Class Registrar
    Dim Archivo As String
    Dim Canal As Integer = FreeFile()
    Dim Nreg As Integer
    Private Sub AñadirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles AñadirToolStripMenuItem.Click, NuevoToolStripMenuItem.Click
        'Dim MiAbrir As New OpenFileDialog
        'MiAbrir.Title = "Añadir datos en..."
        'MiAbrir.ShowDialog()
        'If MiAbrir.FileName = "" Then Exit Sub
        'Archivo = MiAbrir.FileName
        'FileOpen(Canal, Archivo, OpenMode.Append)
        'PBotones.Visible = True
        Dim Miopcion As ToolStripMenuItem = sender
        Dim Titulo As String
        Select Case Miopcion.Tag
            Case 8
                Titulo = "Añadir datos en..."
            Case 2
                Titulo = "Nuevo Archivo de datos..."
        End Select
        ModoApertura(Miopcion.Tag, Titulo)
    End Sub

    Sub ModoApertura(Modo As Integer, Titulo As String)
        Dim MiAbrir As New OpenFileDialog
        MiAbrir.Title = Titulo
        MiAbrir.ShowDialog()
        If MiAbrir.FileName = "" Then Exit Sub
        Archivo = MiAbrir.FileName
        FileOpen(Canal, Archivo, Modo)
        PBotones.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLimpiar.Click
        limpiar()
        CNombre.Focus()
    End Sub

    Private Sub BRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRegistrar.Click
        Write(Canal, CNombre.Text)
        Write(Canal, CApellidos.Text)
        Write(Canal, CFecha.Text)
        limpiar()
        CNombre.Focus()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        FileClose(Canal)
        Me.Dispose()
    End Sub
    Sub limpiar()
        CNombre.Clear()
        CApellidos.Clear()
        CFecha.Clear()
    End Sub

    Private Sub Registrar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FileClose(Canal)
    End Sub

    'Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
    '    Dim MiAbrir As New SaveFileDialog
    '    MiAbrir.Title = "Nuevo Archivo de datos..."
    '    MiAbrir.ShowDialog()
    '    If MiAbrir.FileName = "" Then Exit Sub
    '    Archivo = MiAbrir.FileName
    '    FileOpen(Canal, Archivo, OpenMode.Output)
    '    PBotones.Visible = True
    'End Sub
End Class