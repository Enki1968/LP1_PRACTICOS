<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm04ConsultarVentasDeUnaSucursal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalVentas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmdListar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdListar.Location = New System.Drawing.Point(171, 14)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(100, 30)
        Me.cmdListar.TabIndex = 8
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalVentas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 223)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de datos"
        '
        'lblTotalVentas
        '
        Me.lblTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalVentas.Location = New System.Drawing.Point(152, 188)
        Me.lblTotalVentas.Name = "lblTotalVentas"
        Me.lblTotalVentas.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalVentas.TabIndex = 2
        Me.lblTotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Venta Total:"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvVentas.Location = New System.Drawing.Point(7, 20)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(245, 150)
        Me.dgvVentas.TabIndex = 0
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(59, 20)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(106, 21)
        Me.cmbSucursal.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sucursal:"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Mes"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Importe"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 110
        '
        'frm04ConsultarVentasDeUnaSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(282, 287)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm04ConsultarVentasDeUnaSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar ventas de una sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdListar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalVentas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
