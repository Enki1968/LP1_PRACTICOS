Public Class FrmAgregarNuevoSocio
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        If IND < 100 Then
            Socios(IND).cod = NUM
            Socios(IND).nombre = txtNombre.Text
            Socios(IND).deuda = txtDeuda.Text
            MessageBox.Show("Socio Agregado")
            NUM = NUM + 1
            IND = IND + 1
        Else
            MessageBox.Show("No se pueden agregar mas socios")
        End If
        LimpiarCampos()
    End Sub
    Private Sub LimpiarCampos()
        txtNombre.Text = ""
        txtDeuda.Text = ""
    End Sub
    Private Sub CorroboraDatos()
        If txtNombre.Text <> "" And txtDeuda.Text <> "" Then
            cmdCargar.Enabled = True
        Else
            cmdCargar.Enabled = False
        End If
    End Sub

End Class