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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaEliminarMaterial))
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textBoxNumeroEliminar = New System.Windows.Forms.TextBox()
        Me.buttonEliminar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.labelEliminarMaterial = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(144, 157)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(121, 13)
        Me.labelNumero.TabIndex = 1
        Me.labelNumero.Text = "Número de Material:"
        '
        'textBoxNumeroEliminar
        '
        Me.textBoxNumeroEliminar.Location = New System.Drawing.Point(271, 154)
        Me.textBoxNumeroEliminar.Name = "textBoxNumeroEliminar"
        Me.textBoxNumeroEliminar.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNumeroEliminar.TabIndex = 2
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Location = New System.Drawing.Point(391, 152)
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.buttonEliminar.TabIndex = 3
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CrearMaterialToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.ListarMaterialToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CrearMaterialToolStripMenuItem
        '
        Me.CrearMaterialToolStripMenuItem.Name = "CrearMaterialToolStripMenuItem"
        Me.CrearMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CrearMaterialToolStripMenuItem.Text = "Crear Material"
        '
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar Material"
        '
        'ListarMaterialToolStripMenuItem
        '
        Me.ListarMaterialToolStripMenuItem.Name = "ListarMaterialToolStripMenuItem"
        Me.ListarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListarMaterialToolStripMenuItem.Text = "Listar Material"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(589, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'labelEliminarMaterial
        '
        Me.labelEliminarMaterial.AutoSize = True
        Me.labelEliminarMaterial.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEliminarMaterial.Location = New System.Drawing.Point(142, 67)
        Me.labelEliminarMaterial.Name = "labelEliminarMaterial"
        Me.labelEliminarMaterial.Size = New System.Drawing.Size(323, 37)
        Me.labelEliminarMaterial.TabIndex = 6
        Me.labelEliminarMaterial.Text = "Eliminar Material"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 92)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'VentanaEliminarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(589, 226)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelEliminarMaterial)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.buttonEliminar)
        Me.Controls.Add(Me.textBoxNumeroEliminar)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaEliminarMaterial"
        Me.Text = "VentanaEliminarMaterial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelNumero As Label
    Friend WithEvents textBoxNumeroEliminar As TextBox
    Friend WithEvents buttonEliminar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents labelEliminarMaterial As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
