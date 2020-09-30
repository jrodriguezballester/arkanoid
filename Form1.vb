Public Class Fjuego
    Private Sub Fjuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nave.Left = ClientSize.Width / 2 - Nave.Width / 2
        Nave.Top = ClientSize.Height - Nave.Height - 20
    End Sub
End Class
