<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdClientes = New System.Windows.Forms.TextBox()
        Me.txtDUIClientes = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreoClientes = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefonoClientes = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreClientes = New System.Windows.Forms.TextBox()
        Me.lblApellidosClientes = New System.Windows.Forms.Label()
        Me.txtApellidosClientes = New System.Windows.Forms.TextBox()
        Me.PicBxMostrarTbClientes = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GrpBxAccionesdeRegsitroClientes = New System.Windows.Forms.GroupBox()
        Me.PicBxEditarCliente = New System.Windows.Forms.PictureBox()
        Me.PictBxGuardarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarCliente = New System.Windows.Forms.PictureBox()
        CType(Me.PicBxMostrarTbClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxAccionesdeRegsitroClientes.SuspendLayout()
        CType(Me.PicBxEditarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBxGuardarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(297, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Clientes"
        '
        'txtIdClientes
        '
        Me.txtIdClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdClientes.Location = New System.Drawing.Point(286, 178)
        Me.txtIdClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdClientes.Name = "txtIdClientes"
        Me.txtIdClientes.Size = New System.Drawing.Size(78, 23)
        Me.txtIdClientes.TabIndex = 1
        '
        'txtDUIClientes
        '
        Me.txtDUIClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDUIClientes.Location = New System.Drawing.Point(415, 178)
        Me.txtDUIClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDUIClientes.Name = "txtDUIClientes"
        Me.txtDUIClientes.Size = New System.Drawing.Size(142, 23)
        Me.txtDUIClientes.TabIndex = 2
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIdCliente.Location = New System.Drawing.Point(253, 179)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(26, 17)
        Me.lblIdCliente.TabIndex = 4
        Me.lblIdCliente.Text = "Id :"
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(377, 180)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(32, 15)
        Me.lblDUI.TabIndex = 5
        Me.lblDUI.Text = "DUI :"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(231, 290)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(49, 15)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo :"
        '
        'txtCorreoClientes
        '
        Me.txtCorreoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreoClientes.Location = New System.Drawing.Point(286, 287)
        Me.txtCorreoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreoClientes.Name = "txtCorreoClientes"
        Me.txtCorreoClientes.Size = New System.Drawing.Size(271, 23)
        Me.txtCorreoClientes.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(221, 327)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 15)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono :"
        '
        'txtTelefonoClientes
        '
        Me.txtTelefonoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefonoClientes.Location = New System.Drawing.Point(286, 324)
        Me.txtTelefonoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefonoClientes.Name = "txtTelefonoClientes"
        Me.txtTelefonoClientes.Size = New System.Drawing.Size(271, 23)
        Me.txtTelefonoClientes.TabIndex = 10
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(221, 217)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(62, 15)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombres :"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreClientes.Location = New System.Drawing.Point(286, 214)
        Me.txtNombreClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(271, 23)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Location = New System.Drawing.Point(218, 253)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(62, 15)
        Me.lblApellidosClientes.TabIndex = 13
        Me.lblApellidosClientes.Text = "Apellidos :"
        '
        'txtApellidosClientes
        '
        Me.txtApellidosClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidosClientes.Location = New System.Drawing.Point(286, 250)
        Me.txtApellidosClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidosClientes.Name = "txtApellidosClientes"
        Me.txtApellidosClientes.Size = New System.Drawing.Size(271, 23)
        Me.txtApellidosClientes.TabIndex = 14
        '
        'PicBxMostrarTbClientes
        '
        Me.PicBxMostrarTbClientes.Image = CType(resources.GetObject("PicBxMostrarTbClientes.Image"), System.Drawing.Image)
        Me.PicBxMostrarTbClientes.Location = New System.Drawing.Point(748, 464)
        Me.PicBxMostrarTbClientes.Name = "PicBxMostrarTbClientes"
        Me.PicBxMostrarTbClientes.Size = New System.Drawing.Size(38, 39)
        Me.PicBxMostrarTbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxMostrarTbClientes.TabIndex = 17
        Me.PicBxMostrarTbClientes.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(581, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 512)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 100)
        Me.Panel2.TabIndex = 21
        '
        'GrpBxAccionesdeRegsitroClientes
        '
        Me.GrpBxAccionesdeRegsitroClientes.Controls.Add(Me.PicBxEliminarCliente)
        Me.GrpBxAccionesdeRegsitroClientes.Controls.Add(Me.PicBxAgregarCliente)
        Me.GrpBxAccionesdeRegsitroClientes.Controls.Add(Me.PictBxGuardarCliente)
        Me.GrpBxAccionesdeRegsitroClientes.Controls.Add(Me.PicBxEditarCliente)
        Me.GrpBxAccionesdeRegsitroClientes.Location = New System.Drawing.Point(581, 274)
        Me.GrpBxAccionesdeRegsitroClientes.Name = "GrpBxAccionesdeRegsitroClientes"
        Me.GrpBxAccionesdeRegsitroClientes.Size = New System.Drawing.Size(184, 73)
        Me.GrpBxAccionesdeRegsitroClientes.TabIndex = 22
        Me.GrpBxAccionesdeRegsitroClientes.TabStop = False
        Me.GrpBxAccionesdeRegsitroClientes.Text = "Acciones de Registro"
        '
        'PicBxEditarCliente
        '
        Me.PicBxEditarCliente.Image = CType(resources.GetObject("PicBxEditarCliente.Image"), System.Drawing.Image)
        Me.PicBxEditarCliente.Location = New System.Drawing.Point(6, 28)
        Me.PicBxEditarCliente.Name = "PicBxEditarCliente"
        Me.PicBxEditarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PicBxEditarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarCliente.TabIndex = 0
        Me.PicBxEditarCliente.TabStop = False
        '
        'PictBxGuardarCliente
        '
        Me.PictBxGuardarCliente.Image = CType(resources.GetObject("PictBxGuardarCliente.Image"), System.Drawing.Image)
        Me.PictBxGuardarCliente.Location = New System.Drawing.Point(50, 28)
        Me.PictBxGuardarCliente.Name = "PictBxGuardarCliente"
        Me.PictBxGuardarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PictBxGuardarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictBxGuardarCliente.TabIndex = 1
        Me.PictBxGuardarCliente.TabStop = False
        '
        'PicBxAgregarCliente
        '
        Me.PicBxAgregarCliente.Image = CType(resources.GetObject("PicBxAgregarCliente.Image"), System.Drawing.Image)
        Me.PicBxAgregarCliente.Location = New System.Drawing.Point(94, 28)
        Me.PicBxAgregarCliente.Name = "PicBxAgregarCliente"
        Me.PicBxAgregarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PicBxAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarCliente.TabIndex = 2
        Me.PicBxAgregarCliente.TabStop = False
        '
        'PicBxEliminarCliente
        '
        Me.PicBxEliminarCliente.Image = CType(resources.GetObject("PicBxEliminarCliente.Image"), System.Drawing.Image)
        Me.PicBxEliminarCliente.Location = New System.Drawing.Point(138, 28)
        Me.PicBxEliminarCliente.Name = "PicBxEliminarCliente"
        Me.PicBxEliminarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PicBxEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarCliente.TabIndex = 23
        Me.PicBxEliminarCliente.TabStop = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 512)
        Me.Controls.Add(Me.GrpBxAccionesdeRegsitroClientes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicBxMostrarTbClientes)
        Me.Controls.Add(Me.txtApellidosClientes)
        Me.Controls.Add(Me.lblApellidosClientes)
        Me.Controls.Add(Me.txtNombreClientes)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtTelefonoClientes)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtCorreoClientes)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.txtDUIClientes)
        Me.Controls.Add(Me.txtIdClientes)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormClientes"
        Me.Text = "Cliente"
        CType(Me.PicBxMostrarTbClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxAccionesdeRegsitroClientes.ResumeLayout(False)
        CType(Me.PicBxEditarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBxGuardarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdClientes As TextBox
    Friend WithEvents txtDUIClientes As TextBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents lblDUI As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreoClientes As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefonoClientes As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreClientes As TextBox
    Friend WithEvents lblApellidosClientes As Label
    Friend WithEvents txtApellidosClientes As TextBox
    Friend WithEvents PicBxMostrarTbClientes As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GrpBxAccionesdeRegsitroClientes As GroupBox
    Friend WithEvents PicBxEliminarCliente As PictureBox
    Friend WithEvents PicBxAgregarCliente As PictureBox
    Friend WithEvents PictBxGuardarCliente As PictureBox
    Friend WithEvents PicBxEditarCliente As PictureBox
End Class
