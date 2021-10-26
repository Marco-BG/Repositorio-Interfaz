Public Class Form1
    'Friend WithEvents miBoton As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'miBoton = New Button
        'miBoton.Text = "Pulsar"

        Dim miBoton = New Button

        AddHandler miBoton.Click, AddressOf click_Boton
        Me.Controls.Add(miBoton)
    End Sub
    Sub click_Boton(miObjeto As Object, evento As EventArgs)
        MessageBox.Show("Hola")
    End Sub

    Private Sub btn_masTextBox_Click(sender As Object, e As EventArgs) Handles btn_masTextBox.Click
        Dim miTextBox As CajaTexto

        If panel.Controls.Count > 9 Then
            Exit Sub
        End If
        miTextBox = New CajaTexto
        miTextBox.Top = panel.Controls.Count * (miTextBox.Height + 5)
        AddHandler miTextBox.DoubleClick, AddressOf miTexto
        panel.Controls.Add(miTextBox)
        miTextBox.Name = "" & panel.Controls.Count
        lbl_textContador.Text = "Nº de TextBox " & panel.Controls.Count
    End Sub

    Private Sub btn_menosTextBox_Click(sender As Object, e As EventArgs) Handles btn_menosTextBox.Click
        If panel.Controls.Count = 0 Then
            Exit Sub
        End If
        panel.Controls.RemoveAt(panel.Controls.Count - 1)
        lbl_textContador.Text = "Nº de TextBox " & panel.Controls.Count
    End Sub
    Private Sub miTexto(objeto As Object, evento As EventArgs)
        Dim miTexto As TextBox = objeto
        If miTexto.Text = "" Then
            Exit Sub
        End If
        MessageBox.Show("Contenido de mi TexBox " + miTexto.Name + " es " + miTexto.Text)
    End Sub
End Class

