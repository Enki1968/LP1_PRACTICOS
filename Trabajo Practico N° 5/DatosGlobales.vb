Module DatosGlobales
    Public empleado() As String = {"Garcia, Leonardo", "Perez, David", "Fernández, Franco", "Carrizo, Alejandra", "Ortega, Marina"}
    Public maquina() As String = {"GH-156", "JM-25-80", "ZK-1900"}
    Public cantidadproducida(5, 3) As Integer

    Dim r As Random = New Random()
    Public Sub CargaAutomaticaDatos()
        Dim f As Integer = 0
        Dim c As Integer = 0

        While f < 5
            c = 0
            While c < 3
                cantidadproducida(f, c) = r.Next(0, 100)
                c = c + 1
            End While
            f = f + 1
        End While
    End Sub
End Module
