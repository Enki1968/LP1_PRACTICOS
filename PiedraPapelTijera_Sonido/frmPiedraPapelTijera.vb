Imports System.Media
Public Class frmPiedraPapelTijera

    Private objR As New Random()
    Dim r As Integer = objR.Next(1, 4)
    Dim jugadas As Integer = 0
    Dim ganadas As Integer = 0
    Dim empatadas As Integer = 0
    Dim perdidas As Integer = 0
    Dim sonido As New SoundPlayer()

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub btnPiedra_Click(sender As Object, e As EventArgs) Handles btnPiedra.Click
        pctJugador.Image = My.Resources.piedra
        Dim r As Integer = objR.Next(1, 4)
        jugadas += 1
        lblJugadas.Text = jugadas
        sonido.Stop()

        If r = 1 Then
            pctPc.Image = My.Resources.piedra
            lblMensaje.Text = "EMPATE!"
            lblMensaje.BackColor = Color.White
            sonido.SoundLocation = "Empate.wav"
            sonido.Play()
            empatadas += 1
            lblEmpatadas.Text = empatadas
        Else
            If r = 2 Then
                pctPc.Image = My.Resources.Papel
                lblMensaje.Text = "TÚ PIERDES, GANÓ PC!"
                lblMensaje.BackColor = Color.White
                sonido.SoundLocation = "Ohno.wav"
                sonido.Play()
                perdidas += 1
                lblPerdidas.Text = perdidas
            Else
                If r = 3 Then
                    pctPc.Image = My.Resources.Tijera
                    lblMensaje.Text = "GANASTE!!!"
                    lblMensaje.BackColor = Color.White
                    sonido.SoundLocation = "Aleluya.wav"
                    sonido.Play()
                    ganadas += 1
                    lblGanadas.Text = ganadas
                End If
            End If
        End If
        If (jugadas = 7) Then
            lblMensaje.Text = "FIN DEL JUEGO!"
            lblMensaje.BackColor = Color.White
            lblMensaje.ForeColor = Color.Red
            sonido.SoundLocation = "FinDelJuego1.wav"
            sonido.Play()
            btnPiedra.Enabled = False
            btnPapel.Enabled = False
            btnTijera.Enabled = False

        End If
    End Sub

    Private Sub btnPapel_Click(sender As Object, e As EventArgs) Handles btnPapel.Click
        pctJugador.Image = My.Resources.Papel
        Dim r As Integer = objR.Next(1, 4)
        jugadas += 1
        lblJugadas.Text = jugadas
        sonido.Stop()

        If r = 1 Then
            pctPc.Image = My.Resources.piedra
            lblMensaje.Text = "GANASTE!!!"
            lblMensaje.BackColor = Color.White
            sonido.SoundLocation = "Aleluya.wav"
            sonido.Play()
            ganadas += 1
            lblGanadas.Text = ganadas
        Else
            If r = 2 Then
                pctPc.Image = My.Resources.Papel
                lblMensaje.Text = "EMPATE!"
                lblMensaje.BackColor = Color.White
                sonido.SoundLocation = "Empate.wav"
                sonido.Play()

                empatadas += 1
                lblEmpatadas.Text = empatadas
            Else
                If r = 3 Then
                    pctPc.Image = My.Resources.Tijera
                    lblMensaje.Text = "TÚ PIERDES, GANÓ PC!"
                    lblMensaje.BackColor = Color.White
                    sonido.SoundLocation = "Ohno.wav"
                    sonido.Play()
                    perdidas += 1
                    lblPerdidas.Text = perdidas
                End If
            End If
        End If
        If (jugadas = 7) Then
            lblMensaje.Text = "FIN DEL JUEGO!"
            lblMensaje.BackColor = Color.White
            lblMensaje.ForeColor = Color.Red
            sonido.SoundLocation = "FinDelJuego1.wav"
            sonido.Play()
            btnPiedra.Enabled = False
            btnPapel.Enabled = False
            btnTijera.Enabled = False
        End If
    End Sub

    Private Sub btnTijera_Click(sender As Object, e As EventArgs) Handles btnTijera.Click
        pctJugador.Image = My.Resources.Tijera
        Dim r As Integer = objR.Next(1, 4)
        jugadas += 1
        lblJugadas.Text = jugadas
        sonido.Stop()

        If r = 1 Then
            pctPc.Image = My.Resources.piedra
            lblMensaje.Text = "TÚ PIERDES, GANÓ PC!"
            lblMensaje.BackColor = Color.White
            sonido.SoundLocation = "Ohno.wav"
            sonido.Play()
            perdidas += 1
            lblPerdidas.Text = perdidas
        Else
            If r = 2 Then
                pctPc.Image = My.Resources.Papel
                lblMensaje.Text = "GANASTE!!!"
                lblMensaje.BackColor = Color.White
                sonido.SoundLocation = "Aleluya.wav"
                sonido.Play()
                ganadas += 1
                lblGanadas.Text = ganadas
            Else
                If r = 3 Then
                    pctPc.Image = My.Resources.Tijera
                    lblMensaje.Text = "EMPATE!"
                    lblMensaje.BackColor = Color.White
                    sonido.SoundLocation = "Empate.wav"
                    sonido.Play()
                    empatadas += 1
                    lblEmpatadas.Text = empatadas

                End If
            End If
        End If

        If (jugadas = 7) Then
            lblMensaje.Text = "FIN DEL JUEGO!"
            lblMensaje.BackColor = Color.White
            lblMensaje.ForeColor = Color.Red
            sonido.SoundLocation = "FinDelJuego1.wav"
            sonido.Play()
            btnPiedra.Enabled = False
            btnPapel.Enabled = False
            btnTijera.Enabled = False
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        sonido.SoundLocation = "kart-mario.wav"
        sonido.Play()
        btnPiedra.Enabled = True
        btnPapel.Enabled = True
        btnTijera.Enabled = True
        lblJugadas.Text = ""
        lblGanadas.Text = ""
        lblEmpatadas.Text = ""
        lblPerdidas.Text = ""
        lblMensaje.Text = ""
        lblMensaje.BackColor = Color.Transparent
        pctJugador.Image = My.Resources.Titulo
        pctPc.Image = My.Resources.Titulo
        jugadas = 0
        ganadas = 0
        empatadas = 0
        perdidas = 0

    End Sub

    Private Sub frmPiedraPapelTijera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sonido.SoundLocation = "kart-mario.wav"
        sonido.Play()
    End Sub
End Class
