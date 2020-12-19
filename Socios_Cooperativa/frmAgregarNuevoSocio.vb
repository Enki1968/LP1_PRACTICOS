Public Class frmAgregarNuevoSocio
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        If IND < 100 Then
            socios(IND).codigo = txtCodigo.Text
            socios(IND).nombre = txtNombre.Text
            socios(IND).deuda = txtDeuda.Text
            IND = IND + 1
            MessageBox.Show("Los datos se cargaron exitosamente")
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDeuda.Text = ""
    End Sub

    Private Sub Activar_Boton()
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtDeuda.Text <> "" Then
            cmdCargar.Enabled = True
        Else
            cmdCargar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Activar_Boton()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Activar_Boton()
    End Sub

    Private Sub txtDeuda_TextChanged(sender As Object, e As EventArgs) Handles txtDeuda.TextChanged
        Activar_Boton()
    End Sub
End Class