Public Class frmSistemaSocios
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgregarNuevoSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoSocioToolStripMenuItem.Click
        frmAgregarNuevoSocio.Show()
    End Sub

    Private Sub ListadoGeneralDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeSociosToolStripMenuItem.Click
        frmListadoGeneralDeSocios.Show()
    End Sub

    Private Sub ConsultaDeDatosDeUnSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDatosDeUnSocioToolStripMenuItem.Click
        frmConsultaDeDatosDeUnSocio.Show()
    End Sub

    Private Sub frmSistemaSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSocios()

    End Sub
End Class
