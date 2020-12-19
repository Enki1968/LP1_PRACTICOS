Public Class frmPrincipal

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Visible = True
        Me.Close()
    End Sub
End Class