Public Class FrmConsultaRepuestos

    Dim objREP As New Repuestos
    Dim MARCA As String = ""
    Dim ORIGEN As String = ""

    Private Sub FrmConsultaRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBMarcas.Items.Add("Todas las marcas")
        objREP.ObtenerMarcas(CBMarcas)
    End Sub

    Private Sub CBMarcas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMarcas.SelectedIndexChanged
        MARCA = CBMarcas.Text.ToUpper
    End Sub

    Private Sub RBNac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNac.CheckedChanged
        ORIGEN = "NACIONAL"
    End Sub

    Private Sub RBImp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBImp.CheckedChanged
        ORIGEN = "IMPORTADO"
    End Sub

    Private Sub RBAmb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAmb.CheckedChanged
        ORIGEN = "AMBOS"
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        objREP.ObtenerRepuestos(Grilla, MARCA, ORIGEN)
    End Sub
End Class