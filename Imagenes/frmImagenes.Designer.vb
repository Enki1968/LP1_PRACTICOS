<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagenes
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
        Me.rdbMujerInvisible = New System.Windows.Forms.RadioButton()
        Me.rdbLinternaVerde = New System.Windows.Forms.RadioButton()
        Me.rdbMujerMaravilla = New System.Windows.Forms.RadioButton()
        Me.rdbCapitanAmerica = New System.Windows.Forms.RadioButton()
        Me.pctImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMujerInvisible)
        Me.GroupBox1.Controls.Add(Me.rdbLinternaVerde)
        Me.GroupBox1.Controls.Add(Me.rdbMujerMaravilla)
        Me.GroupBox1.Controls.Add(Me.rdbCapitanAmerica)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Superhéroes"
        '
        'rdbMujerInvisible
        '
        Me.rdbMujerInvisible.AutoSize = True
        Me.rdbMujerInvisible.Location = New System.Drawing.Point(22, 150)
        Me.rdbMujerInvisible.Name = "rdbMujerInvisible"
        Me.rdbMujerInvisible.Size = New System.Drawing.Size(92, 17)
        Me.rdbMujerInvisible.TabIndex = 3
        Me.rdbMujerInvisible.Text = "Mujer Invisible"
        Me.rdbMujerInvisible.UseVisualStyleBackColor = True
        '
        'rdbLinternaVerde
        '
        Me.rdbLinternaVerde.AutoSize = True
        Me.rdbLinternaVerde.Location = New System.Drawing.Point(22, 110)
        Me.rdbLinternaVerde.Name = "rdbLinternaVerde"
        Me.rdbLinternaVerde.Size = New System.Drawing.Size(94, 17)
        Me.rdbLinternaVerde.TabIndex = 2
        Me.rdbLinternaVerde.Text = "Linterna Verde"
        Me.rdbLinternaVerde.UseVisualStyleBackColor = True
        '
        'rdbMujerMaravilla
        '
        Me.rdbMujerMaravilla.AutoSize = True
        Me.rdbMujerMaravilla.Location = New System.Drawing.Point(22, 70)
        Me.rdbMujerMaravilla.Name = "rdbMujerMaravilla"
        Me.rdbMujerMaravilla.Size = New System.Drawing.Size(96, 17)
        Me.rdbMujerMaravilla.TabIndex = 1
        Me.rdbMujerMaravilla.Text = "Mujer Maravilla"
        Me.rdbMujerMaravilla.UseVisualStyleBackColor = True
        '
        'rdbCapitanAmerica
        '
        Me.rdbCapitanAmerica.AutoSize = True
        Me.rdbCapitanAmerica.Checked = True
        Me.rdbCapitanAmerica.Location = New System.Drawing.Point(22, 30)
        Me.rdbCapitanAmerica.Name = "rdbCapitanAmerica"
        Me.rdbCapitanAmerica.Size = New System.Drawing.Size(102, 17)
        Me.rdbCapitanAmerica.TabIndex = 0
        Me.rdbCapitanAmerica.TabStop = True
        Me.rdbCapitanAmerica.Text = "Capitán América"
        Me.rdbCapitanAmerica.UseVisualStyleBackColor = True
        '
        'pctImagen
        '
        Me.pctImagen.Image = Global.Imagenes.My.Resources.Resources.CapitanAmerica
        Me.pctImagen.Location = New System.Drawing.Point(235, 45)
        Me.pctImagen.Name = "pctImagen"
        Me.pctImagen.Size = New System.Drawing.Size(200, 200)
        Me.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctImagen.TabIndex = 1
        Me.pctImagen.TabStop = False
        '
        'frmImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 266)
        Me.Controls.Add(Me.pctImagen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmImagenes"
        Me.Text = "Imagenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbLinternaVerde As RadioButton
    Friend WithEvents rdbMujerMaravilla As RadioButton
    Friend WithEvents rdbCapitanAmerica As RadioButton
    Friend WithEvents rdbMujerInvisible As RadioButton
    Friend WithEvents pctImagen As PictureBox
End Class
