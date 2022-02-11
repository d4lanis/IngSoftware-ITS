<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Servicios = New System.Windows.Forms.DataGridView()
        Me.txt_nombreServicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_Servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(12, 67)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(103, 31)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "Eliminar Servicio"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(591, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Agregar un servicio:"
        '
        'dgv_Servicios
        '
        Me.dgv_Servicios.AllowUserToAddRows = False
        Me.dgv_Servicios.AllowUserToDeleteRows = False
        Me.dgv_Servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Servicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Servicios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Servicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Servicios.Location = New System.Drawing.Point(12, 106)
        Me.dgv_Servicios.Name = "dgv_Servicios"
        Me.dgv_Servicios.ReadOnly = True
        Me.dgv_Servicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Servicios.Size = New System.Drawing.Size(507, 368)
        Me.dgv_Servicios.TabIndex = 3
        '
        'txt_nombreServicio
        '
        Me.txt_nombreServicio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_nombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombreServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_nombreServicio.ForeColor = System.Drawing.Color.White
        Me.txt_nombreServicio.Location = New System.Drawing.Point(596, 126)
        Me.txt_nombreServicio.MaxLength = 40
        Me.txt_nombreServicio.Multiline = True
        Me.txt_nombreServicio.Name = "txt_nombreServicio"
        Me.txt_nombreServicio.Size = New System.Drawing.Size(395, 56)
        Me.txt_nombreServicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(592, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre del servicio:"
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lbl_error.Location = New System.Drawing.Point(593, 206)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(44, 16)
        Me.lbl_error.TabIndex = 7
        Me.lbl_error.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(310, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Control del Catálogo de Servicios del Sistema"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 47)
        Me.Panel1.TabIndex = 17
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
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1014, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_error)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombreServicio)
        Me.Controls.Add(Me.dgv_Servicios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Name = "frmServicios"
        Me.Text = "Catálogo de Servicios"
        CType(Me.dgv_Servicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_Servicios As DataGridView
    Friend WithEvents txt_nombreServicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_error As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
End Class
