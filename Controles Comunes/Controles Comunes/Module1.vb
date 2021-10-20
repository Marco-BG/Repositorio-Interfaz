Module Arranque
    Sub main()
        Dim Op As Integer = 0
        Dim miPrincipal As Principal
        Op = MessageBox.Show("¿Sigues? Si o No ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If Op = vbNo Then
            End
        End If

        miPrincipal = New Principal
        miPrincipal.ShowDialog()
    End Sub
End Module
