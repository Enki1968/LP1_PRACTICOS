<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculoImc
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
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblImc = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblAltura)
        Me.GroupBox1.Controls.Add(Me.lblPeso)
        Me.GroupBox1.Controls.Add(Me.txtAltura)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(85, 22)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 22)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(85, 57)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 22)
        Me.txtAltura.TabIndex = 1
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(20, 25)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(48, 16)
        Me.lblPeso.TabIndex = 2
        Me.lblPeso.Text = "Peso:"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(20, 60)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(52, 16)
        Me.lblAltura.TabIndex = 3
        Me.lblAltura.Text = "Altura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblImc)
        Me.GroupBox2.Controls.Add(Me.lblDiagnostico)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diagnóstico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "I.M.C.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnóstico:"
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiagnostico.Location = New System.Drawing.Point(120, 60)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(240, 40)
        Me.lblDiagnostico.TabIndex = 3
        Me.lblDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(12, 250)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(110, 25)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(140, 250)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(110, 25)
        Me.btnNuevaConsulta.TabIndex = 3
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(268, 250)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 25)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblImc
        '
        Me.lblImc.BackColor = System.Drawing.Color.Transparent
        Me.lblImc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImc.Location = New System.Drawing.Point(119, 22)
        Me.lblImc.Name = "lblImc"
        Me.lblImc.Size = New System.Drawing.Size(100, 25)
        Me.lblImc.TabIndex = 4
        Me.lblImc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IndiceDeMasaCorporal_TP2.My.Resources.Resources.imc
        Me.PictureBox1.Location = New System.Drawing.Point(278, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmCalculoImc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(390, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevaConsulta)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCalculoImc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de IMC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDiagnostico As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblImc As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevaConsulta As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
