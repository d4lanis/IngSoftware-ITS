<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDePagos
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
        Me.dgv_pagos = New System.Windows.Forms.DataGridView()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dtp_fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_msjFecha = New System.Windows.Forms.Label()
        Me.btn_buscarTodos = New System.Windows.Forms.Button()
        Me.btn_PDF = New System.Windows.Forms.Button()
        Me.rb_fecha = New System.Windows.Forms.CheckBox()
        Me.rb_nombre = New System.Windows.Forms.CheckBox()
        Me.lbl_MsjError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.dgv_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_pagos
        '
        Me.dgv_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pagos.Location = New System.Drawing.Point(15, 187)
        Me.dgv_pagos.Name = "dgv_pagos"
        Me.dgv_pagos.Size = New System.Drawing.Size(927, 277)
        Me.dgv_pagos.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_nombre.Location = New System.Drawing.Point(165, 114)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(396, 19)
        Me.txt_nombre.TabIndex = 1
        '
        'dtp_fecha1
        '
        Me.dtp_fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fecha1.Location = New System.Drawing.Point(165, 63)
        Me.dtp_fecha1.Name = "dtp_fecha1"
        Me.dtp_fecha1.Size = New System.Drawing.Size(299, 26)
        Me.dtp_fecha1.TabIndex = 2
        '
        'dtp_fecha2
        '
        Me.dtp_fecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_fecha2.Location = New System.Drawing.Point(494, 63)
        Me.dtp_fecha2.Name = "dtp_fecha2"
        Me.dtp_fecha2.Size = New System.Drawing.Size(299, 26)
        Me.dtp_fecha2.TabIndex = 3
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_buscar.FlatAppearance.BorderSize = 0
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Location = New System.Drawing.Point(567, 113)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(118, 29)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'lbl_msjFecha
        '
        Me.lbl_msjFecha.AutoSize = True
        Me.lbl_msjFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_msjFecha.Location = New System.Drawing.Point(470, 68)
        Me.lbl_msjFecha.Name = "lbl_msjFecha"
        Me.lbl_msjFecha.Size = New System.Drawing.Size(21, 21)
        Me.lbl_msjFecha.TabIndex = 7
        Me.lbl_msjFecha.Text = "a"
        '
        'btn_buscarTodos
        '
        Me.btn_buscarTodos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_buscarTodos.FlatAppearance.BorderSize = 0
        Me.btn_buscarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarTodos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_buscarTodos.ForeColor = System.Drawing.Color.White
        Me.btn_buscarTodos.Location = New System.Drawing.Point(691, 113)
        Me.btn_buscarTodos.Name = "btn_buscarTodos"
        Me.btn_buscarTodos.Size = New System.Drawing.Size(118, 29)
        Me.btn_buscarTodos.TabIndex = 8
        Me.btn_buscarTodos.Text = "Buscar todos"
        Me.btn_buscarTodos.UseVisualStyleBackColor = False
        '
        'btn_PDF
        '
        Me.btn_PDF.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_PDF.FlatAppearance.BorderSize = 0
        Me.btn_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PDF.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_PDF.ForeColor = System.Drawing.Color.White
        Me.btn_PDF.Location = New System.Drawing.Point(815, 113)
        Me.btn_PDF.Name = "btn_PDF"
        Me.btn_PDF.Size = New System.Drawing.Size(118, 29)
        Me.btn_PDF.TabIndex = 9
        Me.btn_PDF.Text = "PDF"
        Me.btn_PDF.UseVisualStyleBackColor = False
        '
        'rb_fecha
        '
        Me.rb_fecha.AutoSize = True
        Me.rb_fecha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rb_fecha.Location = New System.Drawing.Point(9, 86)
        Me.rb_fecha.Name = "rb_fecha"
        Me.rb_fecha.Size = New System.Drawing.Size(138, 21)
        Me.rb_fecha.TabIndex = 11
        Me.rb_fecha.Text = "Buscar con fecha"
        Me.rb_fecha.UseVisualStyleBackColor = True
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rb_nombre.Location = New System.Drawing.Point(9, 113)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(152, 21)
        Me.rb_nombre.TabIndex = 12
        Me.rb_nombre.Text = "Buscar con nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'lbl_MsjError
        '
        Me.lbl_MsjError.AutoSize = True
        Me.lbl_MsjError.Location = New System.Drawing.Point(162, 143)
        Me.lbl_MsjError.Name = "lbl_MsjError"
        Me.lbl_MsjError.Size = New System.Drawing.Size(0, 13)
        Me.lbl_MsjError.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(400, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Haga click en un pago para eliminarlo."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 47)
        Me.Panel1.TabIndex = 18
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(951, 476)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 165
        Me.LineShape1.X2 = 560
        Me.LineShape1.Y1 = 133
        Me.LineShape1.Y2 = 133
        '
        'frmReporteDePagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(951, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_MsjError)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.rb_fecha)
        Me.Controls.Add(Me.btn_PDF)
        Me.Controls.Add(Me.btn_buscarTodos)
        Me.Controls.Add(Me.lbl_msjFecha)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.dtp_fecha2)
        Me.Controls.Add(Me.dtp_fecha1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.dgv_pagos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmReporteDePagos"
        Me.Text = "frmReporteDePagos"
        CType(Me.dgv_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pagos As DataGridView
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents dtp_fecha1 As DateTimePicker
    Friend WithEvents dtp_fecha2 As DateTimePicker
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_msjFecha As Label
    Friend WithEvents btn_buscarTodos As Button
    Friend WithEvents btn_PDF As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents rb_fecha As CheckBox
    Friend WithEvents rb_nombre As CheckBox
    Friend WithEvents lbl_MsjError As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
