Public Class Form1
    Dim CON As Contacto
    Dim i As Integer = 0
    Dim Contador As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim CON.Nombre(2)
        ReDim CON.Numero(2)
    End Sub

    Private Sub cmdRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistrar.Click
        If i <= 2 Then
            CON.Nombre(i) = txtNombre.Text
            CON.Numero(i) = txtNumero.Text

            i += 1
        End If

        If i > 2 Then
            MessageBox.Show("Registros completos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdRegistrar.Enabled = False
        End If

        txtNombre.Text = ""
        txtNumero.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Contador = 0
        lst.Items.Clear()

        Do While Contador < 3
            lst.Items.Add(CON.Nombre(Contador) & " " & CON.Numero(Contador))
            Contador += 1
        Loop


    End Sub
End Class
