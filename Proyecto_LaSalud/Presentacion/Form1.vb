Public Class FormClientes
    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarClientes_MouseHover(sender As Object, e As EventArgs) Handles PicBxEditarClientes.MouseHover
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Editar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Editar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarCliente_MouseHover(sender As Object, e As EventArgs) Handles PicBxGuardarCliente.MouseHover
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Guardar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Guardar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarCliente_MouseHover(sender As Object, e As EventArgs) Handles PicBxAgregarCliente.MouseHover
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Agregar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Agregar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO CLIENTE (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarCliente_MouseHover(sender As Object, e As EventArgs) Handles PicBxEliminarCliente.MouseHover
        ToolTipCliente.SetToolTip(PicBxAgregarCliente, "Eliminar el registro del cliente")
        ToolTipCliente.ToolTipTitle = "Eliminar"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON DE VER REGISTROS DE CLIENTE 
    Private Sub PicBx2RegistrosdeCliente_MouseHover(sender As Object, e As EventArgs) Handles PicBx2RegistrosdeCliente.MouseHover
        ToolTipCliente.SetToolTip(PicBx2RegistrosdeCliente, "Ver los registros del cliente")
        ToolTipCliente.ToolTipTitle = "Registros de Cliente"
        ToolTipCliente.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private dt As New DataTable

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    'Proceso para mostar los datos en la tabla
    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar()
            DataGridViewClientes.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewClientes.DataSource = dt
                txtBusquedaClientes.Enabled = True
                DataGridViewClientes.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewClientes.DataSource = Nothing
                txtBusquedaClientes.Enabled = False
                DataGridViewClientes.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarCliente.Visible = True
        BttGuardarCliente.Visible = False
        BttEditarCliente.Visible = False

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
                DataGridViewClientes.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewClientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        DataGridViewClientes.Columns(1).Visible = False
    End Sub


End Class