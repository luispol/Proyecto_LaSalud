<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMedicamentos))
        Me.DataGridViewMedicamentos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBoxAccionesdeRegistroMedicamentos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BttEliminarMedicamento = New System.Windows.Forms.Button()
        Me.BttAgregarMedicamentos = New System.Windows.Forms.Button()
        Me.BttGuardarMedicamento = New System.Windows.Forms.Button()
        Me.BttEditarMedicamentos = New System.Windows.Forms.Button()
        Me.PicBxEditarMedicamentos = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarMedicamento = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarMedicamento = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarMedicamentos = New System.Windows.Forms.PictureBox()
        Me.GroupBxDatosMedicametos = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblimagen = New System.Windows.Forms.Label()
        Me.Btn_CargarPic = New System.Windows.Forms.PictureBox()
        Me.Btn_limpiarPic = New System.Windows.Forms.PictureBox()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.datefecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.BttnSeleecionarCategoria = New System.Windows.Forms.Button()
        Me.txtNom_Categoria = New System.Windows.Forms.TextBox()
        Me.txtPrecioCompraMed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.txtNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.txtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.lblIdMedicamento = New System.Windows.Forms.Label()
        Me.lblnombreMed = New System.Windows.Forms.Label()
        Me.txtidCategoria_med = New System.Windows.Forms.TextBox()
        Me.labelCategoria = New System.Windows.Forms.Label()
        Me.txtDescripcionMed = New System.Windows.Forms.TextBox()
        Me.txtPrecioVentaMed = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBusquedaMedicamentos = New System.Windows.Forms.TextBox()
        Me.cbCampoMedicamento = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbeliminarmedicamento = New System.Windows.Forms.CheckBox()
        Me.ToolTipMedicamento = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialogMed = New System.Windows.Forms.OpenFileDialog()
        Me.lnkInexistente = New System.Windows.Forms.LinkLabel()
        Me.gbMantenimientoStock = New System.Windows.Forms.GroupBox()
        Me.chkAumentar_Disminuir = New System.Windows.Forms.CheckBox()
        Me.rbDisminuirStock = New System.Windows.Forms.RadioButton()
        Me.rbAumentarStock = New System.Windows.Forms.RadioButton()
        Me.txtStockOpc = New System.Windows.Forms.NumericUpDown()
        Me.lblStock = New System.Windows.Forms.Label()
        CType(Me.DataGridViewMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAccionesdeRegistroMedicamentos.SuspendLayout()
        CType(Me.PicBxEditarMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBxDatosMedicametos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Btn_CargarPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_limpiarPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMantenimientoStock.SuspendLayout()
        CType(Me.txtStockOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMedicamentos
        '
        Me.DataGridViewMedicamentos.AllowUserToAddRows = False
        Me.DataGridViewMedicamentos.AllowUserToDeleteRows = False
        Me.DataGridViewMedicamentos.AllowUserToResizeColumns = False
        Me.DataGridViewMedicamentos.AllowUserToResizeRows = False
        Me.DataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridViewMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewMedicamentos.Location = New System.Drawing.Point(690, 98)
        Me.DataGridViewMedicamentos.Name = "DataGridViewMedicamentos"
        Me.DataGridViewMedicamentos.ReadOnly = True
        Me.DataGridViewMedicamentos.RowHeadersWidth = 51
        Me.DataGridViewMedicamentos.RowTemplate.Height = 25
        Me.DataGridViewMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMedicamentos.Size = New System.Drawing.Size(627, 362)
        Me.DataGridViewMedicamentos.TabIndex = 34
        Me.ToolTipMedicamento.SetToolTip(Me.DataGridViewMedicamentos, "Para editar o eliminar, primero seleccione un registro")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'GroupBoxAccionesdeRegistroMedicamentos
        '
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.Button1)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.BttEliminarMedicamento)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.BttAgregarMedicamentos)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.BttGuardarMedicamento)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.BttEditarMedicamentos)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.PicBxEditarMedicamentos)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.PicBxEliminarMedicamento)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.PicBxGuardarMedicamento)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Controls.Add(Me.PicBxAgregarMedicamentos)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBoxAccionesdeRegistroMedicamentos.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxAccionesdeRegistroMedicamentos.Location = New System.Drawing.Point(690, 468)
        Me.GroupBoxAccionesdeRegistroMedicamentos.Name = "GroupBoxAccionesdeRegistroMedicamentos"
        Me.GroupBoxAccionesdeRegistroMedicamentos.Size = New System.Drawing.Size(427, 117)
        Me.GroupBoxAccionesdeRegistroMedicamentos.TabIndex = 32
        Me.GroupBoxAccionesdeRegistroMedicamentos.TabStop = False
        Me.GroupBoxAccionesdeRegistroMedicamentos.Text = "Acciones de Registro"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(335, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 38)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BttEliminarMedicamento
        '
        Me.BttEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEliminarMedicamento.Location = New System.Drawing.Point(218, 68)
        Me.BttEliminarMedicamento.Name = "BttEliminarMedicamento"
        Me.BttEliminarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttEliminarMedicamento.TabIndex = 26
        Me.BttEliminarMedicamento.Text = "Eliminar"
        Me.BttEliminarMedicamento.UseVisualStyleBackColor = True
        '
        'BttAgregarMedicamentos
        '
        Me.BttAgregarMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttAgregarMedicamentos.Location = New System.Drawing.Point(57, 68)
        Me.BttAgregarMedicamentos.Name = "BttAgregarMedicamentos"
        Me.BttAgregarMedicamentos.Size = New System.Drawing.Size(111, 38)
        Me.BttAgregarMedicamentos.TabIndex = 25
        Me.BttAgregarMedicamentos.Text = "Agregar"
        Me.BttAgregarMedicamentos.UseVisualStyleBackColor = True
        '
        'BttGuardarMedicamento
        '
        Me.BttGuardarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttGuardarMedicamento.Location = New System.Drawing.Point(218, 24)
        Me.BttGuardarMedicamento.Name = "BttGuardarMedicamento"
        Me.BttGuardarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttGuardarMedicamento.TabIndex = 24
        Me.BttGuardarMedicamento.Text = "Guardar"
        Me.BttGuardarMedicamento.UseVisualStyleBackColor = True
        '
        'BttEditarMedicamentos
        '
        Me.BttEditarMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEditarMedicamentos.Location = New System.Drawing.Point(57, 24)
        Me.BttEditarMedicamentos.Name = "BttEditarMedicamentos"
        Me.BttEditarMedicamentos.Size = New System.Drawing.Size(111, 38)
        Me.BttEditarMedicamentos.TabIndex = 23
        Me.BttEditarMedicamentos.Text = "Editar"
        Me.BttEditarMedicamentos.UseVisualStyleBackColor = True
        '
        'PicBxEditarMedicamentos
        '
        Me.PicBxEditarMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEditarMedicamentos.Image = CType(resources.GetObject("PicBxEditarMedicamentos.Image"), System.Drawing.Image)
        Me.PicBxEditarMedicamentos.Location = New System.Drawing.Point(13, 24)
        Me.PicBxEditarMedicamentos.Name = "PicBxEditarMedicamentos"
        Me.PicBxEditarMedicamentos.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEditarMedicamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarMedicamentos.TabIndex = 0
        Me.PicBxEditarMedicamentos.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.PicBxEditarMedicamentos, "Editar el registro de Cliente")
        '
        'PicBxEliminarMedicamento
        '
        Me.PicBxEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarMedicamento.Image = CType(resources.GetObject("PicBxEliminarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxEliminarMedicamento.Location = New System.Drawing.Point(174, 68)
        Me.PicBxEliminarMedicamento.Name = "PicBxEliminarMedicamento"
        Me.PicBxEliminarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEliminarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarMedicamento.TabIndex = 3
        Me.PicBxEliminarMedicamento.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.PicBxEliminarMedicamento, "Eliminar el registro del cliente")
        '
        'PicBxGuardarMedicamento
        '
        Me.PicBxGuardarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarMedicamento.Image = CType(resources.GetObject("PicBxGuardarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxGuardarMedicamento.Location = New System.Drawing.Point(174, 24)
        Me.PicBxGuardarMedicamento.Name = "PicBxGuardarMedicamento"
        Me.PicBxGuardarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxGuardarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarMedicamento.TabIndex = 1
        Me.PicBxGuardarMedicamento.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.PicBxGuardarMedicamento, "Guardar el registro del cliente")
        '
        'PicBxAgregarMedicamentos
        '
        Me.PicBxAgregarMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarMedicamentos.Image = CType(resources.GetObject("PicBxAgregarMedicamentos.Image"), System.Drawing.Image)
        Me.PicBxAgregarMedicamentos.Location = New System.Drawing.Point(13, 68)
        Me.PicBxAgregarMedicamentos.Name = "PicBxAgregarMedicamentos"
        Me.PicBxAgregarMedicamentos.Size = New System.Drawing.Size(38, 38)
        Me.PicBxAgregarMedicamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarMedicamentos.TabIndex = 2
        Me.PicBxAgregarMedicamentos.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.PicBxAgregarMedicamentos, "Agregar el registro del cliente")
        '
        'GroupBxDatosMedicametos
        '
        Me.GroupBxDatosMedicametos.Controls.Add(Me.Panel2)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.Btn_CargarPic)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.Btn_limpiarPic)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.Imagen)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.datefecha_vencimiento)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.BttnSeleecionarCategoria)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtNom_Categoria)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtPrecioCompraMed)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.Label1)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.LabelFecha)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtStock)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.labelStock)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtNombreMedicamento)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtIdMedicamento)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.lblIdMedicamento)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.lblnombreMed)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtidCategoria_med)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.labelCategoria)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtDescripcionMed)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.txtPrecioVentaMed)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.lblDescripcion)
        Me.GroupBxDatosMedicametos.Controls.Add(Me.lblPrecioVenta)
        Me.GroupBxDatosMedicametos.Location = New System.Drawing.Point(250, 153)
        Me.GroupBxDatosMedicametos.Name = "GroupBxDatosMedicametos"
        Me.GroupBxDatosMedicametos.Size = New System.Drawing.Size(427, 432)
        Me.GroupBxDatosMedicametos.TabIndex = 33
        Me.GroupBxDatosMedicametos.TabStop = False
        Me.GroupBxDatosMedicametos.Text = "Datos de  Medicamento"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblimagen)
        Me.Panel2.Location = New System.Drawing.Point(245, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 38)
        Me.Panel2.TabIndex = 29
        '
        'lblimagen
        '
        Me.lblimagen.AutoSize = True
        Me.lblimagen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblimagen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblimagen.Location = New System.Drawing.Point(8, 11)
        Me.lblimagen.Name = "lblimagen"
        Me.lblimagen.Size = New System.Drawing.Size(55, 15)
        Me.lblimagen.TabIndex = 9
        Me.lblimagen.Text = "Imagen :"
        '
        'Btn_CargarPic
        '
        Me.Btn_CargarPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CargarPic.Image = CType(resources.GetObject("Btn_CargarPic.Image"), System.Drawing.Image)
        Me.Btn_CargarPic.Location = New System.Drawing.Point(323, 243)
        Me.Btn_CargarPic.Name = "Btn_CargarPic"
        Me.Btn_CargarPic.Size = New System.Drawing.Size(38, 38)
        Me.Btn_CargarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_CargarPic.TabIndex = 28
        Me.Btn_CargarPic.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.Btn_CargarPic, "Editar el registro de Cliente")
        '
        'Btn_limpiarPic
        '
        Me.Btn_limpiarPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_limpiarPic.Image = CType(resources.GetObject("Btn_limpiarPic.Image"), System.Drawing.Image)
        Me.Btn_limpiarPic.Location = New System.Drawing.Point(367, 243)
        Me.Btn_limpiarPic.Name = "Btn_limpiarPic"
        Me.Btn_limpiarPic.Size = New System.Drawing.Size(38, 38)
        Me.Btn_limpiarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_limpiarPic.TabIndex = 27
        Me.Btn_limpiarPic.TabStop = False
        Me.ToolTipMedicamento.SetToolTip(Me.Btn_limpiarPic, "Editar el registro de Cliente")
        '
        'Imagen
        '
        Me.Imagen.BackgroundImage = CType(resources.GetObject("Imagen.BackgroundImage"), System.Drawing.Image)
        Me.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Imagen.Location = New System.Drawing.Point(245, 287)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(160, 134)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen.TabIndex = 25
        Me.Imagen.TabStop = False
        '
        'datefecha_vencimiento
        '
        Me.datefecha_vencimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.datefecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datefecha_vencimiento.Location = New System.Drawing.Point(133, 371)
        Me.datefecha_vencimiento.Name = "datefecha_vencimiento"
        Me.datefecha_vencimiento.Size = New System.Drawing.Size(93, 23)
        Me.datefecha_vencimiento.TabIndex = 24
        '
        'BttnSeleecionarCategoria
        '
        Me.BttnSeleecionarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttnSeleecionarCategoria.Location = New System.Drawing.Point(371, 122)
        Me.BttnSeleecionarCategoria.Name = "BttnSeleecionarCategoria"
        Me.BttnSeleecionarCategoria.Size = New System.Drawing.Size(34, 23)
        Me.BttnSeleecionarCategoria.TabIndex = 23
        Me.BttnSeleecionarCategoria.Text = "..."
        Me.BttnSeleecionarCategoria.UseVisualStyleBackColor = True
        '
        'txtNom_Categoria
        '
        Me.txtNom_Categoria.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNom_Categoria.Location = New System.Drawing.Point(198, 122)
        Me.txtNom_Categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNom_Categoria.MaxLength = 50
        Me.txtNom_Categoria.Name = "txtNom_Categoria"
        Me.txtNom_Categoria.Size = New System.Drawing.Size(167, 23)
        Me.txtNom_Categoria.TabIndex = 22
        '
        'txtPrecioCompraMed
        '
        Me.txtPrecioCompraMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecioCompraMed.Location = New System.Drawing.Point(133, 284)
        Me.txtPrecioCompraMed.MaxLength = 18
        Me.txtPrecioCompraMed.Name = "txtPrecioCompraMed"
        Me.txtPrecioCompraMed.Size = New System.Drawing.Size(93, 23)
        Me.txtPrecioCompraMed.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Precio Compra :"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(8, 377)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(116, 15)
        Me.LabelFecha.TabIndex = 17
        Me.LabelFecha.Text = "Fecha  Vencimiento :"
        '
        'txtStock
        '
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.Location = New System.Drawing.Point(133, 243)
        Me.txtStock.MaxLength = 18
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(93, 23)
        Me.txtStock.TabIndex = 16
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Location = New System.Drawing.Point(85, 246)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(42, 15)
        Me.labelStock.TabIndex = 15
        Me.labelStock.Text = "Stock :"
        '
        'txtNombreMedicamento
        '
        Me.txtNombreMedicamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreMedicamento.Location = New System.Drawing.Point(133, 78)
        Me.txtNombreMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreMedicamento.MaxLength = 50
        Me.txtNombreMedicamento.Name = "txtNombreMedicamento"
        Me.txtNombreMedicamento.Size = New System.Drawing.Size(272, 23)
        Me.txtNombreMedicamento.TabIndex = 2
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdMedicamento.Location = New System.Drawing.Point(133, 35)
        Me.txtIdMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.Size = New System.Drawing.Size(272, 23)
        Me.txtIdMedicamento.TabIndex = 1
        '
        'lblIdMedicamento
        '
        Me.lblIdMedicamento.AutoSize = True
        Me.lblIdMedicamento.Location = New System.Drawing.Point(30, 38)
        Me.lblIdMedicamento.Name = "lblIdMedicamento"
        Me.lblIdMedicamento.Size = New System.Drawing.Size(97, 15)
        Me.lblIdMedicamento.TabIndex = 4
        Me.lblIdMedicamento.Text = "Id Medicamento:"
        '
        'lblnombreMed
        '
        Me.lblnombreMed.AutoSize = True
        Me.lblnombreMed.Location = New System.Drawing.Point(70, 81)
        Me.lblnombreMed.Name = "lblnombreMed"
        Me.lblnombreMed.Size = New System.Drawing.Size(57, 15)
        Me.lblnombreMed.TabIndex = 5
        Me.lblnombreMed.Text = "Nombre :"
        '
        'txtidCategoria_med
        '
        Me.txtidCategoria_med.Cursor = System.Windows.Forms.Cursors.No
        Me.txtidCategoria_med.Enabled = False
        Me.txtidCategoria_med.Location = New System.Drawing.Point(133, 122)
        Me.txtidCategoria_med.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidCategoria_med.Name = "txtidCategoria_med"
        Me.txtidCategoria_med.Size = New System.Drawing.Size(59, 23)
        Me.txtidCategoria_med.TabIndex = 12
        '
        'labelCategoria
        '
        Me.labelCategoria.AutoSize = True
        Me.labelCategoria.Location = New System.Drawing.Point(63, 125)
        Me.labelCategoria.Name = "labelCategoria"
        Me.labelCategoria.Size = New System.Drawing.Size(64, 15)
        Me.labelCategoria.TabIndex = 11
        Me.labelCategoria.Text = "Categoría :"
        '
        'txtDescripcionMed
        '
        Me.txtDescripcionMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcionMed.Location = New System.Drawing.Point(133, 162)
        Me.txtDescripcionMed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionMed.MaxLength = 50
        Me.txtDescripcionMed.Multiline = True
        Me.txtDescripcionMed.Name = "txtDescripcionMed"
        Me.txtDescripcionMed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionMed.Size = New System.Drawing.Size(272, 66)
        Me.txtDescripcionMed.TabIndex = 14
        '
        'txtPrecioVentaMed
        '
        Me.txtPrecioVentaMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecioVentaMed.Location = New System.Drawing.Point(133, 327)
        Me.txtPrecioVentaMed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioVentaMed.MaxLength = 18
        Me.txtPrecioVentaMed.Name = "txtPrecioVentaMed"
        Me.txtPrecioVentaMed.Size = New System.Drawing.Size(93, 23)
        Me.txtPrecioVentaMed.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(52, 165)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(75, 15)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.Text = "Descripción :"
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.Location = New System.Drawing.Point(49, 330)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(78, 15)
        Me.lblPrecioVenta.TabIndex = 7
        Me.lblPrecioVenta.Text = "Precio Venta :"
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Location = New System.Drawing.Point(943, 281)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(102, 15)
        Me.linklblInexistente.TabIndex = 38
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'txtBusquedaMedicamentos
        '
        Me.txtBusquedaMedicamentos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusquedaMedicamentos.Location = New System.Drawing.Point(918, 47)
        Me.txtBusquedaMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBusquedaMedicamentos.MaxLength = 50
        Me.txtBusquedaMedicamentos.Name = "txtBusquedaMedicamentos"
        Me.txtBusquedaMedicamentos.Size = New System.Drawing.Size(399, 23)
        Me.txtBusquedaMedicamentos.TabIndex = 37
        '
        'cbCampoMedicamento
        '
        Me.cbCampoMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCampoMedicamento.FormattingEnabled = True
        Me.cbCampoMedicamento.Items.AddRange(New Object() {"nombre", "nombre_categoria"})
        Me.cbCampoMedicamento.Location = New System.Drawing.Point(690, 47)
        Me.cbCampoMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCampoMedicamento.Name = "cbCampoMedicamento"
        Me.cbCampoMedicamento.Size = New System.Drawing.Size(222, 23)
        Me.cbCampoMedicamento.TabIndex = 36
        Me.cbCampoMedicamento.Text = "nombre"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(232, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 22)
        Me.Panel1.TabIndex = 35
        '
        'cbeliminarmedicamento
        '
        Me.cbeliminarmedicamento.AutoSize = True
        Me.cbeliminarmedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbeliminarmedicamento.Location = New System.Drawing.Point(690, 75)
        Me.cbeliminarmedicamento.Name = "cbeliminarmedicamento"
        Me.cbeliminarmedicamento.Size = New System.Drawing.Size(69, 19)
        Me.cbeliminarmedicamento.TabIndex = 39
        Me.cbeliminarmedicamento.Text = "Eliminar"
        Me.cbeliminarmedicamento.UseVisualStyleBackColor = True
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
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(232, 628)
        Me.Panel1Clientes.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(285, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 58)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "REGISTRO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      MEDICAMENTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(564, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialogMed
        '
        Me.OpenFileDialogMed.FileName = "OpenFileDialog1"
        '
        'lnkInexistente
        '
        Me.lnkInexistente.AutoSize = True
        Me.lnkInexistente.Location = New System.Drawing.Point(956, 305)
        Me.lnkInexistente.Name = "lnkInexistente"
        Me.lnkInexistente.Size = New System.Drawing.Size(0, 15)
        Me.lnkInexistente.TabIndex = 40
        '
        'gbMantenimientoStock
        '
        Me.gbMantenimientoStock.Controls.Add(Me.chkAumentar_Disminuir)
        Me.gbMantenimientoStock.Controls.Add(Me.rbDisminuirStock)
        Me.gbMantenimientoStock.Controls.Add(Me.rbAumentarStock)
        Me.gbMantenimientoStock.Controls.Add(Me.txtStockOpc)
        Me.gbMantenimientoStock.Controls.Add(Me.lblStock)
        Me.gbMantenimientoStock.Location = New System.Drawing.Point(1123, 468)
        Me.gbMantenimientoStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbMantenimientoStock.Name = "gbMantenimientoStock"
        Me.gbMantenimientoStock.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbMantenimientoStock.Size = New System.Drawing.Size(194, 117)
        Me.gbMantenimientoStock.TabIndex = 41
        Me.gbMantenimientoStock.TabStop = False
        Me.gbMantenimientoStock.Text = "Mantenimiento de stock"
        '
        'chkAumentar_Disminuir
        '
        Me.chkAumentar_Disminuir.AutoSize = True
        Me.chkAumentar_Disminuir.Location = New System.Drawing.Point(19, 24)
        Me.chkAumentar_Disminuir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAumentar_Disminuir.Name = "chkAumentar_Disminuir"
        Me.chkAumentar_Disminuir.Size = New System.Drawing.Size(141, 19)
        Me.chkAumentar_Disminuir.TabIndex = 49
        Me.chkAumentar_Disminuir.Text = "Aumentar / Disminuir"
        Me.chkAumentar_Disminuir.UseVisualStyleBackColor = True
        '
        'rbDisminuirStock
        '
        Me.rbDisminuirStock.AutoSize = True
        Me.rbDisminuirStock.Location = New System.Drawing.Point(105, 82)
        Me.rbDisminuirStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbDisminuirStock.Name = "rbDisminuirStock"
        Me.rbDisminuirStock.Size = New System.Drawing.Size(76, 19)
        Me.rbDisminuirStock.TabIndex = 48
        Me.rbDisminuirStock.TabStop = True
        Me.rbDisminuirStock.Text = "Disminuir"
        Me.rbDisminuirStock.UseVisualStyleBackColor = True
        '
        'rbAumentarStock
        '
        Me.rbAumentarStock.AutoSize = True
        Me.rbAumentarStock.Location = New System.Drawing.Point(105, 60)
        Me.rbAumentarStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAumentarStock.Name = "rbAumentarStock"
        Me.rbAumentarStock.Size = New System.Drawing.Size(78, 19)
        Me.rbAumentarStock.TabIndex = 47
        Me.rbAumentarStock.TabStop = True
        Me.rbAumentarStock.Text = "Aumentar"
        Me.rbAumentarStock.UseVisualStyleBackColor = True
        '
        'txtStockOpc
        '
        Me.txtStockOpc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtStockOpc.Location = New System.Drawing.Point(19, 78)
        Me.txtStockOpc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockOpc.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtStockOpc.Name = "txtStockOpc"
        Me.txtStockOpc.Size = New System.Drawing.Size(74, 23)
        Me.txtStockOpc.TabIndex = 46
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(19, 56)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(42, 15)
        Me.lblStock.TabIndex = 0
        Me.lblStock.Text = "Stock: "
        '
        'FormMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 628)
        Me.Controls.Add(Me.gbMantenimientoStock)
        Me.Controls.Add(Me.lnkInexistente)
        Me.Controls.Add(Me.DataGridViewMedicamentos)
        Me.Controls.Add(Me.GroupBoxAccionesdeRegistroMedicamentos)
        Me.Controls.Add(Me.GroupBxDatosMedicametos)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.txtBusquedaMedicamentos)
        Me.Controls.Add(Me.cbCampoMedicamento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbeliminarmedicamento)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMedicamentos"
        Me.Text = "Medicamentos"
        CType(Me.DataGridViewMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAccionesdeRegistroMedicamentos.ResumeLayout(False)
        CType(Me.PicBxEditarMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBxDatosMedicametos.ResumeLayout(False)
        Me.GroupBxDatosMedicametos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Btn_CargarPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_limpiarPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMantenimientoStock.ResumeLayout(False)
        Me.gbMantenimientoStock.PerformLayout()
        CType(Me.txtStockOpc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMedicamentos As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ToolTipMedicamento As ToolTip
    Friend WithEvents GroupBoxAccionesdeRegistroMedicamentos As GroupBox
    Friend WithEvents BttEliminarMedicamento As Button
    Friend WithEvents BttAgregarMedicamentos As Button
    Friend WithEvents BttGuardarMedicamento As Button
    Friend WithEvents BttEditarMedicamentos As Button
    Friend WithEvents PicBxEditarMedicamentos As PictureBox
    Friend WithEvents PicBxEliminarMedicamento As PictureBox
    Friend WithEvents PicBxGuardarMedicamento As PictureBox
    Friend WithEvents PicBxAgregarMedicamentos As PictureBox
    Friend WithEvents GroupBxDatosMedicametos As GroupBox
    Friend WithEvents txtPrecioCompraMed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents labelStock As Label
    Friend WithEvents txtNombreMedicamento As TextBox
    Friend WithEvents txtIdMedicamento As TextBox
    Friend WithEvents lblIdMedicamento As Label
    Friend WithEvents lblnombreMed As Label
    Friend WithEvents labelCategoria As Label
    Friend WithEvents lblimagen As Label
    Friend WithEvents txtDescripcionMed As TextBox
    Friend WithEvents txtPrecioVentaMed As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents txtBusquedaMedicamentos As TextBox
    Friend WithEvents cbCampoMedicamento As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbeliminarmedicamento As CheckBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BttnSeleecionarCategoria As Button
    Friend WithEvents datefecha_vencimiento As DateTimePicker
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_CargarPic As PictureBox
    Friend WithEvents Btn_limpiarPic As PictureBox
    Friend WithEvents OpenFileDialogMed As OpenFileDialog
    Friend WithEvents lnkInexistente As LinkLabel
    Public WithEvents txtidCategoria_med As TextBox
    Public WithEvents txtNom_Categoria As TextBox
    Friend WithEvents gbMantenimientoStock As GroupBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtStockOpc As NumericUpDown
    Friend WithEvents rbDisminuirStock As RadioButton
    Friend WithEvents rbAumentarStock As RadioButton
    Friend WithEvents chkAumentar_Disminuir As CheckBox
    Friend WithEvents Button1 As Button
End Class
