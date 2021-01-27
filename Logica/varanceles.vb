Public Class varanceles
    Dim idarancel As Integer
    Dim idinstitucion, nombrearancel As String
    Dim precioarancel As Double


    Public Property gidarancel
        Get
            Return idarancel
        End Get
        Set(ByVal value)
            idarancel = value
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
    Public Property gnombrearancel
        Get
            Return nombrearancel
        End Get
        Set(ByVal value)
            nombrearancel = value
        End Set
    End Property

    Public Property gprecioarancel
        Get
            Return precioarancel
        End Get
        Set(ByVal value)
            precioarancel = value
        End Set
    End Property

    'constructores

    Public Sub New()

        End Sub

    Public Sub New(ByVal idarancel As Integer, ByVal idinstitucion As String, ByVal nombrearancel As String, ByVal precioarancel As Double)
        gidarancel = idarancel
        gidinstitucion = idinstitucion
        gnombrearancel = nombrearancel
        gprecioarancel = precioarancel
    End Sub

End Class
