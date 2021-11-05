<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_saludo = New System.Windows.Forms.Label()
        Me.ComboFuentes = New System.Windows.Forms.ComboBox()
        Me.tlb_deslizador = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkTachada = New System.Windows.Forms.CheckBox()
        Me.checkSubrayada = New System.Windows.Forms.CheckBox()
        Me.checkInclinada = New System.Windows.Forms.CheckBox()
        Me.checkNegrita = New System.Windows.Forms.CheckBox()
        Me.checkNormal = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_saludo
        '
        Me.lbl_saludo.AutoSize = True
        Me.lbl_saludo.Location = New System.Drawing.Point(342, 88)
        Me.lbl_saludo.Name = "lbl_saludo"
        Me.lbl_saludo.Size = New System.Drawing.Size(32, 15)
        Me.lbl_saludo.TabIndex = 0
        Me.lbl_saludo.Text = "Hola"
        '
        'ComboFuentes
        '
        Me.ComboFuentes.FormattingEnabled = True
        Me.ComboFuentes.Location = New System.Drawing.Point(305, 233)
        Me.ComboFuentes.Name = "ComboFuentes"
        Me.ComboFuentes.Size = New System.Drawing.Size(225, 23)
        Me.ComboFuentes.TabIndex = 1
        '
        'tlb_deslizador
        '
        Me.tlb_deslizador.Location = New System.Drawing.Point(305, 182)
        Me.tlb_deslizador.Maximum = 50
        Me.tlb_deslizador.Minimum = 8
        Me.tlb_deslizador.Name = "tlb_deslizador"
        Me.tlb_deslizador.Size = New System.Drawing.Size(225, 45)
        Me.tlb_deslizador.TabIndex = 2
        Me.tlb_deslizador.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tlb_deslizador.Value = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.checkTachada)
        Me.Panel1.Controls.Add(Me.checkSubrayada)
        Me.Panel1.Controls.Add(Me.checkInclinada)
        Me.Panel1.Controls.Add(Me.checkNegrita)
        Me.Panel1.Location = New System.Drawing.Point(-9, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 105)
        Me.Panel1.TabIndex = 3
        '
        'checkTachada
        '
        Me.checkTachada.AutoSize = True
        Me.checkTachada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)
        Me.checkTachada.Location = New System.Drawing.Point(14, 86)
        Me.checkTachada.Name = "checkTachada"
        Me.checkTachada.Size = New System.Drawing.Size(69, 19)
        Me.checkTachada.TabIndex = 0
        Me.checkTachada.Text = "Tachada"
        Me.checkTachada.UseVisualStyleBackColor = True
        '
        'checkSubrayada
        '
        Me.checkSubrayada.AutoSize = True
        Me.checkSubrayada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.checkSubrayada.Location = New System.Drawing.Point(14, 61)
        Me.checkSubrayada.Name = "checkSubrayada"
        Me.checkSubrayada.Size = New System.Drawing.Size(81, 19)
        Me.checkSubrayada.TabIndex = 0
        Me.checkSubrayada.Text = "Subrayada"
        Me.checkSubrayada.UseVisualStyleBackColor = True
        '
        'checkInclinada
        '
        Me.checkInclinada.AutoSize = True
        Me.checkInclinada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.checkInclinada.Location = New System.Drawing.Point(14, 36)
        Me.checkInclinada.Name = "checkInclinada"
        Me.checkInclinada.Size = New System.Drawing.Size(75, 19)
        Me.checkInclinada.TabIndex = 0
        Me.checkInclinada.Text = "Inclinada"
        Me.checkInclinada.UseVisualStyleBackColor = True
        '
        'checkNegrita
        '
        Me.checkNegrita.AutoSize = True
        Me.checkNegrita.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.checkNegrita.Location = New System.Drawing.Point(14, 11)
        Me.checkNegrita.Name = "checkNegrita"
        Me.checkNegrita.Size = New System.Drawing.Size(68, 19)
        Me.checkNegrita.TabIndex = 0
        Me.checkNegrita.Text = "Negrita"
        Me.checkNegrita.UseVisualStyleBackColor = True
        '
        'checkNormal
        '
        Me.checkNormal.AutoSize = True
        Me.checkNormal.Checked = True
        Me.checkNormal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkNormal.Location = New System.Drawing.Point(5, 33)
        Me.checkNormal.Name = "checkNormal"
        Me.checkNormal.Size = New System.Drawing.Size(66, 19)
        Me.checkNormal.TabIndex = 0
        Me.checkNormal.Text = "Normal"
        Me.checkNormal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkNormal)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 193)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estilos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tlb_deslizador)
        Me.Controls.Add(Me.ComboFuentes)
        Me.Controls.Add(Me.lbl_saludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_saludo As Label
    Friend WithEvents ComboFuentes As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents tlb_deslizador As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents checkTachada As CheckBox
    Friend WithEvents checkSubrayada As CheckBox
    Friend WithEvents checkInclinada As CheckBox
    Friend WithEvents checkNegrita As CheckBox
    Friend WithEvents checkNormal As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
