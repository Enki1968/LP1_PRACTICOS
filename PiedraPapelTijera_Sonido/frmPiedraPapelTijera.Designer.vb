<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPiedraPapelTijera
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
        Me.pctJugador = New System.Windows.Forms.PictureBox()
        Me.pctPc = New System.Windows.Forms.PictureBox()
        Me.btnPiedra = New System.Windows.Forms.Button()
        Me.btnPapel = New System.Windows.Forms.Button()
        Me.btnTijera = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblJugadas = New System.Windows.Forms.Label()
        Me.lblGanadas = New System.Windows.Forms.Label()
        Me.lblPerdidas = New System.Windows.Forms.Label()
        Me.lblEmpatadas = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pctJugador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctJugador
        '
        Me.pctJugador.BackColor = System.Drawing.Color.Transparent
        Me.pctJugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctJugador.Image = Global.PiedraPapelTijera.My.Resources.Resources.Titulo
        Me.pctJugador.Location = New System.Drawing.Point(12, 55)
        Me.pctJugador.Name = "pctJugador"
        Me.pctJugador.Size = New System.Drawing.Size(190, 185)
        Me.pctJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctJugador.TabIndex = 0
        Me.pctJugador.TabStop = False
        '
        'pctPc
        '
        Me.pctPc.BackColor = System.Drawing.Color.Transparent
        Me.pctPc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctPc.Image = Global.PiedraPapelTijera.My.Resources.Resources.Titulo
        Me.pctPc.Location = New System.Drawing.Point(417, 55)
        Me.pctPc.Name = "pctPc"
        Me.pctPc.Size = New System.Drawing.Size(190, 185)
        Me.pctPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPc.TabIndex = 1
        Me.pctPc.TabStop = False
        '
        'btnPiedra
        '
        Me.btnPiedra.BackColor = System.Drawing.Color.HotPink
        Me.btnPiedra.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPiedra.Location = New System.Drawing.Point(82, 262)
        Me.btnPiedra.Name = "btnPiedra"
        Me.btnPiedra.Size = New System.Drawing.Size(120, 45)
        Me.btnPiedra.TabIndex = 4
        Me.btnPiedra.Text = "Piedra"
        Me.btnPiedra.UseVisualStyleBackColor = False
        '
        'btnPapel
        '
        Me.btnPapel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPapel.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPapel.Location = New System.Drawing.Point(247, 262)
        Me.btnPapel.Name = "btnPapel"
        Me.btnPapel.Size = New System.Drawing.Size(120, 45)
        Me.btnPapel.TabIndex = 5
        Me.btnPapel.Text = "Papel"
        Me.btnPapel.UseVisualStyleBackColor = False
        '
        'btnTijera
        '
        Me.btnTijera.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTijera.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTijera.Location = New System.Drawing.Point(417, 262)
        Me.btnTijera.Name = "btnTijera"
        Me.btnTijera.Size = New System.Drawing.Size(120, 45)
        Me.btnTijera.TabIndex = 6
        Me.btnTijera.Text = "Tijera"
        Me.btnTijera.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "JUGADOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(493, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(247, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jugadas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(244, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ganadas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(242, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Perdidas:"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.MistyRose
        Me.btnReiniciar.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.Location = New System.Drawing.Point(139, 424)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(135, 40)
        Me.btnReiniciar.TabIndex = 12
        Me.btnReiniciar.Text = "REINICIAR"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.MistyRose
        Me.btnSalir.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(342, 424)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 40)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 334)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(595, 56)
        Me.lblMensaje.TabIndex = 14
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJugadas
        '
        Me.lblJugadas.BackColor = System.Drawing.Color.White
        Me.lblJugadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJugadas.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugadas.ForeColor = System.Drawing.Color.Black
        Me.lblJugadas.Location = New System.Drawing.Point(342, 55)
        Me.lblJugadas.Name = "lblJugadas"
        Me.lblJugadas.Size = New System.Drawing.Size(40, 35)
        Me.lblJugadas.TabIndex = 17
        Me.lblJugadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGanadas
        '
        Me.lblGanadas.BackColor = System.Drawing.Color.White
        Me.lblGanadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGanadas.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGanadas.ForeColor = System.Drawing.Color.Black
        Me.lblGanadas.Location = New System.Drawing.Point(342, 105)
        Me.lblGanadas.Name = "lblGanadas"
        Me.lblGanadas.Size = New System.Drawing.Size(40, 35)
        Me.lblGanadas.TabIndex = 18
        Me.lblGanadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPerdidas
        '
        Me.lblPerdidas.BackColor = System.Drawing.Color.White
        Me.lblPerdidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPerdidas.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerdidas.ForeColor = System.Drawing.Color.Black
        Me.lblPerdidas.Location = New System.Drawing.Point(342, 205)
        Me.lblPerdidas.Name = "lblPerdidas"
        Me.lblPerdidas.Size = New System.Drawing.Size(40, 35)
        Me.lblPerdidas.TabIndex = 19
        Me.lblPerdidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpatadas
        '
        Me.lblEmpatadas.BackColor = System.Drawing.Color.White
        Me.lblEmpatadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpatadas.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpatadas.ForeColor = System.Drawing.Color.Black
        Me.lblEmpatadas.Location = New System.Drawing.Point(342, 155)
        Me.lblEmpatadas.Name = "lblEmpatadas"
        Me.lblEmpatadas.Size = New System.Drawing.Size(40, 35)
        Me.lblEmpatadas.TabIndex = 20
        Me.lblEmpatadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(224, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Empatadas:"
        '
        'frmPiedraPapelTijera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(619, 486)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEmpatadas)
        Me.Controls.Add(Me.lblPerdidas)
        Me.Controls.Add(Me.lblGanadas)
        Me.Controls.Add(Me.lblJugadas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTijera)
        Me.Controls.Add(Me.btnPapel)
        Me.Controls.Add(Me.btnPiedra)
        Me.Controls.Add(Me.pctPc)
        Me.Controls.Add(Me.pctJugador)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmPiedraPapelTijera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piedra, Papel ó Tijera"
        CType(Me.pctJugador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctJugador As PictureBox
    Friend WithEvents pctPc As PictureBox
    Friend WithEvents btnPiedra As Button
    Friend WithEvents btnPapel As Button
    Friend WithEvents btnTijera As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblJugadas As Label
    Friend WithEvents lblGanadas As Label
    Friend WithEvents lblPerdidas As Label
    Friend WithEvents lblEmpatadas As Label
    Friend WithEvents Label8 As Label
End Class
