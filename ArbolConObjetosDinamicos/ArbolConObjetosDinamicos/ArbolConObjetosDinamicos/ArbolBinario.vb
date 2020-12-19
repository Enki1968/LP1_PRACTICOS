
Public Class ArbolBinario
    Private Raiz As Nodo = Nothing
    Private Nuevo As Nodo = Nothing
    Private Vec(0) As Nodo
    Private I As Integer = 0

    Public Sub AgregarNodo(ByVal Leg As Integer, ByVal Nom As String, ByVal Ape As String)
        Dim Aux As Nodo = Raiz
        Dim Ant As Nodo = Raiz
        Nuevo = New Nodo
        Nuevo.Leg = Leg
        Nuevo.Nom = Nom
        Nuevo.Ape = Ape
        If Raiz Is Nothing Then
            Raiz = Nuevo
        Else
            Aux = Raiz
            Do While Not (Aux Is Nothing)
                Ant = Aux
                If Nuevo.Leg < Aux.Leg Then
                    Aux = Aux.Izq
                Else
                    Aux = Aux.Der
                End If
            Loop
            If Nuevo.Leg < Ant.Leg Then
                Ant.Izq = Nuevo
            Else
                Ant.Der = Nuevo
            End If
        End If

    End Sub

    Public Sub Listar(ByVal Lis As ListBox, ByVal Modo As Integer)
        Lis.Items.Clear()
        Select Case Modo
            Case 1
                PreOrden(Raiz, Lis)
            Case 2
                InOrden(Raiz, Lis)
            Case 3
                PosOrden(Raiz, Lis)
        End Select

    End Sub
    Private Sub PreOrden(ByVal Pos As Nodo, ByVal L As ListBox)
        L.Items.Add(Pos.Leg & " " & Pos.Nom & " " & Pos.Ape)
        If Not (Pos.Izq Is Nothing) Then
            InOrden(Pos.Izq, L)
        End If
        If Not (Pos.Der Is Nothing) Then
            InOrden(Pos.Der, L)
        End If
    End Sub

    Private Sub InOrden(ByVal Pos As Nodo, ByVal L As ListBox)
        If Not (Pos.Izq Is Nothing) Then
            InOrden(Pos.Izq, L)
        End If
        L.Items.Add(Pos.Leg & " " & Pos.Nom & " " & Pos.Ape)
        If Not (Pos.Der Is Nothing) Then
            InOrden(Pos.Der, L)
        End If
    End Sub



    Private Sub PosOrden(ByVal Pos As Nodo, ByVal L As ListBox)
        If Not (Pos.Izq Is Nothing) Then
            InOrden(Pos.Izq, L)
        End If
        If Not (Pos.Der Is Nothing) Then
            InOrden(Pos.Der, L)
        End If
        L.Items.Add(Pos.Leg & " " & Pos.Nom & " " & Pos.Ape)
    End Sub

    Public Sub Mostrar(ByVal T As TreeView)
        T.Nodes.Clear()
        T.Nodes.Add("", "", 3)
        IO(Raiz, T.Nodes(0))
        T.ExpandAll()
    End Sub

    Private Sub IO(ByVal Pos As Nodo, ByVal N As TreeNode)
        If Not (Pos.Izq Is Nothing) Then
            IO(Pos.Izq, N.Nodes.Add("", "", 2))
        End If
        N.Text = (Pos.Leg & " " & Pos.Nom & " " & Pos.Ape)
        If Not (Pos.Der Is Nothing) Then
            IO(Pos.Der, N.Nodes.Add("", "", 1))
        End If
    End Sub

    Public Sub Equilibrar()
        I = 0
        ArbolVector(Raiz)
        Raiz = Nothing
        VectorArbol(0, I - 1)
        ReDim Vec(0)
    End Sub

    Private Sub ArbolVector(ByVal R As Nodo)
        If Not (R.Izq Is Nothing) Then
            ArbolVector(R.Izq)
        End If
        Vec(I) = R
        I = I + 1
        ReDim Preserve Vec(I)
        If Not (R.Der Is Nothing) Then
            ArbolVector(R.Der)
        End If
    End Sub

    Private Sub VectorArbol(ByVal p As Integer, ByVal u As Integer)
        Dim m As Integer = (p + u) / 2
        If p <= u Then
            AgregarNodo(Vec(m).Leg, Vec(m).Nom, Vec(m).Ape)
            VectorArbol(p, m - 1)
            VectorArbol(m + 1, u)
        End If
    End Sub

    Public Sub Borrar(ByVal n As Integer)
        I = 0
        ArbolVectorBorrar(Raiz, n)
        Raiz = Nothing
        VectorArbol(0, I - 1)
        ReDim Vec(0)
    End Sub


    Private Sub ArbolVectorBorrar(ByVal R As Nodo, ByVal Num As Integer)
        If Not (R.Izq Is Nothing) Then
            ArbolVectorBorrar(R.Izq, Num)
        End If
        If Num <> R.Leg Then
            Vec(I) = R
            I = I + 1
            ReDim Preserve Vec(I)
        End If
        If Not (R.Der Is Nothing) Then
            ArbolVectorBorrar(R.Der, Num)
        End If
    End Sub

End Class
