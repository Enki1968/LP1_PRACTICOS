Public Class frmListadoGeneral
    Private Sub cmdListar_Click_1(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        dgvEmpleados.Rows.Clear()

        While i < IND
            dgvEmpleados.Rows.Add(empleados(i).codigo, empleados(i).nombre, empleados(i).categoria, empleados(i).sueldo)
            total = total + empleados(i).sueldo 'Acumula los sueldos
            i = i + 1                           'Cuenta los empleados
        End While
        lblTotalSueldos.Text = total.ToString("C")  'Muestra el formato moneda según como esté la configuración regional de cada equipo donde se ejecute.
        lblCantidadEmpleados.Text = i               'Muestra la cantidad de empleados
        cmdListar.Enabled = False
    End Sub

    Private Sub frmListadoGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class