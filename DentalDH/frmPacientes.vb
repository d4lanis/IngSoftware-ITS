Public Class frmPacientes

    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim dt As DataTable

    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comm = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes order by nombre;"
        con.fillDGV(comm, dgv_Pacientes)
        dgv_Pacientes.Columns(0).Visible = False
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        registrar()
    End Sub

    Private Sub registrar()
        con.fillDGV(seleccionarQuery, dgv_Pacientes)
        dgv_Pacientes.Columns(0).Visible = False
    End Sub

    Private Function seleccionarQuery()
        Dim query As String
        If txt_buscarNombre.Text = String.Empty And mtxt_buscarTel.Text = String.Empty Then
            MsgBox("Ningún campo tiene datos. Escriba al menos el nombre o el número telefónico del paciente, o ambos.")
            query = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes order by nombre;"
        ElseIf txt_buscarNombre.Text = String.Empty And mtxt_buscarTel.Text.Length > 0 Then
            'buscar solo con el número
            query = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes
WHERE numeroTelefono like '" & mtxt_buscarTel.Text & "%' order by nombre;"
        ElseIf txt_buscarNombre.Text.Length > 0 And mtxt_buscarTel.Text = String.Empty Then
            'buscar solo con el nombre
            query = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes
WHERE CONCAT_WS(' ', nombre, aPaterno, aMaterno) like '%" & txt_buscarNombre.Text & "%' order by nombre;"
        Else
            'buscar con ambos
            query = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes
WHERE numeroTelefono like '" & mtxt_buscarTel.Text & "%' AND CONCAT_WS(' ', nombre, aPaterno, aMaterno) like '%" & txt_buscarNombre.Text & "%' order by nombre;"
        End If
        Return query
    End Function

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If VariablesGlobales.permiso = 1 Then
            Me.Close()
            frmMenuAdmin.Show()
        Else
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub btn_buscarTodos_Click(sender As Object, e As EventArgs) Handles btn_buscarTodos.Click
        comm = "SELECT idPaciente, nombre, aPaterno, aMaterno, numeroTelefono as Numero, correoElectronico as Email, fechaNacimiento as Nacimiento FROM pacientes order by nombre;"
        con.fillDGV(comm, dgv_Pacientes)
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
        frmRegistroPaciente.Show()

    End Sub

    Private Sub dgv_Pacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pacientes.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= dgv_Pacientes.Rows.Count - 1 Then
            VariablesGlobales.idPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(0).Value
            VariablesGlobales.nombrePaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(1).Value
            VariablesGlobales.paternoPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(2).Value
            VariablesGlobales.maternoPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(3).Value
            VariablesGlobales.telefonoPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(4).Value
            VariablesGlobales.correoPaciente = dgv_Pacientes.Rows(e.RowIndex).Cells(5).Value
            VariablesGlobales.fechaNacimiento = dgv_Pacientes.Rows(e.RowIndex).Cells(6).Value
            Me.Close()
            frmRegistroPacientesMenu.Show()
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