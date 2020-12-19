Module DatosGlobales
    Public meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"}
    Public sucursales() As String = {"Sur", "Norte", "Central", "Oriente"}
    Public ventas(11, 3) As Decimal

    Dim r As Random = New Random()
    Public Sub CargarMatriz()
        Dim f As Integer = 0
        Dim c As Integer = 0

        While f < 12
            c = 0
            While c < 4
                ventas(f, c) = r.Next(100, 200)
                c = c + 1
            End While
            f = f + 1
        End While
    End Sub
End Module
