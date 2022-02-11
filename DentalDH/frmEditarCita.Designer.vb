<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarCita
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
        Me.rtxt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Servicios = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_hora = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Paciente = New System.Windows.Forms.Label()
        Me.checkB_Asistencia = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_EliminarCita = New FontAwesome.Sharp.IconButton()
        Me.btn_registrar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtxt_descripcion
        '
        Me.rtxt_descripcion.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rtxt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rtxt_descripcion.Location = New System.Drawing.Point(12, 290)
        Me.rtxt_descripcion.Name = "rtxt_descripcion"
        Me.rtxt_descripcion.Size = New System.Drawing.Size(724, 156)
        Me.rtxt_descripcion.TabIndex = 5
        Me.rtxt_descripcion.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(64, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Descripción:"
        '
        'cb_Servicios
        '
        Me.cb_Servicios.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cb_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Servicios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cb_Servicios.FormattingEnabled = True
        Me.cb_Servicios.Location = New System.Drawing.Point(243, 177)
        Me.cb_Servicios.Name = "cb_Servicios"
        Me.cb_Servicios.Size = New System.Drawing.Size(401, 29)
        Me.cb_Servicios.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(37, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Procedimiento: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hora:"
        '
        'dtp_hora
        '
        Me.dtp_hora.CustomFormat = "hh:mm:ss"
        Me.dtp_hora.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora.Location = New System.Drawing.Point(243, 128)
        Me.dtp_hora.Name = "dtp_hora"
        Me.dtp_hora.Size = New System.Drawing.Size(401, 27)
        Me.dtp_hora.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(105, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_fecha.Location = New System.Drawing.Point(243, 76)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(401, 27)
        Me.dtp_fecha.TabIndex = 1
        '
        'lbl_Paciente
        '
        Me.lbl_Paciente.AutoSize = True
        Me.lbl_Paciente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Paciente.ForeColor = System.Drawing.Color.White
        Me.lbl_Paciente.Location = New System.Drawing.Point(493, 19)
        Me.lbl_Paciente.Name = "lbl_Paciente"
        Me.lbl_Paciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_Paciente.TabIndex = 11
        Me.lbl_Paciente.Text = "Label1"
        '
        'checkB_Asistencia
        '
        Me.checkB_Asistencia.AutoSize = True
        Me.checkB_Asistencia.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.checkB_Asistencia.Location = New System.Drawing.Point(60, 228)
        Me.checkB_Asistencia.Name = "checkB_Asistencia"
        Me.checkB_Asistencia.Size = New System.Drawing.Size(108, 25)
        Me.checkB_Asistencia.TabIndex = 4
        Me.checkB_Asistencia.Text = "Asistencia"
        Me.checkB_Asistencia.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_EliminarCita)
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.lbl_Paciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 58)
        Me.Panel1.TabIndex = 20
        '
        'btn_EliminarCita
        '
        Me.btn_EliminarCita.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_EliminarCita.FlatAppearance.BorderSize = 0
        Me.btn_EliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EliminarCita.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EliminarCita.ForeColor = System.Drawing.Color.White
        Me.btn_EliminarCita.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btn_EliminarCita.IconColor = System.Drawing.Color.White
        Me.btn_EliminarCita.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_EliminarCita.IconSize = 38
        Me.btn_EliminarCita.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_EliminarCita.Location = New System.Drawing.Point(312, 0)
        Me.btn_EliminarCita.Name = "btn_EliminarCita"
        Me.btn_EliminarCita.Size = New System.Drawing.Size(156, 58)
        Me.btn_EliminarCita.TabIndex = 12
        Me.btn_EliminarCita.Text = "Eliminar Cita"
        Me.btn_EliminarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarCita.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.btn_registrar.IconColor = System.Drawing.Color.White
        Me.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_registrar.IconSize = 40
        Me.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_registrar.Location = New System.Drawing.Point(156, 0)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(156, 58)
        Me.btn_registrar.TabIndex = 7
        Me.btn_registrar.Text = "   Aceptar"
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
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(156, 58)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Regresar    "
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEditarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(748, 518)
        Me.Controls.Add(Me.checkB_Asistencia)
        Me.Controls.Add(Me.rtxt_descripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_Servicios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_hora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEditarCita"
        Me.Text = "Editar Cita"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxt_descripcion As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_Servicios As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_hora As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents lbl_Paciente As Label
    Friend WithEvents checkB_Asistencia As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_registrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_EliminarCita As FontAwesome.Sharp.IconButton
End Class
