Public Class frmModificarPaciente

    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim a As DateTime
    Dim d As String
    Dim q As String
    Dim r As Integer
    Dim dt As DataTable

    Private Sub frmModificarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nombre.Text = VariablesGlobales.nombrePaciente
        txt_aPaterno.Text = VariablesGlobales.paternoPaciente
        txt_aMaterno.Text = VariablesGlobales.maternoPaciente
        txt_telefono.Text = VariablesGlobales.telefonoPaciente
        txt_correo.Text = VariablesGlobales.correoPaciente
        dtp_fechaNacimiento.MaxDate = DateTime.Now
        dtp_fechaNacimiento.Value = VariablesGlobales.fechaNacimiento
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

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
                q = "select count(*) as total from pacientes where numeroTelefono='" & txt_telefono.Text() & "' and not idPaciente='" & VariablesGlobales.idPaciente & "'"
                dt = con.fillDataTable(q)
                r = dt.Rows(0).Item("total")
                If r > 0 Then
                    MessageBox.Show("El telefono ingresado ya esta registrado con otro paciente, verifique su informacion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    a = dtp_fechaNacimiento.Value.Date.ToShortDateString
                    d = Format(a, "yyyy-MM-dd")
                    comm = "update pacientes 
                    set nombre= '" & txt_nombre.Text() & "', aPaterno= '" & txt_aPaterno.Text() & "' , aMaterno= '" & txt_aMaterno.Text() & "', numeroTelefono= " & txt_telefono.Text() & " , correoElectronico= '" & txt_correo.Text() & "', fechaNacimiento= '" & d &
                    "' where idPaciente= " & VariablesGlobales.idPaciente & ";"
                    con.fillDataTable(comm)
                    MessageBox.Show("Datos Modificados", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                    frmPacientes.Show()
                End If

            End If

        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmRegistroPacientesMenu.Show()
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
End Class