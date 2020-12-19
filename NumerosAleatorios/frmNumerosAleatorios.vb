Public Class frmNumerosAleatorios

    Private r As New Random
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim n As Integer = 0
        n = r.Next(1, 11)
        lblNumero.Text = n
    End Sub
End Class
