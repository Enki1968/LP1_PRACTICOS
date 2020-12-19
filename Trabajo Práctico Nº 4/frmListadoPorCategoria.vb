Public Class frmListadoPorCategoria
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0
        dgvEmpleados.Rows.Clear()

        While i < IND
            If empleados(i).categoria = txtCategoria.Text Then
                dgvEmpleados.Rows.Add(empleados(i).codigo, empleados(i).nombre, empleados(i).categoria, empleados(i).sueldo)
                total = total + empleados(i).sueldo
                cantidad = cantidad + 1
            End If
            i = i + 1
        End While

        If cantidad = 0 Then
            MessageBox.Show("La categoría no existe")
            lblTotalSueldos.Text = ""
            lblCantidadEmpleados.Text = ""
        Else
            lblTotalSueldos.Text = total.ToString("C")  'Muestra el formato moneda según como esté la configuración regional de cada equipo donde se ejecute.
            lblCantidadEmpleados.Text = cantidad
        End If

    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmdListar.Select()
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class
