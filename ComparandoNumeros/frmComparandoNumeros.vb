Public Class frmComparandoNumeros
    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        Dim a As Integer = txtA.Text
        Dim b As Integer = txtB.Text

        If a > b Then
            lblResultados.Text = "A es mayor"
            lblResultados.BackColor = Color.LightBlue
        Else
            If a < b Then
                lblResultados.Text = "A es menor"
                lblResultados.BackColor = Color.LightGreen
            Else
                lblResultados.Text = "IGUAL"
                lblResultados.BackColor = Color.LightSalmon
            End If
        End If

    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
        If txtA.Text <> "" And txtB.Text <> "" Then
            btnComparar.Enabled = True
        Else
            btnComparar.Enabled = False
        End If
    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
        If txtA.Text <> "" And txtB.Text <> "" Then
            btnComparar.Enabled = True
        Else
            btnComparar.Enabled = False
        End If
    End Sub
End Class
