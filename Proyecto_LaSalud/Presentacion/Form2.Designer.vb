<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMedicamentos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBxDatosMedicamentos = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblNombreMedicamento = New System.Windows.Forms.Label()
        Me.txtBxPrecioMedicamento = New System.Windows.Forms.TextBox()
        Me.LblPrecioMedicamento = New System.Windows.Forms.Label()
        Me.txtDescripcionMedic = New System.Windows.Forms.TextBox()
        Me.LabelDescripMedicamento = New System.Windows.Forms.Label()
        Me.txtApellido2Cliente = New System.Windows.Forms.TextBox()
        Me.labelCategoriaMedicamento = New System.Windows.Forms.Label()
        Me.txtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.lablMedicamento = New System.Windows.Forms.Label()
        Me.txtNombreClientes = New System.Windows.Forms.TextBox()
        Me.lblIdCategoria = New System.Windows.Forms.Label()
        Me.txtStockMedicamentos = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewMedicamentos = New System.Windows.Forms.DataGridView()
        Me.GroupBoxMedicamentos = New System.Windows.Forms.GroupBox()
        Me.BttEliminarMedicamento = New System.Windows.Forms.Button()
        Me.BttAgregarMedicamento = New System.Windows.Forms.Button()
        Me.BttGuardarMedicamento = New System.Windows.Forms.Button()
        Me.BttEditarMedicamento = New System.Windows.Forms.Button()
        Me.PicBxEditarMedicamento = New System.Windows.Forms.PictureBox()
        Me.PicBxEliminarMedicamento = New System.Windows.Forms.PictureBox()
        Me.PicBxGuardarMedicamento = New System.Windows.Forms.PictureBox()
        Me.PicBxAgregarMedicamento = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTipMedicamentos = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBxDatosMedicamentos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMedicamentos.SuspendLayout()
        CType(Me.PicBxEditarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxEliminarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxGuardarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBxAgregarMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 619)
        Me.Panel1.TabIndex = 11
        '
        'GroupBxDatosMedicamentos
        '
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.TextBox1)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.LblNombreMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtBxPrecioMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.LblPrecioMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtDescripcionMedic)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.LabelDescripMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtApellido2Cliente)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.labelCategoriaMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtIdMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.lablMedicamento)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtNombreClientes)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.lblIdCategoria)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.txtStockMedicamentos)
        Me.GroupBxDatosMedicamentos.Controls.Add(Me.lblStock)
        Me.GroupBxDatosMedicamentos.Location = New System.Drawing.Point(257, 136)
        Me.GroupBxDatosMedicamentos.Name = "GroupBxDatosMedicamentos"
        Me.GroupBxDatosMedicamentos.Size = New System.Drawing.Size(427, 440)
        Me.GroupBxDatosMedicamentos.TabIndex = 22
        Me.GroupBxDatosMedicamentos.TabStop = False
        Me.GroupBxDatosMedicamentos.Text = "Datos de Medicamentos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 23)
        Me.TextBox1.TabIndex = 25
        '
        'LblNombreMedicamento
        '
        Me.LblNombreMedicamento.AutoSize = True
        Me.LblNombreMedicamento.Location = New System.Drawing.Point(66, 89)
        Me.LblNombreMedicamento.Name = "LblNombreMedicamento"
        Me.LblNombreMedicamento.Size = New System.Drawing.Size(57, 15)
        Me.LblNombreMedicamento.TabIndex = 24
        Me.LblNombreMedicamento.Text = "Nombre :"
        '
        'txtBxPrecioMedicamento
        '
        Me.txtBxPrecioMedicamento.Enabled = False
        Me.txtBxPrecioMedicamento.Location = New System.Drawing.Point(304, 271)
        Me.txtBxPrecioMedicamento.Name = "txtBxPrecioMedicamento"
        Me.txtBxPrecioMedicamento.Size = New System.Drawing.Size(104, 23)
        Me.txtBxPrecioMedicamento.TabIndex = 23
        '
        'LblPrecioMedicamento
        '
        Me.LblPrecioMedicamento.AutoSize = True
        Me.LblPrecioMedicamento.Location = New System.Drawing.Point(252, 274)
        Me.LblPrecioMedicamento.Name = "LblPrecioMedicamento"
        Me.LblPrecioMedicamento.Size = New System.Drawing.Size(46, 15)
        Me.LblPrecioMedicamento.TabIndex = 22
        Me.LblPrecioMedicamento.Text = "Precio :"
        '
        'txtDescripcionMedic
        '
        Me.txtDescripcionMedic.Location = New System.Drawing.Point(129, 176)
        Me.txtDescripcionMedic.Multiline = True
        Me.txtDescripcionMedic.Name = "txtDescripcionMedic"
        Me.txtDescripcionMedic.Size = New System.Drawing.Size(279, 76)
        Me.txtDescripcionMedic.TabIndex = 19
        '
        'LabelDescripMedicamento
        '
        Me.LabelDescripMedicamento.AutoSize = True
        Me.LabelDescripMedicamento.Location = New System.Drawing.Point(48, 176)
        Me.LabelDescripMedicamento.Name = "LabelDescripMedicamento"
        Me.LabelDescripMedicamento.Size = New System.Drawing.Size(75, 15)
        Me.LabelDescripMedicamento.TabIndex = 17
        Me.LabelDescripMedicamento.Text = "Descripción :"
        '
        'txtApellido2Cliente
        '
        Me.txtApellido2Cliente.Location = New System.Drawing.Point(129, 130)
        Me.txtApellido2Cliente.Name = "txtApellido2Cliente"
        Me.txtApellido2Cliente.Size = New System.Drawing.Size(279, 23)
        Me.txtApellido2Cliente.TabIndex = 16
        '
        'labelCategoriaMedicamento
        '
        Me.labelCategoriaMedicamento.AutoSize = True
        Me.labelCategoriaMedicamento.Location = New System.Drawing.Point(59, 130)
        Me.labelCategoriaMedicamento.Name = "labelCategoriaMedicamento"
        Me.labelCategoriaMedicamento.Size = New System.Drawing.Size(64, 15)
        Me.labelCategoriaMedicamento.TabIndex = 15
        Me.labelCategoriaMedicamento.Text = "Categoría :"
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdMedicamento.Location = New System.Drawing.Point(129, 41)
        Me.txtIdMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.Size = New System.Drawing.Size(86, 23)
        Me.txtIdMedicamento.TabIndex = 1
        '
        'lablMedicamento
        '
        Me.lablMedicamento.AutoSize = True
        Me.lablMedicamento.Location = New System.Drawing.Point(23, 41)
        Me.lablMedicamento.Name = "lablMedicamento"
        Me.lablMedicamento.Size = New System.Drawing.Size(100, 15)
        Me.lablMedicamento.TabIndex = 4
        Me.lablMedicamento.Text = "Id Medicamento :"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreClientes.Location = New System.Drawing.Point(304, 41)
        Me.txtNombreClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(104, 23)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblIdCategoria
        '
        Me.lblIdCategoria.AutoSize = True
        Me.lblIdCategoria.Location = New System.Drawing.Point(221, 44)
        Me.lblIdCategoria.Name = "lblIdCategoria"
        Me.lblIdCategoria.Size = New System.Drawing.Size(77, 15)
        Me.lblIdCategoria.TabIndex = 11
        Me.lblIdCategoria.Text = "Id Categoría :"
        '
        'txtStockMedicamentos
        '
        Me.txtStockMedicamentos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockMedicamentos.Location = New System.Drawing.Point(129, 271)
        Me.txtStockMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockMedicamentos.Name = "txtStockMedicamentos"
        Me.txtStockMedicamentos.Size = New System.Drawing.Size(117, 23)
        Me.txtStockMedicamentos.TabIndex = 14
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(81, 274)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(42, 15)
        Me.lblStock.TabIndex = 13
        Me.lblStock.Text = "Stock :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(571, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(309, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 58)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "REGISTRO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      MEDICAMENTOS"
        '
        'DataGridViewMedicamentos
        '
        Me.DataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicamentos.Location = New System.Drawing.Point(706, 38)
        Me.DataGridViewMedicamentos.Name = "DataGridViewMedicamentos"
        Me.DataGridViewMedicamentos.RowTemplate.Height = 25
        Me.DataGridViewMedicamentos.Size = New System.Drawing.Size(602, 415)
        Me.DataGridViewMedicamentos.TabIndex = 25
        '
        'GroupBoxMedicamentos
        '
        Me.GroupBoxMedicamentos.Controls.Add(Me.BttEliminarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.BttAgregarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.BttGuardarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.BttEditarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.PicBxEditarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.PicBxEliminarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.PicBxGuardarMedicamento)
        Me.GroupBoxMedicamentos.Controls.Add(Me.PicBxAgregarMedicamento)
        Me.GroupBoxMedicamentos.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxMedicamentos.Location = New System.Drawing.Point(706, 459)
        Me.GroupBoxMedicamentos.Name = "GroupBoxMedicamentos"
        Me.GroupBoxMedicamentos.Size = New System.Drawing.Size(602, 117)
        Me.GroupBoxMedicamentos.TabIndex = 26
        Me.GroupBoxMedicamentos.TabStop = False
        Me.GroupBoxMedicamentos.Text = "Acciones de Registro"
        '
        'BttEliminarMedicamento
        '
        Me.BttEliminarMedicamento.Location = New System.Drawing.Point(228, 68)
        Me.BttEliminarMedicamento.Name = "BttEliminarMedicamento"
        Me.BttEliminarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttEliminarMedicamento.TabIndex = 26
        Me.BttEliminarMedicamento.Text = "Eliminar"
        Me.BttEliminarMedicamento.UseVisualStyleBackColor = True
        '
        'BttAgregarMedicamento
        '
        Me.BttAgregarMedicamento.Location = New System.Drawing.Point(57, 68)
        Me.BttAgregarMedicamento.Name = "BttAgregarMedicamento"
        Me.BttAgregarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttAgregarMedicamento.TabIndex = 25
        Me.BttAgregarMedicamento.Text = "Agregar"
        Me.BttAgregarMedicamento.UseVisualStyleBackColor = True
        '
        'BttGuardarMedicamento
        '
        Me.BttGuardarMedicamento.Location = New System.Drawing.Point(228, 24)
        Me.BttGuardarMedicamento.Name = "BttGuardarMedicamento"
        Me.BttGuardarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttGuardarMedicamento.TabIndex = 24
        Me.BttGuardarMedicamento.Text = "Guardar"
        Me.BttGuardarMedicamento.UseVisualStyleBackColor = True
        '
        'BttEditarMedicamento
        '
        Me.BttEditarMedicamento.Location = New System.Drawing.Point(57, 24)
        Me.BttEditarMedicamento.Name = "BttEditarMedicamento"
        Me.BttEditarMedicamento.Size = New System.Drawing.Size(111, 38)
        Me.BttEditarMedicamento.TabIndex = 23
        Me.BttEditarMedicamento.Text = "Editar"
        Me.BttEditarMedicamento.UseVisualStyleBackColor = True
        '
        'PicBxEditarMedicamento
        '
        Me.PicBxEditarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEditarMedicamento.Image = CType(resources.GetObject("PicBxEditarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxEditarMedicamento.Location = New System.Drawing.Point(13, 24)
        Me.PicBxEditarMedicamento.Name = "PicBxEditarMedicamento"
        Me.PicBxEditarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEditarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEditarMedicamento.TabIndex = 0
        Me.PicBxEditarMedicamento.TabStop = False
        Me.ToolTipMedicamentos.SetToolTip(Me.PicBxEditarMedicamento, "Editar el registro del Medicamento")
        '
        'PicBxEliminarMedicamento
        '
        Me.PicBxEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxEliminarMedicamento.Image = CType(resources.GetObject("PicBxEliminarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxEliminarMedicamento.Location = New System.Drawing.Point(184, 68)
        Me.PicBxEliminarMedicamento.Name = "PicBxEliminarMedicamento"
        Me.PicBxEliminarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxEliminarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxEliminarMedicamento.TabIndex = 3
        Me.PicBxEliminarMedicamento.TabStop = False
        Me.ToolTipMedicamentos.SetToolTip(Me.PicBxEliminarMedicamento, "Eliminar el registro del Medicamento")
        '
        'PicBxGuardarMedicamento
        '
        Me.PicBxGuardarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxGuardarMedicamento.Image = CType(resources.GetObject("PicBxGuardarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxGuardarMedicamento.Location = New System.Drawing.Point(184, 24)
        Me.PicBxGuardarMedicamento.Name = "PicBxGuardarMedicamento"
        Me.PicBxGuardarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxGuardarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxGuardarMedicamento.TabIndex = 1
        Me.PicBxGuardarMedicamento.TabStop = False
        Me.ToolTipMedicamentos.SetToolTip(Me.PicBxGuardarMedicamento, "Guardar el registro del Medicamento")
        '
        'PicBxAgregarMedicamento
        '
        Me.PicBxAgregarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBxAgregarMedicamento.Image = CType(resources.GetObject("PicBxAgregarMedicamento.Image"), System.Drawing.Image)
        Me.PicBxAgregarMedicamento.Location = New System.Drawing.Point(13, 68)
        Me.PicBxAgregarMedicamento.Name = "PicBxAgregarMedicamento"
        Me.PicBxAgregarMedicamento.Size = New System.Drawing.Size(38, 38)
        Me.PicBxAgregarMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBxAgregarMedicamento.TabIndex = 2
        Me.PicBxAgregarMedicamento.TabStop = False
        Me.ToolTipMedicamentos.SetToolTip(Me.PicBxAgregarMedicamento, "Guardar el registro del Medicamento")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 22)
        Me.Panel2.TabIndex = 27
        '
        'FormMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 619)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBoxMedicamentos)
        Me.Controls.Add(Me.DataGridViewMedicamentos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBxDatosMedicamentos)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMedicamentos"
        Me.Text = "Medicamentos"
        Me.GroupBxDatosMedicamentos.ResumeLayout(False)
        Me.GroupBxDatosMedicamentos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMedicamentos.ResumeLayout(False)
        CType(Me.PicBxEditarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxEliminarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxGuardarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBxAgregarMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBxDatosMedicamentos As GroupBox
    Friend WithEvents txtDescripcionMedic As TextBox
    Friend WithEvents LabelDescripMedicamento As Label
    Friend WithEvents txtApellido2Cliente As TextBox
    Friend WithEvents labelCategoriaMedicamento As Label
    Friend WithEvents txtIdMedicamento As TextBox
    Friend WithEvents lablMedicamento As Label
    Friend WithEvents txtNombreClientes As TextBox
    Friend WithEvents lblIdCategoria As Label
    Friend WithEvents txtStockMedicamentos As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblNombreMedicamento As Label
    Friend WithEvents txtBxPrecioMedicamento As TextBox
    Friend WithEvents LblPrecioMedicamento As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewMedicamentos As DataGridView
    Friend WithEvents GroupBoxMedicamentos As GroupBox
    Friend WithEvents BttEliminarMedicamento As Button
    Friend WithEvents BttAgregarMedicamento As Button
    Friend WithEvents BttGuardarMedicamento As Button
    Friend WithEvents BttEditarMedicamento As Button
    Friend WithEvents PicBxEditarMedicamento As PictureBox
    Friend WithEvents PicBxEliminarMedicamento As PictureBox
    Friend WithEvents PicBxGuardarMedicamento As PictureBox
    Friend WithEvents PicBxAgregarMedicamento As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolTipMedicamentos As ToolTip
End Class
