Imports System.Data.SqlClient

Public Class VentanaListarMateriales
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs) Handles buttonRegresar.Click
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
        Me.Close()
    End Sub

    Private Sub VentanaListarMateriales_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.DataTable1TableAdapter.Fill(Me.DBMaterialesDataSet.DataTable1, CType(NumeroToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub buttonListar_Click(sender As Object, e As EventArgs) Handles buttonListar.Click
        'Dim conn As New SqlConnection
        'Dim cmd As New SqlCommand
        'Dim sqlDataReader As SqlDataReader

        'Dim numeroParametro As Integer = 0
        'conn.ConnectionString = miConexionString

        'conn.Open()

        'cmd = New SqlCommand("SELECT num_mat FROM Materiales WHERE num_mat = @numero", conn)
        'cmd.CommandType = CommandType.Text


        'cmd.Parameters.Add("@numero", SqlDbType.Int).Value = textBoxNumero.Text
        'sqlDataReader = cmd.ExecuteReader


        'If sqlDataReader.HasRows Then
        '    sqlDataReader.Read()

        '    numeroParametro = sqlDataReader.GetSqlInt32(0)


        'Else
        '    MessageBox.Show("No existe el material")
        'End If
        Try
            If textBoxNumero.Text.Equals("") Then
                Me.DataTable1TableAdapter.FillByFiltro(Me.DBMaterialesDataSet.DataTable1, CType(0, Integer), CType(textBoxCategoria.Text, String))
            Else
                Me.DataTable1TableAdapter.FillByFiltro(Me.DBMaterialesDataSet.DataTable1, CType(textBoxNumero.Text, Integer), CType(textBoxCategoria.Text, String))
            End If


        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.DataTable1TableAdapter.Fill(Me.DBMaterialesDataSet.DataTable1, CType(NumeroToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class