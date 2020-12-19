Public Class frmListadoGeneralDeSocios
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim i As Integer = 0
        Dim tot_deuda As Decimal = 0
        Dim interes As Decimal = 0
        Dim v As Decimal = 0
        dgvSocios.Rows.Clear()

        While i < IND
            interes = socios(i).deuda * 15 / 100
            dgvSocios.Rows.Add(socios(i).codigo, socios(i).nombre, socios(i).deuda, interes)
            tot_deuda = tot_deuda + socios(i).deuda
            v = v + interes
            i = i + 1
        End While
        lblImporteTotalDeuda.Text = tot_deuda
        lblImporteTotalIntereses.Text = v
        lblCantidadSocios.Text = i
        'cmdListar.Enabled = False
    End Sub
End Class