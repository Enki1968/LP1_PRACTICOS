<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaAutomaticaDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ProduccionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.CargaAutomaticaDeDatosToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'CargaAutomaticaDeDatosToolStripMenuItem
        '
        Me.CargaAutomaticaDeDatosToolStripMenuItem.Name = "CargaAutomaticaDeDatosToolStripMenuItem"
        Me.CargaAutomaticaDeDatosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CargaAutomaticaDeDatosToolStripMenuItem.Text = "Carga Automatica de Datos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem, Me.LisToolStripMenuItem})
        Me.ProduccionToolStripMenuItem.Name = "ProduccionToolStripMenuItem"
        Me.ProduccionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ProduccionToolStripMenuItem.Text = "Produccion"
        '
        'ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem
        '
        Me.ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Name = "ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem"
        Me.ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Text = "Consultar cantidad producida por un empleado..."
        '
        'LisToolStripMenuItem
        '
        Me.LisToolStripMenuItem.Name = "LisToolStripMenuItem"
        Me.LisToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.LisToolStripMenuItem.Text = "Listar total producido en cada maquina..."
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 382)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicio"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaAutomaticaDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCantidadProducidaPorUnEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LisToolStripMenuItem As ToolStripMenuItem
End Class
