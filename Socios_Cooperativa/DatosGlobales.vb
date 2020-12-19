Module DatosGlobales
    Public Structure RegistroSocio
        Dim codigo As Integer
        Dim nombre As String
        Dim deuda As Decimal
    End Structure

    Public socios(100) As RegistroSocio
    Public IND As Integer = 0

    Public Sub CargarSocios()
        socios(IND).codigo = 1
        socios(IND).nombre = "Sanchez Carlos"
        socios(IND).deuda = 1000
        IND += 1
        socios(IND).codigo = 2
        socios(IND).nombre = "Rodriguez Alberto"
        socios(IND).deuda = 1500
        IND += 1
        socios(IND).codigo = 3
        socios(IND).nombre = "Albelo Ricardo"
        socios(IND).deuda = 1300
        IND += 1
        socios(IND).codigo = 4
        socios(IND).nombre = "Pereyra Silvana"
        socios(IND).deuda = 900
        IND += 1
        socios(IND).codigo = 5
        socios(IND).nombre = "Palacios Sofia"
        socios(IND).deuda = 1100
        IND += 1
    End Sub
End Module
