Imports System.IO

Module VariablesGlobales
    Dim directorioDebug As String = Directory.GetCurrentDirectory()
    Dim directorioBin As DirectoryInfo = Directory.GetParent(directorioDebug)
    Dim directorio As DirectoryInfo = Directory.GetParent(directorioBin.ToString())

    Public miConexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio.ToString() & "\DBMateriales.mdf;Integrated Security=True"

    Public Sub mostrarVentanaInicio()
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
    End Sub
    Public Sub mostrarVentanaCrear()
        Dim ventanaCrearMaterial As New VentanaCrearMaterial

        ventanaCrearMaterial.Show()

    End Sub
    Public Sub mostrarVentanaModificar()
        Dim ventanaModificarMaterial As New VentanaModificarMaterial

        ventanaModificarMaterial.Show()

    End Sub
    Public Sub mostrarVentanaListar()
        Dim ventanaListarMateriales As New VentanaListarMateriales

        ventanaListarMateriales.ShowDialog()

    End Sub
    Public Sub mostrarVentanaEliminar()
        Dim ventanaEliminarMaterial As New VentanaEliminarMaterial

        ventanaEliminarMaterial.Show()

    End Sub
End Module
