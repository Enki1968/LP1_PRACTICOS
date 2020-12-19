<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeses
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
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.cmdMostarMes = New System.Windows.Forms.Button()
        Me.lblNombreMes = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNombreMes)
        Me.GroupBox1.Controls.Add(Me.cmdMostarMes)
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(428, 259)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre del mes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número del mes:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(206, 37)
        Me.txtMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(148, 22)
        Me.txtMes.TabIndex = 1
        Me.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdMostarMes
        '
        Me.cmdMostarMes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMostarMes.Enabled = False
        Me.cmdMostarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMostarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMostarMes.ForeColor = System.Drawing.Color.Black
        Me.cmdMostarMes.Location = New System.Drawing.Point(58, 95)
        Me.cmdMostarMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdMostarMes.Name = "cmdMostarMes"
        Me.cmdMostarMes.Size = New System.Drawing.Size(300, 55)
        Me.cmdMostarMes.TabIndex = 2
        Me.cmdMostarMes.Text = "Mostrar Mes"
        Me.cmdMostarMes.UseVisualStyleBackColor = False
        '
        'lblNombreMes
        '
        Me.lblNombreMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMes.ForeColor = System.Drawing.Color.Red
        Me.lblNombreMes.Location = New System.Drawing.Point(57, 170)
        Me.lblNombreMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreMes.Name = "lblNombreMes"
        Me.lblNombreMes.Size = New System.Drawing.Size(300, 65)
        Me.lblNombreMes.TabIndex = 3
        Me.lblNombreMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMeses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 287)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMeses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombreMes As Label
    Friend WithEvents cmdMostarMes As Button
    Friend WithEvents txtMes As TextBox
    Friend WithEvents Label1 As Label
End Class
