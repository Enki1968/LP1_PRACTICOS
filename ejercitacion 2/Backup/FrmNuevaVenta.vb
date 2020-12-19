Public Class FrmNuevaVenta

    Dim objVEN As New Ventas
    Private Sub FrmNuevaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objVEN.ObtenerMozos(LBMozos)
        objVEN.ObtenerMesas(CBMesas)
    End Sub

    Private Sub LBMozos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBMozos.SelectedIndexChanged
        objVEN.mozo = LBMozos.SelectedIndex + 1
    End Sub

    
    Private Sub CBMesas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMesas.SelectedIndexChanged
        objVEN.mesa = CBMesas.Text
    End Sub

    Private Sub TBImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBImporte.TextChanged
        objVEN.importe = Val(TBImporte.Text)
        BAgregar.Enabled = objVEN.Habilitar
    End Sub

    Private Sub BAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar.Click
        objVEN.AgregarVenta()
        Inicializar()
        LBMozos.Focus()
    End Sub

    Private Sub Inicializar()
        LBMozos.SelectedIndex = 0
        CBMesas.SelectedIndex = 0
        TBImporte.Text = ""

    End Sub

    Private Sub BTotales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTotales.Click
        Dim objTOT As New FrmTotales(objVEN)
        objTOT.ShowDialog()
    End Sub
End Class
