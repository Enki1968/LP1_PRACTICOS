Public Class FrmPedidoLlamada
    Dim objLLA As New Llamadas

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        objLLA.Registrar()
        CBInternos.SelectedIndex = 0
        TBTelefono.Text = ""
        TBMotivo.Text = ""
        CBInternos.Focus()
    End Sub

    Private Sub FrmPedidoLlamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objLLA.ObtenerInternos(CBInternos)
        CBInternos.SelectedIndex = 0
    End Sub

    Private Sub CBInternos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBInternos.SelectedIndexChanged
        objLLA.interno = CBInternos.Text
        BAceptar.Enabled = objLLA.Habilitar
    End Sub

    Private Sub TBTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTelefono.TextChanged
        objLLA.telefono = TBTelefono.Text
        BAceptar.Enabled = objLLA.Habilitar
    End Sub

    Private Sub TBMotivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBMotivo.TextChanged
        objLLA.motivo = TBMotivo.Text
        BAceptar.Enabled = objLLA.Habilitar
    End Sub

    Private Sub BPuntitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPuntitos.Click
        Dim objCON As New FrmLlamadasInterno(objLLA)
        objCON.ShowDialog()
    End Sub
End Class
