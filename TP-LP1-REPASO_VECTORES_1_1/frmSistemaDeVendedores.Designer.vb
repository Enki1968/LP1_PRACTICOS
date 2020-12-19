<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistemaDeVendedores
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
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGeneralDeVendoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeDatosDeUnVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.VendedorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(132, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoVendedorToolStripMenuItem, Me.ListadoGeneralDeVendoresToolStripMenuItem, Me.ConsultaDeDatosDeUnVendedorToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'AgregarNuevoVendedorToolStripMenuItem
        '
        Me.AgregarNuevoVendedorToolStripMenuItem.Name = "AgregarNuevoVendedorToolStripMenuItem"
        Me.AgregarNuevoVendedorToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AgregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor..."
        '
        'ListadoGeneralDeVendoresToolStripMenuItem
        '
        Me.ListadoGeneralDeVendoresToolStripMenuItem.Name = "ListadoGeneralDeVendoresToolStripMenuItem"
        Me.ListadoGeneralDeVendoresToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ListadoGeneralDeVendoresToolStripMenuItem.Text = "Listado general de vendedores..."
        '
        'ConsultaDeDatosDeUnVendedorToolStripMenuItem
        '
        Me.ConsultaDeDatosDeUnVendedorToolStripMenuItem.Name = "ConsultaDeDatosDeUnVendedorToolStripMenuItem"
        Me.ConsultaDeDatosDeUnVendedorToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ConsultaDeDatosDeUnVendedorToolStripMenuItem.Text = "Consulta de datos de un vendedor..."
        '
        'frmSistemaDeVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(480, 457)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistemaDeVendedores"
        Me.Text = "Sistema de Vendedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGeneralDeVendoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeDatosDeUnVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
