<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Gray
        Me.btn_aceptar.FlatAppearance.BorderSize = 0
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(306, 252)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(89, 31)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Gray
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(505, 252)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(84, 31)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(405, 147)
        Me.txt_password.MaxLength = 16
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(198, 20)
        Me.txt_password.TabIndex = 2
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(405, 101)
        Me.txt_usuario.MaxLength = 35
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(198, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(303, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(266, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(345, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INICIO DE SESION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 311)
        Me.Panel1.TabIndex = 7
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 115
        Me.IconPictureBox1.Location = New System.Drawing.Point(32, 94)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(146, 115)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(213, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 311)
        Me.Panel2.TabIndex = 8
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(665, 311)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 405
        Me.LineShape2.X2 = 600
        Me.LineShape2.Y1 = 175
        Me.LineShape2.Y2 = 175
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 405
        Me.LineShape1.X2 = 600
        Me.LineShape1.Y1 = 129
        Me.LineShape1.Y2 = 129
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(665, 311)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema"
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
