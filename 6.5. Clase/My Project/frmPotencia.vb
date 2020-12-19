Public Class frmPotencia
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblResultado.Text = ""
        lblResultado.BackColor = Color.MistyRose
    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged
        If txtBase.Text = "" Or txtExponente.Text = "" Then 'Verifica si las cajas de texto estan vacias, si lo están, deshabilita los btn y si ambas estan escritas habilita los btn
            btnCalcularWhile.Enabled = False
            btnCalcularFor.Enabled = False
        Else
            btnCalcularWhile.Enabled = True
            btnCalcularFor.Enabled = True
        End If
    End Sub

    Private Sub txtExponente_TextChanged(sender As Object, e As EventArgs) Handles txtExponente.TextChanged
        If txtBase.Text = "" Or txtExponente.Text = "" Then 'Verifica si las cajas de texto estan vacias, si lo están, deshabilita los btn y si ambas estan escritas habilita los btn
            btnCalcularWhile.Enabled = False
            btnCalcularFor.Enabled = False
        Else
            btnCalcularWhile.Enabled = True
            btnCalcularFor.Enabled = True
        End If
    End Sub

    Private Sub btnCalcularWhile_Click(sender As Object, e As EventArgs) Handles btnCalcularWhile.Click
        Dim base As Integer = txtBase.Text
        Dim exponente As Integer = txtExponente.Text
        Dim cantidad As Integer = 0         'Esta variable lleva la cantidad de productos que llevo haciendo
        Dim resultado As Integer = 1        'A esta variable la inicializamos con 1, ya que en el producto es el elemento neutro,  puesto que si ponemos cero, al multiplicar nos daría cero
        While cantidad < exponente
            resultado = resultado * base
            cantidad = cantidad + 1
        End While
        lblResultado.Text = resultado
        lblResultado.BackColor = Color.White

    End Sub

    Private Sub btnCalcularFor_Click(sender As Object, e As EventArgs) Handles btnCalcularFor.Click
        Dim base As Integer = txtBase.Text
        Dim exponente As Integer = txtExponente.Text
        Dim cantidad As Integer = 0
        Dim resultado As Integer = 1

        For cantidad = 1 To exponente
            resultado = resultado * base
        Next
        lblResultado.Text = resultado
        lblResultado.BackColor = Color.White
    End Sub
End Class
