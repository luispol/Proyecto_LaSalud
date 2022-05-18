Public Class vdetalle_factura
    Dim correlativo, no_factura, idmedicamento As Integer
    Dim cantidad, precio_unitario As Double

    Public Property gcorrelativo
        Get
            Return correlativo
        End Get
        Set(value)
            correlativo = value
        End Set
    End Property

    Public Property gno_factura
        Get
            Return no_factura
        End Get
        Set(value)
            no_factura = value
        End Set
    End Property

    Public Property gidmedicamento
        Get
            Return idmedicamento
        End Get
        Set(value)
            idmedicamento = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property

    Public Property gprecio_unitario
        Get
            Return precio_unitario
        End Get
        Set(value)
            precio_unitario = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal correlativo As Integer,
                   ByVal no_factura As Integer,
                   ByVal idmedicamento As Integer,
                   ByVal cantidad As Double,
                   ByVal precio_unitario As Double)

        gcorrelativo = correlativo
        gno_factura = no_factura
        gidmedicamento = idmedicamento
        gcantidad = cantidad
        gprecio_unitario = precio_unitario

    End Sub



End Class
