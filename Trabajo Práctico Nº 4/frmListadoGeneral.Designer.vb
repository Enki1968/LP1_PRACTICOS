<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoGeneral
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.lblTotalSueldos = New System.Windows.Forms.Label()
        Me.lblCantidadEmpleados = New System.Windows.Forms.Label()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(180, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(444, 197)
        Me.dgvEmpleados.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.FillWeight = 60.9137!
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.FillWeight = 178.0239!
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.FillWeight = 71.77203!
        Me.Column3.HeaderText = "Categoría"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.FillWeight = 89.29033!
        Me.Column4.HeaderText = "Sueldo"
        Me.Column4.Name = "Column4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmdListar)
        Me.GroupBox2.Controls.Add(Me.lblTotalSueldos)
        Me.GroupBox2.Controls.Add(Me.lblCantidadEmpleados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 170)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Importe total de sueldos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cantidad de Empleados:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.Color.Transparent
        Me.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.ForeColor = System.Drawing.Color.White
        Me.cmdListar.Location = New System.Drawing.Point(173, 124)
        Me.cmdListar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(100, 29)
        Me.cmdListar.TabIndex = 2
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'lblTotalSueldos
        '
        Me.lblTotalSueldos.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSueldos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSueldos.ForeColor = System.Drawing.Color.White
        Me.lblTotalSueldos.Location = New System.Drawing.Point(328, 26)
        Me.lblTotalSueldos.Name = "lblTotalSueldos"
        Me.lblTotalSueldos.Size = New System.Drawing.Size(100, 27)
        Me.lblTotalSueldos.TabIndex = 11
        Me.lblTotalSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidadEmpleados
        '
        Me.lblCantidadEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadEmpleados.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadEmpleados.ForeColor = System.Drawing.Color.White
        Me.lblCantidadEmpleados.Location = New System.Drawing.Point(328, 73)
        Me.lblCantidadEmpleados.Name = "lblCantidadEmpleados"
        Me.lblCantidadEmpleados.Size = New System.Drawing.Size(100, 27)
        Me.lblCantidadEmpleados.TabIndex = 12
        Me.lblCantidadEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmListadoGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListadoGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Listado general de empleados"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdListar As Button
    Friend WithEvents lblTotalSueldos As Label
    Friend WithEvents lblCantidadEmpleados As Label
End Class
