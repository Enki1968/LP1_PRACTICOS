Public Class Llamadas
    Private Const MAXPED As Integer = 100
    Private Const MAXINT As Integer = 10

    Private _interno As Integer
    Private _telefono As String
    Private _motivo As String

    Private _empleado As String


    Public Property interno() As Integer
        Get
            Return _interno
        End Get
        Set(ByVal value As Integer)
            If value > 0 And value <= MAXINT Then
                _interno = value
            End If
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property

    Public ReadOnly Property empleado() As String
        Get
            Return EMPLEADOS(_interno - 1)
        End Get
    End Property

    Private Structure TIPOPEDIDOS
        Public hora As String
        Public interno As Integer
        Public telefono As String
        Public motivo As String
    End Structure


    Dim PEDIDOS(MAXPED) As TIPOPEDIDOS
    Dim EMPLEADOS() As String = {"Ana", "Carla", "Estela", "Josefina", "Luisa", "Marta", "Patricia", "Renata", "Sara", "Yanina"}

    Dim POS As Integer = 0


    Public Sub ObtenerInternos(ByVal CBINTERNOS As ComboBox)
        Dim NI As Integer = 0
        For NI = 1 To MAXINT
            CBINTERNOS.Items.Add(NI)
        Next
    End Sub

    Public Function Habilitar() As Boolean
        Dim VALOR As Boolean = True
        If _interno < 1 Or _interno > MAXINT Or _telefono = "" Or _motivo = "" Or POS = MAXPED Then
            VALOR = False
        End If
        Return VALOR
    End Function

    Public Sub Registrar()
        POS = POS + 1
        PEDIDOS(POS).hora = DateAndTime.TimeOfDay
        PEDIDOS(POS).interno = _interno
        PEDIDOS(POS).telefono = _telefono
        PEDIDOS(POS).motivo = _motivo
    End Sub

    Public Sub ObtenerLlamadas(ByVal GRILLA As DataGridView)
        Dim X As Integer = 0
        GRILLA.Rows.Clear()
        For X = 1 To POS
            If _interno = PEDIDOS(X).interno Then
                GRILLA.Rows.Add(PEDIDOS(X).hora, PEDIDOS(X).telefono, PEDIDOS(X).motivo)
            End If
        Next

    End Sub

End Class
