Public Class FrmConsultarProduccionDeEmpleado
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmConsultarProduccionDeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        CmbEmpleades.Items.Clear()
        For i = 0 To IndE - 1
            CmbEmpleades.Items.Add(Empleade(i).Nombre)
        Next
        CmbEmpleades.SelectedIndex = 0
    End Sub

    Private Sub CmdListar_Click(sender As Object, e As EventArgs) Handles CmdListar.Click
        Dim f As Integer = CmbEmpleades.SelectedIndex
        Dim c As Integer = 0
        Dim Total As Integer = 0


        Grilla.Rows.Clear()
        For c = 0 To IndM - 1
            Grilla.Rows.Add(Maquina(c), CantidadProducida(f, c))
            Total = Total + CantidadProducida(f, c)
        Next

        LblTotalPrudu.Text = Total
    End Sub
End Class