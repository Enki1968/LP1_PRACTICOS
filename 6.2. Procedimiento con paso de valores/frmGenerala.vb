Public Class frmGenerala

    Private objR As New Random()
    Private Sub btnArrojarDado_Click(sender As Object, e As EventArgs) Handles btnArrojarDado.Click
        Dim d1 As Integer = objR.Next(1, 7)
        Dim d2 As Integer = objR.Next(1, 7)
        Dim d3 As Integer = objR.Next(1, 7)
        Dim d4 As Integer = objR.Next(1, 7)
        Dim d5 As Integer = objR.Next(1, 7)

        lblMensaje.Text = ""

        DibujarDado(d1, pctDado1)
        DibujarDado(d2, pctDado2)
        DibujarDado(d3, pctDado3)
        DibujarDado(d4, pctDado4)
        DibujarDado(d5, pctDado5)

        If (d1 = d2 And d2 = d3 And d3 = d4 And d4 = d5) Then
            lblMensaje.Text = "Generala!!!"
            btnArrojarDado.Enabled = False

        Else
            If ((d1 = d2 And d1 = d3 And d1 = d4) Or (d1 = d2 And d2 = d3 And d3 = d5) Or (d1 = d2 And d1 = d4 And d1 = d5) Or
                (d1 = d3 And d1 = d4 And d1 = d5) Or (d2 = d3 And d2 = d4 And d2 = d5)) Then
                lblMensaje.Text = "Poker!!!"
                btnArrojarDado.Enabled = False
            Else
                If ((d1 = d2 And d2 <> d3 And d3 = d4 And d4 = d5) Or (d1 = d3 And d3 <> d2 And d2 = d4 And d4 = d5) Or
                    (d1 = d3 And d3 <> d2 And d2 = d4 And d4 = d5) Or (d1 = d4 And d2 <> d4 And d2 = d3 And d3 = d5) Or
                    (d1 = d5 And d5 <> d2 And d2 = d3 And d3 = d4) Or (d2 = d5 And d5 <> d1 And d1 = d3 And d3 = d4) Or
                    (d3 = d5 And d5 <> d1 And d1 = d2 And d2 = d4) Or (d4 = d5 And d5 <> d1 And d1 = d2 And d2 = d3)) Then
                    lblMensaje.Text = "Full!!!"
                    btnArrojarDado.Enabled = False
                Else
                    If ((d1 <> d2 And d1 <> d3 And d1 <> d4 And d1 <> d5 And d2 <> d3 And
                        d2 <> d4 And d2 <> d5 And d3 <> d4 And d3 <> d5 And d4 <> d5) And
                        (d1 + d2 + d3 + d4 + d5 = 15 Or d1 + d2 + d3 + d4 + d5 = 20)) Then
                        lblMensaje.Text = "Escalera!!!"
                        btnArrojarDado.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub DibujarDado(x As Integer, imagen As PictureBox)
        Select Case (x)
            Case 1
                imagen.Image = My.Resources.dado1
            Case 2
                imagen.Image = My.Resources.dado2
            Case 3
                imagen.Image = My.Resources.dado3
            Case 4
                imagen.Image = My.Resources.dado4
            Case 5
                imagen.Image = My.Resources.dado5
            Case 6
                imagen.Image = My.Resources.dado6
        End Select

    End Sub

    Private Sub btnVolverATirar_Click(sender As Object, e As EventArgs) Handles btnVolverATirar.Click
        lblMensaje.Text = ""
        btnArrojarDado.Enabled = True
        pctDado1.Image = My.Resources.dadoGirando
        pctDado2.Image = My.Resources.dadoGirando
        pctDado3.Image = My.Resources.dadoGirando
        pctDado4.Image = My.Resources.dadoGirando
        pctDado5.Image = My.Resources.dadoGirando
    End Sub
End Class
