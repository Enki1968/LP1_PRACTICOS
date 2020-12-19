Public Class frmConsultaVendedor
    Private Sub frmConsultaVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        cmbNombreVendedor.Items.Clear()

        While i < IND
            cmbNombreVendedor.Items.Add(vendedor(i).nombre)
            i = i + 1
        End While
        cmbNombreVendedor.SelectedIndex = 0
    End Sub
    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As Integer = cmbNombreVendedor.SelectedIndex
        lblCodigoVendedor.Text = vendedor(i).codigo
        lblSueldoVendedor.Text = vendedor(i).sueldo.ToString("C")
    End Sub

    Private Sub cmbNombreVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbNombreVendedor.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmdConsultar.Select()
            e.Handled = True
        End If
    End Sub
End Class