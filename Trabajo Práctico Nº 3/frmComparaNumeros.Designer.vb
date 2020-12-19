<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComparaNumeros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pctIzquierda = New System.Windows.Forms.PictureBox()
        Me.pctDerecha = New System.Windows.Forms.PictureBox()
        Me.pctResultado = New System.Windows.Forms.PictureBox()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnMenor = New System.Windows.Forms.Button()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAciertos = New System.Windows.Forms.Label()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.lblPuntaje = New System.Windows.Forms.Label()
        CType(Me.pctIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctIzquierda
        '
        Me.pctIzquierda.BackColor = System.Drawing.Color.Transparent
        Me.pctIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctIzquierda.Location = New System.Drawing.Point(12, 83)
        Me.pctIzquierda.Name = "pctIzquierda"
        Me.pctIzquierda.Size = New System.Drawing.Size(110, 140)
        Me.pctIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctIzquierda.TabIndex = 0
        Me.pctIzquierda.TabStop = False
        '
        'pctDerecha
        '
        Me.pctDerecha.BackColor = System.Drawing.Color.Transparent
        Me.pctDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctDerecha.Location = New System.Drawing.Point(318, 83)
        Me.pctDerecha.Name = "pctDerecha"
        Me.pctDerecha.Size = New System.Drawing.Size(110, 140)
        Me.pctDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDerecha.TabIndex = 1
        Me.pctDerecha.TabStop = False
        '
        'pctResultado
        '
        Me.pctResultado.BackColor = System.Drawing.Color.Transparent
        Me.pctResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctResultado.Location = New System.Drawing.Point(188, 111)
        Me.pctResultado.Name = "pctResultado"
        Me.pctResultado.Size = New System.Drawing.Size(65, 75)
        Me.pctResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctResultado.TabIndex = 2
        Me.pctResultado.TabStop = False
        '
        'btnMayor
        '
        Me.btnMayor.BackgroundImage = Global.Trabajo_Práctico_Nº_3.My.Resources.Resources.Mayor
        Me.btnMayor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMayor.Location = New System.Drawing.Point(32, 253)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(90, 80)
        Me.btnMayor.TabIndex = 3
        Me.btnMayor.UseVisualStyleBackColor = True
        Me.btnMayor.Visible = False
        '
        'btnIgual
        '
        Me.btnIgual.BackgroundImage = Global.Trabajo_Práctico_Nº_3.My.Resources.Resources.Igual
        Me.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIgual.Location = New System.Drawing.Point(180, 253)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(90, 80)
        Me.btnIgual.TabIndex = 4
        Me.btnIgual.UseVisualStyleBackColor = True
        Me.btnIgual.Visible = False
        '
        'btnMenor
        '
        Me.btnMenor.BackgroundImage = Global.Trabajo_Práctico_Nº_3.My.Resources.Resources.Menor
        Me.btnMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenor.Location = New System.Drawing.Point(318, 253)
        Me.btnMenor.Name = "btnMenor"
        Me.btnMenor.Size = New System.Drawing.Size(90, 80)
        Me.btnMenor.TabIndex = 5
        Me.btnMenor.UseVisualStyleBackColor = True
        Me.btnMenor.Visible = False
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.Khaki
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJugar.ForeColor = System.Drawing.Color.Blue
        Me.btnJugar.Location = New System.Drawing.Point(11, 394)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(417, 60)
        Me.btnJugar.TabIndex = 6
        Me.btnJugar.Text = "Jugar!"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 71)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Indica si el número de la izquierda es" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " mayor, igual o menor que el de la derech" &
    "a."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnReiniciar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.Location = New System.Drawing.Point(12, 482)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(140, 45)
        Me.btnReiniciar.TabIndex = 8
        Me.btnReiniciar.Text = "Volver a jugar"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnSalir.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(288, 482)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(140, 45)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Aciertos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Errores:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Puntaje:"
        '
        'lblAciertos
        '
        Me.lblAciertos.BackColor = System.Drawing.Color.Transparent
        Me.lblAciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAciertos.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAciertos.ForeColor = System.Drawing.Color.Crimson
        Me.lblAciertos.Location = New System.Drawing.Point(83, 356)
        Me.lblAciertos.Name = "lblAciertos"
        Me.lblAciertos.Size = New System.Drawing.Size(35, 20)
        Me.lblAciertos.TabIndex = 14
        Me.lblAciertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrores
        '
        Me.lblErrores.BackColor = System.Drawing.Color.Transparent
        Me.lblErrores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrores.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.Crimson
        Me.lblErrores.Location = New System.Drawing.Point(222, 356)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(35, 20)
        Me.lblErrores.TabIndex = 15
        Me.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPuntaje
        '
        Me.lblPuntaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPuntaje.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntaje.ForeColor = System.Drawing.Color.Crimson
        Me.lblPuntaje.Location = New System.Drawing.Point(384, 356)
        Me.lblPuntaje.Name = "lblPuntaje"
        Me.lblPuntaje.Size = New System.Drawing.Size(35, 20)
        Me.lblPuntaje.TabIndex = 16
        Me.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmComparaNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Trabajo_Práctico_Nº_3.My.Resources.Resources.nubes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 544)
        Me.Controls.Add(Me.lblPuntaje)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.lblAciertos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.btnMenor)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnMayor)
        Me.Controls.Add(Me.pctResultado)
        Me.Controls.Add(Me.pctDerecha)
        Me.Controls.Add(Me.pctIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmComparaNumeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compara números y cantidades"
        CType(Me.pctIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctIzquierda As PictureBox
    Friend WithEvents pctDerecha As PictureBox
    Friend WithEvents pctResultado As PictureBox
    Friend WithEvents btnMayor As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnMenor As Button
    Friend WithEvents btnJugar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAciertos As Label
    Friend WithEvents lblErrores As Label
    Friend WithEvents lblPuntaje As Label
End Class
