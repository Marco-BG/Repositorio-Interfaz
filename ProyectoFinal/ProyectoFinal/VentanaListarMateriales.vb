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

        Try

            If textBoxNumero.Text.Equals("") Then

                Me.DataTable1TableAdapter.FillByFiltro(DBMaterialesDataSet.DataTable1, CType(0, Integer), CType(textBoxCategoria.Text, String))

            Else
                Me.DataTable1TableAdapter.FillByFiltro(DBMaterialesDataSet.DataTable1, CType(textBoxNumero.Text, Integer), CType(textBoxCategoria.Text, String))
                'VentanaListarMateriales.DataTable1TableAdapter.FillAll(VentanaListarMateriales.DBMaterialesDataSet.DataTable1)

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
    Public Sub refrescarGrid()
        Me.DataTable1TableAdapter.FillAll(Me.DBMaterialesDataSet.DataTable1)
    End Sub
End Class