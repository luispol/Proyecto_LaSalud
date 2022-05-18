<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBxDatosVentas = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BttAgregarVenta = New System.Windows.Forms.Button()
        Me.BttGuardarVenta = New System.Windows.Forms.Button()
        Me.BttEditarVenta = New System.Windows.Forms.Button()
        Me.PicBxEditarClientes = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarCliente = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.txtFecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar_cliente = New System.Windows.Forms.Button()
        Me.txtNombre_cliente = New System.Windows.Forms.TextBox()
        Me.txtForma_pago = New System.Windows.Forms.TextBox()
        Me.labelApellido2Cliente = New System.Windows.Forms.Label()
        Me.txtno_factura = New System.Windows.Forms.TextBox()
        Me.lblno_factura = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblidcliente_venta = New System.Windows.Forms.Label()
        Me.lblFecha_venta = New System.Windows.Forms.Label()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBusquedaClientes = New System.Windows.Forms.TextBox()
        Me.cbCampoCliente = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.ToolTipCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBxDatosVentas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridViewVentas.TabIndex = 34
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
        'GroupBxDatosVentas
        '
        Me.GroupBxDatosVentas.Controls.Add(Me.GroupBox1)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtFecha_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.btnBuscar_cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtNombre_cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtForma_pago)
        Me.GroupBxDatosVentas.Controls.Add(Me.labelApellido2Cliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblno_factura)
        Me.GroupBxDatosVentas.Controls.Add(Me.txtIdCliente)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblidcliente_venta)
        Me.GroupBxDatosVentas.Controls.Add(Me.lblFecha_venta)
        Me.GroupBxDatosVentas.Location = New System.Drawing.Point(286, 183)
        Me.GroupBxDatosVentas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosVentas.Name = "GroupBxDatosVentas"
        Me.GroupBxDatosVentas.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBxDatosVentas.Size = New System.Drawing.Size(488, 597)
        Me.GroupBxDatosVentas.TabIndex = 33
        Me.GroupBxDatosVentas.TabStop = False
        Me.GroupBxDatosVentas.Text = "Datos de la venta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BttAgregarVenta)
        Me.GroupBox1.Controls.Add(Me.BttGuardarVenta)
        Me.GroupBox1.Controls.Add(Me.BttEditarVenta)
        Me.GroupBox1.Controls.Add(Me.PicBxEditarClientes)
        Me.GroupBox1.Controls.Add(Me.PicBxGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.PicBxAgregarCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 371)
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
        'txtFecha_venta
        '
        Me.txtFecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha_venta.Location = New System.Drawing.Point(126, 162)
        Me.txtFecha_venta.Name = "txtFecha_venta"
        Me.txtFecha_venta.Size = New System.Drawing.Size(130, 27)
        Me.txtFecha_venta.TabIndex = 25
        '
        'btnBuscar_cliente
        '
        Me.btnBuscar_cliente.Location = New System.Drawing.Point(399, 107)
        Me.btnBuscar_cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar_cliente.Name = "btnBuscar_cliente"
        Me.btnBuscar_cliente.Size = New System.Drawing.Size(57, 27)
        Me.btnBuscar_cliente.TabIndex = 24
        Me.btnBuscar_cliente.Text = "..."
        Me.btnBuscar_cliente.UseVisualStyleBackColor = True
        '
        'txtNombre_cliente
        '
        Me.txtNombre_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre_cliente.Location = New System.Drawing.Point(215, 107)
        Me.txtNombre_cliente.Name = "txtNombre_cliente"
        Me.txtNombre_cliente.Size = New System.Drawing.Size(166, 27)
        Me.txtNombre_cliente.TabIndex = 22
        '
        'txtForma_pago
        '
        Me.txtForma_pago.Location = New System.Drawing.Point(126, 225)
        Me.txtForma_pago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtForma_pago.Name = "txtForma_pago"
        Me.txtForma_pago.Size = New System.Drawing.Size(330, 27)
        Me.txtForma_pago.TabIndex = 16
        '
        'labelApellido2Cliente
        '
        Me.labelApellido2Cliente.AutoSize = True
        Me.labelApellido2Cliente.Location = New System.Drawing.Point(6, 225)
        Me.labelApellido2Cliente.Name = "labelApellido2Cliente"
        Me.labelApellido2Cliente.Size = New System.Drawing.Size(114, 20)
        Me.labelApellido2Cliente.TabIndex = 15
        Me.labelApellido2Cliente.Text = "Forma de pago:"
        '
        'txtno_factura
        '
        Me.txtno_factura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtno_factura.Location = New System.Drawing.Point(126, 56)
        Me.txtno_factura.Name = "txtno_factura"
        Me.txtno_factura.Size = New System.Drawing.Size(131, 27)
        Me.txtno_factura.TabIndex = 1
        '
        'lblno_factura
        '
        Me.lblno_factura.AutoSize = True
        Me.lblno_factura.Location = New System.Drawing.Point(39, 56)
        Me.lblno_factura.Name = "lblno_factura"
        Me.lblno_factura.Size = New System.Drawing.Size(81, 20)
        Me.lblno_factura.TabIndex = 4
        Me.lblno_factura.Text = "no_factura:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCliente.Location = New System.Drawing.Point(126, 107)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(76, 27)
        Me.txtIdCliente.TabIndex = 12
        '
        'lblidcliente_venta
        '
        Me.lblidcliente_venta.AutoSize = True
        Me.lblidcliente_venta.Location = New System.Drawing.Point(49, 110)
        Me.lblidcliente_venta.Name = "lblidcliente_venta"
        Me.lblidcliente_venta.Size = New System.Drawing.Size(71, 20)
        Me.lblidcliente_venta.TabIndex = 11
        Me.lblidcliente_venta.Text = "IdCliente:"
        '
        'lblFecha_venta
        '
        Me.lblFecha_venta.AutoSize = True
        Me.lblFecha_venta.Location = New System.Drawing.Point(70, 167)
        Me.lblFecha_venta.Name = "lblFecha_venta"
        Me.lblFecha_venta.Size = New System.Drawing.Size(50, 20)
        Me.lblFecha_venta.TabIndex = 13
        Me.lblFecha_venta.Text = "Fecha:"
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Location = New System.Drawing.Point(1098, 377)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(129, 20)
        Me.linklblInexistente.TabIndex = 38
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'txtBusquedaClientes
        '
        Me.txtBusquedaClientes.Location = New System.Drawing.Point(1067, 67)
        Me.txtBusquedaClientes.Name = "txtBusquedaClientes"
        Me.txtBusquedaClientes.Size = New System.Drawing.Size(427, 27)
        Me.txtBusquedaClientes.TabIndex = 37
        '
        'cbCampoCliente
        '
        Me.cbCampoCliente.FormattingEnabled = True
        Me.cbCampoCliente.Items.AddRange(New Object() {"DUI", "primerapellido"})
        Me.cbCampoCliente.Location = New System.Drawing.Point(807, 65)
        Me.cbCampoCliente.Name = "cbCampoCliente"
        Me.cbCampoCliente.Size = New System.Drawing.Size(253, 28)
        Me.cbCampoCliente.TabIndex = 36
        Me.cbCampoCliente.Text = "DUI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(265, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 29)
        Me.Panel1.TabIndex = 35
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(807, 103)
        Me.cbeliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(85, 24)
        Me.cbeliminar.TabIndex = 39
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Panel1Clientes
        '
        Me.Panel1Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1Clientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1Clientes.Location = New System.Drawing.Point(0, 0)
        Me.Panel1Clientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(265, 827)
        Me.Panel1Clientes.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(286, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 36)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "REGISTRO DE CLIENTES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(645, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 827)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.GroupBxDatosVentas)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.txtBusquedaClientes)
        Me.Controls.Add(Me.cbCampoCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBxDatosVentas.ResumeLayout(False)
        Me.GroupBxDatosVentas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicBxEditarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ToolTipCliente As ToolTip
    Friend WithEvents GroupBxDatosVentas As GroupBox
    Friend WithEvents txtForma_pago As TextBox
    Friend WithEvents labelApellido2Cliente As Label
    Friend WithEvents txtno_factura As TextBox
    Friend WithEvents lblno_factura As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblidcliente_venta As Label
    Friend WithEvents lblFecha_venta As Label
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents txtBusquedaClientes As TextBox
    Friend WithEvents cbCampoCliente As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombre_cliente As TextBox
    Friend WithEvents btnBuscar_cliente As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BttAgregarVenta As Button
    Friend WithEvents BttGuardarVenta As Button
    Friend WithEvents BttEditarVenta As Button
    Friend WithEvents PicBxEditarClientes As PictureBox
    Friend WithEvents PicBxGuardarCliente As PictureBox
    Friend WithEvents PicBxAgregarCliente As PictureBox
    Friend WithEvents txtFecha_venta As DateTimePicker
End Class
