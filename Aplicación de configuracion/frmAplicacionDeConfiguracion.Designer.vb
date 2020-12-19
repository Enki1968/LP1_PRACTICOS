<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionDeConfiguracion
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
        Me.lblNombreAplicacion = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblVersionNumero = New System.Windows.Forms.Label()
        Me.lblLeyenda = New System.Windows.Forms.Label()
        Me.lblNombreAutor = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.btnCompletarCampos = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbProfesional = New System.Windows.Forms.RadioButton()
        Me.rdbParticular = New System.Windows.Forms.RadioButton()
        Me.rdbEstudiantil = New System.Windows.Forms.RadioButton()
        Me.rdbEspecial = New System.Windows.Forms.RadioButton()
        Me.rdbLibre = New System.Windows.Forms.RadioButton()
        Me.txtNombreAplicacion = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreAutor = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pctImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreAplicacion
        '
        Me.lblNombreAplicacion.AutoSize = True
        Me.lblNombreAplicacion.Location = New System.Drawing.Point(12, 55)
        Me.lblNombreAplicacion.Name = "lblNombreAplicacion"
        Me.lblNombreAplicacion.Size = New System.Drawing.Size(125, 13)
        Me.lblNombreAplicacion.TabIndex = 0
        Me.lblNombreAplicacion.Text = "Nombre de la Aplicación:"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(12, 85)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresa.TabIndex = 1
        Me.lblEmpresa.Text = "Empresa:"
        '
        'lblVersionNumero
        '
        Me.lblVersionNumero.AutoSize = True
        Me.lblVersionNumero.Location = New System.Drawing.Point(12, 111)
        Me.lblVersionNumero.Name = "lblVersionNumero"
        Me.lblVersionNumero.Size = New System.Drawing.Size(85, 13)
        Me.lblVersionNumero.TabIndex = 2
        Me.lblVersionNumero.Text = "Versión Número:"
        '
        'lblLeyenda
        '
        Me.lblLeyenda.AutoSize = True
        Me.lblLeyenda.Location = New System.Drawing.Point(12, 140)
        Me.lblLeyenda.Name = "lblLeyenda"
        Me.lblLeyenda.Size = New System.Drawing.Size(51, 13)
        Me.lblLeyenda.TabIndex = 3
        Me.lblLeyenda.Text = "Leyenda:"
        '
        'lblNombreAutor
        '
        Me.lblNombreAutor.AutoSize = True
        Me.lblNombreAutor.Location = New System.Drawing.Point(12, 213)
        Me.lblNombreAutor.Name = "lblNombreAutor"
        Me.lblNombreAutor.Size = New System.Drawing.Size(92, 13)
        Me.lblNombreAutor.TabIndex = 4
        Me.lblNombreAutor.Text = "Nombre del Autor:"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Location = New System.Drawing.Point(12, 241)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(100, 13)
        Me.lblFechaCreacion.TabIndex = 5
        Me.lblFechaCreacion.Text = "Fecha de Creación:"
        '
        'btnCompletarCampos
        '
        Me.btnCompletarCampos.Location = New System.Drawing.Point(12, 270)
        Me.btnCompletarCampos.Name = "btnCompletarCampos"
        Me.btnCompletarCampos.Size = New System.Drawing.Size(125, 22)
        Me.btnCompletarCampos.TabIndex = 6
        Me.btnCompletarCampos.Text = "Completar los campos"
        Me.btnCompletarCampos.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(179, 270)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 22)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar los cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(347, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 22)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbProfesional)
        Me.GroupBox1.Controls.Add(Me.rdbParticular)
        Me.GroupBox1.Controls.Add(Me.rdbEstudiantil)
        Me.GroupBox1.Controls.Add(Me.rdbEspecial)
        Me.GroupBox1.Controls.Add(Me.rdbLibre)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 145)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Licencia"
        '
        'rdbProfesional
        '
        Me.rdbProfesional.AutoSize = True
        Me.rdbProfesional.Location = New System.Drawing.Point(20, 120)
        Me.rdbProfesional.Name = "rdbProfesional"
        Me.rdbProfesional.Size = New System.Drawing.Size(77, 17)
        Me.rdbProfesional.TabIndex = 4
        Me.rdbProfesional.TabStop = True
        Me.rdbProfesional.Text = "Profesional"
        Me.rdbProfesional.UseVisualStyleBackColor = True
        '
        'rdbParticular
        '
        Me.rdbParticular.AutoSize = True
        Me.rdbParticular.Location = New System.Drawing.Point(20, 95)
        Me.rdbParticular.Name = "rdbParticular"
        Me.rdbParticular.Size = New System.Drawing.Size(69, 17)
        Me.rdbParticular.TabIndex = 3
        Me.rdbParticular.TabStop = True
        Me.rdbParticular.Text = "Particular"
        Me.rdbParticular.UseVisualStyleBackColor = True
        '
        'rdbEstudiantil
        '
        Me.rdbEstudiantil.AutoSize = True
        Me.rdbEstudiantil.Location = New System.Drawing.Point(20, 70)
        Me.rdbEstudiantil.Name = "rdbEstudiantil"
        Me.rdbEstudiantil.Size = New System.Drawing.Size(73, 17)
        Me.rdbEstudiantil.TabIndex = 2
        Me.rdbEstudiantil.TabStop = True
        Me.rdbEstudiantil.Text = "Estudiantil"
        Me.rdbEstudiantil.UseVisualStyleBackColor = True
        '
        'rdbEspecial
        '
        Me.rdbEspecial.AutoSize = True
        Me.rdbEspecial.Location = New System.Drawing.Point(20, 45)
        Me.rdbEspecial.Name = "rdbEspecial"
        Me.rdbEspecial.Size = New System.Drawing.Size(65, 17)
        Me.rdbEspecial.TabIndex = 1
        Me.rdbEspecial.TabStop = True
        Me.rdbEspecial.Text = "Especial"
        Me.rdbEspecial.UseVisualStyleBackColor = True
        '
        'rdbLibre
        '
        Me.rdbLibre.AutoSize = True
        Me.rdbLibre.Location = New System.Drawing.Point(20, 20)
        Me.rdbLibre.Name = "rdbLibre"
        Me.rdbLibre.Size = New System.Drawing.Size(48, 17)
        Me.rdbLibre.TabIndex = 0
        Me.rdbLibre.TabStop = True
        Me.rdbLibre.Text = "Libre"
        Me.rdbLibre.UseVisualStyleBackColor = True
        '
        'txtNombreAplicacion
        '
        Me.txtNombreAplicacion.Location = New System.Drawing.Point(140, 54)
        Me.txtNombreAplicacion.Name = "txtNombreAplicacion"
        Me.txtNombreAplicacion.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreAplicacion.TabIndex = 10
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(83, 82)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(237, 20)
        Me.txtNombreEmpresa.TabIndex = 11
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(109, 109)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(211, 20)
        Me.txtVersion.TabIndex = 12
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(83, 136)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(237, 62)
        Me.txtDescripcion.TabIndex = 13
        '
        'txtNombreAutor
        '
        Me.txtNombreAutor.Location = New System.Drawing.Point(120, 210)
        Me.txtNombreAutor.Name = "txtNombreAutor"
        Me.txtNombreAutor.Size = New System.Drawing.Size(352, 20)
        Me.txtNombreAutor.TabIndex = 14
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(120, 237)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(352, 20)
        Me.dtpFecha.TabIndex = 15
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Window
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(484, 40)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "                   Usted se encuentra configurando los datos de su aplicación. Es" &
    "ta información podrá ser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    visualizada en la ventana ""Acerca " &
    "de..."" de su programa."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctImagen
        '
        Me.pctImagen.BackColor = System.Drawing.Color.Transparent
        Me.pctImagen.Image = Global.Aplicación_de_configuracion.My.Resources.Resources.Informacion
        Me.pctImagen.Location = New System.Drawing.Point(15, 7)
        Me.pctImagen.Name = "pctImagen"
        Me.pctImagen.Size = New System.Drawing.Size(30, 30)
        Me.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctImagen.TabIndex = 17
        Me.pctImagen.TabStop = False
        '
        'frmAplicacionDeConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 296)
        Me.Controls.Add(Me.pctImagen)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtNombreAutor)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.txtNombreAplicacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCompletarCampos)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.lblNombreAutor)
        Me.Controls.Add(Me.lblLeyenda)
        Me.Controls.Add(Me.lblVersionNumero)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblNombreAplicacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmAplicacionDeConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Configuración"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreAplicacion As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblVersionNumero As Label
    Friend WithEvents lblLeyenda As Label
    Friend WithEvents lblNombreAutor As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents btnCompletarCampos As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbProfesional As RadioButton
    Friend WithEvents rdbParticular As RadioButton
    Friend WithEvents rdbEstudiantil As RadioButton
    Friend WithEvents rdbEspecial As RadioButton
    Friend WithEvents rdbLibre As RadioButton
    Friend WithEvents txtNombreAplicacion As TextBox
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreAutor As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblInfo As Label
    Friend WithEvents pctImagen As PictureBox
End Class
