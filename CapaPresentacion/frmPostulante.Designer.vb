<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostulante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBuscarPostulante = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvPostulante = New System.Windows.Forms.DataGridView()
        Me.btnEliminarPostulante = New System.Windows.Forms.Button()
        Me.btnModificarPostulante = New System.Windows.Forms.Button()
        Me.btnNuevoPostulante = New System.Windows.Forms.Button()
        Me.txtnombrePostulante = New System.Windows.Forms.TextBox()
        Me.txtCodPostulante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapellidoPostulante = New System.Windows.Forms.TextBox()
        Me.txtdireccionPostulante = New System.Windows.Forms.TextBox()
        Me.txttelefonoPostulante = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSexoPostulante = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCodEscuela = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPostulante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarPostulante
        '
        Me.btnBuscarPostulante.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscarPostulante.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPostulante.ForeColor = System.Drawing.Color.White
        Me.btnBuscarPostulante.Location = New System.Drawing.Point(695, 48)
        Me.btnBuscarPostulante.Name = "btnBuscarPostulante"
        Me.btnBuscarPostulante.Size = New System.Drawing.Size(177, 46)
        Me.btnBuscarPostulante.TabIndex = 35
        Me.btnBuscarPostulante.Text = "BUSCAR"
        Me.btnBuscarPostulante.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(555, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "CODIGO"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(559, 72)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(130, 22)
        Me.txtbuscar.TabIndex = 33
        '
        'dgvPostulante
        '
        Me.dgvPostulante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPostulante.Location = New System.Drawing.Point(559, 100)
        Me.dgvPostulante.Name = "dgvPostulante"
        Me.dgvPostulante.RowTemplate.Height = 24
        Me.dgvPostulante.Size = New System.Drawing.Size(535, 287)
        Me.dgvPostulante.TabIndex = 32
        '
        'btnEliminarPostulante
        '
        Me.btnEliminarPostulante.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminarPostulante.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPostulante.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPostulante.Location = New System.Drawing.Point(103, 441)
        Me.btnEliminarPostulante.Name = "btnEliminarPostulante"
        Me.btnEliminarPostulante.Size = New System.Drawing.Size(177, 46)
        Me.btnEliminarPostulante.TabIndex = 31
        Me.btnEliminarPostulante.Text = "ELIMINAR"
        Me.btnEliminarPostulante.UseVisualStyleBackColor = False
        '
        'btnModificarPostulante
        '
        Me.btnModificarPostulante.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificarPostulante.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPostulante.ForeColor = System.Drawing.Color.White
        Me.btnModificarPostulante.Location = New System.Drawing.Point(194, 389)
        Me.btnModificarPostulante.Name = "btnModificarPostulante"
        Me.btnModificarPostulante.Size = New System.Drawing.Size(177, 46)
        Me.btnModificarPostulante.TabIndex = 30
        Me.btnModificarPostulante.Text = "MODIFICAR"
        Me.btnModificarPostulante.UseVisualStyleBackColor = False
        '
        'btnNuevoPostulante
        '
        Me.btnNuevoPostulante.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevoPostulante.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPostulante.ForeColor = System.Drawing.Color.White
        Me.btnNuevoPostulante.Location = New System.Drawing.Point(11, 389)
        Me.btnNuevoPostulante.Name = "btnNuevoPostulante"
        Me.btnNuevoPostulante.Size = New System.Drawing.Size(177, 46)
        Me.btnNuevoPostulante.TabIndex = 29
        Me.btnNuevoPostulante.Text = "NUEVO"
        Me.btnNuevoPostulante.UseVisualStyleBackColor = False
        '
        'txtnombrePostulante
        '
        Me.txtnombrePostulante.Location = New System.Drawing.Point(136, 72)
        Me.txtnombrePostulante.Name = "txtnombrePostulante"
        Me.txtnombrePostulante.Size = New System.Drawing.Size(178, 22)
        Me.txtnombrePostulante.TabIndex = 24
        '
        'txtCodPostulante
        '
        Me.txtCodPostulante.Location = New System.Drawing.Point(136, 32)
        Me.txtCodPostulante.Name = "txtCodPostulante"
        Me.txtCodPostulante.Size = New System.Drawing.Size(130, 22)
        Me.txtCodPostulante.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "TELEFONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "DIRECCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "APELLIDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "CODIGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NOMBRE"
        '
        'txtapellidoPostulante
        '
        Me.txtapellidoPostulante.Location = New System.Drawing.Point(136, 107)
        Me.txtapellidoPostulante.Name = "txtapellidoPostulante"
        Me.txtapellidoPostulante.Size = New System.Drawing.Size(178, 22)
        Me.txtapellidoPostulante.TabIndex = 36
        '
        'txtdireccionPostulante
        '
        Me.txtdireccionPostulante.Location = New System.Drawing.Point(136, 201)
        Me.txtdireccionPostulante.Name = "txtdireccionPostulante"
        Me.txtdireccionPostulante.Size = New System.Drawing.Size(178, 22)
        Me.txtdireccionPostulante.TabIndex = 37
        '
        'txttelefonoPostulante
        '
        Me.txttelefonoPostulante.Location = New System.Drawing.Point(136, 239)
        Me.txttelefonoPostulante.Name = "txttelefonoPostulante"
        Me.txttelefonoPostulante.Size = New System.Drawing.Size(178, 22)
        Me.txttelefonoPostulante.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 24)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "FECHA NACIMIENTO"
        '
        'dtpFechanacimiento
        '
        Me.dtpFechanacimiento.Location = New System.Drawing.Point(17, 308)
        Me.dtpFechanacimiento.Name = "dtpFechanacimiento"
        Me.dtpFechanacimiento.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechanacimiento.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 24)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "SEXO"
        '
        'cmbSexoPostulante
        '
        Me.cmbSexoPostulante.FormattingEnabled = True
        Me.cmbSexoPostulante.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexoPostulante.Location = New System.Drawing.Point(136, 343)
        Me.cmbSexoPostulante.Name = "cmbSexoPostulante"
        Me.cmbSexoPostulante.Size = New System.Drawing.Size(121, 24)
        Me.cmbSexoPostulante.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "ESCUELA"
        '
        'cmbCodEscuela
        '
        Me.cmbCodEscuela.FormattingEnabled = True
        Me.cmbCodEscuela.Items.AddRange(New Object() {"M", "F"})
        Me.cmbCodEscuela.Location = New System.Drawing.Point(136, 157)
        Me.cmbCodEscuela.Name = "cmbCodEscuela"
        Me.cmbCodEscuela.Size = New System.Drawing.Size(178, 24)
        Me.cmbCodEscuela.TabIndex = 44
        '
        'frmPostulante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1118, 518)
        Me.Controls.Add(Me.cmbCodEscuela)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSexoPostulante)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpFechanacimiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttelefonoPostulante)
        Me.Controls.Add(Me.txtdireccionPostulante)
        Me.Controls.Add(Me.txtapellidoPostulante)
        Me.Controls.Add(Me.btnBuscarPostulante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvPostulante)
        Me.Controls.Add(Me.btnEliminarPostulante)
        Me.Controls.Add(Me.btnModificarPostulante)
        Me.Controls.Add(Me.btnNuevoPostulante)
        Me.Controls.Add(Me.txtnombrePostulante)
        Me.Controls.Add(Me.txtCodPostulante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPostulante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPostulante"
        CType(Me.dgvPostulante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarPostulante As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvPostulante As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarPostulante As System.Windows.Forms.Button
    Friend WithEvents btnModificarPostulante As System.Windows.Forms.Button
    Friend WithEvents btnNuevoPostulante As System.Windows.Forms.Button
    Friend WithEvents txtnombrePostulante As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPostulante As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtapellidoPostulante As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionPostulante As System.Windows.Forms.TextBox
    Friend WithEvents txttelefonoPostulante As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechanacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSexoPostulante As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEscuela As System.Windows.Forms.ComboBox

End Class
