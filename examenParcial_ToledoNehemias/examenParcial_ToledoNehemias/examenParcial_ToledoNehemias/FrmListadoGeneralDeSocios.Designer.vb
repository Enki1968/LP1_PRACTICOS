<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoGeneralDeSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoGeneralDeSocios))
        Me.grpThree = New System.Windows.Forms.GroupBox()
        Me.dgvListadoSocios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIntereses = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.lblEigth = New System.Windows.Forms.Label()
        Me.lblSocios = New System.Windows.Forms.Label()
        Me.lblten = New System.Windows.Forms.Label()
        Me.grpThree.SuspendLayout()
        CType(Me.dgvListadoSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpThree
        '
        Me.grpThree.BackColor = System.Drawing.Color.White
        Me.grpThree.Controls.Add(Me.dgvListadoSocios)
        Me.grpThree.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpThree.Location = New System.Drawing.Point(12, 12)
        Me.grpThree.Name = "grpThree"
        Me.grpThree.Size = New System.Drawing.Size(454, 144)
        Me.grpThree.TabIndex = 2
        Me.grpThree.TabStop = False
        Me.grpThree.Text = "Listado de Socios"
        '
        'dgvListadoSocios
        '
        Me.dgvListadoSocios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoSocios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvListadoSocios.Location = New System.Drawing.Point(10, 19)
        Me.dgvListadoSocios.Name = "dgvListadoSocios"
        Me.dgvListadoSocios.Size = New System.Drawing.Size(436, 117)
        Me.dgvListadoSocios.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre de Socio"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Deuda"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Interés (15%)"
        Me.Column4.Name = "Column4"
        '
        'lblIntereses
        '
        Me.lblIntereses.BackColor = System.Drawing.Color.White
        Me.lblIntereses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntereses.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntereses.Location = New System.Drawing.Point(258, 212)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Size = New System.Drawing.Size(104, 19)
        Me.lblIntereses.TabIndex = 14
        Me.lblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeuda
        '
        Me.lblDeuda.BackColor = System.Drawing.Color.White
        Me.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeuda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeuda.Location = New System.Drawing.Point(258, 177)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(104, 19)
        Me.lblDeuda.TabIndex = 13
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNine
        '
        Me.lblNine.AutoSize = True
        Me.lblNine.BackColor = System.Drawing.Color.White
        Me.lblNine.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNine.Location = New System.Drawing.Point(21, 213)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(218, 18)
        Me.lblNine.TabIndex = 12
        Me.lblNine.Text = "Importe total de intereses:"
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdListar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.Location = New System.Drawing.Point(379, 177)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(87, 85)
        Me.cmdListar.TabIndex = 11
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'lblEigth
        '
        Me.lblEigth.AutoSize = True
        Me.lblEigth.BackColor = System.Drawing.Color.White
        Me.lblEigth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEigth.Location = New System.Drawing.Point(90, 178)
        Me.lblEigth.Name = "lblEigth"
        Me.lblEigth.Size = New System.Drawing.Size(149, 18)
        Me.lblEigth.TabIndex = 10
        Me.lblEigth.Text = "Total de la deuda:"
        '
        'lblSocios
        '
        Me.lblSocios.BackColor = System.Drawing.Color.White
        Me.lblSocios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSocios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocios.Location = New System.Drawing.Point(258, 244)
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(104, 19)
        Me.lblSocios.TabIndex = 19
        Me.lblSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblten
        '
        Me.lblten.AutoSize = True
        Me.lblten.BackColor = System.Drawing.Color.White
        Me.lblten.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblten.Location = New System.Drawing.Point(74, 244)
        Me.lblten.Name = "lblten"
        Me.lblten.Size = New System.Drawing.Size(165, 18)
        Me.lblten.TabIndex = 17
        Me.lblten.Text = "Cantidad de socios:"
        '
        'FrmListadoGeneralDeSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(484, 281)
        Me.Controls.Add(Me.lblSocios)
        Me.Controls.Add(Me.lblten)
        Me.Controls.Add(Me.lblIntereses)
        Me.Controls.Add(Me.lblDeuda)
        Me.Controls.Add(Me.lblNine)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.lblEigth)
        Me.Controls.Add(Me.grpThree)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListadoGeneralDeSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado general de socios..."
        Me.grpThree.ResumeLayout(False)
        CType(Me.dgvListadoSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpThree As GroupBox
    Friend WithEvents dgvListadoSocios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lblIntereses As Label
    Friend WithEvents lblDeuda As Label
    Friend WithEvents lblNine As Label
    Friend WithEvents cmdListar As Button
    Friend WithEvents lblEigth As Label
    Friend WithEvents lblSocios As Label
    Friend WithEvents lblten As Label
End Class
