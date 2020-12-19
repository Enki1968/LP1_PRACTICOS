Public Class frmBusquedaEmpleado
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim i As Integer = 0

        While i < IND And empleados(i).codigo <> txtCodigo.Text 'Se denomina "Búsqueda secuencial"
            i = i + 1
        End While

        If i = IND Then
            MessageBox.Show("El empleado no exixte!!!")
            txtCodigo.Text = ""
            lblNombre.Text = ""
            lblCategoria.Text = ""
            lblSueldo.Text = ""
        Else
            lblNombre.Text = empleados(i).nombre
            lblCategoria.Text = empleados(i).categoria
            lblSueldo.Text = empleados(i).sueldo.ToString("C")  'Muestra el formato moneda según como esté la configuración regional de cada equipo donde se ejecute.
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmdBuscar.Select()
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class