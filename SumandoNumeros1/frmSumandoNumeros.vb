Public Class frmSumandoNumeros
    Private Sub btnSumarWhile_Click(sender As Object, e As EventArgs) Handles btnSumarWhile.Click
        Dim n As Integer = 0        'Variable que tiene el n° que vamos sumando
        Dim r As Integer = 0        'Variable que almacena los resultados

        While n <= txtHasta.Text    'Condición Mientras que
            r = r + n               'Acumulador
            n = n + 1               'Contador
        End While
        lblResultado.Text = r       'Muetra el valor de "r"

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblResultado.Text = ""      'Borra el contenido de la etiqueta
    End Sub

    Private Sub btnSumarFor_Click(sender As Object, e As EventArgs) Handles btnSumarFor.Click
        Dim n As Integer = 0        'Variable que tiene el n° que vamos sumando
        Dim r As Integer = 0        'Variable que almacena los resultados

        For n = 0 To txtHasta.Text  'Para n que comienza en cero Hasta que valga txtHasta
            r = r + n               'En este bucle sólo es necesario colocar el incremento de la variable
        Next                        'Me ahorro de colocar el contador porque Next me pasa al valor siguiente 
        lblResultado.Text = r       'Muetra el valor de "r"
    End Sub
End Class
