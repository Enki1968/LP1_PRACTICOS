<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoGralVendedores
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvVendedores = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCantidadVendedores = New System.Windows.Forms.Label()
        Me.lblTotalSueldos = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVendedores
        '
        Me.dgvVendedores.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVendedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvVendedores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvVendedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVendedores.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVendedores.Location = New System.Drawing.Point(15, 14)
        Me.dgvVendedores.Name = "dgvVendedores"
        Me.dgvVendedores.Size = New System.Drawing.Size(286, 221)
        Me.dgvVendedores.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.HeaderText = "Sueldo"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCantidadVendedores)
        Me.GroupBox1.Controls.Add(Me.lblTotalSueldos)
        Me.GroupBox1.Controls.Add(Me.cmdListar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 139)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblCantidadVendedores
        '
        Me.lblCantidadVendedores.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadVendedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadVendedores.Location = New System.Drawing.Point(170, 60)
        Me.lblCantidadVendedores.Name = "lblCantidadVendedores"
        Me.lblCantidadVendedores.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidadVendedores.TabIndex = 4
        Me.lblCantidadVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSueldos
        '
        Me.lblTotalSueldos.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSueldos.Location = New System.Drawing.Point(170, 22)
        Me.lblTotalSueldos.Name = "lblTotalSueldos"
        Me.lblTotalSueldos.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalSueldos.TabIndex = 3
        Me.lblTotalSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdListar
        '
        Me.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListar.Location = New System.Drawing.Point(91, 102)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(100, 23)
        Me.cmdListar.TabIndex = 2
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad de Vendedores:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importe Total de Sueldos:"
        '
        'frmListadoGralVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(315, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvVendedores)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmListadoGralVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado general de vendedores"
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdListar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidadVendedores As Label
    Friend WithEvents lblTotalSueldos As Label
End Class
