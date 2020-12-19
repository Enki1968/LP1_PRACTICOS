Public Class frmJuegoDeDados

    Private r As New Random
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim x As Integer = 0
        x = r.Next(1, 7)

        Select Case x
            Case 1
                pctImagen.Image = My.Resources.dado1
            Case 2
                pctImagen.Image = My.Resources.dado2
            Case 3
                pctImagen.Image = My.Resources.dado3
            Case 4
                pctImagen.Image = My.Resources.dado4
            Case 5
                pctImagen.Image = My.Resources.dado5
            Case 6
                pctImagen.Image = My.Resources.dado6
        End Select

    End Sub
End Class
