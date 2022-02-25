Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Solo se cumple una condicion 
        If Not TextBox1.Text.Equals("") And Not TextBox2.Text.Equals("") Then
            MessageBox.Show("se muestra el 1 y 2")

        ElseIf Not TextBox2.Text.Equals("") And Not TextBox3.Text.Equals("") Then
            MessageBox.Show("se muestra el 2 y 3")

        ElseIf Not TextBox1.Text.Equals("") Then
            MessageBox.Show("se muestra el 1")

        ElseIf Not TextBox2.Text.Equals("") Then
            MessageBox.Show("se muestra el 2")
        End If
    End Sub
End Class
