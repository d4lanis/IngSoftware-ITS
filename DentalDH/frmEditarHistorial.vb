Public Class frmEditarHistorial

    Dim con As Conexion = New Conexion
    Dim comm As String

    Private Sub frmEditarHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
        txt_descripcion.Text = VariablesGlobales.f
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmHistorialClinico.Show()
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        registrar()
    End Sub

    Private Sub registrar()
        If String.IsNullOrEmpty(txt_descripcion.Text) Then
            MessageBox.Show("Introduzca la descripcion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            comm = "update historialclinico set descripcion= '" & txt_descripcion.Text & "' where idHistorialClinico=" & VariablesGlobales.idHistorialClinico
            con.fillDataTable(comm)
            MessageBox.Show("Regitro Editado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            frmHistorialClinico.Show()
        End If
    End Sub

    Private Sub txt_descripcion_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
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