Imports System.Data.SqlClient

Public Class Form1
    Dim radioDepartament As String = ""

    Public location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DAM2Alu1\Desktop\InsertBaseDatos\registroBd\registroBd\baseUsuario.mdf;Integrated Security=True"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadComboBox()

        updateRegister()




    End Sub

    Private Sub updateRegister()
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand



        conn.ConnectionString = location
        conn.Open()

        cmd.Connection = conn

        Dim consultNumRegister As String = "select max(numRegistro) from Usuario"

        Dim comandSelect As SqlCommand = New SqlCommand(consultNumRegister, conn)


        Dim numRegister As SqlDataReader = comandSelect.ExecuteReader()

        If numRegister.Read Then
            textBoxRegister.Text = numRegister(0) + 1
        End If
    End Sub

    Private Sub loadComboBox()
        comboBoxPeriod.Text = comboBoxPeriod.Items(0)

    End Sub
    Private Sub deleteForm()
        textBoxName.Text = ""
        textBoxLastName.Text = ""
        textBoxDNI.Text = ""

        obligatoryName.Text = ""
        obligatoryLastName.Text = ""
        obligatoryDNI.Text = ""
    End Sub
    Private Sub fieldObligatory()

        Dim campoObligatorio As String = "Campos Obligatorios*"

        obligatoryName.ForeColor = Color.Red
        obligatoryName.Text = campoObligatorio

        obligatoryLastName.ForeColor = Color.Red
        obligatoryLastName.Text = campoObligatorio

        obligatoryDNI.ForeColor = Color.Red
        obligatoryDNI.Text = campoObligatorio
    End Sub
    Private Function fillComprobation() As Boolean

        Dim isChecked As Boolean

        If textBoxName.Text.Equals("") Or textBoxLastName.Text.Equals("") Or textBoxDNI.Text.Equals("") Then
            fieldObligatory()
            Return False
        Else
            Return True
        End If

        For Each nameRadioButton As RadioButton In groupBoxDepartament.Controls
            If nameRadioButton.Checked Then
                isChecked = True
            End If
        Next
    End Function



    Private Sub buttonSend_Click(sender As Object, e As EventArgs) Handles buttonSend.Click
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand

        If Not fillComprobation() Then
            MessageBox.Show("Rellena los campos obligatorios")
        Else
            For Each radio As RadioButton In groupBoxDepartament.Controls
                If radio.Checked Then
                    radioDepartament = radio.Text
                End If
            Next

            Try

                conn.ConnectionString = location
                conn.Open()

                cmd.Connection = conn

                Dim insertUser As String = "insert into Usuario values ('" + Str(textBoxRegister.Text) + "', '" + textBoxDNI.Text.ToString() + "', '" + textBoxName.Text.ToString() + "', '" + textBoxLastName.Text.ToString() + "', '" + dateTime.Text.ToString() + "', '" + radioDepartament.ToString() + "', '" + comboBoxPeriod.SelectedItem.ToString() + "')"
                cmd.CommandText = insertUser

                cmd.ExecuteNonQuery()
                MessageBox.Show("exito")
                deleteForm()
                updateRegister()
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class
