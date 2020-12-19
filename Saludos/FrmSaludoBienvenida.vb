Public Class frmSaludoBienvenida
    Private Sub frmSaludoBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        lblMensaje.Text = "Hola!!!...¿como te va? "
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblMensaje.Text = ""
    End Sub
End Class
