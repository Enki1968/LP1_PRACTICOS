Public Class frm00Principal
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDelSistema.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CargaDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaDeVentasToolStripMenuItem.Click
        frm01CargaVentas.Show()
    End Sub

    Private Sub ConsultaDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeVentasToolStripMenuItem.Click
        frm02ConsultaDeUnaVenta.Show()
    End Sub

    Private Sub ListadoDeTotalesDeVentasPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTotalesDeVentasPorMesToolStripMenuItem.Click
        frm03ConsultaVentasDeUnMes.Show()
    End Sub

    Private Sub ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem.Click
        frm04ConsultarVentasDeUnaSucursal.Show()
    End Sub
End Class