Module FuncionesYProcedimientos
    Public Function Potencia(b As Integer, e As Integer) As Integer
        Dim cantidad As Integer = 0
        Dim resultado As Integer = 1
        While cantidad < e
            resultado = resultado * b
            cantidad = cantidad + 1
        End While

        Return resultado
    End Function

End Module
