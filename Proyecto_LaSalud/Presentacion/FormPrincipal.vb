Public Class FormPrincipal

    'PROCEDIMIENTOS PARA BOTONES:
    'Procesos para el boton Clientes
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormulario(Of FormClientes)()
        btnClientes.BackColor = Color.FromArgb(12, 61, 92)
        btnVentas.BackColor = Color.FromArgb(4, 41, 68)
        btnMedicamentos.BackColor = Color.FromArgb(4, 41, 68)
        btnCategorias.BackColor = Color.FromArgb(4, 41, 68)
    End Sub

    'Proceso para el boton Medicamentos
    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        AbrirFormulario(Of FormMedicamentos)()
        btnMedicamentos.BackColor = Color.FromArgb(12, 61, 92)
        btnClientes.BackColor = Color.FromArgb(4, 41, 68)
        btnVentas.BackColor = Color.FromArgb(4, 41, 68)
        btnCategorias.BackColor = Color.FromArgb(4, 41, 68)
    End Sub

    'Proceso para el boton ventas
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormulario(Of FormVentas)()
        btnVentas.BackColor = Color.FromArgb(12, 61, 92)
        btnClientes.BackColor = Color.FromArgb(4, 41, 68)
        btnMedicamentos.BackColor = Color.FromArgb(4, 41, 68)
        btnCategorias.BackColor = Color.FromArgb(4, 41, 68)
    End Sub

    'Proceso para el boton categorias
    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        AbrirFormulario(Of FormCategorias)()
        btnCategorias.BackColor = Color.FromArgb(12, 61, 92)
        btnClientes.BackColor = Color.FromArgb(4, 41, 68)
        btnMedicamentos.BackColor = Color.FromArgb(4, 41, 68)
        btnVentas.BackColor = Color.FromArgb(4, 41, 68)
    End Sub



    'Proceso para abrir formularios
    Private Sub AbrirFormulario(Of Miform As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si formulario no fue encontrado no existe
        If formulario Is Nothing Then
            formulario = New Miform()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub


End Class
