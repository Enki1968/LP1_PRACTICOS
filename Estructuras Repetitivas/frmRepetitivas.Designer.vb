<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepetitivas
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
        Me.cmbNumeros = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompletarLista = New System.Windows.Forms.Button()
        Me.lstNumeros = New System.Windows.Forms.ListBox()
        Me.btnCompletarCuadro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbNumeros
        '
        Me.cmbNumeros.FormattingEnabled = True
        Me.cmbNumeros.Location = New System.Drawing.Point(123, 40)
        Me.cmbNumeros.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNumeros.Name = "cmbNumeros"
        Me.cmbNumeros.Size = New System.Drawing.Size(88, 24)
        Me.cmbNumeros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de mes:"
        '
        'btnCompletarLista
        '
        Me.btnCompletarLista.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCompletarLista.Location = New System.Drawing.Point(10, 83)
        Me.btnCompletarLista.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompletarLista.Name = "btnCompletarLista"
        Me.btnCompletarLista.Size = New System.Drawing.Size(201, 28)
        Me.btnCompletarLista.TabIndex = 2
        Me.btnCompletarLista.Text = "Completar Lista"
        Me.btnCompletarLista.UseVisualStyleBackColor = False
        '
        'lstNumeros
        '
        Me.lstNumeros.FormattingEnabled = True
        Me.lstNumeros.ItemHeight = 16
        Me.lstNumeros.Location = New System.Drawing.Point(10, 131)
        Me.lstNumeros.Name = "lstNumeros"
        Me.lstNumeros.Size = New System.Drawing.Size(201, 148)
        Me.lstNumeros.TabIndex = 3
        '
        'btnCompletarCuadro
        '
        Me.btnCompletarCuadro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCompletarCuadro.Location = New System.Drawing.Point(10, 299)
        Me.btnCompletarCuadro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompletarCuadro.Name = "btnCompletarCuadro"
        Me.btnCompletarCuadro.Size = New System.Drawing.Size(201, 28)
        Me.btnCompletarCuadro.TabIndex = 4
        Me.btnCompletarCuadro.Text = "Completar Cuadro"
        Me.btnCompletarCuadro.UseVisualStyleBackColor = False
        '
        'frmRepetitivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 348)
        Me.Controls.Add(Me.btnCompletarCuadro)
        Me.Controls.Add(Me.lstNumeros)
        Me.Controls.Add(Me.btnCompletarLista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNumeros)
        Me.Font = New System.Drawing.Font("Humnst777 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRepetitivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repetitivas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbNumeros As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompletarLista As Button
    Friend WithEvents lstNumeros As ListBox
    Friend WithEvents btnCompletarCuadro As Button
End Class
