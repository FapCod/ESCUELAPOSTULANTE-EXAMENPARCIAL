<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscuela
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodEscuela = New System.Windows.Forms.TextBox()
        Me.txtnombreEscuela = New System.Windows.Forms.TextBox()
        Me.numvacanteEscuela = New System.Windows.Forms.NumericUpDown()
        Me.numinscritoEscuela = New System.Windows.Forms.NumericUpDown()
        Me.chcActivoEscuela = New System.Windows.Forms.CheckBox()
        Me.chcInactivoEscuela = New System.Windows.Forms.CheckBox()
        Me.btnNuevoEscuela = New System.Windows.Forms.Button()
        Me.btnModificarEscuela = New System.Windows.Forms.Button()
        Me.btnEliminarEscuela = New System.Windows.Forms.Button()
        Me.dgvEscuela = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarEscuela = New System.Windows.Forms.Button()
        CType(Me.numvacanteEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numinscritoEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CODIGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VACANTES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "INSCRITOS"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ESTADO"
        '
        'txtCodEscuela
        '
        Me.txtCodEscuela.Location = New System.Drawing.Point(136, 36)
        Me.txtCodEscuela.Name = "txtCodEscuela"
        Me.txtCodEscuela.Size = New System.Drawing.Size(130, 22)
        Me.txtCodEscuela.TabIndex = 5
        '
        'txtnombreEscuela
        '
        Me.txtnombreEscuela.Location = New System.Drawing.Point(136, 76)
        Me.txtnombreEscuela.Name = "txtnombreEscuela"
        Me.txtnombreEscuela.Size = New System.Drawing.Size(178, 22)
        Me.txtnombreEscuela.TabIndex = 6
        '
        'numvacanteEscuela
        '
        Me.numvacanteEscuela.Location = New System.Drawing.Point(136, 111)
        Me.numvacanteEscuela.Name = "numvacanteEscuela"
        Me.numvacanteEscuela.Size = New System.Drawing.Size(120, 22)
        Me.numvacanteEscuela.TabIndex = 7
        '
        'numinscritoEscuela
        '
        Me.numinscritoEscuela.Location = New System.Drawing.Point(136, 147)
        Me.numinscritoEscuela.Name = "numinscritoEscuela"
        Me.numinscritoEscuela.Size = New System.Drawing.Size(120, 22)
        Me.numinscritoEscuela.TabIndex = 8
        Me.numinscritoEscuela.Visible = False
        '
        'chcActivoEscuela
        '
        Me.chcActivoEscuela.AutoSize = True
        Me.chcActivoEscuela.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcActivoEscuela.ForeColor = System.Drawing.Color.White
        Me.chcActivoEscuela.Location = New System.Drawing.Point(136, 185)
        Me.chcActivoEscuela.Name = "chcActivoEscuela"
        Me.chcActivoEscuela.Size = New System.Drawing.Size(104, 28)
        Me.chcActivoEscuela.TabIndex = 9
        Me.chcActivoEscuela.Text = "ACTIVO"
        Me.chcActivoEscuela.UseVisualStyleBackColor = True
        '
        'chcInactivoEscuela
        '
        Me.chcInactivoEscuela.AutoSize = True
        Me.chcInactivoEscuela.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcInactivoEscuela.ForeColor = System.Drawing.Color.White
        Me.chcInactivoEscuela.Location = New System.Drawing.Point(246, 184)
        Me.chcInactivoEscuela.Name = "chcInactivoEscuela"
        Me.chcInactivoEscuela.Size = New System.Drawing.Size(126, 28)
        Me.chcInactivoEscuela.TabIndex = 10
        Me.chcInactivoEscuela.Text = "INACTIVO"
        Me.chcInactivoEscuela.UseVisualStyleBackColor = True
        '
        'btnNuevoEscuela
        '
        Me.btnNuevoEscuela.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevoEscuela.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEscuela.ForeColor = System.Drawing.Color.White
        Me.btnNuevoEscuela.Location = New System.Drawing.Point(16, 254)
        Me.btnNuevoEscuela.Name = "btnNuevoEscuela"
        Me.btnNuevoEscuela.Size = New System.Drawing.Size(177, 46)
        Me.btnNuevoEscuela.TabIndex = 11
        Me.btnNuevoEscuela.Text = "NUEVO"
        Me.btnNuevoEscuela.UseVisualStyleBackColor = False
        '
        'btnModificarEscuela
        '
        Me.btnModificarEscuela.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificarEscuela.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEscuela.ForeColor = System.Drawing.Color.White
        Me.btnModificarEscuela.Location = New System.Drawing.Point(199, 254)
        Me.btnModificarEscuela.Name = "btnModificarEscuela"
        Me.btnModificarEscuela.Size = New System.Drawing.Size(177, 46)
        Me.btnModificarEscuela.TabIndex = 12
        Me.btnModificarEscuela.Text = "MODIFICAR"
        Me.btnModificarEscuela.UseVisualStyleBackColor = False
        '
        'btnEliminarEscuela
        '
        Me.btnEliminarEscuela.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminarEscuela.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEscuela.ForeColor = System.Drawing.Color.White
        Me.btnEliminarEscuela.Location = New System.Drawing.Point(108, 306)
        Me.btnEliminarEscuela.Name = "btnEliminarEscuela"
        Me.btnEliminarEscuela.Size = New System.Drawing.Size(177, 46)
        Me.btnEliminarEscuela.TabIndex = 13
        Me.btnEliminarEscuela.Text = "ELIMINAR"
        Me.btnEliminarEscuela.UseVisualStyleBackColor = False
        '
        'dgvEscuela
        '
        Me.dgvEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEscuela.Location = New System.Drawing.Point(399, 99)
        Me.dgvEscuela.Name = "dgvEscuela"
        Me.dgvEscuela.RowTemplate.Height = 24
        Me.dgvEscuela.Size = New System.Drawing.Size(535, 287)
        Me.dgvEscuela.TabIndex = 14
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(399, 71)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(130, 22)
        Me.txtBuscar.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(395, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CODIGO"
        '
        'btnBuscarEscuela
        '
        Me.btnBuscarEscuela.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscarEscuela.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEscuela.ForeColor = System.Drawing.Color.White
        Me.btnBuscarEscuela.Location = New System.Drawing.Point(535, 47)
        Me.btnBuscarEscuela.Name = "btnBuscarEscuela"
        Me.btnBuscarEscuela.Size = New System.Drawing.Size(177, 46)
        Me.btnBuscarEscuela.TabIndex = 17
        Me.btnBuscarEscuela.Text = "BUSCAR"
        Me.btnBuscarEscuela.UseVisualStyleBackColor = False
        '
        'frmEscuela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(957, 416)
        Me.Controls.Add(Me.btnBuscarEscuela)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvEscuela)
        Me.Controls.Add(Me.btnEliminarEscuela)
        Me.Controls.Add(Me.btnModificarEscuela)
        Me.Controls.Add(Me.btnNuevoEscuela)
        Me.Controls.Add(Me.chcInactivoEscuela)
        Me.Controls.Add(Me.chcActivoEscuela)
        Me.Controls.Add(Me.numinscritoEscuela)
        Me.Controls.Add(Me.numvacanteEscuela)
        Me.Controls.Add(Me.txtnombreEscuela)
        Me.Controls.Add(Me.txtCodEscuela)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEscuela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEscuela"
        CType(Me.numvacanteEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numinscritoEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodEscuela As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreEscuela As System.Windows.Forms.TextBox
    Friend WithEvents numvacanteEscuela As System.Windows.Forms.NumericUpDown
    Friend WithEvents numinscritoEscuela As System.Windows.Forms.NumericUpDown
    Friend WithEvents chcActivoEscuela As System.Windows.Forms.CheckBox
    Friend WithEvents chcInactivoEscuela As System.Windows.Forms.CheckBox
    Friend WithEvents btnNuevoEscuela As System.Windows.Forms.Button
    Friend WithEvents btnModificarEscuela As System.Windows.Forms.Button
    Friend WithEvents btnEliminarEscuela As System.Windows.Forms.Button
    Friend WithEvents dgvEscuela As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEscuela As System.Windows.Forms.Button
End Class
