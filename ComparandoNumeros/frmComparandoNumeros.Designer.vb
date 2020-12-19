<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComparandoNumeros
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
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblNumeroB = New System.Windows.Forms.Label()
        Me.lblNumeroA = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResultados)
        Me.GroupBox1.Controls.Add(Me.btnComparar)
        Me.GroupBox1.Controls.Add(Me.txtB)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.lblNumeroB)
        Me.GroupBox1.Controls.Add(Me.lblNumeroA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comparación de dos números "
        '
        'lblResultados
        '
        Me.lblResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultados.Location = New System.Drawing.Point(19, 176)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(222, 48)
        Me.lblResultados.TabIndex = 5
        Me.lblResultados.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblResultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnComparar
        '
        Me.btnComparar.Enabled = False
        Me.btnComparar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComparar.Location = New System.Drawing.Point(19, 108)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(222, 49)
        Me.btnComparar.TabIndex = 4
        Me.btnComparar.Text = "Comparar"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(100, 65)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(141, 20)
        Me.txtB.TabIndex = 3
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(100, 35)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(141, 20)
        Me.txtA.TabIndex = 2
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNumeroB
        '
        Me.lblNumeroB.AutoSize = True
        Me.lblNumeroB.Location = New System.Drawing.Point(25, 68)
        Me.lblNumeroB.Name = "lblNumeroB"
        Me.lblNumeroB.Size = New System.Drawing.Size(57, 13)
        Me.lblNumeroB.TabIndex = 1
        Me.lblNumeroB.Text = "Número B:"
        '
        'lblNumeroA
        '
        Me.lblNumeroA.AutoSize = True
        Me.lblNumeroA.Location = New System.Drawing.Point(25, 38)
        Me.lblNumeroA.Name = "lblNumeroA"
        Me.lblNumeroA.Size = New System.Drawing.Size(57, 13)
        Me.lblNumeroA.TabIndex = 0
        Me.lblNumeroA.Text = "Número A:"
        '
        'frmComparandoNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmComparandoNumeros"
        Me.Text = "Comparando Números"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblResultados As Label
    Friend WithEvents btnComparar As Button
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblNumeroB As Label
    Friend WithEvents lblNumeroA As Label
End Class
