Imports System.Data.SqlClient

Public Class VentanaModificarMaterial
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs) Handles buttonRegresar.Click
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
        Me.Close()
    End Sub

    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim datosSelect As SqlDataReader

        conn.ConnectionString = miConexionString

        conn.Open()
        cmd = New SqlCommand("SELECT Gest_Materiales.pas, Gest_Materiales.sec, Gest_Materiales.stock, Materiales.mat, Materiales.cat, Materiales.sub_cat, Materiales.fe_reg, Materiales.[desc], Materiales.imp_com, Materiales.imp_ven FROM Gest_Materiales INNER JOIN Materiales ON Gest_Materiales.num_mat = Materiales.num_mat WHERE Gest_Materiales.num_mat = @numeroMaterial", conn)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.Add("@numeroMaterial", SqlDbType.Int).Value = textBoxRegistro.Text
        Try
            datosSelect = cmd.ExecuteReader()

            If datosSelect.HasRows Then
                datosSelect.Read()
                MessageBox.Show(datosSelect.GetString(1) + " " + CStr(CInt(datosSelect.GetInt32(2))) + " " + datosSelect.GetString(3) + " " + datosSelect.GetString(4) + " " + datosSelect.GetString(5) + " " + datosSelect.GetDateTime(6) + " " + datosSelect.GetString(7) + " " + CStr(CDbl(datosSelect.GetSqlMoney(8))) + " " + CStr(CDbl(datosSelect.GetSqlMoney(9))) + " " + Str(CInt(datosSelect.GetInt32(0))))

                Dim seccion As String = datosSelect.GetString(1)
                Dim categoria As String = datosSelect.GetString(4)

                Select Case seccion
                    Case "A"
                        RadioButton1.Checked = True
                    Case "B"
                        RadioButton2.Checked = True
                    Case "C"
                        RadioButton3.Checked = True
                    Case "D"
                        RadioButton4.Checked = True
                    Case "E"
                        RadioButton5.Checked = True
                    Case "F"
                        RadioButton6.Checked = True
                End Select

                Select Case categoria
                    Case "Hardware"
                        comboBoxCategoria.Items.Clear()
                        comboBoxCategoria.Items.Add("Software")
                        comboBoxCategoria.Items.Add("Hardware")

                        comboBoxSubCategoria.Items.Add("Equipos")
                        comboBoxSubCategoria.Items.Add("Periféricos")
                    Case "Software"
                        comboBoxCategoria.Items.Clear()
                        comboBoxCategoria.Items.Add("Hardware")
                        comboBoxCategoria.Items.Add("Software")

                        comboBoxSubCategoria.Items.Add("Antivirus")
                        comboBoxSubCategoria.Items.Add("Servicios")
                End Select

                comboBoxPasillo.Text = CStr(CInt(datosSelect.GetInt32(0)))
                textBoxMaterial.Text = datosSelect.GetString(3)
                comboBoxCategoria.Text = categoria
                comboBoxSubCategoria.Text = datosSelect.GetString(5)
                fechaRegistro.Text = datosSelect.GetDateTime(6)
                textBoxDescripcion.Text = datosSelect.GetString(7)
                textBoxCompra.Text = datosSelect.GetSqlMoney(8)
                textBoxVenta.Text = datosSelect.GetSqlMoney(9)
                textBoxStock.Text = CStr(CInt(datosSelect.GetInt32(2)))

            Else
                MessageBox.Show("No existe el material")
            End If

        Catch ex As Exception
            MessageBox.Show("Debe poner el id para buscar el material")
        Finally
            loadPasillos()

        End Try


    End Sub

    Private Sub comboBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCategoria.SelectedIndexChanged
        If comboBoxCategoria.SelectedItem.Equals("Hardware") Then
            comboBoxSubCategoria.Items.Clear()
            comboBoxSubCategoria.Items.Add("Equipos")
            comboBoxSubCategoria.Items.Add("Periféricos")

        Else
            comboBoxSubCategoria.Items.Clear()
            comboBoxSubCategoria.Items.Add("Antivirus")
            comboBoxSubCategoria.Items.Add("Servicio")
        End If
    End Sub
    Private Sub loadPasillos()
        comboBoxPasillo.Items.Add(1)
        comboBoxPasillo.Items.Add(2)
        comboBoxPasillo.Items.Add(3)
        comboBoxPasillo.Items.Add(4)
        comboBoxPasillo.Items.Add(5)
        comboBoxPasillo.Items.Add(6)
        comboBoxPasillo.Items.Add(7)
        comboBoxPasillo.Items.Add(8)
    End Sub

    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        Dim conn As New SqlConnection
        Dim cmd As SqlCommand
        Dim cmdSelectNumber As SqlCommand
        Dim sqlDataReader As SqlDataReader

        Dim valorSeccion As String = ""

        For Each seccion As RadioButton In groupBoxSeccion.Controls
            If seccion.Checked Then
                valorSeccion = seccion.Text
            End If
        Next

        Try
            conn.ConnectionString = miConexionString
            conn.Open()

            Dim numeroGuardado As Integer = 0

            If textBoxRegistro.Text.Equals("") Then
                MessageBox.Show("Debe buscar el id del material")
                Exit Sub
            Else
                cmdSelectNumber = New SqlCommand("SELECT num_mat FROM Materiales WHERE num_mat = @numero", conn)
                cmdSelectNumber.CommandType = CommandType.Text
                cmdSelectNumber.Parameters.Add("@numero", SqlDbType.Int).Value = textBoxRegistro.Text

                sqlDataReader = cmdSelectNumber.ExecuteReader

                If sqlDataReader.HasRows Then
                    sqlDataReader.Read()
                    MessageBox.Show(CStr(CInt(sqlDataReader.GetInt32(0))))

                    numeroGuardado = sqlDataReader.GetInt32(0)

                    conn.Close()
                    conn.Open()

                    cmd = New SqlCommand("UPDATE Materiales SET mat = @material, cat = @categoria, sub_cat = @subCategoria, fe_reg = @fechaRegistro, [desc] = @descripcion, imp_com = @importeCompra, imp_ven = @importeVenta WHERE num_mat = @numeroMaterial", conn)
                    cmd.CommandType = CommandType.Text

                    If textBoxCompra.Text.Equals("") Then
                        Exit Sub
                    Else
                        cmd.Parameters.Add("@material", SqlDbType.VarChar).Value = textBoxMaterial.Text
                        cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = comboBoxCategoria.Text
                        cmd.Parameters.Add("@subCategoria", SqlDbType.VarChar).Value = comboBoxSubCategoria.Text
                        cmd.Parameters.Add("@fechaRegistro", SqlDbType.DateTime).Value = fechaRegistro.Text
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textBoxDescripcion.Text
                        cmd.Parameters.Add("@importeCompra", SqlDbType.Money).Value = textBoxCompra.Text
                        cmd.Parameters.Add("@importeVenta", SqlDbType.Money).Value = textBoxVenta.Text
                        cmd.Parameters.Add("@numeroMaterial", SqlDbType.Int).Value = CStr(numeroGuardado)

                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand("UPDATE Gest_Materiales SET pas = @pasillo, sec = @seccion, stock = @stock WHERE num_mat = @numeroMaterial", conn)
                        cmd.CommandType = CommandType.Text

                        cmd.Parameters.Add("@pasillo", SqlDbType.VarChar).Value = comboBoxPasillo.Text
                        cmd.Parameters.Add("@seccion", SqlDbType.VarChar).Value = valorSeccion
                        cmd.Parameters.Add("@stock", SqlDbType.Int).Value = textBoxStock.Text
                        cmd.Parameters.Add("@numeroMaterial", SqlDbType.Int).Value = textBoxRegistro.Text

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("El material se ha guardado exitosamente")
                    End If
                Else
                    MessageBox.Show("No existe el material")

                End If
            End If




        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class