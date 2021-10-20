<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.btnSaludo = New System.Windows.Forms.Button()
        Me.rtbDia = New System.Windows.Forms.RadioButton()
        Me.rtbTarde = New System.Windows.Forms.RadioButton()
        Me.rtbNoche = New System.Windows.Forms.RadioButton()
        Me.panelOpcionesRadio = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.panelNombres = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.panelOpcionesRadio.SuspendLayout()
        Me.panelNombres.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(233, 148)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(43, 15)
        Me.lblSaludo.TabIndex = 1
        Me.lblSaludo.Tag = ""
        Me.lblSaludo.Text = "Saludo"
        '
        'btnSaludo
        '
        Me.btnSaludo.Location = New System.Drawing.Point(51, 144)
        Me.btnSaludo.Name = "btnSaludo"
        Me.btnSaludo.Size = New System.Drawing.Size(122, 23)
        Me.btnSaludo.TabIndex = 2
        Me.btnSaludo.Tag = "Medios"
        Me.btnSaludo.Text = "Saludo"
        Me.btnSaludo.UseVisualStyleBackColor = True
        '
        'rtbDia
        '
        Me.rtbDia.AutoSize = True
        Me.rtbDia.Checked = True
        Me.rtbDia.Location = New System.Drawing.Point(52, 14)
        Me.rtbDia.Name = "rtbDia"
        Me.rtbDia.Size = New System.Drawing.Size(42, 19)
        Me.rtbDia.TabIndex = 3
        Me.rtbDia.TabStop = True
        Me.rtbDia.Tag = "Buenos"
        Me.rtbDia.Text = "Dia"
        Me.rtbDia.UseVisualStyleBackColor = True
        '
        'rtbTarde
        '
        Me.rtbTarde.AutoSize = True
        Me.rtbTarde.Location = New System.Drawing.Point(52, 39)
        Me.rtbTarde.Name = "rtbTarde"
        Me.rtbTarde.Size = New System.Drawing.Size(53, 19)
        Me.rtbTarde.TabIndex = 4
        Me.rtbTarde.Tag = "Buenas "
        Me.rtbTarde.Text = "Tarde"
        Me.rtbTarde.UseVisualStyleBackColor = True
        '
        'rtbNoche
        '
        Me.rtbNoche.AutoSize = True
        Me.rtbNoche.Location = New System.Drawing.Point(52, 64)
        Me.rtbNoche.Name = "rtbNoche"
        Me.rtbNoche.Size = New System.Drawing.Size(60, 19)
        Me.rtbNoche.TabIndex = 5
        Me.rtbNoche.Tag = "Buenas "
        Me.rtbNoche.Text = "Noche"
        Me.rtbNoche.UseVisualStyleBackColor = True
        '
        'panelOpcionesRadio
        '
        Me.panelOpcionesRadio.Controls.Add(Me.RadioButton1)
        Me.panelOpcionesRadio.Controls.Add(Me.rtbDia)
        Me.panelOpcionesRadio.Controls.Add(Me.rtbNoche)
        Me.panelOpcionesRadio.Controls.Add(Me.rtbTarde)
        Me.panelOpcionesRadio.Location = New System.Drawing.Point(51, 12)
        Me.panelOpcionesRadio.Name = "panelOpcionesRadio"
        Me.panelOpcionesRadio.Size = New System.Drawing.Size(203, 112)
        Me.panelOpcionesRadio.TabIndex = 6
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(52, 90)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 19)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Medios Días"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'panelNombres
        '
        Me.panelNombres.Controls.Add(Me.RadioButton2)
        Me.panelNombres.Controls.Add(Me.RadioButton3)
        Me.panelNombres.Controls.Add(Me.RadioButton4)
        Me.panelNombres.Controls.Add(Me.RadioButton5)
        Me.panelNombres.Location = New System.Drawing.Point(358, 12)
        Me.panelNombres.Name = "panelNombres"
        Me.panelNombres.Size = New System.Drawing.Size(203, 112)
        Me.panelNombres.TabIndex = 6
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(52, 90)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 19)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Martin"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(52, 14)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 19)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "Buenos"
        Me.RadioButton3.Text = "Juan"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(52, 64)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Tag = "Buenas "
        Me.RadioButton4.Text = "Luis"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(52, 39)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(51, 19)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Tag = "Buenas "
        Me.RadioButton5.Text = "Pepe"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelNombres)
        Me.Controls.Add(Me.panelOpcionesRadio)
        Me.Controls.Add(Me.btnSaludo)
        Me.Controls.Add(Me.lblSaludo)
        Me.Name = "Principal"
        Me.Text = "Form1"
        Me.panelOpcionesRadio.ResumeLayout(False)
        Me.panelOpcionesRadio.PerformLayout()
        Me.panelNombres.ResumeLayout(False)
        Me.panelNombres.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSaludo As Label
    Friend WithEvents btnSaludo As Button
    Friend WithEvents rtbDia As RadioButton
    Friend WithEvents rtbTarde As RadioButton
    Friend WithEvents rtbNoche As RadioButton
    Friend WithEvents panelOpcionesRadio As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents panelNombres As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
End Class
