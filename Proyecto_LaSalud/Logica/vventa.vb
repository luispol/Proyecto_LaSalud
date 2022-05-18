Public Class vventa
    Dim no_factura, idcliente As Integer
    Dim fecha_venta As Date
    Dim forma_pago As String

    Public Property gno_factura
        Get
            Return no_factura
        End Get
        Set(value)
            no_factura = value
        End Set
    End Property

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property

    Public Property gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(value)
            fecha_venta = value
        End Set
    End Property

    Public Property gforma_pago
        Get
            Return forma_pago
        End Get
        Set(value)
            forma_pago = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal no_factura As Integer, ByVal idcliente As Integer, ByVal fecha_venta As Date, ByVal forma_pago As String)
        gno_factura = no_factura
        gidcliente = idcliente
        gfecha_venta = fecha_venta
        gforma_pago = forma_pago
    End Sub








End Class
