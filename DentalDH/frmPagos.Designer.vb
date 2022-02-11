<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.lbl_datosDelPaciente = New System.Windows.Forms.Label()
        Me.dgv_Adeudos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ll_verPagos = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_Adeudos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_datosDelPaciente
        '
        Me.lbl_datosDelPaciente.AutoSize = True
        Me.lbl_datosDelPaciente.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_datosDelPaciente.ForeColor = System.Drawing.Color.White
        Me.lbl_datosDelPaciente.Location = New System.Drawing.Point(179, 13)
        Me.lbl_datosDelPaciente.Name = "lbl_datosDelPaciente"
        Me.lbl_datosDelPaciente.Size = New System.Drawing.Size(61, 21)
        Me.lbl_datosDelPaciente.TabIndex = 0
        Me.lbl_datosDelPaciente.Text = "Label1"
        '
        'dgv_Adeudos
        '
        Me.dgv_Adeudos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Adeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Adeudos.Location = New System.Drawing.Point(12, 114)
        Me.dgv_Adeudos.Name = "dgv_Adeudos"
        Me.dgv_Adeudos.Size = New System.Drawing.Size(1036, 404)
        Me.dgv_Adeudos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(263, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione un adeudo para registrar un pago sobre el."
        '
        'll_verPagos
        '
        Me.ll_verPagos.AutoSize = True
        Me.ll_verPagos.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.ll_verPagos.LinkColor = System.Drawing.Color.White
        Me.ll_verPagos.Location = New System.Drawing.Point(714, 31)
        Me.ll_verPagos.Name = "ll_verPagos"
        Me.ll_verPagos.Size = New System.Drawing.Size(347, 16)
        Me.ll_verPagos.TabIndex = 4
        Me.ll_verPagos.TabStop = True
        Me.ll_verPagos.Text = "¿Ver pagos de clientes? ¿Eliminar un pago erroneo? Click aquí."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Adeudos del cliente:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.ll_verPagos)
        Me.Panel1.Controls.Add(Me.lbl_datosDelPaciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 47)
        Me.Panel1.TabIndex = 13
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
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1061, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Adeudos)
        Me.Name = "frmPagos"
        Me.Text = "Control de Pagos del Paciente"
        CType(Me.dgv_Adeudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_datosDelPaciente As Label
    Friend WithEvents dgv_Adeudos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ll_verPagos As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
End Class
