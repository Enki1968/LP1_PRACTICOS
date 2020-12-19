Public Class frmListadoClientesDeudores
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0    'Acumula los valores de deuda.
        Dim cantidad As Integer = 0 'Cuenta los clientes que cumplan con la condición


        dgvClientes.Rows.Clear()
        While i < IND
            If clientes(i).deuda > 0 Then
                dgvClientes.Rows.Add(clientes(i).codigo, clientes(i).nombre, clientes(i).limite, clientes(i).deuda)
                total = total + clientes(i).deuda   'El acumulador se incrementa en una cantidad variable
                cantidad = cantidad + 1             'El contador se incrementa en una cantidad constante
            End If
            i = i + 1
        End While
        lblTotalDeuda.Text = total
        lblCantidadClientes.Text = cantidad
        lblPromedioDeuda.Text = total / cantidad

    End Sub
End Class