Public Class frmAgregarAdeudo
    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim a As DateTime
    Dim d As String
    Dim f As String
    Dim deuda As String
    Dim dt As DataTable

    Private Sub frmAgregarAdeudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Revisar query
        f = "SELECT IFNULL(SUM(a.monto), 0)- (SELECT IFNULL(SUM(p.monto), 0) FROM pagos as p, adeudos as a 
WHERE p.idAdeudo=a.idAdeudo AND
a.idPaciente=" & VariablesGlobales.idPaciente & ") as deuda from adeudos as a 
WHERE idPaciente=" & VariablesGlobales.idPaciente & ";"
        dt = con.fillDataTable(f)
        dtp_fecha.MaxDate = Date.Now
        dtp_fecha.Value = DateTime.Now
        deuda = dt.Rows(0).Item("deuda")

        lbl_deudaTotal.Text = "Deuda Total del Paciente: " & deuda
        lbl_datosPaciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
        frmAdeudos.Show()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        registrar()
    End Sub

    Private Sub registrar()
        If String.IsNullOrEmpty(txt_concepto.Text) Or String.IsNullOrEmpty(txt_monto.Text) Then
            MessageBox.Show("LLene todos los datos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            a = dtp_fecha.Value.Date.ToShortDateString
            d = Format(a, "yyyy-MM-dd")
            comm = "insert into adeudos (idPaciente, idEmpleado, concepto, monto, fecha , pagado) values (" & VariablesGlobales.idPaciente & "," & VariablesGlobales.idUsuario & ",'" & txt_concepto.Text() & " '," & txt_monto.Text() & ",'" & d & "'," & " 0)"
            con.fillDataTable(comm)
            MessageBox.Show("Adeudo agregado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            frmAdeudos.Show()
        End If
    End Sub

    Private Sub txt_concepto_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_concepto.KeyPress
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
End Class