Public Class frmEquivalencias
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim C As Integer = 0
        Dim R As Integer = 0
        Dim F As Integer = 0
        Dim K As Integer = 0

        C = txtCentigrado.Text
        F = (C * 9 / 5) + 32
        R = ((C * 9 / 5) + 32) + 460
        K = C + 273

        lblRankine.Text = R
        lblRankine.BackColor = Color.White

        lblFahrenheit.Text = F
        lblFahrenheit.BackColor = Color.White

        lblKelvin.Text = K
        lblKelvin.BackColor = Color.White

    End Sub
End Class