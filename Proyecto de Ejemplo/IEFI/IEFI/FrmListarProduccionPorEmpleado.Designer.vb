<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarProduccionPorEmpleado
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
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.LblTotalPrudu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPromProduc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbListar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Grilla.Location = New System.Drawing.Point(12, 12)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(358, 278)
        Me.Grilla.TabIndex = 0
        '
        'LblTotalPrudu
        '
        Me.LblTotalPrudu.AutoSize = True
        Me.LblTotalPrudu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPrudu.Location = New System.Drawing.Point(117, 311)
        Me.LblTotalPrudu.Name = "LblTotalPrudu"
        Me.LblTotalPrudu.Size = New System.Drawing.Size(43, 14)
        Me.LblTotalPrudu.TabIndex = 6
        Me.LblTotalPrudu.Text = "______"
        Me.LblTotalPrudu.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Producido: "
        '
        'LblPromProduc
        '
        Me.LblPromProduc.AutoSize = True
        Me.LblPromProduc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPromProduc.Location = New System.Drawing.Point(328, 311)
        Me.LblPromProduc.Name = "LblPromProduc"
        Me.LblPromProduc.Size = New System.Drawing.Size(37, 14)
        Me.LblPromProduc.TabIndex = 8
        Me.LblPromProduc.Text = "_____"
        Me.LblPromProduc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Promedio de Produccion: "
        '
        'CmbListar
        '
        Me.CmbListar.Location = New System.Drawing.Point(169, 353)
        Me.CmbListar.Name = "CmbListar"
        Me.CmbListar.Size = New System.Drawing.Size(201, 43)
        Me.CmbListar.TabIndex = 9
        Me.CmbListar.Text = "Listar"
        Me.CmbListar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre del empleado"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total Producido"
        Me.Column2.Name = "Column2"
        '
        'FrmListarProduccionPorEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 408)
        Me.Controls.Add(Me.CmbListar)
        Me.Controls.Add(Me.LblPromProduc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTotalPrudu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Grilla)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListarProduccionPorEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de produccion por cada emplado"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grilla As DataGridView
    Friend WithEvents LblTotalPrudu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPromProduc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbListar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
