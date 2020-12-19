Public Class FrmConsultaDeDatosDeunSocio
    Private Sub FrmConsultaDeDatosDeunSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To IND - 1
            cmbSocios.Items.Add(Socios(i).nombre)
        Next
        cmbSocios.SelectedIndex = 0
    End Sub
    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As Integer = cmbSocios.SelectedIndex
        lblCodigo.Text = Socios(i).cod
        lblDeudaSocio.Text = Socios(i).deuda
    End Sub
End Class