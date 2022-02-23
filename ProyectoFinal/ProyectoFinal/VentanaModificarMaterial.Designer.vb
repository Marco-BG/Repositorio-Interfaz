<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaModificarMaterial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonRegresar
        '
        Me.buttonRegresar.Location = New System.Drawing.Point(13, 13)
        Me.buttonRegresar.Name = "buttonRegresar"
        Me.buttonRegresar.Size = New System.Drawing.Size(75, 23)
        Me.buttonRegresar.TabIndex = 0
        Me.buttonRegresar.Text = "Regresar"
        Me.buttonRegresar.UseVisualStyleBackColor = True
        '
        'VentanaModificarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonRegresar)
        Me.Name = "VentanaModificarMaterial"
        Me.Text = "VentanaModificarMaterial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonRegresar As Button
End Class
