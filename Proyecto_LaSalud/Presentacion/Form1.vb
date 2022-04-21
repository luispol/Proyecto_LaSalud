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


End Class