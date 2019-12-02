Imports CapaEntidad
Imports CapaNegocio
Public Class frmPostulante


    Private Sub frmPostulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegEscuela As New negEscuela
        ver()
        cmbCodEscuela.DataSource = objnegEscuela.listarActivosEscuela()
        cmbCodEscuela.DisplayMember = "nombreEscuela"
        cmbCodEscuela.ValueMember = "CodEscuela"
    End Sub
    Public Sub ver()
        Dim objnegPostulante As New negPostulante
        dgvPostulante.DataSource = objnegPostulante.listarPostulante()
    End Sub
    Private Sub btnNuevoPostulante_Click(sender As Object, e As EventArgs) Handles btnNuevoPostulante.Click
        Dim objentPostulante As New entPostulante
        objentPostulante.codPostulante = Val(txtCodPostulante.Text)
        objentPostulante.nombrePostulante = txtnombrePostulante.Text
        objentPostulante.apellidoPostulante = txtapellidoPostulante.Text
        objentPostulante.objentEscuela.codEscuela = cmbCodEscuela.SelectedValue
        objentPostulante.direccionPostulante = txtdireccionPostulante.Text
        objentPostulante.telefonoPostulante = txttelefonoPostulante.Text
        objentPostulante.fechanacimientoPostulante = dtpFechanacimiento.Value
        objentPostulante.sexoPostulante = cmbSexoPostulante.Text
        Dim objnegPostulante As New negPostulante
        Dim Verificar As Boolean
        Verificar = objnegPostulante.nuevoPostulante(objentPostulante)
        If Verificar = True Then
            MsgBox("Registro Exitoso")

            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If
    End Sub

    Private Sub btnModificarPostulante_Click(sender As Object, e As EventArgs) Handles btnModificarPostulante.Click
        Dim objentPostulante As New entPostulante
        objentPostulante.codPostulante = Val(txtCodPostulante.Text)
        objentPostulante.nombrePostulante = txtnombrePostulante.Text
        objentPostulante.apellidoPostulante = txtapellidoPostulante.Text
        objentPostulante.objentEscuela.codEscuela = cmbCodEscuela.SelectedValue
        objentPostulante.direccionPostulante = txtdireccionPostulante.Text
        objentPostulante.telefonoPostulante = txttelefonoPostulante.Text
        objentPostulante.fechanacimientoPostulante = dtpFechanacimiento.Value
        objentPostulante.sexoPostulante = cmbSexoPostulante.Text
        Dim objnegPostulante As New negPostulante
        Dim Verificar As Boolean
        Verificar = objnegPostulante.modificarPostulante(objentPostulante)
        If Verificar = True Then
            MsgBox("Actualizacion Exitoso")
            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If
    End Sub

    Private Sub dgvPostulante_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPostulante.CellClick
        Dim i As Integer
        i = dgvPostulante.CurrentRow.Index
        txtCodPostulante.Text = dgvPostulante.Item(0, i).Value()
        txtnombrePostulante.Text = dgvPostulante.Item(1, i).Value()
        txtapellidoPostulante.Text = dgvPostulante.Item(2, i).Value()
        cmbCodEscuela.Text = dgvPostulante.Item(3, i).Value()
        txtdireccionPostulante.Text = dgvPostulante.Item(4, i).Value()
        txttelefonoPostulante.Text = dgvPostulante.Item(5, i).Value()
        dtpFechanacimiento.Value = dgvPostulante.Item(6, i).Value()
        cmbSexoPostulante.Text = dgvPostulante.Item(7, i).Value()
    End Sub

    Private Sub btnEliminarPostulante_Click(sender As Object, e As EventArgs) Handles btnEliminarPostulante.Click
        Dim i As Integer
        Dim CodPostulante As Integer
        i = dgvPostulante.CurrentRow.Index
        CodPostulante = dgvPostulante.Item(0, i).Value()
        Dim objnegPostulante As New negPostulante
        Dim Verificar As Boolean
        Verificar = objnegPostulante.eliminarPostulante(CodPostulante)
        If Verificar = True Then
            MsgBox("Eliminacion Exitoso")
            ver()
        Else
            MsgBox("Ocurrio Un error")
        End If
    End Sub

    Private Sub btnBuscarPostulante_Click(sender As Object, e As EventArgs) Handles btnBuscarPostulante.Click
        Dim objnegPostulante As New negPostulante
        Dim CodPostulante As Integer
        CodPostulante = Val(txtbuscar.text)
        dgvPostulante.DataSource = objnegPostulante.buscarPostulante(CodPostulante)
    End Sub
End Class
