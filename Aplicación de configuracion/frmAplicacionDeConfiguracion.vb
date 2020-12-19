Public Class frmAplicacionDeConfiguracion
    Private Sub frmAplicacionDeConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCompletarCampos_Click(sender As Object, e As EventArgs) Handles btnCompletarCampos.Click
        txtNombreAplicacion.Text = "Ingrese nombre de aplicacion"
        txtNombreEmpresa.Text = "Ingrese nombre de la empresa"
        txtVersion.Text = "Numero"
        txtDescripcion.Text = "Ingrese la descripcion que desee"
        txtNombreAutor.Text = "Franco Cristian Sosa"
        dtpFecha.Value = Today

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MsgBox("Esta opcion no se encuentra implementada.", MsgBoxStyle.Information, "Informacion")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInfo.Click

    End Sub
End Class
