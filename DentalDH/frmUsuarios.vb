Imports System.Text.RegularExpressions
Public Class frmUsuarios
    Dim con As Conexion
    Dim query As String
    Dim dt As DataTable
    Dim aux As AuxiliarEditarUsuarios


    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        aux = New AuxiliarEditarUsuarios
        aux.fillCBPermisos(cb_permisos)
        lbl_comprobarContraseña.Visible = False
        fillDgv_Usuarios()
    End Sub

    Private Sub fillDgv_Usuarios()
        query = "Select idUsuario as ID, nombre, Usuario, 
case 
when permiso=1 then 'Administrador'
when permiso=2 then 'Doctor'
when permiso=3 then 'Recepcionista'
END as Permisos,
permiso
from usuarios WHERE idUsuario <> " & VariablesGlobales.idUsuario & ";"
        con.fillDGV(query, dgv_Usuarios)
        dgv_Usuarios.Columns(4).Visible = False
        dgv_Usuarios.Columns(0).Visible = False
    End Sub

    'Al presionar el botón se busca al usuario en el query
    Private Sub btn_buscarUsuario_Click(sender As Object, e As EventArgs) Handles btn_buscarUsuario.Click
        fillDgv_Usuarios()
    End Sub

    'Al presionar el botón se valida que no hayan campos vacíos, si es el caso, realiza el insert y limpia las cajas de texto. Si no es el caso, le pide al usuario que llene los datos.
    Private Sub btn_agregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If aux.validarDatos(txt_nombreEmpleado, txt_agregarNombreUsuario, txt_agregarContraseña, txt_agregarContraseñaComprobado, lbl_comprobarContraseña) Then
            query = "insert into usuarios values (default, '" & txt_agregarContraseñaComprobado.Text & "', '" & txt_agregarNombreUsuario.Text & "','" & txt_nombreEmpleado.Text & "'," & cb_permisos.SelectedValue & ");"
            con.ejecutarNoQuery(query)
            If VariablesGlobales.usuarioDuplicado = False Then
                limpiarTextBox()
                fillDgv_Usuarios()
            Else
                VariablesGlobales.usuarioDuplicado = False
            End If
        End If
    End Sub

    'Comprueba que los datos que se meten en las txtbox no vayan a hacer que el query falle. Si es así muestra un mensaje pidiendo
    'que llenen los datos. Esto se movió a otra clase y se invoca desde ella.
    Private Function validarDatos()
        Dim regex As Regex
        Dim datosValidos As Boolean = False
        If txt_nombreEmpleado.Text.Length > 0 And txt_agregarNombreUsuario.Text.Length > 0 And txt_agregarContraseñaComprobado.Text.Length > 0 And txt_agregarContraseña.Text.Length > 0 Then ' no hay txtbox vacías y las contraseñas tienen más de 8 caracteres
            If txt_agregarContraseña.Text = txt_agregarContraseñaComprobado.Text Then 'las contraseñas coinciden
                regex = New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$") 'Expresion regular de contraseña segura
                If regex.IsMatch(txt_agregarContraseñaComprobado.Text) Then
                    datosValidos = True
                    lbl_comprobarContraseña.Visible = True
                    lbl_comprobarContraseña.Text = "Las contraseñas coinciden y cumplen con el estándar de seguridad."
                    lbl_comprobarContraseña.ForeColor = Color.Green
                Else
                    lbl_comprobarContraseña.Visible = True
                    lbl_comprobarContraseña.Text = "La contraseña debe tener al menos 8 caracteres, letras y números."
                    lbl_comprobarContraseña.ForeColor = Color.Red
                End If
            Else
                lbl_comprobarContraseña.Visible = True
                lbl_comprobarContraseña.Text = "Las contraseñas no coinciden."
                lbl_comprobarContraseña.ForeColor = Color.Red
            End If
        Else
            MsgBox("No pueden haber campos en blanco. Revise sus datos.")
        End If
        Return datosValidos
    End Function 'Ésto se mudó a la clase AuxiliarEditarUsuarios para ser usado en varias clases

    'Limpia las textbox de contraseña y nombre usuario.
    Private Sub limpiarTextBox()
        txt_agregarContraseña.Clear()
        txt_agregarContraseñaComprobado.Clear()
        txt_agregarNombreUsuario.Clear()
        txt_nombreEmpleado.Clear()
        lbl_comprobarContraseña.Visible = False
    End Sub

    'Para regresar al menú
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmMenuAdmin.Show()
    End Sub

    'Para accesar a la form que edita el usuario seleccionado
    Private Sub dgv_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Usuarios.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= dgv_Usuarios.Rows.Count - 1 Then
            VariablesGlobales.idUsuarioEdit = dgv_Usuarios.Rows(e.RowIndex).Cells(0).Value.ToString
            VariablesGlobales.nombreUsuarioEdit = dgv_Usuarios.Rows(e.RowIndex).Cells(1).Value.ToString
            VariablesGlobales.permisosNombreEdit = dgv_Usuarios.Rows(e.RowIndex).Cells(3).Value.ToString
            Me.Hide()
            frmEditarUsuarios.Show()
        End If
    End Sub

    Private Sub txt_nombreEmpleado_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombreEmpleado.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
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
            fillDgv_Usuarios()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class