Public Class frm04ConsultarVentasDeUnaSucursal
    Private Sub frm04ConsultarVentasDeUnaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < 4
            cmbSucursal.Items.Add(sucursales(i))
            i = i + 1
        End While
        cmbSucursal.SelectedIndex = 0
    End Sub

    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = 0
        Dim c As Integer = cmbSucursal.SelectedIndex
        Dim total As Decimal = 0
        dgvVentas.Rows.Clear()

        While f < 12
            dgvVentas.Rows.Add(meses(f), ventas(f, c))
            total = total + ventas(f, c)
            f = f + 1
        End While
        lblTotalVentas.Text = total.ToString("C")
    End Sub
End Class