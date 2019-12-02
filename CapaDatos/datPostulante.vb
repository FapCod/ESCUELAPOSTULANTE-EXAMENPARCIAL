Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datPostulante
    Public Function nuevoPostulante(objPostulante As entPostulante) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registrarPostulante"
            cmd.Parameters.AddWithValue("@codPostulante", objPostulante.codPostulante)
            cmd.Parameters.AddWithValue("@nombrePostulante", objPostulante.nombrePostulante)
            cmd.Parameters.AddWithValue("@apellidoPostulante", objPostulante.apellidoPostulante)
            cmd.Parameters.AddWithValue("@codEscuela", objPostulante.objentEscuela.codEscuela)
            cmd.Parameters.AddWithValue("@direccionPostulante", objPostulante.direccionPostulante)
            cmd.Parameters.AddWithValue("@telefonoPostulante", objPostulante.telefonoPostulante)
            cmd.Parameters.AddWithValue("@fechanacimientoPostulante", objPostulante.fechanacimientoPostulante)
            cmd.Parameters.AddWithValue("@sexoPostulante", objPostulante.sexoPostulante)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return False
    End Function

    Public Function modificarPostulante(objPostulante As entPostulante) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "actualizarPostulante"
            cmd.Parameters.AddWithValue("@codPostulante", objPostulante.codPostulante)
            cmd.Parameters.AddWithValue("@nombrePostulante", objPostulante.nombrePostulante)
            cmd.Parameters.AddWithValue("@apellidoPostulante", objPostulante.apellidoPostulante)
            cmd.Parameters.AddWithValue("@codEscuela", objPostulante.objentEscuela.codEscuela)
            cmd.Parameters.AddWithValue("@direccionPostulante", objPostulante.direccionPostulante)
            cmd.Parameters.AddWithValue("@telefonoPostulante", objPostulante.telefonoPostulante)
            cmd.Parameters.AddWithValue("@fechanacimientoPostulante", objPostulante.fechanacimientoPostulante)
            cmd.Parameters.AddWithValue("@sexoPostulante", objPostulante.sexoPostulante)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return False
    End Function

    Public Function eliminarPostulante(codPostulante As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "eliminarPostulante"
            cmd.Parameters.AddWithValue("@codPostulante", codPostulante)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return False
    End Function

    Public Function buscarPostulante(codPostulante As Integer) As DataTable
        Try
            Dim objdat As New datConexion
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "buscarPostulante"
            cmd.Parameters.AddWithValue("@codPostulante", codPostulante)
            objdat.Conectar("", "", True)
            cmd.Connection = objdat.cnn
            If cmd.ExecuteNonQuery Then
                dt = New DataTable
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function listarPostulante() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarPostulante"
        objdat.Conectar("", "", True)
        cmd.Connection = objdat.cnn
        If cmd.ExecuteNonQuery Then
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Else
            Return Nothing
        End If

    End Function
End Class
