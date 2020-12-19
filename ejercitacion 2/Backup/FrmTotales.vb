Public Class FrmTotales


    Public Sub New(ByVal objVEN As Ventas)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objVEN.ObtenerVentas(GRILLA)
    End Sub

End Class