<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesSobreElPaciente
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
        Me.lbl_datosPaciente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnHistorialClinico = New FontAwesome.Sharp.IconButton()
        Me.BtnAdeudos = New FontAwesome.Sharp.IconButton()
        Me.btnAgendaDeCitas = New FontAwesome.Sharp.IconButton()
        Me.btnReporteDePagos = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_datosPaciente
        '
        Me.lbl_datosPaciente.AutoSize = True
        Me.lbl_datosPaciente.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosPaciente.ForeColor = System.Drawing.Color.White
        Me.lbl_datosPaciente.Location = New System.Drawing.Point(154, 12)
        Me.lbl_datosPaciente.Name = "lbl_datosPaciente"
        Me.lbl_datosPaciente.Size = New System.Drawing.Size(79, 24)
        Me.lbl_datosPaciente.TabIndex = 0
        Me.lbl_datosPaciente.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHistorialClinico)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnAdeudos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAgendaDeCitas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReporteDePagos)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(208, 308)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 48)
        Me.Panel5.TabIndex = 0
        '
        'btnHistorialClinico
        '
        Me.btnHistorialClinico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistorialClinico.FlatAppearance.BorderSize = 0
        Me.btnHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialClinico.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnHistorialClinico.ForeColor = System.Drawing.Color.White
        Me.btnHistorialClinico.IconChar = FontAwesome.Sharp.IconChar.HospitalUser
        Me.btnHistorialClinico.IconColor = System.Drawing.Color.White
        Me.btnHistorialClinico.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHistorialClinico.IconSize = 46
        Me.btnHistorialClinico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialClinico.Location = New System.Drawing.Point(3, 57)
        Me.btnHistorialClinico.Name = "btnHistorialClinico"
        Me.btnHistorialClinico.Size = New System.Drawing.Size(200, 51)
        Me.btnHistorialClinico.TabIndex = 0
        Me.btnHistorialClinico.Text = "Historial Clínico     "
        Me.btnHistorialClinico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorialClinico.UseVisualStyleBackColor = True
        '
        'BtnAdeudos
        '
        Me.BtnAdeudos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdeudos.FlatAppearance.BorderSize = 0
        Me.BtnAdeudos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdeudos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnAdeudos.ForeColor = System.Drawing.Color.White
        Me.BtnAdeudos.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.BtnAdeudos.IconColor = System.Drawing.Color.White
        Me.BtnAdeudos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnAdeudos.IconSize = 44
        Me.BtnAdeudos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdeudos.Location = New System.Drawing.Point(3, 114)
        Me.BtnAdeudos.Name = "BtnAdeudos"
        Me.BtnAdeudos.Size = New System.Drawing.Size(200, 51)
        Me.BtnAdeudos.TabIndex = 1
        Me.BtnAdeudos.Text = "Adeudos   "
        Me.BtnAdeudos.UseVisualStyleBackColor = True
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
        Me.btnAgendaDeCitas.Location = New System.Drawing.Point(3, 171)
        Me.btnAgendaDeCitas.Name = "btnAgendaDeCitas"
        Me.btnAgendaDeCitas.Size = New System.Drawing.Size(200, 51)
        Me.btnAgendaDeCitas.TabIndex = 2
        Me.btnAgendaDeCitas.Text = "Agendar Cita      "
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
        Me.btnReporteDePagos.Location = New System.Drawing.Point(3, 228)
        Me.btnReporteDePagos.Name = "btnReporteDePagos"
        Me.btnReporteDePagos.Size = New System.Drawing.Size(200, 51)
        Me.btnReporteDePagos.TabIndex = 3
        Me.btnReporteDePagos.Text = "Reporte de Pagos"
        Me.btnReporteDePagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporteDePagos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.lbl_datosPaciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(208, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 51)
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
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(148, 51)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar    "
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(208, 50)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(755, 258)
        Me.logo.TabIndex = 9
        Me.logo.TabStop = False
        '
        'frmOperacionesSobreElPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(963, 308)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmOperacionesSobreElPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de Operaciones"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_datosPaciente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnHistorialClinico As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnAdeudos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgendaDeCitas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReporteDePagos As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
    Friend WithEvents logo As PictureBox
End Class
