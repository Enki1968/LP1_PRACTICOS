Public Class FrmTotales


    Public Sub New(ByVal objVEN As Ventas)

        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
        objVEN.ObtenerVentas(GRILLA)
    End Sub

End Class