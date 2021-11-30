Public Class Form1
    Dim miAdaptador As OleDbDataAdapter
    Dim miConexionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\Neptuno.mdb"

    Dim miConexion As New OleDbConnection(miConexionString)
    Dim miTablaDatos As New DataTable

    Dim miBindingSource As New BindingSource

    Dim miConstructor As New OleDbCommandBuilder
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            miConexion.Open()
            MessageBox.Show("Conexión exitosa")

        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar a las base de datos")
            Exit Sub
        End Try

        Dim miMySQL As String = "Select * from productos"
        miAdaptador = New OleDbDataAdapter(miMySQL, miConexion)

        Try
            miAdaptador.Fill(miTablaDatos)
        Catch ex As Exception
            MessageBox.Show("No se ha realizado")
            Exit Sub
        End Try
        miConstructor.DataAdapter = miAdaptador

        miAdaptador.UpdateCommand = miConstructor.GetUpdateCommand
        miAdaptador.DeleteCommand = miConstructor.GetDeleteCommand
        miAdaptador.InsertCommand = miConstructor.GetInsertCommand

        miBindingSource.DataSource = miTablaDatos
        miBindingNavigator.BindingSource = miBindingSource
        miRejilla.DataSource = miBindingSource

        enlaceDb()
    End Sub
    Sub enlaceDb()
        textBoxProducto.DataBindings.Add(New Binding("Text", miBindingSource, "NombreProducto"))
    End Sub
    Sub actualizar()
        Dim numeroRegistro As Integer
        Try
            numeroRegistro = miAdaptador.Update(miTablaDatos)
            MessageBox.Show("Numero de registros actualizados " & numeroRegistro)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        actualizar()
    End Sub
End Class
