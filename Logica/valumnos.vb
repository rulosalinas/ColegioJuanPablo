Imports System.Data.SqlClient
Public Class valumnos
    Dim idalumno, dnitutor As Integer
    Dim apellidos, nombres, dni, domicilio, localidad, sexo, telefono, motivobaja As String '--variavles en os que se guarda los datos alunno
    Dim fnacimiento, falta, fbaja As Date
    Dim estado As String
    'seeter y getter --precedimiento para ver y capturar datos

    Public Property gidalumno
        Get
            Return idalumno
        End Get
        Set(ByVal value)
            idalumno = value
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

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property

    Public Property gfnacimiento
        Get
            Return fnacimiento
        End Get
        Set(ByVal value)
            fnacimiento = value
        End Set
    End Property

    Public Property gdomicilio
        Get
            Return domicilio
        End Get
        Set(ByVal value)
            domicilio = value
        End Set
    End Property

    Public Property glocalidad
        Get
            Return localidad
        End Get
        Set(ByVal value)
            localidad = value
        End Set
    End Property

    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(ByVal value)
            sexo = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gfalta
        Get
            Return falta
        End Get
        Set(ByVal value)
            falta = value
        End Set
    End Property

    Public Property gestado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set
    End Property

    Public Property gfbaja
        Get
            Return fbaja
        End Get
        Set(ByVal value)
            fbaja = value
        End Set
    End Property

    Public Property gmotivobaja
        Get
            Return motivobaja
        End Get
        Set(ByVal value)
            motivobaja = value
        End Set
    End Property
    Public Property gdnitutor
        Get
            Return dnitutor
        End Get
        Set(ByVal value)
            dnitutor = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idalumno As Integer, ByVal dnitutor As Integer, ByVal apellidos As String,
                   ByVal nombres As String, ByVal dni As String, ByVal domicilio As String, ByVal localidad As String,
                   ByVal sexo As String, ByVal telefono As String, ByVal motivobaja As String, ByVal fnacimiento As Date,
                   ByVal falta As Date, ByVal fbaja As Date, ByVal estado As String)
        gidalumno = idalumno
        gdnitutor = dnitutor
        gapellidos = apellidos
        gnombres = nombres
        gdni = dni
        gdomicilio = domicilio
        glocalidad = localidad
        gsexo = sexo
        gtelefono = telefono
        gmotivobaja = motivobaja
        gfnacimiento = fnacimiento
        gfalta = falta
        gfbaja = fbaja
        gestado = estado
    End Sub
End Class

