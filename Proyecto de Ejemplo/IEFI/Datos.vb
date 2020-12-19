Module Datos
    Public Structure RegistroEmpleades
        Dim Codigo As Integer
        Dim Nombre As String
    End Structure

    Public Empleade(4) As RegistroEmpleades
    Public Maquina(2) As String
    Public CantidadProducida(4, 2) As Integer
    Public IndE As Integer = 0
    Public IndM As Integer = 0
    Public IndBusqueda As Integer = 0

    Public Function CargaAutomaticaDeDatos()
        Dim R As New Random
        Dim f As Integer = 0
        Dim c As Integer = 0

        Empleade(0).Codigo = 15
        Empleade(0).Nombre = "Garcia, Leonardo"
        Empleade(1).Codigo = 80
        Empleade(1).Nombre = "Perez, David"
        Empleade(2).Codigo = 136
        Empleade(2).Nombre = "Fernandez, Franco"
        Empleade(3).Codigo = 458
        Empleade(3).Nombre = "Carrizo, Alejandra"
        Empleade(4).Codigo = 983
        Empleade(4).Nombre = "Ortega, Marina"

        IndE = 5

        Maquina(0) = "GH-153"
        Maquina(1) = "JM-25-80"
        Maquina(2) = "Zk - 1900"

        IndM = 3

        For f = 0 To IndE - 1
            For c = 0 To IndM - 1
                CantidadProducida(f, c) = R.Next(1, 101)
            Next
        Next

    End Function
End Module
