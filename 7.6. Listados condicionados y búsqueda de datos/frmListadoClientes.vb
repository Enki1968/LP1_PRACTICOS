Public Class frmListadoClientes

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        dgvClientes.Rows.Clear()
        CargarVectorClientes()

        While i < IND
            dgvClientes.Rows.Add(clientes(i).codigo, clientes(i).nombre, clientes(i).limite, clientes(i).deuda)
            total = total + clientes(i).deuda
            i = i + 1
        End While
        lblTotal.Text = total
    End Sub
End Class