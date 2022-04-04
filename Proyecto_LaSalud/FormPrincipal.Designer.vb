<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnMedicamentos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnMedicamentos)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(214, 421)
        Me.PanelMenu.TabIndex = 0
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentas.Location = New System.Drawing.Point(-5, 156)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(219, 30)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnMedicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMedicamentos.Location = New System.Drawing.Point(-4, 112)
        Me.btnMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(219, 30)
        Me.btnMedicamentos.TabIndex = 1
        Me.btnMedicamentos.Text = "Medicamentos"
        Me.btnMedicamentos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(-4, 70)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(219, 30)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(214, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(562, 34)
        Me.PanelTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Algerian", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(229, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(130, 26)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "LA SALUD"
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(214, 34)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(562, 387)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 340)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 421)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPrincipal"
        Me.Text = "LA SALUD SYSTEM"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
