﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        'VentanaEliminarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonRegresarInicio)
        Me.Name = "VentanaEliminarMaterial"
        Me.Text = "VentanaEliminarMaterial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonRegresarInicio As Button
End Class
