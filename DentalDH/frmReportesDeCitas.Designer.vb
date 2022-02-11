<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesDeCitas
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
        Me.dtp_fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_pdf = New System.Windows.Forms.Button()
        Me.dgv_Citas = New System.Windows.Forms.DataGridView()
        Me.btn_buscarHoy = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_Citas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_fecha1
        '
        Me.dtp_fecha1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fecha1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_fecha1.Location = New System.Drawing.Point(15, 98)
        Me.dtp_fecha1.Name = "dtp_fecha1"
        Me.dtp_fecha1.Size = New System.Drawing.Size(304, 27)
        Me.dtp_fecha1.TabIndex = 0
        '
        'dtp_fecha2
        '
        Me.dtp_fecha2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fecha2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtp_fecha2.Location = New System.Drawing.Point(365, 98)
        Me.dtp_fecha2.Name = "dtp_fecha2"
        Me.dtp_fecha2.Size = New System.Drawing.Size(304, 27)
        Me.dtp_fecha2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(332, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_Buscar.ForeColor = System.Drawing.Color.White
        Me.btn_Buscar.Location = New System.Drawing.Point(675, 95)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(80, 36)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_pdf
        '
        Me.btn_pdf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_pdf.FlatAppearance.BorderSize = 0
        Me.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pdf.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_pdf.ForeColor = System.Drawing.Color.White
        Me.btn_pdf.Location = New System.Drawing.Point(761, 95)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(125, 36)
        Me.btn_pdf.TabIndex = 4
        Me.btn_pdf.Text = "Generar PDF"
        Me.btn_pdf.UseVisualStyleBackColor = False
        '
        'dgv_Citas
        '
        Me.dgv_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Citas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.dgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Citas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Citas.Location = New System.Drawing.Point(12, 150)
        Me.dgv_Citas.MultiSelect = False
        Me.dgv_Citas.Name = "dgv_Citas"
        Me.dgv_Citas.ReadOnly = True
        Me.dgv_Citas.Size = New System.Drawing.Size(982, 383)
        Me.dgv_Citas.TabIndex = 6
        '
        'btn_buscarHoy
        '
        Me.btn_buscarHoy.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_buscarHoy.FlatAppearance.BorderSize = 0
        Me.btn_buscarHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarHoy.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscarHoy.ForeColor = System.Drawing.Color.White
        Me.btn_buscarHoy.Location = New System.Drawing.Point(892, 95)
        Me.btn_buscarHoy.Name = "btn_buscarHoy"
        Me.btn_buscarHoy.Size = New System.Drawing.Size(102, 36)
        Me.btn_buscarHoy.TabIndex = 7
        Me.btn_buscarHoy.Text = "Buscar hoy"
        Me.btn_buscarHoy.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 47)
        Me.Panel1.TabIndex = 19
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
        'frmReportesDeCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1006, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_buscarHoy)
        Me.Controls.Add(Me.dgv_Citas)
        Me.Controls.Add(Me.btn_pdf)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fecha2)
        Me.Controls.Add(Me.dtp_fecha1)
        Me.Name = "frmReportesDeCitas"
        Me.Text = "Agenda de Citas"
        CType(Me.dgv_Citas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_fecha1 As DateTimePicker
    Friend WithEvents dtp_fecha2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_pdf As Button
    Friend WithEvents dgv_Citas As DataGridView
    Friend WithEvents btn_buscarHoy As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
End Class
