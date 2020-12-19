Module RegistroVendedor
    Public Structure RegistroVendedor
        Dim codigo As Integer
        Dim nombre As String
        Dim sueldo As Decimal
    End Structure
    Public vendedor(100) As RegistroVendedor
    Public IND As Integer = 0
End Module
