Public Class frm03ConsultaVentasDeUnMes
    Private Sub frm03ConsultaVentasDeUnMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        While i < 12
            cmbMes.Items.Add(meses(i))
            i = i + 1
        End While
        cmbMes.SelectedIndex = 0
    End Sub

    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = cmbMes.SelectedIndex
        Dim c As Integer = 0
        Dim total As Integer = 0
        dgvVentas.Rows.Clear()

        While c < 4
            dgvVentas.Rows.Add(sucursales(c), ventas(f, c))
            total = total + ventas(f, c)
            c = c + 1
        End While
        lblTotalVentas.Text = total.ToString("C")
    End Sub
End Class