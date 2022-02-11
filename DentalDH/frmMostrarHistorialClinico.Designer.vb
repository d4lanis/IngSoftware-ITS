<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarHistorialClinico
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
        Me.txt_historial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(321, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'txt_historial
        '
        Me.txt_historial.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_historial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_historial.Location = New System.Drawing.Point(12, 89)
        Me.txt_historial.Multiline = True
        Me.txt_historial.Name = "txt_historial"
        Me.txt_historial.ReadOnly = True
        Me.txt_historial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_historial.Size = New System.Drawing.Size(960, 360)
        Me.txt_historial.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(808, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Historial Clinico del Paciente, se desea agregar un registro a este expediente pr" &
    "esione el boton agregar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 47)
        Me.Panel1.TabIndex = 7
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
        'frmMostrarHistorialClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_historial)
        Me.Name = "frmMostrarHistorialClinico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMostrarHistorialClinico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_historial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
End Class
