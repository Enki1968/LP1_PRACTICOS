Public Class frmConsultaClientes
    Private Sub frmConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < IND
            cmbCliente.Items.Add(clientes(i).nombre)
            i = i + 1
        End While
    End Sub

    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Dim i As Integer = cmbCliente.SelectedIndex
        lblDeuda.Text = clientes(i).deuda
        lblLimite.Text = clientes(i).limite
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged

    End Sub
End Class