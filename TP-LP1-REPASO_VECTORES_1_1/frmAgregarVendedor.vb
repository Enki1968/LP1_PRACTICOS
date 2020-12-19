Public Class frmAgregarVendedor
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        If IND < 100 Then
            vendedor(IND).codigo = txtCodigo.Text
            vendedor(IND).nombre = txtNombre.Text
            vendedor(IND).sueldo = txtSueldo.Text
            IND = IND + 1
            MessageBox.Show("Los datos se cargaron exitosamente")
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtSueldo.Text = ""
    End Sub

    Private Sub Activar_Boton()
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtSueldo.Text <> "" Then
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

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged
        Activar_Boton()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtNombre.Select()
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtSueldo.Select()
        Else
            If Char.IsLetter(e.KeyChar) Or e.KeyChar = " " Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtNombre.Select()
        Else
            If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class