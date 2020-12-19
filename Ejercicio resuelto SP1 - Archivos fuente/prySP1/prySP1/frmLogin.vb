Public Class frmLogin

    Dim USUARIO As String = ""
    Dim CONTRASEÑA As String = ""
    Dim VECES As Integer = 0

    Const USUARIO1 As String = "Administrador"
    Const CONTRASEÑA1 As String = "adm135$"

    Const USUARIO2 As String = "Operador"
    Const CONTRASEÑA2 As String = "op246$"


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        USUARIO = txtUsuario.Text.Trim
        CONTRASEÑA = txtContraseña.Text.Trim

        If (USUARIO = USUARIO1 And CONTRASEÑA = CONTRASEÑA1) Or (USUARIO = USUARIO2 And CONTRASEÑA = CONTRASEÑA2) Then
            Me.Visible = False
            frmPrincipal.Show()
        Else
            VECES = VECES + 1
            MessageBox.Show("Verifique el usuario o contraseña", "Acceso Denegado")

        End If

        If VECES = 3 Then
            txtUsuario.Enabled = False
            txtContraseña.Enabled = False
            btnAceptar.Enabled = False
            MessageBox.Show("Se ha bloqueado el acceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
