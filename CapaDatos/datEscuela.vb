Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datEscuela
    Public Function nuevoEscuela(objEscuela As entEscuela) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registrarEscuela"
            cmd.Parameters.AddWithValue("@codEscuela", objEscuela.codEscuela)
            cmd.Parameters.AddWithValue("@nombreEscuela", objEscuela.nombreEscuela)
            cmd.Parameters.AddWithValue("@vacanteEscuela", objEscuela.vacanteEscuela)
            cmd.Parameters.AddWithValue("@inscritoEscuela", objEscuela.inscritoEscuela)
            cmd.Parameters.AddWithValue("@estadoEscuela", objEscuela.estadoEscuela)
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

    Public Function modificarEscuela(objEscuela As entEscuela) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "actualizarEscuela"
            cmd.Parameters.AddWithValue("@codEscuela", objEscuela.codEscuela)
            cmd.Parameters.AddWithValue("@nombreEscuela", objEscuela.nombreEscuela)
            cmd.Parameters.AddWithValue("@vacanteEscuela", objEscuela.vacanteEscuela)
            cmd.Parameters.AddWithValue("@inscritoEscuela", objEscuela.inscritoEscuela)
            cmd.Parameters.AddWithValue("@estadoEscuela", objEscuela.estadoEscuela)
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

    Public Function eliminarEscuela(codEscuela As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "eliminarEscuela"
            cmd.Parameters.AddWithValue("@codEscuela", codEscuela)
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

    Public Function buscarEscuela(codEscuela As Integer) As DataTable
        Try
            Dim objdat As New datConexion
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "buscarEscuela"
            cmd.Parameters.AddWithValue("@codEscuela", codEscuela)
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

    Public Function listarActivosEscuela() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarEscuela"
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
