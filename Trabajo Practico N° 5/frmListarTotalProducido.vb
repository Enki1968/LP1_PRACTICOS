Public Class frmListarTotalProducido
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim total As Integer = 0
        dgvProduccion.Rows.Clear()

        While f < 5
            total = 0
            c = 0
            While c < 3
                total = total + cantidadproducida(f, c)
                c = c + 1
            End While
            dgvProduccion.Rows.Add(empleado(f), total)
            f = f + 1
        End While
    End Sub
End Class