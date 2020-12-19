<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumandoNumeros2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.cmdSumarWhile = New System.Windows.Forms.Button()
        Me.cmdSumarFor = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHasta)
        Me.GroupBox1.Controls.Add(Me.txtDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(190, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Números a sumar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(92, 23)
        Me.txtDesde.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(80, 23)
        Me.txtDesde.TabIndex = 2
        Me.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(92, 62)
        Me.txtHasta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(80, 23)
        Me.txtHasta.TabIndex = 3
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Resultado:"
        '
        'lblResultado
        '
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(105, 131)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(80, 23)
        Me.lblResultado.TabIndex = 2
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSumarWhile
        '
        Me.cmdSumarWhile.Location = New System.Drawing.Point(224, 20)
        Me.cmdSumarWhile.Name = "cmdSumarWhile"
        Me.cmdSumarWhile.Size = New System.Drawing.Size(123, 30)
        Me.cmdSumarWhile.TabIndex = 3
        Me.cmdSumarWhile.Text = "Sumar con While"
        Me.cmdSumarWhile.UseVisualStyleBackColor = True
        '
        'cmdSumarFor
        '
        Me.cmdSumarFor.Location = New System.Drawing.Point(224, 70)
        Me.cmdSumarFor.Name = "cmdSumarFor"
        Me.cmdSumarFor.Size = New System.Drawing.Size(123, 30)
        Me.cmdSumarFor.TabIndex = 4
        Me.cmdSumarFor.Text = "Sumar con For"
        Me.cmdSumarFor.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(224, 120)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(123, 30)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar Resultado"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'frmSumandoNumeros2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(367, 174)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdSumarFor)
        Me.Controls.Add(Me.cmdSumarWhile)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSumandoNumeros2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumando Números2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents cmdSumarWhile As Button
    Friend WithEvents cmdSumarFor As Button
    Friend WithEvents cmdBorrar As Button
End Class
