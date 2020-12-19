Public Class frmConsultaDeDatosDeUnSocio
    Private Sub frmConsultaDeDatosDeUnSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        cmbSocios.Items.Clear()

        While i < IND
            cmbSocios.Items.Add(socios(i).nombre)
            i = i + 1
        End While
        cmbSocios.SelectedIndex = 0
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As Integer = cmbSocios.SelectedIndex
        lblCodigo.Text = socios(i).codigo
        lblDeuda.Text = socios(i).deuda
    End Sub

End Class