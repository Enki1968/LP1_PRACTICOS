<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaRepuestos
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
        Me.CBMarcas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBAmb = New System.Windows.Forms.RadioButton()
        Me.RBNac = New System.Windows.Forms.RadioButton()
        Me.RBImp = New System.Windows.Forms.RadioButton()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBMarcas
        '
        Me.CBMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarcas.FormattingEnabled = True
        Me.CBMarcas.Location = New System.Drawing.Point(45, 60)
        Me.CBMarcas.Name = "CBMarcas"
        Me.CBMarcas.Size = New System.Drawing.Size(205, 21)
        Me.CBMarcas.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Marca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBAmb)
        Me.GroupBox1.Controls.Add(Me.RBNac)
        Me.GroupBox1.Controls.Add(Me.RBImp)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 66)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen"
        '
        'RBAmb
        '
        Me.RBAmb.AutoSize = True
        Me.RBAmb.Location = New System.Drawing.Point(193, 29)
        Me.RBAmb.Name = "RBAmb"
        Me.RBAmb.Size = New System.Drawing.Size(57, 17)
        Me.RBAmb.TabIndex = 9
        Me.RBAmb.TabStop = True
        Me.RBAmb.Text = "Ambos"
        Me.RBAmb.UseVisualStyleBackColor = True
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
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(624, 58)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 11
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Grilla.Location = New System.Drawing.Point(45, 119)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.Size = New System.Drawing.Size(654, 327)
        Me.Grilla.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Repuesto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Marca"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Origen"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'FrmConsultaRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 491)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBMarcas)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmConsultaRepuestos"
        Me.Text = "Repuestos AutoCor - Consulta repuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBAmb As System.Windows.Forms.RadioButton
    Friend WithEvents RBNac As System.Windows.Forms.RadioButton
    Friend WithEvents RBImp As System.Windows.Forms.RadioButton
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
