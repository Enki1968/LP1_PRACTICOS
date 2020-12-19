<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumarDosNumeros
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
        Me.lblNumeroA = New System.Windows.Forms.Label()
        Me.lblNumeroB = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumeroA
        '
        Me.lblNumeroA.AutoSize = True
        Me.lblNumeroA.Location = New System.Drawing.Point(15, 28)
        Me.lblNumeroA.Name = "lblNumeroA"
        Me.lblNumeroA.Size = New System.Drawing.Size(57, 13)
        Me.lblNumeroA.TabIndex = 0
        Me.lblNumeroA.Text = "Número A:"
        '
        'lblNumeroB
        '
        Me.lblNumeroB.AutoSize = True
        Me.lblNumeroB.Location = New System.Drawing.Point(15, 63)
        Me.lblNumeroB.Name = "lblNumeroB"
        Me.lblNumeroB.Size = New System.Drawing.Size(57, 13)
        Me.lblNumeroB.TabIndex = 1
        Me.lblNumeroB.Text = "Número B:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(15, 141)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(58, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Resultado:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(125, 25)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 3
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(125, 60)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 4
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(125, 95)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(100, 25)
        Me.btnSumar.TabIndex = 5
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'lblResultado
        '
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultado.Location = New System.Drawing.Point(125, 136)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(100, 25)
        Me.lblResultado.TabIndex = 7
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSumarDosNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 171)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblNumeroB)
        Me.Controls.Add(Me.lblNumeroA)
        Me.Name = "frmSumarDosNumeros"
        Me.Text = "Sumar dos números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroA As Label
    Friend WithEvents lblNumeroB As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultado As Label
End Class
