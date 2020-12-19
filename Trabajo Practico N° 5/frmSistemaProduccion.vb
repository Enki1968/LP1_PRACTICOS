Public Class frmSistemaProduccion
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub CargaAutomáticaDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaAutomáticaDeDatosToolStripMenuItem.Click
        CargaAutomaticaDatos()
        MessageBox.Show("Se han cargado los datos correctamente")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Click
        frmConsultaCantidadProducidaEmpleado.Show()
    End Sub

    Private Sub ListarTotalProducidoEnCadaMáquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarTotalProducidoEnCadaMáquinaToolStripMenuItem.Click
        frmListarTotalProducido.Show()
    End Sub
End Class
