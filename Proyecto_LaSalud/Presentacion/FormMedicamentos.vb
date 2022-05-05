Public Class FormMedicamentos
    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO DE MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarMedicamento_MouseHover(sender As Object, e As EventArgs) Handles PicBxEditarMedicamento.MouseHover
        ToolTipMedicamentos.SetToolTip(PicBxAgregarMedicamento, "Editar el registro del Medicamento")
        ToolTipMedicamentos.ToolTipTitle = "Editar"
        ToolTipMedicamentos.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarMedicamento_MouseHover(sender As Object, e As EventArgs) Handles PicBxAgregarMedicamento.MouseHover
        ToolTipMedicamentos.SetToolTip(PicBxAgregarMedicamento, "Agregar el registro del Medicamento")
        ToolTipMedicamentos.ToolTipTitle = "Agregar"
        ToolTipMedicamentos.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarMedicamento_MouseHover(sender As Object, e As EventArgs) Handles PicBxGuardarMedicamento.MouseHover
        ToolTipMedicamentos.SetToolTip(PicBxAgregarMedicamento, "Guardar el registro del Medicamento")
        ToolTipMedicamentos.ToolTipTitle = "Guardar"
        ToolTipMedicamentos.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO DEL MEDICAMENTO (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarMedicamento_MouseHover(sender As Object, e As EventArgs) Handles PicBxEliminarMedicamento.MouseHover
        ToolTipMedicamentos.SetToolTip(PicBxAgregarMedicamento, "Eliminar el registro del Medicamento")
        ToolTipMedicamentos.ToolTipTitle = "Eliminar"
        ToolTipMedicamentos.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class