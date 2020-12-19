Public Class frmVectores

    Dim personas(9) As String   'Escribo 9, ya que, la primer posición del vector es cero, por lo tanto me representa 10.
    Dim indice As Integer = 0   'Los índices siempre son del tipo Entero.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If indice < 10 Then
            personas(indice) = txtNombreApellido.Text
            indice = indice + 1     'Tambien es válido colocar indice += 1
            MessageBox.Show("Datos cargados correctamente")
            txtNombreApellido.Text = ""
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If

    End Sub

    Private Sub txtNombreApellido_TextChanged(sender As Object, e As EventArgs) Handles txtNombreApellido.TextChanged
        If txtNombreApellido.Text <> "" Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListarWhile.Click
        Dim i As Integer = 0        'Indice local para usar exclusivamente con el listado.
        LstPersonas.Items.Clear()
        While i < indice
            LstPersonas.Items.Add(personas(i))
            i = i + 1
        End While
    End Sub

    Private Sub btnListarFor_Click(sender As Object, e As EventArgs) Handles btnListarFor.Click
        LstPersonas.Items.Clear()
        For i = 0 To indice - 1     'Para que llegue solamente hasta la posición del último dato cargado.
            LstPersonas.Items.Add(personas(i))
        Next
    End Sub
End Class
