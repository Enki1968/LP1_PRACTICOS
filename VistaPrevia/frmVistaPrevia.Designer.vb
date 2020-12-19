<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaPrevia
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbAzul = New System.Windows.Forms.RadioButton()
        Me.rdbVerde = New System.Windows.Forms.RadioButton()
        Me.rdbRojo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbAmarillo = New System.Windows.Forms.RadioButton()
        Me.rdbRosa = New System.Windows.Forms.RadioButton()
        Me.rdbCeleste = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(25, 18)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(292, 75)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Vista Previa de un texto"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbAzul)
        Me.GroupBox1.Controls.Add(Me.rdbVerde)
        Me.GroupBox1.Controls.Add(Me.rdbRojo)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de Texto"
        '
        'rdbAzul
        '
        Me.rdbAzul.AutoSize = True
        Me.rdbAzul.Location = New System.Drawing.Point(10, 100)
        Me.rdbAzul.Name = "rdbAzul"
        Me.rdbAzul.Size = New System.Drawing.Size(45, 17)
        Me.rdbAzul.TabIndex = 2
        Me.rdbAzul.TabStop = True
        Me.rdbAzul.Text = "Azul"
        Me.rdbAzul.UseVisualStyleBackColor = True
        '
        'rdbVerde
        '
        Me.rdbVerde.AutoSize = True
        Me.rdbVerde.Location = New System.Drawing.Point(10, 60)
        Me.rdbVerde.Name = "rdbVerde"
        Me.rdbVerde.Size = New System.Drawing.Size(53, 17)
        Me.rdbVerde.TabIndex = 1
        Me.rdbVerde.TabStop = True
        Me.rdbVerde.Text = "Verde"
        Me.rdbVerde.UseVisualStyleBackColor = True
        '
        'rdbRojo
        '
        Me.rdbRojo.AutoSize = True
        Me.rdbRojo.BackColor = System.Drawing.SystemColors.Control
        Me.rdbRojo.Checked = True
        Me.rdbRojo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbRojo.Location = New System.Drawing.Point(10, 20)
        Me.rdbRojo.Name = "rdbRojo"
        Me.rdbRojo.Size = New System.Drawing.Size(47, 17)
        Me.rdbRojo.TabIndex = 0
        Me.rdbRojo.TabStop = True
        Me.rdbRojo.Text = "Rojo"
        Me.rdbRojo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbAmarillo)
        Me.GroupBox2.Controls.Add(Me.rdbRosa)
        Me.GroupBox2.Controls.Add(Me.rdbCeleste)
        Me.GroupBox2.Location = New System.Drawing.Point(187, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 130)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de Fondo"
        '
        'rdbAmarillo
        '
        Me.rdbAmarillo.AutoSize = True
        Me.rdbAmarillo.Location = New System.Drawing.Point(10, 100)
        Me.rdbAmarillo.Name = "rdbAmarillo"
        Me.rdbAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.rdbAmarillo.TabIndex = 2
        Me.rdbAmarillo.TabStop = True
        Me.rdbAmarillo.Text = "Amarillo"
        Me.rdbAmarillo.UseVisualStyleBackColor = True
        '
        'rdbRosa
        '
        Me.rdbRosa.AutoSize = True
        Me.rdbRosa.Location = New System.Drawing.Point(10, 60)
        Me.rdbRosa.Name = "rdbRosa"
        Me.rdbRosa.Size = New System.Drawing.Size(50, 17)
        Me.rdbRosa.TabIndex = 1
        Me.rdbRosa.TabStop = True
        Me.rdbRosa.Text = "Rosa"
        Me.rdbRosa.UseVisualStyleBackColor = True
        '
        'rdbCeleste
        '
        Me.rdbCeleste.AutoSize = True
        Me.rdbCeleste.Checked = True
        Me.rdbCeleste.Location = New System.Drawing.Point(10, 20)
        Me.rdbCeleste.Name = "rdbCeleste"
        Me.rdbCeleste.Size = New System.Drawing.Size(60, 17)
        Me.rdbCeleste.TabIndex = 0
        Me.rdbCeleste.TabStop = True
        Me.rdbCeleste.Text = "Celeste"
        Me.rdbCeleste.UseVisualStyleBackColor = True
        '
        'frmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 263)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTexto)
        Me.Name = "frmVistaPrevia"
        Me.Text = "Vista previa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTexto As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbAzul As RadioButton
    Friend WithEvents rdbVerde As RadioButton
    Friend WithEvents rdbRojo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbAmarillo As RadioButton
    Friend WithEvents rdbRosa As RadioButton
    Friend WithEvents rdbCeleste As RadioButton
End Class
