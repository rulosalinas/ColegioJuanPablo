Public Class vpagos
    Dim idpago, idinscripcion, idusuario, numcomprobante As Integer
    Dim tipocomprobante, formapago As String
    Dim fpago, horapago As Date
    Dim totalpago As Double

    Public Property gidpago
        Get
            Return idpago
        End Get
        Set(value)
            idpago = value
        End Set
    End Property

    Public Property gidinscripcion
        Get
            Return idinscripcion
        End Get
        Set(value)
            idinscripcion = value
        End Set
    End Property

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property
    Public Property gtipocomprobante
        Get
            Return tipocomprobante
        End Get
        Set(value)
            tipocomprobante = value
        End Set
    End Property
    Public Property gnumcomprobante
        Get
            Return numcomprobante
        End Get
        Set(value)
            numcomprobante = value
        End Set
    End Property
    Public Property gfpago
        Get
            Return fpago
        End Get
        Set(value)
            fpago = value
        End Set
    End Property
    Public Property ghorapago
        Get
            Return horapago
        End Get
        Set(value)
            horapago = value
        End Set
    End Property
    Public Property gformapago
        Get
            Return formapago
        End Get
        Set(value)
            formapago = value
        End Set
    End Property
    Public Property gtotalpago
        Get
            Return totalpago
        End Get
        Set(value)
            totalpago = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpago As Integer, ByVal idinscripcion As Integer, ByVal idusuario As Integer, ByVal numcomprobante As Integer,
                    ByVal tipocomprobante As String, ByVal formapago As String,
                    ByVal fpago As Date, ByVal horapago As Date, ByVal totalpago As Double)
        gidpago = idpago
        gidinscripcion = idinscripcion
        gidusuario = idusuario
        gnumcomprobante = numcomprobante
        gtipocomprobante = tipocomprobante
        gformapago = formapago
        gfpago = fpago
        ghorapago = horapago
        gtotalpago = totalpago

    End Sub


End Class
