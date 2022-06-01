<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetalle_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetalle_Factura))
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BttAgregarDetalleVenta = New System.Windows.Forms.Button()
        Me.BttGuardarDetalleVenta = New System.Windows.Forms.Button()
        Me.PicBxGuardarDetalleVenta = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarDet_Venta = New System.Windows.Forms.PictureBox()
        Me.BttQuitarArts = New System.Windows.Forms.Button()
        Me.ToolTipCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbeliminardetalleVenta = New System.Windows.Forms.CheckBox()
        Me.txtFecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.labelApellido2Cliente = New System.Windows.Forms.Label()
        Me.txtno_factura = New System.Windows.Forms.TextBox()
        Me.lblno_factura = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblidcliente_venta = New System.Windows.Forms.Label()
        Me.lblFecha_venta = New System.Windows.Forms.Label()
        Me.GroupBxDatosVentas = New System.Windows.Forms.GroupBox()
        Me.Imagen = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBxGuardarDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarDet_Venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBxDatosVentas.SuspendLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1Clientes
        '
        Me.Panel1Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1Clientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1Clientes.Location = New System.Drawing.Point(0, 22)
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(232, 606)
        Me.Panel1Clientes.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(588, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 100)
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
        Me.cbFormaPago.Location = New System.Drawing.Point(105, 143)
        Me.cbFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(329, 23)
        Me.cbFormaPago.TabIndex = 34
        Me.cbFormaPago.Text = "Efectivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BttAgregarDetalleVenta)
        Me.GroupBox1.Controls.Add(Me.BttGuardarDetalleVenta)
        Me.GroupBox1.Controls.Add(Me.PicBxGuardarDetalleVenta)
        Me.GroupBox1.Controls.Add(Me.PicBxAgregarDet_Venta)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(250, 492)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 83)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones de Registro"
        '
        'BttAgregarDetalleVenta
        '
        Me.BttAgregarDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttAgregarDetalleVenta.Location = New System.Drawing.Point(57, 24)
        Me.BttAgregarDetalleVenta.Name = "BttAgregarDetalleVenta"
        Me.BttAgregarDetalleVenta.Size = New System.Drawing.Size(111, 38)
        Me.BttAgregarDetalleVenta.TabIndex = 25
        Me.BttAgregarDetalleVenta.Text = "Agregar"
        Me.BttAgregarDetalleVenta.UseVisualStyleBackColor = True
        '
        'BttGuardarDetalleVenta
        '
        Me.BttGuardarDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttGuardarDetalleVenta.Location = New System.Drawing.Point(218, 24)
        Me.BttGuardarDetalleVenta.Name = "BttGuardarDetalleVenta"
        Me.BttGuardarDetalleVenta.Size = New System.Drawing.Size(111, 38)
        Me.BttGuardarDetalleVenta.TabIndex = 24
        Me.BttGuardarDetalleVenta.Text = "Guardar"
        Me.BttGuardarDetalleVenta.UseVisualStyleBackColor = True
        '
        'PicBxGuardarDetalleVenta
        '
        Me.PicBxGuardarDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarDetalleVenta.Image = CType(resources.GetObject("PicBxGuardarDetalleVenta.Image"), System.Drawing.Image)
        Me.PicBxGuardarDetalleVenta.Location = New System.Drawing.Point(174, 24)
        Me.PicBxGuardarDetalleVenta.Name = "PicBxGuardarDetalleVenta"
        Me.PicBxGuardarDetalleVenta.Size = New System.Drawing.Size(38, 38)
        Me.PicBxGuardarDetalleVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarDetalleVenta.TabIndex = 1
        Me.PicBxGuardarDetalleVenta.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxGuardarDetalleVenta, "Guarda o confirma el articulo a la venta")
        '
        'PicBxAgregarDet_Venta
        '
        Me.PicBxAgregarDet_Venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarDet_Venta.Image = CType(resources.GetObject("PicBxAgregarDet_Venta.Image"), System.Drawing.Image)
        Me.PicBxAgregarDet_Venta.Location = New System.Drawing.Point(13, 24)
        Me.PicBxAgregarDet_Venta.Name = "PicBxAgregarDet_Venta"
        Me.PicBxAgregarDet_Venta.Size = New System.Drawing.Size(38, 38)
        Me.PicBxAgregarDet_Venta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarDet_Venta.TabIndex = 2
        Me.PicBxAgregarDet_Venta.TabStop = False
        Me.ToolTipCliente.SetToolTip(Me.PicBxAgregarDet_Venta, "Agrega un nuevo producto a la venta")
        '
        'BttQuitarArts
        '
        Me.BttQuitarArts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttQuitarArts.Location = New System.Drawing.Point(1197, 36)
        Me.BttQuitarArts.Name = "BttQuitarArts"
        Me.BttQuitarArts.Size = New System.Drawing.Size(111, 27)
        Me.BttQuitarArts.TabIndex = 23
        Me.BttQuitarArts.Text = "Quitar Arcticulo"
        Me.BttQuitarArts.UseVisualStyleBackColor = True
        '
        'DataGridViewDetalleVenta
        '
        Me.DataGridViewDetalleVenta.AllowUserToAddRows = False
        Me.DataGridViewDetalleVenta.AllowUserToDeleteRows = False
        Me.DataGridViewDetalleVenta.AllowUserToResizeColumns = False
        Me.DataGridViewDetalleVenta.AllowUserToResizeRows = False
        Me.DataGridViewDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridViewDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewDetalleVenta.Location = New System.Drawing.Point(716, 69)
        Me.DataGridViewDetalleVenta.Name = "DataGridViewDetalleVenta"
        Me.DataGridViewDetalleVenta.ReadOnly = True
        Me.DataGridViewDetalleVenta.RowHeadersWidth = 51
        Me.DataGridViewDetalleVenta.RowTemplate.Height = 25
        Me.DataGridViewDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDetalleVenta.Size = New System.Drawing.Size(592, 506)
        Me.DataGridViewDetalleVenta.TabIndex = 44
        Me.ToolTipCliente.SetToolTip(Me.DataGridViewDetalleVenta, "Para editar o eliminar, primero seleccione un registro")
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
        Me.linklblInexistente.Location = New System.Drawing.Point(961, 283)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(102, 15)
        Me.linklblInexistente.TabIndex = 48
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1329, 22)
        Me.Panel1.TabIndex = 45
        '
        'cbeliminardetalleVenta
        '
        Me.cbeliminardetalleVenta.AutoSize = True
        Me.cbeliminardetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbeliminardetalleVenta.Location = New System.Drawing.Point(716, 44)
        Me.cbeliminardetalleVenta.Name = "cbeliminardetalleVenta"
        Me.cbeliminardetalleVenta.Size = New System.Drawing.Size(69, 19)
        Me.cbeliminardetalleVenta.TabIndex = 49
        Me.cbeliminardetalleVenta.Text = "Eliminar"
        Me.cbeliminardetalleVenta.UseVisualStyleBackColor = True
        '
        'txtFecha_venta
        '
        Me.txtFecha_venta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtFecha_venta.Enabled = False
        Me.txtFecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha_venta.Location = New System.Drawing.Point(105, 105)
        Me.txtFecha_venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha_venta.Name = "txtFecha_venta"
        Me.txtFecha_venta.Size = New System.Drawing.Size(114, 23)
        Me.txtFecha_venta.TabIndex = 25
        '
        'labelApellido2Cliente
        '
        Me.labelApellido2Cliente.AutoSize = True
        Me.labelApellido2Cliente.Location = New System.Drawing.Point(8, 146)
        Me.labelApellido2Cliente.Name = "labelApellido2Cliente"
        Me.labelApellido2Cliente.Size = New System.Drawing.Size(93, 15)
        Me.labelApellido2Cliente.TabIndex = 15
        Me.labelApellido2Cliente.Text = "Forma de pago :"
        '
        'txtno_factura
        '
        Me.txtno_factura.Cursor = System.Windows.Forms.Cursors.No
        Me.txtno_factura.Enabled = False
        Me.txtno_factura.Location = New System.Drawing.Point(105, 27)
        Me.txtno_factura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtno_factura.Name = "txtno_factura"
        Me.txtno_factura.Size = New System.Drawing.Size(58, 23)
        Me.txtno_factura.TabIndex = 1
        '
        'lblno_factura
        '
        Me.lblno_factura.AutoSize = True
        Me.lblno_factura.Location = New System.Drawing.Point(29, 30)
        Me.lblno_factura.Name = "lblno_factura"
        Me.lblno_factura.Size = New System.Drawing.Size(69, 15)
        Me.lblno_factura.TabIndex = 4
        Me.lblno_factura.Text = "N° Factura :"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(105, 65)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(58, 23)
        Me.txtIdCliente.TabIndex = 12
        '
        'lblidcliente_venta
        '
        Me.lblidcliente_venta.AutoSize = True
        Me.lblidcliente_venta.Location = New System.Drawing.Point(35, 68)
        Me.lblidcliente_venta.Name = "lblidcliente_venta"
        Me.lblidcliente_venta.Size = New System.Drawing.Size(63, 15)
        Me.lblidcliente_venta.TabIndex = 11
        Me.lblidcliente_venta.Text = "Id Cliente :"
        '
        'lblFecha_venta
        '
        Me.lblFecha_venta.AutoSize = True
        Me.lblFecha_venta.Location = New System.Drawing.Point(54, 111)
        Me.lblFecha_venta.Name = "lblFecha_venta"
        Me.lblFecha_venta.Size = New System.Drawing.Size(44, 15)
        Me.lblFecha_venta.TabIndex = 13
        Me.lblFecha_venta.Text = "Fecha :"
        '
        'GroupBxDatosVentas
        '
        Me.GroupBxDatosVentas.Controls.Add(Me.Imagen)
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
        Me.GroupBxDatosVentas.Controls.Add(Me.txtFecha_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.labelApellido2Cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtIdCliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblidcliente_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblFecha_venta)
        Me.GroupBxDatosVentas.Location = New System.Drawing.Point(250, 137)
        Me.GroupBxDatosVentas.Name = "GroupBxDatosVentas"
        Me.GroupBxDatosVentas.Size = New System.Drawing.Size(451, 349)
        Me.GroupBxDatosVentas.TabIndex = 43
        Me.GroupBxDatosVentas.TabStop = False
        Me.GroupBxDatosVentas.Text = "Datos de la venta"
        '
        'Imagen
        '
        Me.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Imagen.Location = New System.Drawing.Point(289, 209)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(145, 134)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen.TabIndex = 47
        Me.Imagen.TabStop = False
        '
        'txtStock
        '
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.No
        Me.txtStock.Location = New System.Drawing.Point(105, 260)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtStock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(72, 23)
        Me.txtStock.TabIndex = 46
        Me.txtStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCantidad
        '
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCantidad.Location = New System.Drawing.Point(105, 220)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 23)
        Me.txtCantidad.TabIndex = 45
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(104, 301)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(73, 23)
        Me.txtPrecioUnitario.TabIndex = 44
        '
        'lblPrecio_Unitario
        '
        Me.lblPrecio_Unitario.AutoSize = True
        Me.lblPrecio_Unitario.Location = New System.Drawing.Point(8, 304)
        Me.lblPrecio_Unitario.Name = "lblPrecio_Unitario"
        Me.lblPrecio_Unitario.Size = New System.Drawing.Size(90, 15)
        Me.lblPrecio_Unitario.TabIndex = 43
        Me.lblPrecio_Unitario.Text = "Precio unitario :"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(56, 262)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(42, 15)
        Me.lblStock.TabIndex = 42
        Me.lblStock.Text = "Stock :"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(37, 222)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(61, 15)
        Me.lblCantidad.TabIndex = 41
        Me.lblCantidad.Text = "Cantidad :"
        '
        'txtNombre_Medicamento
        '
        Me.txtNombre_Medicamento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNombre_Medicamento.Enabled = False
        Me.txtNombre_Medicamento.Location = New System.Drawing.Point(169, 181)
        Me.txtNombre_Medicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre_Medicamento.Name = "txtNombre_Medicamento"
        Me.txtNombre_Medicamento.Size = New System.Drawing.Size(223, 23)
        Me.txtNombre_Medicamento.TabIndex = 40
        '
        'btnBuscar_Medicamento
        '
        Me.btnBuscar_Medicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar_Medicamento.Location = New System.Drawing.Point(398, 181)
        Me.btnBuscar_Medicamento.Name = "btnBuscar_Medicamento"
        Me.btnBuscar_Medicamento.Size = New System.Drawing.Size(36, 23)
        Me.btnBuscar_Medicamento.TabIndex = 39
        Me.btnBuscar_Medicamento.Text = "..."
        Me.btnBuscar_Medicamento.UseVisualStyleBackColor = True
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdMedicamento.Enabled = False
        Me.txtIdMedicamento.Location = New System.Drawing.Point(105, 181)
        Me.txtIdMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.Size = New System.Drawing.Size(58, 23)
        Me.txtIdMedicamento.TabIndex = 38
        '
        'lblMedicamento
        '
        Me.lblMedicamento.AutoSize = True
        Me.lblMedicamento.Location = New System.Drawing.Point(11, 185)
        Me.lblMedicamento.Name = "lblMedicamento"
        Me.lblMedicamento.Size = New System.Drawing.Size(87, 15)
        Me.lblMedicamento.TabIndex = 37
        Me.lblMedicamento.Text = "Medicamento :"
        '
        'txtApellido2_cliente
        '
        Me.txtApellido2_cliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtApellido2_cliente.Enabled = False
        Me.txtApellido2_cliente.Location = New System.Drawing.Point(311, 65)
        Me.txtApellido2_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido2_cliente.Name = "txtApellido2_cliente"
        Me.txtApellido2_cliente.Size = New System.Drawing.Size(123, 23)
        Me.txtApellido2_cliente.TabIndex = 36
        '
        'txtApellido1_cliente
        '
        Me.txtApellido1_cliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtApellido1_cliente.Enabled = False
        Me.txtApellido1_cliente.Location = New System.Drawing.Point(168, 65)
        Me.txtApellido1_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido1_cliente.Name = "txtApellido1_cliente"
        Me.txtApellido1_cliente.Size = New System.Drawing.Size(137, 23)
        Me.txtApellido1_cliente.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(292, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 29)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "DETALLES DE VENTA"
        '
        'FormDetalle_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 628)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.BttQuitarArts)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbeliminardetalleVenta)
        Me.Controls.Add(Me.GroupBxDatosVentas)
        Me.Controls.Add(Me.DataGridViewDetalleVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormDetalle_Factura"
        Me.Text = "FormDetalle_Factura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicBxGuardarDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarDet_Venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBxDatosVentas.ResumeLayout(False)
        Me.GroupBxDatosVentas.PerformLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbeliminardetalleVenta As CheckBox
    Friend WithEvents GroupBxDatosVentas As GroupBox
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BttGuardarDetalleVenta As Button
    Friend WithEvents BttQuitarArts As Button
    Friend WithEvents ToolTipCliente As ToolTip
    Friend WithEvents PicBxGuardarDetalleVenta As PictureBox
    Friend WithEvents PicBxAgregarDet_Venta As PictureBox
    Friend WithEvents txtFecha_venta As DateTimePicker
    Friend WithEvents labelApellido2Cliente As Label
    Friend WithEvents txtno_factura As TextBox
    Friend WithEvents lblno_factura As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblidcliente_venta As Label
    Friend WithEvents lblFecha_venta As Label
    Friend WithEvents DataGridViewDetalleVenta As DataGridView
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
    Friend WithEvents BttAgregarDetalleVenta As Button
    Friend WithEvents Imagen As PictureBox
End Class
