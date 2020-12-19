<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFomulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFomulario))
        Me.CmdBorrar = New System.Windows.Forms.Button
        Me.CmdPosOrden = New System.Windows.Forms.Button
        Me.CmdPreOrden = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblApe = New System.Windows.Forms.Label
        Me.LblNom = New System.Windows.Forms.Label
        Me.LblCod = New System.Windows.Forms.Label
        Me.CmdInOrden = New System.Windows.Forms.Button
        Me.CmdAgregar = New System.Windows.Forms.Button
        Me.TextApe = New System.Windows.Forms.TextBox
        Me.TextNom = New System.Windows.Forms.TextBox
        Me.TextCod = New System.Windows.Forms.TextBox
        Me.cmdEquilibrar = New System.Windows.Forms.Button
        Me.Tree = New System.Windows.Forms.TreeView
        Me.IMAGENES = New System.Windows.Forms.ImageList(Me.components)
        Me.Lst = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'CmdBorrar
        '
        Me.CmdBorrar.Location = New System.Drawing.Point(290, 34)
        Me.CmdBorrar.Name = "CmdBorrar"
        Me.CmdBorrar.Size = New System.Drawing.Size(132, 26)
        Me.CmdBorrar.TabIndex = 61
        Me.CmdBorrar.Text = "Borrar"
        Me.CmdBorrar.UseVisualStyleBackColor = True
        '
        'CmdPosOrden
        '
        Me.CmdPosOrden.Location = New System.Drawing.Point(290, 94)
        Me.CmdPosOrden.Name = "CmdPosOrden"
        Me.CmdPosOrden.Size = New System.Drawing.Size(133, 23)
        Me.CmdPosOrden.TabIndex = 60
        Me.CmdPosOrden.Text = "Listar Post Orden"
        Me.CmdPosOrden.UseVisualStyleBackColor = True
        '
        'CmdPreOrden
        '
        Me.CmdPreOrden.Location = New System.Drawing.Point(14, 94)
        Me.CmdPreOrden.Name = "CmdPreOrden"
        Me.CmdPreOrden.Size = New System.Drawing.Size(133, 23)
        Me.CmdPreOrden.TabIndex = 59
        Me.CmdPreOrden.Text = "Listar Pre Orden"
        Me.CmdPreOrden.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Apellido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Código:"
        '
        'LblApe
        '
        Me.LblApe.AutoSize = True
        Me.LblApe.Location = New System.Drawing.Point(223, 67)
        Me.LblApe.Name = "LblApe"
        Me.LblApe.Size = New System.Drawing.Size(0, 13)
        Me.LblApe.TabIndex = 53
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(223, 39)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(0, 13)
        Me.LblNom.TabIndex = 54
        '
        'LblCod
        '
        Me.LblCod.AutoSize = True
        Me.LblCod.Location = New System.Drawing.Point(223, 10)
        Me.LblCod.Name = "LblCod"
        Me.LblCod.Size = New System.Drawing.Size(0, 13)
        Me.LblCod.TabIndex = 52
        '
        'CmdInOrden
        '
        Me.CmdInOrden.Location = New System.Drawing.Point(153, 94)
        Me.CmdInOrden.Name = "CmdInOrden"
        Me.CmdInOrden.Size = New System.Drawing.Size(133, 23)
        Me.CmdInOrden.TabIndex = 50
        Me.CmdInOrden.Text = "Listar In Orden"
        Me.CmdInOrden.UseVisualStyleBackColor = True
        '
        'CmdAgregar
        '
        Me.CmdAgregar.Location = New System.Drawing.Point(290, 8)
        Me.CmdAgregar.Name = "CmdAgregar"
        Me.CmdAgregar.Size = New System.Drawing.Size(133, 23)
        Me.CmdAgregar.TabIndex = 51
        Me.CmdAgregar.Text = "Agregar"
        Me.CmdAgregar.UseVisualStyleBackColor = True
        '
        'TextApe
        '
        Me.TextApe.Location = New System.Drawing.Point(70, 60)
        Me.TextApe.Name = "TextApe"
        Me.TextApe.Size = New System.Drawing.Size(153, 20)
        Me.TextApe.TabIndex = 49
        '
        'TextNom
        '
        Me.TextNom.Location = New System.Drawing.Point(70, 36)
        Me.TextNom.Name = "TextNom"
        Me.TextNom.Size = New System.Drawing.Size(153, 20)
        Me.TextNom.TabIndex = 48
        '
        'TextCod
        '
        Me.TextCod.Location = New System.Drawing.Point(70, 10)
        Me.TextCod.Name = "TextCod"
        Me.TextCod.Size = New System.Drawing.Size(153, 20)
        Me.TextCod.TabIndex = 47
        '
        'cmdEquilibrar
        '
        Me.cmdEquilibrar.Location = New System.Drawing.Point(292, 63)
        Me.cmdEquilibrar.Name = "cmdEquilibrar"
        Me.cmdEquilibrar.Size = New System.Drawing.Size(130, 25)
        Me.cmdEquilibrar.TabIndex = 63
        Me.cmdEquilibrar.Text = "Equilibrar"
        Me.cmdEquilibrar.UseVisualStyleBackColor = True
        '
        'Tree
        '
        Me.Tree.ImageIndex = 0
        Me.Tree.ImageList = Me.IMAGENES
        Me.Tree.Location = New System.Drawing.Point(14, 123)
        Me.Tree.Name = "Tree"
        Me.Tree.SelectedImageIndex = 0
        Me.Tree.Size = New System.Drawing.Size(410, 193)
        Me.Tree.TabIndex = 64
        '
        'IMAGENES
        '
        Me.IMAGENES.ImageStream = CType(resources.GetObject("IMAGENES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMAGENES.TransparentColor = System.Drawing.Color.Transparent
        Me.IMAGENES.Images.SetKeyName(0, "sample.gif")
        Me.IMAGENES.Images.SetKeyName(1, "diamond.gif")
        Me.IMAGENES.Images.SetKeyName(2, "directive.gif")
        Me.IMAGENES.Images.SetKeyName(3, "stop.gif")
        Me.IMAGENES.Images.SetKeyName(4, "4diamonds.gif")
        Me.IMAGENES.Images.SetKeyName(5, "directives.gif")
        '
        'Lst
        '
        Me.Lst.FormattingEnabled = True
        Me.Lst.Location = New System.Drawing.Point(12, 126)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(410, 186)
        Me.Lst.TabIndex = 65
        '
        'FrmFomulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 334)
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.cmdEquilibrar)
        Me.Controls.Add(Me.CmdBorrar)
        Me.Controls.Add(Me.CmdPosOrden)
        Me.Controls.Add(Me.CmdPreOrden)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblApe)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.LblCod)
        Me.Controls.Add(Me.CmdInOrden)
        Me.Controls.Add(Me.CmdAgregar)
        Me.Controls.Add(Me.TextApe)
        Me.Controls.Add(Me.TextNom)
        Me.Controls.Add(Me.TextCod)
        Me.Name = "FrmFomulario"
        Me.Text = "Arbol Binario De Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdBorrar As System.Windows.Forms.Button
    Friend WithEvents CmdPosOrden As System.Windows.Forms.Button
    Friend WithEvents CmdPreOrden As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblApe As System.Windows.Forms.Label
    Friend WithEvents LblNom As System.Windows.Forms.Label
    Friend WithEvents LblCod As System.Windows.Forms.Label
    Friend WithEvents CmdInOrden As System.Windows.Forms.Button
    Friend WithEvents CmdAgregar As System.Windows.Forms.Button
    Friend WithEvents TextApe As System.Windows.Forms.TextBox
    Friend WithEvents TextNom As System.Windows.Forms.TextBox
    Friend WithEvents TextCod As System.Windows.Forms.TextBox
    Friend WithEvents cmdEquilibrar As System.Windows.Forms.Button
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents IMAGENES As System.Windows.Forms.ImageList
    Friend WithEvents Lst As System.Windows.Forms.ListBox

End Class
