Public Class Fjuego
    Dim movHor, movVer As Integer
    Private Sub Fjuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nave.Left = ClientSize.Width / 2 - Nave.Width / 2
        Nave.Top = ClientSize.Height - Nave.Height - 20
        Bola.Left = ClientSize.Width / 2

        movHor = 2
        movVer = 2


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Bola.Left = Bola.Left + movHor
        Bola.Top += movVer
        Nave.Left = Bola.Left + 80
        'Cuando toca pared cambia de sentido
        If Bola.Left < 0 Or Bola.Left > ClientSize.Width - Bola.Width Then movHor = -movHor
        'cuando toca techo cambia de sentido
        If Bola.Top < 0 Then
            movVer = -movVer
        End If
        'cuando toca suelo perdemos
        If Bola.Top > ClientSize.Height - Bola.Height Then
            'movVer = -movVer 'movimiento infinito
            'HEMOS PERDIDO
            Timer1.Enabled = False

        End If
        'Controlar el rebote en Nave
        If Bola.Top > ClientSize.Height - Nave.Height - 20 - Bola.Height Then
            If Bola.Left > Nave.Left And Bola.Left < Nave.Left + Nave.Width Then
                movVer = -movVer
                '  Timer1.Enabled = False
            End If

        End If
    End Sub
End Class
