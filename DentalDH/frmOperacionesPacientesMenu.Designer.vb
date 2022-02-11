<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesPacientesMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscarNombre = New System.Windows.Forms.TextBox()
        Me.mtxt_buscarTel = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_Pacientes = New System.Windows.Forms.DataGridView()
        Me.btn_buscarTodos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciona un paciente para realizar operaciones sobre el."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar por nombre del paciente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(450, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Número de telefono:"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Gray
        Me.btn_buscar.FlatAppearance.BorderSize = 0
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Location = New System.Drawing.Point(642, 128)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(128, 30)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscarNombre
        '
        Me.txt_buscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_buscarNombre.Location = New System.Drawing.Point(28, 133)
        Me.txt_buscarNombre.MaxLength = 90
        Me.txt_buscarNombre.Name = "txt_buscarNombre"
        Me.txt_buscarNombre.Size = New System.Drawing.Size(379, 26)
        Me.txt_buscarNombre.TabIndex = 1
        '
        'mtxt_buscarTel
        '
        Me.mtxt_buscarTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.mtxt_buscarTel.Location = New System.Drawing.Point(454, 131)
        Me.mtxt_buscarTel.Mask = "9999999999"
        Me.mtxt_buscarTel.Name = "mtxt_buscarTel"
        Me.mtxt_buscarTel.Size = New System.Drawing.Size(161, 26)
        Me.mtxt_buscarTel.TabIndex = 5
        '
        'dgv_Pacientes
        '
        Me.dgv_Pacientes.AllowUserToAddRows = False
        Me.dgv_Pacientes.AllowUserToDeleteRows = False
        Me.dgv_Pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Pacientes.Location = New System.Drawing.Point(28, 190)
        Me.dgv_Pacientes.Name = "dgv_Pacientes"
        Me.dgv_Pacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Pacientes.Size = New System.Drawing.Size(909, 270)
        Me.dgv_Pacientes.TabIndex = 6
        '
        'btn_buscarTodos
        '
        Me.btn_buscarTodos.BackColor = System.Drawing.Color.Gray
        Me.btn_buscarTodos.FlatAppearance.BorderSize = 0
        Me.btn_buscarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarTodos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscarTodos.ForeColor = System.Drawing.Color.White
        Me.btn_buscarTodos.Location = New System.Drawing.Point(809, 128)
        Me.btn_buscarTodos.Name = "btn_buscarTodos"
        Me.btn_buscarTodos.Size = New System.Drawing.Size(128, 29)
        Me.btn_buscarTodos.TabIndex = 7
        Me.btn_buscarTodos.Text = "Buscar todos"
        Me.btn_buscarTodos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 47)
        Me.Panel1.TabIndex = 8
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
        'frmOperacionesPacientesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(962, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_buscarTodos)
        Me.Controls.Add(Me.dgv_Pacientes)
        Me.Controls.Add(Me.mtxt_buscarTel)
        Me.Controls.Add(Me.txt_buscarNombre)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOperacionesPacientesMenu"
        Me.Text = "Operaciones sobre pacientes"
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscarNombre As TextBox
    Friend WithEvents mtxt_buscarTel As MaskedTextBox
    Friend WithEvents dgv_Pacientes As DataGridView
    Friend WithEvents btn_buscarTodos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
End Class
