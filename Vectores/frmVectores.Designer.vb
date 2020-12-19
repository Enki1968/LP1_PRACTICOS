<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVectores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnListarWhile = New System.Windows.Forms.Button()
        Me.LstPersonas = New System.Windows.Forms.ListBox()
        Me.btnListarFor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.txtNombreApellido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(318, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de datos"
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(144, 77)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(161, 43)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Location = New System.Drawing.Point(144, 34)
        Me.txtNombreApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(161, 24)
        Me.txtNombreApellido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre y Apellido:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnListarFor)
        Me.GroupBox2.Controls.Add(Me.LstPersonas)
        Me.GroupBox2.Controls.Add(Me.btnListarWhile)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 206)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de datos"
        '
        'btnListarWhile
        '
        Me.btnListarWhile.Location = New System.Drawing.Point(183, 146)
        Me.btnListarWhile.Margin = New System.Windows.Forms.Padding(5)
        Me.btnListarWhile.Name = "btnListarWhile"
        Me.btnListarWhile.Size = New System.Drawing.Size(122, 43)
        Me.btnListarWhile.TabIndex = 3
        Me.btnListarWhile.Text = "Listar con While"
        Me.btnListarWhile.UseVisualStyleBackColor = True
        '
        'LstPersonas
        '
        Me.LstPersonas.FormattingEnabled = True
        Me.LstPersonas.ItemHeight = 17
        Me.LstPersonas.Location = New System.Drawing.Point(12, 23)
        Me.LstPersonas.Name = "LstPersonas"
        Me.LstPersonas.Size = New System.Drawing.Size(293, 106)
        Me.LstPersonas.TabIndex = 4
        '
        'btnListarFor
        '
        Me.btnListarFor.Location = New System.Drawing.Point(12, 146)
        Me.btnListarFor.Margin = New System.Windows.Forms.Padding(5)
        Me.btnListarFor.Name = "btnListarFor"
        Me.btnListarFor.Size = New System.Drawing.Size(122, 43)
        Me.btnListarFor.TabIndex = 5
        Me.btnListarFor.Text = "Listar con For"
        Me.btnListarFor.UseVisualStyleBackColor = True
        '
        'frmVectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 389)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmVectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vectores - Introducción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtNombreApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LstPersonas As ListBox
    Friend WithEvents btnListarWhile As Button
    Friend WithEvents btnListarFor As Button
End Class
