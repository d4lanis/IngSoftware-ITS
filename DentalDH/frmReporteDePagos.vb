Public Class frmReporteDePagos
    Dim con As Conexion
    Dim query, fecha1, fecha2, titulo As String
    Dim fechaVisible, nombreVisible As Boolean
    Dim itext As itext

    Private Sub frmReporteDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_fecha.Checked = False
        rb_nombre.Checked = True
        lbl_MsjError.Visible = False
        con = New Conexion
        itext = New itext
        buscarTodos()
        ocultar()
    End Sub

    Private Function validarDatos()
        lbl_MsjError.Visible = False
        If rb_nombre.Checked = False Then
            Return True
        End If
        If txt_nombre.Text = String.Empty Then
            lbl_MsjError.Text = "Hay campos vacíos, escriba un parámetro o desmarque su casilla."
            lbl_MsjError.ForeColor = Color.Red
            lbl_MsjError.Visible = True
            Return False
        End If
        Return True
    End Function

    Private Sub ocultar()
        If rb_fecha.Checked Then
            dtp_fecha1.Visible = True
            dtp_fecha2.Visible = True
            lbl_msjFecha.Visible = True
        Else
            dtp_fecha1.Visible = False
            dtp_fecha2.Visible = False
            lbl_msjFecha.Visible = False
        End If

        If rb_nombre.Checked Then
            txt_nombre.Visible = True
        Else
            txt_nombre.Visible = False
        End If
    End Sub

    Private Sub buscarTodos()
        query = "SELECT pagos.idPago, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Paciente, pacientes.numeroTelefono as Telefono, 
pagos.monto as Monto, pagos.fecha as Fecha, usuarios.nombre as Recibio FROM pagos, pacientes, usuarios, adeudos
WHERE pagos.idEmpleado=usuarios.idUsuario AND 
pagos.idAdeudo=adeudos.idAdeudo AND
adeudos.idEmpleado=usuarios.idUsuario AND
adeudos.idPaciente=pacientes.idPaciente AND pagos.monto <> 0;"
        con.fillDGV(query, dgv_pagos)
        dgv_pagos.Columns(0).Visible = False
    End Sub

    Private Sub buscarNombre()
        query = "SELECT pagos.idPago, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Paciente, pacientes.numeroTelefono as Telefono, 
pagos.monto as Monto, pagos.fecha as Fecha, usuarios.nombre as Recibio FROM pagos, pacientes, usuarios, adeudos
WHERE pagos.idEmpleado=usuarios.idUsuario AND 
pagos.idAdeudo=adeudos.idAdeudo AND
adeudos.idEmpleado=usuarios.idUsuario AND
adeudos.idPaciente=pacientes.idPaciente AND
concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) like '%" & txt_nombre.Text & "%' AND pagos.monto <> 0;"
        con.fillDGV(query, dgv_pagos)
        dgv_pagos.Columns(0).Visible = False

    End Sub

    Private Sub recuperarFechas()
        fecha1 = Format(dtp_fecha1.Value, "yyyy-MM-dd")
        fecha2 = Format(dtp_fecha2.Value, "yyyy-MM-dd")
    End Sub

    Private Sub buscarFecha()
        recuperarFechas()
        query = "SELECT pagos.idPago, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Paciente, pacientes.numeroTelefono as Telefono, 
pagos.monto as Monto, pagos.fecha as Fecha, usuarios.nombre as Recibio FROM pagos, pacientes, usuarios, adeudos
WHERE pagos.idEmpleado=usuarios.idUsuario AND 
pagos.idAdeudo=adeudos.idAdeudo AND
adeudos.idEmpleado=usuarios.idUsuario AND
adeudos.idPaciente=pacientes.idPaciente AND
pagos.fecha >= '" & fecha1 & "' AND
pagos.fecha <= '" & fecha2 & "' AND pagos.monto <> 0;"
        con.fillDGV(query, dgv_pagos)
        dgv_pagos.Columns(0).Visible = False

    End Sub

    Private Sub btn_buscarTodos_Click(sender As Object, e As EventArgs) Handles btn_buscarTodos.Click
        rb_nombre.Checked = False
        rb_fecha.Checked = False
        lbl_MsjError.Visible = False
        ocultar()
        buscarTodos()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        buscar()
    End Sub

    Private Sub buscar()
        If validarDatos() Then
            If rb_fecha.Checked And rb_nombre.Checked Then
                buscarAmbos()
            ElseIf rb_fecha.Checked And rb_nombre.Checked = False Then
                buscarFecha()
            ElseIf rb_nombre.Checked And rb_fecha.Checked = False Then
                buscarNombre()
            Else
                MsgBox("No está buscando con ningún parámetro.")
            End If
        End If
    End Sub


    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        If VariablesGlobales.permiso = 1 Then
            frmMenuAdmin.Show()
        Else
            frmMenu.Show()
        End If
    End Sub

    Private Sub btn_PDF_Click(sender As Object, e As EventArgs) Handles btn_PDF.Click
        valorTitulo()
        itext.imprimirDGV(dgv_pagos, Date.Today, titulo)
    End Sub

    Private Sub dgv_pagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pagos.CellClick

        If dgv_pagos.CurrentCell.Value Is DBNull.Value Then

        Else
            If VariablesGlobales.permiso = 1 Then
                If Date.Compare(Convert.ToDateTime(dgv_pagos.Rows(e.RowIndex).Cells(4).Value.ToString), Date.Today) = 0 Then
                    If MessageBox.Show("¿Eliminar pago?", " ATENCION", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        query = "DELETE FROM pagos WHERE idPago=" & dgv_pagos.Rows(e.RowIndex).Cells(0).Value & ";"
                        con.ejecutarNoQuery(query)
                        buscar()
                    End If
                Else
                    MsgBox("Por seguridad, un pago solo se puede eliminar el mismo día que se recibió.")
                End If

            Else
                MsgBox("Necesitas permisos de administrador para ésta acción.")
            End If
        End If

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            buscar()
        End If
    End Sub

    Private Sub rb_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles rb_fecha.CheckedChanged
        ocultar()
    End Sub

    Private Sub rb_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles rb_nombre.CheckedChanged
        ocultar()
    End Sub

    Private Sub valorTitulo()
        If rb_fecha.Checked And rb_nombre.Checked Then
            titulo = "Reporte de pagos de " & txt_nombre.Text & " entre las fechas: " & fecha1 & " y " & fecha2 & "."
        ElseIf rb_nombre.Checked And rb_fecha.Checked = False Then 'Solo nombre
            titulo = "Reporte de pagos de " & txt_nombre.Text & "."
        ElseIf rb_nombre.Checked = False And rb_fecha.Checked Then
            titulo = "Reporte de pagos entre las fechas " & fecha1 & " y " & fecha2 & "."
        Else
            titulo = "Reporte de todos los pagos registrados."
        End If
    End Sub

    Private Sub buscarAmbos()
        recuperarFechas()
        query = "SELECT pagos.idPago, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Paciente, pacientes.numeroTelefono as Telefono, 
pagos.monto as Monto, pagos.fecha as Fecha, usuarios.nombre as Recibio FROM pagos, pacientes, usuarios, adeudos
WHERE pagos.idEmpleado=usuarios.idUsuario AND 
pagos.idAdeudo=adeudos.idAdeudo AND
adeudos.idEmpleado=usuarios.idUsuario AND
adeudos.idPaciente=pacientes.idPaciente AND 
pagos.fecha >= '" & fecha1 & "' AND
pagos.fecha <= '" & fecha2 & "' AND
concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) like '%" & txt_nombre.Text & "%' AND pagos.monto <> 0;"
        con.fillDGV(query, dgv_pagos)
        dgv_pagos.Columns(0).Visible = False

    End Sub


End Class