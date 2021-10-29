<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_textContador = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.btn_masTextBox = New System.Windows.Forms.Button()
        Me.btn_menosTextBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_textContador
        '
        Me.lbl_textContador.AutoSize = True
        Me.lbl_textContador.Location = New System.Drawing.Point(560, 9)
        Me.lbl_textContador.Name = "lbl_textContador"
        Me.lbl_textContador.Size = New System.Drawing.Size(90, 15)
        Me.lbl_textContador.TabIndex = 0
        Me.lbl_textContador.Text = "Nº de TextBox 0"
        '
        'panel
        '
        Me.panel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel.Location = New System.Drawing.Point(445, 27)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(344, 488)
        Me.panel.TabIndex = 1
        '
        'btn_masTextBox
        '
        Me.btn_masTextBox.Location = New System.Drawing.Point(49, 63)
        Me.btn_masTextBox.Name = "btn_masTextBox"
        Me.btn_masTextBox.Size = New System.Drawing.Size(111, 23)
        Me.btn_masTextBox.TabIndex = 2
        Me.btn_masTextBox.Text = "Más TextBox"
        Me.btn_masTextBox.UseVisualStyleBackColor = True
        '
        'btn_menosTextBox
        '
        Me.btn_menosTextBox.Location = New System.Drawing.Point(49, 122)
        Me.btn_menosTextBox.Name = "btn_menosTextBox"
        Me.btn_menosTextBox.Size = New System.Drawing.Size(111, 23)
        Me.btn_menosTextBox.TabIndex = 3
        Me.btn_menosTextBox.Text = "Menos TextBox"
        Me.btn_menosTextBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 514)
        Me.Controls.Add(Me.btn_menosTextBox)
        Me.Controls.Add(Me.btn_masTextBox)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.lbl_textContador)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_textContador As Label
    Friend WithEvents panel As Panel
    Friend WithEvents btn_masTextBox As Button
    Friend WithEvents btn_menosTextBox As Button
End Class
