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
        Me.components = New System.ComponentModel.Container()
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
        Me.txtApellido1Cliente = New System.Windows.Forms.TextBox()
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.Panel2Clientes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicBxEditarClientes = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarCliente = New System.Windows.Forms.PictureBox()
        Me.ToolTipCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdireccionCliente = New System.Windows.Forms.TextBox()
        Me.LabelDirec = New System.Windows.Forms.Label()
        Me.txtApellido2Cliente = New System.Windows.Forms.TextBox()
        Me.labelApellido2Cliente = New System.Windows.Forms.Label()
        Me.PicBx2RegistrosdeCliente = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBxDatosCliente.SuspendLayout()
        CType(Me.PicBx2RegistrosdeCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(522, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'txtIdClientes
        '
        Me.txtIdClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdClientes.Location = New System.Drawing.Point(79, 27)
        Me.txtIdClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdClientes.Name = "txtIdClientes"
        Me.txtIdClientes.Size = New System.Drawing.Size(56, 23)
        Me.txtIdClientes.TabIndex = 1
        '
        'txtDUIClientes
        '
        Me.txtDUIClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDUIClientes.Location = New System.Drawing.Point(199, 27)
        Me.txtDUIClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDUIClientes.Name = "txtDUIClientes"
        Me.txtDUIClientes.Size = New System.Drawing.Size(137, 23)
        Me.txtDUIClientes.TabIndex = 2
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(49, 27)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(23, 15)
        Me.lblIdCliente.TabIndex = 4
        Me.lblIdCliente.Text = "Id :"
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(161, 30)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(32, 15)
        Me.lblDUI.TabIndex = 5
        Me.lblDUI.Text = "DUI :"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(23, 199)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(49, 15)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo :"
        '
        'txtCorreoClientes
        '
        Me.txtCorreoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreoClientes.Location = New System.Drawing.Point(78, 196)
        Me.txtCorreoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreoClientes.Name = "txtCorreoClientes"
        Me.txtCorreoClientes.Size = New System.Drawing.Size(258, 23)
        Me.txtCorreoClientes.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(14, 345)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 15)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono :"
        '
        'txtTelefonoClientes
        '
        Me.txtTelefonoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefonoClientes.Location = New System.Drawing.Point(79, 342)
        Me.txtTelefonoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefonoClientes.Name = "txtTelefonoClientes"
        Me.txtTelefonoClientes.Size = New System.Drawing.Size(257, 23)
        Me.txtTelefonoClientes.TabIndex = 10
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(11, 68)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(62, 15)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombres :"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreClientes.Location = New System.Drawing.Point(79, 68)
        Me.txtNombreClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(257, 23)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Location = New System.Drawing.Point(10, 112)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(66, 15)
        Me.lblApellidosClientes.TabIndex = 13
        Me.lblApellidosClientes.Text = "Apellido 1 :"
        '
        'txtApellido1Cliente
        '
        Me.txtApellido1Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido1Cliente.Location = New System.Drawing.Point(78, 109)
        Me.txtApellido1Cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido1Cliente.Name = "txtApellido1Cliente"
        Me.txtApellido1Cliente.Size = New System.Drawing.Size(258, 23)
        Me.txtApellido1Cliente.TabIndex = 14
        '
        'Panel1Clientes
        '
        Me.Panel1Clientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1Clientes.Location = New System.Drawing.Point(0, 0)
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(200, 512)
        Me.Panel1Clientes.TabIndex = 15
        '
        'Panel2Clientes
        '
        Me.Panel2Clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2Clientes.Location = New System.Drawing.Point(200, 0)
        Me.Panel2Clientes.Name = "Panel2Clientes"
        Me.Panel2Clientes.Size = New System.Drawing.Size(592, 100)
        Me.Panel2Clientes.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(587, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(271, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "REGISTRO DE CLIENTES"
        '
        'PicBxEditarClientes
        '
        Me.PicBxEditarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEditarClientes.Image = CType(resources.GetObject("PicBxEditarClientes.Image"), System.Drawing.Image)
        Me.PicBxEditarClientes.Location = New System.Drawing.Point(10, 30)
        Me.PicBxEditarClientes.Name = "PicBxEditarClientes"
        Me.PicBxEditarClientes.Size = New System.Drawing.Size(38, 39)
        Me.PicBxEditarClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarClientes.TabIndex = 0
        Me.PicBxEditarClientes.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxEditarClientes, "Editar el registro de Cliente")
        '
        'PicBxAgregarCliente
        '
        Me.PicBxAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarCliente.Image = CType(resources.GetObject("PicBxAgregarCliente.Image"), System.Drawing.Image)
        Me.PicBxAgregarCliente.Location = New System.Drawing.Point(98, 30)
        Me.PicBxAgregarCliente.Name = "PicBxAgregarCliente"
        Me.PicBxAgregarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PicBxAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarCliente.TabIndex = 2
        Me.PicBxAgregarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxAgregarCliente, "Agregar el registro del cliente")
        '
        'PicBxEliminarCliente
        '
        Me.PicBxEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarCliente.Image = CType(resources.GetObject("PicBxEliminarCliente.Image"), System.Drawing.Image)
        Me.PicBxEliminarCliente.Location = New System.Drawing.Point(142, 30)
        Me.PicBxEliminarCliente.Name = "PicBxEliminarCliente"
        Me.PicBxEliminarCliente.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarCliente.TabIndex = 3
        Me.PicBxEliminarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxEliminarCliente, "Eliminar el registro del cliente")
        '
        'PicBxGuardarCliente
        '
        Me.PicBxGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarCliente.Image = CType(resources.GetObject("PicBxGuardarCliente.Image"), System.Drawing.Image)
        Me.PicBxGuardarCliente.Location = New System.Drawing.Point(54, 30)
        Me.PicBxGuardarCliente.Name = "PicBxGuardarCliente"
        Me.PicBxGuardarCliente.Size = New System.Drawing.Size(38, 39)
        Me.PicBxGuardarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarCliente.TabIndex = 1
        Me.PicBxGuardarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxGuardarCliente, "Guardar el registro del cliente")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicBxEditarClientes)
        Me.GroupBox1.Controls.Add(Me.PicBxEliminarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxAgregarCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(587, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 79)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones de Registro"
        '
        'GroupBxDatosCliente
        '
        Me.GroupBxDatosCliente.Controls.Add(Me.TextBox1)
        Me.GroupBxDatosCliente.Controls.Add(Me.Label3)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtdireccionCliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.LabelDirec)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtApellido2Cliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.labelApellido2Cliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtDUIClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtIdClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblIdCliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblDUI)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtNombreClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblNombreCliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtTelefonoClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblTelefono)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtApellido1Cliente)
        Me.GroupBxDatosCliente.Controls.Add(Me.txtCorreoClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblApellidosClientes)
        Me.GroupBxDatosCliente.Controls.Add(Me.lblCorreo)
        Me.GroupBxDatosCliente.Location = New System.Drawing.Point(227, 131)
        Me.GroupBxDatosCliente.Name = "GroupBxDatosCliente"
        Me.GroupBxDatosCliente.Size = New System.Drawing.Size(354, 375)
        Me.GroupBxDatosCliente.TabIndex = 21
        Me.GroupBxDatosCliente.TabStop = False
        Me.GroupBxDatosCliente.Text = "Datos del Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 304)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 23)
        Me.TextBox1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Dpto :"
        '
        'txtdireccionCliente
        '
        Me.txtdireccionCliente.Location = New System.Drawing.Point(78, 236)
        Me.txtdireccionCliente.Multiline = True
        Me.txtdireccionCliente.Name = "txtdireccionCliente"
        Me.txtdireccionCliente.Size = New System.Drawing.Size(258, 55)
        Me.txtdireccionCliente.TabIndex = 19
        '
        'LabelDirec
        '
        Me.LabelDirec.AutoSize = True
        Me.LabelDirec.Location = New System.Drawing.Point(9, 239)
        Me.LabelDirec.Name = "LabelDirec"
        Me.LabelDirec.Size = New System.Drawing.Size(63, 15)
        Me.LabelDirec.TabIndex = 17
        Me.LabelDirec.Text = "Dirección :"
        '
        'txtApellido2Cliente
        '
        Me.txtApellido2Cliente.Location = New System.Drawing.Point(78, 151)
        Me.txtApellido2Cliente.Name = "txtApellido2Cliente"
        Me.txtApellido2Cliente.Size = New System.Drawing.Size(258, 23)
        Me.txtApellido2Cliente.TabIndex = 16
        '
        'labelApellido2Cliente
        '
        Me.labelApellido2Cliente.AutoSize = True
        Me.labelApellido2Cliente.Location = New System.Drawing.Point(11, 154)
        Me.labelApellido2Cliente.Name = "labelApellido2Cliente"
        Me.labelApellido2Cliente.Size = New System.Drawing.Size(66, 15)
        Me.labelApellido2Cliente.TabIndex = 15
        Me.labelApellido2Cliente.Text = "Apellido 2 :"
        '
        'PicBx2RegistrosdeCliente
        '
        Me.PicBx2RegistrosdeCliente.Image = CType(resources.GetObject("PicBx2RegistrosdeCliente.Image"), System.Drawing.Image)
        Me.PicBx2RegistrosdeCliente.Location = New System.Drawing.Point(748, 468)
        Me.PicBx2RegistrosdeCliente.Name = "PicBx2RegistrosdeCliente"
        Me.PicBx2RegistrosdeCliente.Size = New System.Drawing.Size(38, 38)
        Me.PicBx2RegistrosdeCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBx2RegistrosdeCliente.TabIndex = 22
        Me.PicBx2RegistrosdeCliente.TabStop = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 512)
        Me.Controls.Add(Me.PicBx2RegistrosdeCliente)
        Me.Controls.Add(Me.GroupBxDatosCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2Clientes)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormClientes"
        Me.Text = "Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBxDatosCliente.ResumeLayout(False)
        Me.GroupBxDatosCliente.PerformLayout()
        CType(Me.PicBx2RegistrosdeCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtApellido1Cliente As TextBox
    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents Panel2Clientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PicBxEditarClientes As PictureBox
    Friend WithEvents PicBxAgregarCliente As PictureBox
    Friend WithEvents PicBxEliminarCliente As PictureBox
    Friend WithEvents PicBxGuardarCliente As PictureBox
    Friend WithEvents ToolTipCliente As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBxDatosCliente As GroupBox
    Friend WithEvents PicBx2RegistrosdeCliente As PictureBox
    Friend WithEvents txtdireccionCliente As TextBox
    Friend WithEvents LabelDirec As Label
    Friend WithEvents txtApellido2Cliente As TextBox
    Friend WithEvents labelApellido2Cliente As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
