<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarHistorial
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
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(80, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(379, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripcion del historial (200 caracteres)"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_descripcion.Location = New System.Drawing.Point(14, 166)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_descripcion.MaxLength = 200
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(664, 265)
        Me.txt_descripcion.TabIndex = 2
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(558, 121)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(121, 26)
        Me.dtp_fecha.TabIndex = 1
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
        Me.Panel1.Size = New System.Drawing.Size(693, 58)
        Me.Panel1.TabIndex = 5
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
        Me.btnRegistrar.Size = New System.Drawing.Size(148, 58)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Registrar"
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
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAgregarHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(693, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAgregarHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar registro a Historial Clinico"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrar As FontAwesome.Sharp.IconButton
End Class
