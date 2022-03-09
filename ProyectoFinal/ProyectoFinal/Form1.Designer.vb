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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonCrearMaterial = New System.Windows.Forms.Button()
        Me.buttonModificarMaterial = New System.Windows.Forms.Button()
        Me.buttonListarMaterial = New System.Windows.Forms.Button()
        Me.buttonEliminarMaterial = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrearMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.buttonIconoCrear = New System.Windows.Forms.ToolStripButton()
        Me.buttonIconoModificar = New System.Windows.Forms.ToolStripButton()
        Me.buttonIconoListar = New System.Windows.Forms.ToolStripButton()
        Me.buttonIconoEliminar = New System.Windows.Forms.ToolStripButton()
        Me.labelAlmacenMateriales = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonCrearMaterial
        '
        Me.buttonCrearMaterial.Location = New System.Drawing.Point(347, 148)
        Me.buttonCrearMaterial.Name = "buttonCrearMaterial"
        Me.buttonCrearMaterial.Size = New System.Drawing.Size(109, 23)
        Me.buttonCrearMaterial.TabIndex = 0
        Me.buttonCrearMaterial.Text = "Crear Material"
        Me.buttonCrearMaterial.UseVisualStyleBackColor = True
        '
        'buttonModificarMaterial
        '
        Me.buttonModificarMaterial.Location = New System.Drawing.Point(347, 192)
        Me.buttonModificarMaterial.Name = "buttonModificarMaterial"
        Me.buttonModificarMaterial.Size = New System.Drawing.Size(109, 23)
        Me.buttonModificarMaterial.TabIndex = 1
        Me.buttonModificarMaterial.Text = "Modificar Material"
        Me.buttonModificarMaterial.UseVisualStyleBackColor = True
        '
        'buttonListarMaterial
        '
        Me.buttonListarMaterial.Location = New System.Drawing.Point(347, 235)
        Me.buttonListarMaterial.Name = "buttonListarMaterial"
        Me.buttonListarMaterial.Size = New System.Drawing.Size(109, 23)
        Me.buttonListarMaterial.TabIndex = 2
        Me.buttonListarMaterial.Text = "Listar Materiales"
        Me.buttonListarMaterial.UseVisualStyleBackColor = True
        '
        'buttonEliminarMaterial
        '
        Me.buttonEliminarMaterial.Location = New System.Drawing.Point(347, 277)
        Me.buttonEliminarMaterial.Name = "buttonEliminarMaterial"
        Me.buttonEliminarMaterial.Size = New System.Drawing.Size(109, 23)
        Me.buttonEliminarMaterial.TabIndex = 3
        Me.buttonEliminarMaterial.Text = "Eliminar Material"
        Me.buttonEliminarMaterial.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpToolStripMenuItem
        '
        Me.OpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CrearMaterialToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.ListarMaterialesToolStripMenuItem, Me.EliminarMaterialToolStripMenuItem, Me.ToolStripMenuItem2, Me.CerrarToolStripMenuItem})
        Me.OpToolStripMenuItem.Name = "OpToolStripMenuItem"
        Me.OpToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.OpToolStripMenuItem.Text = "Opciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(197, 6)
        '
        'CrearMaterialToolStripMenuItem
        '
        Me.CrearMaterialToolStripMenuItem.Name = "CrearMaterialToolStripMenuItem"
        Me.CrearMaterialToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CrearMaterialToolStripMenuItem.Text = "Crear Material"
        '
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar Material"
        '
        'ListarMaterialesToolStripMenuItem
        '
        Me.ListarMaterialesToolStripMenuItem.Name = "ListarMaterialesToolStripMenuItem"
        Me.ListarMaterialesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ListarMaterialesToolStripMenuItem.Text = "Listar Materiales"
        '
        'EliminarMaterialToolStripMenuItem
        '
        Me.EliminarMaterialToolStripMenuItem.Name = "EliminarMaterialToolStripMenuItem"
        Me.EliminarMaterialToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EliminarMaterialToolStripMenuItem.Text = "Eliminar Material"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(197, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonIconoCrear, Me.buttonIconoModificar, Me.buttonIconoListar, Me.buttonIconoEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'buttonIconoCrear
        '
        Me.buttonIconoCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonIconoCrear.Image = CType(resources.GetObject("buttonIconoCrear.Image"), System.Drawing.Image)
        Me.buttonIconoCrear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonIconoCrear.Name = "buttonIconoCrear"
        Me.buttonIconoCrear.Size = New System.Drawing.Size(23, 22)
        Me.buttonIconoCrear.Text = "ToolStripButton1"
        '
        'buttonIconoModificar
        '
        Me.buttonIconoModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonIconoModificar.Image = CType(resources.GetObject("buttonIconoModificar.Image"), System.Drawing.Image)
        Me.buttonIconoModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonIconoModificar.Name = "buttonIconoModificar"
        Me.buttonIconoModificar.Size = New System.Drawing.Size(23, 22)
        Me.buttonIconoModificar.Text = "ToolStripButton2"
        '
        'buttonIconoListar
        '
        Me.buttonIconoListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonIconoListar.Image = CType(resources.GetObject("buttonIconoListar.Image"), System.Drawing.Image)
        Me.buttonIconoListar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonIconoListar.Name = "buttonIconoListar"
        Me.buttonIconoListar.Size = New System.Drawing.Size(23, 22)
        Me.buttonIconoListar.Text = "ToolStripButton3"
        '
        'buttonIconoEliminar
        '
        Me.buttonIconoEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonIconoEliminar.Image = CType(resources.GetObject("buttonIconoEliminar.Image"), System.Drawing.Image)
        Me.buttonIconoEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonIconoEliminar.Name = "buttonIconoEliminar"
        Me.buttonIconoEliminar.Size = New System.Drawing.Size(23, 22)
        Me.buttonIconoEliminar.Text = "ToolStripButton4"
        '
        'labelAlmacenMateriales
        '
        Me.labelAlmacenMateriales.AutoSize = True
        Me.labelAlmacenMateriales.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAlmacenMateriales.Location = New System.Drawing.Point(205, 64)
        Me.labelAlmacenMateriales.Name = "labelAlmacenMateriales"
        Me.labelAlmacenMateriales.Size = New System.Drawing.Size(395, 37)
        Me.labelAlmacenMateriales.TabIndex = 6
        Me.labelAlmacenMateriales.Text = "Almacén de Materiales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 89)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelAlmacenMateriales)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.buttonEliminarMaterial)
        Me.Controls.Add(Me.buttonListarMaterial)
        Me.Controls.Add(Me.buttonModificarMaterial)
        Me.Controls.Add(Me.buttonCrearMaterial)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Almacén de Materiales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonCrearMaterial As Button
    Friend WithEvents buttonModificarMaterial As Button
    Friend WithEvents buttonListarMaterial As Button
    Friend WithEvents buttonEliminarMaterial As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CrearMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents buttonIconoCrear As ToolStripButton
    Friend WithEvents buttonIconoModificar As ToolStripButton
    Friend WithEvents buttonIconoListar As ToolStripButton
    Friend WithEvents buttonIconoEliminar As ToolStripButton
    Friend WithEvents labelAlmacenMateriales As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
