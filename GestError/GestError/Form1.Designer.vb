<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.AbrirArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.pictureImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pictureImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(100, 50)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(102, 23)
        Me.btnImagen.TabIndex = 0
        Me.btnImagen.Text = "Cargar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'AbrirArchivo
        '
        Me.AbrirArchivo.FileName = "OpenFileDialog1"
        '
        'pictureImagen
        '
        Me.pictureImagen.Location = New System.Drawing.Point(324, 64)
        Me.pictureImagen.Name = "pictureImagen"
        Me.pictureImagen.Size = New System.Drawing.Size(346, 241)
        Me.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureImagen.TabIndex = 1
        Me.pictureImagen.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureImagen)
        Me.Controls.Add(Me.btnImagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImagen As Button
    Friend WithEvents AbrirArchivo As OpenFileDialog
    Friend WithEvents pictureImagen As PictureBox
End Class
