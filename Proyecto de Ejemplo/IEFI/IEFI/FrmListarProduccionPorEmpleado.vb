Public Class FrmListarProduccionPorEmpleado
    Private Sub CmbListar_Click(sender As Object, e As EventArgs) Handles CmbListar.Click
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim Total As Integer = 0
        Dim Suma As Integer = 0

        Grilla.Rows.Clear()
        Suma = 0
        For f = 0 To IndE - 1
            Total = 0
            For c = 0 To IndM - 1
                Total = Total + CantidadProducida(f, c)
            Next
            Grilla.Rows.Add(Empleade(f).Nombre, Total)
            Suma = Suma + Total
        Next
        LblTotalPrudu.Text = Suma
        LblPromProduc.Text = Suma / IndE - 1

    End Sub
End Class