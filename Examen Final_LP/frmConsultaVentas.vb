Public Class frmConsultaVentas
    Public vecMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"}
    Public matVentas(3, 11) As Decimal

    Dim r As Random = New Random()
    Public Sub CargarMatrizVentas()
        Dim f As Integer = 0
        Dim c As Integer = 0

        While f < 4
            c = 0
            While c < 12
                matVentas(f, c) = r.Next(1000, 5000)
                c = c + 1
            End While
            f = f + 1
        End While
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMatrizVentas()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim total As Decimal = 0
        Dim totalgeneral As Decimal = 0
        dgvConsulta.Rows.Clear()

        While c < 12
            total = 0
            f = 0
            While f < 4
                total = total + matVentas(f, c)
                f = f + 1
            End While
            dgvConsulta.Rows.Add(vecMeses(c), total, (total / 4))
            totalgeneral = totalgeneral + total
            c = c + 1
        End While
        lblTotal.Text = totalgeneral.ToString("C")
        lblPromedio.Text = (totalgeneral / 12).ToString("C")

    End Sub
End Class
