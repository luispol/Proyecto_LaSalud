Public Class FormVentas

    Private dt As New DataTable

    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarClientes_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Editar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Editar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Guardar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Guardar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Agregar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Agregar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Eliminar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Eliminar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON DE VER REGISTROS DE CLIENTE 
    'Private Sub PicBx2RegistrosdeCliente_MouseHover(sender As Object, e As EventArgs)
    '    ToolTipCliente.SetToolTip(PicBx2RegistrosdeCliente, "Ver los registros del cliente")
    '    ToolTipCliente.ToolTipTitle = "Registros de Cliente"
    '    ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    'End Sub

    Private Sub DataGridViewClientes_MouseHover(sender As Object, e As EventArgs) Handles DataGridViewVentas.MouseHover
        ToolTipCliente.SetToolTip(DataGridViewVentas, "Para editar o eliminar, seleccione un registro")
        ToolTipCliente.ToolTipTitle = "Editar o Eliminar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtno_factura.Enabled = False
        txtDUIClientes.Enabled = False
        txtIdCliente.Enabled = False
        txtApellido1Cliente.Enabled = False
        txtForma_pago.Enabled = False
        TxtApellido3.Enabled = False
        txtCorreoClientes.Enabled = False
        txtdireccionCliente.Enabled = False
        txtTelefonoClientes.Enabled = False
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar()
            DataGridViewVentas.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewVentas.DataSource = dt
                txtBusquedaClientes.Enabled = True
                DataGridViewVentas.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewVentas.DataSource = Nothing
                txtBusquedaClientes.Enabled = False
                DataGridViewVentas.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarVenta.Enabled = True
        BttGuardarVenta.Enabled = False
        BttEditarVenta.Enabled = False
        BttEditarVenta.Visible = True
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampoCliente.Text & " like '" & txtBusquedaClientes.Text & "%'"
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
        DataGridViewVentas.Columns(1).Visible = False
    End Sub

    'Procesos de los textbox para capturar la informacion del cliente

    Private Sub txtNombreClientes_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCliente.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese los nombres del cliente")
        End If
    End Sub

    Private Sub txtApellido1Cliente_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido1Cliente.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el primer apellido del cliente")
        End If
    End Sub

    Private Sub txtApellido2Cliente_Validating(sender As Object, e As CancelEventArgs) Handles txtForma_pago.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el segundo apellido del cliente")
        End If
    End Sub

    Private Sub txtdireccionCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccionCliente.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del cliente")
        End If
    End Sub
    Private Sub txtTelefonoClientes_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefonoClientes.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el telefono del cliente")
        End If
    End Sub

    'Proceso para limpiar los textbox cuando se registre un nuevo cliente
    Public Sub limpiar()
        txtno_factura.Text = ""
        txtIdCliente.Text = ""
        txtNombre_cliente.Text = ""
        txtForma_pago.Text = ""

    End Sub
    'Acciones al dar click al boton agregar
    Private Sub BttAgregarCliente_Click(sender As Object, e As EventArgs)
        limpiar()
        mostrar()
        'Habilitar el boton guardar
        BttGuardarVenta.Enabled = True
        'activiacion de los textboxs
        txtno_factura.Enabled = False
        txtDUIClientes.Enabled = True
        txtIdCliente.Enabled = True
        txtApellido1Cliente.Enabled = True
        txtForma_pago.Enabled = True
        TxtApellido3.Enabled = True
        txtCorreoClientes.Enabled = True
        txtdireccionCliente.Enabled = True
        txtTelefonoClientes.Enabled = True

    End Sub

    Private Sub BttGuardarCliente_Click(sender As Object, e As EventArgs)
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtApellido1Cliente.Text <> "" And txtForma_pago.Text <> "" And txtdireccionCliente.Text <> "" And txtTelefonoClientes.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New fcliente
                dts.gDUI = txtDUIClientes.Text
                dts.gnombres = txtIdCliente.Text
                dts.gprimerapellido = txtApellido1Cliente.Text
                dts.gsegundoapellido = txtForma_pago.Text
                dts.gtercerapellido = TxtApellido3.Text
                dts.gcorreo = txtCorreoClientes.Text
                dts.gdireccion = txtdireccionCliente.Text
                dts.gtelefono = txtTelefonoClientes.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Datos registrados", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtno_factura.Enabled = False
                    txtDUIClientes.Enabled = False
                    txtIdCliente.Enabled = False
                    txtApellido1Cliente.Enabled = False
                    txtForma_pago.Enabled = False
                    TxtApellido3.Enabled = False
                    txtCorreoClientes.Enabled = False
                    txtdireccionCliente.Enabled = False
                    txtTelefonoClientes.Enabled = False
                    'Acciones de botones
                    BttGuardarVenta.Enabled = False
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

    'Al hacer click en un registro de cliente en el DataGridView,
    'los datos del cliente seleccionado se transladan a los text box correspondientes
    Private Sub DataGridViewClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellClick

        'MessageBox.Show("Edite los datos y para confirmar, pulse el botón EDITAR", "Editar registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Cajas de texto
        txtno_factura.Text = DataGridViewVentas.SelectedCells.Item(1).Value
        txtDUIClientes.Text = DataGridViewVentas.SelectedCells.Item(2).Value
        txtIdCliente.Text = DataGridViewVentas.SelectedCells.Item(3).Value
        txtApellido1Cliente.Text = DataGridViewVentas.SelectedCells.Item(4).Value
        txtForma_pago.Text = DataGridViewVentas.SelectedCells.Item(5).Value
        TxtApellido3.Text = DataGridViewVentas.SelectedCells.Item(6).Value
        txtdireccionCliente.Text = DataGridViewVentas.SelectedCells.Item(7).Value
        txtCorreoClientes.Text = DataGridViewVentas.SelectedCells.Item(8).Value
        txtTelefonoClientes.Text = DataGridViewVentas.SelectedCells.Item(9).Value

        'Habilitar el boton Editar
        BttEditarVenta.Enabled = True

        'Desabilitar el boton Agregar, Guardar, Eliminar
        BttAgregarVenta.Enabled = False
        BttGuardarVenta.Enabled = False
        BttEliminarVenta.Enabled = False


        'Habilitar los Text Box
        txtno_factura.Enabled = False
        txtIdCliente.Enabled = True
        txtDUIClientes.Enabled = True
        txtApellido1Cliente.Enabled = True
        txtForma_pago.Enabled = True
        TxtApellido3.Enabled = True
        txtdireccionCliente.Enabled = True
        txtCorreoClientes.Enabled = True
        txtTelefonoClientes.Enabled = True
    End Sub

    'BOTON EDITAR
    Private Sub BttEditarCliente_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere editar los datos del cliente?", "Modicando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'Condicion para validar que se hayan registrado datos en texboxs especificos
            If Me.ValidateChildren = True And txtIdCliente.Text <> "" And txtApellido1Cliente.Text <> "" And txtForma_pago.Text <> "" And txtdireccionCliente.Text <> "" And txtTelefonoClientes.Text <> "" And txtno_factura.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gidcliente = txtno_factura.Text
                    dts.gDUI = txtDUIClientes.Text
                    dts.gnombres = txtIdCliente.Text
                    dts.gprimerapellido = txtApellido1Cliente.Text
                    dts.gsegundoapellido = txtForma_pago.Text
                    dts.gtercerapellido = TxtApellido3.Text
                    dts.gcorreo = txtCorreoClientes.Text
                    dts.gdireccion = txtdireccionCliente.Text
                    dts.gtelefono = txtTelefonoClientes.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Datos de Cliente modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtno_factura.Enabled = False
                        txtDUIClientes.Enabled = False
                        txtIdCliente.Enabled = False
                        txtApellido1Cliente.Enabled = False
                        txtForma_pago.Enabled = False
                        TxtApellido3.Enabled = False
                        txtCorreoClientes.Enabled = False
                        txtdireccionCliente.Enabled = False
                        txtTelefonoClientes.Enabled = False
                        cbeliminar.Checked = False
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
                txtDUIClientes.Enabled = False
                txtIdCliente.Enabled = False
                txtApellido1Cliente.Enabled = False
                txtForma_pago.Enabled = False
                TxtApellido3.Enabled = False
                txtCorreoClientes.Enabled = False
                txtdireccionCliente.Enabled = False
                txtTelefonoClientes.Enabled = False
                limpiar()
            End If
        Else
            MessageBox.Show("Cancelando los cambios del registro", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtno_factura.Enabled = False
            txtDUIClientes.Enabled = False
            txtIdCliente.Enabled = False
            txtApellido1Cliente.Enabled = False
            txtForma_pago.Enabled = False
            TxtApellido3.Enabled = False
            txtCorreoClientes.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False
            cbeliminar.Checked = False
            Call mostrar()
        End If
        limpiar()
        BttAgregarVenta.Enabled = True
        BttGuardarVenta.Enabled = False
        BttEditarVenta.Enabled = False
        BttEliminarVenta.Enabled = False
    End Sub

    'Proceso para que muestre la columna que contiene los checkbox para seleccionar el registro a eliminar
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            DataGridViewVentas.Columns.Item("Eliminar").Visible = True
            BttEliminarVenta.Enabled = True
            BttAgregarVenta.Enabled = False
            BttEditarVenta.Enabled = False
            BttGuardarVenta.Enabled = False
        Else
            DataGridViewVentas.Columns.Item("Eliminar").Visible = False
            BttEliminarVenta.Enabled = False
            BttAgregarVenta.Enabled = True
            BttEditarVenta.Enabled = False
            BttGuardarVenta.Enabled = False
            limpiar()
            txtno_factura.Enabled = False
            txtDUIClientes.Enabled = False
            txtIdCliente.Enabled = False
            txtApellido1Cliente.Enabled = False
            txtForma_pago.Enabled = False
            TxtApellido3.Enabled = False
            txtCorreoClientes.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False


        End If

    End Sub
    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellContentClick
        If e.ColumnIndex = Me.DataGridViewVentas.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewVentas.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            BttEliminarVenta.Enabled = True
        End If
    End Sub
    'BOTON ELIMINAR
    Private Sub BttEliminarCliente_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere eliminar a los clientes seleccionados?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataGridViewVentas.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New vcliente
                        Dim func As New fcliente
                        vdb.gidcliente = onekey

                        If func.eliminar(vdb) Then
                            cbeliminar.Checked = False
                            txtno_factura.Enabled = False
                            txtDUIClientes.Enabled = False
                            txtIdCliente.Enabled = False
                            txtApellido1Cliente.Enabled = False
                            txtForma_pago.Enabled = False
                            TxtApellido3.Enabled = False
                            txtCorreoClientes.Enabled = False
                            txtdireccionCliente.Enabled = False
                            txtTelefonoClientes.Enabled = False

                        Else
                            MessageBox.Show("El cliente no fue eliminado", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cbeliminar.Checked = False
                            txtno_factura.Enabled = False
                            txtDUIClientes.Enabled = False
                            txtIdCliente.Enabled = False
                            txtApellido1Cliente.Enabled = False
                            txtForma_pago.Enabled = False
                            TxtApellido3.Enabled = False
                            txtCorreoClientes.Enabled = False
                            txtdireccionCliente.Enabled = False
                            txtTelefonoClientes.Enabled = False
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando la eliminación de registros", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbeliminar.Checked = False
            txtno_factura.Enabled = False
            txtDUIClientes.Enabled = False
            txtIdCliente.Enabled = False
            txtApellido1Cliente.Enabled = False
            txtForma_pago.Enabled = False
            TxtApellido3.Enabled = False
            txtCorreoClientes.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False
            Call mostrar()
        End If
        Call limpiar()
        BttAgregarVenta.Enabled = True
    End Sub

    Private Sub txtBusquedaClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaClientes.TextChanged
        buscar()
    End Sub

    Private Sub BttEliminarVenta_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PicBxEliminarCliente_Click(sender As Object, e As EventArgs)

    End Sub
End Class