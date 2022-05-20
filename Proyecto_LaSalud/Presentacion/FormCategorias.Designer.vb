<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCategorias))
        Me.DataGridViewCategoria = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBoxAccionesDeRegsitroCategoria = New System.Windows.Forms.GroupBox()
        Me.BttEliminarCategoria = New System.Windows.Forms.Button()
        Me.BttAgregarCategoria = New System.Windows.Forms.Button()
        Me.BttGuardarCategoria = New System.Windows.Forms.Button()
        Me.BttEditarCategoria = New System.Windows.Forms.Button()
        Me.PicBxEditarCategoria = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarCategoria = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarCategoria = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarCategoria = New System.Windows.Forms.PictureBox()
        Me.GroupBxDatosCategoria = New System.Windows.Forms.GroupBox()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.lblIdCategoria = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.lblNombreCategoria = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.linklblInexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBusquedaCategoria = New System.Windows.Forms.TextBox()
        Me.cbCampoCategoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.ToolTipCategoria = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1Clientes = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAccionesDeRegsitroCategoria.SuspendLayout()
        CType(Me.PicBxEditarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBxDatosCategoria.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCategoria
        '
        Me.DataGridViewCategoria.AllowUserToAddRows = False
        Me.DataGridViewCategoria.AllowUserToDeleteRows = False
        Me.DataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridViewCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewCategoria.Location = New System.Drawing.Point(706, 100)
        Me.DataGridViewCategoria.Name = "DataGridViewCategoria"
        Me.DataGridViewCategoria.ReadOnly = True
        Me.DataGridViewCategoria.RowHeadersWidth = 51
        Me.DataGridViewCategoria.RowTemplate.Height = 25
        Me.DataGridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCategoria.Size = New System.Drawing.Size(602, 362)
        Me.DataGridViewCategoria.TabIndex = 34
        Me.ToolTipCategoria.SetToolTip(Me.DataGridViewCategoria, "Para editar o eliminar, primero seleccione un registro")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'GroupBoxAccionesDeRegsitroCategoria
        '
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.BttEliminarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.BttAgregarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.BttGuardarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.BttEditarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.PicBxEditarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.PicBxEliminarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.PicBxGuardarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.Controls.Add(Me.PicBxAgregarCategoria)
        Me.GroupBoxAccionesDeRegsitroCategoria.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxAccionesDeRegsitroCategoria.Location = New System.Drawing.Point(250, 317)
        Me.GroupBoxAccionesDeRegsitroCategoria.Name = "GroupBoxAccionesDeRegsitroCategoria"
        Me.GroupBoxAccionesDeRegsitroCategoria.Size = New System.Drawing.Size(427, 126)
        Me.GroupBoxAccionesDeRegsitroCategoria.TabIndex = 32
        Me.GroupBoxAccionesDeRegsitroCategoria.TabStop = False
        Me.GroupBoxAccionesDeRegsitroCategoria.Text = "Acciones de Registro"
        '
        'BttEliminarCategoria
        '
        Me.BttEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEliminarCategoria.Location = New System.Drawing.Point(232, 68)
        Me.BttEliminarCategoria.Name = "BttEliminarCategoria"
        Me.BttEliminarCategoria.Size = New System.Drawing.Size(111, 38)
        Me.BttEliminarCategoria.TabIndex = 26
        Me.BttEliminarCategoria.Text = "Eliminar"
        Me.BttEliminarCategoria.UseVisualStyleBackColor = True
        '
        'BttAgregarCategoria
        '
        Me.BttAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttAgregarCategoria.Location = New System.Drawing.Point(61, 68)
        Me.BttAgregarCategoria.Name = "BttAgregarCategoria"
        Me.BttAgregarCategoria.Size = New System.Drawing.Size(111, 38)
        Me.BttAgregarCategoria.TabIndex = 25
        Me.BttAgregarCategoria.Text = "Agregar"
        Me.BttAgregarCategoria.UseVisualStyleBackColor = True
        '
        'BttGuardarCategoria
        '
        Me.BttGuardarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttGuardarCategoria.Location = New System.Drawing.Point(232, 24)
        Me.BttGuardarCategoria.Name = "BttGuardarCategoria"
        Me.BttGuardarCategoria.Size = New System.Drawing.Size(111, 38)
        Me.BttGuardarCategoria.TabIndex = 24
        Me.BttGuardarCategoria.Text = "Guardar"
        Me.BttGuardarCategoria.UseVisualStyleBackColor = True
        '
        'BttEditarCategoria
        '
        Me.BttEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttEditarCategoria.Location = New System.Drawing.Point(61, 24)
        Me.BttEditarCategoria.Name = "BttEditarCategoria"
        Me.BttEditarCategoria.Size = New System.Drawing.Size(111, 38)
        Me.BttEditarCategoria.TabIndex = 23
        Me.BttEditarCategoria.Text = "Editar"
        Me.BttEditarCategoria.UseVisualStyleBackColor = True
        '
        'PicBxEditarCategoria
        '
        Me.PicBxEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEditarCategoria.Image = CType(resources.GetObject("PicBxEditarCategoria.Image"), System.Drawing.Image)
        Me.PicBxEditarCategoria.Location = New System.Drawing.Point(17, 24)
        Me.PicBxEditarCategoria.Name = "PicBxEditarCategoria"
        Me.PicBxEditarCategoria.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEditarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarCategoria.TabIndex = 0
        Me.PicBxEditarCategoria.TabStop = False
        Me.ToolTipCategoria.SetToolTip(Me.PicBxEditarCategoria, "Editar el registro de la categoría")
        '
        'PicBxEliminarCategoria
        '
        Me.PicBxEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarCategoria.Image = CType(resources.GetObject("PicBxEliminarCategoria.Image"), System.Drawing.Image)
        Me.PicBxEliminarCategoria.Location = New System.Drawing.Point(188, 68)
        Me.PicBxEliminarCategoria.Name = "PicBxEliminarCategoria"
        Me.PicBxEliminarCategoria.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEliminarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarCategoria.TabIndex = 3
        Me.PicBxEliminarCategoria.TabStop = False
        Me.ToolTipCategoria.SetToolTip(Me.PicBxEliminarCategoria, "Eliminar el registro de la categoría")
        '
        'PicBxGuardarCategoria
        '
        Me.PicBxGuardarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarCategoria.Image = CType(resources.GetObject("PicBxGuardarCategoria.Image"), System.Drawing.Image)
        Me.PicBxGuardarCategoria.Location = New System.Drawing.Point(188, 24)
        Me.PicBxGuardarCategoria.Name = "PicBxGuardarCategoria"
        Me.PicBxGuardarCategoria.Size = New System.Drawing.Size(38, 38)
        Me.PicBxGuardarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarCategoria.TabIndex = 1
        Me.PicBxGuardarCategoria.TabStop = False
        Me.ToolTipCategoria.SetToolTip(Me.PicBxGuardarCategoria, "Guardar el registro de la categoría")
        '
        'PicBxAgregarCategoria
        '
        Me.PicBxAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarCategoria.Image = CType(resources.GetObject("PicBxAgregarCategoria.Image"), System.Drawing.Image)
        Me.PicBxAgregarCategoria.Location = New System.Drawing.Point(17, 68)
        Me.PicBxAgregarCategoria.Name = "PicBxAgregarCategoria"
        Me.PicBxAgregarCategoria.Size = New System.Drawing.Size(38, 38)
        Me.PicBxAgregarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarCategoria.TabIndex = 2
        Me.PicBxAgregarCategoria.TabStop = False
        Me.ToolTipCategoria.SetToolTip(Me.PicBxAgregarCategoria, "Agregar el registro de la categoría")
        '
        'GroupBxDatosCategoria
        '
        Me.GroupBxDatosCategoria.Controls.Add(Me.txtIdCategoria)
        Me.GroupBxDatosCategoria.Controls.Add(Me.lblIdCategoria)
        Me.GroupBxDatosCategoria.Controls.Add(Me.txtNombreCategoria)
        Me.GroupBxDatosCategoria.Controls.Add(Me.lblNombreCategoria)
        Me.GroupBxDatosCategoria.Location = New System.Drawing.Point(250, 156)
        Me.GroupBxDatosCategoria.Name = "GroupBxDatosCategoria"
        Me.GroupBxDatosCategoria.Size = New System.Drawing.Size(427, 142)
        Me.GroupBxDatosCategoria.TabIndex = 33
        Me.GroupBxDatosCategoria.TabStop = False
        Me.GroupBxDatosCategoria.Text = "Categorias"
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdCategoria.Location = New System.Drawing.Point(131, 41)
        Me.txtIdCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(276, 23)
        Me.txtIdCategoria.TabIndex = 1
        '
        'lblIdCategoria
        '
        Me.lblIdCategoria.AutoSize = True
        Me.lblIdCategoria.Location = New System.Drawing.Point(49, 41)
        Me.lblIdCategoria.Name = "lblIdCategoria"
        Me.lblIdCategoria.Size = New System.Drawing.Size(77, 15)
        Me.lblIdCategoria.TabIndex = 4
        Me.lblIdCategoria.Text = "Id Categoria :"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreCategoria.Location = New System.Drawing.Point(131, 82)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(276, 23)
        Me.txtNombreCategoria.TabIndex = 12
        '
        'lblNombreCategoria
        '
        Me.lblNombreCategoria.AutoSize = True
        Me.lblNombreCategoria.Location = New System.Drawing.Point(15, 82)
        Me.lblNombreCategoria.Name = "lblNombreCategoria"
        Me.lblNombreCategoria.Size = New System.Drawing.Size(111, 15)
        Me.lblNombreCategoria.TabIndex = 11
        Me.lblNombreCategoria.Text = "Nombre Categoría :"
        '
        'txtflag
        '
        Me.txtflag.Enabled = False
        Me.txtflag.Location = New System.Drawing.Point(1284, 468)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(24, 23)
        Me.txtflag.TabIndex = 13
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Location = New System.Drawing.Point(961, 283)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(102, 15)
        Me.linklblInexistente.TabIndex = 38
        Me.linklblInexistente.TabStop = True
        Me.linklblInexistente.Text = "Datos inexistentes"
        '
        'txtBusquedaCategoria
        '
        Me.txtBusquedaCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusquedaCategoria.Location = New System.Drawing.Point(934, 50)
        Me.txtBusquedaCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBusquedaCategoria.Name = "txtBusquedaCategoria"
        Me.txtBusquedaCategoria.Size = New System.Drawing.Size(374, 23)
        Me.txtBusquedaCategoria.TabIndex = 37
        '
        'cbCampoCategoria
        '
        Me.cbCampoCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCampoCategoria.FormattingEnabled = True
        Me.cbCampoCategoria.Items.AddRange(New Object() {"nombre_categoria"})
        Me.cbCampoCategoria.Location = New System.Drawing.Point(706, 49)
        Me.cbCampoCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCampoCategoria.Name = "cbCampoCategoria"
        Me.cbCampoCategoria.Size = New System.Drawing.Size(222, 23)
        Me.cbCampoCategoria.TabIndex = 36
        Me.cbCampoCategoria.Text = "nombre_categoria"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(232, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 22)
        Me.Panel1.TabIndex = 35
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbeliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbeliminar.Location = New System.Drawing.Point(706, 77)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(67, 19)
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
        Me.Panel1Clientes.Name = "Panel1Clientes"
        Me.Panel1Clientes.Size = New System.Drawing.Size(232, 621)
        Me.Panel1Clientes.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(273, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 58)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "    REGISTRO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         CATEGORIAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(564, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'FormCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 621)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.DataGridViewCategoria)
        Me.Controls.Add(Me.GroupBoxAccionesDeRegsitroCategoria)
        Me.Controls.Add(Me.GroupBxDatosCategoria)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.txtBusquedaCategoria)
        Me.Controls.Add(Me.cbCampoCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.Panel1Clientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCategorias"
        Me.Text = "FormCategorias"
        CType(Me.DataGridViewCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAccionesDeRegsitroCategoria.ResumeLayout(False)
        CType(Me.PicBxEditarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBxDatosCategoria.ResumeLayout(False)
        Me.GroupBxDatosCategoria.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCategoria As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ToolTipCategoria As ToolTip
    Friend WithEvents GroupBoxAccionesDeRegsitroCategoria As GroupBox
    Friend WithEvents BttEliminarCategoria As Button
    Friend WithEvents BttAgregarCategoria As Button
    Friend WithEvents BttGuardarCategoria As Button
    Friend WithEvents BttEditarCategoria As Button
    Friend WithEvents PicBxEditarCategoria As PictureBox
    Friend WithEvents PicBxEliminarCategoria As PictureBox
    Friend WithEvents PicBxGuardarCategoria As PictureBox
    Friend WithEvents PicBxAgregarCategoria As PictureBox
    Friend WithEvents GroupBxDatosCategoria As GroupBox
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents lblIdCategoria As Label
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents lblNombreCategoria As Label
    Friend WithEvents linklblInexistente As LinkLabel
    Friend WithEvents txtBusquedaCategoria As TextBox
    Friend WithEvents cbCampoCategoria As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Panel1Clientes As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtflag As TextBox
End Class
