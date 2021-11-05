Public Class Form1
    Dim contador As FontStyle
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()


    End Sub

    Private Sub cargaFuentes()
        Dim miFuente
        For Each miFuente In FontFamily.Families
            ComboFuentes.Items.Add(miFuente.Name)
        Next
        ComboFuentes.Text = ComboFuentes.Items(0)
    End Sub

    Private Sub cargaEstilos()

        contador = FontStyle.Regular

        For Each cuadrado As CheckBox In Panel1.Controls
            If cuadrado.Checked Then
                'Select Case cuadrado.Name

                '    Case "checkNormal"
                '        contador += FontStyle.Regular
                '    Case "checkNegrita"
                '        contador += FontStyle.Bold
                '    Case "checkInclinada"
                '        contador += FontStyle.Italic
                '    Case "checkSubrayada"
                '        contador += FontStyle.Underline
                '    Case "checkTachada"
                '        contador += FontStyle.Strikeout
                'End Select
                contador += cuadrado.Font.Style
            End If
        Next
        If contador Then
            checkNormal.Checked = False
        End If
        Dim miFuente As New Font(ComboFuentes.Text, tlb_deslizador.Value, contador)
        lbl_saludo.Font = miFuente
    End Sub


    Private Sub ComboFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFuentes.SelectedIndexChanged
        lbl_saludo.Font = New Font(ComboFuentes.Text, tlb_deslizador.Value, contador)
    End Sub

    Private Sub tlb_deslizador_Scroll(sender As Object, e As EventArgs) Handles tlb_deslizador.Scroll
        lbl_saludo.Font = New Font(ComboFuentes.Text, tlb_deslizador.Value, contador)
    End Sub

    Private Sub checks(sender As Object, e As EventArgs) Handles checkNegrita.CheckedChanged, checkInclinada.CheckedChanged, checkSubrayada.CheckedChanged, checkTachada.CheckedChanged


        If checkNormal.Checked Then
            'If checkNegrita.Checked Or checkInclinada.Checked Or checkSubrayada.Checked Or checkTachada.Checked Then
            '    checkNegrita.Checked = False
            '    checkInclinada.Checked = False
            '    checkSubrayada.Checked = False
            '    checkTachada.Checked = False
            'End If
            cargaEstilos()
            Exit Sub
        End If

        cargaEstilos()
        If contador = 0 Then
            checkNormal.Checked = True
        End If


    End Sub

    Private Sub checkNormal_CheckedChanged(sender As Object, e As EventArgs) Handles checkNormal.CheckedChanged
        If checkNormal.Checked Then
            For Each micheck As CheckBox In Panel1.Controls
                micheck.Checked = False
            Next
        End If
        If contador = 0 Then checkNormal.Checked = True
    End Sub
End Class
