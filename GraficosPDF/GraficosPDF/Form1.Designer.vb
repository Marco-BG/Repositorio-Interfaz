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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.miRejilla = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoríaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPorUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelNuevoPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuspendidoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NeptunoDataSet = New GraficosPDF.NeptunoDataSet()
        Me.btnTodas = New System.Windows.Forms.Button()
        Me.textBoxProducto = New System.Windows.Forms.TextBox()
        Me.miBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNombreProducto = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.NeptunoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New GraficosPDF.NeptunoDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New GraficosPDF.NeptunoDataSetTableAdapters.TableAdapterManager()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        CType(Me.miRejilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.miBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.miBindingNavigator.SuspendLayout()
        CType(Me.NeptunoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'miRejilla
        '
        Me.miRejilla.AllowUserToAddRows = False
        Me.miRejilla.AutoGenerateColumns = False
        Me.miRejilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.miRejilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.IdCategoríaDataGridViewTextBoxColumn, Me.CantidadPorUnidadDataGridViewTextBoxColumn, Me.PrecioUnidadDataGridViewTextBoxColumn, Me.UnidadesEnExistenciaDataGridViewTextBoxColumn, Me.UnidadesEnPedidoDataGridViewTextBoxColumn, Me.NivelNuevoPedidoDataGridViewTextBoxColumn, Me.SuspendidoDataGridViewCheckBoxColumn})
        Me.miRejilla.DataSource = Me.ProductosBindingSource
        Me.miRejilla.Location = New System.Drawing.Point(75, 88)
        Me.miRejilla.Name = "miRejilla"
        Me.miRejilla.Size = New System.Drawing.Size(601, 311)
        Me.miRejilla.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        '
        'IdCategoríaDataGridViewTextBoxColumn
        '
        Me.IdCategoríaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoría"
        Me.IdCategoríaDataGridViewTextBoxColumn.HeaderText = "IdCategoría"
        Me.IdCategoríaDataGridViewTextBoxColumn.Name = "IdCategoríaDataGridViewTextBoxColumn"
        '
        'CantidadPorUnidadDataGridViewTextBoxColumn
        '
        Me.CantidadPorUnidadDataGridViewTextBoxColumn.DataPropertyName = "CantidadPorUnidad"
        Me.CantidadPorUnidadDataGridViewTextBoxColumn.HeaderText = "CantidadPorUnidad"
        Me.CantidadPorUnidadDataGridViewTextBoxColumn.Name = "CantidadPorUnidadDataGridViewTextBoxColumn"
        '
        'PrecioUnidadDataGridViewTextBoxColumn
        '
        Me.PrecioUnidadDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.HeaderText = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.Name = "PrecioUnidadDataGridViewTextBoxColumn"
        '
        'UnidadesEnExistenciaDataGridViewTextBoxColumn
        '
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.DataPropertyName = "UnidadesEnExistencia"
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.HeaderText = "UnidadesEnExistencia"
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.Name = "UnidadesEnExistenciaDataGridViewTextBoxColumn"
        '
        'UnidadesEnPedidoDataGridViewTextBoxColumn
        '
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.DataPropertyName = "UnidadesEnPedido"
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.HeaderText = "UnidadesEnPedido"
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.Name = "UnidadesEnPedidoDataGridViewTextBoxColumn"
        '
        'NivelNuevoPedidoDataGridViewTextBoxColumn
        '
        Me.NivelNuevoPedidoDataGridViewTextBoxColumn.DataPropertyName = "NivelNuevoPedido"
        Me.NivelNuevoPedidoDataGridViewTextBoxColumn.HeaderText = "NivelNuevoPedido"
        Me.NivelNuevoPedidoDataGridViewTextBoxColumn.Name = "NivelNuevoPedidoDataGridViewTextBoxColumn"
        '
        'SuspendidoDataGridViewCheckBoxColumn
        '
        Me.SuspendidoDataGridViewCheckBoxColumn.DataPropertyName = "Suspendido"
        Me.SuspendidoDataGridViewCheckBoxColumn.HeaderText = "Suspendido"
        Me.SuspendidoDataGridViewCheckBoxColumn.Name = "SuspendidoDataGridViewCheckBoxColumn"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.NeptunoDataSet
        '
        'NeptunoDataSet
        '
        Me.NeptunoDataSet.DataSetName = "NeptunoDataSet"
        Me.NeptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnTodas
        '
        Me.btnTodas.Location = New System.Drawing.Point(331, 59)
        Me.btnTodas.Name = "btnTodas"
        Me.btnTodas.Size = New System.Drawing.Size(75, 23)
        Me.btnTodas.TabIndex = 1
        Me.btnTodas.Text = "Todas"
        Me.btnTodas.UseVisualStyleBackColor = True
        '
        'textBoxProducto
        '
        Me.textBoxProducto.Location = New System.Drawing.Point(75, 59)
        Me.textBoxProducto.Name = "textBoxProducto"
        Me.textBoxProducto.Size = New System.Drawing.Size(235, 20)
        Me.textBoxProducto.TabIndex = 2
        '
        'miBindingNavigator
        '
        Me.miBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.miBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.miBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.miBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.miBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.miBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.miBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.miBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.miBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.miBindingNavigator.Name = "miBindingNavigator"
        Me.miBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.miBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.miBindingNavigator.TabIndex = 3
        Me.miBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnNombreProducto
        '
        Me.btnNombreProducto.Location = New System.Drawing.Point(498, 59)
        Me.btnNombreProducto.Name = "btnNombreProducto"
        Me.btnNombreProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnNombreProducto.TabIndex = 5
        Me.btnNombreProducto.Text = "Nombre"
        Me.btnNombreProducto.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(331, 28)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 6
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(498, 28)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 7
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'NeptunoDataSetBindingSource
        '
        Me.NeptunoDataSetBindingSource.DataSource = Me.NeptunoDataSet
        Me.NeptunoDataSetBindingSource.Position = 0
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Compañías_de_envíosTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_de_pedidosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GraficosPDF.NeptunoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(589, 28)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimo.TabIndex = 8
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(250, 28)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.btnPrimero.TabIndex = 9
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(589, 56)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(75, 23)
        Me.btnPDF.TabIndex = 10
        Me.btnPDF.Text = "Imprimir PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnNombreProducto)
        Me.Controls.Add(Me.miBindingNavigator)
        Me.Controls.Add(Me.textBoxProducto)
        Me.Controls.Add(Me.btnTodas)
        Me.Controls.Add(Me.miRejilla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.miRejilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeptunoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.miBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.miBindingNavigator.ResumeLayout(False)
        Me.miBindingNavigator.PerformLayout()
        CType(Me.NeptunoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents miRejilla As DataGridView
    Friend WithEvents NeptunoDataSetBindingSource As BindingSource
    Friend WithEvents NeptunoDataSet As NeptunoDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As NeptunoDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As NeptunoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnTodas As Button
    Friend WithEvents textBoxProducto As TextBox
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoríaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPorUnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadesEnExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadesEnPedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NivelNuevoPedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuspendidoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents miBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents btnNombreProducto As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnPDF As Button
End Class
