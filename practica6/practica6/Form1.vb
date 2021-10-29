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
        Dim miTextBox = New TextBox
        Dim texto = New Label

        If panel.Controls.Count > 18 Then
            Exit Sub
        End If

        texto.Text = "Nº de TextBox " & panel.Controls.Count / 2

        miTextBox.Top = panel.Controls.Count * (miTextBox.Height)
        texto.Top = panel.Controls.Count * (texto.Height)
        miTextBox.Left = 150

        texto.ForeColor = Color.Red
        miTextBox.ForeColor = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))

        AddHandler miTextBox.DoubleClick, AddressOf miTexto

        panel.Controls.Add(texto)
        panel.Controls.Add(miTextBox)
        miTextBox.Name = "" & panel.Controls.Count

        'If panel.Controls.GetType().Equals(miTextBox) Then
        'lbl_textContador.Text = "Nº de TextBox " & panel.Controls.Count
        ' End If

        lbl_textContador.Text = "Nº de TextBox " & panel.Controls.Count / 2
    End Sub

    Private Sub btn_menosTextBox_Click(sender As Object, e As EventArgs) Handles btn_menosTextBox.Click
        If panel.Controls.Count = 0 Then
            Exit Sub
        End If
        panel.Controls.RemoveAt(panel.Controls.Count - 1)
        panel.Controls.RemoveAt(panel.Controls.Count - 1)
        lbl_textContador.Text = "Nº de TextBox " & panel.Controls.Count / 2
    End Sub
    Private Sub miTexto(objeto As Object, evento As EventArgs)
        Dim miTexto As TextBox = objeto
        If miTexto.Text = "" Then
            Exit Sub
        End If
        MessageBox.Show("Contenido de mi TexBox " + miTexto.Name + " es " + miTexto.Text)
    End Sub
End Class

