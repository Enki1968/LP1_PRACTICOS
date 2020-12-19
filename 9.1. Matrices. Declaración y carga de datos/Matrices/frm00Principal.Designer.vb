<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm00Principal
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasDeUnaSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoDeTotalesDeVentasPorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoTotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(498, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca del sistema..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargaDeVentasToolStripMenuItem, Me.ConsultaDeVentasToolStripMenuItem, Me.VentasDeUnaSucursalToolStripMenuItem, Me.ListadoDeTotalesDeVentasPorMesToolStripMenuItem, Me.ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ListadoTotalesToolStripMenuItem, Me.ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CargaDeVentasToolStripMenuItem
        '
        Me.CargaDeVentasToolStripMenuItem.Name = "CargaDeVentasToolStripMenuItem"
        Me.CargaDeVentasToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.CargaDeVentasToolStripMenuItem.Text = "Carga de ventas..."
        '
        'ConsultaDeVentasToolStripMenuItem
        '
        Me.ConsultaDeVentasToolStripMenuItem.Name = "ConsultaDeVentasToolStripMenuItem"
        Me.ConsultaDeVentasToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ConsultaDeVentasToolStripMenuItem.Text = "Consulta de ventas..."
        '
        'VentasDeUnaSucursalToolStripMenuItem
        '
        Me.VentasDeUnaSucursalToolStripMenuItem.Name = "VentasDeUnaSucursalToolStripMenuItem"
        Me.VentasDeUnaSucursalToolStripMenuItem.Size = New System.Drawing.Size(292, 6)
        '
        'ListadoDeTotalesDeVentasPorMesToolStripMenuItem
        '
        Me.ListadoDeTotalesDeVentasPorMesToolStripMenuItem.Name = "ListadoDeTotalesDeVentasPorMesToolStripMenuItem"
        Me.ListadoDeTotalesDeVentasPorMesToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ListadoDeTotalesDeVentasPorMesToolStripMenuItem.Text = "Ventas de un mes..."
        '
        'ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem
        '
        Me.ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem.Name = "ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem"
        Me.ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem.Text = "Ventas de una sucursal..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(292, 6)
        '
        'ListadoTotalesToolStripMenuItem
        '
        Me.ListadoTotalesToolStripMenuItem.Name = "ListadoTotalesToolStripMenuItem"
        Me.ListadoTotalesToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ListadoTotalesToolStripMenuItem.Text = "Listado de totales de ventas por  mes..."
        '
        'ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem
        '
        Me.ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem.Name = "ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem"
        Me.ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem.Text = "Listado de totales de ventas por sucursal..."
        '
        'frm00Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm00Principal"
        Me.Text = "Sistema de Gestión de Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTotalesDeVentasPorMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTotalesDeVentasPorSucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasDeUnaSucursalToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ListadoTotalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTotalesDeVentasPorSucursalToolStripMenuItem As ToolStripMenuItem
End Class
