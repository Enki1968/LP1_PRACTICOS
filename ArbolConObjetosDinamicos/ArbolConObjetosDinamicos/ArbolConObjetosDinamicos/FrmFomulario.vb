Public Class FrmFomulario

    Dim A As New ArbolBinario

    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregar.Click
        Tree.Visible = True
        Lst.Visible = False
        A.AgregarNodo(TextCod.Text, TextNom.Text, TextApe.Text)
        A.Mostrar(Tree)
        TextCod.Text = ""
        TextNom.Text = ""
        TextApe.Text = ""
        TextCod.Select()
    End Sub

    Private Sub cmdEquilibrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEquilibrar.Click
        Tree.Visible = True
        Lst.Visible = False
        A.Equilibrar()
        A.Mostrar(Tree)
    End Sub

    Private Sub CmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        Tree.Visible = True
        Lst.Visible = False
        A.Borrar(TextCod.Text)
        A.Mostrar(Tree)
        TextCod.Text = ""
    End Sub

    Private Sub CmdPreOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPreOrden.Click
        Tree.Visible = False
        Lst.Visible = True
        A.Listar(Lst, 1)
    End Sub

    Private Sub CmdInOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInOrden.Click
        Tree.Visible = False
        Lst.Visible = True
        A.Listar(Lst, 2)
    End Sub

    Private Sub CmdPosOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPosOrden.Click
        Tree.Visible = False
        Lst.Visible = True
        A.Listar(Lst, 3)
    End Sub

End Class
