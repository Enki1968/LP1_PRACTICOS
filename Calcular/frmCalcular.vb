Public Class frmCalcular
    Private Sub frmCalcular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim Suma As Integer = 0
        Dim Resta As Integer = 0
        Dim Producto As Integer = 0
        Dim Division As Integer = 0

        A = txtA.Text
        B = txtB.Text

        Suma = A + B
        Resta = A - B
        Producto = A * B
        Division = A / B

        lblSuma.Text = Suma
        lblResta.Text = Resta
        lblProducto.Text = Producto
        lblDivision.Text = Division
    End Sub
End Class
