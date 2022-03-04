Public Class Form1

    'Metodos para mostrar las ventanas de la aplicación =>
    '---------------------------------------------------------------------------------------------------------------

    'Eventos de los botones de la ventana de inicio =>
    '---------------------------------------------------------------------------------------------------------------
    Private Sub buttonCrearMaterial_Click(sender As Object, e As EventArgs) Handles buttonCrearMaterial.Click
        mostrarVentanaCrear()
        Me.Close()
    End Sub

    Private Sub buttonModificarMaterial_Click(sender As Object, e As EventArgs) Handles buttonModificarMaterial.Click
        mostrarVentanaModificar()
        Me.Close()
    End Sub

    Private Sub buttonListar_Click(sender As Object, e As EventArgs) Handles buttonListarMaterial.Click
        mostrarVentanaListar()
        Me.Close()
    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminarMaterial.Click
        mostrarVentanaEliminar()
        Me.Close()
    End Sub
    'Eventos para los botones del menu primario (Menú opciones) =>
    '----------------------------------------------------------------------------------------------------------------
    Private Sub CrearMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearMaterialToolStripMenuItem.Click
        mostrarVentanaCrear()
        Me.Close()
    End Sub
    Private Sub ModificarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMaterialToolStripMenuItem.Click
        mostrarVentanaModificar()
        Me.Close()
    End Sub
    Private Sub ListarMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMaterialesToolStripMenuItem.Click
        mostrarVentanaListar()
        Me.Close()
    End Sub
    Private Sub EliminarMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMaterialToolStripMenuItem.Click
        mostrarVentanaEliminar()
        Me.Close()
    End Sub
    Private Sub cerrarAplicacion(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Eventos para los botones de la barra de iconos (Menú secundario) =>
    '----------------------------------------------------------------------------------------------------------------
    Private Sub buttonIconoCrear_Click(sender As Object, e As EventArgs) Handles buttonIconoCrear.Click
        mostrarVentanaCrear()
        Me.Close()
    End Sub

    Private Sub buttonIconoModificar_Click(sender As Object, e As EventArgs) Handles buttonIconoModificar.Click
        mostrarVentanaModificar()
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles buttonIconoListar.Click
        mostrarVentanaListar()
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles buttonIconoEliminar.Click
        mostrarVentanaEliminar()
        Me.Close()
    End Sub
End Class
