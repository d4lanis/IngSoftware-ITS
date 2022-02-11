<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegistroPacientes = New FontAwesome.Sharp.IconButton()
        Me.btnOpSobrePacientes = New FontAwesome.Sharp.IconButton()
        Me.btnAgendaDeCitas = New FontAwesome.Sharp.IconButton()
        Me.btnReporteDePagos = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnCatalogoDeServicios = New FontAwesome.Sharp.IconButton()
        Me.btnLogo = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnCerrarSesión = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = Global.DentalDH.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(212, 56)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(955, 444)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRegistroPacientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpSobrePacientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAgendaDeCitas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReporteDePagos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUsuarios)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCatalogoDeServicios)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLogo)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(208, 500)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 40)
        Me.Panel5.TabIndex = 0
        '
        'btnRegistroPacientes
        '
        Me.btnRegistroPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistroPacientes.FlatAppearance.BorderSize = 0
        Me.btnRegistroPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroPacientes.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnRegistroPacientes.ForeColor = System.Drawing.Color.White
        Me.btnRegistroPacientes.IconChar = FontAwesome.Sharp.IconChar.HospitalUser
        Me.btnRegistroPacientes.IconColor = System.Drawing.Color.White
        Me.btnRegistroPacientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistroPacientes.IconSize = 46
        Me.btnRegistroPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroPacientes.Location = New System.Drawing.Point(3, 49)
        Me.btnRegistroPacientes.Name = "btnRegistroPacientes"
        Me.btnRegistroPacientes.Size = New System.Drawing.Size(200, 51)
        Me.btnRegistroPacientes.TabIndex = 0
        Me.btnRegistroPacientes.Text = "Registro Pacientes"
        Me.btnRegistroPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistroPacientes.UseVisualStyleBackColor = True
        '
        'btnOpSobrePacientes
        '
        Me.btnOpSobrePacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOpSobrePacientes.FlatAppearance.BorderSize = 0
        Me.btnOpSobrePacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpSobrePacientes.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnOpSobrePacientes.ForeColor = System.Drawing.Color.White
        Me.btnOpSobrePacientes.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnOpSobrePacientes.IconColor = System.Drawing.Color.White
        Me.btnOpSobrePacientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOpSobrePacientes.IconSize = 44
        Me.btnOpSobrePacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpSobrePacientes.Location = New System.Drawing.Point(3, 106)
        Me.btnOpSobrePacientes.Name = "btnOpSobrePacientes"
        Me.btnOpSobrePacientes.Size = New System.Drawing.Size(200, 51)
        Me.btnOpSobrePacientes.TabIndex = 1
        Me.btnOpSobrePacientes.Text = "Operaciones sobre Pacientes"
        Me.btnOpSobrePacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOpSobrePacientes.UseVisualStyleBackColor = True
        '
        'btnAgendaDeCitas
        '
        Me.btnAgendaDeCitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgendaDeCitas.FlatAppearance.BorderSize = 0
        Me.btnAgendaDeCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaDeCitas.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnAgendaDeCitas.ForeColor = System.Drawing.Color.White
        Me.btnAgendaDeCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt
        Me.btnAgendaDeCitas.IconColor = System.Drawing.Color.White
        Me.btnAgendaDeCitas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgendaDeCitas.IconSize = 46
        Me.btnAgendaDeCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgendaDeCitas.Location = New System.Drawing.Point(3, 163)
        Me.btnAgendaDeCitas.Name = "btnAgendaDeCitas"
        Me.btnAgendaDeCitas.Size = New System.Drawing.Size(200, 51)
        Me.btnAgendaDeCitas.TabIndex = 2
        Me.btnAgendaDeCitas.Text = "Agenda de Citas"
        Me.btnAgendaDeCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendaDeCitas.UseVisualStyleBackColor = True
        '
        'btnReporteDePagos
        '
        Me.btnReporteDePagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReporteDePagos.FlatAppearance.BorderSize = 0
        Me.btnReporteDePagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteDePagos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnReporteDePagos.ForeColor = System.Drawing.Color.White
        Me.btnReporteDePagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.btnReporteDePagos.IconColor = System.Drawing.Color.White
        Me.btnReporteDePagos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReporteDePagos.IconSize = 46
        Me.btnReporteDePagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteDePagos.Location = New System.Drawing.Point(3, 220)
        Me.btnReporteDePagos.Name = "btnReporteDePagos"
        Me.btnReporteDePagos.Size = New System.Drawing.Size(200, 51)
        Me.btnReporteDePagos.TabIndex = 3
        Me.btnReporteDePagos.Text = "Reporte de Pagos"
        Me.btnReporteDePagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporteDePagos.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnUsuarios.IconColor = System.Drawing.Color.White
        Me.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuarios.IconSize = 46
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(3, 277)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(200, 51)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnCatalogoDeServicios
        '
        Me.btnCatalogoDeServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCatalogoDeServicios.FlatAppearance.BorderSize = 0
        Me.btnCatalogoDeServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatalogoDeServicios.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnCatalogoDeServicios.ForeColor = System.Drawing.Color.White
        Me.btnCatalogoDeServicios.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell
        Me.btnCatalogoDeServicios.IconColor = System.Drawing.Color.White
        Me.btnCatalogoDeServicios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCatalogoDeServicios.IconSize = 46
        Me.btnCatalogoDeServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogoDeServicios.Location = New System.Drawing.Point(3, 334)
        Me.btnCatalogoDeServicios.Name = "btnCatalogoDeServicios"
        Me.btnCatalogoDeServicios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCatalogoDeServicios.Size = New System.Drawing.Size(200, 51)
        Me.btnCatalogoDeServicios.TabIndex = 5
        Me.btnCatalogoDeServicios.Text = "Servicios"
        Me.btnCatalogoDeServicios.UseVisualStyleBackColor = True
        '
        'btnLogo
        '
        Me.btnLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.btnLogo.IconColor = System.Drawing.Color.White
        Me.btnLogo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogo.IconSize = 46
        Me.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogo.Location = New System.Drawing.Point(3, 391)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(200, 51)
        Me.btnLogo.TabIndex = 6
        Me.btnLogo.Text = "     Cambiar Logo"
        Me.btnLogo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.btnCerrarSesión)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(208, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 51)
        Me.Panel1.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(378, 28)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(50, 17)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "Label1"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(377, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(61, 19)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Label1"
        '
        'btnCerrarSesión
        '
        Me.btnCerrarSesión.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCerrarSesión.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesión.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnCerrarSesión.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesión.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerrarSesión.IconColor = System.Drawing.Color.White
        Me.btnCerrarSesión.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrarSesión.IconSize = 46
        Me.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesión.Location = New System.Drawing.Point(0, 0)
        Me.btnCerrarSesión.Name = "btnCerrarSesión"
        Me.btnCerrarSesión.Size = New System.Drawing.Size(168, 51)
        Me.btnCerrarSesión.TabIndex = 1
        Me.btnCerrarSesión.Text = "Cerrar Sesión"
        Me.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarSesión.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(208, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 449)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 5)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.logo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1167, 500)
        Me.Panel4.TabIndex = 6
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        Me.Reloj.Interval = 500
        '
        'frmMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logo As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRegistroPacientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpSobrePacientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgendaDeCitas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReporteDePagos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCatalogoDeServicios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrarSesión As FontAwesome.Sharp.IconButton
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Reloj As Timer
End Class
