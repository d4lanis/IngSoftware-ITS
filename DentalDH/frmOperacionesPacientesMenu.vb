Public Class frmOperacionesPacientesMenu
    Dim con As Conexion
    Dim query As String
    Dim dt As DataTable

    Private Sub frmOperacionesPacientesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes order by nombre;"
        fillDgv_Pacientes()
    End Sub

    Private Sub fillDgv_Pacientes()
        query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes;"
        con.fillDGV(query, dgv_Pacientes)
        dgv_Pacientes.Columns(0).Visible = False
    End Sub

    Private Function seleccionarQuery()
        Dim query As String
        If txt_buscarNombre.Text = String.Empty And mtxt_buscarTel.Text = String.Empty Then
            MsgBox("Ningún campo tiene datos. Escriba al menos el nombre o el número telefónico del paciente, o ambos.")
            query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes order by nombre;"
        ElseIf txt_buscarNombre.Text = String.Empty And mtxt_buscarTel.Text.Length > 0 Then
            'buscar solo con el número
            query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes
WHERE numeroTelefono like '" & mtxt_buscarTel.Text & "%' order by nombre;"
        ElseIf txt_buscarNombre.Text.Length > 0 And mtxt_buscarTel.Text = String.Empty Then
            'buscar solo con el nombre
            query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes
WHERE nombre like '%" & txt_buscarNombre.Text & "%' order by nombre;"
        Else
            'buscar con ambos
            query = "SELECT idPaciente, concat_ws(' ', nombre, aPaterno, aMaterno) as nombre, numeroTelefono as Numero, correoElectronico as EMail, fechaNacimiento as Nacimiento FROM pacientes
WHERE numeroTelefono like '" & mtxt_buscarTel.Text & "%' AND nombre like '%" & txt_buscarNombre.Text & "%' order by nombre;"
        End If
        Return query
    End Function

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        registrar()
    End Sub

    Private Sub registrar()
        con.fillDGV(seleccionarQuery, dgv_Pacientes)
    End Sub
    'Vuelve a poblar el dgv_Pacientes
    Private Sub btn_buscarTodos_Click(sender As Object, e As EventArgs) Handles btn_buscarTodos.Click
        fillDgv_Pacientes()
    End Sub

    Private Sub dgv_Pacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pacientes.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= dgv_Pacientes.Rows.Count - 1 Then
            VariablesGlobales.idPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(0).Value
            VariablesGlobales.nombrePaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(1).Value
            VariablesGlobales.telefonoPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(2).Value
            Me.Hide()
            frmOperacionesSobreElPaciente.Show()
        End If
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If VariablesGlobales.permiso = 1 Then
            Me.Close()
            frmMenuAdmin.Show()
        Else
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub txt_buscarNombre_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscarNombre.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            registrar()
        End If
    End Sub

    Private Sub mtxt_buscarTel_MaskInputRejected(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles mtxt_buscarTel.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            registrar()
        End If
    End Sub
End Class