<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarNuevoSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarNuevoSocio))
        Me.grpTwo = New System.Windows.Forms.GroupBox()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblSeven = New System.Windows.Forms.Label()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.grpTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTwo
        '
        Me.grpTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpTwo.Controls.Add(Me.cmdCargar)
        Me.grpTwo.Controls.Add(Me.txtDeuda)
        Me.grpTwo.Controls.Add(Me.txtNombre)
        Me.grpTwo.Controls.Add(Me.lblSeven)
        Me.grpTwo.Controls.Add(Me.lblSix)
        Me.grpTwo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTwo.Location = New System.Drawing.Point(12, 12)
        Me.grpTwo.Name = "grpTwo"
        Me.grpTwo.Size = New System.Drawing.Size(460, 237)
        Me.grpTwo.TabIndex = 0
        Me.grpTwo.TabStop = False
        Me.grpTwo.Text = "Agregar nuevo socio"
        '
        'cmdCargar
        '
        Me.cmdCargar.BackColor = System.Drawing.Color.White
        Me.cmdCargar.Location = New System.Drawing.Point(232, 165)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(204, 43)
        Me.cmdCargar.TabIndex = 3
        Me.cmdCargar.Text = "Cargar socio"
        Me.cmdCargar.UseVisualStyleBackColor = False
        '
        'txtDeuda
        '
        Me.txtDeuda.Location = New System.Drawing.Point(232, 97)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.Size = New System.Drawing.Size(204, 26)
        Me.txtDeuda.TabIndex = 2
        Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(232, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 1
        '
        'lblSeven
        '
        Me.lblSeven.AutoSize = True
        Me.lblSeven.BackColor = System.Drawing.Color.White
        Me.lblSeven.Location = New System.Drawing.Point(109, 104)
        Me.lblSeven.Name = "lblSeven"
        Me.lblSeven.Size = New System.Drawing.Size(79, 18)
        Me.lblSeven.TabIndex = 2
        Me.lblSeven.Text = "Deuda: $"
        '
        'lblSix
        '
        Me.lblSix.AutoSize = True
        Me.lblSix.BackColor = System.Drawing.Color.White
        Me.lblSix.Location = New System.Drawing.Point(28, 44)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(155, 18)
        Me.lblSix.TabIndex = 0
        Me.lblSix.Text = "Nombre y apellido:"
        '
        'FrmAgregarNuevoSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.grpTwo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarNuevoSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar nuevo socio…"
        Me.grpTwo.ResumeLayout(False)
        Me.grpTwo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTwo As GroupBox
    Friend WithEvents cmdCargar As Button
    Friend WithEvents txtDeuda As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblSeven As Label
    Friend WithEvents lblSix As Label
End Class
