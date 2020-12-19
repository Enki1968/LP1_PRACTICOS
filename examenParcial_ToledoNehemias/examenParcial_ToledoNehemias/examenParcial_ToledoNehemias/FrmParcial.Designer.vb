<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParcial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParcial))
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGeneralDeSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeDatosDeUnSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrincipal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.ForeColor = System.Drawing.Color.White
        Me.lblPrincipal.Location = New System.Drawing.Point(504, 321)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(253, 87)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "EXAMEN PARCIAL"
        Me.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DsToolStripMenuItem, Me.SociosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DsToolStripMenuItem
        '
        Me.DsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.DsToolStripMenuItem.Name = "DsToolStripMenuItem"
        Me.DsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DsToolStripMenuItem.Text = "Sistemas"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de.."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoSocioToolStripMenuItem, Me.ListadoGeneralDeSociosToolStripMenuItem, Me.ConsultaDeDatosDeUnSocioToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'AgregarNuevoSocioToolStripMenuItem
        '
        Me.AgregarNuevoSocioToolStripMenuItem.Name = "AgregarNuevoSocioToolStripMenuItem"
        Me.AgregarNuevoSocioToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.AgregarNuevoSocioToolStripMenuItem.Text = "Agregar nuevo socio..."
        '
        'ListadoGeneralDeSociosToolStripMenuItem
        '
        Me.ListadoGeneralDeSociosToolStripMenuItem.Name = "ListadoGeneralDeSociosToolStripMenuItem"
        Me.ListadoGeneralDeSociosToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ListadoGeneralDeSociosToolStripMenuItem.Text = "Listado general de socios…"
        '
        'ConsultaDeDatosDeUnSocioToolStripMenuItem
        '
        Me.ConsultaDeDatosDeUnSocioToolStripMenuItem.Name = "ConsultaDeDatosDeUnSocioToolStripMenuItem"
        Me.ConsultaDeDatosDeUnSocioToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ConsultaDeDatosDeUnSocioToolStripMenuItem.Text = "Consulta de datos de un socio"
        '
        'FrmParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmParcial"
        Me.Text = "Examen Parcial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGeneralDeSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeDatosDeUnSocioToolStripMenuItem As ToolStripMenuItem
End Class
