Public Class frmListadoConSueldoMayor
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0    'Acumula los valores de sueldo.
        Dim cantidad As Integer = 0 'Cuenta los empleados que cumplan con la condición
        dgvEmpleados.Rows.Clear()

        While i < IND
            If empleados(i).sueldo > txtImporte.Text Then
                Dim v = dgvEmpleados.Rows.Add(empleados(i).codigo, empleados(i).nombre, empleados(i).categoria, empleados(i).sueldo)
                total = total + empleados(i).sueldo   'El acumulador se incrementa en una cantidad variable
                cantidad = cantidad + 1               'El contador se incrementa en una cantidad constante
            End If
            i = i + 1
        End While
        lblTotalSueldos.Text = total.ToString("C")  'Muestra el formato moneda según como esté la configuración regional de cada equipo donde se ejecute.
        lblCantidadEmpleados.Text = cantidad
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
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