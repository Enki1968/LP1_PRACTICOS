Public Class FrmListadoGeneralDeSocios
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        dgvListadoSocios.Rows.Clear()
        Dim acum As Integer = 0
        Dim cont As Integer = 0
        Dim interes As Integer = 0
        Dim acInt As Integer = 0
        For i = 0 To IND - 1
            interes = Socios(i).deuda * 15 / 100
            dgvListadoSocios.Rows.Add(Socios(i).cod, Socios(i).nombre, Socios(i).deuda, interes)
            acum = acum + Socios(i).deuda
            cont = cont + 1
            acInt = acInt + interes
        Next
        lblDeuda.Text = acum
        lblIntereses.Text = acInt
        lblSocios.Text = cont
    End Sub
End Class