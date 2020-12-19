Imports System

Module Program
    Sub Main()
        Dim Pago As Integer = 0
        Dim Interes As Integer = 0
        Dim Importe As Integer = 0

        Console.WriteLine("Escriba el IMPORTE: ")
        Importe = Console.ReadLine()

        Console.WriteLine("Escriba el monto de PAGO: ")
        Pago = Console.ReadLine()

        If Pago < Importe Then
            Interes = Importe * 20 / 100
            Console.WriteLine("Usted deberá pagar la próxima vez: " & (Importe - Pago) + Interes)

        End If
        Console.ReadLine()
    End Sub
End Module
