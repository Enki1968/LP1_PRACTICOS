Public Class frmSumandoNumeros2
    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        lblResultado.Text = ""      'Borra el contenido de la etiqueta
    End Sub

    Private Sub cmdSumarWhile_Click(sender As Object, e As EventArgs) Handles cmdSumarWhile.Click
        Dim n As Integer = txtDesde.Text    'Le indicamos a la variable "n" el punto de partida
        Dim r As Integer = 0                'Variable que almacena los resultados

        While n <= txtHasta.Text            'Condición Mientras que
            r = r + n                       'Acumulador
            n = n + 1                       'Contador
        End While
        lblResultado.Text = r               'Muetra el valor de "r"
    End Sub

    Private Sub cmdSumarFor_Click(sender As Object, e As EventArgs) Handles cmdSumarFor.Click
        Dim n As Integer = 0                'Variable que tiene el n° que vamos sumando
        Dim r As Integer = 0                'Variable que almacena los resultados

        For n = txtDesde.Text To txtHasta.Text  'Para n que comienza valiendo lo que el usuario ingreso en txtDesde hasta que valga txtHasta incluido 
            r = r + n                       'Instrucción que acumula (Acumulador)
        Next                                'Me ahorro de colocar el Contador porque Next me pasa al valor siguiente 
        lblResultado.Text = r               'Muetra el valor de "r"

    End Sub
End Class
