Imports System.Data.SqlClient

Public Class VentanaConfirmacionEliminar
    Private Sub buttonSi_Click(sender As Object, e As EventArgs) Handles buttonSi.Click
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand

        conn.ConnectionString = miConexionString
        conn.Open()

        cmd = New SqlCommand("DELETE FROM Gest_Materiales WHERE num_mat = @numeroMaterial", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@numeroMaterial", SqlDbType.Int).Value = textBoxNumBorrar.Text
        cmd.ExecuteNonQuery()

        cmd = New SqlCommand("DELETE FROM Materiales WHERE num_mat = @numeroMaterial", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@numeroMaterial", SqlDbType.Int).Value = textBoxNumBorrar.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("Se ha borrado el material", "Borrado de Material")
    End Sub
End Class