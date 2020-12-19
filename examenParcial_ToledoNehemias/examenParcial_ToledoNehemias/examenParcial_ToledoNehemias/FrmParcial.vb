Public Class FrmParcial
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAcercaDe.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AgregarNuevoSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoSocioToolStripMenuItem.Click
        FrmAgregarNuevoSocio.Show()
    End Sub
    Private Sub ListadoGeneralDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeSociosToolStripMenuItem.Click
        FrmListadoGeneralDeSocios.Show()
    End Sub
    Private Sub ConsultaDeDatosDeUnSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDatosDeUnSocioToolStripMenuItem.Click
        FrmConsultaDeDatosDeunSocio.Show()
    End Sub

    Private Sub FrmParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
