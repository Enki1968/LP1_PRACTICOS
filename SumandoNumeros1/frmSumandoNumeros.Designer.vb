<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumandoNumeros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSumarWhile
        '
        Me.btnSumarWhile.Location = New System.Drawing.Point(15, 165)
        Me.btnSumarWhile.Name = "btnSumarWhile"
        Me.btnSumarWhile.Size = New System.Drawing.Size(115, 35)
        Me.btnSumarWhile.TabIndex = 0
        Me.btnSumarWhile.Text = "Sumar con While"
        Me.btnSumarWhile.UseVisualStyleBackColor = True
        '
        'btnSumarFor
        '
        Me.btnSumarFor.Location = New System.Drawing.Point(150, 165)
        Me.btnSumarFor.Name = "btnSumarFor"
        Me.btnSumarFor.Size = New System.Drawing.Size(115, 35)
        Me.btnSumarFor.TabIndex = 1
        Me.btnSumarFor.Text = "Sumar con For"
        Me.btnSumarFor.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(285, 165)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(115, 35)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sumar todos los números hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado de la suma:"
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(265, 85)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(135, 23)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(265, 37)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(135, 23)
        Me.txtHasta.TabIndex = 6
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSumandoNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(456, 223)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSumarFor)
        Me.Controls.Add(Me.btnSumarWhile)
        Me.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSumandoNumeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumando Números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSumarWhile As Button
    Friend WithEvents btnSumarFor As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtHasta As TextBox
End Class
