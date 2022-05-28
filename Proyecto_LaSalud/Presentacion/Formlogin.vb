Public Class Formlogin

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub bttSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub bttIngresar_Click(sender As Object, e As EventArgs) Handles bttIngresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtUsuario.Text
            dts.gpassword = txtContrasena.Text

            If func.validar_usuario(dts) = True Then
                FormPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente las credenciales correctas", MsgBoxStyle.Information, "Acceso denegado")
                txtContrasena.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class