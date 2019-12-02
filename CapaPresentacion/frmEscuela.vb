Imports CapaNegocio
Imports CapaEntidad
Public Class frmEscuela

    Private Sub frmEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver()
    End Sub
    Public Sub ver()
        Dim objnegEscuela As New negEscuela
        dgvEscuela.DataSource = objnegEscuela.listarActivosEscuela()
    End Sub
    Private Sub btnNuevoEscuela_Click(sender As Object, e As EventArgs) Handles btnNuevoEscuela.Click
        Dim objentEscuela As New entEscuela
        objentEscuela.codEscuela = Val(txtCodEscuela.Text)
        objentEscuela.nombreEscuela = txtnombreEscuela.Text
        objentEscuela.vacanteEscuela = numvacanteEscuela.Value
        objentEscuela.inscritoEscuela = 0
        If chcActivoEscuela.Checked = True Then
            objentEscuela.estadoEscuela = True
        ElseIf chcInactivoEscuela.Checked = True Then
            objentEscuela.estadoEscuela = False
        End If
        Dim objnegEscuela As New negEscuela
        Dim Verificar As Boolean
        Verificar = objnegEscuela.nuevoEscuela(objentEscuela)
        If Verificar = True Then
            MsgBox("Registro Exitoso")
            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If

    End Sub

    Private Sub dgvEscuela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEscuela.CellClick
        Dim i As Integer
        i = dgvEscuela.CurrentRow.Index
        txtCodEscuela.Text = dgvEscuela.Item(0, i).Value()
        txtnombreEscuela.Text = dgvEscuela.Item(1, i).Value()
        numvacanteEscuela.Value = dgvEscuela.Item(2, i).Value()
        numinscritoEscuela.Value = dgvEscuela.Item(3, i).Value()
        chcActivoEscuela.Checked = dgvEscuela.Item(4, i).Value()
    End Sub

    Private Sub btnModificarEscuela_Click(sender As Object, e As EventArgs) Handles btnModificarEscuela.Click
        Dim objentEscuela As New entEscuela
        objentEscuela.codEscuela = Val(txtCodEscuela.Text)
        objentEscuela.nombreEscuela = txtnombreEscuela.Text
        objentEscuela.vacanteEscuela = numvacanteEscuela.Value
        objentEscuela.inscritoEscuela = 0
        If chcActivoEscuela.Checked = True Then
            objentEscuela.estadoEscuela = True
        ElseIf chcInactivoEscuela.Checked = True Then
            objentEscuela.estadoEscuela = False
        End If
        Dim objnegEscuela As New negEscuela
        Dim Verificar As Boolean
        Verificar = objnegEscuela.modificarEscuela(objentEscuela)
        If Verificar = True Then
            MsgBox("Actualizacion Exitosa")
            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If
    End Sub

    Private Sub btnEliminarEscuela_Click(sender As Object, e As EventArgs) Handles btnEliminarEscuela.Click
        Dim objnegEscuela As New negEscuela
        Dim i As Integer
        Dim codEscuela As Integer
        i = dgvEscuela.CurrentRow.Index
        codEscuela = dgvEscuela.Item(0, i).Value()
        Dim Verificar As Boolean
        Verificar = objnegEscuela.eliminarEscuela(codEscuela)
        If Verificar = True Then
            MsgBox("Eliminacion Exitosa")
            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If
    End Sub

    Private Sub btnBuscarEscuela_Click(sender As Object, e As EventArgs) Handles btnBuscarEscuela.Click
        Dim objnegEscuela As New negEscuela
        Dim codEscuela As Integer
        codEscuela = Val(txtBuscar.Text)
        dgvEscuela.DataSource = objnegEscuela.buscarEscuela(codEscuela)
    End Sub
End Class