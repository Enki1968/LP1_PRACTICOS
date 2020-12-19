Public Class frmComparaNumeros
    Private objR As New Random()
    Dim aciertos As Integer = 0
    Dim errores As Integer = 0
    Dim puntaje As Integer = 0
    Dim izq As Integer = 0
    Dim der As Integer = 0

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        izq = objR.Next(1, 10)  'Intervalo >=1 a <10, "se pide de 1 a 9 inclusive"
        der = objR.Next(1, 10)  'Intervalo >=1 a <10, "se pide de 1 a 9 inclusive"
        pctIzquierda.Visible = True
        pctDerecha.Visible = True
        btnMayor.Visible = True
        btnIgual.Visible = True
        btnMenor.Visible = True
        btnReiniciar.Enabled = False

        Select Case izq
            Case 1
                pctIzquierda.Image = My.Resources._1
            Case 2
                pctIzquierda.Image = My.Resources._2
            Case 3
                pctIzquierda.Image = My.Resources._3
            Case 4
                pctIzquierda.Image = My.Resources._4
            Case 5
                pctIzquierda.Image = My.Resources._5
            Case 6
                pctIzquierda.Image = My.Resources._6
            Case 7
                pctIzquierda.Image = My.Resources._7
            Case 8
                pctIzquierda.Image = My.Resources._8
            Case 9
                pctIzquierda.Image = My.Resources._9
        End Select

        Select Case der
            Case 1
                pctDerecha.Image = My.Resources._1
            Case 2
                pctDerecha.Image = My.Resources._2
            Case 3
                pctDerecha.Image = My.Resources._3
            Case 4
                pctDerecha.Image = My.Resources._4
            Case 5
                pctDerecha.Image = My.Resources._5
            Case 6
                pctDerecha.Image = My.Resources._6
            Case 7
                pctDerecha.Image = My.Resources._7
            Case 8
                pctDerecha.Image = My.Resources._8
            Case 9
                pctDerecha.Image = My.Resources._9
        End Select

        btnJugar.Visible = False    'Se pide ocultar botón jugar luego del evento.
        pctResultado.Visible = False
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        btnJugar.Visible = True
        btnJugar.Enabled = True
        btnJugar.BackColor = Color.Khaki
        btnMayor.Visible = False
        btnIgual.Visible = False
        btnMenor.Visible = False
        lblAciertos.Text = ""
        lblErrores.Text = ""
        lblPuntaje.Text = ""
        aciertos = 0
        errores = 0
        puntaje = 0
        pctIzquierda.Visible = False
        pctResultado.Visible = False
        pctDerecha.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        pctResultado.Visible = True
        btnJugar.Visible = True

        If izq > der Then
            pctResultado.Image = My.Resources.Bien
            aciertos = aciertos + 1
            puntaje = puntaje + 2
            lblAciertos.Text = aciertos
            lblPuntaje.Text = puntaje
        Else
            pctResultado.Image = My.Resources.Mal
            errores = errores + 1
            puntaje = puntaje - 1
            lblErrores.Text = errores
            lblPuntaje.Text = puntaje
        End If

        If lblPuntaje.Text >= 10 Then
            frmCocoFeliz.Show()
            btnJugar.Enabled = False
            btnJugar.BackColor = Color.Transparent
            btnMayor.Visible = False
            btnIgual.Visible = False
            btnMenor.Visible = False
            btnReiniciar.Enabled = True
        Else
            If lblPuntaje.Text = 0 Then
                frmCocoTriste.Show()
                btnJugar.Enabled = False
                btnJugar.BackColor = Color.Transparent
                btnMayor.Visible = False
                btnIgual.Visible = False
                btnMenor.Visible = False
                btnReiniciar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        pctResultado.Visible = True
        btnJugar.Visible = True

        If izq = der Then
            pctResultado.Image = My.Resources.Bien
            aciertos = aciertos + 1
            puntaje = puntaje + 2
            lblAciertos.Text = aciertos
            lblPuntaje.Text = puntaje
        Else
            pctResultado.Image = My.Resources.Mal
            errores = errores + 1
            puntaje = puntaje - 1
            lblErrores.Text = errores
            lblPuntaje.Text = puntaje
        End If

        If lblPuntaje.Text >= 10 Then
            frmCocoFeliz.Show()
            btnJugar.Enabled = False
            btnJugar.BackColor = Color.Transparent
            btnMayor.Visible = False
            btnIgual.Visible = False
            btnMenor.Visible = False
            btnReiniciar.Enabled = True
        Else
            If lblPuntaje.Text = 0 Then
                frmCocoTriste.Show()
                btnJugar.Enabled = False
                btnJugar.BackColor = Color.Transparent
                btnMayor.Visible = False
                btnIgual.Visible = False
                btnMenor.Visible = False
                btnReiniciar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        pctResultado.Visible = True
        btnJugar.Visible = True

        If izq < der Then
            pctResultado.Image = My.Resources.Bien
            aciertos = aciertos + 1
            puntaje = puntaje + 2
            lblAciertos.Text = aciertos
            lblPuntaje.Text = puntaje
        Else
            pctResultado.Image = My.Resources.Mal
            errores = errores + 1
            puntaje = puntaje - 1
            lblErrores.Text = errores
            lblPuntaje.Text = puntaje
        End If

        If lblPuntaje.Text >= 10 Then
            frmCocoFeliz.Show()
            btnJugar.Enabled = False
            btnJugar.BackColor = Color.Transparent
            btnMayor.Visible = False
            btnIgual.Visible = False
            btnMenor.Visible = False
            btnReiniciar.Enabled = True
        Else
            If lblPuntaje.Text = 0 Then
                frmCocoTriste.Show()
                btnJugar.Enabled = False
                btnJugar.BackColor = Color.Transparent
                btnMayor.Visible = False
                btnIgual.Visible = False
                btnMenor.Visible = False
                btnReiniciar.Enabled = True
            End If
        End If
    End Sub
End Class
