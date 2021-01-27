Public Class vtutor
    Dim dnitutor As Integer
    Dim apellidotutor, nombretutor, domtutor, localidadtutor, parentescotutor, teltutor, nomtutor2, teltutor2, nomtutor3, teltutor3 As String

    Public Property gdnitutor
        Get
            Return dnitutor
        End Get
        Set(ByVal value)
            dnitutor = value
        End Set
    End Property

    Public Property gapellidotutor
        Get
            Return apellidotutor
        End Get
        Set(ByVal value)
            apellidotutor = value
        End Set
    End Property
    Public Property gnombretutor
        Get
            Return nombretutor
        End Get
        Set(ByVal value)
            nombretutor = value
        End Set
    End Property

    Public Property gdomtutor
        Get
            Return domtutor
        End Get
        Set(ByVal value)
            domtutor = value
        End Set
    End Property

    Public Property gparentescotutor
        Get
            Return parentescotutor
        End Get
        Set(ByVal value)
            parentescotutor = value
        End Set
    End Property
    Public Property glocalidadtutor
        Get
            Return localidadtutor
        End Get
        Set(ByVal value)
            localidadtutor = value
        End Set
    End Property
    Public Property gteltutor
        Get
            Return teltutor
        End Get
        Set(ByVal value)
            teltutor = value
        End Set
    End Property
    Public Property gnomtutor2
        Get
            Return nomtutor2
        End Get
        Set(ByVal value)
            nomtutor2 = value
        End Set
    End Property
    Public Property gteltutor2
        Get
            Return teltutor2
        End Get
        Set(ByVal value)
            teltutor2 = value
        End Set
    End Property
    Public Property gnomtutor3
        Get
            Return nomtutor3
        End Get
        Set(ByVal value)
            nomtutor3 = value
        End Set
    End Property
    Public Property gteltutor3
        Get
            Return teltutor3
        End Get
        Set(ByVal value)
            teltutor3 = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal dnitutor As Integer, ByVal apellidotutor As String, ByVal nombretutor As String, ByVal domtutor As String, ByVal parentescotutor As String, ByVal localidadtutor As String, ByVal teltutor As String, ByVal nomtutor2 As String, ByVal teltutor2 As String, ByVal nomtutor3 As String, ByVal teltutor3 As String)
        gdnitutor = dnitutor
        gapellidotutor = apellidotutor
        gnombretutor = nombretutor
        gdomtutor = domtutor
        gparentescotutor = parentescotutor
        glocalidadtutor = localidadtutor
        gteltutor = teltutor
        gnomtutor2 = nomtutor2
        gteltutor2 = teltutor2
        gnomtutor3 = nomtutor3
        teltutor3 = nomtutor3
    End Sub
End Class
