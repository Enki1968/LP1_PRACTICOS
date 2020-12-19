<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidoLlamada
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBTelefono = New System.Windows.Forms.TextBox
        Me.TBMotivo = New System.Windows.Forms.TextBox
        Me.BAceptar = New System.Windows.Forms.Button
        Me.CBInternos = New System.Windows.Forms.ComboBox
        Me.BPuntitos = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Motivo"
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(93, 77)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(188, 20)
        Me.TBTelefono.TabIndex = 8
        '
        'TBMotivo
        '
        Me.TBMotivo.Location = New System.Drawing.Point(93, 120)
        Me.TBMotivo.Name = "TBMotivo"
        Me.TBMotivo.Size = New System.Drawing.Size(387, 20)
        Me.TBMotivo.TabIndex = 9
        '
        'BAceptar
        '
        Me.BAceptar.Enabled = False
        Me.BAceptar.Location = New System.Drawing.Point(405, 167)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 10
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'CBInternos
        '
        Me.CBInternos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBInternos.FormattingEnabled = True
        Me.CBInternos.Location = New System.Drawing.Point(94, 37)
        Me.CBInternos.Name = "CBInternos"
        Me.CBInternos.Size = New System.Drawing.Size(60, 21)
        Me.CBInternos.TabIndex = 11
        '
        'BPuntitos
        '
        Me.BPuntitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPuntitos.Location = New System.Drawing.Point(182, 35)
        Me.BPuntitos.Name = "BPuntitos"
        Me.BPuntitos.Size = New System.Drawing.Size(39, 23)
        Me.BPuntitos.TabIndex = 12
        Me.BPuntitos.Text = "..."
        Me.BPuntitos.UseVisualStyleBackColor = True
        '
        'FrmPedidoLlamada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 238)
        Me.Controls.Add(Me.BPuntitos)
        Me.Controls.Add(Me.CBInternos)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TBMotivo)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmPedidoLlamada"
        Me.Text = "SP5 - MotoCenter - Pedido de llamada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TBMotivo As System.Windows.Forms.TextBox
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents CBInternos As System.Windows.Forms.ComboBox
    Friend WithEvents BPuntitos As System.Windows.Forms.Button

End Class
