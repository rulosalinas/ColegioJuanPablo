Public Class vdivisiones
    Dim iddivision, idcurso As Integer
    Dim nombredivision As String


    Public Property giddivision
        Get
            Return iddivision
        End Get
        Set(ByVal value)
            iddivision = value
        End Set
    End Property
    Public Property gidcurso
        Get
            Return idcurso
        End Get
        Set(ByVal value)
            idcurso = value
        End Set
    End Property

    Public Property gnombredivision
        Get
            Return nombredivision
        End Get
        Set(ByVal value)
            nombredivision = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal iddivision As Integer, ByVal idcurso As Integer, ByVal nombredivision As String)
        giddivision = iddivision
        gidcurso = idcurso
        gnombredivision = nombredivision
    End Sub
End Class
