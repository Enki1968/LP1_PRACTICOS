Public Class frm01CargaVentas
    Private Sub frm01CargaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < 12
            cmbMes.Items.Add(meses(i))
            i = i + 1
        End While
        cmbMes.SelectedIndex = 0

        i = 0   'Para que el indice comience otra vez en cero.
        While i < 4
            cmbSucursal.Items.Add(sucursales(i))
            i = i + 1
        End While
        cmbSucursal.SelectedIndex = 0

    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        Dim f As Integer = cmbMes.SelectedIndex         'Toma el valor de las coordenadas elegidas.
        Dim c As Integer = cmbSucursal.SelectedIndex    'Toma el valor de las coordenadas elegidas.

        ventas(f, c) = ventas(f, c) + txtVentas.Text
        MessageBox.Show("Datos cargados")
        txtVentas.Text = ""
    End Sub

    Private Sub txtVentas_TextChanged(sender As Object, e As EventArgs) Handles txtVentas.TextChanged
        If txtVentas.Text = "" Then
            cmdCargar.Enabled = False
        Else
            cmdCargar.Enabled = True
        End If
    End Sub
End Class