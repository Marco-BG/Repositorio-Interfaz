Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AbrirCajaTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaTextoToolStripMenuItem.Click


    End Sub

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        Dim miHijo As New Hijo
        miHijo.MdiParent = Me
        miHijo.Show()

    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CerrarVentanaActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActivaToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then
            Exit Sub
        End If
        ActiveMdiChild.Close()
    End Sub
End Class
