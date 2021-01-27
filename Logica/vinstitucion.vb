Public Class vinstitucion
    Dim id_inst As Integer
    Dim nombre_inst, domicilio_inst, cuit_inst, logo_inst As String

    'seeter y getter
    Public Property gid_inst
        Get
            Return id_inst
        End Get
        Set(ByVal value)
            id_inst = value
        End Set
    End Property

    Public Property gnombre_inst
        Get
            Return nombre_inst
        End Get
        Set(ByVal value)
            nombre_inst = value
        End Set
    End Property

    Public Property gdomicilio_inst
        Get
            Return domicilio_inst
        End Get
        Set(ByVal value)
            domicilio_inst = value
        End Set
    End Property

    Public Property gcuit_inst
        Get
            Return cuit_inst
        End Get
        Set(ByVal value)
            cuit_inst = value
        End Set
    End Property
    Public Property glogo_inst
        Get
            Return logo_inst
        End Get
        Set(ByVal value)
            logo_inst = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_inst As Integer, ByVal nombre_inst As String, ByVal domicilio_inst As String, ByVal cuit_inst As String, ByVal logo_inst As String)
        gid_inst = id_inst
        gnombre_inst = nombre_inst
        gdomicilio_inst = domicilio_inst
        gcuit_inst = cuit_inst
        glogo_inst = logo_inst
    End Sub

End Class
