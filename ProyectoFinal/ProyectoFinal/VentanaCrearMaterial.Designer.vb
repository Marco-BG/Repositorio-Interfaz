<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCrearMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCrearMaterial))
        Me.grupBoxCampos = New System.Windows.Forms.GroupBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.textBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.textBoxCompra = New System.Windows.Forms.TextBox()
        Me.textBoxVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tiempoFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaRegistro = New System.Windows.Forms.Label()
        Me.labelImporteCompra = New System.Windows.Forms.Label()
        Me.comboBoxSubCategoria = New System.Windows.Forms.ComboBox()
        Me.labelSubCategoria = New System.Windows.Forms.Label()
        Me.labelCategoria = New System.Windows.Forms.Label()
        Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.textBoxMaterial = New System.Windows.Forms.TextBox()
        Me.labelMaterial = New System.Windows.Forms.Label()
        Me.textBoxRegistro = New System.Windows.Forms.TextBox()
        Me.labelNumeroRegistro = New System.Windows.Forms.Label()
        Me.comboBoxPasillo = New System.Windows.Forms.ComboBox()
        Me.labelPasillo = New System.Windows.Forms.Label()
        Me.groupBoxSeccion = New System.Windows.Forms.GroupBox()
        Me.radioButtonF = New System.Windows.Forms.RadioButton()
        Me.radioButtonE = New System.Windows.Forms.RadioButton()
        Me.radioButtonD = New System.Windows.Forms.RadioButton()
        Me.radioButtonC = New System.Windows.Forms.RadioButton()
        Me.radioButtonB = New System.Windows.Forms.RadioButton()
        Me.radioButtonA = New System.Windows.Forms.RadioButton()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.textBoxStock = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.grupBoxCampos.SuspendLayout()
        Me.groupBoxSeccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupBoxCampos
        '
        Me.grupBoxCampos.Controls.Add(Me.labelDescripcion)
        Me.grupBoxCampos.Controls.Add(Me.textBoxDescripcion)
        Me.grupBoxCampos.Controls.Add(Me.textBoxCompra)
        Me.grupBoxCampos.Controls.Add(Me.textBoxVenta)
        Me.grupBoxCampos.Controls.Add(Me.Label1)
        Me.grupBoxCampos.Controls.Add(Me.tiempoFechaRegistro)
        Me.grupBoxCampos.Controls.Add(Me.labelFechaRegistro)
        Me.grupBoxCampos.Controls.Add(Me.labelImporteCompra)
        Me.grupBoxCampos.Controls.Add(Me.comboBoxSubCategoria)
        Me.grupBoxCampos.Controls.Add(Me.labelSubCategoria)
        Me.grupBoxCampos.Controls.Add(Me.labelCategoria)
        Me.grupBoxCampos.Controls.Add(Me.comboBoxCategoria)
        Me.grupBoxCampos.Controls.Add(Me.textBoxMaterial)
        Me.grupBoxCampos.Controls.Add(Me.labelMaterial)
        Me.grupBoxCampos.Controls.Add(Me.textBoxRegistro)
        Me.grupBoxCampos.Controls.Add(Me.labelNumeroRegistro)
        Me.grupBoxCampos.Location = New System.Drawing.Point(144, 217)
        Me.grupBoxCampos.Name = "grupBoxCampos"
        Me.grupBoxCampos.Size = New System.Drawing.Size(275, 322)
        Me.grupBoxCampos.TabIndex = 1
        Me.grupBoxCampos.TabStop = False
        Me.grupBoxCampos.Text = "Material"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(9, 225)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(79, 13)
        Me.labelDescripcion.TabIndex = 18
        Me.labelDescripcion.Text = "Descripción:"
        '
        'textBoxDescripcion
        '
        Me.textBoxDescripcion.Location = New System.Drawing.Point(112, 209)
        Me.textBoxDescripcion.Multiline = True
        Me.textBoxDescripcion.Name = "textBoxDescripcion"
        Me.textBoxDescripcion.Size = New System.Drawing.Size(148, 51)
        Me.textBoxDescripcion.TabIndex = 17
        '
        'textBoxCompra
        '
        Me.textBoxCompra.Location = New System.Drawing.Point(112, 266)
        Me.textBoxCompra.Name = "textBoxCompra"
        Me.textBoxCompra.Size = New System.Drawing.Size(105, 20)
        Me.textBoxCompra.TabIndex = 14
        '
        'textBoxVenta
        '
        Me.textBoxVenta.Enabled = False
        Me.textBoxVenta.Location = New System.Drawing.Point(111, 293)
        Me.textBoxVenta.Name = "textBoxVenta"
        Me.textBoxVenta.Size = New System.Drawing.Size(106, 20)
        Me.textBoxVenta.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Importe de Venta:"
        '
        'tiempoFechaRegistro
        '
        Me.tiempoFechaRegistro.CustomFormat = "yyyy/MM/dd"
        Me.tiempoFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tiempoFechaRegistro.Location = New System.Drawing.Point(111, 175)
        Me.tiempoFechaRegistro.Name = "tiempoFechaRegistro"
        Me.tiempoFechaRegistro.Size = New System.Drawing.Size(106, 20)
        Me.tiempoFechaRegistro.TabIndex = 11
        '
        'labelFechaRegistro
        '
        Me.labelFechaRegistro.AutoSize = True
        Me.labelFechaRegistro.Location = New System.Drawing.Point(6, 175)
        Me.labelFechaRegistro.Name = "labelFechaRegistro"
        Me.labelFechaRegistro.Size = New System.Drawing.Size(115, 13)
        Me.labelFechaRegistro.TabIndex = 10
        Me.labelFechaRegistro.Text = "Fecha de Registro:"
        '
        'labelImporteCompra
        '
        Me.labelImporteCompra.AutoSize = True
        Me.labelImporteCompra.Location = New System.Drawing.Point(6, 266)
        Me.labelImporteCompra.Name = "labelImporteCompra"
        Me.labelImporteCompra.Size = New System.Drawing.Size(115, 13)
        Me.labelImporteCompra.TabIndex = 8
        Me.labelImporteCompra.Text = "Importe de Compra:"
        '
        'comboBoxSubCategoria
        '
        Me.comboBoxSubCategoria.FormattingEnabled = True
        Me.comboBoxSubCategoria.Location = New System.Drawing.Point(111, 139)
        Me.comboBoxSubCategoria.Name = "comboBoxSubCategoria"
        Me.comboBoxSubCategoria.Size = New System.Drawing.Size(106, 21)
        Me.comboBoxSubCategoria.TabIndex = 7
        '
        'labelSubCategoria
        '
        Me.labelSubCategoria.AutoSize = True
        Me.labelSubCategoria.Location = New System.Drawing.Point(6, 142)
        Me.labelSubCategoria.Name = "labelSubCategoria"
        Me.labelSubCategoria.Size = New System.Drawing.Size(85, 13)
        Me.labelSubCategoria.TabIndex = 6
        Me.labelSubCategoria.Text = "SubCategoria:"
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(6, 104)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(67, 13)
        Me.labelCategoria.TabIndex = 5
        Me.labelCategoria.Text = "Categoría:"
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.comboBoxCategoria.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.comboBoxCategoria.Location = New System.Drawing.Point(111, 104)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(106, 21)
        Me.comboBoxCategoria.TabIndex = 4
        Me.comboBoxCategoria.Text = "Hardware"
        '
        'textBoxMaterial
        '
        Me.textBoxMaterial.Location = New System.Drawing.Point(111, 69)
        Me.textBoxMaterial.Name = "textBoxMaterial"
        Me.textBoxMaterial.Size = New System.Drawing.Size(106, 20)
        Me.textBoxMaterial.TabIndex = 3
        '
        'labelMaterial
        '
        Me.labelMaterial.AutoSize = True
        Me.labelMaterial.Location = New System.Drawing.Point(6, 69)
        Me.labelMaterial.Name = "labelMaterial"
        Me.labelMaterial.Size = New System.Drawing.Size(61, 13)
        Me.labelMaterial.TabIndex = 2
        Me.labelMaterial.Text = "Material:"
        '
        'textBoxRegistro
        '
        Me.textBoxRegistro.Location = New System.Drawing.Point(111, 37)
        Me.textBoxRegistro.Name = "textBoxRegistro"
        Me.textBoxRegistro.Size = New System.Drawing.Size(106, 20)
        Me.textBoxRegistro.TabIndex = 1
        '
        'labelNumeroRegistro
        '
        Me.labelNumeroRegistro.AutoSize = True
        Me.labelNumeroRegistro.Location = New System.Drawing.Point(6, 40)
        Me.labelNumeroRegistro.Name = "labelNumeroRegistro"
        Me.labelNumeroRegistro.Size = New System.Drawing.Size(103, 13)
        Me.labelNumeroRegistro.TabIndex = 0
        Me.labelNumeroRegistro.Text = "Número Registro:"
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.comboBoxPasillo.Location = New System.Drawing.Point(51, 43)
        Me.comboBoxPasillo.Name = "comboBoxPasillo"
        Me.comboBoxPasillo.Size = New System.Drawing.Size(106, 21)
        Me.comboBoxPasillo.TabIndex = 16
        Me.comboBoxPasillo.Text = "1"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(6, 46)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(55, 13)
        Me.labelPasillo.TabIndex = 15
        Me.labelPasillo.Text = "Pasillo:"
        '
        'groupBoxSeccion
        '
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonF)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonE)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonD)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonC)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonB)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonA)
        Me.groupBoxSeccion.Location = New System.Drawing.Point(6, 92)
        Me.groupBoxSeccion.Name = "groupBoxSeccion"
        Me.groupBoxSeccion.Size = New System.Drawing.Size(222, 100)
        Me.groupBoxSeccion.TabIndex = 2
        Me.groupBoxSeccion.TabStop = False
        Me.groupBoxSeccion.Text = "Sección"
        '
        'radioButtonF
        '
        Me.radioButtonF.AutoSize = True
        Me.radioButtonF.Location = New System.Drawing.Point(104, 68)
        Me.radioButtonF.Name = "radioButtonF"
        Me.radioButtonF.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonF.TabIndex = 5
        Me.radioButtonF.Text = "F"
        Me.radioButtonF.UseVisualStyleBackColor = True
        '
        'radioButtonE
        '
        Me.radioButtonE.AutoSize = True
        Me.radioButtonE.Location = New System.Drawing.Point(104, 45)
        Me.radioButtonE.Name = "radioButtonE"
        Me.radioButtonE.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonE.TabIndex = 4
        Me.radioButtonE.Text = "E"
        Me.radioButtonE.UseVisualStyleBackColor = True
        '
        'radioButtonD
        '
        Me.radioButtonD.AutoSize = True
        Me.radioButtonD.Location = New System.Drawing.Point(104, 20)
        Me.radioButtonD.Name = "radioButtonD"
        Me.radioButtonD.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonD.TabIndex = 3
        Me.radioButtonD.Text = "D"
        Me.radioButtonD.UseVisualStyleBackColor = True
        '
        'radioButtonC
        '
        Me.radioButtonC.AutoSize = True
        Me.radioButtonC.Location = New System.Drawing.Point(7, 68)
        Me.radioButtonC.Name = "radioButtonC"
        Me.radioButtonC.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonC.TabIndex = 2
        Me.radioButtonC.Text = "C"
        Me.radioButtonC.UseVisualStyleBackColor = True
        '
        'radioButtonB
        '
        Me.radioButtonB.AutoSize = True
        Me.radioButtonB.Location = New System.Drawing.Point(7, 44)
        Me.radioButtonB.Name = "radioButtonB"
        Me.radioButtonB.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonB.TabIndex = 1
        Me.radioButtonB.Text = "B"
        Me.radioButtonB.UseVisualStyleBackColor = True
        '
        'radioButtonA
        '
        Me.radioButtonA.AutoSize = True
        Me.radioButtonA.Checked = True
        Me.radioButtonA.Location = New System.Drawing.Point(7, 20)
        Me.radioButtonA.Name = "radioButtonA"
        Me.radioButtonA.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonA.TabIndex = 0
        Me.radioButtonA.TabStop = True
        Me.radioButtonA.Text = "A"
        Me.radioButtonA.UseVisualStyleBackColor = True
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Location = New System.Drawing.Point(6, 221)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(43, 13)
        Me.labelStock.TabIndex = 3
        Me.labelStock.Text = "Stock:"
        '
        'textBoxStock
        '
        Me.textBoxStock.Location = New System.Drawing.Point(50, 217)
        Me.textBoxStock.Name = "textBoxStock"
        Me.textBoxStock.Size = New System.Drawing.Size(42, 20)
        Me.textBoxStock.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.groupBoxSeccion)
        Me.GroupBox1.Controls.Add(Me.labelStock)
        Me.GroupBox1.Controls.Add(Me.comboBoxPasillo)
        Me.GroupBox1.Controls.Add(Me.textBoxStock)
        Me.GroupBox1.Controls.Add(Me.labelPasillo)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 322)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion de Materiales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 93)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.ListarMaterialesToolStripMenuItem, Me.EliminarMaterialToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
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
        'ModificarMaterialToolStripMenuItem
        '
        Me.ModificarMaterialToolStripMenuItem.Name = "ModificarMaterialToolStripMenuItem"
        Me.ModificarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificarMaterialToolStripMenuItem.Text = "Modificar Material"
        '
        'ListarMaterialesToolStripMenuItem
        '
        Me.ListarMaterialesToolStripMenuItem.Name = "ListarMaterialesToolStripMenuItem"
        Me.ListarMaterialesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListarMaterialesToolStripMenuItem.Text = "Listar Materiales"
        '
        'EliminarMaterialToolStripMenuItem
        '
        Me.EliminarMaterialToolStripMenuItem.Name = "EliminarMaterialToolStripMenuItem"
        Me.EliminarMaterialToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EliminarMaterialToolStripMenuItem.Text = "Eliminar Material"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(812, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
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
        'VentanaCrearMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 551)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupBoxCampos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaCrearMaterial"
        Me.Text = "VentanaCrearMaterial"
        Me.grupBoxCampos.ResumeLayout(False)
        Me.grupBoxCampos.PerformLayout()
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupBoxCampos As GroupBox
    Friend WithEvents labelNumeroRegistro As Label
    Friend WithEvents labelCategoria As Label
    Friend WithEvents comboBoxCategoria As ComboBox
    Friend WithEvents textBoxMaterial As TextBox
    Friend WithEvents labelMaterial As Label
    Friend WithEvents textBoxRegistro As TextBox
    Friend WithEvents labelSubCategoria As Label
    Friend WithEvents comboBoxSubCategoria As ComboBox
    Friend WithEvents labelImporteCompra As Label
    Friend WithEvents labelFechaRegistro As Label
    Friend WithEvents tiempoFechaRegistro As DateTimePicker
    Friend WithEvents textBoxVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxCompra As TextBox
    Friend WithEvents comboBoxPasillo As ComboBox
    Friend WithEvents labelPasillo As Label
    Friend WithEvents groupBoxSeccion As GroupBox
    Friend WithEvents radioButtonC As RadioButton
    Friend WithEvents radioButtonB As RadioButton
    Friend WithEvents radioButtonA As RadioButton
    Friend WithEvents labelStock As Label
    Friend WithEvents textBoxStock As TextBox
    Friend WithEvents radioButtonF As RadioButton
    Friend WithEvents radioButtonE As RadioButton
    Friend WithEvents radioButtonD As RadioButton
    Friend WithEvents textBoxDescripcion As TextBox
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
