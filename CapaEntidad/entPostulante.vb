Public Class entPostulante
    Private _codPostulante
    Private _nombrePostulante
    Private _apellidoPostulante
    Public objentEscuela As New entEscuela
    Private _direccionPostulante
    Private _telefonoPostulante
    Private _fechanacimientoPostulante
    Private _sexoPostulante

    Public Property codPostulante As Integer
        Get
            Return _codPostulante
        End Get
        Set(value As Integer)
            _codPostulante = value
        End Set
    End Property

    Public Property nombrePostulante As String
        Get
            Return _nombrePostulante
        End Get
        Set(value As String)
            _nombrePostulante = value
        End Set
    End Property

    Public Property apellidoPostulante As String
        Get
            Return _apellidoPostulante
        End Get
        Set(value As String)
            _apellidoPostulante = value
        End Set
    End Property

    Public Property direccionPostulante As String
        Get
            Return _direccionPostulante
        End Get
        Set(value As String)
            _direccionPostulante = value
        End Set
    End Property

    Public Property telefonoPostulante As String
        Get
            Return _telefonoPostulante
        End Get
        Set(value As String)
            _telefonoPostulante = value
        End Set
    End Property

    Public Property fechanacimientoPostulante As Date
        Get
            Return _fechanacimientoPostulante
        End Get
        Set(value As Date)
            _fechanacimientoPostulante = value
        End Set
    End Property

    Public Property sexoPostulante As String
        Get
            Return _sexoPostulante
        End Get
        Set(value As String)
            _sexoPostulante = value
        End Set
    End Property
    Public Sub New()
        objentEscuela = New entEscuela
    End Sub
End Class
