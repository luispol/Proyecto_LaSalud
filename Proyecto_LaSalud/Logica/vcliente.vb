Public Class vcliente
    Dim idcliente As Integer

    Dim DUI, nombres, primerapellido, segundoapellido, tercerapellido, direccion, correo, telefono As String

    'METODOS SEETERS Y GETTERS

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
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

    'CONSTRUCTORES

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal DUI As String, ByVal primerapellido As String, ByVal segundoapellido As String, ByVal tercerapellido As String, ByVal direccion As String, ByVal correo As String, ByVal telefono As String)
        gidcliente = idcliente
        gnombres = nombres
        gDUI = DUI
        gprimerapellido = primerapellido
        gsegundoapellido = segundoapellido
        gtercerapellido = tercerapellido
        gdireccion = direccion
        gcorreo = correo
        gtelefono = telefono

    End Sub

End Class
