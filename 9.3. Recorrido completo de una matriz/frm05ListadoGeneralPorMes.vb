Public Class frm05ListadoGeneralPorMes
    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim total As Decimal = 0
        Dim totalgeneral As Decimal = 0
        dgvVentas.Rows.Clear()

        While f < 12
            total = 0
            c = 0
            While c < 4
                total = total + ventas(f, c)
                c = c + 1
            End While
            dgvVentas.Rows.Add(meses(f), total)
            totalgeneral = totalgeneral + total
            f = f + 1
        End While
        lblTotalVentas.Text = totalgeneral.ToString("C")
    End Sub

    Private Sub frm05ListadoGeneralPorMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class