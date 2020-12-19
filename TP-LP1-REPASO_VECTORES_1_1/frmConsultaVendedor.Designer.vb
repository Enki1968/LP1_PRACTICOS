<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVendedor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSueldoVendedor = New System.Windows.Forms.Label()
        Me.lblCodigoVendedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmbNombreVendedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSueldoVendedor)
        Me.GroupBox1.Controls.Add(Me.lblCodigoVendedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Vendedor"
        '
        'lblSueldoVendedor
        '
        Me.lblSueldoVendedor.BackColor = System.Drawing.Color.Transparent
        Me.lblSueldoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSueldoVendedor.Location = New System.Drawing.Point(170, 60)
        Me.lblSueldoVendedor.Name = "lblSueldoVendedor"
        Me.lblSueldoVendedor.Size = New System.Drawing.Size(100, 23)
        Me.lblSueldoVendedor.TabIndex = 4
        Me.lblSueldoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodigoVendedor
        '
        Me.lblCodigoVendedor.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigoVendedor.Location = New System.Drawing.Point(170, 22)
        Me.lblCodigoVendedor.Name = "lblCodigoVendedor"
        Me.lblCodigoVendedor.Size = New System.Drawing.Size(100, 23)
        Me.lblCodigoVendedor.TabIndex = 3
        Me.lblCodigoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sueldo del vendedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del vendedor:"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdConsultar.ForeColor = System.Drawing.Color.White
        Me.cmdConsultar.Location = New System.Drawing.Point(182, 75)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(100, 23)
        Me.cmdConsultar.TabIndex = 2
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmbNombreVendedor
        '
        Me.cmbNombreVendedor.FormattingEnabled = True
        Me.cmbNombreVendedor.Location = New System.Drawing.Point(161, 34)
        Me.cmbNombreVendedor.Name = "cmbNombreVendedor"
        Me.cmbNombreVendedor.Size = New System.Drawing.Size(121, 21)
        Me.cmbNombreVendedor.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre del vendedor:"
        '
        'frmConsultaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(311, 226)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbNombreVendedor)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Datos Vendedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSueldoVendedor As Label
    Friend WithEvents lblCodigoVendedor As Label
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNombreVendedor As ComboBox
    Friend WithEvents Label3 As Label
End Class
