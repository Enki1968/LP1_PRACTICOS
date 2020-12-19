Module DatosGlobales
    Public Structure RegCliente
        Dim codigo As Integer
        Dim nombre As String
        Dim limite As Decimal
        Dim deuda As Decimal
    End Structure
    Public clientes(9) As RegCliente
    Public IND As Integer = 0
    Public Sub CargarVectorClientes()
        clientes(IND).codigo = 15
        clientes(IND).nombre = "Juan"
        clientes(IND).limite = 15000
        clientes(IND).deuda = 1500
        IND = IND + 1
        clientes(IND).codigo = 20
        clientes(IND).nombre = "José"
        clientes(IND).limite = 20000
        clientes(IND).deuda = 2000
        IND = IND + 1
        clientes(IND).codigo = 30
        clientes(IND).nombre = "Ana"
        clientes(IND).limite = 30000
        clientes(IND).deuda = 3000
        IND = IND + 1
    End Sub

End Module
