Public Class frmAgregarHistorial

    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim a As DateTime
    Dim d As String

    Private Sub frmAgregarHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
        dtp_fecha.MaxDate = Date.Now
        dtp_fecha.Value = Date.Now
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmHistorialClinico.Show()
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        registrar()
    End Sub

    Private Sub registrar()
        If String.IsNullOrEmpty(txt_descripcion.Text) Then
            MessageBox.Show("Introduzca la descripcion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            a = dtp_fecha.Value.Date.ToShortDateString
            d = Format(a, "yyyy-MM-dd")
            comm = "insert into historialclinico (idPaciente, descripcion, fecha) values ( " & VariablesGlobales.idPaciente & ",'" & txt_descripcion.Text() & "' , '" & d & "')"
            con.fillDataTable(comm)
            MessageBox.Show("Regitro Agregado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            frmHistorialClinico.Show()
        End If
    End Sub

    Private Sub txt_descripcion_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            registrar()
        End If
    End Sub
End Class