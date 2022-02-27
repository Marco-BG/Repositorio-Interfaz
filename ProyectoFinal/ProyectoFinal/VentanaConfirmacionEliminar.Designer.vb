<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaConfirmacionEliminar
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
        Me.labelTextoConfirma = New System.Windows.Forms.Label()
        Me.labelNumeroMaterial = New System.Windows.Forms.Label()
        Me.labelMaterial = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.buttonSi = New System.Windows.Forms.Button()
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTextoConfirma
        '
        Me.labelTextoConfirma.AutoSize = True
        Me.labelTextoConfirma.Location = New System.Drawing.Point(179, 25)
        Me.labelTextoConfirma.Name = "labelTextoConfirma"
        Me.labelTextoConfirma.Size = New System.Drawing.Size(226, 13)
        Me.labelTextoConfirma.TabIndex = 0
        Me.labelTextoConfirma.Text = "¿Estas seguro que quieres eliminar el material?"
        '
        'labelNumeroMaterial
        '
        Me.labelNumeroMaterial.AutoSize = True
        Me.labelNumeroMaterial.Location = New System.Drawing.Point(32, 74)
        Me.labelNumeroMaterial.Name = "labelNumeroMaterial"
        Me.labelNumeroMaterial.Size = New System.Drawing.Size(102, 13)
        Me.labelNumeroMaterial.TabIndex = 1
        Me.labelNumeroMaterial.Text = "Número de Material:"
        '
        'labelMaterial
        '
        Me.labelMaterial.AutoSize = True
        Me.labelMaterial.Location = New System.Drawing.Point(35, 105)
        Me.labelMaterial.Name = "labelMaterial"
        Me.labelMaterial.Size = New System.Drawing.Size(47, 13)
        Me.labelMaterial.TabIndex = 2
        Me.labelMaterial.Text = "Material:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(160, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(160, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'buttonSi
        '
        Me.buttonSi.Location = New System.Drawing.Point(160, 198)
        Me.buttonSi.Name = "buttonSi"
        Me.buttonSi.Size = New System.Drawing.Size(75, 23)
        Me.buttonSi.TabIndex = 5
        Me.buttonSi.Text = "SI"
        Me.buttonSi.UseVisualStyleBackColor = True
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(314, 198)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 6
        Me.buttonCancelar.Text = "CANCELAR"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'VentanaConfirmacionEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 257)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonSi)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelMaterial)
        Me.Controls.Add(Me.labelNumeroMaterial)
        Me.Controls.Add(Me.labelTextoConfirma)
        Me.Name = "VentanaConfirmacionEliminar"
        Me.Text = "VentanaConfirmacionEliminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTextoConfirma As Label
    Friend WithEvents labelNumeroMaterial As Label
    Friend WithEvents labelMaterial As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents buttonSi As Button
    Friend WithEvents buttonCancelar As Button
End Class
