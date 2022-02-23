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
        Me.myGroupBox = New System.Windows.Forms.GroupBox()
        Me.textBoxRegister = New System.Windows.Forms.TextBox()
        Me.labelNumRegister = New System.Windows.Forms.Label()
        Me.obligatoryName = New System.Windows.Forms.Label()
        Me.obligatoryDNI = New System.Windows.Forms.Label()
        Me.labelObligatoryName = New System.Windows.Forms.Label()
        Me.groupBoxPerfil = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.labelDateBirth = New System.Windows.Forms.Label()
        Me.labelAccessPeriod = New System.Windows.Forms.Label()
        Me.comboBoxPeriod = New System.Windows.Forms.ComboBox()
        Me.buttonSend = New System.Windows.Forms.Button()
        Me.textBoxDNI = New System.Windows.Forms.TextBox()
        Me.textBoxLastName = New System.Windows.Forms.TextBox()
        Me.textBoxName = New System.Windows.Forms.TextBox()
        Me.groupBoxDepartament = New System.Windows.Forms.GroupBox()
        Me.radioButtonLogic = New System.Windows.Forms.RadioButton()
        Me.radioButtonResource = New System.Windows.Forms.RadioButton()
        Me.radioButtonFinanzas = New System.Windows.Forms.RadioButton()
        Me.labelDNI = New System.Windows.Forms.Label()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.myGroupBox.SuspendLayout()
        Me.groupBoxPerfil.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxDepartament.SuspendLayout()
        Me.SuspendLayout()
        '
        'myGroupBox
        '
        Me.myGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.myGroupBox.Controls.Add(Me.textBoxRegister)
        Me.myGroupBox.Controls.Add(Me.obligatoryName)
        Me.myGroupBox.Controls.Add(Me.obligatoryDNI)
        Me.myGroupBox.Controls.Add(Me.labelNumRegister)
        Me.myGroupBox.Controls.Add(Me.labelObligatoryName)
        Me.myGroupBox.Controls.Add(Me.groupBoxPerfil)
        Me.myGroupBox.Controls.Add(Me.buttonSend)
        Me.myGroupBox.Controls.Add(Me.textBoxDNI)
        Me.myGroupBox.Controls.Add(Me.textBoxLastName)
        Me.myGroupBox.Controls.Add(Me.textBoxName)
        Me.myGroupBox.Controls.Add(Me.groupBoxDepartament)
        Me.myGroupBox.Controls.Add(Me.labelDNI)
        Me.myGroupBox.Controls.Add(Me.labelLastName)
        Me.myGroupBox.Controls.Add(Me.labelName)
        Me.myGroupBox.Location = New System.Drawing.Point(32, 63)
        Me.myGroupBox.Name = "myGroupBox"
        Me.myGroupBox.Size = New System.Drawing.Size(704, 352)
        Me.myGroupBox.TabIndex = 0
        Me.myGroupBox.TabStop = False
        Me.myGroupBox.Text = "Datos del Usuario"
        '
        'textBoxRegister
        '
        Me.textBoxRegister.BackColor = System.Drawing.Color.Khaki
        Me.textBoxRegister.Location = New System.Drawing.Point(98, 28)
        Me.textBoxRegister.Name = "textBoxRegister"
        Me.textBoxRegister.Size = New System.Drawing.Size(53, 20)
        Me.textBoxRegister.TabIndex = 18
        '
        'labelNumRegister
        '
        Me.labelNumRegister.AutoSize = True
        Me.labelNumRegister.Location = New System.Drawing.Point(6, 29)
        Me.labelNumRegister.Name = "labelNumRegister"
        Me.labelNumRegister.Size = New System.Drawing.Size(86, 13)
        Me.labelNumRegister.TabIndex = 17
        Me.labelNumRegister.Text = "Número Registro"
        '
        'obligatoryName
        '
        Me.obligatoryName.AutoSize = True
        Me.obligatoryName.Location = New System.Drawing.Point(176, 29)
        Me.obligatoryName.Name = "obligatoryName"
        Me.obligatoryName.Size = New System.Drawing.Size(0, 13)
        Me.obligatoryName.TabIndex = 16
        '
        'obligatoryDNI
        '
        Me.obligatoryDNI.AutoSize = True
        Me.obligatoryDNI.Location = New System.Drawing.Point(176, 90)
        Me.obligatoryDNI.Name = "obligatoryDNI"
        Me.obligatoryDNI.Size = New System.Drawing.Size(0, 13)
        Me.obligatoryDNI.TabIndex = 15
        '
        'labelObligatoryName
        '
        Me.labelObligatoryName.AutoSize = True
        Me.labelObligatoryName.Location = New System.Drawing.Point(176, 29)
        Me.labelObligatoryName.Name = "labelObligatoryName"
        Me.labelObligatoryName.Size = New System.Drawing.Size(0, 13)
        Me.labelObligatoryName.TabIndex = 13
        '
        'groupBoxPerfil
        '
        Me.groupBoxPerfil.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.groupBoxPerfil.Controls.Add(Me.PictureBox1)
        Me.groupBoxPerfil.Controls.Add(Me.dateTime)
        Me.groupBoxPerfil.Controls.Add(Me.labelDateBirth)
        Me.groupBoxPerfil.Controls.Add(Me.labelAccessPeriod)
        Me.groupBoxPerfil.Controls.Add(Me.comboBoxPeriod)
        Me.groupBoxPerfil.Location = New System.Drawing.Point(330, 10)
        Me.groupBoxPerfil.Name = "groupBoxPerfil"
        Me.groupBoxPerfil.Size = New System.Drawing.Size(355, 281)
        Me.groupBoxPerfil.TabIndex = 12
        Me.groupBoxPerfil.TabStop = False
        Me.groupBoxPerfil.Text = "Datos del perfil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 61)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dateTime
        '
        Me.dateTime.Location = New System.Drawing.Point(147, 105)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(189, 20)
        Me.dateTime.TabIndex = 10
        '
        'labelDateBirth
        '
        Me.labelDateBirth.AutoSize = True
        Me.labelDateBirth.Location = New System.Drawing.Point(6, 111)
        Me.labelDateBirth.Name = "labelDateBirth"
        Me.labelDateBirth.Size = New System.Drawing.Size(111, 13)
        Me.labelDateBirth.TabIndex = 3
        Me.labelDateBirth.Text = "Fecha de Nacimiento:"
        '
        'labelAccessPeriod
        '
        Me.labelAccessPeriod.AutoSize = True
        Me.labelAccessPeriod.Location = New System.Drawing.Point(6, 175)
        Me.labelAccessPeriod.Name = "labelAccessPeriod"
        Me.labelAccessPeriod.Size = New System.Drawing.Size(100, 13)
        Me.labelAccessPeriod.TabIndex = 5
        Me.labelAccessPeriod.Text = "Periodo de Acceso:"
        '
        'comboBoxPeriod
        '
        Me.comboBoxPeriod.FormattingEnabled = True
        Me.comboBoxPeriod.Items.AddRange(New Object() {"Matutino(08:00-14:00)", "Vespertino(14:00-22:00)", "Nocturno(22:00-8:00)"})
        Me.comboBoxPeriod.Location = New System.Drawing.Point(147, 172)
        Me.comboBoxPeriod.Name = "comboBoxPeriod"
        Me.comboBoxPeriod.Size = New System.Drawing.Size(189, 21)
        Me.comboBoxPeriod.TabIndex = 6
        '
        'buttonSend
        '
        Me.buttonSend.Location = New System.Drawing.Point(314, 325)
        Me.buttonSend.Name = "buttonSend"
        Me.buttonSend.Size = New System.Drawing.Size(75, 23)
        Me.buttonSend.TabIndex = 11
        Me.buttonSend.Text = "Enviar"
        Me.buttonSend.UseVisualStyleBackColor = True
        '
        'textBoxDNI
        '
        Me.textBoxDNI.BackColor = System.Drawing.Color.Khaki
        Me.textBoxDNI.Location = New System.Drawing.Point(98, 113)
        Me.textBoxDNI.Name = "textBoxDNI"
        Me.textBoxDNI.Size = New System.Drawing.Size(100, 20)
        Me.textBoxDNI.TabIndex = 9
        '
        'textBoxLastName
        '
        Me.textBoxLastName.BackColor = System.Drawing.Color.Khaki
        Me.textBoxLastName.Location = New System.Drawing.Point(98, 87)
        Me.textBoxLastName.Name = "textBoxLastName"
        Me.textBoxLastName.Size = New System.Drawing.Size(100, 20)
        Me.textBoxLastName.TabIndex = 8
        '
        'textBoxName
        '
        Me.textBoxName.BackColor = System.Drawing.Color.Khaki
        Me.textBoxName.Location = New System.Drawing.Point(98, 61)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(100, 20)
        Me.textBoxName.TabIndex = 7
        '
        'groupBoxDepartament
        '
        Me.groupBoxDepartament.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.groupBoxDepartament.Controls.Add(Me.radioButtonLogic)
        Me.groupBoxDepartament.Controls.Add(Me.radioButtonResource)
        Me.groupBoxDepartament.Controls.Add(Me.radioButtonFinanzas)
        Me.groupBoxDepartament.Location = New System.Drawing.Point(9, 151)
        Me.groupBoxDepartament.Name = "groupBoxDepartament"
        Me.groupBoxDepartament.Size = New System.Drawing.Size(200, 100)
        Me.groupBoxDepartament.TabIndex = 4
        Me.groupBoxDepartament.TabStop = False
        Me.groupBoxDepartament.Text = "Departamento Autorizador"
        '
        'radioButtonLogic
        '
        Me.radioButtonLogic.AutoSize = True
        Me.radioButtonLogic.Location = New System.Drawing.Point(7, 77)
        Me.radioButtonLogic.Name = "radioButtonLogic"
        Me.radioButtonLogic.Size = New System.Drawing.Size(69, 17)
        Me.radioButtonLogic.TabIndex = 2
        Me.radioButtonLogic.TabStop = True
        Me.radioButtonLogic.Text = "Logística"
        Me.radioButtonLogic.UseVisualStyleBackColor = True
        '
        'radioButtonResource
        '
        Me.radioButtonResource.AutoSize = True
        Me.radioButtonResource.Location = New System.Drawing.Point(7, 54)
        Me.radioButtonResource.Name = "radioButtonResource"
        Me.radioButtonResource.Size = New System.Drawing.Size(118, 17)
        Me.radioButtonResource.TabIndex = 1
        Me.radioButtonResource.TabStop = True
        Me.radioButtonResource.Text = "Recursos Humanos"
        Me.radioButtonResource.UseVisualStyleBackColor = True
        '
        'radioButtonFinanzas
        '
        Me.radioButtonFinanzas.AutoSize = True
        Me.radioButtonFinanzas.Checked = True
        Me.radioButtonFinanzas.Location = New System.Drawing.Point(7, 30)
        Me.radioButtonFinanzas.Name = "radioButtonFinanzas"
        Me.radioButtonFinanzas.Size = New System.Drawing.Size(67, 17)
        Me.radioButtonFinanzas.TabIndex = 0
        Me.radioButtonFinanzas.TabStop = True
        Me.radioButtonFinanzas.Text = "Finanzas"
        Me.radioButtonFinanzas.UseVisualStyleBackColor = True
        '
        'labelDNI
        '
        Me.labelDNI.AutoSize = True
        Me.labelDNI.Location = New System.Drawing.Point(7, 116)
        Me.labelDNI.Name = "labelDNI"
        Me.labelDNI.Size = New System.Drawing.Size(29, 13)
        Me.labelDNI.TabIndex = 2
        Me.labelDNI.Text = "DNI:"
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Location = New System.Drawing.Point(7, 90)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(47, 13)
        Me.labelLastName.TabIndex = 1
        Me.labelLastName.Text = "Apellido:"
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(7, 61)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(47, 13)
        Me.labelName.TabIndex = 0
        Me.labelName.Text = "Nombre:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.myGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.myGroupBox.ResumeLayout(False)
        Me.myGroupBox.PerformLayout()
        Me.groupBoxPerfil.ResumeLayout(False)
        Me.groupBoxPerfil.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxDepartament.ResumeLayout(False)
        Me.groupBoxDepartament.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myGroupBox As GroupBox
    Friend WithEvents labelDateBirth As Label
    Friend WithEvents labelDNI As Label
    Friend WithEvents labelLastName As Label
    Friend WithEvents labelName As Label
    Friend WithEvents comboBoxPeriod As ComboBox
    Friend WithEvents labelAccessPeriod As Label
    Friend WithEvents groupBoxDepartament As GroupBox
    Friend WithEvents radioButtonLogic As RadioButton
    Friend WithEvents radioButtonResource As RadioButton
    Friend WithEvents radioButtonFinanzas As RadioButton
    Friend WithEvents textBoxName As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents textBoxDNI As TextBox
    Friend WithEvents textBoxLastName As TextBox
    Friend WithEvents buttonSend As Button
    Friend WithEvents groupBoxPerfil As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents obligatoryDNI As Label
    Friend WithEvents labelObligatoryName As Label
    Friend WithEvents obligatoryName As Label
    Friend WithEvents labelNumRegister As Label
    Friend WithEvents textBoxRegister As TextBox
End Class
