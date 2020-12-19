Public Class frmConsultaCantidadProducidaEmpleado
    Private Sub frmConsultaCantidadProducidaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        While i < 5
            cmbEmpleado.Items.Add(empleado(i))
            i = i + 1
        End While
        cmbEmpleado.SelectedIndex = 0
    End Sub

    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = cmbEmpleado.SelectedIndex
        Dim c As Integer = 0
        dgvProduccion.Rows.Clear()

        While c < 3
            dgvProduccion.Rows.Add(maquina(c), cantidadproducida(f, c))
            c = c + 1
        End While
    End Sub
End Class