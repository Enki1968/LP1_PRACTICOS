Public Class frmVistaPrevia
    Private Sub rdbRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRojo.CheckedChanged
        lblTexto.ForeColor = Color.Red
    End Sub

    Private Sub rdbVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVerde.CheckedChanged
        lblTexto.ForeColor = Color.Green
    End Sub

    Private Sub rdbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAzul.CheckedChanged
        lblTexto.ForeColor = Color.Blue
    End Sub

    Private Sub rdbCeleste_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCeleste.CheckedChanged
        lblTexto.BackColor = Color.LightBlue
    End Sub

    Private Sub rdbRosa_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRosa.CheckedChanged
        lblTexto.BackColor = Color.Pink
    End Sub

    Private Sub rdbAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAmarillo.CheckedChanged
        lblTexto.BackColor = Color.Yellow
    End Sub
End Class
