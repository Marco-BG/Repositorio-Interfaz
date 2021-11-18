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
        Me.tlb_deslizador = New System.Windows.Forms.TrackBar()
        Me.comboFuentes = New System.Windows.Forms.ComboBox()
        Me.lbl_saludo = New System.Windows.Forms.Label()
        Me.grupoColores = New System.Windows.Forms.GroupBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cambiarColores = New System.Windows.Forms.Button()
        Me.radioColorFuente = New System.Windows.Forms.RadioButton()
        Me.radioCambiarFondo = New System.Windows.Forms.RadioButton()
        Me.grupoOpciones = New System.Windows.Forms.GroupBox()
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoColores.SuspendLayout()
        Me.grupoOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlb_deslizador
        '
        Me.tlb_deslizador.Location = New System.Drawing.Point(12, 66)
        Me.tlb_deslizador.Maximum = 50
        Me.tlb_deslizador.Minimum = 1
        Me.tlb_deslizador.Name = "tlb_deslizador"
        Me.tlb_deslizador.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tlb_deslizador.Size = New System.Drawing.Size(45, 289)
        Me.tlb_deslizador.TabIndex = 0
        Me.tlb_deslizador.Value = 1
        '
        'comboFuentes
        '
        Me.comboFuentes.FormattingEnabled = True
        Me.comboFuentes.Location = New System.Drawing.Point(119, 354)
        Me.comboFuentes.Name = "comboFuentes"
        Me.comboFuentes.Size = New System.Drawing.Size(207, 21)
        Me.comboFuentes.TabIndex = 1
        '
        'lbl_saludo
        '
        Me.lbl_saludo.AutoSize = True
        Me.lbl_saludo.Location = New System.Drawing.Point(160, 196)
        Me.lbl_saludo.Name = "lbl_saludo"
        Me.lbl_saludo.Size = New System.Drawing.Size(29, 13)
        Me.lbl_saludo.TabIndex = 2
        Me.lbl_saludo.Text = "Hola"
        '
        'grupoColores
        '
        Me.grupoColores.Controls.Add(Me.Panel8)
        Me.grupoColores.Controls.Add(Me.Panel7)
        Me.grupoColores.Controls.Add(Me.Panel6)
        Me.grupoColores.Controls.Add(Me.Panel5)
        Me.grupoColores.Controls.Add(Me.Panel4)
        Me.grupoColores.Controls.Add(Me.Panel3)
        Me.grupoColores.Controls.Add(Me.Panel2)
        Me.grupoColores.Controls.Add(Me.Panel1)
        Me.grupoColores.Location = New System.Drawing.Point(414, 160)
        Me.grupoColores.Name = "grupoColores"
        Me.grupoColores.Size = New System.Drawing.Size(283, 265)
        Me.grupoColores.TabIndex = 3
        Me.grupoColores.TabStop = False
        Me.grupoColores.Text = "Colores"
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(215, 97)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(41, 36)
        Me.Panel8.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(151, 97)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(41, 36)
        Me.Panel7.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(87, 97)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(41, 36)
        Me.Panel6.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(28, 97)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(41, 36)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(215, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(41, 36)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(151, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(41, 36)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(87, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(41, 36)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(28, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(41, 36)
        Me.Panel1.TabIndex = 0
        '
        'btn_cambiarColores
        '
        Me.btn_cambiarColores.Location = New System.Drawing.Point(414, 12)
        Me.btn_cambiarColores.Name = "btn_cambiarColores"
        Me.btn_cambiarColores.Size = New System.Drawing.Size(158, 26)
        Me.btn_cambiarColores.TabIndex = 4
        Me.btn_cambiarColores.Text = "Cambiar Colores"
        Me.btn_cambiarColores.UseVisualStyleBackColor = True
        '
        'radioColorFuente
        '
        Me.radioColorFuente.AutoSize = True
        Me.radioColorFuente.Checked = True
        Me.radioColorFuente.Location = New System.Drawing.Point(6, 19)
        Me.radioColorFuente.Name = "radioColorFuente"
        Me.radioColorFuente.Size = New System.Drawing.Size(126, 17)
        Me.radioColorFuente.TabIndex = 5
        Me.radioColorFuente.TabStop = True
        Me.radioColorFuente.Text = "Cambiar Color Fuente"
        Me.radioColorFuente.UseVisualStyleBackColor = True
        '
        'radioCambiarFondo
        '
        Me.radioCambiarFondo.AutoSize = True
        Me.radioCambiarFondo.Location = New System.Drawing.Point(6, 43)
        Me.radioCambiarFondo.Name = "radioCambiarFondo"
        Me.radioCambiarFondo.Size = New System.Drawing.Size(96, 17)
        Me.radioCambiarFondo.TabIndex = 6
        Me.radioCambiarFondo.Text = "Cambiar Fondo"
        Me.radioCambiarFondo.UseVisualStyleBackColor = True
        '
        'grupoOpciones
        '
        Me.grupoOpciones.Controls.Add(Me.radioColorFuente)
        Me.grupoOpciones.Controls.Add(Me.radioCambiarFondo)
        Me.grupoOpciones.Location = New System.Drawing.Point(593, 12)
        Me.grupoOpciones.Name = "grupoOpciones"
        Me.grupoOpciones.Size = New System.Drawing.Size(157, 88)
        Me.grupoOpciones.TabIndex = 7
        Me.grupoOpciones.TabStop = False
        Me.grupoOpciones.Text = "Opciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grupoOpciones)
        Me.Controls.Add(Me.btn_cambiarColores)
        Me.Controls.Add(Me.grupoColores)
        Me.Controls.Add(Me.lbl_saludo)
        Me.Controls.Add(Me.comboFuentes)
        Me.Controls.Add(Me.tlb_deslizador)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoColores.ResumeLayout(False)
        Me.grupoOpciones.ResumeLayout(False)
        Me.grupoOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlb_deslizador As TrackBar
    Friend WithEvents comboFuentes As ComboBox
    Friend WithEvents lbl_saludo As Label
    Friend WithEvents grupoColores As GroupBox
    Friend WithEvents btn_cambiarColores As Button
    Friend WithEvents radioColorFuente As RadioButton
    Friend WithEvents radioCambiarFondo As RadioButton
    Friend WithEvents grupoOpciones As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
