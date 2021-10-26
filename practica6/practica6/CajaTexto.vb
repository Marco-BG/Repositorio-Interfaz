

Public Class CajaTexto
    Inherits TextBox
    Public Overrides Property ForeColor As Color
        Get
            Dim miColor As Color = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
            Return miColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property
    'Public Sub New()

    'End Sub
End Class
