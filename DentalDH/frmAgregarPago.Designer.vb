<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarPago
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
        Me.lbl_DatosDePaciente = New System.Windows.Forms.Label()
        Me.lbl_deudaActual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_Monto = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_DatosDePaciente
        '
        Me.lbl_DatosDePaciente.AutoSize = True
        Me.lbl_DatosDePaciente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_DatosDePaciente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_DatosDePaciente.Location = New System.Drawing.Point(96, 90)
        Me.lbl_DatosDePaciente.Name = "lbl_DatosDePaciente"
        Me.lbl_DatosDePaciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_DatosDePaciente.TabIndex = 0
        Me.lbl_DatosDePaciente.Text = "Label1"
        '
        'lbl_deudaActual
        '
        Me.lbl_deudaActual.AutoSize = True
        Me.lbl_deudaActual.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_deudaActual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_deudaActual.Location = New System.Drawing.Point(96, 191)
        Me.lbl_deudaActual.Name = "lbl_deudaActual"
        Me.lbl_deudaActual.Size = New System.Drawing.Size(61, 21)
        Me.lbl_deudaActual.TabIndex = 1
        Me.lbl_deudaActual.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(23, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pago por el monto de:"
        '
        'mtxt_Monto
        '
        Me.mtxt_Monto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mtxt_Monto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxt_Monto.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.mtxt_Monto.Location = New System.Drawing.Point(224, 234)
        Me.mtxt_Monto.Mask = "999999"
        Me.mtxt_Monto.Name = "mtxt_Monto"
        Me.mtxt_Monto.Size = New System.Drawing.Size(158, 20)
        Me.mtxt_Monto.TabIndex = 3
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_fecha.Location = New System.Drawing.Point(86, 275)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(120, 21)
        Me.lbl_fecha.TabIndex = 4
        Me.lbl_fecha.Text = "A la fecha de:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 58)
        Me.Panel1.TabIndex = 8
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnRegistrar.IconColor = System.Drawing.Color.White
        Me.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrar.IconSize = 40
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(148, 0)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(175, 58)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Agregar Pago"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = True
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
        'frmAgregarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(407, 319)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.mtxt_Monto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_deudaActual)
        Me.Controls.Add(Me.lbl_DatosDePaciente)
        Me.Name = "frmAgregarPago"
        Me.Text = "frmAgregarPago"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_DatosDePaciente As Label
    Friend WithEvents lbl_deudaActual As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxt_Monto As MaskedTextBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegistrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
End Class
