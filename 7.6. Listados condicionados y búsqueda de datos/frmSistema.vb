Public Class frmSistema
    Public Sub CargarVectorClientes()
        clientes(IND).codigo = 15
        clientes(IND).nombre = "Juan"
        clientes(IND).limite = 15000
        clientes(IND).deuda = 1500
        IND = IND + 1
        clientes(IND).codigo = 20
        clientes(IND).nombre = "José"
        clientes(IND).limite = 20000
        clientes(IND).deuda = 2000
        IND = IND + 1
        clientes(IND).codigo = 30
        clientes(IND).nombre = "Ana"
        clientes(IND).limite = 30000
        clientes(IND).deuda = 3000
        IND = IND + 1
    End Sub

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

    Private Sub ListadoDeClientesDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesDeudoresToolStripMenuItem.Click
        frmListadoClientesDeudores.Show()
    End Sub

    Private Sub BúsquedaDeUnClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BúsquedaDeUnClienteToolStripMenuItem.Click
        frmBusquedaCliente.Show()
    End Sub
End Class
