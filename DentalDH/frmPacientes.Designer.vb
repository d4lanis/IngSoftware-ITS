<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        Me.txt_buscarNombre = New System.Windows.Forms.TextBox()
        Me.mtxt_buscarTel = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_buscarTodos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_Pacientes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(451, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(430, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seleccione a un paciente si desea modificar sus datos."
        '
        'txt_buscarNombre
        '
        Me.txt_buscarNombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_buscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscarNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_buscarNombre.Location = New System.Drawing.Point(16, 100)
        Me.txt_buscarNombre.MaxLength = 90
        Me.txt_buscarNombre.Name = "txt_buscarNombre"
        Me.txt_buscarNombre.Size = New System.Drawing.Size(395, 20)
        Me.txt_buscarNombre.TabIndex = 1
        '
        'mtxt_buscarTel
        '
        Me.mtxt_buscarTel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mtxt_buscarTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxt_buscarTel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.mtxt_buscarTel.Location = New System.Drawing.Point(455, 103)
        Me.mtxt_buscarTel.Mask = "9999999999"
        Me.mtxt_buscarTel.Name = "mtxt_buscarTel"
        Me.mtxt_buscarTel.Size = New System.Drawing.Size(164, 20)
        Me.mtxt_buscarTel.TabIndex = 2
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Gray
        Me.btn_buscar.FlatAppearance.BorderSize = 0
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscar.Location = New System.Drawing.Point(655, 97)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(120, 33)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_buscarTodos
        '
        Me.btn_buscarTodos.BackColor = System.Drawing.Color.Gray
        Me.btn_buscarTodos.FlatAppearance.BorderSize = 0
        Me.btn_buscarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarTodos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscarTodos.Location = New System.Drawing.Point(836, 97)
        Me.btn_buscarTodos.Name = "btn_buscarTodos"
        Me.btn_buscarTodos.Size = New System.Drawing.Size(120, 33)
        Me.btn_buscarTodos.TabIndex = 4
        Me.btn_buscarTodos.Text = "Buscar Todos"
        Me.btn_buscarTodos.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(470, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Para registrar un paciente nuevo presione el boton de agregar."
        '
        'dgv_Pacientes
        '
        Me.dgv_Pacientes.AllowUserToAddRows = False
        Me.dgv_Pacientes.AllowUserToDeleteRows = False
        Me.dgv_Pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Pacientes.Location = New System.Drawing.Point(17, 190)
        Me.dgv_Pacientes.Name = "dgv_Pacientes"
        Me.dgv_Pacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Pacientes.Size = New System.Drawing.Size(951, 359)
        Me.dgv_Pacientes.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 47)
        Me.Panel1.TabIndex = 12
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(984, 561)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 411
        Me.LineShape1.Y1 = 120
        Me.LineShape1.Y2 = 120
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_Pacientes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_buscarTodos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.mtxt_buscarTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscarNombre)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_buscarNombre As TextBox
    Friend WithEvents mtxt_buscarTel As MaskedTextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_buscarTodos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_Pacientes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
