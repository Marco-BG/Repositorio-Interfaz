Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'SampleDatabaseDataSet1.Orders' Puede moverla o quitarla según sea necesario.
        Me.OrdersTableAdapter.Fill(Me.SampleDatabaseDataSet1.Orders)
        'TODO: esta línea de código carga datos en la tabla 'SampleDatabaseDataSet1.Customer' Puede moverla o quitarla según sea necesario.
        Me.CustomerTableAdapter.Fill(Me.SampleDatabaseDataSet1.Customer)


    End Sub
End Class
