Public Class Form1

    'Cargo la función "cargarFuentes()" a mi formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load, MyBase.Load
        cargarFuentes()
        click_paneles()
    End Sub

    'Funcion para que me devuelva las fuentes del sistema
    Private Sub cargarFuentes()
        Dim fuentes
        For Each fuentes In FontFamily.Families
            comboFuentes.Items.Add(fuentes.Name)
        Next
        comboFuentes.Text = comboFuentes.Items(0)
    End Sub

    Private Sub tlb_deslizador_Scroll(sender As Object, e As EventArgs) Handles tlb_deslizador.Scroll
        If tlb_deslizador.Value > 1 Then
            lbl_saludo.Font = New Font(comboFuentes.Text, tlb_deslizador.Value)
        End If
    End Sub

    Private Sub comboFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFuentes.SelectedIndexChanged
        lbl_saludo.Font = New Font(comboFuentes.Text, tlb_deslizador.Value)
    End Sub

    Private Sub btn_cambiarColores_Click(sender As Object, e As EventArgs) Handles btn_cambiarColores.Click
        For Each paneles As Panel In grupoColores.Controls
            paneles.BackColor = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)
        Next
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        For Each radios As RadioButton In grupoOpciones.Controls
            If radios.Checked Then
                Select Case radios.Name
                    Case "radioColorFuente"
                        lbl_saludo.ForeColor = Panel1.BackColor
                    Case "radioCambiarFondo"
                        lbl_saludo.BackColor = Panel1.BackColor
                End Select
            End If
        Next
    End Sub


    Private Sub click_paneles()
        For Each paneles As Panel In grupoColores.Controls

            AddHandler paneles.Click, AddressOf Me.botones_Click

        Next
    End Sub
    Private Sub botones_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim panel As Panel = sender

        If radioColorFuente.Checked Then
            lbl_saludo.ForeColor = panel.BackColor

        ElseIf radioCambiarFondo.Checked Then
            lbl_saludo.BackColor = panel.BackColor
        End If
    End Sub

End Class


