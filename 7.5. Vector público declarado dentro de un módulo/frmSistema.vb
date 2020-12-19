Public Class frmSistema
    Private Sub AgregarNuevosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevosClientesToolStripMenuItem.Click
        frmNuevoCliente.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        frmListadoClientes.Show()
    End Sub

    Private Sub ConsultaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeClientesToolStripMenuItem.Click
        frmConsultaClientes.Show()
    End Sub

    Private Sub DatosDelProgramadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelProgramadorToolStripMenuItem.Click
        frmDatosProgramador.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
