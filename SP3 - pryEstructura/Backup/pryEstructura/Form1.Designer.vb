<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdRegistrar = New System.Windows.Forms.Button
        Me.lst = New System.Windows.Forms.ListBox
        Me.cmdListar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(81, 60)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número"
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.Location = New System.Drawing.Point(106, 97)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdRegistrar.TabIndex = 2
        Me.cmdRegistrar.Text = "Registrar"
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'lst
        '
        Me.lst.FormattingEnabled = True
        Me.lst.Location = New System.Drawing.Point(316, 21)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(120, 95)
        Me.lst.TabIndex = 4
        '
        'cmdListar
        '
        Me.cmdListar.Location = New System.Drawing.Point(235, 21)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(75, 23)
        Me.cmdListar.TabIndex = 3
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.cmdRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 128)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "Form1"
        Me.Text = "Contactos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdRegistrar As System.Windows.Forms.Button
    Friend WithEvents lst As System.Windows.Forms.ListBox
    Friend WithEvents cmdListar As System.Windows.Forms.Button

End Class
