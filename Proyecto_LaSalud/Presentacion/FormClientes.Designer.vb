<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicBxEditarClientes = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarCliente = New System.Windows.Forms.PictureBox()
        Me.ToolTipCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BttEliminarCliente = New System.Windows.Forms.Button()
        Me.BttAgregarCliente = New System.Windows.Forms.Button()
        Me.BttGuardarCliente = New System.Windows.Forms.Button()
        Me.BttEditarCliente = New System.Windows.Forms.Button()
        Me.GroupBxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TxtApellido3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdireccionCliente = New System.Windows.Forms.TextBox()
        Me.LabelDirec = New System.Windows.Forms.Label()
        Me.txtApellido2Cliente = New System.Windows.Forms.TextBox()
        Me.labelApellido2Cliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCampoCliente = New System.Windows.Forms.ComboBox()
        Me.txtBusquedaClientes = New System.Windows.Forms.TextBox()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBxDatosCliente.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdClientes
        '
        Me.txtIdClientes.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdClientes.Location = New System.Drawing.Point(90, 55)
        Me.txtIdClientes.Name = "txtIdClientes"
        Me.txtIdClientes.Size = New System.Drawing.Size(131, 27)
        Me.txtIdClientes.TabIndex = 1
        '
        'txtDUIClientes
        '
        Me.txtDUIClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDUIClientes.Location = New System.Drawing.Point(272, 55)
        Me.txtDUIClientes.MaxLength = 9
        Me.txtDUIClientes.Name = "txtDUIClientes"
        Me.txtDUIClientes.Size = New System.Drawing.Size(194, 27)
        Me.txtDUIClientes.TabIndex = 2
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(56, 55)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(29, 20)
        Me.lblIdCliente.TabIndex = 4
        Me.lblIdCliente.Text = "Id :"
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(229, 59)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(41, 20)
        Me.lblDUI.TabIndex = 5
        Me.lblDUI.Text = "DUI :"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(26, 345)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo :"
        '
        'txtCorreoClientes
        '
        Me.txtCorreoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreoClientes.Location = New System.Drawing.Point(89, 341)
        Me.txtCorreoClientes.MaxLength = 50
        Me.txtCorreoClientes.Name = "txtCorreoClientes"
        Me.txtCorreoClientes.Size = New System.Drawing.Size(377, 27)
        Me.txtCorreoClientes.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(16, 523)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(74, 20)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono :"
        '
        'txtTelefonoClientes
        '
        Me.txtTelefonoClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefonoClientes.Location = New System.Drawing.Point(90, 519)
        Me.txtTelefonoClientes.MaxLength = 10
        Me.txtTelefonoClientes.Name = "txtTelefonoClientes"
        Me.txtTelefonoClientes.Size = New System.Drawing.Size(375, 27)
        Me.txtTelefonoClientes.TabIndex = 10
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(13, 109)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(77, 20)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombres :"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreClientes.Location = New System.Drawing.Point(90, 109)
        Me.txtNombreClientes.MaxLength = 50
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(375, 27)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Location = New System.Drawing.Point(11, 168)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(85, 20)
        Me.lblApellidosClientes.TabIndex = 13
        Me.lblApellidosClientes.Text = "Apellido 1 :"
        '
        'txtApellido1Cliente
        '
        Me.txtApellido1Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido1Cliente.Location = New System.Drawing.Point(89, 164)
        Me.txtApellido1Cliente.MaxLength = 50
        Me.txtApellido1Cliente.Name = "txtApellido1Cliente"
        Me.txtApellido1Cliente.Size = New System.Drawing.Size(377, 27)
        Me.txtApellido1Cliente.TabIndex = 14
        '
        'Panel1Clientes
        '
        Me.Panel1Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1Clientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1Clientes.Location = New System.Drawing.Point(0, 0)
        Me.Panel1Clientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(265, 837)
        Me.Panel1Clientes.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(645, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(286, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 36)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "REGISTRO DE CLIENTES"
        '
        'PicBxEditarClientes
        '
        Me.PicBxEditarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEditarClientes.Image = CType(resources.GetObject("PicBxEditarClientes.Image"), System.Drawing.Image)
        Me.PicBxEditarClientes.Location = New System.Drawing.Point(15, 32)
        Me.PicBxEditarClientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBxEditarClientes.Name = "PicBxEditarClientes"
        Me.PicBxEditarClientes.Size = New System.Drawing.Size(43, 51)
        Me.PicBxEditarClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarClientes.TabIndex = 0
        Me.PicBxEditarClientes.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxEditarClientes, "Editar el registro de Cliente")
        '
        'PicBxAgregarCliente
        '
        Me.PicBxAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarCliente.Image = CType(resources.GetObject("PicBxAgregarCliente.Image"), System.Drawing.Image)
        Me.PicBxAgregarCliente.Location = New System.Drawing.Point(15, 91)
        Me.PicBxAgregarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBxAgregarCliente.Name = "PicBxAgregarCliente"
        Me.PicBxAgregarCliente.Size = New System.Drawing.Size(43, 51)
        Me.PicBxAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarCliente.TabIndex = 2
        Me.PicBxAgregarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxAgregarCliente, "Agregar el registro del cliente")
        '
        'PicBxEliminarCliente
        '
        Me.PicBxEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarCliente.Image = CType(resources.GetObject("PicBxEliminarCliente.Image"), System.Drawing.Image)
        Me.PicBxEliminarCliente.Location = New System.Drawing.Point(210, 91)
        Me.PicBxEliminarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBxEliminarCliente.Name = "PicBxEliminarCliente"
        Me.PicBxEliminarCliente.Size = New System.Drawing.Size(43, 51)
        Me.PicBxEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarCliente.TabIndex = 3
        Me.PicBxEliminarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxEliminarCliente, "Eliminar el registro del cliente")
        '
        'PicBxGuardarCliente
        '
        Me.PicBxGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarCliente.Image = CType(resources.GetObject("PicBxGuardarCliente.Image"), System.Drawing.Image)
        Me.PicBxGuardarCliente.Location = New System.Drawing.Point(210, 32)
        Me.PicBxGuardarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBxGuardarCliente.Name = "PicBxGuardarCliente"
        Me.PicBxGuardarCliente.Size = New System.Drawing.Size(43, 51)
        Me.PicBxGuardarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarCliente.TabIndex = 1
        Me.PicBxGuardarCliente.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxGuardarCliente, "Guardar el registro del cliente")
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AllowUserToAddRows = False
        Me.DataGridViewClientes.AllowUserToDeleteRows = False
        Me.DataGridViewClientes.AllowUserToResizeColumns = False
        Me.DataGridViewClientes.AllowUserToResizeRows = False
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridViewClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewClientes.Location = New System.Drawing.Point(807, 133)
        Me.DataGridViewClientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.RowHeadersWidth = 51
        Me.DataGridViewClientes.RowTemplate.Height = 25
        Me.DataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewClientes.Size = New System.Drawing.Size(688, 483)
        Me.DataGridViewClientes.TabIndex = 23
        Me.ToolTipCliente.SetToolTip(Me.DataGridViewClientes, "Para editar o eliminar, primero seleccione un registro")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BttEliminarCliente)
        Me.GroupBox1.Controls.Add(Me.BttAgregarCliente)
        Me.GroupBox1.Controls.Add(Me.BttGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.BttEditarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxEditarClientes)
        Me.GroupBox1.Controls.Add(Me.PicBxEliminarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxAgregarCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(807, 624)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(688, 156)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones de Registro"
        '
        'BttEliminarCliente
        '
        Me.BttEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEliminarCliente.Location = New System.Drawing.Point(261, 91)
        Me.BttEliminarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttEliminarCliente.Name = "BttEliminarCliente"
        Me.BttEliminarCliente.Size = New System.Drawing.Size(127, 51)
        Me.BttEliminarCliente.TabIndex = 26
        Me.BttEliminarCliente.Text = "Eliminar"
        Me.BttEliminarCliente.UseVisualStyleBackColor = True
        '
        'BttAgregarCliente
        '
        Me.BttAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttAgregarCliente.Location = New System.Drawing.Point(65, 91)
        Me.BttAgregarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttAgregarCliente.Name = "BttAgregarCliente"
        Me.BttAgregarCliente.Size = New System.Drawing.Size(127, 51)
        Me.BttAgregarCliente.TabIndex = 25
        Me.BttAgregarCliente.Text = "Agregar"
        Me.BttAgregarCliente.UseVisualStyleBackColor = True
        '
        'BttGuardarCliente
        '
        Me.BttGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttGuardarCliente.Location = New System.Drawing.Point(261, 32)
        Me.BttGuardarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttGuardarCliente.Name = "BttGuardarCliente"
        Me.BttGuardarCliente.Size = New System.Drawing.Size(127, 51)
        Me.BttGuardarCliente.TabIndex = 24
        Me.BttGuardarCliente.Text = "Guardar"
        Me.BttGuardarCliente.UseVisualStyleBackColor = True
        '
        'BttEditarCliente
        '
        Me.BttEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEditarCliente.Location = New System.Drawing.Point(65, 32)
        Me.BttEditarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttEditarCliente.Name = "BttEditarCliente"
        Me.BttEditarCliente.Size = New System.Drawing.Size(127, 51)
        Me.BttEditarCliente.TabIndex = 23
        Me.BttEditarCliente.Text = "Editar"
        Me.BttEditarCliente.UseVisualStyleBackColor = True
        '
        'GroupBxDatosCliente
        '
        Me.GroupBxDatosCliente.Controls.Add(Me.TxtApellido3)
        Me.GroupBxDatosCliente.Controls.Add(Me.Label1)
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
        Me.GroupBxDatosCliente.Location = New System.Drawing.Point(286, 183)
        Me.GroupBxDatosCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosCliente.Name = "GroupBxDatosCliente"
        Me.GroupBxDatosCliente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosCliente.Size = New System.Drawing.Size(488, 597)
        Me.GroupBxDatosCliente.TabIndex = 21
        Me.GroupBxDatosCliente.TabStop = False
        Me.GroupBxDatosCliente.Text = "Datos del Cliente"
        '
        'TxtApellido3
        '
        Me.TxtApellido3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtApellido3.Location = New System.Drawing.Point(89, 284)
        Me.TxtApellido3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellido3.MaxLength = 50
        Me.TxtApellido3.Name = "TxtApellido3"
        Me.TxtApellido3.Size = New System.Drawing.Size(377, 27)
        Me.TxtApellido3.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Apellido 3 :"
        '
        'txtdireccionCliente
        '
        Me.txtdireccionCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdireccionCliente.Location = New System.Drawing.Point(89, 395)
        Me.txtdireccionCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdireccionCliente.MaxLength = 50
        Me.txtdireccionCliente.Multiline = True
        Me.txtdireccionCliente.Name = "txtdireccionCliente"
        Me.txtdireccionCliente.Size = New System.Drawing.Size(377, 100)
        Me.txtdireccionCliente.TabIndex = 19
        '
        'LabelDirec
        '
        Me.LabelDirec.AutoSize = True
        Me.LabelDirec.Location = New System.Drawing.Point(10, 399)
        Me.LabelDirec.Name = "LabelDirec"
        Me.LabelDirec.Size = New System.Drawing.Size(79, 20)
        Me.LabelDirec.TabIndex = 17
        Me.LabelDirec.Text = "Dirección :"
        '
        'txtApellido2Cliente
        '
        Me.txtApellido2Cliente.Location = New System.Drawing.Point(89, 220)
        Me.txtApellido2Cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido2Cliente.MaxLength = 50
        Me.txtApellido2Cliente.Name = "txtApellido2Cliente"
        Me.txtApellido2Cliente.Size = New System.Drawing.Size(377, 27)
        Me.txtApellido2Cliente.TabIndex = 16
        '
        'labelApellido2Cliente
        '
        Me.labelApellido2Cliente.AutoSize = True
        Me.labelApellido2Cliente.Location = New System.Drawing.Point(13, 224)
        Me.labelApellido2Cliente.Name = "labelApellido2Cliente"
        Me.labelApellido2Cliente.Size = New System.Drawing.Size(85, 20)
        Me.labelApellido2Cliente.TabIndex = 15
        Me.labelApellido2Cliente.Text = "Apellido 2 :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(265, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1254, 29)
        Me.Panel1.TabIndex = 24
        '
        'cbCampoCliente
        '
        Me.cbCampoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCampoCliente.FormattingEnabled = True
        Me.cbCampoCliente.Items.AddRange(New Object() {"DUI", "nombres", "primerapellido"})
        Me.cbCampoCliente.Location = New System.Drawing.Point(807, 65)
        Me.cbCampoCliente.Name = "cbCampoCliente"
        Me.cbCampoCliente.Size = New System.Drawing.Size(253, 28)
        Me.cbCampoCliente.TabIndex = 25
        Me.cbCampoCliente.Text = "DUI"
        '
        'txtBusquedaClientes
        '
        Me.txtBusquedaClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusquedaClientes.Location = New System.Drawing.Point(1067, 67)
        Me.txtBusquedaClientes.MaxLength = 50
        Me.txtBusquedaClientes.Name = "txtBusquedaClientes"
        Me.txtBusquedaClientes.Size = New System.Drawing.Size(427, 27)
        Me.txtBusquedaClientes.TabIndex = 26
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Location = New System.Drawing.Point(1098, 377)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(129, 20)
        Me.linklblInexistente.TabIndex = 27
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbeliminar.Location = New System.Drawing.Point(807, 103)
        Me.cbeliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(85, 24)
        Me.cbeliminar.TabIndex = 28
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 837)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.txtBusquedaClientes)
        Me.Controls.Add(Me.cbCampoCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.GroupBxDatosCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormClientes"
        Me.Text = "Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBxDatosCliente.ResumeLayout(False)
        Me.GroupBxDatosCliente.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PicBxEditarClientes As PictureBox
    Friend WithEvents PicBxAgregarCliente As PictureBox
    Friend WithEvents PicBxEliminarCliente As PictureBox
    Friend WithEvents PicBxGuardarCliente As PictureBox
    Friend WithEvents ToolTipCliente As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBxDatosCliente As GroupBox
    Friend WithEvents txtdireccionCliente As TextBox
    Friend WithEvents LabelDirec As Label
    Friend WithEvents txtApellido2Cliente As TextBox
    Friend WithEvents labelApellido2Cliente As Label
    Friend WithEvents TxtApellido3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents BttEditarCliente As Button
    Friend WithEvents BttEliminarCliente As Button
    Friend WithEvents BttAgregarCliente As Button
    Friend WithEvents BttGuardarCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbCampoCliente As ComboBox
    Friend WithEvents txtBusquedaClientes As TextBox
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents cbeliminar As CheckBox
End Class
