Public Class vniveles
    Dim idnivel As Integer
    Dim idinstitucion, nombrenivel As String
    Dim cuotanivel As Decimal

    Public Property gidnivel
        Get
            Return idnivel
        End Get
        Set(ByVal value)
            idnivel = value
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

    Public Property gnombrenivel
        Get
            Return nombrenivel
        End Get
        Set(ByVal value)
            nombrenivel = value
        End Set
    End Property

    Public Property gcuotanivel
        Get
            Return cuotanivel
        End Get
        Set(ByVal value)
            cuotanivel = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idnivel As Integer, ByVal idinstitucion As String, ByVal nombrenivel As String, ByVal cuotanivel As String)
        gidnivel = idnivel
        gidinstitucion = idinstitucion
        gnombrenivel = nombrenivel
        gcuotanivel = cuotanivel
    End Sub
End Class
