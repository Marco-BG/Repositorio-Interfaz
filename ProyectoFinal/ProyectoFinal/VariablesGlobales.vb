Imports System.IO

Module VariablesGlobales
    Dim directorioDebug As String = Directory.GetCurrentDirectory()
    Dim directorioBin As DirectoryInfo = Directory.GetParent(directorioDebug)
    Dim directorio As DirectoryInfo = Directory.GetParent(directorioBin.ToString())

    Public miConexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio.ToString() & "\DBMateriales.mdf;Integrated Security=True"

End Module
