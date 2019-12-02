Imports CapaDatos
Imports CapaEntidad
Public Class negPostulante
    Dim objentPostulante As New entPostulante
    Dim objdatPostulante As New datPostulante
    Public Function listarPostulante() As DataTable
        Return objdatPostulante.listarPostulante()
    End Function

    Public Function nuevoPostulante(objentPostulante) As Boolean
        Dim edadPostulante As Integer
        Dim FECHANAC As Date
        FECHANAC = objentPostulante.fechanacimientoPostulante
        edadPostulante = Now.Year - FECHANAC.Year
        If objentPostulante.telefonoPostulante.length = 9 And edadPostulante > 15 Then
            Return objdatPostulante.nuevoPostulante(objentPostulante)
        Else
            Return False
        End If
    End Function

    Public Function modificarPostulante(objentPostulante) As Boolean
        Dim edadPostulante As Integer
        Dim FECHANAC As Date
        FECHANAC = objentPostulante.fechanacimientoPostulante
        edadPostulante = Now.Year - FECHANAC.Year
        If objentPostulante.telefonoPostulante.length = 9 And edadPostulante > 15 Then
            Return objdatPostulante.modificarPostulante(objentPostulante)
        Else
            Return False
        End If
    End Function

    Public Function eliminarPostulante(codPostulante As Integer) As Boolean
        Return objdatPostulante.eliminarPostulante(codPostulante)
    End Function

    Public Function buscarPostulante(codPostulante As Integer) As DataTable
        Return objdatPostulante.buscarPostulante(codPostulante)
    End Function
End Class
