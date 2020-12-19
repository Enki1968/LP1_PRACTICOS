<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLlamadasInterno
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.LEmpleado = New System.Windows.Forms.Label
        Me.Grilla = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.LInterno = New System.Windows.Forms.Label
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Empleado"
        '
        'LEmpleado
        '
        Me.LEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LEmpleado.Location = New System.Drawing.Point(250, 33)
        Me.LEmpleado.Name = "LEmpleado"
        Me.LEmpleado.Size = New System.Drawing.Size(355, 23)
        Me.LEmpleado.TabIndex = 15
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grilla.Location = New System.Drawing.Point(35, 87)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.Size = New System.Drawing.Size(570, 187)
        Me.Grilla.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Hora"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Teléfono"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Motivo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Interno"
        '
        'LInterno
        '
        Me.LInterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LInterno.Location = New System.Drawing.Point(89, 34)
        Me.LInterno.Name = "LInterno"
        Me.LInterno.Size = New System.Drawing.Size(65, 23)
        Me.LInterno.TabIndex = 17
        '
        'FrmLlamadasInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 318)
        Me.Controls.Add(Me.LInterno)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.LEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmLlamadasInterno"
        Me.Text = "SP5 - MotoCenter - Llamadas por interno"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LEmpleado As System.Windows.Forms.Label
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LInterno As System.Windows.Forms.Label
End Class
