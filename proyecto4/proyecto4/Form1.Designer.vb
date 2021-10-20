<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.ltb_color = New System.Windows.Forms.ListBox()
        Me.btn_color = New System.Windows.Forms.Button()
        Me.ltb_marcas = New System.Windows.Forms.ListBox()
        Me.txt_marcas = New System.Windows.Forms.TextBox()
        Me.btn_ingresaMarcas = New System.Windows.Forms.Button()
        Me.btn_borrarColor = New System.Windows.Forms.Button()
        Me.btn_borrarMarcas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(99, 157)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(120, 23)
        Me.txt_color.TabIndex = 0
        '
        'ltb_color
        '
        Me.ltb_color.FormattingEnabled = True
        Me.ltb_color.ItemHeight = 15
        Me.ltb_color.Location = New System.Drawing.Point(99, 57)
        Me.ltb_color.Name = "ltb_color"
        Me.ltb_color.Size = New System.Drawing.Size(120, 94)
        Me.ltb_color.TabIndex = 1
        '
        'btn_color
        '
        Me.btn_color.Location = New System.Drawing.Point(99, 186)
        Me.btn_color.Name = "btn_color"
        Me.btn_color.Size = New System.Drawing.Size(120, 23)
        Me.btn_color.TabIndex = 2
        Me.btn_color.Text = "Ingresar Color"
        Me.btn_color.UseVisualStyleBackColor = True
        '
        'ltb_marcas
        '
        Me.ltb_marcas.FormattingEnabled = True
        Me.ltb_marcas.ItemHeight = 15
        Me.ltb_marcas.Location = New System.Drawing.Point(249, 57)
        Me.ltb_marcas.Name = "ltb_marcas"
        Me.ltb_marcas.Size = New System.Drawing.Size(120, 94)
        Me.ltb_marcas.TabIndex = 1
        '
        'txt_marcas
        '
        Me.txt_marcas.Location = New System.Drawing.Point(249, 157)
        Me.txt_marcas.Name = "txt_marcas"
        Me.txt_marcas.Size = New System.Drawing.Size(120, 23)
        Me.txt_marcas.TabIndex = 0
        '
        'btn_ingresaMarcas
        '
        Me.btn_ingresaMarcas.Location = New System.Drawing.Point(249, 186)
        Me.btn_ingresaMarcas.Name = "btn_ingresaMarcas"
        Me.btn_ingresaMarcas.Size = New System.Drawing.Size(120, 23)
        Me.btn_ingresaMarcas.TabIndex = 2
        Me.btn_ingresaMarcas.Text = "Ingresar Marcas"
        Me.btn_ingresaMarcas.UseVisualStyleBackColor = True
        '
        'btn_borrarColor
        '
        Me.btn_borrarColor.Location = New System.Drawing.Point(99, 215)
        Me.btn_borrarColor.Name = "btn_borrarColor"
        Me.btn_borrarColor.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarColor.TabIndex = 2
        Me.btn_borrarColor.Text = "Borrar Color"
        Me.btn_borrarColor.UseVisualStyleBackColor = True
        '
        'btn_borrarMarcas
        '
        Me.btn_borrarMarcas.Location = New System.Drawing.Point(249, 215)
        Me.btn_borrarMarcas.Name = "btn_borrarMarcas"
        Me.btn_borrarMarcas.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarMarcas.TabIndex = 2
        Me.btn_borrarMarcas.Text = "Borrar Marcas"
        Me.btn_borrarMarcas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_borrarMarcas)
        Me.Controls.Add(Me.btn_ingresaMarcas)
        Me.Controls.Add(Me.btn_borrarColor)
        Me.Controls.Add(Me.btn_color)
        Me.Controls.Add(Me.ltb_marcas)
        Me.Controls.Add(Me.ltb_color)
        Me.Controls.Add(Me.txt_marcas)
        Me.Controls.Add(Me.txt_color)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_color As TextBox
    Friend WithEvents ltb_color As ListBox
    Friend WithEvents btn_color As Button
    Friend WithEvents ltb_marcas As ListBox
    Friend WithEvents txt_marcas As TextBox
    Friend WithEvents btn_ingresaMarcas As Button
    Friend WithEvents btn_borrarColor As Button
    Friend WithEvents btn_borrarMarcas As Button
End Class
