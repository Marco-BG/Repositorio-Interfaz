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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaModificarMaterial))
        Me.labelNumeroMaterial = New System.Windows.Forms.Label()
        Me.textBoxRegistro = New System.Windows.Forms.TextBox()
        Me.buttonBuscar = New System.Windows.Forms.Button()
        Me.labelMaterial = New System.Windows.Forms.Label()
        Me.labelCategoria = New System.Windows.Forms.Label()
        Me.labelSubcategoria = New System.Windows.Forms.Label()
        Me.labelFechaRegistro = New System.Windows.Forms.Label()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.labelImporteCompra = New System.Windows.Forms.Label()
        Me.labelImporteVenta = New System.Windows.Forms.Label()
        Me.labelPasillo = New System.Windows.Forms.Label()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.textBoxMaterial = New System.Windows.Forms.TextBox()
        Me.textBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.textBoxCompra = New System.Windows.Forms.TextBox()
        Me.textBoxVenta = New System.Windows.Forms.TextBox()
        Me.textBoxStock = New System.Windows.Forms.TextBox()
        Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.comboBoxSubCategoria = New System.Windows.Forms.ComboBox()
        Me.fechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxPasillo = New System.Windows.Forms.ComboBox()
        Me.groupBoxSeccion = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textBoxNumero = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMaterialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripInicio = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelVentanaModificar = New System.Windows.Forms.Label()
        Me.groupBoxSeccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelNumeroMaterial
        '
        Me.labelNumeroMaterial.AutoSize = True
        Me.labelNumeroMaterial.Location = New System.Drawing.Point(88, 167)
        Me.labelNumeroMaterial.Name = "labelNumeroMaterial"
        Me.labelNumeroMaterial.Size = New System.Drawing.Size(121, 13)
        Me.labelNumeroMaterial.TabIndex = 1
        Me.labelNumeroMaterial.Text = "Número de Material:"
        '
        'textBoxRegistro
        '
        Me.textBoxRegistro.Location = New System.Drawing.Point(208, 167)
        Me.textBoxRegistro.Name = "textBoxRegistro"
        Me.textBoxRegistro.Size = New System.Drawing.Size(100, 20)
        Me.textBoxRegistro.TabIndex = 2
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(314, 165)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.buttonBuscar.TabIndex = 3
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'labelMaterial
        '
        Me.labelMaterial.AutoSize = True
        Me.labelMaterial.Location = New System.Drawing.Point(17, 54)
        Me.labelMaterial.Name = "labelMaterial"
        Me.labelMaterial.Size = New System.Drawing.Size(61, 13)
        Me.labelMaterial.TabIndex = 4
        Me.labelMaterial.Text = "Material:"
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(17, 85)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(67, 13)
        Me.labelCategoria.TabIndex = 5
        Me.labelCategoria.Text = "Categoría:"
        '
        'labelSubcategoria
        '
        Me.labelSubcategoria.AutoSize = True
        Me.labelSubcategoria.Location = New System.Drawing.Point(17, 116)
        Me.labelSubcategoria.Name = "labelSubcategoria"
        Me.labelSubcategoria.Size = New System.Drawing.Size(85, 13)
        Me.labelSubcategoria.TabIndex = 6
        Me.labelSubcategoria.Text = "Subcategoría:"
        '
        'labelFechaRegistro
        '
        Me.labelFechaRegistro.AutoSize = True
        Me.labelFechaRegistro.Location = New System.Drawing.Point(17, 147)
        Me.labelFechaRegistro.Name = "labelFechaRegistro"
        Me.labelFechaRegistro.Size = New System.Drawing.Size(97, 13)
        Me.labelFechaRegistro.TabIndex = 7
        Me.labelFechaRegistro.Text = "Fecha Registro:"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(17, 180)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(79, 13)
        Me.labelDescripcion.TabIndex = 8
        Me.labelDescripcion.Text = "Descripción:"
        '
        'labelImporteCompra
        '
        Me.labelImporteCompra.AutoSize = True
        Me.labelImporteCompra.Location = New System.Drawing.Point(17, 241)
        Me.labelImporteCompra.Name = "labelImporteCompra"
        Me.labelImporteCompra.Size = New System.Drawing.Size(115, 13)
        Me.labelImporteCompra.TabIndex = 9
        Me.labelImporteCompra.Text = "Importe de Compra:"
        '
        'labelImporteVenta
        '
        Me.labelImporteVenta.AutoSize = True
        Me.labelImporteVenta.Location = New System.Drawing.Point(17, 274)
        Me.labelImporteVenta.Name = "labelImporteVenta"
        Me.labelImporteVenta.Size = New System.Drawing.Size(109, 13)
        Me.labelImporteVenta.TabIndex = 10
        Me.labelImporteVenta.Text = "Importe de Venta:"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(15, 31)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(55, 13)
        Me.labelPasillo.TabIndex = 11
        Me.labelPasillo.Text = "Pasillo:"
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Location = New System.Drawing.Point(8, 187)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(43, 13)
        Me.labelStock.TabIndex = 13
        Me.labelStock.Text = "Stock:"
        '
        'textBoxMaterial
        '
        Me.textBoxMaterial.Location = New System.Drawing.Point(137, 54)
        Me.textBoxMaterial.Name = "textBoxMaterial"
        Me.textBoxMaterial.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMaterial.TabIndex = 14
        '
        'textBoxDescripcion
        '
        Me.textBoxDescripcion.Location = New System.Drawing.Point(137, 180)
        Me.textBoxDescripcion.Multiline = True
        Me.textBoxDescripcion.Name = "textBoxDescripcion"
        Me.textBoxDescripcion.Size = New System.Drawing.Size(100, 45)
        Me.textBoxDescripcion.TabIndex = 18
        '
        'textBoxCompra
        '
        Me.textBoxCompra.Location = New System.Drawing.Point(137, 241)
        Me.textBoxCompra.Name = "textBoxCompra"
        Me.textBoxCompra.Size = New System.Drawing.Size(100, 20)
        Me.textBoxCompra.TabIndex = 19
        '
        'textBoxVenta
        '
        Me.textBoxVenta.Enabled = False
        Me.textBoxVenta.Location = New System.Drawing.Point(137, 274)
        Me.textBoxVenta.Name = "textBoxVenta"
        Me.textBoxVenta.Size = New System.Drawing.Size(100, 20)
        Me.textBoxVenta.TabIndex = 20
        '
        'textBoxStock
        '
        Me.textBoxStock.Location = New System.Drawing.Point(52, 185)
        Me.textBoxStock.Name = "textBoxStock"
        Me.textBoxStock.Size = New System.Drawing.Size(43, 20)
        Me.textBoxStock.TabIndex = 23
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.Location = New System.Drawing.Point(137, 85)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxCategoria.TabIndex = 25
        '
        'comboBoxSubCategoria
        '
        Me.comboBoxSubCategoria.FormattingEnabled = True
        Me.comboBoxSubCategoria.Location = New System.Drawing.Point(137, 116)
        Me.comboBoxSubCategoria.Name = "comboBoxSubCategoria"
        Me.comboBoxSubCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxSubCategoria.TabIndex = 26
        '
        'fechaRegistro
        '
        Me.fechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaRegistro.Location = New System.Drawing.Point(137, 147)
        Me.fechaRegistro.Name = "fechaRegistro"
        Me.fechaRegistro.ShowCheckBox = True
        Me.fechaRegistro.Size = New System.Drawing.Size(100, 20)
        Me.fechaRegistro.TabIndex = 27
        Me.fechaRegistro.Value = New Date(2022, 2, 26, 0, 0, 0, 0)
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Location = New System.Drawing.Point(76, 28)
        Me.comboBoxPasillo.Name = "comboBoxPasillo"
        Me.comboBoxPasillo.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxPasillo.TabIndex = 28
        '
        'groupBoxSeccion
        '
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton6)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton5)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton4)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton3)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton2)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton1)
        Me.groupBoxSeccion.Location = New System.Drawing.Point(11, 68)
        Me.groupBoxSeccion.Name = "groupBoxSeccion"
        Me.groupBoxSeccion.Size = New System.Drawing.Size(212, 97)
        Me.groupBoxSeccion.TabIndex = 29
        Me.groupBoxSeccion.TabStop = False
        Me.groupBoxSeccion.Text = "Sección"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(108, 66)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "F"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(108, 43)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "E"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(108, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "D"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 67)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "C"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "B"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "A"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(17, 27)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(49, 13)
        Me.labelNumero.TabIndex = 30
        Me.labelNumero.Text = "Número:"
        '
        'textBoxNumero
        '
        Me.textBoxNumero.Enabled = False
        Me.textBoxNumero.Location = New System.Drawing.Point(137, 27)
        Me.textBoxNumero.Name = "textBoxNumero"
        Me.textBoxNumero.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNumero.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelNumero)
        Me.GroupBox1.Controls.Add(Me.textBoxNumero)
        Me.GroupBox1.Controls.Add(Me.labelMaterial)
        Me.GroupBox1.Controls.Add(Me.labelCategoria)
        Me.GroupBox1.Controls.Add(Me.labelSubcategoria)
        Me.GroupBox1.Controls.Add(Me.labelFechaRegistro)
        Me.GroupBox1.Controls.Add(Me.fechaRegistro)
        Me.GroupBox1.Controls.Add(Me.labelDescripcion)
        Me.GroupBox1.Controls.Add(Me.comboBoxSubCategoria)
        Me.GroupBox1.Controls.Add(Me.labelImporteCompra)
        Me.GroupBox1.Controls.Add(Me.comboBoxCategoria)
        Me.GroupBox1.Controls.Add(Me.labelImporteVenta)
        Me.GroupBox1.Controls.Add(Me.textBoxMaterial)
        Me.GroupBox1.Controls.Add(Me.textBoxDescripcion)
        Me.GroupBox1.Controls.Add(Me.textBoxVenta)
        Me.GroupBox1.Controls.Add(Me.textBoxCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 302)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labelPasillo)
        Me.GroupBox2.Controls.Add(Me.labelStock)
        Me.GroupBox2.Controls.Add(Me.groupBoxSeccion)
        Me.GroupBox2.Controls.Add(Me.textBoxStock)
        Me.GroupBox2.Controls.Add(Me.comboBoxPasillo)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(448, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 302)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión de Materiales"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CrearMaterialesToolStripMenuItem, Me.ListarMaterialToolStripMenuItem, Me.EliminarMaterialToolStripMenuItem1, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CrearMaterialesToolStripMenuItem
        '
        Me.CrearMaterialesToolStripMenuItem.Name = "CrearMaterialesToolStripMenuItem"
        Me.CrearMaterialesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CrearMaterialesToolStripMenuItem.Text = "Crear Material"
        '
        'ListarMaterialToolStripMenuItem
        '
        Me.ListarMaterialToolStripMenuItem.Name = "ListarMaterialToolStripMenuItem"
        Me.ListarMaterialToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ListarMaterialToolStripMenuItem.Text = "Listar Materiales"
        '
        'EliminarMaterialToolStripMenuItem1
        '
        Me.EliminarMaterialToolStripMenuItem1.Name = "EliminarMaterialToolStripMenuItem1"
        Me.EliminarMaterialToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.EliminarMaterialToolStripMenuItem1.Text = "Eliminar Material"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripGuardar, Me.toolStripInicio})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(808, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripGuardar
        '
        Me.toolStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripGuardar.Image = CType(resources.GetObject("toolStripGuardar.Image"), System.Drawing.Image)
        Me.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripGuardar.Name = "toolStripGuardar"
        Me.toolStripGuardar.Size = New System.Drawing.Size(23, 22)
        Me.toolStripGuardar.Text = "ToolStripButton1"
        '
        'toolStripInicio
        '
        Me.toolStripInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripInicio.Image = CType(resources.GetObject("toolStripInicio.Image"), System.Drawing.Image)
        Me.toolStripInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripInicio.Name = "toolStripInicio"
        Me.toolStripInicio.Size = New System.Drawing.Size(23, 22)
        Me.toolStripInicio.Text = "ToolStripButton2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 90)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'labelVentanaModificar
        '
        Me.labelVentanaModificar.AutoSize = True
        Me.labelVentanaModificar.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVentanaModificar.Location = New System.Drawing.Point(257, 74)
        Me.labelVentanaModificar.Name = "labelVentanaModificar"
        Me.labelVentanaModificar.Size = New System.Drawing.Size(341, 37)
        Me.labelVentanaModificar.TabIndex = 37
        Me.labelVentanaModificar.Text = "Modificar Material"
        '
        'VentanaModificarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(808, 506)
        Me.Controls.Add(Me.labelVentanaModificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.buttonBuscar)
        Me.Controls.Add(Me.textBoxRegistro)
        Me.Controls.Add(Me.labelNumeroMaterial)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaModificarMaterial"
        Me.Text = "VentanaModificarMaterial"
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelNumeroMaterial As Label
    Friend WithEvents textBoxRegistro As TextBox
    Friend WithEvents buttonBuscar As Button
    Friend WithEvents labelMaterial As Label
    Friend WithEvents labelCategoria As Label
    Friend WithEvents labelSubcategoria As Label
    Friend WithEvents labelFechaRegistro As Label
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents labelImporteCompra As Label
    Friend WithEvents labelImporteVenta As Label
    Friend WithEvents labelPasillo As Label
    Friend WithEvents labelStock As Label
    Friend WithEvents textBoxMaterial As TextBox
    Friend WithEvents textBoxDescripcion As TextBox
    Friend WithEvents textBoxCompra As TextBox
    Friend WithEvents textBoxVenta As TextBox
    Friend WithEvents textBoxStock As TextBox
    Friend WithEvents comboBoxCategoria As ComboBox
    Friend WithEvents comboBoxSubCategoria As ComboBox
    Friend WithEvents fechaRegistro As DateTimePicker
    Friend WithEvents comboBoxPasillo As ComboBox
    Friend WithEvents groupBoxSeccion As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents labelNumero As Label
    Friend WithEvents textBoxNumero As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMaterialToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolStripGuardar As ToolStripButton
    Friend WithEvents toolStripInicio As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelVentanaModificar As Label
End Class
