<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumandoNumeros3
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
        Me.btnSumarWhile = New System.Windows.Forms.Button()
        Me.btnSumarFor = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbMultiplo10 = New System.Windows.Forms.RadioButton()
        Me.rdbMultiplo5 = New System.Windows.Forms.RadioButton()
        Me.rdbMultiplo2 = New System.Windows.Forms.RadioButton()
        Me.rdbTodosLosNumeros = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSumarWhile
        '
        Me.btnSumarWhile.Location = New System.Drawing.Point(13, 275)
        Me.btnSumarWhile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSumarWhile.Name = "btnSumarWhile"
        Me.btnSumarWhile.Size = New System.Drawing.Size(182, 28)
        Me.btnSumarWhile.TabIndex = 0
        Me.btnSumarWhile.Text = "Sumar con While"
        Me.btnSumarWhile.UseVisualStyleBackColor = True
        '
        'btnSumarFor
        '
        Me.btnSumarFor.Location = New System.Drawing.Point(13, 320)
        Me.btnSumarFor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSumarFor.Name = "btnSumarFor"
        Me.btnSumarFor.Size = New System.Drawing.Size(182, 28)
        Me.btnSumarFor.TabIndex = 1
        Me.btnSumarFor.Text = "Sumar con For"
        Me.btnSumarFor.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(13, 365)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(182, 28)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar resultado"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMultiplo10)
        Me.GroupBox1.Controls.Add(Me.rdbMultiplo5)
        Me.GroupBox1.Controls.Add(Me.rdbMultiplo2)
        Me.GroupBox1.Controls.Add(Me.rdbTodosLosNumeros)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 143)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Números a sumar:"
        '
        'rdbMultiplo10
        '
        Me.rdbMultiplo10.AutoSize = True
        Me.rdbMultiplo10.Location = New System.Drawing.Point(18, 115)
        Me.rdbMultiplo10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbMultiplo10.Name = "rdbMultiplo10"
        Me.rdbMultiplo10.Size = New System.Drawing.Size(115, 20)
        Me.rdbMultiplo10.TabIndex = 3
        Me.rdbMultiplo10.TabStop = True
        Me.rdbMultiplo10.Text = "Múltiplo de 10"
        Me.rdbMultiplo10.UseVisualStyleBackColor = True
        '
        'rdbMultiplo5
        '
        Me.rdbMultiplo5.AutoSize = True
        Me.rdbMultiplo5.Location = New System.Drawing.Point(18, 85)
        Me.rdbMultiplo5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbMultiplo5.Name = "rdbMultiplo5"
        Me.rdbMultiplo5.Size = New System.Drawing.Size(108, 20)
        Me.rdbMultiplo5.TabIndex = 2
        Me.rdbMultiplo5.TabStop = True
        Me.rdbMultiplo5.Text = "Múltiplo de 5"
        Me.rdbMultiplo5.UseVisualStyleBackColor = True
        '
        'rdbMultiplo2
        '
        Me.rdbMultiplo2.AutoSize = True
        Me.rdbMultiplo2.Location = New System.Drawing.Point(18, 55)
        Me.rdbMultiplo2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbMultiplo2.Name = "rdbMultiplo2"
        Me.rdbMultiplo2.Size = New System.Drawing.Size(108, 20)
        Me.rdbMultiplo2.TabIndex = 1
        Me.rdbMultiplo2.TabStop = True
        Me.rdbMultiplo2.Text = "Múltiplo de 2"
        Me.rdbMultiplo2.UseVisualStyleBackColor = True
        '
        'rdbTodosLosNumeros
        '
        Me.rdbTodosLosNumeros.AutoSize = True
        Me.rdbTodosLosNumeros.Checked = True
        Me.rdbTodosLosNumeros.Location = New System.Drawing.Point(18, 25)
        Me.rdbTodosLosNumeros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbTodosLosNumeros.Name = "rdbTodosLosNumeros"
        Me.rdbTodosLosNumeros.Size = New System.Drawing.Size(144, 20)
        Me.rdbTodosLosNumeros.TabIndex = 0
        Me.rdbTodosLosNumeros.TabStop = True
        Me.rdbTodosLosNumeros.Text = "Todos los números"
        Me.rdbTodosLosNumeros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 177)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Resultado:"
        '
        'lblResultado
        '
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(95, 223)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(100, 25)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(98, 176)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 22)
        Me.txtHasta.TabIndex = 7
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSumandoNumeros3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(211, 411)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSumarFor)
        Me.Controls.Add(Me.btnSumarWhile)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSumandoNumeros3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumando Números3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSumarWhile As Button
    Friend WithEvents btnSumarFor As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbMultiplo10 As RadioButton
    Friend WithEvents rdbMultiplo5 As RadioButton
    Friend WithEvents rdbMultiplo2 As RadioButton
    Friend WithEvents rdbTodosLosNumeros As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtHasta As TextBox
End Class
