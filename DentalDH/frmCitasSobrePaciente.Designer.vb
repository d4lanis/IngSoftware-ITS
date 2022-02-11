<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitasSobrePaciente
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
        Me.lbl_Paciente = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hora = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Servicios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_registrar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Paciente
        '
        Me.lbl_Paciente.AutoSize = True
        Me.lbl_Paciente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_Paciente.ForeColor = System.Drawing.Color.White
        Me.lbl_Paciente.Location = New System.Drawing.Point(305, 19)
        Me.lbl_Paciente.Name = "lbl_Paciente"
        Me.lbl_Paciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_Paciente.TabIndex = 0
        Me.lbl_Paciente.Text = "Label1"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_fecha.Location = New System.Drawing.Point(244, 90)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(311, 27)
        Me.dtp_fecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(105, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'dtp_hora
        '
        Me.dtp_hora.CustomFormat = "hh:mm:ss"
        Me.dtp_hora.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora.Location = New System.Drawing.Point(244, 167)
        Me.dtp_hora.Name = "dtp_hora"
        Me.dtp_hora.Size = New System.Drawing.Size(311, 27)
        Me.dtp_hora.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(37, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Procedimiento: "
        '
        'cb_Servicios
        '
        Me.cb_Servicios.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cb_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Servicios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cb_Servicios.FormattingEnabled = True
        Me.cb_Servicios.Location = New System.Drawing.Point(244, 245)
        Me.cb_Servicios.Name = "cb_Servicios"
        Me.cb_Servicios.Size = New System.Drawing.Size(311, 29)
        Me.cb_Servicios.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(64, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Descripción:"
        '
        'rtxt_descripcion
        '
        Me.rtxt_descripcion.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rtxt_descripcion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_descripcion.Location = New System.Drawing.Point(25, 342)
        Me.rtxt_descripcion.Name = "rtxt_descripcion"
        Me.rtxt_descripcion.Size = New System.Drawing.Size(572, 156)
        Me.rtxt_descripcion.TabIndex = 4
        Me.rtxt_descripcion.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.lbl_Paciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 58)
        Me.Panel1.TabIndex = 11
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
        Me.btn_registrar.Location = New System.Drawing.Point(148, 0)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(127, 58)
        Me.btn_registrar.TabIndex = 5
        Me.btn_registrar.Text = "Registrar"
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
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 58)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCitasSobrePaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(636, 518)
        Me.Controls.Add(Me.rtxt_descripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_Servicios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_hora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCitasSobrePaciente"
        Me.Text = "Agendar Cita"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Paciente As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_hora As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_Servicios As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rtxt_descripcion As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_registrar As FontAwesome.Sharp.IconButton
End Class
