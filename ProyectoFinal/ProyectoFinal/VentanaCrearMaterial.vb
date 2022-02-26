Imports System.Data.SqlClient
Imports System.IO

Public Class VentanaCrearMaterial


    Dim directorioDebug As String = Directory.GetCurrentDirectory()
    Dim directorioBin As DirectoryInfo = Directory.GetParent(directorioDebug)
    Dim directorio As DirectoryInfo = Directory.GetParent(directorioBin.ToString())

    Dim MiConexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio.ToString() & "\DBMateriales.mdf;Integrated Security=True"

    Private Sub VentanaCrearMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarPrimerValorSubCategoria()
        updateNumberMaterial()
    End Sub

    Private Sub cargarPrimerValorSubCategoria()
        comboBoxSubCategoria.Text = comboBoxSubCategoria.Items(0)

    End Sub
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs) Handles buttonRegresar.Click
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

        If numRegister.Read Then
            textBoxRegistro.Text = numRegister(0) + 1
        End If
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

    Private Sub buttonInsertar_Click(sender As Object, e As EventArgs) Handles buttonInsertar.Click
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
            conn.ConnectionString = MiConexionString
            conn.Open()

            cmd.Connection = conn

            Dim insertTable1 As String = "insert into Materiales values ('" + textBoxRegistro.Text + "', '" + textBoxMaterial.Text.ToString() + "', '" + comboBoxCategoria.SelectedItem.ToString() + "', '" + comboBoxSubCategoria.SelectedItem.ToString() + "', '" + tiempoFechaRegistro.Text.ToString() + "', '" + textBoxDescripcion.Text.ToString() + "', '" + textBoxCompra.Text.ToString() + "','" + textBoxVenta.Text.ToString() + "')"
            cmd.CommandText = insertTable1

            cmd.ExecuteNonQuery()

            Dim insertTable2 As String = "insert into Gest_Materiales values ('" + textBoxRegistro.Text + "', '" + comboBoxPasillo.SelectedItem.ToString() + "', '" + valorSeccion + "', '" + textBoxStock.Text + "')"
            cmd.CommandText = insertTable2

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            updateNumberMaterial()
        End Try



    End Sub
End Class

