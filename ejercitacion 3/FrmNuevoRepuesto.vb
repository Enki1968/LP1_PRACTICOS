Public Class FrmNuevoRepuesto
    Dim objREP As New Repuestos
    Private Sub FrmNuevoRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objREP.ObtenerMarcas(CBMarcas)
    End Sub

    Private Sub TBRepuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBRepuesto.TextChanged
        objREP.repuesto = TBRepuesto.Text
        BAceptar.Enabled = objREP.Habilitar
    End Sub

    Private Sub TBNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNombre.TextChanged
        objREP.nombre = TBNombre.Text
        BAceptar.Enabled = objREP.Habilitar
    End Sub

    Private Sub CBMarcas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMarcas.SelectedIndexChanged
        objREP.marca = CBMarcas.Text
    End Sub

    Private Sub RBNac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNac.CheckedChanged
        objREP.origen = "NACIONAL"
    End Sub

    Private Sub RBImp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBImp.CheckedChanged
        objREP.origen = "IMPORTADO"
    End Sub

    Private Sub TBPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPrecio.TextChanged
        objREP.precio = Val(TBPrecio.Text)
        BAceptar.Enabled = objREP.Habilitar
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Dim ESTA As Boolean = False
        ESTA = objREP.Buscar(TBRepuesto.Text.Trim)
        If ESTA = True Then
            MessageBox.Show("El código de repuesto ya está grabado ...", "Error")
        Else
            objREP.Grabar()
            Inicializar()
            TBRepuesto.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        TBRepuesto.Text = ""
        TBNombre.Text = ""
        TBPrecio.Text = ""
        CBMarcas.SelectedIndex = 0
        RBNac.Checked = True
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        Inicializar()
        TBRepuesto.Focus()
    End Sub

    Private Sub BConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsultar.Click
        Dim objCR As New FrmConsultaRepuestos
        objCR.ShowDialog()
    End Sub
End Class
