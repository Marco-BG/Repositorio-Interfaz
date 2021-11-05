<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leerTexto
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
        Me.richTextFichero = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'richTextFichero
        '
        Me.richTextFichero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextFichero.Location = New System.Drawing.Point(0, 0)
        Me.richTextFichero.Name = "richTextFichero"
        Me.richTextFichero.Size = New System.Drawing.Size(800, 450)
        Me.richTextFichero.TabIndex = 0
        Me.richTextFichero.Text = ""
        '
        'leerTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.richTextFichero)
        Me.Name = "leerTexto"
        Me.Text = "leerTexto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richTextFichero As RichTextBox
End Class
