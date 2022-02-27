<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaEliminarMaterial
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
        Me.buttonRegresarInicio = New System.Windows.Forms.Button()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textBoxNumeroEliminar = New System.Windows.Forms.TextBox()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonRegresarInicio
        '
        Me.buttonRegresarInicio.Location = New System.Drawing.Point(13, 13)
        Me.buttonRegresarInicio.Name = "buttonRegresarInicio"
        Me.buttonRegresarInicio.Size = New System.Drawing.Size(75, 23)
        Me.buttonRegresarInicio.TabIndex = 0
        Me.buttonRegresarInicio.Text = "Regresar"
        Me.buttonRegresarInicio.UseVisualStyleBackColor = True
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(13, 79)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(39, 13)
        Me.labelNumero.TabIndex = 1
        Me.labelNumero.Text = "Label1"
        '
        'textBoxNumeroEliminar
        '
        Me.textBoxNumeroEliminar.Location = New System.Drawing.Point(59, 79)
        Me.textBoxNumeroEliminar.Name = "textBoxNumeroEliminar"
        Me.textBoxNumeroEliminar.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNumeroEliminar.TabIndex = 2
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(265, 79)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.buttonEliminar.TabIndex = 3
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'VentanaEliminarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.textBoxNumeroEliminar)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.buttonRegresarInicio)
        Me.Name = "VentanaEliminarMaterial"
        Me.Text = "VentanaEliminarMaterial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonRegresarInicio As Button
    Friend WithEvents labelNumero As Label
    Friend WithEvents textBoxNumeroEliminar As TextBox
    Friend WithEvents buttonEliminar As Button
End Class
