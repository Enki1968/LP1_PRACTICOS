<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcular
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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumeroB = New System.Windows.Forms.Label()
        Me.lblNumeroA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.lblSumar = New System.Windows.Forms.Label()
        Me.lblDividir = New System.Windows.Forms.Label()
        Me.lblMultiplicar = New System.Windows.Forms.Label()
        Me.lblRestar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(130, 35)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(90, 23)
        Me.txtA.TabIndex = 0
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(130, 65)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(90, 23)
        Me.txtB.TabIndex = 1
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lblNumeroB)
        Me.GroupBox1.Controls.Add(Me.txtB)
        Me.GroupBox1.Controls.Add(Me.lblNumeroA)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(230, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Números"
        '
        'lblNumeroB
        '
        Me.lblNumeroB.AutoSize = True
        Me.lblNumeroB.Location = New System.Drawing.Point(40, 67)
        Me.lblNumeroB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroB.Name = "lblNumeroB"
        Me.lblNumeroB.Size = New System.Drawing.Size(69, 16)
        Me.lblNumeroB.TabIndex = 1
        Me.lblNumeroB.Text = "Número B"
        '
        'lblNumeroA
        '
        Me.lblNumeroA.AutoSize = True
        Me.lblNumeroA.Location = New System.Drawing.Point(40, 37)
        Me.lblNumeroA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroA.Name = "lblNumeroA"
        Me.lblNumeroA.Size = New System.Drawing.Size(71, 16)
        Me.lblNumeroA.TabIndex = 0
        Me.lblNumeroA.Text = "Número A"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.lblDivision)
        Me.GroupBox2.Controls.Add(Me.lblProducto)
        Me.GroupBox2.Controls.Add(Me.lblResta)
        Me.GroupBox2.Controls.Add(Me.lblSuma)
        Me.GroupBox2.Controls.Add(Me.lblSumar)
        Me.GroupBox2.Controls.Add(Me.lblDividir)
        Me.GroupBox2.Controls.Add(Me.lblMultiplicar)
        Me.GroupBox2.Controls.Add(Me.lblRestar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 180)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(230, 160)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'lblDivision
        '
        Me.lblDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivision.Location = New System.Drawing.Point(130, 120)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(90, 23)
        Me.lblDivision.TabIndex = 8
        Me.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProducto
        '
        Me.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProducto.Location = New System.Drawing.Point(130, 90)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(90, 23)
        Me.lblProducto.TabIndex = 7
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResta
        '
        Me.lblResta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResta.Location = New System.Drawing.Point(130, 60)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(90, 23)
        Me.lblResta.TabIndex = 6
        Me.lblResta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuma
        '
        Me.lblSuma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSuma.Location = New System.Drawing.Point(130, 30)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(90, 23)
        Me.lblSuma.TabIndex = 5
        Me.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSumar
        '
        Me.lblSumar.AutoSize = True
        Me.lblSumar.Location = New System.Drawing.Point(40, 30)
        Me.lblSumar.Name = "lblSumar"
        Me.lblSumar.Size = New System.Drawing.Size(49, 16)
        Me.lblSumar.TabIndex = 4
        Me.lblSumar.Text = "Sumar"
        '
        'lblDividir
        '
        Me.lblDividir.AutoSize = True
        Me.lblDividir.Location = New System.Drawing.Point(40, 120)
        Me.lblDividir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDividir.Name = "lblDividir"
        Me.lblDividir.Size = New System.Drawing.Size(48, 16)
        Me.lblDividir.TabIndex = 3
        Me.lblDividir.Text = "Dividir"
        '
        'lblMultiplicar
        '
        Me.lblMultiplicar.AutoSize = True
        Me.lblMultiplicar.Location = New System.Drawing.Point(40, 90)
        Me.lblMultiplicar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMultiplicar.Name = "lblMultiplicar"
        Me.lblMultiplicar.Size = New System.Drawing.Size(74, 16)
        Me.lblMultiplicar.TabIndex = 2
        Me.lblMultiplicar.Text = "Multiplicar"
        '
        'lblRestar
        '
        Me.lblRestar.AutoSize = True
        Me.lblRestar.Location = New System.Drawing.Point(40, 60)
        Me.lblRestar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRestar.Name = "lblRestar"
        Me.lblRestar.Size = New System.Drawing.Size(52, 16)
        Me.lblRestar.TabIndex = 1
        Me.lblRestar.Text = "Restar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " "
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.LightGreen
        Me.btnCalcular.FlatAppearance.BorderSize = 5
        Me.btnCalcular.Location = New System.Drawing.Point(77, 140)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(122, 25)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'frmCalcular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 362)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmCalcular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumeroB As Label
    Friend WithEvents lblNumeroA As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDividir As Label
    Friend WithEvents lblMultiplicar As Label
    Friend WithEvents lblRestar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblSumar As Label
    Friend WithEvents lblDivision As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblResta As Label
    Friend WithEvents lblSuma As Label
End Class
