Public Class FrmLlamadasInterno

    Public Sub New(ByVal objLLA As Llamadas)

        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
        LInterno.Text = objLLA.interno
        LEmpleado.Text = objLLA.empleado
        objLLA.ObtenerLlamadas(Grilla)
    End Sub

    
End Class