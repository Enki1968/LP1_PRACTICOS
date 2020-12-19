Public Class frmRepetitivas
    Private Sub btnCompletarLista_Click(sender As Object, e As EventArgs) Handles btnCompletarLista.Click
        Dim m As Integer = 1
        cmbNumeros.Items.Clear()

        While m <= 12
            cmbNumeros.Items.Add(m)
            m = m + 1
        End While

    End Sub

    Private Sub btnCompletarCuadro_Click(sender As Object, e As EventArgs) Handles btnCompletarCuadro.Click
        lstNumeros.Items.Clear()

        For m = 1 To 12
            lstNumeros.Items.Add(m)
        Next
        lstNumeros.Focus()
    End Sub
End Class
