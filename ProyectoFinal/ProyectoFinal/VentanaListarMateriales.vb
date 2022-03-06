Imports System.Data.SqlClient

Public Class VentanaListarMateriales

    Dim rejilla As New DataView
    Private Sub buttonRegresar_Click(sender As Object, e As EventArgs) Handles buttonRegresar.Click
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

        conn.ConnectionString = miConexionString
        Try
            conn.Open()
            MessageBox.Show("Conexion establecida")
        Catch ex As Exception
            MessageBox.Show("Conexion no establecida")
        End Try

        If Not textBoxNumero.Text.Trim = Nothing Then
            If concatenacion = "" Then
                concatenacion = "num_mat = '" + textBoxNumero.Text + "'"
            Else
                concatenacion += " AND num_mat = '" + textBoxNumero.Text + "'"
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
                Else
                    MessageBox.Show(radio.Text)
                    concatenacion += " AND sec = '" + radio.Text + "'"
                End If
            End If

        Next

        If Not concatenacion = "" Then
            Dim adaptador As New SqlDataAdapter("SELECT m.*, g.pas, g.sec, g.stock FROM Materiales m JOIN Gest_Materiales g ON m.num_mat = g.num_mat", conn)
            Dim datos As New DataSet
            adaptador.Fill(datos)
            rejilla.Table = datos.Tables(0)
            gridViewMateriales.DataSource = rejilla
            rejilla.RowFilter = concatenacion
        End If
    End Sub

    Private Sub buttonListar_Click(sender As Object, e As EventArgs) Handles buttonListar.Click
        filtrado()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub


End Class