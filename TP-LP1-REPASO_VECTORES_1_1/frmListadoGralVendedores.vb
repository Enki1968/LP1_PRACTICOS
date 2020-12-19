Public Class frmListadoGralVendedores
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        dgvVendedores.Rows.Clear()

        While i < IND
            dgvVendedores.Rows.Add(vendedor(i).codigo, vendedor(i).nombre, vendedor(i).sueldo)
            total = total + vendedor(i).sueldo
            i = i + 1
        End While
        lblTotalSueldos.Text = total.ToString("C")
        lblCantidadVendedores.Text = i
        cmdListar.Enabled = False
    End Sub
End Class