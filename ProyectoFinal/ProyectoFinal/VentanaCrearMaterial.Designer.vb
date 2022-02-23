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
        Me.buttonRegresar = New System.Windows.Forms.Button()
        Me.grupBoxCampos = New System.Windows.Forms.GroupBox()
        Me.comboBoxPasillo = New System.Windows.Forms.ComboBox()
        Me.labelPasillo = New System.Windows.Forms.Label()
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
        Me.groupBoxSeccion = New System.Windows.Forms.GroupBox()
        Me.radioButtonC = New System.Windows.Forms.RadioButton()
        Me.radioButtonB = New System.Windows.Forms.RadioButton()
        Me.radioButtonA = New System.Windows.Forms.RadioButton()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.textBoxStock = New System.Windows.Forms.TextBox()
        Me.radioButtonD = New System.Windows.Forms.RadioButton()
        Me.radioButtonE = New System.Windows.Forms.RadioButton()
        Me.radioButtonF = New System.Windows.Forms.RadioButton()
        Me.buttonInsertar = New System.Windows.Forms.Button()
        Me.textBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.grupBoxCampos.SuspendLayout()
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
        'grupBoxCampos
        '
        Me.grupBoxCampos.Controls.Add(Me.labelDescripcion)
        Me.grupBoxCampos.Controls.Add(Me.textBoxDescripcion)
        Me.grupBoxCampos.Controls.Add(Me.comboBoxPasillo)
        Me.grupBoxCampos.Controls.Add(Me.labelPasillo)
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
        Me.grupBoxCampos.Location = New System.Drawing.Point(34, 87)
        Me.grupBoxCampos.Name = "grupBoxCampos"
        Me.grupBoxCampos.Size = New System.Drawing.Size(275, 351)
        Me.grupBoxCampos.TabIndex = 1
        Me.grupBoxCampos.TabStop = False
        Me.grupBoxCampos.Text = "Material"
        '
        'comboBoxPasillo
        '
        Me.comboBoxPasillo.FormattingEnabled = True
        Me.comboBoxPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.comboBoxPasillo.Location = New System.Drawing.Point(111, 323)
        Me.comboBoxPasillo.Name = "comboBoxPasillo"
        Me.comboBoxPasillo.Size = New System.Drawing.Size(106, 21)
        Me.comboBoxPasillo.TabIndex = 16
        Me.comboBoxPasillo.Text = "1"
        '
        'labelPasillo
        '
        Me.labelPasillo.AutoSize = True
        Me.labelPasillo.Location = New System.Drawing.Point(6, 332)
        Me.labelPasillo.Name = "labelPasillo"
        Me.labelPasillo.Size = New System.Drawing.Size(40, 13)
        Me.labelPasillo.TabIndex = 15
        Me.labelPasillo.Text = "Pasillo:"
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
        Me.Label1.Size = New System.Drawing.Size(91, 13)
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
        Me.labelFechaRegistro.Size = New System.Drawing.Size(97, 13)
        Me.labelFechaRegistro.TabIndex = 10
        Me.labelFechaRegistro.Text = "Fecha de Registro:"
        '
        'labelImporteCompra
        '
        Me.labelImporteCompra.AutoSize = True
        Me.labelImporteCompra.Location = New System.Drawing.Point(6, 266)
        Me.labelImporteCompra.Name = "labelImporteCompra"
        Me.labelImporteCompra.Size = New System.Drawing.Size(99, 13)
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
        Me.labelSubCategoria.Size = New System.Drawing.Size(74, 13)
        Me.labelSubCategoria.TabIndex = 6
        Me.labelSubCategoria.Text = "SubCategoria:"
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(6, 104)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(57, 13)
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
        Me.labelMaterial.Size = New System.Drawing.Size(47, 13)
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
        Me.labelNumeroRegistro.Size = New System.Drawing.Size(89, 13)
        Me.labelNumeroRegistro.TabIndex = 0
        Me.labelNumeroRegistro.Text = "Número Registro:"
        '
        'groupBoxSeccion
        '
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonF)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonE)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonD)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonC)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonB)
        Me.groupBoxSeccion.Controls.Add(Me.radioButtonA)
        Me.groupBoxSeccion.Location = New System.Drawing.Point(315, 156)
        Me.groupBoxSeccion.Name = "groupBoxSeccion"
        Me.groupBoxSeccion.Size = New System.Drawing.Size(222, 100)
        Me.groupBoxSeccion.TabIndex = 2
        Me.groupBoxSeccion.TabStop = False
        Me.groupBoxSeccion.Text = "Sección"
        '
        'radioButtonC
        '
        Me.radioButtonC.AutoSize = True
        Me.radioButtonC.Location = New System.Drawing.Point(7, 68)
        Me.radioButtonC.Name = "radioButtonC"
        Me.radioButtonC.Size = New System.Drawing.Size(32, 17)
        Me.radioButtonC.TabIndex = 2
        Me.radioButtonC.TabStop = True
        Me.radioButtonC.Text = "C"
        Me.radioButtonC.UseVisualStyleBackColor = True
        '
        'radioButtonB
        '
        Me.radioButtonB.AutoSize = True
        Me.radioButtonB.Location = New System.Drawing.Point(7, 44)
        Me.radioButtonB.Name = "radioButtonB"
        Me.radioButtonB.Size = New System.Drawing.Size(32, 17)
        Me.radioButtonB.TabIndex = 1
        Me.radioButtonB.TabStop = True
        Me.radioButtonB.Text = "B"
        Me.radioButtonB.UseVisualStyleBackColor = True
        '
        'radioButtonA
        '
        Me.radioButtonA.AutoSize = True
        Me.radioButtonA.Location = New System.Drawing.Point(7, 20)
        Me.radioButtonA.Name = "radioButtonA"
        Me.radioButtonA.Size = New System.Drawing.Size(32, 17)
        Me.radioButtonA.TabIndex = 0
        Me.radioButtonA.TabStop = True
        Me.radioButtonA.Text = "A"
        Me.radioButtonA.UseVisualStyleBackColor = True
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Location = New System.Drawing.Point(543, 199)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(38, 13)
        Me.labelStock.TabIndex = 3
        Me.labelStock.Text = "Stock:"
        '
        'textBoxStock
        '
        Me.textBoxStock.Location = New System.Drawing.Point(588, 199)
        Me.textBoxStock.Name = "textBoxStock"
        Me.textBoxStock.Size = New System.Drawing.Size(48, 20)
        Me.textBoxStock.TabIndex = 4
        '
        'radioButtonD
        '
        Me.radioButtonD.AutoSize = True
        Me.radioButtonD.Location = New System.Drawing.Point(104, 20)
        Me.radioButtonD.Name = "radioButtonD"
        Me.radioButtonD.Size = New System.Drawing.Size(33, 17)
        Me.radioButtonD.TabIndex = 3
        Me.radioButtonD.TabStop = True
        Me.radioButtonD.Text = "D"
        Me.radioButtonD.UseVisualStyleBackColor = True
        '
        'radioButtonE
        '
        Me.radioButtonE.AutoSize = True
        Me.radioButtonE.Location = New System.Drawing.Point(104, 45)
        Me.radioButtonE.Name = "radioButtonE"
        Me.radioButtonE.Size = New System.Drawing.Size(32, 17)
        Me.radioButtonE.TabIndex = 4
        Me.radioButtonE.TabStop = True
        Me.radioButtonE.Text = "E"
        Me.radioButtonE.UseVisualStyleBackColor = True
        '
        'radioButtonF
        '
        Me.radioButtonF.AutoSize = True
        Me.radioButtonF.Location = New System.Drawing.Point(104, 68)
        Me.radioButtonF.Name = "radioButtonF"
        Me.radioButtonF.Size = New System.Drawing.Size(31, 17)
        Me.radioButtonF.TabIndex = 5
        Me.radioButtonF.TabStop = True
        Me.radioButtonF.Text = "F"
        Me.radioButtonF.UseVisualStyleBackColor = True
        '
        'buttonInsertar
        '
        Me.buttonInsertar.Location = New System.Drawing.Point(419, 296)
        Me.buttonInsertar.Name = "buttonInsertar"
        Me.buttonInsertar.Size = New System.Drawing.Size(91, 23)
        Me.buttonInsertar.TabIndex = 5
        Me.buttonInsertar.Text = "Crear Material"
        Me.buttonInsertar.UseVisualStyleBackColor = True
        '
        'textBoxDescripcion
        '
        Me.textBoxDescripcion.Location = New System.Drawing.Point(112, 209)
        Me.textBoxDescripcion.Multiline = True
        Me.textBoxDescripcion.Name = "textBoxDescripcion"
        Me.textBoxDescripcion.Size = New System.Drawing.Size(148, 51)
        Me.textBoxDescripcion.TabIndex = 17
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(9, 225)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(39, 13)
        Me.labelDescripcion.TabIndex = 18
        Me.labelDescripcion.Text = "Label2"
        '
        'VentanaCrearMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonInsertar)
        Me.Controls.Add(Me.textBoxStock)
        Me.Controls.Add(Me.labelStock)
        Me.Controls.Add(Me.groupBoxSeccion)
        Me.Controls.Add(Me.grupBoxCampos)
        Me.Controls.Add(Me.buttonRegresar)
        Me.Name = "VentanaCrearMaterial"
        Me.Text = "VentanaCrearMaterial"
        Me.grupBoxCampos.ResumeLayout(False)
        Me.grupBoxCampos.PerformLayout()
        Me.groupBoxSeccion.ResumeLayout(False)
        Me.groupBoxSeccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonRegresar As Button
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
    Friend WithEvents buttonInsertar As Button
    Friend WithEvents textBoxDescripcion As TextBox
    Friend WithEvents labelDescripcion As Label
End Class
