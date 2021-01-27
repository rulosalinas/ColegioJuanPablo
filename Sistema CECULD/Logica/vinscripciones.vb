Imports System.Data.SqlClient
Public Class vinscripciones

    Dim idinscripcion, idalumno, idcarrera, idnivel, idcurso, iddivision As Integer
    Dim dni, apellidos, nombres, idinstitucion, institucion, nivel, carrera, curso, division As String '--variavles en os que se guarda los datos alunno
    Dim finscripcion As Date

    'seeter y getter --precedimiento para ver y capturar datos

    Public Property gidinscripcion
        Get
            Return idinscripcion
        End Get
        Set(ByVal value)
            idinscripcion = value
        End Set
    End Property
    Public Property gidalumno
        Get
            Return idalumno
        End Get
        Set(ByVal value)
            idalumno = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
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

    Public Property ginstitucion
        Get
            Return institucion
        End Get
        Set(ByVal value)
            institucion = value
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
    Public Property gnivel
        Get
            Return nivel
        End Get
        Set(ByVal value)
            nivel = value
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
    Public Property gcarrera
        Get
            Return carrera
        End Get
        Set(ByVal value)
            carrera = value
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
    Public Property gcurso
        Get
            Return curso
        End Get
        Set(ByVal value)
            curso = value
        End Set
    End Property
    Public Property giddivision
        Get
            Return iddivision
        End Get
        Set(ByVal value)
            iddivision = value
        End Set
    End Property
    Public Property gdivision
        Get
            Return division
        End Get
        Set(ByVal value)
            division = value
        End Set
    End Property
    Public Property gfinscripcion
        Get
            Return finscripcion
        End Get
        Set(ByVal value)
            finscripcion = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idinscripcion As Integer, ByVal idalumno As Integer, ByVal idnivel As Integer, ByVal idcarrera As Integer, ByVal dni As String,
                   ByVal idcurso As Integer, ByVal iddivision As Integer, ByVal idinstitucion As String, ByVal apellidos As String, ByVal nombres As String,
                   ByVal institucion As String, ByVal nivel As String, ByVal carrera As String, ByVal curso As String, ByVal division As String,
                   ByVal finscripcion As Date)

        gidinscripcion = idinscripcion
        gidalumno = idalumno
        gdni = dni
        gnombres = nombres
        gapellidos = apellidos
        gidinstitucion = idinstitucion
        ginstitucion = institucion
        gidnivel = idnivel
        gnivel = nivel
        gidcarrera = idcarrera
        gcarrera = carrera
        gidcurso = curso
        giddivision = iddivision
        gdivision = division
        gfinscripcion = finscripcion
    End Sub
End Class

