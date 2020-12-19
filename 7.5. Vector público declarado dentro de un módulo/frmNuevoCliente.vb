Public Class frmNuevoCliente
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If IND < 10 Then
            clientes(IND).codigo = txtCodigo.Text
            clientes(IND).nombre = txtNombre.Text
            clientes(IND).deuda = txtDeuda.Text
            clientes(IND).limite = txtLimite.Text
            IND = IND + 1
            MessageBox.Show("Los datos se cargaron exitosamente")
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDeuda.Text = ""
        txtLimite.Text = ""
    End Sub

    Private Sub ControlarDatos()
        If txtCodigo.Text <> "" And txtDeuda.Text <> "" And txtNombre.Text <> "" And txtLimite.Text <> "" Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtDeuda_TextChanged(sender As Object, e As EventArgs) Handles txtDeuda.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged
        ControlarDatos()
    End Sub
End Class
