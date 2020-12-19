Public Class frm06ListadoGeneralPorSucursal
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim total As Decimal = 0
        Dim totalgeneral As Decimal = 0

        While c < 4
            f = 0
            total = 0
            While f < 12
                total = total + ventas(f, c)
                f = f + 1
            End While
            dgvVentas.Rows.Add(sucursales(c), total)
            totalgeneral = totalgeneral + total
            c = c + 1
        End While
        lblTotalVentas.Text = totalgeneral.ToString("C")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class