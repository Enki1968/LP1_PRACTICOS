Public Class frmMeses
    Private Sub cmdMostarMes_Click(sender As Object, e As EventArgs) Handles cmdMostarMes.Click
        Dim m As Integer = txtMes.Text

        Select Case m
            Case 1
                lblNombreMes.Text = "Enero"
            Case 2
                lblNombreMes.Text = "Febrero"
            Case 3
                lblNombreMes.Text = "Marzo"
            Case 4
                lblNombreMes.Text = "Abril"
            Case 5
                lblNombreMes.Text = "Mayo"
            Case 6
                lblNombreMes.Text = "Junio"
            Case 7
                lblNombreMes.Text = "Julio"
            Case 8
                lblNombreMes.Text = "Agosto"
            Case 9
                lblNombreMes.Text = "Setiembre"
            Case 10
                lblNombreMes.Text = "Octubre"
            Case 11
                lblNombreMes.Text = "Noviembre"
            Case 12
                lblNombreMes.Text = "Diciembre"
            Case Else
                lblNombreMes.Text = "Valor incorrecto!, no corresponde a ningún mes."
        End Select
    End Sub

    Private Sub txtMes_TextChanged(sender As Object, e As EventArgs) Handles txtMes.TextChanged
        If txtMes.Text <> "" Then
            cmdMostarMes.Enabled = True
        Else
            cmdMostarMes.Enabled = False
        End If
    End Sub
End Class
