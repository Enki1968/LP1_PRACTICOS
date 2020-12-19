Public Class Repuestos
    Dim _repuesto As String
    Dim _nombre As String
    Dim _marca As String
    Dim _origen As String
    Dim _precio As Decimal

    Dim MARCAS() As String = {"Chevrolet", "Fiat", "Peugeot"}

    Dim _archivo As String

    Public Property repuesto() As String
        Get
            Return _repuesto
        End Get
        Set(ByVal value As String)
            _repuesto = value.Trim
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value.Trim
        End Set
    End Property

    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value.ToUpper
        End Set
    End Property

    Public Property origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value.ToUpper
        End Set
    End Property

    Public Property precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

    Public Sub ObtenerMarcas(ByRef CBMARCAS As ComboBox)
        For Each MARCA As String In MARCAS
            CBMARCAS.Items.Add(MARCA)
        Next
        CBMARCAS.SelectedIndex = 0
    End Sub

    Public Function Habilitar() As Boolean
        Dim VALOR As Boolean = True
        If _repuesto = "" Or _nombre = "" Or _marca = "" Or _origen = "" Or _precio <= 0 Then
            VALOR = False
        End If
        Return VALOR
    End Function

    Public Sub Grabar()
        Dim NUMERO As Integer = 0
        NUMERO = FreeFile()
        FileOpen(NUMERO, _archivo, OpenMode.Append)
        WriteLine(NUMERO, _repuesto, _nombre, _marca, _origen, _precio)
        FileClose(NUMERO)

    End Sub

    Public Function Buscar(ByVal REPUESTO As Long) As Boolean
        Dim ESTA As Boolean = False
        Dim NUMERO As Integer = FreeFile()
        Dim objLEE As New Repuestos
        FileOpen(NUMERO, _archivo, OpenMode.Input)
        Do While Not EOF(NUMERO) And objLEE.repuesto <> REPUESTO
            Input(NUMERO, objLEE.repuesto)
            Input(NUMERO, objLEE.nombre)
            Input(NUMERO, objLEE.marca)
            Input(NUMERO, objLEE.origen)
            Input(NUMERO, objLEE.precio)
            If objLEE.repuesto = REPUESTO Then
                ESTA = True
            End If
        Loop
        FileClose(NUMERO)
        Return ESTA
    End Function
    Public Sub New()
        Dim NUMERO As Integer = 0
        _archivo = "Repuestos.txt"
        NUMERO = FreeFile()
        FileOpen(NUMERO, _archivo, OpenMode.Append)
        FileClose(NUMERO)

    End Sub

    Public Sub ObtenerRepuestos(ByRef GRILLA As DataGridView, ByVal MARCA As String, ByVal ORIGEN As String)
        Dim NUMERO As Integer = FreeFile()
        Dim objLEE As New Repuestos
        FileOpen(NUMERO, _archivo, OpenMode.Input)
        GRILLA.Rows.Clear()
        Do While Not EOF(NUMERO)
            Input(NUMERO, objLEE.repuesto)
            Input(NUMERO, objLEE.nombre)
            Input(NUMERO, objLEE.marca)
            Input(NUMERO, objLEE.origen)
            Input(NUMERO, objLEE.precio)
            If (MARCA = "TODAS LAS MARCAS" Or MARCA = objLEE.marca) And (ORIGEN = "AMBOS" Or ORIGEN = objLEE.origen) Then
                GRILLA.Rows.Add(objLEE.repuesto, objLEE.nombre, objLEE.marca, objLEE.origen, objLEE.precio)
            End If
        Loop
        FileClose(NUMERO)

    End Sub
End Class
