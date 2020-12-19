Module DatosGlobales
    Public Structure RegistroSocio
        Dim cod As Integer
        Dim nombre As String
        Dim deuda As Decimal
    End Structure
    Public Socios(100) As RegistroSocio
    Public IND As Integer = 0
    Public NUM As Integer = 1

End Module
