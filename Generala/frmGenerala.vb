Public Class frmGenerala

    Private objR As New Random()
    Private Sub btnArrojarDado_Click(sender As Object, e As EventArgs) Handles btnArrojarDado.Click
        Dim d1 As Integer = objR.Next(1, 7)
        Dim d2 As Integer = objR.Next(1, 7)
        Dim d3 As Integer = objR.Next(1, 7)
        Dim d4 As Integer = objR.Next(1, 7)
        Dim d5 As Integer = objR.Next(1, 7)

        lblMensaje.Text = ""

        Select Case (d1)
            Case 1
                pctDado1.Image = My.Resources.dado1
            Case 2
                pctDado1.Image = My.Resources.dado2
            Case 3
                pctDado1.Image = My.Resources.dado3
            Case 4
                pctDado1.Image = My.Resources.dado4
            Case 5
                pctDado1.Image = My.Resources.dado5
            Case 6
                pctDado1.Image = My.Resources.dado6
        End Select

        Select Case (d2)
            Case 1
                pctDado2.Image = My.Resources.dado1
            Case 2
                pctDado2.Image = My.Resources.dado2
            Case 3
                pctDado2.Image = My.Resources.dado3
            Case 4
                pctDado2.Image = My.Resources.dado4
            Case 5
                pctDado2.Image = My.Resources.dado5
            Case 6
                pctDado2.Image = My.Resources.dado6
        End Select

        Select Case (d3)
            Case 1
                pctDado3.Image = My.Resources.dado1
            Case 2
                pctDado3.Image = My.Resources.dado2
            Case 3
                pctDado3.Image = My.Resources.dado3
            Case 4
                pctDado3.Image = My.Resources.dado4
            Case 5
                pctDado3.Image = My.Resources.dado5
            Case 6
                pctDado3.Image = My.Resources.dado6
        End Select

        Select Case (d4)
            Case 1
                pctDado4.Image = My.Resources.dado1
            Case 2
                pctDado4.Image = My.Resources.dado2
            Case 3
                pctDado4.Image = My.Resources.dado3
            Case 4
                pctDado4.Image = My.Resources.dado4
            Case 5
                pctDado4.Image = My.Resources.dado5
            Case 6
                pctDado4.Image = My.Resources.dado6
        End Select

        Select Case (d5)
            Case 1
                pctDado5.Image = My.Resources.dado1
            Case 2
                pctDado5.Image = My.Resources.dado2
            Case 3
                pctDado5.Image = My.Resources.dado3
            Case 4
                pctDado5.Image = My.Resources.dado4
            Case 5
                pctDado5.Image = My.Resources.dado5
            Case 6
                pctDado5.Image = My.Resources.dado6
        End Select

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
