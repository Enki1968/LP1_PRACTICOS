Public Class frmGestionDeEmpleados
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AgregarNuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoEmpleadoToolStripMenuItem.Click
        frmAgregarNuevoEmpleado.Show()
    End Sub

    Private Sub ListadoGeneralDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeEmpleadoToolStripMenuItem.Click
        frmListadoGeneral.Show()
    End Sub

    Private Sub ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosDeUnaCategoríaToolStripMenuItem.Click
        frmListadoPorCategoria.Show()
    End Sub

    Private Sub ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Click
        frmListadoConSueldoMayor.Show()
    End Sub

    Private Sub ConsultaDeDatosDeUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDatosDeUnEmpleadoToolStripMenuItem.Click
        frmColsultaDatosEmpleado.Show()
    End Sub

    Private Sub BúsquedaDeUnEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BúsquedaDeUnEmpleadoToolStripMenuItem.Click
        frmBusquedaEmpleado.Show()
    End Sub

    Private Sub frmGestionDeEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpleados()
    End Sub
End Class
