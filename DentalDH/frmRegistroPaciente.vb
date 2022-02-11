Public Class frmRegistroPaciente

    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim q As String
    Dim r As Integer
    Dim a As DateTime
    Dim d As String
    Dim dt As DataTable

    Private Sub frmRegistroPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_fechaNacimiento.Value = Date.Now
        dtp_fechaNacimiento.MaxDate = Date.Now.AddHours(2)
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txt_nombre.Text) Or String.IsNullOrEmpty(txt_aPaterno.Text) Or String.IsNullOrEmpty(txt_aMaterno.Text) Or String.IsNullOrEmpty(txt_telefono.Text) Or String.IsNullOrEmpty(txt_correo.Text) Then
            MessageBox.Show("Ingrese todos los datos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If txt_telefono.Text.Length < 10 Then
                MessageBox.Show("numero de telefono no valido, favor de ingresar nuemero de telefono a 10 digitos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf con.validaremail((txt_correo.Text)) = False Then
                MessageBox.Show("Dirección de correo electronico no valida,   
                       el correo debe tener el formato: nombre@dominio.com, " &
                               " por favor escriba un correo valido un correo valido", "Validación de   
                       correo electronico", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                txt_correo.Focus()
                txt_correo.SelectAll()
            Else
                a = dtp_fechaNacimiento.Value.Date.ToShortDateString
                d = Format(a, "yyyy-MM-dd")
                q = "select count(*) as total from pacientes where numeroTelefono=" & txt_telefono.Text()
                dt = con.fillDataTable(q)
                r = dt.Rows(0).Item("total")


                If r > 0 Then
                    MessageBox.Show("Paciente ya se encuentra registrado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    comm = "insert into pacientes (nombre, aPaterno, aMaterno, numeroTelefono, correoElectronico, fechaNacimiento)
                    values ('" & txt_nombre.Text() & "','" & txt_aPaterno.Text() & "','" & txt_aMaterno.Text() & "'," & txt_telefono.Text() & ",'" & txt_correo.Text() & "','" & d & "');"
                    con.fillDataTable(comm)
                    MessageBox.Show("Paciente Registrado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                    frmPacientes.Show()
                End If
            End If
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmPacientes.Show()
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_aPaterno_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_aPaterno.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_aMaterno_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_aMaterno.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_aPaterno_TextChanged(sender As Object, e As EventArgs) Handles txt_aPaterno.TextChanged, txt_aPaterno.KeyPress

    End Sub

End Class