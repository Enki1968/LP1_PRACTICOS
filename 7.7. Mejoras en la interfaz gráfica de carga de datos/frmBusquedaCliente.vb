Public Class frmBusquedaCliente
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim i As Integer = 0
        While i < IND And clientes(i).codigo <> txtCodigo.Text
            i = i + 1
        End While

        If i = IND Then
            MessageBox.Show("Cliente no exixte!!!")
            txtCodigo.Text = "" 'Le vacié la TextBox también
            lblNombre.Text = ""
            lblDeuda.Text = ""
            lblLimite.Text = ""
        Else
            lblNombre.Text = clientes(i).nombre
            lblDeuda.Text = clientes(i).deuda
            lblLimite.Text = clientes(i).limite
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class