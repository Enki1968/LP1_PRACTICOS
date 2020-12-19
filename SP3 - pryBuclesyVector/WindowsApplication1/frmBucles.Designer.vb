<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBucles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdDo = New System.Windows.Forms.Button
        Me.lstResultado = New System.Windows.Forms.ListBox
        Me.cmdFor = New System.Windows.Forms.Button
        Me.cmdCarga = New System.Windows.Forms.Button
        Me.cmdForEach = New System.Windows.Forms.Button
        Me.cmdOrdenar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdDo
        '
        Me.cmdDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDo.Location = New System.Drawing.Point(194, 12)
        Me.cmdDo.Name = "cmdDo"
        Me.cmdDo.Size = New System.Drawing.Size(152, 46)
        Me.cmdDo.TabIndex = 0
        Me.cmdDo.Text = "Do While"
        Me.cmdDo.UseVisualStyleBackColor = True
        '
        'lstResultado
        '
        Me.lstResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.ItemHeight = 25
        Me.lstResultado.Location = New System.Drawing.Point(12, 12)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(152, 254)
        Me.lstResultado.TabIndex = 1
        '
        'cmdFor
        '
        Me.cmdFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFor.Location = New System.Drawing.Point(194, 64)
        Me.cmdFor.Name = "cmdFor"
        Me.cmdFor.Size = New System.Drawing.Size(152, 46)
        Me.cmdFor.TabIndex = 2
        Me.cmdFor.Text = "For"
        Me.cmdFor.UseVisualStyleBackColor = True
        '
        'cmdCarga
        '
        Me.cmdCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCarga.Location = New System.Drawing.Point(194, 116)
        Me.cmdCarga.Name = "cmdCarga"
        Me.cmdCarga.Size = New System.Drawing.Size(152, 46)
        Me.cmdCarga.TabIndex = 3
        Me.cmdCarga.Text = "Carga"
        Me.cmdCarga.UseVisualStyleBackColor = True
        '
        'cmdForEach
        '
        Me.cmdForEach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForEach.Location = New System.Drawing.Point(194, 168)
        Me.cmdForEach.Name = "cmdForEach"
        Me.cmdForEach.Size = New System.Drawing.Size(152, 46)
        Me.cmdForEach.TabIndex = 4
        Me.cmdForEach.Text = "For Each"
        Me.cmdForEach.UseVisualStyleBackColor = True
        '
        'cmdOrdenar
        '
        Me.cmdOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrdenar.Location = New System.Drawing.Point(194, 220)
        Me.cmdOrdenar.Name = "cmdOrdenar"
        Me.cmdOrdenar.Size = New System.Drawing.Size(152, 46)
        Me.cmdOrdenar.TabIndex = 5
        Me.cmdOrdenar.Text = "Ordenar"
        Me.cmdOrdenar.UseVisualStyleBackColor = True
        '
        'frmBucles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 282)
        Me.Controls.Add(Me.cmdOrdenar)
        Me.Controls.Add(Me.cmdForEach)
        Me.Controls.Add(Me.cmdCarga)
        Me.Controls.Add(Me.cmdFor)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.cmdDo)
        Me.Name = "frmBucles"
        Me.Text = "Bucles y Vectores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdDo As System.Windows.Forms.Button
    Friend WithEvents lstResultado As System.Windows.Forms.ListBox
    Friend WithEvents cmdFor As System.Windows.Forms.Button
    Friend WithEvents cmdCarga As System.Windows.Forms.Button
    Friend WithEvents cmdForEach As System.Windows.Forms.Button
    Friend WithEvents cmdOrdenar As System.Windows.Forms.Button

End Class
