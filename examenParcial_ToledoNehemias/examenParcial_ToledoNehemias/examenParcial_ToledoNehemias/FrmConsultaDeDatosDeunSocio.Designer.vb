<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaDeDatosDeunSocio
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
        Me.grpFive = New System.Windows.Forms.GroupBox()
        Me.lblDeudaSocio = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblTwelve = New System.Windows.Forms.Label()
        Me.lblEleven = New System.Windows.Forms.Label()
        Me.grpFour = New System.Windows.Forms.GroupBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmbSocios = New System.Windows.Forms.ComboBox()
        Me.grpFive.SuspendLayout()
        Me.grpFour.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFive
        '
        Me.grpFive.Controls.Add(Me.lblDeudaSocio)
        Me.grpFive.Controls.Add(Me.lblCodigo)
        Me.grpFive.Controls.Add(Me.lblTwelve)
        Me.grpFive.Controls.Add(Me.lblEleven)
        Me.grpFive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFive.ForeColor = System.Drawing.Color.White
        Me.grpFive.Location = New System.Drawing.Point(12, 142)
        Me.grpFive.Name = "grpFive"
        Me.grpFive.Size = New System.Drawing.Size(460, 107)
        Me.grpFive.TabIndex = 4
        Me.grpFive.TabStop = False
        Me.grpFive.Text = "Resultados de la consulta"
        '
        'lblDeudaSocio
        '
        Me.lblDeudaSocio.BackColor = System.Drawing.Color.White
        Me.lblDeudaSocio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeudaSocio.ForeColor = System.Drawing.Color.Black
        Me.lblDeudaSocio.Location = New System.Drawing.Point(272, 71)
        Me.lblDeudaSocio.Name = "lblDeudaSocio"
        Me.lblDeudaSocio.Size = New System.Drawing.Size(100, 19)
        Me.lblDeudaSocio.TabIndex = 13
        Me.lblDeudaSocio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(272, 31)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(100, 19)
        Me.lblCodigo.TabIndex = 12
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTwelve
        '
        Me.lblTwelve.AutoSize = True
        Me.lblTwelve.BackColor = System.Drawing.Color.White
        Me.lblTwelve.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwelve.ForeColor = System.Drawing.Color.Black
        Me.lblTwelve.Location = New System.Drawing.Point(85, 71)
        Me.lblTwelve.Name = "lblTwelve"
        Me.lblTwelve.Size = New System.Drawing.Size(153, 19)
        Me.lblTwelve.TabIndex = 11
        Me.lblTwelve.Text = "Deuda del socio:"
        '
        'lblEleven
        '
        Me.lblEleven.AutoSize = True
        Me.lblEleven.BackColor = System.Drawing.Color.White
        Me.lblEleven.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEleven.ForeColor = System.Drawing.Color.Black
        Me.lblEleven.Location = New System.Drawing.Point(76, 31)
        Me.lblEleven.Name = "lblEleven"
        Me.lblEleven.Size = New System.Drawing.Size(162, 19)
        Me.lblEleven.TabIndex = 10
        Me.lblEleven.Text = "Código del socio:"
        '
        'grpFour
        '
        Me.grpFour.BackColor = System.Drawing.Color.White
        Me.grpFour.Controls.Add(Me.cmdConsultar)
        Me.grpFour.Controls.Add(Me.cmbSocios)
        Me.grpFour.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFour.Location = New System.Drawing.Point(12, 12)
        Me.grpFour.Name = "grpFour"
        Me.grpFour.Size = New System.Drawing.Size(460, 109)
        Me.grpFour.TabIndex = 3
        Me.grpFour.TabStop = False
        Me.grpFour.Text = "Seleccione Socio a consultar"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdConsultar.Location = New System.Drawing.Point(272, 38)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(162, 27)
        Me.cmdConsultar.TabIndex = 1
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'cmbSocios
        '
        Me.cmbSocios.FormattingEnabled = True
        Me.cmbSocios.Location = New System.Drawing.Point(21, 38)
        Me.cmbSocios.Name = "cmbSocios"
        Me.cmbSocios.Size = New System.Drawing.Size(169, 26)
        Me.cmbSocios.TabIndex = 0
        '
        'FrmConsultaDeDatosDeunSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.grpFive)
        Me.Controls.Add(Me.grpFour)
        Me.Name = "FrmConsultaDeDatosDeunSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de datos de un socio..."
        Me.grpFive.ResumeLayout(False)
        Me.grpFive.PerformLayout()
        Me.grpFour.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpFive As GroupBox
    Friend WithEvents lblDeudaSocio As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblTwelve As Label
    Friend WithEvents lblEleven As Label
    Friend WithEvents grpFour As GroupBox
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents cmbSocios As ComboBox
End Class
