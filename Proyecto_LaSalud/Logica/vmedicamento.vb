Public Class vmedicamento
    Dim idmedicamento, idcategoria As Integer
    Dim nombre, descripcion As String
    Dim stock, precio_compra, precio_venta As Double
    Dim fecha_vencimiento As Date
    Dim imagen() As Byte

    Public Property gidmedicamento
        Get
            Return idmedicamento
        End Get
        Set(value)
            idmedicamento = value
        End Set
    End Property

    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(value)
            idcategoria = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property gstock
        Get
            Return stock
        End Get
        Set(value)
            stock = value
        End Set
    End Property

    Public Property gprecio_compra
        Get
            Return precio_compra
        End Get
        Set(value)
            precio_compra = value
        End Set
    End Property

    Public Property gprecio_venta
        Get
            Return precio_venta
        End Get
        Set(value)
            precio_venta = value
        End Set
    End Property

    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(value)
            fecha_vencimiento = value
        End Set
    End Property

    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                    ByVal idmedicamento As Integer,
                    ByVal idcategoria As Integer,
                    ByVal nombre As String,
                    ByVal descripcion As String,
                    ByVal stock As Double,
                    ByVal precio_venta As Double,
                    ByVal precio_compra As Double,
                    ByVal fecha_vencimiento As Date,
                    ByVal imagen As Byte)

        gidmedicamento = idmedicamento
        gidcategoria = idcategoria
        gnombre = nombre
        gdescripcion = descripcion
        gstock = stock
        gprecio_venta = precio_venta
        gprecio_compra = precio_compra
        gfecha_vencimiento = fecha_vencimiento
        gimagen = imagen

    End Sub
End Class
