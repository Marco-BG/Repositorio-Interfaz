Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
    End Sub

    Private Sub cargaFuentes()
        Dim miFuente As FontFamily
        For Each miFuente In FontFamily.Families
            ComboFuentes.Items.Add(miFuente.Name)
        Next
        ComboFuentes.Text = ComboFuentes.Items(0)
    End Sub

    Private Sub ComboFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFuentes.SelectedIndexChanged
        lbl_saludo.Font = New Font(ComboFuentes.Text, tlb_deslizador.Value)
    End Sub

    Private Sub tlb_deslizador_Scroll(sender As Object, e As EventArgs) Handles tlb_deslizador.Scroll
        lbl_saludo.Font = New Font(ComboFuentes.Text, tlb_deslizador.Value)
    End Sub
End Class
