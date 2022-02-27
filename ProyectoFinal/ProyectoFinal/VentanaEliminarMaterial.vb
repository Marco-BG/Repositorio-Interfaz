Imports System.Data.SqlClient

Public Class VentanaEliminarMaterial
    Private Sub buttonRegresarInicio_Click(sender As Object, e As EventArgs) Handles buttonRegresarInicio.Click
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
        Me.Close()
    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminar.Click
        'VentanaConfirmacionEliminar.TextBox1.Text = textBoxNumeroEliminar.Text
        'VentanaConfirmacionEliminar.Show()

        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim datosSelect As SqlDataReader

        conn.ConnectionString = miConexionString

        conn.Open()
        cmd = New SqlCommand("SELECT num_mat, mat FROM Materiales WHERE num_mat = @numero", conn)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = textBoxNumeroEliminar.Text

        datosSelect = cmd.ExecuteReader()

        If datosSelect.HasRows Then
            datosSelect.Read()
            'MessageBox.Show(CStr(CInt(datosSelect.GetInt32(0))) + " " + datosSelect.GetString(1))
            VentanaConfirmacionEliminar.TextBox1.Text = CStr(CInt(datosSelect.GetInt32(0)))
            VentanaConfirmacionEliminar.TextBox2.Text = datosSelect.GetString(1)

            VentanaConfirmacionEliminar.Show()
        End If
    End Sub
End Class