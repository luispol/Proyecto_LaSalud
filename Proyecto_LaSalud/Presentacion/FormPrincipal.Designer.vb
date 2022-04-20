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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicBxbottnVents = New System.Windows.Forms.PictureBox()
        Me.PicBxBottnMedicts = New System.Windows.Forms.PictureBox()
        Me.PicBxbttClientes = New System.Windows.Forms.PictureBox()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnMedicamentos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxbottnVents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxBottnMedicts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxbttClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormularios.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.PicBxbottnVents)
        Me.PanelMenu.Controls.Add(Me.PicBxBottnMedicts)
        Me.PanelMenu.Controls.Add(Me.PicBxbttClientes)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnMedicamentos)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(232, 637)
        Me.PanelMenu.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-59, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PicBxbottnVents
        '
        Me.PicBxbottnVents.Image = CType(resources.GetObject("PicBxbottnVents.Image"), System.Drawing.Image)
        Me.PicBxbottnVents.Location = New System.Drawing.Point(3, 267)
        Me.PicBxbottnVents.Name = "PicBxbottnVents"
        Me.PicBxbottnVents.Size = New System.Drawing.Size(39, 39)
        Me.PicBxbottnVents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxbottnVents.TabIndex = 4
        Me.PicBxbottnVents.TabStop = False
        '
        'PicBxBottnMedicts
        '
        Me.PicBxBottnMedicts.Image = CType(resources.GetObject("PicBxBottnMedicts.Image"), System.Drawing.Image)
        Me.PicBxBottnMedicts.Location = New System.Drawing.Point(3, 224)
        Me.PicBxBottnMedicts.Name = "PicBxBottnMedicts"
        Me.PicBxBottnMedicts.Size = New System.Drawing.Size(38, 37)
        Me.PicBxBottnMedicts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxBottnMedicts.TabIndex = 3
        Me.PicBxBottnMedicts.TabStop = False
        '
        'PicBxbttClientes
        '
        Me.PicBxbttClientes.Image = CType(resources.GetObject("PicBxbttClientes.Image"), System.Drawing.Image)
        Me.PicBxbttClientes.Location = New System.Drawing.Point(3, 179)
        Me.PicBxbttClientes.Name = "PicBxbttClientes"
        Me.PicBxbttClientes.Size = New System.Drawing.Size(38, 39)
        Me.PicBxbttClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxbttClientes.TabIndex = 2
        Me.PicBxbttClientes.TabStop = False
        '
        'btnVentas
        '
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentas.Location = New System.Drawing.Point(-1, 267)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(232, 39)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "VENTAS"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnMedicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMedicamentos.Location = New System.Drawing.Point(-1, 224)
        Me.btnMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(232, 37)
        Me.btnMedicamentos.TabIndex = 1
        Me.btnMedicamentos.Text = "MEDICAMENTOS"
        Me.btnMedicamentos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(-1, 179)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(232, 39)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelFormularios.Controls.Add(Me.Panel1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1320, 637)
        Me.PanelFormularios.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1320, 22)
        Me.Panel1.TabIndex = 0
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1320, 637)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelFormularios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.Text = "LA SALUD SYSTEM"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxbottnVents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxBottnMedicts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxbttClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormularios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents PicBxbttClientes As PictureBox
    Friend WithEvents PicBxbottnVents As PictureBox
    Friend WithEvents PicBxBottnMedicts As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
