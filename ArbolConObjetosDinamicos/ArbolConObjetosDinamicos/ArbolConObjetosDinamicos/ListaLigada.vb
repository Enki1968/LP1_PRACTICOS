Public Class ListaLigada
    Dim Pri As Nodo = Nothing
    Dim Ult As Nodo = Nothing
    Dim Nvo As Nodo = Nothing

    Public Sub AgregarNodoLD(ByVal Leg As Integer, ByVal Nom As String, ByVal Ape As String)
        Dim i As Nodo = Pri
        Dim a As Nodo = Pri
        Nvo = New Nodo
        Nvo.Leg = Leg
        Nvo.Nom = Nom
        Nvo.Ape = Ape
        If Pri Is Nothing Then
            Nvo.Sig = Nothing
            Nvo.Ant = Nothing
            Pri = Nvo
            Ult = Nvo
        Else
            If Nvo.Leg < Pri.Leg Then
                Pri.Ant = Nvo
                Nvo.Sig = Pri
                Nvo.Ant = Nothing
                Pri = Nvo
            Else
                If Nvo.Leg > Ult.Leg Then
                    Ult.Sig = Nvo
                    Nvo.Ant = Ult
                    Nvo.Sig = Nothing
                    Ult = Nvo
                Else
                    Do While i.Leg < Nvo.Leg And Not (i.Sig Is Nothing)
                        a = i
                        i = i.Sig
                    Loop
                    Nvo.Ant = a
                    Nvo.Sig = i
                    a.Sig = Nvo
                    i.Ant = Nvo
                End If
            End If
        End If
    End Sub

    Public Sub AgregarNodo(ByVal Leg As Integer, ByVal Nom As String, ByVal Ape As String)
        Nvo = New Nodo
        Dim Aux As Nodo = Pri
        Dim Ant As Nodo = Aux
        Nvo.Leg = Leg
        Nvo.Nom = Nom
        Nvo.Ape = Ape
        If Pri Is Nothing Then
            Pri = Nvo
            Nvo.Sig = Nothing
        Else
            If Leg < Pri.Leg Then
                Nvo.Sig = Pri
                Pri = Nvo
            Else
                Do While Aux.Leg < Leg
                    Ant = Aux
                    Aux = Aux.Sig
                    If Aux Is Nothing Then
                        Exit Do
                    End If
                Loop
                Ant.Sig = Nvo
                Nvo.Sig = Aux
            End If
        End If
    End Sub

    Public Sub listar(ByVal L As ListBox)
        Dim aux As Nodo = Pri
        L.Items.Clear()
        Do While Not (aux Is Nothing)
            L.Items.Add(aux.Leg & " " & aux.Nom & " " & aux.Ape)
            aux = aux.Sig
        Loop
    End Sub

    Public Sub listarTodo(ByVal D As DataGridView)
        Dim aux As Nodo = Pri
        Dim f As Integer = 0
        D.Rows.Clear()
        D.Columns.Clear()
        D.Columns.Add("Legajo", "Legajo")
        D.Columns.Add("Nombre", "nombre")
        D.Columns.Add("Apellido", "Apellido")
        Do While Not (aux Is Nothing)
            D.Rows.Add()
            D.Item(0, f).Value = aux.Leg
            D.Item(1, f).Value = aux.Nom
            D.Item(2, f).Value = aux.Ape
            f = f + 1
            aux = aux.Sig
        Loop
    End Sub
End Class
