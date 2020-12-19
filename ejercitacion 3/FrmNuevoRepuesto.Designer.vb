<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoRepuesto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBRepuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBMarcas = New System.Windows.Forms.ComboBox()
        Me.RBNac = New System.Windows.Forms.RadioButton()
        Me.RBImp = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConsultar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Repuesto"
        '
        'TBRepuesto
        '
        Me.TBRepuesto.Location = New System.Drawing.Point(116, 40)
        Me.TBRepuesto.MaxLength = 10
        Me.TBRepuesto.Name = "TBRepuesto"
        Me.TBRepuesto.Size = New System.Drawing.Size(100, 20)
        Me.TBRepuesto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(116, 85)
        Me.TBNombre.MaxLength = 50
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(416, 20)
        Me.TBNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'CBMarcas
        '
        Me.CBMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarcas.FormattingEnabled = True
        Me.CBMarcas.Location = New System.Drawing.Point(116, 127)
        Me.CBMarcas.Name = "CBMarcas"
        Me.CBMarcas.Size = New System.Drawing.Size(205, 21)
        Me.CBMarcas.TabIndex = 5
        '
        'RBNac
        '
        Me.RBNac.AutoSize = True
        Me.RBNac.Checked = True
        Me.RBNac.Location = New System.Drawing.Point(20, 29)
        Me.RBNac.Name = "RBNac"
        Me.RBNac.Size = New System.Drawing.Size(67, 17)
        Me.RBNac.TabIndex = 7
        Me.RBNac.TabStop = True
        Me.RBNac.Text = "Nacional"
        Me.RBNac.UseVisualStyleBackColor = True
        '
        'RBImp
        '
        Me.RBImp.AutoSize = True
        Me.RBImp.Location = New System.Drawing.Point(103, 29)
        Me.RBImp.Name = "RBImp"
        Me.RBImp.Size = New System.Drawing.Size(72, 17)
        Me.RBImp.TabIndex = 8
        Me.RBImp.Text = "Importado"
        Me.RBImp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBNac)
        Me.GroupBox1.Controls.Add(Me.RBImp)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 66)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio"
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(116, 173)
        Me.TBPrecio.MaxLength = 12
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TBPrecio.TabIndex = 11
        '
        'BAceptar
        '
        Me.BAceptar.Enabled = False
        Me.BAceptar.Location = New System.Drawing.Point(116, 228)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 12
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(228, 228)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 13
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(341, 228)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BConsultar.TabIndex = 14
        Me.BConsultar.Text = "Consultar"
        Me.BConsultar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(457, 228)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 15
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'FrmNuevoRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 301)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BConsultar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TBPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBMarcas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBRepuesto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNuevoRepuesto"
        Me.Text = "Repuestos AutoCor - Nuevo repuesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBRepuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents RBNac As System.Windows.Forms.RadioButton
    Friend WithEvents RBImp As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBPrecio As System.Windows.Forms.TextBox
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BConsultar As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button

End Class
