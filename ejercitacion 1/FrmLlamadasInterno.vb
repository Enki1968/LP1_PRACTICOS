Public Class FrmLlamadasInterno

    Public Sub New(ByVal objLLA As Llamadas)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LInterno.Text = objLLA.interno
        LEmpleado.Text = objLLA.empleado
        objLLA.ObtenerLlamadas(Grilla)
    End Sub

    
End Class