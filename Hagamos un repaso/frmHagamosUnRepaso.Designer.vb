<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHagamosUnRepaso
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
        Me.rdbMascota = New System.Windows.Forms.RadioButton()
        Me.rdbAuto = New System.Windows.Forms.RadioButton()
        Me.pctImagen = New System.Windows.Forms.PictureBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMascota)
        Me.GroupBox1.Controls.Add(Me.rdbAuto)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(170, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personajes"
        '
        'rdbMascota
        '
        Me.rdbMascota.AutoSize = True
        Me.rdbMascota.Location = New System.Drawing.Point(36, 102)
        Me.rdbMascota.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rdbMascota.Name = "rdbMascota"
        Me.rdbMascota.Size = New System.Drawing.Size(122, 23)
        Me.rdbMascota.TabIndex = 1
        Me.rdbMascota.Text = "MASCOTAS"
        Me.rdbMascota.UseVisualStyleBackColor = True
        '
        'rdbAuto
        '
        Me.rdbAuto.AutoSize = True
        Me.rdbAuto.Location = New System.Drawing.Point(36, 41)
        Me.rdbAuto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rdbAuto.Name = "rdbAuto"
        Me.rdbAuto.Size = New System.Drawing.Size(86, 23)
        Me.rdbAuto.TabIndex = 0
        Me.rdbAuto.Text = "AUTOS"
        Me.rdbAuto.UseVisualStyleBackColor = True
        '
        'pctImagen
        '
        Me.pctImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctImagen.InitialImage = Nothing
        Me.pctImagen.Location = New System.Drawing.Point(215, 15)
        Me.pctImagen.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pctImagen.Name = "pctImagen"
        Me.pctImagen.Size = New System.Drawing.Size(170, 170)
        Me.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctImagen.TabIndex = 1
        Me.pctImagen.TabStop = False
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"AZUL", "VERDE", "ROJO", "AMARILLO"})
        Me.cmbColor.Location = New System.Drawing.Point(15, 214)
        Me.cmbColor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(370, 27)
        Me.cmbColor.TabIndex = 2
        Me.cmbColor.Text = "Elige un color"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(14, 322)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(371, 60)
        Me.btnMostrar.TabIndex = 3
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'frmHagamosUnRepaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(401, 405)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.pctImagen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmHagamosUnRepaso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HAGAMOS UN REPASO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbMascota As RadioButton
    Friend WithEvents rdbAuto As RadioButton
    Friend WithEvents pctImagen As PictureBox
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents btnMostrar As Button

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If rdbAuto.Checked = True And cmbColor.SelectedIndex = 0 Then
            pctImagen.Image = My.Resources.AutoAzul
        Else
            If rdbAuto.Checked = True And cmbColor.SelectedIndex = 1 Then
                pctImagen.Image = My.Resources.AutoVerde
            Else
                If rdbAuto.Checked = True And cmbColor.SelectedIndex = 2 Then
                    pctImagen.Image = My.Resources.AutoRojo
                Else
                    If rdbAuto.Checked = True And cmbColor.SelectedIndex = 3 Then
                        pctImagen.Image = My.Resources.AutoAmarillo
                    End If
                End If
            End If
        End If


        If rdbMascota.Checked = True And cmbColor.SelectedIndex = 0 Then
            pctImagen.Image = My.Resources.MascotaAzul
        Else
            If rdbMascota.Checked = True And cmbColor.SelectedIndex = 1 Then
                pctImagen.Image = My.Resources.MascotaVerde
            Else
                If rdbMascota.Checked = True And cmbColor.SelectedIndex = 2 Then
                    pctImagen.Image = My.Resources.MascotaRoja
                Else
                    If rdbMascota.Checked = True And cmbColor.SelectedIndex = 3 Then
                        pctImagen.Image = My.Resources.MascotaAmarilla
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub rdbAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAuto.CheckedChanged

    End Sub
End Class
