Public Class frmSumarDosNumeros
    Private Sub frmSumarDosNumeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim Resultado As Integer = 0

        A = txtA.Text
        B = txtB.Text

        Resultado = A + B

        lblResultado.Text = Resultado

    End Sub
End Class
