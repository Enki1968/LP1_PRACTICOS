Public Class frmAgregarNuevoEmpleado
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click

        If IND < 100 Then
            empleados(IND).codigo = txtCodigo.Text
            empleados(IND).nombre = txtNombre.Text
            empleados(IND).categoria = txtCategoria.Text
            empleados(IND).sueldo = txtSueldo.Text
            IND = IND + 1
            MessageBox.Show("Los datos se cargaron exitosamente")
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If

        txtCodigo.Text = ""     'Vaciamos las cajas de texto.
        txtNombre.Text = ""
        txtCategoria.Text = ""
        txtSueldo.Text = ""

    End Sub

    Private Sub Activar_Btn()   'Creamos un procedimiento de usuario o de programador
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtCategoria.Text <> "" And txtSueldo.Text <> "" Then
            cmdCargar.Enabled = True
        Else
            cmdCargar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Activar_Btn()   'Llamamos a que se ejecute el procedimiento Activar_Btn() antes creado con sus respectivas intrucciones
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Activar_Btn()
    End Sub

    Private Sub txtCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtCategoria.TextChanged
        Activar_Btn()
    End Sub

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged
        Activar_Btn()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then 'Si la tecla oprimida es un Enter, me desplazo a la siguiente caja de texto.
            txtNombre.Select()
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then   'Si el caracter ingresado es un número ó una tecla de control entonces...
                e.Handled = False        'Permite el ingreso del dato en la caja de texto.                                    
            Else
                e.Handled = True         'No se carga ese dato en la caja de texto.
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then 'Si la tecla oprimida es un Enter, me desplazo a la siguiente caja de texto.
            txtCategoria.Select()
        Else
            If Char.IsLetter(e.KeyChar) Or e.KeyChar = " " Or Char.IsControl(e.KeyChar) Then   'Si el caracter ingresado es una letra ó una tecla de control entonces...
                e.Handled = False        'Permite el ingreso del dato en la caja de texto.                                    
            Else
                e.Handled = True         'No se carga ese dato en la caja de texto.
            End If
        End If
    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then 'Si la tecla oprimida es un Enter, me desplazo a la siguiente caja de texto.
            txtSueldo.Select()
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then   'Si el caracter ingresado es un número ó una tecla de control entonces...
                e.Handled = False        'Permite el ingreso del dato en la caja de texto.                                    
            Else
                e.Handled = True         'No se carga ese dato en la caja de texto.
            End If
        End If
    End Sub

    Private Sub txtSueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then 'Si la tecla oprimida es un Enter, me desplazo al botón Cargar
            cmdCargar.Select()
        Else
            If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar) Then   'Si el caracter ingresado es un número ó una tecla de control entonces...
                e.Handled = False        'Permite el ingreso del dato en la caja de texto.                                    
            Else
                e.Handled = True         'No se carga ese dato en la caja de texto.
            End If
        End If
    End Sub
End Class