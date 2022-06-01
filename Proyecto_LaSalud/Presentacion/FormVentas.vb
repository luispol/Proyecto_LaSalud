Public Class FormVentas

    Private dt As New DataTable

    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarClientes_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Editar el registro de la venta")
        ToolTipCliente.ToolTipTitle = "Editar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Guardar el registro de la venta")
        ToolTipCliente.ToolTipTitle = "Guardar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Agregar el registro de la venta")
        ToolTipCliente.ToolTipTitle = "Agregar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Eliminar el registro de la venta")
        ToolTipCliente.ToolTipTitle = "Eliminar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON DE VER REGISTROS DE CLIENTE 
    'Private Sub PicBx2RegistrosdeCliente_MouseHover(sender As Object, e As EventArgs)
    '    ToolTipCliente.SetToolTip(PicBx2RegistrosdeCliente, "Ver los registros del cliente")
    '    ToolTipCliente.ToolTipTitle = "Registros de Cliente"
    '    ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    'End Sub

    Private Sub DataGridViewVentas_MouseHover(sender As Object, e As EventArgs) Handles DataGridViewVentas.MouseHover
        ToolTipCliente.SetToolTip(DataGridViewVentas, "Para editar o eliminar, seleccione un registro")
        ToolTipCliente.ToolTipTitle = "Editar o Eliminar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtno_factura.Enabled = False
        txtIdCliente.Enabled = False
        txtApellido1_cliente.Enabled = False
        txtApellido2_cliente.Enabled = False
        txtFecha_venta.Enabled = False
        cbFormaPago.Enabled = False
        btnBuscar_cliente.Enabled = False
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fventa
            dt = func.mostrar()
            DataGridViewVentas.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewVentas.DataSource = dt
                txtBusquedaventas.Enabled = True
                DataGridViewVentas.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewVentas.DataSource = Nothing
                txtBusquedaventas.Enabled = False
                DataGridViewVentas.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarVenta.Enabled = True
        BttGuardarVenta.Enabled = False
        BttEditarVenta.Enabled = False
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampoVenta.Text & " like '" & txtBusquedaventas.Text & "%'"
            If dv.Count <> 0 Then
                linklblInexistente.Visible = False
                DataGridViewVentas.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewVentas.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        DataGridViewVentas.Columns(2).Visible = False
    End Sub



    'Proceso para limpiar los textbox cuando se registre un nuevo cliente
    Public Sub limpiar()
        txtno_factura.Text = ""
        txtIdCliente.Text = ""
        txtApellido1_cliente.Text = ""
        txtApellido2_cliente.Text = ""

    End Sub
    'Acciones al dar click al boton agregar
    Private Sub BttAgregarVenta_Click_1(sender As Object, e As EventArgs) Handles BttAgregarVenta.Click
        limpiar()
        mostrar()
        BttGuardarVenta.Enabled = True
        txtno_factura.Enabled = False
        txtIdCliente.Enabled = False
        txtApellido1_cliente.Enabled = False
        txtApellido2_cliente.Enabled = False
        txtFecha_venta.Enabled = True
        cbFormaPago.Enabled = True
        btnBuscar_cliente.Enabled = True
    End Sub

    Private Sub BttGuardarVenta_Click_1(sender As Object, e As EventArgs) Handles BttGuardarVenta.Click
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtApellido1_cliente.Text <> "" And cbFormaPago.Text <> "" Then
            Try
                Dim dts As New vventa
                Dim func As New fventa
                dts.gidcliente = txtIdCliente.Text
                dts.gfecha_venta = txtFecha_venta.Text
                dts.gforma_pago = cbFormaPago.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Venta registrada, añade productos!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtno_factura.Enabled = False
                    txtIdCliente.Enabled = False
                    txtApellido1_cliente.Enabled = False
                    txtApellido2_cliente.Enabled = False
                    txtFecha_venta.Enabled = False
                    cbFormaPago.Enabled = False
                    cargar_detalle()

                    'Acciones de botones
                    BttGuardarVenta.Enabled = False
                Else
                    MessageBox.Show("Venta no fue registrada", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    'Al hacer click en un registro de cliente en el DataGridView,
    'los datos del cliente seleccionado se transladan a los text box correspondientes
    Private Sub DataGridViewVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellClick

        'MessageBox.Show("Edite los datos y para confirmar, pulse el botón EDITAR", "Editar registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Cajas de texto
        txtno_factura.Text = DataGridViewVentas.SelectedCells.Item(1).Value
        txtIdCliente.Text = DataGridViewVentas.SelectedCells.Item(2).Value
        txtApellido1_cliente.Text = DataGridViewVentas.SelectedCells.Item(3).Value
        txtApellido2_cliente.Text = DataGridViewVentas.SelectedCells.Item(4).Value
        txtFecha_venta.Text = DataGridViewVentas.SelectedCells.Item(6).Value
        cbFormaPago.Text = DataGridViewVentas.SelectedCells.Item(7).Value

        'Habilitar el boton Editar
        BttEditarVenta.Enabled = True

        'Desabilitar el boton Agregar, Guardar, Eliminar
        BttAgregarVenta.Enabled = False
        BttGuardarVenta.Enabled = False


        'Habilitar los Text Box
        txtno_factura.Enabled = False
        txtIdCliente.Enabled = True
        txtApellido1_cliente.Enabled = True
        txtApellido2_cliente.Enabled = True
        txtFecha_venta.Enabled = True
        cbFormaPago.Enabled = True
    End Sub

    'BOTON EDITAR
    Private Sub BttEditarVenta_Click_1(sender As Object, e As EventArgs) Handles BttEditarVenta.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere editar los datos de la venta?", "Modicando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'Condicion para validar que se hayan registrado datos en texboxs especificos
            If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtApellido1_cliente.Text <> "" And txtno_factura.Text <> "" Then
                Try
                    Dim dts As New vventa
                    Dim func As New fventa

                    dts.gidcliente = txtno_factura.Text
                    dts.gidcliente = txtIdCliente.Text
                    dts.gfecha_venta = txtFecha_venta.Text
                    dts.gforma_pago = cbFormaPago.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Datos de la venta modificados correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtno_factura.Enabled = False
                        txtIdCliente.Enabled = False
                        txtApellido1_cliente.Enabled = False
                        txtApellido2_cliente.Enabled = False
                        txtFecha_venta.Enabled = False
                        cbFormaPago.Enabled = False
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
                txtno_factura.Enabled = False
                txtIdCliente.Enabled = False
                txtApellido1_cliente.Enabled = False
                txtApellido2_cliente.Enabled = False
                txtFecha_venta.Enabled = False
                cbFormaPago.Enabled = False
                limpiar()
            End If
        Else
            MessageBox.Show("Cancelando los cambios del registro", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtno_factura.Enabled = False
            txtIdCliente.Enabled = False
            txtApellido1_cliente.Enabled = False
            txtApellido2_cliente.Enabled = False
            txtFecha_venta.Enabled = False
            cbFormaPago.Enabled = False
            Call mostrar()
        End If
        limpiar()
        BttAgregarVenta.Enabled = True
        BttGuardarVenta.Enabled = False
        BttEditarVenta.Enabled = False
    End Sub

    'Proceso para que muestre la columna que contiene los checkbox para seleccionar el registro a eliminar
    'Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
    '    If cbeliminar.CheckState = CheckState.Checked Then
    '        DataGridViewVentas.Columns.Item("Eliminar").Visible = True
    '        BttEliminarVenta.Enabled = True
    '        BttAgregarVenta.Enabled = False
    '        BttEditarVenta.Enabled = False
    '        BttGuardarVenta.Enabled = False
    '    Else
    '        DataGridViewVentas.Columns.Item("Eliminar").Visible = False
    '        BttEliminarVenta.Enabled = False
    '        BttAgregarVenta.Enabled = True
    '        BttEditarVenta.Enabled = False
    '        BttGuardarVenta.Enabled = False
    '        limpiar()
    '        txtno_factura.Enabled = False
    '        txtDUIClientes.Enabled = False
    '        txtIdCliente.Enabled = False
    '        txtApellido1Cliente.Enabled = False
    '        txtForma_pago.Enabled = False
    '        TxtApellido3.Enabled = False
    '        txtCorreoClientes.Enabled = False
    '        txtdireccionCliente.Enabled = False
    '        txtTelefonoClientes.Enabled = False


    '    End If

    'End Sub
    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellContentClick
        If e.ColumnIndex = Me.DataGridViewVentas.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewVentas.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


    Private Sub txtBusquedaventas_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaventas.TextChanged
        buscar()
    End Sub


    Private Sub cargar_detalle()
        FormDetalle_Factura.txtno_factura.Text = DataGridViewVentas.SelectedCells.Item(1).Value
        FormDetalle_Factura.txtIdCliente.Text = DataGridViewVentas.SelectedCells.Item(2).Value
        FormDetalle_Factura.txtApellido1_cliente.Text = DataGridViewVentas.SelectedCells.Item(3).Value
        FormDetalle_Factura.txtApellido2_cliente.Text = DataGridViewVentas.SelectedCells.Item(4).Value
        FormDetalle_Factura.txtFecha_venta.Text = DataGridViewVentas.SelectedCells.Item(6).Value
        FormDetalle_Factura.cbFormaPago.Text = DataGridViewVentas.SelectedCells.Item(7).Value
        FormDetalle_Factura.ShowDialog()
    End Sub

    'Private Sub DataGridViewVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellDoubleClick
    '    cargar_detalle()
    '    FormDetalle_Factura.ShowDialog()
    'End Sub

    Private Sub btnBuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnBuscar_cliente.Click
        Dim frmcli As New FormClientes
        AddOwnedForm(frmcli)
        frmcli.ShowDialog()
    End Sub


End Class