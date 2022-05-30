Public Class FormDetalle_Factura
    Private dt As New DataTable

    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON GUARDAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxGuardarDetalleVenta, "Guarda el registro del detalle de la venta")
        ToolTipCliente.ToolTipTitle = "Guardar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarCliente_MouseHover(sender As Object, e As EventArgs)
        ToolTipCliente.SetToolTip(PicBxAgregarDet_Venta, "Agrega el registro del detalle de la venta")
        ToolTipCliente.ToolTipTitle = "Agregar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub DataGridViewVentas_MouseHover(sender As Object, e As EventArgs) Handles DataGridViewDetalleVenta.MouseHover
        ToolTipCliente.SetToolTip(DataGridViewDetalleVenta, "Para editar o eliminar, seleccione un registro")
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
        txtIdMedicamento.Enabled = False
        txtNombre_Medicamento.Enabled = False
        txtCantidad.Enabled = False
        txtStock.Enabled = False
        txtPrecioUnitario.Enabled = False
        btnBuscar_Medicamento.Enabled = False
        BttQuitarArts.Enabled = False

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fdetalle_factura
            dt = func.mostrar()
            DataGridViewDetalleVenta.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewDetalleVenta.DataSource = dt
                DataGridViewDetalleVenta.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewDetalleVenta.DataSource = Nothing
                DataGridViewDetalleVenta.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarDetalleVenta.Enabled = True
        BttGuardarDetalleVenta.Enabled = False
        BttQuitarArts.Enabled = False

    End Sub

    Private Sub ocultar_columnas()
        DataGridViewDetalleVenta.Columns(1).Visible = False
        DataGridViewDetalleVenta.Columns(2).Visible = False
        DataGridViewDetalleVenta.Columns(3).Visible = False
    End Sub




    'Proceso para limpiar los textbox cuando se registre un nuevo cliente
    Public Sub limpiar()
        txtIdMedicamento.Text = ""
        txtNombre_Medicamento.Text = ""
        txtPrecioUnitario.Text = ""
        txtCantidad.Text = 0
        txtStock.Text = 1

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "no_factura='" & txtno_factura.Text & "'"
            If dv.Count <> 0 Then
                linklblInexistente.Visible = False
                DataGridViewDetalleVenta.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewDetalleVenta.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Acciones al dar click al boton agregar
    Private Sub BttAgregarDetalleVenta_Click_1(sender As Object, e As EventArgs) Handles BttAgregarDetalleVenta.Click, BttAgregarDetalleVenta.Click
        limpiar()
        mostrar()
        txtno_factura.Enabled = False
        txtIdCliente.Enabled = False
        txtApellido1_cliente.Enabled = False
        txtApellido2_cliente.Enabled = False
        txtFecha_venta.Enabled = False
        cbFormaPago.Enabled = False
        txtIdMedicamento.Enabled = False
        txtNombre_Medicamento.Enabled = False
        txtCantidad.Enabled = True
        txtStock.Enabled = True
        txtPrecioUnitario.Enabled = True
        btnBuscar_Medicamento.Enabled = True
        BttQuitarArts.Enabled = True

    End Sub

    Private Sub BttGuardarVenta_Click_1(sender As Object, e As EventArgs) Handles BttGuardarDetalleVenta.Click
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtIdMedicamento.Text <> "" And txtStock.Text <> "" And txtCantidad.Text <> "" And txtPrecioUnitario.Text <> "" Then
            Try
                Dim dts As New vdetalle_factura
                Dim func As New fdetalle_factura

                dts.gno_factura = txtno_factura.Text
                dts.gidmedicamento = txtIdMedicamento.Text
                dts.gcantidad = txtCantidad.Text
                dts.gprecio_unitario = txtPrecioUnitario.Text


                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("Articulo fue añadido", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtno_factura.Enabled = False
                    txtIdCliente.Enabled = False
                    txtApellido1_cliente.Enabled = False
                    txtApellido2_cliente.Enabled = False
                    txtFecha_venta.Enabled = False
                    cbFormaPago.Enabled = False

                    'Acciones de botones
                    BttGuardarDetalleVenta.Enabled = False
                Else
                    MessageBox.Show("Articulo no fue añadido", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewDetalleVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDetalleVenta.CellContentClick
        If e.ColumnIndex = Me.DataGridViewDetalleVenta.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewDetalleVenta.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub BttQuitarArts_Click(sender As Object, e As EventArgs) Handles BttQuitarArts.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere quitar los articulos de la venta?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataGridViewDetalleVenta.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("correlativo").Value)
                        Dim vdb As New vdetalle_factura
                        Dim func As New fdetalle_factura
                        vdb.gcorrelativo = onekey

                        vdb.gidmedicamento = DataGridViewDetalleVenta.SelectedCells.Item(3).Value
                        vdb.gno_factura = DataGridViewDetalleVenta.SelectedCells.Item(2).Value
                        vdb.gcantidad = DataGridViewDetalleVenta.SelectedCells.Item(5).Value

                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) Then

                            End If
                            txtno_factura.Enabled = False
                            txtIdCliente.Enabled = False
                            txtApellido1_cliente.Enabled = False
                            txtApellido2_cliente.Enabled = False
                            txtFecha_venta.Enabled = False
                            cbFormaPago.Enabled = False
                        Else
                            MessageBox.Show("Articulo quitado", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtno_factura.Enabled = False
                            txtIdCliente.Enabled = False
                            txtApellido1_cliente.Enabled = False
                            txtApellido2_cliente.Enabled = False
                            txtFecha_venta.Enabled = False
                            cbFormaPago.Enabled = False
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando la eliminación de registros", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtno_factura.Enabled = False
            txtIdCliente.Enabled = False
            txtApellido1_cliente.Enabled = False
            txtApellido2_cliente.Enabled = False
            txtFecha_venta.Enabled = False
            cbFormaPago.Enabled = False
            Call mostrar()
        End If
        Call limpiar()
        BttAgregarDetalleVenta.Enabled = True
    End Sub

    Private Sub btnBuscar_Medicamento_Click(sender As Object, e As EventArgs) Handles btnBuscar_Medicamento.Click
        Dim frm As New FormMedicamentos
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim cant As Double
        cant = txtCantidad.Value
        If txtCantidad.Value > txtStock.Value Then
            MessageBox.Show("La cantidad que intenta vender, supera al stock", "Error en la venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BttGuardarDetalleVenta.Enabled = False
            txtCantidad.Value = txtStock.Value
        Else
            BttGuardarDetalleVenta.Enabled = True
        End If

        If txtCantidad.Value = 0 Then
            BttGuardarDetalleVenta.Enabled = False

        Else
            BttGuardarDetalleVenta.Enabled = True
        End If
    End Sub

    Private Sub cbeliminardetalleVenta_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminardetalleVenta.CheckedChanged
        If cbeliminardetalleVenta.CheckState = CheckState.Checked Then
            DataGridViewDetalleVenta.Columns.Item("Eliminar").Visible = True
            BttQuitarArts.Enabled = True
            BttAgregarDetalleVenta.Enabled = False
            BttGuardarDetalleVenta.Enabled = False
        Else
            DataGridViewDetalleVenta.Columns.Item("Eliminar").Visible = False
            BttQuitarArts.Enabled = False
            BttAgregarDetalleVenta.Enabled = True
            BttGuardarDetalleVenta.Enabled = False
            limpiar()
            txtCantidad.Enabled = False
            txtStock.Enabled = False
            txtPrecioUnitario.Enabled = False
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("La Cantidad solo debe contener números enteros", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
    '    e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    '    If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
    '        MessageBox.Show("El Stock solo debe contener números", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    'Private Sub txtPrecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnitario.KeyPress
    '    e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    '    If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
    '        MessageBox.Show("El Precio unitario solo debe contener números", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub








End Class