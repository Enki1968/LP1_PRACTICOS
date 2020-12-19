Public Class frmVectoresNumericos
    Dim mes() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Dim ventas(11) As Decimal
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim i As Integer = cmbMes.SelectedIndex
        ventas(i) = ventas(i) + txtImporte.Text
        MessageBox.Show("Datos cargados")
    End Sub

    Private Sub frmVentasAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < 12
            cmbMes.Items.Add(mes(i))
            i = i + 1
        End While
        cmbMes.SelectedIndex = 0    'Esto es si queremos mostrar por defecto el dato de la posición cero(enero)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        Dim cantidad As Integer = 0
        Dim total As Integer = 0

        dgvVentas.Rows.Clear()
        While i < 12
            If ventas(i) > 0 Then
                dgvVentas.Rows.Add(mes(i), ventas(i))
                cantidad = cantidad + 1
                total = total + ventas(i)
            End If
            i = i + 1
        End While
        lblCantidad.Text = cantidad
        lblTotal.Text = total
        lblPromedio.Text = total / cantidad
    End Sub
End Class
