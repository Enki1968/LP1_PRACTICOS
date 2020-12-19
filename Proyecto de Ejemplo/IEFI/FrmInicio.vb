Public Class FrmInicio
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAcercaDe.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Click
        FrmConsultarProduccionDeEmpleado.ShowDialog()
    End Sub

    Private Sub LisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LisToolStripMenuItem.Click
        FrmListarProduccionPorEmpleado.ShowDialog()
    End Sub

    Private Sub CargaAutomaticaDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaAutomaticaDeDatosToolStripMenuItem.Click
        CargaAutomaticaDeDatos()
        MessageBox.Show("Se han cargado los datos correctamente")
    End Sub
End Class
