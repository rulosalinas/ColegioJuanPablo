Public Class vcursos
    Dim idcarrera, idcurso As Integer
    Dim nombrecurso As String

    Public Property gidcurso
        Get
            Return idcurso
        End Get
        Set(ByVal value)
            idcurso = value
        End Set
    End Property
    Public Property gidcarrera
        Get
            Return idcarrera
        End Get
        Set(ByVal value)
            idcarrera = value
        End Set
    End Property

    Public Property gnombrecurso
        Get
            Return nombrecurso
        End Get
        Set(ByVal value)
            nombrecurso = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcurso As Integer, ByVal idcarrera As Integer, ByVal nombrecurso As String)
        gidcurso = idcurso
        gidcarrera = idcarrera
        gnombrecurso = nombrecurso
    End Sub
End Class
