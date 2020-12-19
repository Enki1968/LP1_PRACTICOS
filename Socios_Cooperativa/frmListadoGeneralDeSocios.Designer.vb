<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoGeneralDeSocios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSocios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblImporteTotalDeuda = New System.Windows.Forms.Label()
        Me.lblImporteTotalIntereses = New System.Windows.Forms.Label()
        Me.lblCantidadSocios = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSocios
        '
        Me.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvSocios.Location = New System.Drawing.Point(12, 12)
        Me.dgvSocios.Name = "dgvSocios"
        Me.dgvSocios.Size = New System.Drawing.Size(444, 150)
        Me.dgvSocios.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCantidadSocios)
        Me.GroupBox1.Controls.Add(Me.lblImporteTotalIntereses)
        Me.GroupBox1.Controls.Add(Me.lblImporteTotalDeuda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importe total de deudas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Importe total de intereses:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad de socios:"
        '
        'lblImporteTotalDeuda
        '
        Me.lblImporteTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporteTotalDeuda.Location = New System.Drawing.Point(271, 20)
        Me.lblImporteTotalDeuda.Name = "lblImporteTotalDeuda"
        Me.lblImporteTotalDeuda.Size = New System.Drawing.Size(100, 23)
        Me.lblImporteTotalDeuda.TabIndex = 3
        Me.lblImporteTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImporteTotalIntereses
        '
        Me.lblImporteTotalIntereses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporteTotalIntereses.Location = New System.Drawing.Point(271, 55)
        Me.lblImporteTotalIntereses.Name = "lblImporteTotalIntereses"
        Me.lblImporteTotalIntereses.Size = New System.Drawing.Size(100, 23)
        Me.lblImporteTotalIntereses.TabIndex = 4
        Me.lblImporteTotalIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidadSocios
        '
        Me.lblCantidadSocios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadSocios.Location = New System.Drawing.Point(271, 90)
        Me.lblCantidadSocios.Name = "lblCantidadSocios"
        Me.lblCantidadSocios.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidadSocios.TabIndex = 5
        Me.lblCantidadSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.Color.White
        Me.cmdListar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.ForeColor = System.Drawing.Color.Black
        Me.cmdListar.Location = New System.Drawing.Point(159, 331)
        Me.cmdListar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(160, 30)
        Me.cmdListar.TabIndex = 6
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Deuda"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Interés (15%)"
        Me.Column4.Name = "Column4"
        '
        'frmListadoGeneralDeSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(468, 374)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSocios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmListadoGeneralDeSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado general de socios"
        CType(Me.dgvSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSocios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCantidadSocios As Label
    Friend WithEvents lblImporteTotalIntereses As Label
    Friend WithEvents lblImporteTotalDeuda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdListar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
