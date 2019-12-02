Public Class entEscuela
    Private _codEscuela
    Private _nombreEscuela
    Private _vacanteEscuela
    Private _inscritoEscuela
    Private _estadoEscuela

    Public Property codEscuela As Integer
        Get
            Return _codEscuela
        End Get
        Set(value As Integer)
            _codEscuela = value
        End Set
    End Property

    Public Property nombreEscuela As String
        Get
            Return _nombreEscuela
        End Get
        Set(value As String)
            _nombreEscuela = value
        End Set
    End Property

    Public Property vacanteEscuela As Integer
        Get
            Return _vacanteEscuela
        End Get
        Set(value As Integer)
            _vacanteEscuela = value
        End Set
    End Property

    Public Property inscritoEscuela As Integer
        Get
            Return _inscritoEscuela
        End Get
        Set(value As Integer)
            _inscritoEscuela = value
        End Set
    End Property

    Public Property estadoEscuela As Boolean
        Get
            Return _estadoEscuela
        End Get
        Set(value As Boolean)
            _estadoEscuela = value
        End Set
    End Property

End Class
