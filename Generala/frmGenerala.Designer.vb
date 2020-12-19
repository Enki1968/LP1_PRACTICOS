<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerala
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
        Me.pctDado1 = New System.Windows.Forms.PictureBox()
        Me.pctDado2 = New System.Windows.Forms.PictureBox()
        Me.pctDado3 = New System.Windows.Forms.PictureBox()
        Me.pctDado4 = New System.Windows.Forms.PictureBox()
        Me.pctDado5 = New System.Windows.Forms.PictureBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnArrojarDado = New System.Windows.Forms.Button()
        Me.btnVolverATirar = New System.Windows.Forms.Button()
        CType(Me.pctDado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctDado1
        '
        Me.pctDado1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDado1.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pctDado1.Location = New System.Drawing.Point(12, 12)
        Me.pctDado1.Name = "pctDado1"
        Me.pctDado1.Size = New System.Drawing.Size(80, 80)
        Me.pctDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDado1.TabIndex = 0
        Me.pctDado1.TabStop = False
        '
        'pctDado2
        '
        Me.pctDado2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDado2.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pctDado2.Location = New System.Drawing.Point(112, 12)
        Me.pctDado2.Name = "pctDado2"
        Me.pctDado2.Size = New System.Drawing.Size(80, 80)
        Me.pctDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDado2.TabIndex = 1
        Me.pctDado2.TabStop = False
        '
        'pctDado3
        '
        Me.pctDado3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDado3.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pctDado3.Location = New System.Drawing.Point(212, 13)
        Me.pctDado3.Name = "pctDado3"
        Me.pctDado3.Size = New System.Drawing.Size(80, 80)
        Me.pctDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDado3.TabIndex = 2
        Me.pctDado3.TabStop = False
        '
        'pctDado4
        '
        Me.pctDado4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDado4.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pctDado4.Location = New System.Drawing.Point(312, 12)
        Me.pctDado4.Name = "pctDado4"
        Me.pctDado4.Size = New System.Drawing.Size(80, 80)
        Me.pctDado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDado4.TabIndex = 3
        Me.pctDado4.TabStop = False
        '
        'pctDado5
        '
        Me.pctDado5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctDado5.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pctDado5.Location = New System.Drawing.Point(412, 12)
        Me.pctDado5.Name = "pctDado5"
        Me.pctDado5.Size = New System.Drawing.Size(80, 80)
        Me.pctDado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDado5.TabIndex = 4
        Me.pctDado5.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(12, 130)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(480, 90)
        Me.lblMensaje.TabIndex = 5
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnArrojarDado
        '
        Me.btnArrojarDado.BackColor = System.Drawing.Color.Tomato
        Me.btnArrojarDado.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrojarDado.Location = New System.Drawing.Point(12, 250)
        Me.btnArrojarDado.Name = "btnArrojarDado"
        Me.btnArrojarDado.Size = New System.Drawing.Size(480, 60)
        Me.btnArrojarDado.TabIndex = 6
        Me.btnArrojarDado.Text = "Arrojar Dado"
        Me.btnArrojarDado.UseVisualStyleBackColor = False
        '
        'btnVolverATirar
        '
        Me.btnVolverATirar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnVolverATirar.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverATirar.Location = New System.Drawing.Point(12, 340)
        Me.btnVolverATirar.Name = "btnVolverATirar"
        Me.btnVolverATirar.Size = New System.Drawing.Size(480, 40)
        Me.btnVolverATirar.TabIndex = 7
        Me.btnVolverATirar.Text = "Vover a tirar"
        Me.btnVolverATirar.UseVisualStyleBackColor = False
        '
        'frmGenerala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(504, 397)
        Me.Controls.Add(Me.btnVolverATirar)
        Me.Controls.Add(Me.btnArrojarDado)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.pctDado5)
        Me.Controls.Add(Me.pctDado4)
        Me.Controls.Add(Me.pctDado3)
        Me.Controls.Add(Me.pctDado2)
        Me.Controls.Add(Me.pctDado1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmGenerala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generala"
        CType(Me.pctDado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctDado1 As PictureBox
    Friend WithEvents pctDado2 As PictureBox
    Friend WithEvents pctDado3 As PictureBox
    Friend WithEvents pctDado4 As PictureBox
    Friend WithEvents pctDado5 As PictureBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnArrojarDado As Button
    Friend WithEvents btnVolverATirar As Button
End Class
