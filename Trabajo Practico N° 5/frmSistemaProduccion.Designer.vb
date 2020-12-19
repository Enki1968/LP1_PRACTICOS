<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistemaProduccion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaAutomáticaDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTotalProducidoEnCadaMáquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ProduciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.CargaAutomáticaDeDatosToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'CargaAutomáticaDeDatosToolStripMenuItem
        '
        Me.CargaAutomáticaDeDatosToolStripMenuItem.Name = "CargaAutomáticaDeDatosToolStripMenuItem"
        Me.CargaAutomáticaDeDatosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CargaAutomáticaDeDatosToolStripMenuItem.Text = "Carga automática de datos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ProduciónToolStripMenuItem
        '
        Me.ProduciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem, Me.ListarTotalProducidoEnCadaMáquinaToolStripMenuItem})
        Me.ProduciónToolStripMenuItem.Name = "ProduciónToolStripMenuItem"
        Me.ProduciónToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ProduciónToolStripMenuItem.Text = "Producción"
        '
        'ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem
        '
        Me.ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Name = "ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem"
        Me.ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Text = "Consultar cantidad producida de un empleado…"
        '
        'ListarTotalProducidoEnCadaMáquinaToolStripMenuItem
        '
        Me.ListarTotalProducidoEnCadaMáquinaToolStripMenuItem.Name = "ListarTotalProducidoEnCadaMáquinaToolStripMenuItem"
        Me.ListarTotalProducidoEnCadaMáquinaToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.ListarTotalProducidoEnCadaMáquinaToolStripMenuItem.Text = "Listar total producido en cada máquina..."
        '
        'frmSistemaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(425, 372)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistemaProduccion"
        Me.Text = "Sistema de producción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaAutomáticaDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCantidadProducidaDeUnEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarTotalProducidoEnCadaMáquinaToolStripMenuItem As ToolStripMenuItem
End Class
