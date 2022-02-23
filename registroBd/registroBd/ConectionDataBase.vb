Imports System.Data.SqlClient

Public Class ConectionDataBase

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DAM2Alu1\Desktop\InsertBaseDatos\registroBd\registroBd\baseUsuario.mdf;Integrated Security=True"
End Class
