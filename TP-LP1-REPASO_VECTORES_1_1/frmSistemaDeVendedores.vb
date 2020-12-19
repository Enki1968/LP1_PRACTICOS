Public Class frmSistemaDeVendedores
    Public Sub CargarVendedores()
        vendedor(IND).codigo = 1
        vendedor(IND).nombre = "Sanchez Carlos"
        vendedor(IND).sueldo = 25000
        IND += 1
        vendedor(IND).codigo = 2
        vendedor(IND).nombre = "Rodriguez Roberto"
        vendedor(IND).sueldo = 30000
        IND += 1
        vendedor(IND).codigo = 3
        vendedor(IND).nombre = "Gonzalez Juan"
        vendedor(IND).sueldo = 40000
        IND += 1
        vendedor(IND).codigo = 4
        vendedor(IND).nombre = "Pastre Sergio"
        vendedor(IND).sueldo = 50000
        IND += 1
        vendedor(IND).codigo = 5
        vendedor(IND).nombre = "Pereyra José"
        vendedor(IND).sueldo = 30000
        IND += 1
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub AgregarNuevoVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoVendedorToolStripMenuItem.Click
        frmAgregarVendedor.Show()
    End Sub

    Private Sub ListadoGeneralDeVendoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeVendoresToolStripMenuItem.Click
        frmListadoGralVendedores.Show()
    End Sub

    Private Sub ConsultaDeDatosDeUnVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDatosDeUnVendedorToolStripMenuItem.Click
        frmConsultaVendedor.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmSistemaDeVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVendedores()
    End Sub

End Class
