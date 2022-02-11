<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.dgv_Usuarios = New System.Windows.Forms.DataGridView()
        Me.txt_buscarNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_agregarNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txt_agregarContraseña = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_permisos = New System.Windows.Forms.ComboBox()
        Me.btn_buscarUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_agregarContraseñaComprobado = New System.Windows.Forms.TextBox()
        Me.lbl_comprobarContraseña = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Usuarios
        '
        Me.dgv_Usuarios.AllowUserToAddRows = False
        Me.dgv_Usuarios.AllowUserToDeleteRows = False
        Me.dgv_Usuarios.AllowUserToOrderColumns = True
        Me.dgv_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Usuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Usuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Usuarios.Location = New System.Drawing.Point(423, 121)
        Me.dgv_Usuarios.Name = "dgv_Usuarios"
        Me.dgv_Usuarios.ReadOnly = True
        Me.dgv_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Usuarios.Size = New System.Drawing.Size(557, 356)
        Me.dgv_Usuarios.TabIndex = 0
        '
        'txt_buscarNombre
        '
        Me.txt_buscarNombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_buscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscarNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txt_buscarNombre.Location = New System.Drawing.Point(423, 92)
        Me.txt_buscarNombre.MaxLength = 35
        Me.txt_buscarNombre.Name = "txt_buscarNombre"
        Me.txt_buscarNombre.Size = New System.Drawing.Size(457, 17)
        Me.txt_buscarNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(420, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por nombre de empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(349, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Control de Usuarios del Sistema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agregar usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre de usuario:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'txt_agregarNombreUsuario
        '
        Me.txt_agregarNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarNombreUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.txt_agregarNombreUsuario.Location = New System.Drawing.Point(15, 194)
        Me.txt_agregarNombreUsuario.MaxLength = 35
        Me.txt_agregarNombreUsuario.Name = "txt_agregarNombreUsuario"
        Me.txt_agregarNombreUsuario.Size = New System.Drawing.Size(391, 14)
        Me.txt_agregarNombreUsuario.TabIndex = 2
        '
        'txt_agregarContraseña
        '
        Me.txt_agregarContraseña.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarContraseña.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.txt_agregarContraseña.Location = New System.Drawing.Point(15, 241)
        Me.txt_agregarContraseña.MaxLength = 16
        Me.txt_agregarContraseña.Name = "txt_agregarContraseña"
        Me.txt_agregarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_agregarContraseña.Size = New System.Drawing.Size(391, 14)
        Me.txt_agregarContraseña.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(13, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Permisos:"
        '
        'cb_permisos
        '
        Me.cb_permisos.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cb_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_permisos.FormattingEnabled = True
        Me.cb_permisos.Location = New System.Drawing.Point(88, 343)
        Me.cb_permisos.Name = "cb_permisos"
        Me.cb_permisos.Size = New System.Drawing.Size(243, 21)
        Me.cb_permisos.TabIndex = 5
        '
        'btn_buscarUsuario
        '
        Me.btn_buscarUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_buscarUsuario.FlatAppearance.BorderSize = 0
        Me.btn_buscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscarUsuario.ForeColor = System.Drawing.Color.White
        Me.btn_buscarUsuario.Location = New System.Drawing.Point(886, 84)
        Me.btn_buscarUsuario.Name = "btn_buscarUsuario"
        Me.btn_buscarUsuario.Size = New System.Drawing.Size(94, 31)
        Me.btn_buscarUsuario.TabIndex = 0
        Me.btn_buscarUsuario.Text = "Buscar"
        Me.btn_buscarUsuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Confirmar contraseña:"
        '
        'txt_agregarContraseñaComprobado
        '
        Me.txt_agregarContraseñaComprobado.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_agregarContraseñaComprobado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_agregarContraseñaComprobado.Location = New System.Drawing.Point(15, 283)
        Me.txt_agregarContraseñaComprobado.MaxLength = 16
        Me.txt_agregarContraseñaComprobado.Name = "txt_agregarContraseñaComprobado"
        Me.txt_agregarContraseñaComprobado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_agregarContraseñaComprobado.Size = New System.Drawing.Size(391, 13)
        Me.txt_agregarContraseñaComprobado.TabIndex = 4
        '
        'lbl_comprobarContraseña
        '
        Me.lbl_comprobarContraseña.AutoSize = True
        Me.lbl_comprobarContraseña.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lbl_comprobarContraseña.Location = New System.Drawing.Point(17, 406)
        Me.lbl_comprobarContraseña.Name = "lbl_comprobarContraseña"
        Me.lbl_comprobarContraseña.Size = New System.Drawing.Size(55, 19)
        Me.lbl_comprobarContraseña.TabIndex = 15
        Me.lbl_comprobarContraseña.Text = "Label8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nombre del Empleado"
        '
        'txt_nombreEmpleado
        '
        Me.txt_nombreEmpleado.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_nombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreEmpleado.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.txt_nombreEmpleado.Location = New System.Drawing.Point(15, 151)
        Me.txt_nombreEmpleado.MaxLength = 30
        Me.txt_nombreEmpleado.Name = "txt_nombreEmpleado"
        Me.txt_nombreEmpleado.Size = New System.Drawing.Size(388, 14)
        Me.txt_nombreEmpleado.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 47)
        Me.Panel1.TabIndex = 18
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregar.IconColor = System.Drawing.Color.White
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 40
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregar.Location = New System.Drawing.Point(127, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 47)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.btnRegresar.IconColor = System.Drawing.Color.White
        Me.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegresar.IconSize = 40
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRegresar.Location = New System.Drawing.Point(0, 0)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(127, 47)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(992, 624)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 401
        Me.LineShape1.Y1 = 167
        Me.LineShape1.Y2 = 167
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 403
        Me.LineShape2.Y1 = 210
        Me.LineShape2.Y2 = 210
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 402
        Me.LineShape3.Y1 = 257
        Me.LineShape3.Y2 = 257
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 16
        Me.LineShape4.X2 = 402
        Me.LineShape4.Y1 = 298
        Me.LineShape4.Y2 = 298
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 424
        Me.LineShape5.X2 = 873
        Me.LineShape5.Y1 = 110
        Me.LineShape5.Y2 = 110
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(992, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_nombreEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_comprobarContraseña)
        Me.Controls.Add(Me.txt_agregarContraseñaComprobado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_buscarUsuario)
        Me.Controls.Add(Me.cb_permisos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_agregarContraseña)
        Me.Controls.Add(Me.txt_agregarNombreUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscarNombre)
        Me.Controls.Add(Me.dgv_Usuarios)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmUsuarios"
        Me.Text = "Módulo Usuarios"
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Usuarios As DataGridView
    Friend WithEvents txt_buscarNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_agregarNombreUsuario As TextBox
    Friend WithEvents txt_agregarContraseña As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_permisos As ComboBox
    Friend WithEvents btn_buscarUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_agregarContraseñaComprobado As TextBox
    Friend WithEvents lbl_comprobarContraseña As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nombreEmpleado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape5 As PowerPacks.LineShape
End Class
