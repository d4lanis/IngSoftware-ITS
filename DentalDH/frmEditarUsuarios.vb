Public Class frmEditarUsuarios
    Dim aux As AuxiliarEditarUsuarios
    Dim con As Conexion
    Dim query As String
    Dim nombreEmpleado As String
    Dim nombreUsuario As String
    Dim contraseña As String
    Dim dt As DataTable
    Private Sub frmEditarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_muestraDatos.Text = "Editando al usuario: " & VariablesGlobales.nombreUsuarioEdit & vbCrLf & "Permisos: " & VariablesGlobales.permisosNombreEdit
        aux = New AuxiliarEditarUsuarios
        aux.fillCBPermisos(cb_permisos)
        con = New Conexion
        cargarDatos()
        lbl_comprobarContraseña.Visible = False
    End Sub

    Private Sub cargarDatos() ' cAMBIO
        dt = con.fillDataTable("Select contrasenia, usuario, nombre from usuarios where idUsuario = " & VariablesGlobales.idUsuarioEdit)
        contraseña = dt.Rows(0).Item("contrasenia")
        nombreUsuario = dt.Rows(0).Item("usuario")
        nombreEmpleado = dt.Rows(0).Item("nombre")

        txt_agregarContraseña.Text = contraseña
        txt_agregarContraseñaComprobado.Text = contraseña
        txt_agregarNombreUsuario.Text = nombreUsuario
        txt_nombreEmpleado.Text = nombreEmpleado
        cb_permisos.SelectedIndex = cb_permisos.FindStringExact(VariablesGlobales.permisosNombreEdit)

    End Sub

    Private Sub btn_guardarCambios_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If aux.validarDatos(txt_nombreEmpleado, txt_agregarNombreUsuario, txt_agregarContraseña, txt_agregarContraseñaComprobado, lbl_comprobarContraseña) Then
            query = "update usuarios set contrasenia = '" & txt_agregarContraseñaComprobado.Text & "', permiso = " & cb_permisos.SelectedValue & ", nombre = '" & txt_nombreEmpleado.Text & "', usuario = '" & txt_agregarNombreUsuario.Text & "' where idUsuario=" & VariablesGlobales.idUsuarioEdit & ";"
            con.ejecutarNoQuery(query)
            Me.Close()
            frmUsuarios.Show()
        End If
    End Sub

    Private Sub btn_eliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Eliminar al usuario " & VariablesGlobales.nombreUsuarioEdit & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            query = "delete from usuarios where idUsuario=" & VariablesGlobales.idUsuarioEdit & "; "
            con.ejecutarNoQuery(query)
            Me.Close()
            frmUsuarios.Show()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmUsuarios.Show()
    End Sub

    Private Sub txt_nombreEmpleado_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombreEmpleado.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_agregarNombreUsuario_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_agregarNombreUsuario.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_agregarContraseña_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_agregarContraseña.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_agregarContraseñaComprobado_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_agregarContraseñaComprobado.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
    End Sub
End Class