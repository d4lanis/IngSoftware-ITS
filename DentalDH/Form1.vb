Imports DentalDH.VariablesGlobales
Imports DentalDH.Conexion
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmInicioSesion
    Dim dt As DataTable
    Private con As Conexion
    Private comm As String
    Public icon As Icon

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        aceptar()
    End Sub

    Private Sub aceptar()
        If txt_usuario.Text = String.Empty Then
            MessageBox.Show("No se aceptan datos vacios", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_usuario.Focus()
        ElseIf txt_password.Text = String.Empty Then
            MessageBox.Show("No se aceptan datos vacios", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_password.Focus()
        Else
            comm = "Select * from usuarios where contrasenia='" & txt_password.Text & "' and usuario= '" & txt_usuario.Text & "'"
            con = New Conexion
            dt = con.fillDataTable(comm)

            If dt.Rows.Count = 1 Then
                For Each row As DataRow In dt.Rows
                    If (row.Item("contrasenia") = txt_password.Text) And (row.Item("usuario") = txt_usuario.Text) Then
                        If (row.Item("permiso") = 1) Then
                            idUsuario = row.Item("idUsuario")
                            permiso = row.Item("permiso")
                            txt_password.Clear()
                            txt_usuario.Clear()
                            Me.Hide()
                            frmMenuAdmin.Show()
                        ElseIf (row.Item("permiso") = 2 Or 3) Then
                            idUsuario = row.Item("idUsuario")
                            permiso = row.Item("permiso")
                            txt_password.Clear()
                            txt_usuario.Clear()
                            Me.Hide()
                            frmMenu.Show()
                        End If
                    End If
                Next
            Else
                MessageBox.Show("Verifique sus datos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub frmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        Me.ShowIcon = True
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_usuario.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'txt_usuario.Clear()
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = "," Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'txt_usuario.Clear()
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            aceptar()
        End If
    End Sub
End Class
