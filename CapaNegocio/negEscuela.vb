Imports CapaDatos
Imports CapaEntidad
Public Class negEscuela
    Dim objentEscuela As New entEscuela
    Dim objdatEscuela As New datEscuela
    Public Function listarActivosEscuela() As DataTable
        Return objdatEscuela.listarActivosEscuela()
    End Function

    Public Function nuevoEscuela(objentEscuela) As Boolean
        If objentEscuela.vacanteEscuela >= 20 Then
            Return objdatEscuela.nuevoEscuela(objentEscuela)
        Else
            Return False
        End If
    End Function

    Public Function modificarEscuela(objentEscuela) As Boolean
        If objentEscuela.vacanteEscuela >= 20 Then
            Return objdatEscuela.modificarEscuela(objentEscuela)
        Else
            Return False
        End If
    End Function

    Public Function eliminarEscuela(codEscuela As Integer) As Boolean
        Return objdatEscuela.eliminarEscuela(codEscuela)
    End Function

    Public Function buscarEscuela(codEscuela As Integer) As DataTable
        Return objdatEscuela.buscarEscuela(codEscuela)
    End Function

End Class
