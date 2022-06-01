Imports System.ComponentModel

Public Class FormMedicamentos

    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO DE MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarMedicamento_MouseHover(sender As Object, e As EventArgs)
        ToolTipMedicamento.SetToolTip(PicBxAgregarMedicamentos, "Editar el registro del Medicamento")
        ToolTipMedicamento.ToolTipTitle = "Editar"
        ToolTipMedicamento.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarMedicamento_MouseHover(sender As Object, e As EventArgs)
        ToolTipMedicamento.SetToolTip(PicBxAgregarMedicamentos, "Agregar el registro del Medicamento")
        ToolTipMedicamento.ToolTipTitle = "Agregar"
        ToolTipMedicamento.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarMedicamento_MouseHover(sender As Object, e As EventArgs)
        ToolTipMedicamento.SetToolTip(PicBxAgregarMedicamentos, "Guardar el registro del Medicamento")
        ToolTipMedicamento.ToolTipTitle = "Guardar"
        ToolTipMedicamento.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarMedicamento_MouseHover(sender As Object, e As EventArgs)
        ToolTipMedicamento.SetToolTip(PicBxAgregarMedicamentos, "Eliminar el registro del Medicamento")
        ToolTipMedicamento.ToolTipTitle = "Eliminar"
        ToolTipMedicamento.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private dt As New DataTable

    Private Sub FormMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtIdMedicamento.Enabled = False
        txtNombreMedicamento.Enabled = False
        txtidCategoria_med.Enabled = False
        txtDescripcionMed.Enabled = False
        txtStock.Enabled = False
        txtPrecioCompraMed.Enabled = False
        txtPrecioVentaMed.Enabled = False
        datefecha_vencimiento.Enabled = False
        txtNom_Categoria.Enabled = False
        BttnSeleecionarCategoria.Enabled = False
        Btn_CargarPic.Enabled = False
        Btn_limpiarPic.Enabled = False
        txtStockOpc.Enabled = False
        rbAumentarStock.Enabled = False
        rbDisminuirStock.Enabled = False
        chkAumentar_Disminuir.Enabled = False
    End Sub



    'Proceso para mostar los datos en la tabla
    Private Sub mostrar()
        Try
            Dim func As New fmedicamentos
            dt = func.mostrar()
            DataGridViewMedicamentos.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewMedicamentos.DataSource = dt
                txtBusquedaMedicamentos.Enabled = True
                DataGridViewMedicamentos.ColumnHeadersVisible = True
                lnkInexistente.Enabled = False
            Else
                DataGridViewMedicamentos.DataSource = Nothing
                txtBusquedaMedicamentos.Enabled = False
                DataGridViewMedicamentos.ColumnHeadersVisible = False
                lnkInexistente.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarMedicamentos.Enabled = True
        BttGuardarMedicamento.Enabled = False
        BttEditarMedicamentos.Enabled = False
        BttEditarMedicamentos.Visible = True
        BttEliminarMedicamento.Enabled = False
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampoMedicamento.Text & " like '" & txtBusquedaMedicamentos.Text & "%'"
            If dv.Count <> 0 Then
                linklblInexistente.Visible = False
                DataGridViewMedicamentos.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewMedicamentos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        DataGridViewMedicamentos.Columns(1).Visible = False
        DataGridViewMedicamentos.Columns(2).Visible = False
    End Sub

    'Procesos de los textbox para capturar la informacion
    Private Sub txtNombreMedicamento_Validating(ByVal sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreMedicamento.Validating
        'Revisamos si las cajas de texto tiene caracteres de informacion o no

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del medicamento")
        End If
    End Sub
    Private Sub txtDescripcionMed_Validating(ByVal sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcionMed.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese una descripción al medicamento")
        End If
    End Sub
    Private Sub txtStock_Validating(ByVal sender As Object, e As CancelEventArgs) Handles txtStock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Debe ingresar el stock del medicamento")
        End If
    End Sub
    Private Sub txtPrecioCompraMed_Validating(ByVal sender As Object, e As CancelEventArgs) Handles txtPrecioCompraMed.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de compra al medicamento")
        End If
    End Sub
    Private Sub txtPrecioVentaMed_Validating(ByVal sender As Object, e As CancelEventArgs) Handles txtPrecioVentaMed.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de venta al medicamento")
        End If
    End Sub

    'Proceso para limpiar los textbox cuando se registre un nuevo cliente
    Public Sub limpiar()
        'BttGuardarCliente.Visible = False
        txtIdMedicamento.Text = ""
        txtNombreMedicamento.Text = ""
        txtNom_Categoria.Text = ""
        txtidCategoria_med.Text = ""
        txtDescripcionMed.Text = ""
        txtStock.Text = "0"
        txtPrecioCompraMed.Text = "0"
        txtPrecioVentaMed.Text = "0"
        txtStockOpc.Text = 0
        rbAumentarStock.Checked = False
        rbDisminuirStock.Checked = False
        BttnSeleecionarCategoria.Enabled = False
        chkAumentar_Disminuir.Checked = False

        Imagen.Image = Nothing
        Imagen.BackgroundImage = My.Resources.sin_imagen
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub
    'Acciones al dar click al boton agregar
    Private Sub BttAgregarMedicamentos_Click(sender As Object, e As EventArgs) Handles BttAgregarMedicamentos.Click
        limpiar()
        mostrar()
        'Habilitar el boton guardar
        BttGuardarMedicamento.Enabled = True
        'activiacion de los textboxs
        txtIdMedicamento.Enabled = False
        txtNombreMedicamento.Enabled = True
        txtNom_Categoria.Enabled = False
        txtidCategoria_med.Enabled = False
        txtDescripcionMed.Enabled = True
        txtStock.Enabled = True
        txtPrecioCompraMed.Enabled = True
        txtPrecioVentaMed.Enabled = True
        datefecha_vencimiento.Enabled = True
        BttnSeleecionarCategoria.Enabled = True
        Btn_CargarPic.Enabled = True
        Btn_limpiarPic.Enabled = True
    End Sub

    Private Sub BttGuardarMedicamento_Click(sender As Object, e As EventArgs) Handles BttGuardarMedicamento.Click
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtNombreMedicamento.Text <> "" And txtDescripcionMed.Text <> "" And txtStock.Text <> "" And txtPrecioCompraMed.Text <> "" And txtPrecioVentaMed.Text <> "" Then
            Try
                Dim dts As New vmedicamento
                Dim func As New fmedicamentos
                dts.gnombre = txtNombreMedicamento.Text
                dts.gidcategoria = txtidCategoria_med.Text
                dts.gdescripcion = txtDescripcionMed.Text
                dts.gstock = txtStock.Text
                dts.gprecio_compra = txtPrecioCompraMed.Text
                dts.gprecio_venta = txtPrecioVentaMed.Text
                dts.gfecha_vencimiento = datefecha_vencimiento.Text



                Dim ms As New IO.MemoryStream()

                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.sin_imagen
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                dts.gimagen = ms.GetBuffer


                If func.insertar(dts) Then
                    MessageBox.Show("Datos registrados", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtIdMedicamento.Enabled = False
                    txtNombreMedicamento.Enabled = False
                    txtidCategoria_med.Enabled = False
                    txtDescripcionMed.Enabled = False
                    txtStock.Enabled = False
                    txtPrecioCompraMed.Enabled = False
                    txtPrecioVentaMed.Enabled = False
                    datefecha_vencimiento.Enabled = False
                    txtNom_Categoria.Enabled = False
                    BttnSeleecionarCategoria.Enabled = False
                    Btn_CargarPic.Enabled = False
                    Btn_limpiarPic.Enabled = False

                    'Acciones de botones
                    BttGuardarMedicamento.Enabled = False
                Else
                    MessageBox.Show("Datos no registrados", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falto ingresar datos obligatorios", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    'Al hacer click en un registro de medicamentos en el DataGridView,
    'los datos del medicamento seleccionado se transladan a los text box correspondientes
    Private Sub DataGridViewMedicamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicamentos.CellClick


        'MessageBox.Show("Edite los datos y para confirmar, pulse el botón EDITAR", "Editar registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Cajas de texto
        txtIdMedicamento.Text = DataGridViewMedicamentos.SelectedCells.Item(1).Value
        txtidCategoria_med.Text = DataGridViewMedicamentos.SelectedCells.Item(2).Value
        txtNom_Categoria.Text = DataGridViewMedicamentos.SelectedCells.Item(3).Value
        txtNombreMedicamento.Text = DataGridViewMedicamentos.SelectedCells.Item(4).Value
        txtDescripcionMed.Text = DataGridViewMedicamentos.SelectedCells.Item(5).Value
        txtStock.Text = DataGridViewMedicamentos.SelectedCells.Item(6).Value
        txtPrecioCompraMed.Text = DataGridViewMedicamentos.SelectedCells.Item(7).Value
        txtPrecioVentaMed.Text = DataGridViewMedicamentos.SelectedCells.Item(8).Value
        datefecha_vencimiento.Text = DataGridViewMedicamentos.SelectedCells.Item(9).Value



        Imagen.BackgroundImage = Nothing
        Dim b() As Byte = DataGridViewMedicamentos.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        Imagen.Image = Image.FromStream(ms)
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage

        'Habilitar el boton Editar
        BttEditarMedicamentos.Enabled = True

        'Desabilitar el boton Agregar, Guardar, Eliminar
        BttAgregarMedicamentos.Enabled = False
        BttGuardarMedicamento.Enabled = False
        BttEliminarMedicamento.Enabled = False


        'Habilitar los Text Box
        txtIdMedicamento.Enabled = False
        txtidCategoria_med.Enabled = False
        txtNom_Categoria.Enabled = False
        BttnSeleecionarCategoria.Enabled = True
        txtNombreMedicamento.Enabled = True
        txtDescripcionMed.Enabled = True
        txtStock.Enabled = False
        txtPrecioCompraMed.Enabled = True
        datefecha_vencimiento.Enabled = True
        txtPrecioVentaMed.Enabled = True
        txtStockOpc.Enabled = False
        rbAumentarStock.Enabled = False
        rbDisminuirStock.Enabled = False
        chkAumentar_Disminuir.Enabled = True
    End Sub

    'BOTON EDITAR
    Private Sub BttEditarMedicamentos_Click(sender As Object, e As EventArgs) Handles BttEditarMedicamentos.Click

        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere editar los datos del medicamento?", "Modicando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'Condicion para validar que se hayan registrado datos en texboxs especificos
            If Me.ValidateChildren = True And txtNombreMedicamento.Text <> "" And txtDescripcionMed.Text <> "" And txtStock.Text <> "" And txtPrecioCompraMed.Text <> "" And txtPrecioVentaMed.Text <> "" And txtIdMedicamento.Text <> "" Then
                Try
                    Dim dts As New vmedicamento
                    Dim func As New fmedicamentos

                    dts.gidmedicamento = txtIdMedicamento.Text
                    dts.gnombre = txtNombreMedicamento.Text
                    dts.gidcategoria = txtidCategoria_med.Text
                    dts.gdescripcion = txtDescripcionMed.Text
                    dts.gstock = txtStock.Text
                    dts.gprecio_compra = txtPrecioCompraMed.Text
                    dts.gprecio_venta = txtPrecioVentaMed.Text
                    dts.gfecha_vencimiento = datefecha_vencimiento.Text


                    Dim ms As New IO.MemoryStream()
                    If Not Imagen.Image Is Nothing Then
                        Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                    Else
                        Imagen.Image = My.Resources.sin_imagen
                        Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                    End If

                    dts.gimagen = ms.GetBuffer

                    'If chkAumentar_Disminuir.Checked = True Then
                    '    txtIdMedicamento.Enabled = False
                    '    txtNombreMedicamento.Enabled = False
                    '    txtidCategoria_med.Enabled = False
                    '    txtDescripcionMed.Enabled = False
                    '    txtStock.Enabled = False
                    '    txtPrecioCompraMed.Enabled = False
                    '    txtPrecioVentaMed.Enabled = False
                    '    datefecha_vencimiento.Enabled = False
                    '    BttnSeleecionarCategoria.Enabled = False
                    '    txtStockOpc.Enabled = True
                    '    rbAumentarStock.Enabled = True
                    '    rbDisminuirStock.Enabled = True

                    'End If


                    If rbAumentarStock.Checked = True And txtStockOpc.Value > 0 Then
                        Dim aumentar As Double
                        aumentar = dts.gstock + txtStockOpc.Text
                        dts.gstock = aumentar
                    End If

                    If rbDisminuirStock.Checked = True And txtStockOpc.Value > 0 And txtStockOpc.Value < dts.gstock Then
                        Dim disminuir As Double
                        disminuir = dts.gstock - txtStockOpc.Text
                        dts.gstock = disminuir
                    End If

                    If func.editar(dts) Then
                        MessageBox.Show("Datos de medicamento modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtIdMedicamento.Enabled = False
                        txtNombreMedicamento.Enabled = False
                        txtidCategoria_med.Enabled = False
                        txtDescripcionMed.Enabled = False
                        txtStock.Enabled = False
                        txtPrecioCompraMed.Enabled = False
                        txtPrecioVentaMed.Enabled = False
                        datefecha_vencimiento.Enabled = False
                        txtStockOpc.Enabled = False
                        rbAumentarStock.Enabled = False
                        rbDisminuirStock.Enabled = False
                        chkAumentar_Disminuir.Enabled = False
                        limpiar()
                    Else
                        MessageBox.Show("Datos no modificados", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falto ingresar datos obligatorios", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIdMedicamento.Enabled = False
                txtNombreMedicamento.Enabled = False
                txtidCategoria_med.Enabled = False
                txtDescripcionMed.Enabled = False
                txtStock.Enabled = False
                txtPrecioCompraMed.Enabled = False
                txtPrecioVentaMed.Enabled = False
                datefecha_vencimiento.Enabled = False
                txtStockOpc.Enabled = False
                rbAumentarStock.Enabled = False
                rbDisminuirStock.Enabled = False
                BttnSeleecionarCategoria.Enabled = False
                chkAumentar_Disminuir.Enabled = False
                limpiar()
            End If



        Else
            MessageBox.Show("Cancelando los cambios del registro", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdMedicamento.Enabled = False
            txtNombreMedicamento.Enabled = False
            txtidCategoria_med.Enabled = False
            txtDescripcionMed.Enabled = False
            txtStock.Enabled = False
            txtPrecioCompraMed.Enabled = False
            txtPrecioVentaMed.Enabled = False
            datefecha_vencimiento.Enabled = False
            txtStockOpc.Enabled = False
            rbAumentarStock.Enabled = False
            rbDisminuirStock.Enabled = False
            BttnSeleecionarCategoria.Enabled = False
            chkAumentar_Disminuir.Enabled = False
            Call mostrar()
        End If
        limpiar()
        BttAgregarMedicamentos.Enabled = True
        BttGuardarMedicamento.Enabled = False
        BttEditarMedicamentos.Enabled = False
        BttEliminarMedicamento.Enabled = False
        txtStockOpc.Enabled = False
        rbAumentarStock.Enabled = False
        rbDisminuirStock.Enabled = False
    End Sub

    'Proceso para que muestre la columna que contiene los checkbox para seleccionar el registro a eliminar
    Private Sub cbeliminarmedicamento_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminarmedicamento.CheckedChanged
        If cbeliminarmedicamento.CheckState = CheckState.Checked Then
            DataGridViewMedicamentos.Columns.Item("Eliminar").Visible = True
            BttEliminarMedicamento.Enabled = True
            BttAgregarMedicamentos.Enabled = False
            BttEditarMedicamentos.Enabled = False
            BttGuardarMedicamento.Enabled = False
        Else
            DataGridViewMedicamentos.Columns.Item("Eliminar").Visible = False
            BttEliminarMedicamento.Enabled = False
            BttAgregarMedicamentos.Enabled = True
            BttEditarMedicamentos.Enabled = False
            BttGuardarMedicamento.Enabled = False

        End If

    End Sub
    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicamentos.CellContentClick
        If e.ColumnIndex = Me.DataGridViewMedicamentos.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewMedicamentos.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            BttEliminarMedicamento.Enabled = True
        End If
    End Sub
    'BOTON ELIMINAR
    Private Sub BttEliminarMedicamento_Click(sender As Object, e As EventArgs) Handles BttEliminarMedicamento.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere eliminar los medicamentos seleccionados?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataGridViewMedicamentos.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idmedicamento").Value)
                        Dim vdb As New vmedicamento
                        Dim func As New fmedicamentos
                        vdb.gidmedicamento = onekey

                        If func.eliminar(vdb) Then
                            cbeliminarmedicamento.Checked = False
                            txtIdMedicamento.Enabled = False
                            txtNombreMedicamento.Enabled = False
                            txtidCategoria_med.Enabled = False
                            txtDescripcionMed.Enabled = False
                            txtStock.Enabled = False
                            txtPrecioCompraMed.Enabled = False
                            txtPrecioVentaMed.Enabled = False
                            datefecha_vencimiento.Enabled = False


                        Else
                            MessageBox.Show("El medicamento no fue eliminado", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cbeliminarmedicamento.Checked = False
                            txtIdMedicamento.Enabled = False
                            txtNombreMedicamento.Enabled = False
                            txtidCategoria_med.Enabled = False
                            txtDescripcionMed.Enabled = False
                            txtStock.Enabled = False
                            txtPrecioCompraMed.Enabled = False
                            txtPrecioVentaMed.Enabled = False
                            datefecha_vencimiento.Enabled = False

                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando la eliminación de registros", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbeliminarmedicamento.Checked = False
            txtIdMedicamento.Enabled = False
            txtNombreMedicamento.Enabled = False
            txtidCategoria_med.Enabled = False
            txtDescripcionMed.Enabled = False
            txtStock.Enabled = False
            txtPrecioCompraMed.Enabled = False
            txtPrecioVentaMed.Enabled = False
            datefecha_vencimiento.Enabled = False

            Call mostrar()
        End If
        Call limpiar()
        BttAgregarMedicamentos.Enabled = True
    End Sub
    'BOTON CARGAR IMAGEN A UN MEDICAMENTO
    Private Sub Btn_CargarPic_Click(sender As Object, e As EventArgs) Handles Btn_CargarPic.Click
        If OpenFileDialogMed.ShowDialog() = DialogResult.OK Then
            Imagen.BackgroundImage = Nothing
            Imagen.Image = New Bitmap(OpenFileDialogMed.FileName)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    'BOTON LIMPIAR IMAGEN DE UN MEDICAMENTO (QUITA LA IMAGEN PREDETERMINADA)
    Private Sub Btn_limpiarPic_Click(sender As Object, e As EventArgs) Handles Btn_limpiarPic.Click
        Imagen.Image = Nothing
        Imagen.BackgroundImage = My.Resources.sin_imagen
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub BttnSeleecionarCategoria_Click(ByVal sender As Object, e As EventArgs) Handles BttnSeleecionarCategoria.Click
        Dim frm As New FormCategorias
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub txtBusquedaMedicamentos_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaMedicamentos.TextChanged
        buscar()
    End Sub

    Private Sub DataGridViewMedicamentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicamentos.CellDoubleClick
        Dim frm As FormDetalle_Factura = CType(Owner, FormDetalle_Factura)
        frm.txtIdMedicamento.Text = DataGridViewMedicamentos.CurrentRow.Cells(1).Value
        frm.txtNombre_Medicamento.Text = DataGridViewMedicamentos.CurrentRow.Cells(4).Value
        frm.txtStock.Text = DataGridViewMedicamentos.CurrentRow.Cells(6).Value
        frm.txtPrecioUnitario.Text = DataGridViewMedicamentos.CurrentRow.Cells(7).Value
        frm.Imagen.Image = Imagen.Image
        Me.Close()
    End Sub

    'VALIDACION DE TEXT BOX
    Private Sub txtNombreMedicamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreMedicamento.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MessageBox.Show("El nombre solo debe contener letras", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        Call condicion(txtStock, e)
    End Sub

    Private Sub txtPrecioCompraMed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCompraMed.KeyPress
        Call condicion(txtPrecioCompraMed, e)
    End Sub

    Private Sub txtPrecioVentaMed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVentaMed.KeyPress
        Call condicion(txtPrecioVentaMed, e)
    End Sub

    Private Sub txtDescripcionMed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionMed.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MessageBox.Show("La descripcion solo debe contener letras", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub condicion(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""


        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If


        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnAumentar_Click(sender As Object, e As EventArgs)
        Dim aumentar As Double
        aumentar = txtStock.Text + txtStockOpc.Text

    End Sub

    Private Sub chkAumentar_Disminuir_CheckedChanged(sender As Object, e As EventArgs) Handles chkAumentar_Disminuir.CheckedChanged
        txtIdMedicamento.Enabled = False
        txtNombreMedicamento.Enabled = False
        txtidCategoria_med.Enabled = False
        txtDescripcionMed.Enabled = False
        txtStock.Enabled = False
        txtPrecioCompraMed.Enabled = False
        txtPrecioVentaMed.Enabled = False
        datefecha_vencimiento.Enabled = False
        BttnSeleecionarCategoria.Enabled = False
        txtStockOpc.Enabled = True
        rbAumentarStock.Enabled = True
        rbDisminuirStock.Enabled = True

    End Sub


End Class