<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoClientesDeudores
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPromedioDeuda = New System.Windows.Forms.Label()
        Me.lblCantidadClientes = New System.Windows.Forms.Label()
        Me.lblTotalDeuda = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvClientes)
        Me.GroupBox1.Controls.Add(Me.btnListar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPromedioDeuda)
        Me.GroupBox1.Controls.Add(Me.lblCantidadClientes)
        Me.GroupBox1.Controls.Add(Me.lblTotalDeuda)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de datos"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvClientes.Location = New System.Drawing.Point(9, 19)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(449, 192)
        Me.dgvClientes.TabIndex = 7
        '
        'Column1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column2.HeaderText = "Nombre y Apellido"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column3.HeaderText = "Límitte de crédito"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column4.HeaderText = "Deuda"
        Me.Column4.Name = "Column4"
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(339, 352)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(120, 30)
        Me.btnListar.TabIndex = 6
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Promedio de deuda:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad de clientes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total de deuda:"
        '
        'lblPromedioDeuda
        '
        Me.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPromedioDeuda.Location = New System.Drawing.Point(339, 312)
        Me.lblPromedioDeuda.Name = "lblPromedioDeuda"
        Me.lblPromedioDeuda.Size = New System.Drawing.Size(120, 23)
        Me.lblPromedioDeuda.TabIndex = 2
        Me.lblPromedioDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidadClientes
        '
        Me.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadClientes.Location = New System.Drawing.Point(339, 272)
        Me.lblCantidadClientes.Name = "lblCantidadClientes"
        Me.lblCantidadClientes.Size = New System.Drawing.Size(120, 23)
        Me.lblCantidadClientes.TabIndex = 1
        Me.lblCantidadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDeuda
        '
        Me.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDeuda.Location = New System.Drawing.Point(338, 232)
        Me.lblTotalDeuda.Name = "lblTotalDeuda"
        Me.lblTotalDeuda.Size = New System.Drawing.Size(120, 23)
        Me.lblTotalDeuda.TabIndex = 0
        Me.lblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmListadoClientesDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(492, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmListadoClientesDeudores"
        Me.Text = "frmListadoClientesDeudores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnListar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPromedioDeuda As Label
    Friend WithEvents lblCantidadClientes As Label
    Friend WithEvents lblTotalDeuda As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
