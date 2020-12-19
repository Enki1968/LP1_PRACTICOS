<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcercaDe))
        Me.grpOne = New System.Windows.Forms.GroupBox()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.grpOne.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOne
        '
        Me.grpOne.BackColor = System.Drawing.Color.White
        Me.grpOne.Controls.Add(Me.lblFour)
        Me.grpOne.Controls.Add(Me.lblFive)
        Me.grpOne.Controls.Add(Me.lblThree)
        Me.grpOne.Controls.Add(Me.lblTwo)
        Me.grpOne.Controls.Add(Me.lblOne)
        Me.grpOne.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOne.Location = New System.Drawing.Point(12, 12)
        Me.grpOne.Name = "grpOne"
        Me.grpOne.Size = New System.Drawing.Size(460, 237)
        Me.grpOne.TabIndex = 1
        Me.grpOne.TabStop = False
        Me.grpOne.Text = "Datos del Programador"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.BackColor = System.Drawing.Color.Transparent
        Me.lblFour.Location = New System.Drawing.Point(184, 158)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(257, 18)
        Me.lblFour.TabIndex = 4
        Me.lblFour.Text = "Laboratorio de Programación 1"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.BackColor = System.Drawing.Color.Transparent
        Me.lblFive.Location = New System.Drawing.Point(307, 201)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(131, 18)
        Me.lblFive.TabIndex = 3
        Me.lblFive.Text = "Examen Parcial"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.BackColor = System.Drawing.Color.Transparent
        Me.lblThree.Location = New System.Drawing.Point(130, 114)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(308, 18)
        Me.lblThree.TabIndex = 2
        Me.lblThree.Text = "Analista de Sistemas de Computación"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.BackColor = System.Drawing.Color.Transparent
        Me.lblTwo.Location = New System.Drawing.Point(31, 70)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(126, 18)
        Me.lblTwo.TabIndex = 1
        Me.lblTwo.Text = "DNI: 34676514"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.BackColor = System.Drawing.Color.Transparent
        Me.lblOne.Location = New System.Drawing.Point(31, 34)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(225, 18)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "Nehemias Guillermo Toledo"
        '
        'FrmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.grpOne)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de..."
        Me.grpOne.ResumeLayout(False)
        Me.grpOne.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOne As GroupBox
    Friend WithEvents lblFour As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents lblThree As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblOne As Label
End Class
