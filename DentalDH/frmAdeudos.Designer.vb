<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdeudos
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
        Me.dgv_adeudos = New System.Windows.Forms.DataGridView()
        Me.lbl_datosPaciente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_agregar = New FontAwesome.Sharp.IconButton()
        Me.btn_regresar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_adeudos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_adeudos
        '
        Me.dgv_adeudos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_adeudos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_adeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_adeudos.Location = New System.Drawing.Point(12, 127)
        Me.dgv_adeudos.Name = "dgv_adeudos"
        Me.dgv_adeudos.Size = New System.Drawing.Size(790, 442)
        Me.dgv_adeudos.TabIndex = 0
        '
        'lbl_datosPaciente
        '
        Me.lbl_datosPaciente.AutoSize = True
        Me.lbl_datosPaciente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_datosPaciente.ForeColor = System.Drawing.Color.White
        Me.lbl_datosPaciente.Location = New System.Drawing.Point(342, 15)
        Me.lbl_datosPaciente.Name = "lbl_datosPaciente"
        Me.lbl_datosPaciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_datosPaciente.TabIndex = 3
        Me.lbl_datosPaciente.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione un adeudo para eliminarlo."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.btn_regresar)
        Me.Panel1.Controls.Add(Me.lbl_datosPaciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 47)
        Me.Panel1.TabIndex = 5
        '
        'btn_agregar
        '
        Me.btn_agregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.White
        Me.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_agregar.IconColor = System.Drawing.Color.White
        Me.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_agregar.IconSize = 40
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_agregar.Location = New System.Drawing.Point(127, 0)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(127, 47)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_regresar
        '
        Me.btn_regresar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_regresar.FlatAppearance.BorderSize = 0
        Me.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_regresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.ForeColor = System.Drawing.Color.White
        Me.btn_regresar.IconChar = FontAwesome.Sharp.IconChar.Backward
        Me.btn_regresar.IconColor = System.Drawing.Color.White
        Me.btn_regresar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_regresar.IconSize = 40
        Me.btn_regresar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_regresar.Location = New System.Drawing.Point(0, 0)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(127, 47)
        Me.btn_regresar.TabIndex = 4
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'frmAdeudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(814, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_adeudos)
        Me.Name = "frmAdeudos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adeudos del Paciente"
        CType(Me.dgv_adeudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_adeudos As DataGridView
    Friend WithEvents lbl_datosPaciente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_regresar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_agregar As FontAwesome.Sharp.IconButton
End Class
