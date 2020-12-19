Public Class frmProcedimientos
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblResultado.Text = ""
        lblResultado.BackColor = Color.MistyRose
    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged
        ControlDeDatos()
    End Sub

    Private Sub txtExponente_TextChanged(sender As Object, e As EventArgs) Handles txtExponente.TextChanged
        ControlDeDatos()
    End Sub

    Private Sub btnCalcularWhile_Click(sender As Object, e As EventArgs) Handles btnCalcularWhile.Click
        Dim base As Integer = txtBase.Text
        Dim exponente As Integer = txtExponente.Text
        Dim obj As New FuncionesMatematicas()

        lblResultado.Text = obj.Potencia(base, exponente)
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
    Private Sub ControlDeDatos()
        If txtBase.Text = "" Or txtExponente.Text = "" Then
            btnCalcularWhile.Enabled = False
            btnCalcularFor.Enabled = False
        Else
            btnCalcularWhile.Enabled = True
            btnCalcularFor.Enabled = True
        End If
    End Sub

    Private Sub frmProcedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
