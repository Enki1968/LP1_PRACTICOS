Public Class frmBucles
    Dim Vector(5) As Integer
    Dim i As Integer = 0
    Private Sub frmBucles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Do While i < Vector.Length
            Vector(i) = i + 1
            i += 1
        Loop
    End Sub

    Private Sub cmdDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDo.Click
        i = 0
        Do While i < Vector.Length
            lstResultado.Items.Add(Vector(i))
            i += 1
        Loop
    End Sub

    Private Sub cmdFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFor.Click
        lstResultado.Items.Clear()
        For i = 0 To Vector.Length - 1
            lstResultado.Items.Add(Vector(i))
        Next
    End Sub

    Private Sub cmdCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarga.Click
        Vector(0) = 150
        Vector(1) = 50
        Vector(2) = 350
        Vector(3) = 10
        Vector(4) = 3
        Vector(5) = 100

        lstResultado.Items.Clear()
        For i = 0 To Vector.Length - 1
            lstResultado.Items.Add(Vector(i))
        Next
    End Sub

    Private Sub lstResultado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResultado.Click
        lstResultado.Items.Clear()
    End Sub

    Private Sub cmdForEach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdForEach.Click
        For Each i In Vector
            lstResultado.Items.Add(i)
        Next
    End Sub

    Private Sub cmdOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdenar.Click
        lstResultado.Items.Clear()

        Array.Sort(Vector)

        For Each i In Vector
            lstResultado.Items.Add(i)
        Next

    End Sub
End Class
