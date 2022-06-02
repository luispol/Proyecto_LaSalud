Public Class FormCategorias


    Private dt As New DataTable
    'Proceso al momento de carga del formulario categorias
    Private Sub FormCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtIdCategoria.Enabled = False
        txtNombreCategoria.Enabled = False
    End Sub

    'Proceso para mostar los datos en la tabla
    Private Sub mostrar()
        Try
            Dim func As New fcategoria
            dt = func.mostrar()
            DataGridViewCategoria.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewCategoria.DataSource = dt
                txtBusquedaCategoria.Enabled = True
                DataGridViewCategoria.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewCategoria.DataSource = Nothing
                txtBusquedaCategoria.Enabled = False
                DataGridViewCategoria.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BttAgregarCategoria.Enabled = True
        BttGuardarCategoria.Enabled = False
        BttEditarCategoria.Enabled = False
        BttEditarCategoria.Visible = True
        BttEliminarCategoria.Enabled = False
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampoCategoria.Text & " like '" & txtBusquedaCategoria.Text & "%'"
            If dv.Count <> 0 Then
                linklblInexistente.Visible = False
                DataGridViewCategoria.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewCategoria.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        DataGridViewCategoria.Columns(1).Visible = False
    End Sub

    'Procesos de los textbox para capturar la informacion de la categoria
    Private Sub txtNombreCategoria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreCategoria.Validating
        'Revisamos si la caja de texto tiene caracteres de informacion o no
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de la categoría, es un dato obligatorio.")
        End If
    End Sub

    'Proceso para limpiar los textbox cuando se registre un nuevo cliente
    Public Sub limpiar()
        txtIdCategoria.Text = ""
        txtNombreCategoria.Text = ""
    End Sub
    'Acciones al dar click al boton agregar
    Private Sub BttAgregarCategoria_Click(sender As Object, e As EventArgs) Handles BttAgregarCategoria.Click
        limpiar()
        mostrar()
        'Habilitar el boton guardar
        BttGuardarCategoria.Enabled = True
        'activiacion de los textboxs
        txtIdCategoria.Enabled = False
        txtNombreCategoria.Enabled = True

    End Sub

    Private Sub BttGuardarCategoria_Click(sender As Object, e As EventArgs) Handles BttGuardarCategoria.Click
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtNombreCategoria.Text <> "" Then
            Try
                Dim dts As New vcategoria
                Dim func As New fcategoria
                dts.gnombre_categoria = txtNombreCategoria.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Categoría registrada correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtIdCategoria.Enabled = False
                    txtNombreCategoria.Enabled = False

                    'Acciones de botones
                    BttGuardarCategoria.Enabled = False
                Else
                    MessageBox.Show("Categoría no registrada", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub DataGridViewCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCategoria.CellClick

        'MessageBox.Show("Edite los datos y para confirmar, pulse el botón EDITAR", "Editar registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Cajas de texto
        txtIdCategoria.Text = DataGridViewCategoria.SelectedCells.Item(1).Value
        txtNombreCategoria.Text = DataGridViewCategoria.SelectedCells.Item(2).Value

        'Habilitar el boton Editar
        BttEditarCategoria.Enabled = True

        'Desabilitar el boton Agregar, Guardar, Eliminar
        BttAgregarCategoria.Enabled = False
        BttGuardarCategoria.Enabled = False
        BttEliminarCategoria.Enabled = False


        'Habilitar los Text Box
        txtIdCategoria.Enabled = False
        txtNombreCategoria.Enabled = True

    End Sub

    'BOTON EDITAR
    Private Sub BBttEditarCategoria_Click(sender As Object, e As EventArgs) Handles BttEditarCategoria.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere editar el dato de la categoría?", "Modicando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'Condicion para validar que se hayan registrado datos en texboxs especificos
            If Me.ValidateChildren = True And txtNombreCategoria.Text <> "" And txtIdCategoria.Text <> "" Then
                Try
                    Dim dts As New vcategoria
                    Dim func As New fcategoria

                    dts.gidcategoria = txtIdCategoria.Text
                    dts.gnombre_categoria = txtNombreCategoria.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Categoría modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtIdCategoria.Enabled = False
                        txtNombreCategoria.Enabled = False
                        cbeliminar.Checked = False
                        limpiar()
                    Else
                        MessageBox.Show("Dato no modificados", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falto ingresar datos obligatorios", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIdCategoria.Enabled = False
                txtNombreCategoria.Enabled = False

                limpiar()
            End If
        Else
            MessageBox.Show("Cancelando los cambios del registro", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdCategoria.Enabled = False
            txtNombreCategoria.Enabled = False
            cbeliminar.Checked = False
            Call mostrar()
        End If
        limpiar()
        BttAgregarCategoria.Enabled = True
        BttGuardarCategoria.Enabled = False
        BttEditarCategoria.Enabled = False
        BttEliminarCategoria.Enabled = False
    End Sub

    'Proceso para que muestre la columna que contiene los checkbox para seleccionar el registro a eliminar
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            DataGridViewCategoria.Columns.Item("Eliminar").Visible = True
            BttEliminarCategoria.Enabled = True
            BttAgregarCategoria.Enabled = False
            BttEditarCategoria.Enabled = False
            BttGuardarCategoria.Enabled = False
        Else
            DataGridViewCategoria.Columns.Item("Eliminar").Visible = False
            BttEliminarCategoria.Enabled = False
            BttAgregarCategoria.Enabled = True
            BttEditarCategoria.Enabled = False
            BttGuardarCategoria.Enabled = False
            limpiar()
            txtIdCategoria.Enabled = False
            txtNombreCategoria.Enabled = False

        End If

    End Sub
    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCategoria.CellContentClick
        If e.ColumnIndex = Me.DataGridViewCategoria.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewCategoria.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            BttEliminarCategoria.Enabled = True
        End If
    End Sub
    'BOTON ELIMINAR
    Private Sub BttEliminarCategoria_Click(sender As Object, e As EventArgs) Handles BttEliminarCategoria.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere eliminar a las categorias seleccionadas?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataGridViewCategoria.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcategoria").Value)
                        Dim vdb As New vcategoria
                        Dim func As New fcategoria
                        vdb.gidcategoria = onekey

                        If func.eliminar(vdb) Then
                            cbeliminar.Checked = False
                            txtIdCategoria.Enabled = False
                            txtNombreCategoria.Enabled = False


                        Else
                            MessageBox.Show("Categoría no fue eliminada", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cbeliminar.Checked = False
                            txtIdCategoria.Enabled = False
                            txtNombreCategoria.Enabled = False

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
            txtIdCategoria.Enabled = False
            txtNombreCategoria.Enabled = False

            Call mostrar()
        End If
        Call limpiar()
        BttAgregarCategoria.Enabled = True
    End Sub

    '(CODIGO) MOSTRAR UN MENSAJE DE AYUDA PARA EL USUARIO

    'BOTON EDITAR REGISTRO CATEGORIA (ACCIONES DE REGSITRO)
    Private Sub PicBxEditarCategoria_MouseHover(sender As Object, e As EventArgs) Handles PicBxEditarCategoria.MouseHover
        ToolTipCategoria.SetToolTip(PicBxAgregarCategoria, "Editar el registro de la categoría")
        ToolTipCategoria.ToolTipTitle = "Editar"
        ToolTipCategoria.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON GUARDAR REGISTRO CATEGORIA (ACCIONES DE REGSITRO)
    Private Sub PicBxGuardarCategoria_MouseHover(sender As Object, e As EventArgs) Handles PicBxGuardarCategoria.MouseHover
        ToolTipCategoria.SetToolTip(PicBxAgregarCategoria, "Guardar el registro de la categoría")
        ToolTipCategoria.ToolTipTitle = "Guardar"
        ToolTipCategoria.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON AGREGAR REGISTRO CATEGORIA (ACCIONES DE REGSITRO)
    Private Sub PicBxAgregarCategoria_MouseHover(sender As Object, e As EventArgs) Handles PicBxAgregarCategoria.MouseHover
        ToolTipCategoria.SetToolTip(PicBxAgregarCategoria, "Agregar el registro de la categoría")
        ToolTipCategoria.ToolTipTitle = "Agregar"
        ToolTipCategoria.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'BOTON ELIMINAR REGISTRO CATEGORIA (ACCIONES DE REGSITRO)
    Private Sub PicBxEliminarCategoria_MouseHover(sender As Object, e As EventArgs) Handles PicBxEliminarCategoria.MouseHover
        ToolTipCategoria.SetToolTip(PicBxEliminarCategoria, "Eliminar el registro de la categoría")
        ToolTipCategoria.ToolTipTitle = "Eliminar"
        ToolTipCategoria.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub DataGridViewCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCategoria.CellDoubleClick
        Dim frm As FormMedicamentos = CType(Owner, FormMedicamentos)
        frm.txtidCategoria_med.Text = DataGridViewCategoria.CurrentRow.Cells(1).Value
        frm.txtNom_Categoria.Text = DataGridViewCategoria.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub

    Private Sub txtBusquedaCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCategoria.TextChanged
        buscar()
    End Sub
    'VALIDACION DE TEXT BOX
    Private Sub txtNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCategoria.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MessageBox.Show("El nombre de la categoría no debe contener números", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
        txtIdCategoria.Enabled = False
        txtNombreCategoria.Enabled = False
    End Sub
End Class