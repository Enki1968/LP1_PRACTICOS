Module RegistroEmpleado
    Public Structure RegEmpleado
        Dim codigo As Integer
        Dim nombre As String
        Dim categoria As Integer
        Dim sueldo As Decimal
    End Structure

    Public empleados(99) As RegEmpleado 'Se pide 100 pero como la primera posición del vector es cero entonces 99 = 100 elementos
    Public IND As Integer = 0

    Public Sub CargarEmpleados()
        empleados(IND).codigo = 1
        empleados(IND).nombre = "Sanchez Carlos"
        empleados(IND).categoria = 2
        empleados(IND).sueldo = 1500
        IND += 1
        empleados(IND).codigo = 2
        empleados(IND).nombre = "Rodriguez Roberto"
        empleados(IND).categoria = 1
        empleados(IND).sueldo = 1000
        IND += 1
        empleados(IND).codigo = 3
        empleados(IND).nombre = "Gonzalez Juan"
        empleados(IND).categoria = 1
        empleados(IND).sueldo = 1000
        IND += 1
        empleados(IND).codigo = 4
        empleados(IND).nombre = "Pastre Sergio"
        empleados(IND).categoria = 1
        empleados(IND).sueldo = 1000
        IND += 1
        empleados(IND).codigo = 5
        empleados(IND).nombre = "Pereyra José"
        empleados(IND).categoria = 2
        empleados(IND).sueldo = 1500
        IND += 1
        empleados(IND).codigo = 6
        empleados(IND).nombre = "Sosa Franco"
        empleados(IND).categoria = 4
        empleados(IND).sueldo = 3000
        IND += 1
        empleados(IND).codigo = 7
        empleados(IND).nombre = "Rivera Eduardo"
        empleados(IND).categoria = 2
        empleados(IND).sueldo = 1500
        IND += 1
        empleados(IND).codigo = 8
        empleados(IND).nombre = "Aguilera Agustin"
        empleados(IND).categoria = 3
        empleados(IND).sueldo = 2000
        IND += 1
        empleados(IND).codigo = 9
        empleados(IND).nombre = "Vidal Cecilia"
        empleados(IND).categoria = 3
        empleados(IND).sueldo = 2000
        IND += 1
        empleados(IND).codigo = 10
        empleados(IND).nombre = "Torres Susana"
        empleados(IND).categoria = 4
        empleados(IND).sueldo = 3000
        IND += 1
    End Sub

End Module
