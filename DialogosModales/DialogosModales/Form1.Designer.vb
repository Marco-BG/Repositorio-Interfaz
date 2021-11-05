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
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarVentanaActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.abrirFichero = New System.Windows.Forms.OpenFileDialog()
        Me.guardarFichero = New System.Windows.Forms.SaveFileDialog()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(800, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeerToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarVentanaActivaToolStripMenuItem, Me.CerrarTodasToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'LeerToolStripMenuItem
        '
        Me.LeerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImagenToolStripMenuItem, Me.TextoToolStripMenuItem})
        Me.LeerToolStripMenuItem.Name = "LeerToolStripMenuItem"
        Me.LeerToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LeerToolStripMenuItem.Text = "Leer"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 6)
        '
        'CerrarVentanaActivaToolStripMenuItem
        '
        Me.CerrarVentanaActivaToolStripMenuItem.Name = "CerrarVentanaActivaToolStripMenuItem"
        Me.CerrarVentanaActivaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CerrarVentanaActivaToolStripMenuItem.Text = "Cerrar Ventana Activa"
        '
        'CerrarTodasToolStripMenuItem
        '
        Me.CerrarTodasToolStripMenuItem.Name = "CerrarTodasToolStripMenuItem"
        Me.CerrarTodasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CerrarTodasToolStripMenuItem.Text = "Cerrar Todas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'abrirFichero
        '
        Me.abrirFichero.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarVentanaActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents abrirFichero As OpenFileDialog
    Friend WithEvents guardarFichero As SaveFileDialog
End Class
