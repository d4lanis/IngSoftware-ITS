<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarLogo
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
        Me.txt_RutaImagen = New System.Windows.Forms.TextBox()
        Me.btn_Examinar = New System.Windows.Forms.Button()
        Me.btn_SubirLogo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_RutaImagen
        '
        Me.txt_RutaImagen.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txt_RutaImagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_RutaImagen.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txt_RutaImagen.Location = New System.Drawing.Point(68, 181)
        Me.txt_RutaImagen.Name = "txt_RutaImagen"
        Me.txt_RutaImagen.ReadOnly = True
        Me.txt_RutaImagen.Size = New System.Drawing.Size(286, 20)
        Me.txt_RutaImagen.TabIndex = 0
        '
        'btn_Examinar
        '
        Me.btn_Examinar.BackColor = System.Drawing.Color.Gray
        Me.btn_Examinar.FlatAppearance.BorderSize = 0
        Me.btn_Examinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Examinar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_Examinar.Location = New System.Drawing.Point(371, 181)
        Me.btn_Examinar.Name = "btn_Examinar"
        Me.btn_Examinar.Size = New System.Drawing.Size(95, 29)
        Me.btn_Examinar.TabIndex = 1
        Me.btn_Examinar.Text = "Examinar"
        Me.btn_Examinar.UseVisualStyleBackColor = False
        '
        'btn_SubirLogo
        '
        Me.btn_SubirLogo.BackColor = System.Drawing.Color.Gray
        Me.btn_SubirLogo.FlatAppearance.BorderSize = 0
        Me.btn_SubirLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SubirLogo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btn_SubirLogo.Location = New System.Drawing.Point(371, 263)
        Me.btn_SubirLogo.Name = "btn_SubirLogo"
        Me.btn_SubirLogo.Size = New System.Drawing.Size(95, 29)
        Me.btn_SubirLogo.TabIndex = 2
        Me.btn_SubirLogo.Text = "Subir Logo"
        Me.btn_SubirLogo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar un archivo de imagen:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Location = New System.Drawing.Point(180, 82)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxLogo.TabIndex = 5
        Me.PictureBoxLogo.TabStop = False
        Me.PictureBoxLogo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 58)
        Me.Panel1.TabIndex = 9
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
        Me.btnCancelar.Text = "Regresar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(523, 318)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 71
        Me.LineShape1.X2 = 352
        Me.LineShape1.Y1 = 208
        Me.LineShape1.Y2 = 208
        '
        'frmCambiarLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(523, 318)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_SubirLogo)
        Me.Controls.Add(Me.btn_Examinar)
        Me.Controls.Add(Me.txt_RutaImagen)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmCambiarLogo"
        Me.Text = "Cambiar Logo"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_RutaImagen As TextBox
    Friend WithEvents btn_Examinar As Button
    Friend WithEvents btn_SubirLogo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
