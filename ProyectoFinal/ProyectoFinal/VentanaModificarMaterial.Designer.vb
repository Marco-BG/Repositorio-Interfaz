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
        Me.buttonRegresar = New System.Windows.Forms.Button()
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
        Me.buttonGuardar = New System.Windows.Forms.Button()
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
        Me.labelNumeroMaterial.Location = New System.Drawing.Point(37, 68)
        Me.labelNumeroMaterial.Name = "labelNumeroMaterial"
        Me.labelNumeroMaterial.Size = New System.Drawing.Size(102, 13)
        Me.labelNumeroMaterial.TabIndex = 1
        Me.labelNumeroMaterial.Text = "Número de Material:"
        '
        'textBoxRegistro
        '
        Me.textBoxRegistro.Location = New System.Drawing.Point(157, 68)
        Me.textBoxRegistro.Name = "textBoxRegistro"
        Me.textBoxRegistro.Size = New System.Drawing.Size(100, 20)
        Me.textBoxRegistro.TabIndex = 2
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(389, 90)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.buttonBuscar.TabIndex = 3
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'labelMaterial
        '
        Me.labelMaterial.AutoSize = True
        Me.labelMaterial.Location = New System.Drawing.Point(37, 100)
        Me.labelMaterial.Name = "labelMaterial"
        Me.labelMaterial.Size = New System.Drawing.Size(47, 13)
        Me.labelMaterial.TabIndex = 4
        Me.labelMaterial.Text = "Material:"
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(37, 131)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(57, 13)
        Me.labelCategoria.TabIndex = 5
        Me.labelCategoria.Text = "Categoría:"
        '
        'labelSubcategoria
        '
        Me.labelSubcategoria.AutoSize = True
        Me.labelSubcategoria.Location = New System.Drawing.Point(37, 162)
        Me.labelSubcategoria.Name = "labelSubcategoria"
        Me.labelSubcategoria.Size = New System.Drawing.Size(75, 13)
        Me.labelSubcategoria.TabIndex = 6
        Me.labelSubcategoria.Text = "Subcategoría:"
        '
        'labelFechaRegistro
        '
        Me.labelFechaRegistro.AutoSize = True
        Me.labelFechaRegistro.Location = New System.Drawing.Point(37, 193)
        Me.labelFechaRegistro.Name = "labelFechaRegistro"
        Me.labelFechaRegistro.Size = New System.Drawing.Size(82, 13)
        Me.labelFechaRegistro.TabIndex = 7
        Me.labelFechaRegistro.Text = "Fecha Registro:"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(37, 226)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.labelDescripcion.TabIndex = 8
        Me.labelDescripcion.Text = "Descripción:"
        '
        'labelImporteCompra
        '
        Me.labelImporteCompra.AutoSize = True
        Me.labelImporteCompra.Location = New System.Drawing.Point(37, 260)
        Me.labelImporteCompra.Name = "labelImporteCompra"
        Me.labelImporteCompra.Size = New System.Drawing.Size(99, 13)
        Me.labelImporteCompra.TabIndex = 9
        Me.labelImporteCompra.Text = "Importe de Compra:"
        '
        'labelImporteVenta
        '
        Me.labelImporteVenta.AutoSize = True
        Me.labelImporteVenta.Location = New System.Drawing.Point(37, 293)
        Me.labelImporteVenta.Name = "labelImporteVenta"
        Me.labelImporteVenta.Size = New System.Drawing.Size(91, 13)
        Me.labelImporteVenta.TabIndex = 10
        Me.labelImporteVenta.Text = "Importe de Venta:"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(37, 325)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(40, 13)
        Me.labelPasillo.TabIndex = 11
        Me.labelPasillo.Text = "Pasillo:"
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Location = New System.Drawing.Point(296, 328)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(38, 13)
        Me.labelStock.TabIndex = 13
        Me.labelStock.Text = "Stock:"
        '
        'textBoxMaterial
        '
        Me.textBoxMaterial.Location = New System.Drawing.Point(157, 100)
        Me.textBoxMaterial.Name = "textBoxMaterial"
        Me.textBoxMaterial.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMaterial.TabIndex = 14
        '
        'textBoxDescripcion
        '
        Me.textBoxDescripcion.Location = New System.Drawing.Point(157, 226)
        Me.textBoxDescripcion.Name = "textBoxDescripcion"
        Me.textBoxDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.textBoxDescripcion.TabIndex = 18
        '
        'textBoxCompra
        '
        Me.textBoxCompra.Location = New System.Drawing.Point(157, 260)
        Me.textBoxCompra.Name = "textBoxCompra"
        Me.textBoxCompra.Size = New System.Drawing.Size(100, 20)
        Me.textBoxCompra.TabIndex = 19
        '
        'textBoxVenta
        '
        Me.textBoxVenta.Location = New System.Drawing.Point(157, 293)
        Me.textBoxVenta.Name = "textBoxVenta"
        Me.textBoxVenta.Size = New System.Drawing.Size(100, 20)
        Me.textBoxVenta.TabIndex = 20
        '
        'textBoxStock
        '
        Me.textBoxStock.Location = New System.Drawing.Point(340, 326)
        Me.textBoxStock.Name = "textBoxStock"
        Me.textBoxStock.Size = New System.Drawing.Size(100, 20)
        Me.textBoxStock.TabIndex = 23
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Location = New System.Drawing.Point(267, 415)
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.buttonGuardar.TabIndex = 24
        Me.buttonGuardar.Text = "Guardar"
        Me.buttonGuardar.UseVisualStyleBackColor = True
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.Location = New System.Drawing.Point(157, 131)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxCategoria.TabIndex = 25
        '
        'comboBoxSubCategoria
        '
        Me.comboBoxSubCategoria.FormattingEnabled = True
        Me.comboBoxSubCategoria.Location = New System.Drawing.Point(157, 162)
        Me.comboBoxSubCategoria.Name = "comboBoxSubCategoria"
        Me.comboBoxSubCategoria.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxSubCategoria.TabIndex = 26
        '
        'fechaRegistro
        '
        Me.fechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaRegistro.Location = New System.Drawing.Point(157, 193)
        Me.fechaRegistro.Name = "fechaRegistro"
        Me.fechaRegistro.Size = New System.Drawing.Size(100, 20)
        Me.fechaRegistro.TabIndex = 27
        Me.fechaRegistro.Value = New Date(2022, 2, 26, 0, 0, 0, 0)
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Location = New System.Drawing.Point(157, 325)
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
        Me.groupBoxSeccion.Location = New System.Drawing.Point(299, 209)
        Me.groupBoxSeccion.Name = "groupBoxSeccion"
        Me.groupBoxSeccion.Size = New System.Drawing.Size(88, 97)
        Me.groupBoxSeccion.TabIndex = 29
        Me.groupBoxSeccion.TabStop = False
        Me.groupBoxSeccion.Text = "Sección"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(45, 67)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "F"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(45, 44)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "E"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(45, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(33, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "D"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 67)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "C"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "B"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "A"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'VentanaModificarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.groupBoxSeccion)
        Me.Controls.Add(Me.comboBoxPasillo)
        Me.Controls.Add(Me.fechaRegistro)
        Me.Controls.Add(Me.comboBoxSubCategoria)
        Me.Controls.Add(Me.comboBoxCategoria)
        Me.Controls.Add(Me.buttonGuardar)
        Me.Controls.Add(Me.textBoxStock)
        Me.Controls.Add(Me.textBoxVenta)
        Me.Controls.Add(Me.textBoxCompra)
        Me.Controls.Add(Me.textBoxDescripcion)
        Me.Controls.Add(Me.textBoxMaterial)
        Me.Controls.Add(Me.labelStock)
        Me.Controls.Add(Me.labelPasillo)
        Me.Controls.Add(Me.labelImporteVenta)
        Me.Controls.Add(Me.labelImporteCompra)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Controls.Add(Me.labelFechaRegistro)
        Me.Controls.Add(Me.labelSubcategoria)
        Me.Controls.Add(Me.labelCategoria)
        Me.Controls.Add(Me.labelMaterial)
        Me.Controls.Add(Me.buttonBuscar)
        Me.Controls.Add(Me.textBoxRegistro)
        Me.Controls.Add(Me.labelNumeroMaterial)
        Me.Controls.Add(Me.buttonRegresar)
        Me.Name = "VentanaModificarMaterial"
        Me.Text = "VentanaModificarMaterial"
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonRegresar As Button
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
    Friend WithEvents buttonGuardar As Button
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
End Class
