<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultarProduccionDeEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbEmpleades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotalPrudu = New System.Windows.Forms.Label()
        Me.CmdListar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEmpleades
        '
        Me.CmbEmpleades.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmpleades.FormattingEnabled = True
        Me.CmbEmpleades.Location = New System.Drawing.Point(74, 20)
        Me.CmbEmpleades.Name = "CmbEmpleades"
        Me.CmbEmpleades.Size = New System.Drawing.Size(203, 22)
        Me.CmbEmpleades.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado:"
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Grilla.Location = New System.Drawing.Point(15, 50)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(362, 228)
        Me.Grilla.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total: "
        '
        'LblTotalPrudu
        '
        Me.LblTotalPrudu.AutoSize = True
        Me.LblTotalPrudu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPrudu.Location = New System.Drawing.Point(316, 313)
        Me.LblTotalPrudu.Name = "LblTotalPrudu"
        Me.LblTotalPrudu.Size = New System.Drawing.Size(61, 14)
        Me.LblTotalPrudu.TabIndex = 4
        Me.LblTotalPrudu.Text = "_________"
        Me.LblTotalPrudu.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CmdListar
        '
        Me.CmdListar.Location = New System.Drawing.Point(283, 14)
        Me.CmdListar.Name = "CmdListar"
        Me.CmdListar.Size = New System.Drawing.Size(94, 30)
        Me.CmdListar.TabIndex = 5
        Me.CmdListar.Text = "Listar"
        Me.CmdListar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre de la maquina"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad Producida"
        Me.Column2.Name = "Column2"
        '
        'FrmConsultarProduccionDeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 355)
        Me.Controls.Add(Me.CmdListar)
        Me.Controls.Add(Me.LblTotalPrudu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbEmpleades)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultarProduccionDeEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Cantidad Producida por un empleado"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEmpleades As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTotalPrudu As Label
    Friend WithEvents CmdListar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
