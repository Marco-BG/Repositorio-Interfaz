Imports System.Data.SqlClient
Imports System.IO

Public Class VentanaCrearMaterial

    Private Sub VentanaCrearMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarPrimerValorSubCategoria()

        updateNumberMaterial()
    End Sub

    Private Sub cargarPrimerValorSubCategoria()
        comboBoxSubCategoria.Text = comboBoxSubCategoria.Items(0)

    End Sub
    Private Sub cleanAllTextBox()
        textBoxMaterial.Clear()
        textBoxDescripcion.Clear()
        textBoxCompra.Clear()
        textBoxStock.Clear()
    End Sub
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim inicio As New Form1

        inicio.Show()
        Me.Close()
    End Sub

    Private Sub updateNumberMaterial()
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand

        textBoxRegistro.Enabled = False

        conn.ConnectionString = MiConexionString
        conn.Open()

        cmd.Connection = conn

        Dim consultNumRegister As String = "select max(num_mat) from Materiales"

        Dim comandSelect As SqlCommand = New SqlCommand(consultNumRegister, conn)

        Dim numRegister As SqlDataReader = comandSelect.ExecuteReader()

        Dim cerosGenerados As String = ""
        Try
            If numRegister.Read Then
                textBoxRegistro.Text = numRegister(0) + 1
            End If
            cerosGenerados = textBoxRegistro.Text
            While cerosGenerados.Length < 8
                cerosGenerados = "0" & cerosGenerados
            End While
            textBoxRegistro.Text = cerosGenerados
        Catch ex As Exception
            textBoxRegistro.Text = 1

            cerosGenerados = textBoxRegistro.Text
            While cerosGenerados.Length < 8
                cerosGenerados = "0" & cerosGenerados
            End While
            textBoxRegistro.Text = cerosGenerados
        End Try
    End Sub

    Private Sub comboBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCategoria.SelectedIndexChanged

        If comboBoxCategoria.Text = "Hardware" Then
            'MessageBox.Show(comboBoxCategoria.Text)
            comboBoxSubCategoria.Text = ""
            comboBoxSubCategoria.Items.Clear()

            'Ahora a programar la subcategoria a partir de este control
            comboBoxSubCategoria.Items.Add("Equipo")
            comboBoxSubCategoria.Items.Add("Periféricos")
            comboBoxSubCategoria.Text = comboBoxSubCategoria.Items(0)
        Else
            'MessageBox.Show(comboBoxCategoria.Text)
            comboBoxSubCategoria.Text = ""

            comboBoxSubCategoria.Items.Clear()

            comboBoxSubCategoria.Items.Add("Antivirus")
            comboBoxSubCategoria.Items.Add("Servicio")

            comboBoxSubCategoria.Text = comboBoxSubCategoria.Items(0)
        End If
        'MessageBox.Show(comboBoxCategoria.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim cosa As String = Format(CDbl(textBoxCompra.Text), "c")
        textBoxVenta.Text = cosa
        MessageBox.Show(textBoxVenta.Text)
    End Sub

    Private Sub textBoxCompra_TextChanged(sender As Object, e As EventArgs) Handles textBoxCompra.TextChanged
        If textBoxCompra.Text.Length < 1 Then
            Exit Sub
        Else
            Dim cosa As String = Format(CDbl(textBoxCompra.Text), "#")

            Dim calculo As String = ""
            If comboBoxCategoria.Text = "Hardware" Then
                calculo = CDbl(sender.Text) * 1.8
                textBoxVenta.Text = CStr(calculo)
            Else
                calculo = CDbl(sender.Text) * 1.7
                textBoxVenta.Text = CStr(calculo)
            End If
        End If
    End Sub

    Private Sub toolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand

        Dim valorSeccion

        'MessageBox.Show(comboBoxCategoria.SelectedItem.ToString())
        'MessageBox.Show(comboBoxSubCategoria.SelectedItem.ToString())
        'MessageBox.Show(tiempoFechaRegistro.Text)

        For Each seccion As RadioButton In groupBoxSeccion.Controls
            If seccion.Checked Then
                valorSeccion = seccion.Text
            End If
        Next

        Try
            conn.ConnectionString = miConexionString
            conn.Open()

            cmd.Connection = conn

            cmd = New SqlCommand("INSERT INTO Materiales VALUES(@numRegistro, @material, @categoria, @subCategoria, @fechaRegistro, @descripcion, @importeCompra, @importeVenta)", conn)
            cmd.CommandType = CommandType.Text

            If (textBoxMaterial.Text.Equals("") And textBoxStock.Text.Equals("")) Then
                MessageBox.Show("Debe rellenar el campo " + labelMaterial.Text + " y el campo " + labelStock.Text)
                Exit Sub
            End If

            If textBoxDescripcion.Text.Equals("") Or textBoxCompra.Text.Equals("") Or textBoxVenta.Text.Equals("") Then
                textBoxDescripcion.Text = ""
                textBoxCompra.Text = 0
                textBoxVenta.Text = 0
            End If

            cmd.Parameters.Add("@numRegistro", SqlDbType.Int).Value = textBoxRegistro.Text
            cmd.Parameters.Add("@material", SqlDbType.VarChar).Value = textBoxMaterial.Text
            cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = comboBoxCategoria.SelectedItem.ToString()
            cmd.Parameters.Add("@subCategoria", SqlDbType.VarChar).Value = comboBoxSubCategoria.SelectedItem.ToString()
            cmd.Parameters.Add("@fechaRegistro", SqlDbType.DateTime).Value = tiempoFechaRegistro.Text.ToString()
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textBoxDescripcion.Text
            cmd.Parameters.Add("@importeCompra", SqlDbType.Money).Value = textBoxCompra.Text
            cmd.Parameters.Add("@importeVenta", SqlDbType.Money).Value = textBoxVenta.Text

            cmd.ExecuteNonQuery()

            Dim insertTable2 As String = "insert into Gest_Materiales values ('" + textBoxRegistro.Text + "', '" + comboBoxPasillo.SelectedItem.ToString() + "', '" + valorSeccion + "', '" + textBoxStock.Text + "')"
            cmd.CommandText = insertTable2

            cmd.ExecuteNonQuery()

            MessageBox.Show("Se ha creado el material")
        Catch ex As Exception
            MessageBox.Show("Debe rellenar los campos")
        Finally

            updateNumberMaterial()
            cleanAllTextBox()
        End Try
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        mostrarVentanaInicio()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        mostrarVentanaModificar()
        Me.Close()
    End Sub

    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        mostrarVentanaListar()
        Me.Close()
    End Sub

    Private Sub EliminarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMaterialToolStripMenuItem.Click
        mostrarVentanaEliminar()
        Me.Close()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cargaTabla()
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand

        conn.ConnectionString = miConexionString

        cmd = New SqlCommand("SELECT Materiales.num_mat, Materiales.mat, Materiales.cat, Materiales.sub_cat, Materiales.fe_reg, Materiales.[desc], Materiales.imp_com, Materiales.imp_ven, Gest_Materiales.pas, Gest_Materiales.sec, Gest_Materiales.stock
                    FROM Gest_Materiales INNER JOIN Materiales ON Gest_Materiales.num_mat = Materiales.num_mat")
    End Sub

End Class