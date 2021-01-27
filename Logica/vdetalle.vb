Public Class vdetalle
    Dim iddetalle, idpago, idarancel, cantidad As Integer
    Dim precio, descuento, recargo, total As Double
    Public Property giddetalle
        Get
            Return iddetalle
        End Get
        Set(value)
            iddetalle = value
        End Set
    End Property
    Public Property gidpago
        Get
            Return idpago
        End Get
        Set(value)
            idpago = value
        End Set
    End Property

    Public Property gidarancel
        Get
            Return idarancel
        End Get
        Set(value)
            idarancel = value
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
    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property
    Public Property gdescuento
        Get
            Return descuento
        End Get
        Set(value)
            descuento = value
        End Set
    End Property
    Public Property grecargo
        Get
            Return recargo
        End Get
        Set(value)
            recargo = value
        End Set
    End Property
    Public Property gtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpago As Integer, ByVal iddetalle As Integer, ByVal cantidad As Integer, ByVal idarancel As Integer, ByVal precio As Double, ByVal descuento As Double, ByVal recargo As Double, ByVal total As Double)
        gidpago = idpago
        giddetalle = iddetalle
        gidarancel = idarancel
        gcantidad = cantidad
        gprecio = precio
        gdescuento = descuento
        grecargo = recargo
        gtotal = total

    End Sub
End Class
