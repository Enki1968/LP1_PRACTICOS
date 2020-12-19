Public Class frmColsultaDatosEmpleado
    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As Integer = cmbEmpleados.SelectedIndex
        lblCodigo.Text = empleados(i).codigo
        lblCategoria.Text = empleados(i).categoria
        lblSueldo.Text = empleados(i).sueldo.ToString("C")  'Muestra el formato moneda según como esté la configuración regional de cada equipo donde se ejecute.
    End Sub

    Private Sub frmColsultaDatosEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        cmbEmpleados.Items.Clear()  'Limpio el combobox

        While i < IND
            cmbEmpleados.Items.Add(empleados(i).nombre)
            i = i + 1
        End While
        cmbEmpleados.SelectedIndex = 0  'Queda seleccionado por defecto el elemento de la posicion "0"
    End Sub

    Private Sub cmbEmpleados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEmpleados.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmdConsultar.Select()
            e.Handled = True
        End If
    End Sub
End Class