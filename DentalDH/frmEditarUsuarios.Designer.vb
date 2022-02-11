<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarUsuarios))
        Me.lbl_muestraDatos = New System.Windows.Forms.Label()
        Me.txt_nombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_comprobarContraseña = New System.Windows.Forms.Label()
        Me.txt_agregarContraseñaComprobado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_permisos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_agregarContraseña = New System.Windows.Forms.TextBox()
        Me.txt_agregarNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_editar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_muestraDatos
        '
        Me.lbl_muestraDatos.AutoSize = True
        Me.lbl_muestraDatos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_muestraDatos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_muestraDatos.Location = New System.Drawing.Point(68, 466)
        Me.lbl_muestraDatos.Name = "lbl_muestraDatos"
        Me.lbl_muestraDatos.Size = New System.Drawing.Size(61, 21)
        Me.lbl_muestraDatos.TabIndex = 0
        Me.lbl_muestraDatos.Text = "Label1"
        '
        'txt_nombreEmpleado
        '
        Me.txt_nombreEmpleado.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_nombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreEmpleado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreEmpleado.Location = New System.Drawing.Point(72, 108)
        Me.txt_nombreEmpleado.MaxLength = 30
        Me.txt_nombreEmpleado.Name = "txt_nombreEmpleado"
        Me.txt_nombreEmpleado.Size = New System.Drawing.Size(388, 20)
        Me.txt_nombreEmpleado.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Nombre del Empleado:"
        '
        'lbl_comprobarContraseña
        '
        Me.lbl_comprobarContraseña.AutoSize = True
        Me.lbl_comprobarContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comprobarContraseña.Location = New System.Drawing.Point(71, 354)
        Me.lbl_comprobarContraseña.Name = "lbl_comprobarContraseña"
        Me.lbl_comprobarContraseña.Size = New System.Drawing.Size(61, 21)
        Me.lbl_comprobarContraseña.TabIndex = 27
        Me.lbl_comprobarContraseña.Text = "Label8"
        '
        'txt_agregarContraseñaComprobado
        '
        Me.txt_agregarContraseñaComprobado.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarContraseñaComprobado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarContraseñaComprobado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_agregarContraseñaComprobado.Location = New System.Drawing.Point(74, 299)
        Me.txt_agregarContraseñaComprobado.MaxLength = 16
        Me.txt_agregarContraseñaComprobado.Name = "txt_agregarContraseñaComprobado"
        Me.txt_agregarContraseñaComprobado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_agregarContraseñaComprobado.Size = New System.Drawing.Size(391, 20)
        Me.txt_agregarContraseñaComprobado.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Confirmar contraseña:"
        '
        'cb_permisos
        '
        Me.cb_permisos.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cb_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_permisos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_permisos.FormattingEnabled = True
        Me.cb_permisos.Location = New System.Drawing.Point(154, 396)
        Me.cb_permisos.Name = "cb_permisos"
        Me.cb_permisos.Size = New System.Drawing.Size(311, 29)
        Me.cb_permisos.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 399)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Permisos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Contraseña:"
        '
        'txt_agregarContraseña
        '
        Me.txt_agregarContraseña.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_agregarContraseña.Location = New System.Drawing.Point(73, 237)
        Me.txt_agregarContraseña.MaxLength = 16
        Me.txt_agregarContraseña.Name = "txt_agregarContraseña"
        Me.txt_agregarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_agregarContraseña.Size = New System.Drawing.Size(391, 20)
        Me.txt_agregarContraseña.TabIndex = 19
        '
        'txt_agregarNombreUsuario
        '
        Me.txt_agregarNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarNombreUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_agregarNombreUsuario.Location = New System.Drawing.Point(72, 171)
        Me.txt_agregarNombreUsuario.MaxLength = 35
        Me.txt_agregarNombreUsuario.Name = "txt_agregarNombreUsuario"
        Me.txt_agregarNombreUsuario.Size = New System.Drawing.Size(391, 20)
        Me.txt_agregarNombreUsuario.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nombre de usuario:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 58)
        Me.Panel1.TabIndex = 29
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnEliminar.IconColor = System.Drawing.Color.White
        Me.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEliminar.IconSize = 40
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEliminar.Location = New System.Drawing.Point(275, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 58)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar  "
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_editar.IconColor = System.Drawing.Color.White
        Me.btn_editar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_editar.IconSize = 40
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_editar.Location = New System.Drawing.Point(148, 0)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(127, 58)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "  Editar    "
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.btnCancelar.IconColor = System.Drawing.Color.White
        Me.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancelar.IconSize = 40
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancelar.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 58)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar  "
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(547, 545)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 75
        Me.LineShape4.X2 = 464
        Me.LineShape4.Y1 = 320
        Me.LineShape4.Y2 = 320
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 73
        Me.LineShape3.X2 = 462
        Me.LineShape3.Y1 = 257
        Me.LineShape3.Y2 = 257
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 74
        Me.LineShape2.X2 = 463
        Me.LineShape2.Y1 = 192
        Me.LineShape2.Y2 = 192
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 73
        Me.LineShape1.X2 = 460
        Me.LineShape1.Y1 = 128
        Me.LineShape1.Y2 = 129
        '
        'frmEditarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(547, 545)
        Me.Controls.Add(Me.lbl_muestraDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_nombreEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_comprobarContraseña)
        Me.Controls.Add(Me.txt_agregarContraseñaComprobado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_permisos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_agregarContraseña)
        Me.Controls.Add(Me.txt_agregarNombreUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditarUsuarios"
        Me.Text = "Editar Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_muestraDatos As Label
    Friend WithEvents txt_nombreEmpleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_comprobarContraseña As Label
    Friend WithEvents txt_agregarContraseñaComprobado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_permisos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_agregarContraseña As TextBox
    Friend WithEvents txt_agregarNombreUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_editar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
End Class
