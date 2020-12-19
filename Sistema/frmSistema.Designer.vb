<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistema
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
        Me.AcercaDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDelSistemaToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDelSistemaToolStripMenuItem
        '
        Me.AcercaDelSistemaToolStripMenuItem.Name = "AcercaDelSistemaToolStripMenuItem"
        Me.AcercaDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AcercaDelSistemaToolStripMenuItem.Text = "Acerca del sistema..."
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
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevosClientesToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.ConsultaDeClientesToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'AgregarNuevosClientesToolStripMenuItem
        '
        Me.AgregarNuevosClientesToolStripMenuItem.Name = "AgregarNuevosClientesToolStripMenuItem"
        Me.AgregarNuevosClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AgregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes..."
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de clientes..."
        '
        'ConsultaDeClientesToolStripMenuItem
        '
        Me.ConsultaDeClientesToolStripMenuItem.Name = "ConsultaDeClientesToolStripMenuItem"
        Me.ConsultaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ConsultaDeClientesToolStripMenuItem.Text = "Consulta de clientes..."
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema.My.Resources.Resources.Fondo1
        Me.ClientSize = New System.Drawing.Size(435, 254)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.Text = "Sistema de Gestión de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeClientesToolStripMenuItem As ToolStripMenuItem
End Class
