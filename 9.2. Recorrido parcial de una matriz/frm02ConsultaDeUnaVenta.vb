Public Class frm02ConsultaDeUnaVenta
    Private Sub frm02ConsultaDeUnaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        While i < 12
            cmbMes.Items.Add(meses(i))
            i = i + 1
        End While
        cmbMes.SelectedIndex = 0

        i = 0
        While i < 4
            cmbSucursal.Items.Add(sucursales(i))
            i = i + 1
        End While
        cmbSucursal.SelectedIndex = 0
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim f As Integer = cmbMes.SelectedIndex
        Dim c As Integer = cmbSucursal.SelectedIndex

        lblVentas.Text = ventas(f, c)
    End Sub
End Class