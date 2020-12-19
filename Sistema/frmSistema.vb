Public Class frmSistema
    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        frmListadoClientes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgregarNuevosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevosClientesToolStripMenuItem.Click
        frmAltadeClientes.Show()
    End Sub

    Private Sub AcercaDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDelSistemaToolStripMenuItem.Click
        frmAcercaDelSistema.Show()
    End Sub
End Class
