Public Class frmCalculoImc

    Private Sub frmCalculoImc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPeso.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim P As Single = txtPeso.Text
        Dim A As Single = txtAltura.Text

        Dim IMC As Single = P / (A * A)

        lblImc.Text = IMC
        lblImc.BackColor = Color.White

        If (IMC <= 22) Then
            lblDiagnostico.Text = "El paciente presenta menos del peso ideal"
            lblDiagnostico.BackColor = Color.Gold
        Else
            If (IMC <= 28) Then
                lblDiagnostico.Text = "El paciente está en su peso ideal"
                lblDiagnostico.BackColor = Color.LimeGreen
            Else
                If (IMC <= 35) Then
                    lblDiagnostico.Text = "El paciente presenta un ligero sobrepeso"
                    lblDiagnostico.BackColor = Color.Gold
                Else
                    lblDiagnostico.Text = "El paciente está excedido de peso"
                    lblDiagnostico.BackColor = Color.OrangeRed
                End If
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        txtPeso.Text = ""
        txtAltura.Text = ""
        lblImc.Text = ""
        lblImc.BackColor = Color.Transparent
        lblDiagnostico.Text = ""
        lblDiagnostico.BackColor = Color.Transparent

    End Sub
End Class
