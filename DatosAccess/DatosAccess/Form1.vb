﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.NeptunoDataSet.Pedidos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Detalles_de_pedidos' Puede moverla o quitarla según sea necesario.
        Me.Detalles_de_pedidosTableAdapter.Fill(Me.NeptunoDataSet.Detalles_de_pedidos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.NeptunoDataSet.Clientes)

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet)

    End Sub
End Class
