<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTotales
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
        Me.GRILLA = New System.Windows.Forms.DataGridView
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRILLA
        '
        Me.GRILLA.AllowUserToAddRows = False
        Me.GRILLA.AllowUserToDeleteRows = False
        Me.GRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRILLA.Location = New System.Drawing.Point(39, 33)
        Me.GRILLA.Name = "GRILLA"
        Me.GRILLA.ReadOnly = True
        Me.GRILLA.Size = New System.Drawing.Size(482, 196)
        Me.GRILLA.TabIndex = 0
        '
        'FrmTotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 262)
        Me.Controls.Add(Me.GRILLA)
        Me.Name = "FrmTotales"
        Me.Text = "SP6 - Bar Rico Café - Totales de ventas por mozo y mesa"
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRILLA As System.Windows.Forms.DataGridView
End Class
