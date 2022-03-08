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
        Me.buttonRegresar = New System.Windows.Forms.Button()
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
        CType(Me.gridViewMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBMaterialesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxSeccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonRegresar
        '
        Me.buttonRegresar.Location = New System.Drawing.Point(13, 13)
        Me.buttonRegresar.Name = "buttonRegresar"
        Me.buttonRegresar.Size = New System.Drawing.Size(75, 23)
        Me.buttonRegresar.TabIndex = 0
        Me.buttonRegresar.Text = "Regresar"
        Me.buttonRegresar.UseVisualStyleBackColor = True
        '
        'labelNumeroMaterial
        '
        Me.labelNumeroMaterial.AutoSize = True
        Me.labelNumeroMaterial.Location = New System.Drawing.Point(13, 76)
        Me.labelNumeroMaterial.Name = "labelNumeroMaterial"
        Me.labelNumeroMaterial.Size = New System.Drawing.Size(103, 13)
        Me.labelNumeroMaterial.TabIndex = 4
        Me.labelNumeroMaterial.Text = "Número Material:"
        '
        'textBoxNumero
        '
        Me.textBoxNumero.Location = New System.Drawing.Point(116, 73)
        Me.textBoxNumero.Name = "textBoxNumero"
        Me.textBoxNumero.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNumero.TabIndex = 5
        '
        'buttonListar
        '
        Me.buttonListar.Location = New System.Drawing.Point(255, 74)
        Me.buttonListar.Name = "buttonListar"
        Me.buttonListar.Size = New System.Drawing.Size(75, 23)
        Me.buttonListar.TabIndex = 6
        Me.buttonListar.Text = "Listar"
        Me.buttonListar.UseVisualStyleBackColor = True
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(16, 112)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(67, 13)
        Me.labelCategoria.TabIndex = 9
        Me.labelCategoria.Text = "Categoría:"
        '
        'labelSubCategoria
        '
        Me.labelSubCategoria.AutoSize = True
        Me.labelSubCategoria.Location = New System.Drawing.Point(16, 158)
        Me.labelSubCategoria.Name = "labelSubCategoria"
        Me.labelSubCategoria.Size = New System.Drawing.Size(85, 13)
        Me.labelSubCategoria.TabIndex = 11
        Me.labelSubCategoria.Text = "Subcategoria:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 188)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(20, 188)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(43, 13)
        Me.labelFecha.TabIndex = 16
        Me.labelFecha.Text = "Fecha:"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(16, 221)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(55, 13)
        Me.labelPasillo.TabIndex = 17
        Me.labelPasillo.Text = "Pasillo:"
        '
        'gridViewMateriales
        '
        Me.gridViewMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewMateriales.Location = New System.Drawing.Point(496, 76)
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
        Me.comboBoxCategoria.Location = New System.Drawing.Point(116, 109)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxCategoria.TabIndex = 19
        '
        'comboBoxSubCategoria
        '
        Me.comboBoxSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSubCategoria.FormattingEnabled = True
        Me.comboBoxSubCategoria.Items.AddRange(New Object() {"", "Equipo", "Periférico", "Antivirus", "Servicio"})
        Me.comboBoxSubCategoria.Location = New System.Drawing.Point(116, 150)
        Me.comboBoxSubCategoria.Name = "comboBoxSubCategoria"
        Me.comboBoxSubCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxSubCategoria.TabIndex = 20
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.comboBoxPasillo.Location = New System.Drawing.Point(116, 221)
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
        Me.groupBoxSeccion.Location = New System.Drawing.Point(16, 270)
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
        'VentanaListarMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 557)
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
        Me.Controls.Add(Me.buttonRegresar)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "VentanaListarMateriales"
        Me.Text = "VentanaListarMateriales"
        CType(Me.gridViewMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBMaterialesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonRegresar As Button
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
End Class
