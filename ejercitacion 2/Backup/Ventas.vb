Public Class Ventas
    Const CANMESAS As Integer = 9
    Const CANMOZOS As Integer = 3

    Dim MOZOS() As String = {"CARDOZO JUAN", "FUNES OCTAVIO", "PAEZ MANUEL"}
    Dim MATVEN(CANMOZOS, CANMESAS) As Decimal


    Dim _mozo As Integer
    Dim _mesa As Integer
    Dim _importe As Decimal


    Public Property mozo() As Integer
        Get
            Return _mozo
        End Get
        Set(ByVal value As Integer)
            _mozo = value
        End Set
    End Property

    Public Property mesa() As Integer
        Get
            Return _mesa
        End Get
        Set(ByVal value As Integer)
            _mesa = value
        End Set
    End Property

    Public Property importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property

    Public Function Habilitar() As Boolean
        Dim VALOR As Boolean = True
        If _mozo < 1 Or _mesa < 1 Or _importe <= 0 Then
            VALOR = False
        End If
        Return VALOR
    End Function
    Public Sub ObtenerMozos(ByVal LBMOZOS As ListBox)
        For Each MOZO As String In MOZOS
            LBMOZOS.Items.Add(MOZO)
        Next
        LBMOZOS.SelectedIndex = 0
    End Sub

    Public Sub ObtenerMesas(ByVal CBMESAS As ComboBox)
        Dim MESA As Integer = 0
        For MESA = 1 To CANMESAS
            CBMESAS.Items.Add(MESA)
        Next
        CBMESAS.SelectedIndex = 0
    End Sub

    Public Sub AgregarVenta()
        MATVEN(_mozo, _mesa) = MATVEN(_mozo, _mesa) + _importe
    End Sub

    Public Sub ObtenerVentas(ByVal GRILLA As DataGridView)
        Dim QUEMESA As Integer = 0
        GRILLA.Columns.Add("Mozos", "Mozos")
        For QUEMESA = 1 To CANMESAS
            GRILLA.Columns.Add(QUEMESA, QUEMESA)
        Next
        GRILLA.Columns.Add("Totales", "Totales")

        For Each UNMOZO As String In MOZOS
            GRILLA.Rows.Add(UNMOZO)
        Next
        GRILLA.Rows.Add("Totales")

        Dim QUEMOZO As Integer = 0
        Dim TMOZO As Decimal = 0
        Dim TMESA As Decimal = 0

        For QUEMOZO = 1 To CANMOZOS
            TMOZO = 0
            For QUEMESA = 1 To CANMESAS
                GRILLA.Item(QUEMESA, QUEMOZO - 1).Value = MATVEN(QUEMOZO, QUEMESA)
                TMOZO = TMOZO + MATVEN(QUEMOZO, QUEMESA)
            Next
            GRILLA.Item(CANMESAS + 1, QUEMOZO - 1).Value = TMOZO
        Next

        For QUEMESA = 1 To CANMESAS
            TMESA = 0
            For QUEMOZO = 1 To CANMOZOS
                TMESA = TMESA + MATVEN(QUEMOZO, QUEMESA)
            Next
            GRILLA.Item(QUEMESA, QUEMOZO - 1).Value = TMESA
        Next

        TMESA = 0
        For QUEMOZO = 1 To CANMOZOS
            TMESA = TMESA + Val(GRILLA.Item(CANMESAS + 1, QUEMOZO - 1).Value)
        Next
        GRILLA.Item(CANMESAS + 1, CANMOZOS).Value = TMESA

    End Sub
End Class
