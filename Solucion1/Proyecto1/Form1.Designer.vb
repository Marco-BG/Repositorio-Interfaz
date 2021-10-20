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
        Me.Btn_primerBoton = New System.Windows.Forms.Button()
        Me.Btn_segundoBoton = New System.Windows.Forms.Button()
        Me.Lbl_primeraEtiqueta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_primerBoton
        '
        Me.Btn_primerBoton.Location = New System.Drawing.Point(555, 181)
        Me.Btn_primerBoton.Name = "Btn_primerBoton"
        Me.Btn_primerBoton.Size = New System.Drawing.Size(75, 23)
        Me.Btn_primerBoton.TabIndex = 0
        Me.Btn_primerBoton.Text = "Pulsa"
        Me.Btn_primerBoton.UseVisualStyleBackColor = True
        '
        'Btn_segundoBoton
        '
        Me.Btn_segundoBoton.AutoSize = True
        Me.Btn_segundoBoton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_segundoBoton.Location = New System.Drawing.Point(163, 181)
        Me.Btn_segundoBoton.Name = "Btn_segundoBoton"
        Me.Btn_segundoBoton.Size = New System.Drawing.Size(134, 30)
        Me.Btn_segundoBoton.TabIndex = 1
        Me.Btn_segundoBoton.Text = "Hola buenos dias"
        Me.Btn_segundoBoton.UseVisualStyleBackColor = True
        '
        'Lbl_primeraEtiqueta
        '
        Me.Lbl_primeraEtiqueta.AutoSize = True
        Me.Lbl_primeraEtiqueta.Location = New System.Drawing.Point(369, 240)
        Me.Lbl_primeraEtiqueta.Name = "Lbl_primeraEtiqueta"
        Me.Lbl_primeraEtiqueta.Size = New System.Drawing.Size(114, 15)
        Me.Lbl_primeraEtiqueta.TabIndex = 2
        Me.Lbl_primeraEtiqueta.Text = "Hola buenas noches"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_primeraEtiqueta)
        Me.Controls.Add(Me.Btn_segundoBoton)
        Me.Controls.Add(Me.Btn_primerBoton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_primerBoton As Button
    Friend WithEvents Btn_segundoBoton As Button
    Friend WithEvents Lbl_primeraEtiqueta As Label
End Class
