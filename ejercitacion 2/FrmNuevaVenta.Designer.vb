<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaVenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBMozos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBMesas = New System.Windows.Forms.ComboBox()
        Me.TBImporte = New System.Windows.Forms.TextBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BTotales = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mozos"
        '
        'LBMozos
        '
        Me.LBMozos.FormattingEnabled = True
        Me.LBMozos.Location = New System.Drawing.Point(54, 45)
        Me.LBMozos.Name = "LBMozos"
        Me.LBMozos.Size = New System.Drawing.Size(192, 95)
        Me.LBMozos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mesa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Importe"
        '
        'CBMesas
        '
        Me.CBMesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMesas.FormattingEnabled = True
        Me.CBMesas.Location = New System.Drawing.Point(293, 45)
        Me.CBMesas.Name = "CBMesas"
        Me.CBMesas.Size = New System.Drawing.Size(82, 21)
        Me.CBMesas.TabIndex = 5
        '
        'TBImporte
        '
        Me.TBImporte.Location = New System.Drawing.Point(293, 120)
        Me.TBImporte.Name = "TBImporte"
        Me.TBImporte.Size = New System.Drawing.Size(82, 20)
        Me.TBImporte.TabIndex = 6
        '
        'BAgregar
        '
        Me.BAgregar.Enabled = False
        Me.BAgregar.Location = New System.Drawing.Point(164, 172)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(82, 44)
        Me.BAgregar.TabIndex = 7
        Me.BAgregar.Text = "Agregar nueva venta"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BTotales
        '
        Me.BTotales.Location = New System.Drawing.Point(293, 172)
        Me.BTotales.Name = "BTotales"
        Me.BTotales.Size = New System.Drawing.Size(82, 44)
        Me.BTotales.TabIndex = 8
        Me.BTotales.Text = "Totales por mozo y mesa"
        Me.BTotales.UseVisualStyleBackColor = True
        '
        'FrmNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 241)
        Me.Controls.Add(Me.BTotales)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.TBImporte)
        Me.Controls.Add(Me.CBMesas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBMozos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNuevaVenta"
        Me.Text = "Bar Rico Café - Nueva venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBMozos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBMesas As System.Windows.Forms.ComboBox
    Friend WithEvents TBImporte As System.Windows.Forms.TextBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BTotales As System.Windows.Forms.Button

End Class
