<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarPaciente
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(40, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(40, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 58)
        Me.Panel1.TabIndex = 31
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnEliminar.IconColor = System.Drawing.Color.White
        Me.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEliminar.IconSize = 40
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEliminar.Location = New System.Drawing.Point(148, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 58)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar  "
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
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
        Me.btnCancelar.Text = "Cancelar  "
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEliminarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(458, 326)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEliminarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEliminarPaciente"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
End Class
