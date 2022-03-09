<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaListarMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaListarMateriales))
        Me.labelNumeroMaterial = New System.Windows.Forms.Label()
        Me.textBoxNumero = New System.Windows.Forms.TextBox()
        Me.buttonListar = New System.Windows.Forms.Button()
        Me.labelCategoria = New System.Windows.Forms.Label()
        Me.labelSubCategoria = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelPasillo = New System.Windows.Forms.Label()
        Me.gridViewMateriales = New System.Windows.Forms.DataGridView()
        Me.DBMaterialesDataSet = New ProyectoFinal.DBMaterialesDataSet()
        Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.comboBoxSubCategoria = New System.Windows.Forms.ComboBox()
        Me.comboBoxPasillo = New System.Windows.Forms.ComboBox()
        Me.groupBoxSeccion = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.labelListarMateriales = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.gridViewMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBMaterialesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxSeccion.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelNumeroMaterial
        '
        Me.labelNumeroMaterial.AutoSize = True
        Me.labelNumeroMaterial.Location = New System.Drawing.Point(23, 158)
        Me.labelNumeroMaterial.Name = "labelNumeroMaterial"
        Me.labelNumeroMaterial.Size = New System.Drawing.Size(103, 13)
        Me.labelNumeroMaterial.TabIndex = 4
        Me.labelNumeroMaterial.Text = "Número Material:"
        '
        'textBoxNumero
        '
        Me.textBoxNumero.Location = New System.Drawing.Point(126, 155)
        Me.textBoxNumero.Name = "textBoxNumero"
        Me.textBoxNumero.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNumero.TabIndex = 5
        '
        'buttonListar
        '
        Me.buttonListar.Location = New System.Drawing.Point(251, 153)
        Me.buttonListar.Name = "buttonListar"
        Me.buttonListar.Size = New System.Drawing.Size(75, 23)
        Me.buttonListar.TabIndex = 6
        Me.buttonListar.Text = "Listar"
        Me.buttonListar.UseVisualStyleBackColor = True
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(26, 194)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(67, 13)
        Me.labelCategoria.TabIndex = 9
        Me.labelCategoria.Text = "Categoría:"
        '
        'labelSubCategoria
        '
        Me.labelSubCategoria.AutoSize = True
        Me.labelSubCategoria.Location = New System.Drawing.Point(26, 240)
        Me.labelSubCategoria.Name = "labelSubCategoria"
        Me.labelSubCategoria.Size = New System.Drawing.Size(85, 13)
        Me.labelSubCategoria.TabIndex = 11
        Me.labelSubCategoria.Text = "Subcategoria:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(126, 270)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(30, 270)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(43, 13)
        Me.labelFecha.TabIndex = 16
        Me.labelFecha.Text = "Fecha:"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(26, 303)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(55, 13)
        Me.labelPasillo.TabIndex = 17
        Me.labelPasillo.Text = "Pasillo:"
        '
        'gridViewMateriales
        '
        Me.gridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewMateriales.Location = New System.Drawing.Point(414, 153)
        Me.gridViewMateriales.Name = "gridViewMateriales"
        Me.gridViewMateriales.Size = New System.Drawing.Size(730, 326)
        Me.gridViewMateriales.TabIndex = 18
        '
        'DBMaterialesDataSet
        '
        Me.DBMaterialesDataSet.DataSetName = "DBMaterialesDataSet"
        Me.DBMaterialesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.Items.AddRange(New Object() {"", "Hardware", "Software"})
        Me.comboBoxCategoria.Location = New System.Drawing.Point(126, 191)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxCategoria.TabIndex = 19
        '
        'comboBoxSubCategoria
        '
        Me.comboBoxSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSubCategoria.FormattingEnabled = True
        Me.comboBoxSubCategoria.Items.AddRange(New Object() {"", "Equipo", "Periférico", "Antivirus", "Servicio"})
        Me.comboBoxSubCategoria.Location = New System.Drawing.Point(126, 232)
        Me.comboBoxSubCategoria.Name = "comboBoxSubCategoria"
        Me.comboBoxSubCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxSubCategoria.TabIndex = 20
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.comboBoxPasillo.Location = New System.Drawing.Point(126, 303)
        Me.comboBoxPasillo.Name = "comboBoxPasillo"
        Me.comboBoxPasillo.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxPasillo.TabIndex = 21
        '
        'groupBoxSeccion
        '
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton6)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton5)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton4)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton3)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton2)
        Me.groupBoxSeccion.Controls.Add(Me.RadioButton1)
        Me.groupBoxSeccion.Location = New System.Drawing.Point(26, 352)
        Me.groupBoxSeccion.Name = "groupBoxSeccion"
        Me.groupBoxSeccion.Size = New System.Drawing.Size(238, 100)
        Me.groupBoxSeccion.TabIndex = 22
        Me.groupBoxSeccion.TabStop = False
        Me.groupBoxSeccion.Text = "Sección"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(126, 68)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "F"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(126, 44)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "E"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(126, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "D"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "C"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "B"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "A"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CrearMaterialToolStripMenuItem, Me.ModificarMaterialToolStripMenuItem, Me.EliminarMaterialToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.ToolStrip1.TabIndex = 24
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
        'labelListarMateriales
        '
        Me.labelListarMateriales.AutoSize = True
        Me.labelListarMateriales.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelListarMateriales.Location = New System.Drawing.Point(470, 63)
        Me.labelListarMateriales.Name = "labelListarMateriales"
        Me.labelListarMateriales.Size = New System.Drawing.Size(323, 37)
        Me.labelListarMateriales.TabIndex = 25
        Me.labelListarMateriales.Text = "Listar Materiales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 86)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'VentanaListarMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 557)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelListarMateriales)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.groupBoxSeccion)
        Me.Controls.Add(Me.comboBoxPasillo)
        Me.Controls.Add(Me.comboBoxSubCategoria)
        Me.Controls.Add(Me.comboBoxCategoria)
        Me.Controls.Add(Me.gridViewMateriales)
        Me.Controls.Add(Me.labelPasillo)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.labelSubCategoria)
        Me.Controls.Add(Me.labelCategoria)
        Me.Controls.Add(Me.buttonListar)
        Me.Controls.Add(Me.textBoxNumero)
        Me.Controls.Add(Me.labelNumeroMaterial)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaListarMateriales"
        Me.Text = "VentanaListarMateriales"
        CType(Me.gridViewMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBMaterialesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelNumeroMaterial As Label
    Friend WithEvents textBoxNumero As TextBox
    Friend WithEvents buttonListar As Button
    Friend WithEvents labelCategoria As Label
    Friend WithEvents labelSubCategoria As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelPasillo As Label
    Friend WithEvents gridViewMateriales As DataGridView
    Friend WithEvents DBMaterialesDataSet As DBMaterialesDataSet
    Friend WithEvents comboBoxCategoria As ComboBox
    Friend WithEvents comboBoxSubCategoria As ComboBox
    Friend WithEvents comboBoxPasillo As ComboBox
    Friend WithEvents groupBoxSeccion As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents labelListarMateriales As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
