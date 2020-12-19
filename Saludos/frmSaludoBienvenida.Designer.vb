<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaludoBienvenida
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
        Me.btnSaludar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSaludar
        '
        Me.btnSaludar.Location = New System.Drawing.Point(16, 101)
        Me.btnSaludar.Name = "btnSaludar"
        Me.btnSaludar.Size = New System.Drawing.Size(146, 40)
        Me.btnSaludar.TabIndex = 0
        Me.btnSaludar.Text = "Saludar"
        Me.btnSaludar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(168, 101)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(146, 40)
        Me.btnBorrar.TabIndex = 1
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(16, 20)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(298, 47)
        Me.lblMensaje.TabIndex = 2
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSaludoBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 165)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSaludar)
        Me.Name = "frmSaludoBienvenida"
        Me.Text = "Saludos de Bienvenida"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSaludar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblMensaje As Label
End Class
