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
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_saludo
        '
        Me.lbl_saludo.AutoSize = True
        Me.lbl_saludo.Location = New System.Drawing.Point(211, 56)
        Me.lbl_saludo.Name = "lbl_saludo"
        Me.lbl_saludo.Size = New System.Drawing.Size(32, 15)
        Me.lbl_saludo.TabIndex = 0
        Me.lbl_saludo.Text = "Hola"
        '
        'ComboFuentes
        '
        Me.ComboFuentes.FormattingEnabled = True
        Me.ComboFuentes.Location = New System.Drawing.Point(174, 201)
        Me.ComboFuentes.Name = "ComboFuentes"
        Me.ComboFuentes.Size = New System.Drawing.Size(225, 23)
        Me.ComboFuentes.TabIndex = 1
        '
        'tlb_deslizador
        '
        Me.tlb_deslizador.Location = New System.Drawing.Point(174, 150)
        Me.tlb_deslizador.Maximum = 50
        Me.tlb_deslizador.Minimum = 8
        Me.tlb_deslizador.Name = "tlb_deslizador"
        Me.tlb_deslizador.Size = New System.Drawing.Size(225, 45)
        Me.tlb_deslizador.TabIndex = 2
        Me.tlb_deslizador.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tlb_deslizador.Value = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlb_deslizador)
        Me.Controls.Add(Me.ComboFuentes)
        Me.Controls.Add(Me.lbl_saludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tlb_deslizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_saludo As Label
    Friend WithEvents ComboFuentes As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents tlb_deslizador As TrackBar
End Class
