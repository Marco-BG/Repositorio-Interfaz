Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class VentanaListarMateriales

    Dim rejilla As New DataView
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs)
        Dim ventanaInicio As New Form1

        ventanaInicio.Show()
        Me.Close()
    End Sub

    Private Sub VentanaListarMateriales_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " "
    End Sub

    Private Sub filtrado()
        Dim conn As New SqlConnection
        Dim cmd As SqlCommand
        Dim concatenacion As String = ""

        Dim regex As Regex = New Regex("^[1-9]*$")

        conn.ConnectionString = miConexionString
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Conexion no establecida")
        End Try

        If Not textBoxNumero.Text.Trim = Nothing Then
            If concatenacion = "" Then
                concatenacion = "num_mat = '" + textBoxNumero.Text + "'"
                textBoxNumero.Clear()
            Else
                concatenacion += " AND num_mat = '" + textBoxNumero.Text + "'"
                textBoxNumero.Clear()
            End If
        End If


        If Not comboBoxCategoria.SelectedItem = Nothing Then
            If concatenacion = "" Then
                concatenacion = "cat LIKE '%" + comboBoxCategoria.Text + "%'"
            Else
                concatenacion += " AND cat LIKE '%" + comboBoxCategoria.Text + "%'"
            End If
        End If

        If Not comboBoxSubCategoria.SelectedItem = Nothing Then
            If concatenacion = "" Then
                concatenacion = "sub_cat LIKE '%" + comboBoxSubCategoria.Text + "%'"
            Else
                concatenacion += " AND sub_cat LIKE '%" + comboBoxSubCategoria.Text + "%'"
            End If
        End If

        If Not DateTimePicker1.Text = Nothing Then
            If concatenacion = "" Then
                concatenacion = "fe_reg = '" + DateTimePicker1.Value.Date + "'"
            Else
                concatenacion += " AND fe_reg = '" + DateTimePicker1.Value.Date + "'"
            End If
        End If

        If Not comboBoxPasillo.Text = Nothing Then
            If concatenacion = "" Then
                concatenacion = "pas = '" + comboBoxPasillo.Text + "'"
            Else
                concatenacion += " AND pas = '" + comboBoxPasillo.Text + "'"
            End If
        End If

        For Each radio As RadioButton In groupBoxSeccion.Controls
            If radio.Checked Then
                If concatenacion = "" Then
                    concatenacion = "sec = '" + radio.Text + "'"
                    radio.Checked = False
                Else
                    MessageBox.Show(radio.Text)
                    concatenacion += " AND sec = '" + radio.Text + "'"
                    radio.Checked = False
                End If
            End If

        Next

        If Not regex.IsMatch(textBoxNumero.Text) Then
            MessageBox.Show("Debe introducir un número")
            Exit Sub
        Else
            If Not concatenacion = "" Then
                Dim adaptador As New SqlDataAdapter("SELECT m.*, g.pas, g.sec, g.stock FROM Materiales m JOIN Gest_Materiales g ON m.num_mat = g.num_mat", conn)
                Dim datos As New DataSet
                adaptador.Fill(datos)

                rejilla.Table = datos.Tables(0)
                gridViewMateriales.DataSource = rejilla
                rejilla.RowFilter = concatenacion


            End If
        End If

    End Sub

    Private Sub buttonListar_Click(sender As Object, e As EventArgs) Handles buttonListar.Click
        filtrado()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        mostrarVentanaInicio()
        Me.Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        mostrarVentanaInicio()
        Me.Close()
    End Sub

    Private Sub CrearMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearMaterialToolStripMenuItem.Click
        mostrarVentanaCrear()
        Me.Close()
    End Sub

    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        mostrarVentanaModificar()
        Me.Close()
    End Sub

    Private Sub EliminarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMaterialToolStripMenuItem.Click
        mostrarVentanaEliminar()
        Me.Close()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class