<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificarPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_aMaterno = New System.Windows.Forms.TextBox()
        Me.txt_aPaterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_registrar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(232, 285)
        Me.txt_telefono.Mask = "9999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_telefono.Size = New System.Drawing.Size(338, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'txt_correo
        '
        Me.txt_correo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_correo.Location = New System.Drawing.Point(232, 343)
        Me.txt_correo.MaxLength = 40
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(338, 20)
        Me.txt_correo.TabIndex = 5
        '
        'txt_aMaterno
        '
        Me.txt_aMaterno.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_aMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_aMaterno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aMaterno.Location = New System.Drawing.Point(232, 227)
        Me.txt_aMaterno.MaxLength = 30
        Me.txt_aMaterno.Name = "txt_aMaterno"
        Me.txt_aMaterno.Size = New System.Drawing.Size(338, 20)
        Me.txt_aMaterno.TabIndex = 3
        '
        'txt_aPaterno
        '
        Me.txt_aPaterno.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_aPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_aPaterno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aPaterno.Location = New System.Drawing.Point(232, 172)
        Me.txt_aPaterno.MaxLength = 30
        Me.txt_aPaterno.Name = "txt_aPaterno"
        Me.txt_aPaterno.Size = New System.Drawing.Size(338, 20)
        Me.txt_aPaterno.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(232, 127)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(338, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Fecha de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Correo Electronico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Numero Telefonico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ingresa los Datos a modificar del Paciente"
        '
        'dtp_fechaNacimiento
        '
        Me.dtp_fechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaNacimiento.Location = New System.Drawing.Point(232, 399)
        Me.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento"
        Me.dtp_fechaNacimiento.Size = New System.Drawing.Size(164, 26)
        Me.dtp_fechaNacimiento.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 47)
        Me.Panel1.TabIndex = 27
        '
        'btn_registrar
        '
        Me.btn_registrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_registrar.IconColor = System.Drawing.Color.White
        Me.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_registrar.IconSize = 40
        Me.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_registrar.Location = New System.Drawing.Point(127, 0)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(127, 47)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.Text = "Editar     "
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = True
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
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 47)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 480)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 232
        Me.LineShape5.X2 = 568
        Me.LineShape5.Y1 = 364
        Me.LineShape5.Y2 = 364
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 232
        Me.LineShape4.X2 = 568
        Me.LineShape4.Y1 = 306
        Me.LineShape4.Y2 = 306
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 232
        Me.LineShape3.X2 = 568
        Me.LineShape3.Y1 = 248
        Me.LineShape3.Y2 = 248
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 232
        Me.LineShape2.X2 = 568
        Me.LineShape2.Y1 = 193
        Me.LineShape2.Y2 = 193
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 233
        Me.LineShape1.X2 = 569
        Me.LineShape1.Y1 = 148
        Me.LineShape1.Y2 = 148
        '
        'frmModificarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(584, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtp_fechaNacimiento)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_aMaterno)
        Me.Controls.Add(Me.txt_aPaterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmModificarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar datos del Paciente"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_telefono As MaskedTextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_aMaterno As TextBox
    Friend WithEvents txt_aPaterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_fechaNacimiento As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_registrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
