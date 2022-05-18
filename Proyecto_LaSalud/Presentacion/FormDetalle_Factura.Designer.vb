<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalle_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetalle_Factura))
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BttAgregarVenta = New System.Windows.Forms.Button()
        Me.BttGuardarVenta = New System.Windows.Forms.Button()
        Me.BttEditarVenta = New System.Windows.Forms.Button()
        Me.PicBxEditarClientes = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.ToolTipCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBusquedaDetalle_factura = New System.Windows.Forms.TextBox()
        Me.cbCampoDetalle_factura = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.txtFecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.labelApellido2Cliente = New System.Windows.Forms.Label()
        Me.txtno_factura = New System.Windows.Forms.TextBox()
        Me.lblno_factura = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblidcliente_venta = New System.Windows.Forms.Label()
        Me.lblFecha_venta = New System.Windows.Forms.Label()
        Me.GroupBxDatosVentas = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.NumericUpDown()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.lblPrecio_Unitario = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtNombre_Medicamento = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Medicamento = New System.Windows.Forms.Button()
        Me.txtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.lblMedicamento = New System.Windows.Forms.Label()
        Me.txtApellido2_cliente = New System.Windows.Forms.TextBox()
        Me.txtApellido1_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BttEliminarDetalle_factura = New System.Windows.Forms.Button()
        Me.PicBxEliminarCategoria = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBxDatosVentas.SuspendLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1Clientes
        '
        Me.Panel1Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1Clientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1Clientes.Location = New System.Drawing.Point(0, 29)
        Me.Panel1Clientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(265, 798)
        Me.Panel1Clientes.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(645, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Enabled = False
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Items.AddRange(New Object() {"Efectivo", "BITCOIN", "Tarjeta de credito"})
        Me.cbFormaPago.Location = New System.Drawing.Point(126, 176)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(255, 28)
        Me.cbFormaPago.TabIndex = 34
        Me.cbFormaPago.Text = "Efectivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BttEliminarDetalle_factura)
        Me.GroupBox1.Controls.Add(Me.PicBxEliminarCategoria)
        Me.GroupBox1.Controls.Add(Me.BttAgregarVenta)
        Me.GroupBox1.Controls.Add(Me.BttGuardarVenta)
        Me.GroupBox1.Controls.Add(Me.BttEditarVenta)
        Me.GroupBox1.Controls.Add(Me.PicBxEditarClientes)
        Me.GroupBox1.Controls.Add(Me.PicBxGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxAgregarCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 433)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(460, 156)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones de Registro"
        '
        'BttAgregarVenta
        '
        Me.BttAgregarVenta.Location = New System.Drawing.Point(65, 91)
        Me.BttAgregarVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttAgregarVenta.Name = "BttAgregarVenta"
        Me.BttAgregarVenta.Size = New System.Drawing.Size(127, 51)
        Me.BttAgregarVenta.TabIndex = 25
        Me.BttAgregarVenta.Text = "Agregar"
        Me.BttAgregarVenta.UseVisualStyleBackColor = True
        '
        'BttGuardarVenta
        '
        Me.BttGuardarVenta.Location = New System.Drawing.Point(261, 32)
        Me.BttGuardarVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttGuardarVenta.Name = "BttGuardarVenta"
        Me.BttGuardarVenta.Size = New System.Drawing.Size(127, 51)
        Me.BttGuardarVenta.TabIndex = 24
        Me.BttGuardarVenta.Text = "Guardar"
        Me.BttGuardarVenta.UseVisualStyleBackColor = True
        '
        'BttEditarVenta
        '
        Me.BttEditarVenta.Location = New System.Drawing.Point(65, 32)
        Me.BttEditarVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttEditarVenta.Name = "BttEditarVenta"
        Me.BttEditarVenta.Size = New System.Drawing.Size(127, 51)
        Me.BttEditarVenta.TabIndex = 23
        Me.BttEditarVenta.Text = "Editar"
        Me.BttEditarVenta.UseVisualStyleBackColor = True
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
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridViewVentas.Location = New System.Drawing.Point(807, 133)
        Me.DataGridViewVentas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.RowHeadersWidth = 51
        Me.DataGridViewVentas.RowTemplate.Height = 25
        Me.DataGridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVentas.Size = New System.Drawing.Size(688, 483)
        Me.DataGridViewVentas.TabIndex = 44
        Me.ToolTipCliente.SetToolTip(Me.DataGridViewVentas, "Para editar o eliminar, primero seleccione un registro")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Location = New System.Drawing.Point(1098, 377)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(129, 20)
        Me.linklblInexistente.TabIndex = 48
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'txtBusquedaDetalle_factura
        '
        Me.txtBusquedaDetalle_factura.Location = New System.Drawing.Point(1067, 67)
        Me.txtBusquedaDetalle_factura.Name = "txtBusquedaDetalle_factura"
        Me.txtBusquedaDetalle_factura.Size = New System.Drawing.Size(427, 27)
        Me.txtBusquedaDetalle_factura.TabIndex = 47
        '
        'cbCampoDetalle_factura
        '
        Me.cbCampoDetalle_factura.FormattingEnabled = True
        Me.cbCampoDetalle_factura.Items.AddRange(New Object() {"no_factura"})
        Me.cbCampoDetalle_factura.Location = New System.Drawing.Point(807, 65)
        Me.cbCampoDetalle_factura.Name = "cbCampoDetalle_factura"
        Me.cbCampoDetalle_factura.Size = New System.Drawing.Size(253, 28)
        Me.cbCampoDetalle_factura.TabIndex = 46
        Me.cbCampoDetalle_factura.Text = "no_factura"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1517, 29)
        Me.Panel1.TabIndex = 45
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(807, 103)
        Me.cbeliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(85, 24)
        Me.cbeliminar.TabIndex = 49
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'txtFecha_venta
        '
        Me.txtFecha_venta.Enabled = False
        Me.txtFecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha_venta.Location = New System.Drawing.Point(125, 133)
        Me.txtFecha_venta.Name = "txtFecha_venta"
        Me.txtFecha_venta.Size = New System.Drawing.Size(130, 27)
        Me.txtFecha_venta.TabIndex = 25
        '
        'labelApellido2Cliente
        '
        Me.labelApellido2Cliente.AutoSize = True
        Me.labelApellido2Cliente.Location = New System.Drawing.Point(6, 177)
        Me.labelApellido2Cliente.Name = "labelApellido2Cliente"
        Me.labelApellido2Cliente.Size = New System.Drawing.Size(114, 20)
        Me.labelApellido2Cliente.TabIndex = 15
        Me.labelApellido2Cliente.Text = "Forma de pago:"
        '
        'txtno_factura
        '
        Me.txtno_factura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtno_factura.Enabled = False
        Me.txtno_factura.Location = New System.Drawing.Point(125, 39)
        Me.txtno_factura.Name = "txtno_factura"
        Me.txtno_factura.Size = New System.Drawing.Size(131, 27)
        Me.txtno_factura.TabIndex = 1
        '
        'lblno_factura
        '
        Me.lblno_factura.AutoSize = True
        Me.lblno_factura.Location = New System.Drawing.Point(38, 40)
        Me.lblno_factura.Name = "lblno_factura"
        Me.lblno_factura.Size = New System.Drawing.Size(81, 20)
        Me.lblno_factura.TabIndex = 4
        Me.lblno_factura.Text = "no_factura:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(125, 87)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(61, 27)
        Me.txtIdCliente.TabIndex = 12
        '
        'lblidcliente_venta
        '
        Me.lblidcliente_venta.AutoSize = True
        Me.lblidcliente_venta.Location = New System.Drawing.Point(48, 91)
        Me.lblidcliente_venta.Name = "lblidcliente_venta"
        Me.lblidcliente_venta.Size = New System.Drawing.Size(71, 20)
        Me.lblidcliente_venta.TabIndex = 11
        Me.lblidcliente_venta.Text = "IdCliente:"
        '
        'lblFecha_venta
        '
        Me.lblFecha_venta.AutoSize = True
        Me.lblFecha_venta.Location = New System.Drawing.Point(69, 139)
        Me.lblFecha_venta.Name = "lblFecha_venta"
        Me.lblFecha_venta.Size = New System.Drawing.Size(50, 20)
        Me.lblFecha_venta.TabIndex = 13
        Me.lblFecha_venta.Text = "Fecha:"
        '
        'GroupBxDatosVentas
        '
        Me.GroupBxDatosVentas.Controls.Add(Me.txtStock)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtCantidad)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblPrecio_Unitario)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblStock)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblCantidad)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtNombre_Medicamento)
        Me.GroupBxDatosVentas.Controls.Add(Me.btnBuscar_Medicamento)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtIdMedicamento)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblMedicamento)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtApellido2_cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtApellido1_cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.cbFormaPago)
        Me.GroupBxDatosVentas.Controls.Add(Me.GroupBox1)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtFecha_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.labelApellido2Cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtIdCliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblidcliente_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblFecha_venta)
        Me.GroupBxDatosVentas.Enabled = False
        Me.GroupBxDatosVentas.Location = New System.Drawing.Point(286, 183)
        Me.GroupBxDatosVentas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosVentas.Name = "GroupBxDatosVentas"
        Me.GroupBxDatosVentas.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosVentas.Size = New System.Drawing.Size(515, 597)
        Me.GroupBxDatosVentas.TabIndex = 43
        Me.GroupBxDatosVentas.TabStop = False
        Me.GroupBxDatosVentas.Text = "Datos de la venta"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(126, 317)
        Me.txtStock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtStock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(82, 27)
        Me.txtStock.TabIndex = 46
        Me.txtStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(125, 276)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(82, 27)
        Me.txtCantidad.TabIndex = 45
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(125, 358)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(165, 27)
        Me.txtPrecioUnitario.TabIndex = 44
        '
        'lblPrecio_Unitario
        '
        Me.lblPrecio_Unitario.AutoSize = True
        Me.lblPrecio_Unitario.Location = New System.Drawing.Point(16, 358)
        Me.lblPrecio_Unitario.Name = "lblPrecio_Unitario"
        Me.lblPrecio_Unitario.Size = New System.Drawing.Size(108, 20)
        Me.lblPrecio_Unitario.TabIndex = 43
        Me.lblPrecio_Unitario.Text = "Precio unitario:"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(71, 319)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(48, 20)
        Me.lblStock.TabIndex = 42
        Me.lblStock.Text = "Stock:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(47, 278)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(72, 20)
        Me.lblCantidad.TabIndex = 41
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtNombre_Medicamento
        '
        Me.txtNombre_Medicamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre_Medicamento.Location = New System.Drawing.Point(193, 234)
        Me.txtNombre_Medicamento.Name = "txtNombre_Medicamento"
        Me.txtNombre_Medicamento.Size = New System.Drawing.Size(165, 27)
        Me.txtNombre_Medicamento.TabIndex = 40
        '
        'btnBuscar_Medicamento
        '
        Me.btnBuscar_Medicamento.Location = New System.Drawing.Point(379, 234)
        Me.btnBuscar_Medicamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar_Medicamento.Name = "btnBuscar_Medicamento"
        Me.btnBuscar_Medicamento.Size = New System.Drawing.Size(46, 27)
        Me.btnBuscar_Medicamento.TabIndex = 39
        Me.btnBuscar_Medicamento.Text = "..."
        Me.btnBuscar_Medicamento.UseVisualStyleBackColor = True
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdMedicamento.Location = New System.Drawing.Point(126, 234)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.Size = New System.Drawing.Size(61, 27)
        Me.txtIdMedicamento.TabIndex = 38
        '
        'lblMedicamento
        '
        Me.lblMedicamento.AutoSize = True
        Me.lblMedicamento.Location = New System.Drawing.Point(16, 241)
        Me.lblMedicamento.Name = "lblMedicamento"
        Me.lblMedicamento.Size = New System.Drawing.Size(104, 20)
        Me.lblMedicamento.TabIndex = 37
        Me.lblMedicamento.Text = "Medicamento:"
        '
        'txtApellido2_cliente
        '
        Me.txtApellido2_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido2_cliente.Enabled = False
        Me.txtApellido2_cliente.Location = New System.Drawing.Point(323, 87)
        Me.txtApellido2_cliente.Name = "txtApellido2_cliente"
        Me.txtApellido2_cliente.Size = New System.Drawing.Size(125, 27)
        Me.txtApellido2_cliente.TabIndex = 36
        '
        'txtApellido1_cliente
        '
        Me.txtApellido1_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido1_cliente.Enabled = False
        Me.txtApellido1_cliente.Location = New System.Drawing.Point(192, 87)
        Me.txtApellido1_cliente.Name = "txtApellido1_cliente"
        Me.txtApellido1_cliente.Size = New System.Drawing.Size(125, 27)
        Me.txtApellido1_cliente.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(286, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 36)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "DETALLES DE VENTA"
        '
        'BttEliminarDetalle_factura
        '
        Me.BttEliminarDetalle_factura.Location = New System.Drawing.Point(261, 91)
        Me.BttEliminarDetalle_factura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BttEliminarDetalle_factura.Name = "BttEliminarDetalle_factura"
        Me.BttEliminarDetalle_factura.Size = New System.Drawing.Size(127, 51)
        Me.BttEliminarDetalle_factura.TabIndex = 51
        Me.BttEliminarDetalle_factura.Text = "Eliminar"
        Me.BttEliminarDetalle_factura.UseVisualStyleBackColor = True
        '
        'PicBxEliminarCategoria
        '
        Me.PicBxEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarCategoria.Image = CType(resources.GetObject("PicBxEliminarCategoria.Image"), System.Drawing.Image)
        Me.PicBxEliminarCategoria.Location = New System.Drawing.Point(211, 91)
        Me.PicBxEliminarCategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBxEliminarCategoria.Name = "PicBxEliminarCategoria"
        Me.PicBxEliminarCategoria.Size = New System.Drawing.Size(43, 51)
        Me.PicBxEliminarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarCategoria.TabIndex = 50
        Me.PicBxEliminarCategoria.TabStop = False
        '
        'FormDetalle_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 827)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.txtBusquedaDetalle_factura)
        Me.Controls.Add(Me.cbCampoDetalle_factura)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.GroupBxDatosVentas)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormDetalle_Factura"
        Me.Text = "FormDetalle_Factura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBxDatosVentas.ResumeLayout(False)
        Me.GroupBxDatosVentas.PerformLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents txtBusquedaDetalle_factura As TextBox
    Friend WithEvents cbCampoDetalle_factura As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents GroupBxDatosVentas As GroupBox
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BttAgregarVenta As Button
    Friend WithEvents BttGuardarVenta As Button
    Friend WithEvents BttEditarVenta As Button
    Friend WithEvents PicBxEditarClientes As PictureBox
    Friend WithEvents ToolTipCliente As ToolTip
    Friend WithEvents PicBxGuardarCliente As PictureBox
    Friend WithEvents PicBxAgregarCliente As PictureBox
    Friend WithEvents txtFecha_venta As DateTimePicker
    Friend WithEvents labelApellido2Cliente As Label
    Friend WithEvents txtno_factura As TextBox
    Friend WithEvents lblno_factura As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblidcliente_venta As Label
    Friend WithEvents lblFecha_venta As Label
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido1_cliente As TextBox
    Friend WithEvents txtApellido2_cliente As TextBox
    Friend WithEvents btnBuscar_Medicamento As Button
    Friend WithEvents txtIdMedicamento As TextBox
    Friend WithEvents lblMedicamento As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPrecio_Unitario As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtNombre_Medicamento As TextBox
    Friend WithEvents BttEliminarDetalle_factura As Button
    Friend WithEvents PicBxEliminarCategoria As PictureBox
End Class
