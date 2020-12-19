Public Class frmGestionDeClientes
    Private Structure RegCliente
        Dim codigo As Integer
        Dim Nombre As String
        Dim deuda As Decimal
        Dim limite As Decimal
    End Structure

    Dim clientes(9) As RegCliente
    Dim IND As Integer = 0

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If IND < 10 Then
            clientes(IND).codigo = txtCodigo.Text
            clientes(IND).Nombre = txtNombre.Text
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
        Listar()
    End Sub

    Private Sub Listar()
        Dim i As Integer = 0
        Dim total As Decimal = 0
        dgvClientes.Rows.Clear()
        While i < IND
            dgvClientes.Rows.Add(clientes(i).codigo, clientes(i).Nombre, clientes(i).limite, clientes(i).deuda)
            total = total + clientes(i).deuda
            i = i + 1
        End While
        lblTotal.Text = total
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
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
