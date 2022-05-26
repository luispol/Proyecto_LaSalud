Public Class vusuario
    Dim idusuario As Integer
    Dim nombres, primerapellido, segundoapellido, tercerapellido, DUI, direccion, correo, telefono, login, password, acceso As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(value)
            nombres = value
        End Set
    End Property

    Public Property gprimerapellido
        Get
            Return primerapellido
        End Get
        Set(value)
            primerapellido = value
        End Set
    End Property

    Public Property gsegundoapellido
        Get
            Return segundoapellido
        End Get
        Set(value)
            segundoapellido = value
        End Set
    End Property

    Public Property gtercerapellido
        Get
            Return tercerapellido
        End Get
        Set(value)
            tercerapellido = value
        End Set
    End Property

    Public Property gDUI
        Get
            Return DUI
        End Get
        Set(value)
            DUI = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(value)
            correo = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)
            acceso = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer,
                   ByVal nombres As String,
                   ByVal primerapellido As String,
                   ByVal segundoapellido As String,
                   ByVal tercerapellido As String,
                   ByVal DUI As String,
                   ByVal direccion As String,
                   ByVal correo As String,
                   ByVal telefono As String,
                   ByVal login As String,
                   ByVal password As String,
                   ByVal acceso As String)

        gidusuario = idusuario
        gnombres = nombres
        gprimerapellido = primerapellido
        gsegundoapellido = segundoapellido
        gtercerapellido = tercerapellido
        gDUI = DUI
        gdireccion = direccion
        gcorreo = correo
        gtelefono = telefono
        glogin = login
        gpassword = password
        gacceso = acceso


    End Sub

End Class
