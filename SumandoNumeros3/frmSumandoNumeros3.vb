Public Class frmSumandoNumeros3
    Dim x As Integer = 1            'Declaramos esta variable "global" para que esté disponible para todos los procedimientos
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblResultado.Text = ""      'Borra el contenido de la etiqueta
    End Sub

    Private Sub btnSumarWhile_Click(sender As Object, e As EventArgs) Handles btnSumarWhile.Click
        Dim n As Integer = 0        'Variable que tiene el n° que vamos sumando
        Dim r As Integer = 0        'Variable que almacena los resultados

        While n <= txtHasta.Text    'Condición Mientras que
            r = r + n               'Acumulador
            n = n + x               'La variable "x" dependerá de la opción que elija el usuario
        End While
        lblResultado.Text = r       'Muetra el valor de "r"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHasta.TextChanged

    End Sub

    Private Sub btnSumarFor_Click(sender As Object, e As EventArgs) Handles btnSumarFor.Click
        Dim n As Integer = 0        'Variable que tiene el n° que vamos sumando
        Dim r As Integer = 0        'Variable que almacena los resultados

        For n = 0 To txtHasta.Text Step x   'A continuación de Step le damos la variación, en esta caso "x"
            r = r + n               'En este bucle sólo es necesario colocar el incremento de la variable
        Next
        lblResultado.Text = r       'Muetra el valor de "r"
    End Sub

    Private Sub rdbTodosLosNumeros_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTodosLosNumeros.CheckedChanged
        x = 1
    End Sub

    Private Sub rdbMultiplo2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMultiplo2.CheckedChanged
        x = 2
    End Sub

    Private Sub rdbMultiplo5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMultiplo5.CheckedChanged
        x = 5
    End Sub

    Private Sub rdbMultiplo10_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMultiplo10.CheckedChanged
        x = 10
    End Sub
End Class
