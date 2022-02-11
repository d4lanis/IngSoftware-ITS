<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarAdeudo
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
        Me.lbl_datosPaciente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_concepto = New System.Windows.Forms.TextBox()
        Me.lbl_deudaTotal = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_registrar = New FontAwesome.Sharp.IconButton()
        Me.btn_cancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_datosPaciente
        '
        Me.lbl_datosPaciente.AutoSize = True
        Me.lbl_datosPaciente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_datosPaciente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_datosPaciente.Location = New System.Drawing.Point(116, 60)
        Me.lbl_datosPaciente.Name = "lbl_datosPaciente"
        Me.lbl_datosPaciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_datosPaciente.TabIndex = 0
        Me.lbl_datosPaciente.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(22, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Adeudo por el monto de: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(22, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark
        Me.dtp_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(275, 279)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(120, 27)
        Me.dtp_fecha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(22, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Concepto"
        '
        'txt_concepto
        '
        Me.txt_concepto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_concepto.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_concepto.ForeColor = System.Drawing.Color.White
        Me.txt_concepto.Location = New System.Drawing.Point(275, 199)
        Me.txt_concepto.MaxLength = 70
        Me.txt_concepto.Multiline = True
        Me.txt_concepto.Name = "txt_concepto"
        Me.txt_concepto.Size = New System.Drawing.Size(344, 61)
        Me.txt_concepto.TabIndex = 2
        '
        'lbl_deudaTotal
        '
        Me.lbl_deudaTotal.AutoSize = True
        Me.lbl_deudaTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_deudaTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_deudaTotal.Location = New System.Drawing.Point(22, 107)
        Me.lbl_deudaTotal.Name = "lbl_deudaTotal"
        Me.lbl_deudaTotal.Size = New System.Drawing.Size(61, 21)
        Me.lbl_deudaTotal.TabIndex = 0
        Me.lbl_deudaTotal.Text = "Label1"
        '
        'txt_monto
        '
        Me.txt_monto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_monto.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_monto.Location = New System.Drawing.Point(275, 152)
        Me.txt_monto.Mask = "99999"
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 47)
        Me.Panel1.TabIndex = 7
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
        Me.btn_registrar.TabIndex = 4
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.btn_cancelar.IconColor = System.Drawing.Color.White
        Me.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cancelar.IconSize = 40
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(0, 0)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(127, 47)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frmAgregarAdeudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(643, 371)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.lbl_deudaTotal)
        Me.Controls.Add(Me.txt_concepto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_datosPaciente)
        Me.Name = "frmAgregarAdeudo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar adeudo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_datosPaciente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_concepto As TextBox
    Friend WithEvents lbl_deudaTotal As Label
    Friend WithEvents txt_monto As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_registrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cancelar As FontAwesome.Sharp.IconButton
End Class
