<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedimientos
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
        Me.txtExponente = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnCalcularWhile = New System.Windows.Forms.Button()
        Me.btnCalcularFor = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExponente)
        Me.GroupBox1.Controls.Add(Me.txtBase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(203, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Números a sumar:"
        '
        'txtExponente
        '
        Me.txtExponente.Location = New System.Drawing.Point(100, 69)
        Me.txtExponente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtExponente.Name = "txtExponente"
        Me.txtExponente.Size = New System.Drawing.Size(80, 23)
        Me.txtExponente.TabIndex = 3
        Me.txtExponente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(100, 35)
        Me.txtBase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(80, 23)
        Me.txtBase.TabIndex = 2
        Me.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Exponente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Resultado:"
        '
        'lblResultado
        '
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(100, 147)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(117, 28)
        Me.lblResultado.TabIndex = 2
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalcularWhile
        '
        Me.btnCalcularWhile.Enabled = False
        Me.btnCalcularWhile.Location = New System.Drawing.Point(245, 24)
        Me.btnCalcularWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcularWhile.Name = "btnCalcularWhile"
        Me.btnCalcularWhile.Size = New System.Drawing.Size(125, 30)
        Me.btnCalcularWhile.TabIndex = 3
        Me.btnCalcularWhile.Text = "Cacular con While"
        Me.btnCalcularWhile.UseVisualStyleBackColor = True
        '
        'btnCalcularFor
        '
        Me.btnCalcularFor.Enabled = False
        Me.btnCalcularFor.Location = New System.Drawing.Point(245, 87)
        Me.btnCalcularFor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcularFor.Name = "btnCalcularFor"
        Me.btnCalcularFor.Size = New System.Drawing.Size(125, 30)
        Me.btnCalcularFor.TabIndex = 4
        Me.btnCalcularFor.Text = "Calcular con For"
        Me.btnCalcularFor.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(245, 147)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(125, 30)
        Me.btnBorrar.TabIndex = 5
        Me.btnBorrar.Text = "Borrar Resultado"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'frmProcedimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(391, 197)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCalcularFor)
        Me.Controls.Add(Me.btnCalcularWhile)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmProcedimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtExponente As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnCalcularWhile As Button
    Friend WithEvents btnCalcularFor As Button
    Friend WithEvents btnBorrar As Button
End Class
