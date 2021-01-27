Public Class vcarreras
    Dim idcarrera, idnivel, duracion As Integer
    Dim nombrecarrera, resolucion, idinstitucion As String
    Public Property gidcarrera
        Get
            Return idcarrera
        End Get
        Set(ByVal value)
            idcarrera = value
        End Set
    End Property
    Public Property gidnivel
        Get
            Return idnivel
        End Get
        Set(ByVal value)
            idnivel = value
        End Set
    End Property

    Public Property gnombrecarrera
        Get
            Return nombrecarrera
        End Get
        Set(ByVal value)
            nombrecarrera = value
        End Set
    End Property

    Public Property gresolucion
        Get
            Return resolucion
        End Get
        Set(ByVal value)
            resolucion = value
        End Set
    End Property
    Public Property gduracion
        Get
            Return duracion
        End Get
        Set(ByVal value)
            duracion = value
        End Set
    End Property
    Public Property gidinstitucion
        Get
            Return idinstitucion
        End Get
        Set(ByVal value)
            idinstitucion = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcarrera As Integer, ByVal idnivel As Integer, ByVal idinstitucion As String, ByVal nombrecarrera As String, ByVal resolucion As String, ByVal duracion As Integer)
        gidcarrera = idcarrera
        gidnivel = idnivel
        gnombrecarrera = nombrecarrera
        gresolucion = resolucion
        gduracion = duracion
        gidinstitucion = idinstitucion
    End Sub
End Class
