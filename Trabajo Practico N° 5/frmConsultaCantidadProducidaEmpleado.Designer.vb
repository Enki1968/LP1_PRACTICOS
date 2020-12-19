<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCantidadProducidaEmpleado
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProduccion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.Color.White
        Me.cmdListar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdListar.Location = New System.Drawing.Point(7, 180)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(245, 30)
        Me.cmdListar.TabIndex = 8
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdListar)
        Me.GroupBox1.Controls.Add(Me.dgvProduccion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 223)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad producida por el empleado"
        '
        'dgvProduccion
        '
        Me.dgvProduccion.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Linen
        Me.dgvProduccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProduccion.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvProduccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProduccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvProduccion.Location = New System.Drawing.Point(7, 20)
        Me.dgvProduccion.Name = "dgvProduccion"
        Me.dgvProduccion.Size = New System.Drawing.Size(245, 150)
        Me.dgvProduccion.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column1.HeaderText = "Máquina"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(132, 19)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(135, 22)
        Me.cmbEmpleado.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre del empleado:"
        '
        'frmConsultaCantidadProducidaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(284, 289)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmConsultaCantidadProducidaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar cantidad producida de un empleado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdListar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvProduccion As DataGridView
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
