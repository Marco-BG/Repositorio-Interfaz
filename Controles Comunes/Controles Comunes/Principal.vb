Public Class Principal

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click

        For Each Radio As RadioButton In panelOpcionesRadio.Controls

            If Radio.Checked Then
                lblSaludo.Text = Radio.Tag & " " & Radio.Text
            End If
            Me.Text = lblSaludo.Text
        Next
        For Each Radio As RadioButton In panelNombres.Controls
            If Radio.Checked Then
                lblSaludo.Text &= " " & Radio.Text
            End If
        Next
        Me.Text = lblSaludo.Text
    End Sub
End Class
