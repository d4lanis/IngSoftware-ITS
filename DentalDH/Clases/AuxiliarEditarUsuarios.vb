Imports System.Text.RegularExpressions
Public Class AuxiliarEditarUsuarios

    Dim dt As DataTable
    Public Sub fillCBPermisos(ByRef cb_servicios As ComboBox)
        dt = New DataTable
        dt.Columns.Add("Permiso")
        dt.Columns.Add("Id")

        'Renglon es la variable que adicionara renglones a mi datatable
        Dim Renglon As DataRow = dt.NewRow
        Renglon("Permiso") = "Admnistrador"
        Renglon("Id") = "1"
        dt.Rows.Add(Renglon)

        Renglon = dt.NewRow
        Renglon("Permiso") = "Doctor"
        Renglon("Id") = "2"
        dt.Rows.Add(Renglon)

        Renglon = dt.NewRow
        Renglon("Permiso") = "Recepcionista"
        Renglon("Id") = "3"
        dt.Rows.Add(Renglon)

        cb_servicios.DataSource = dt
        cb_servicios.DisplayMember = "Permiso"
        cb_servicios.ValueMember = "Id"

    End Sub

    Public Function validarDatos(ByRef txt_nombreEmpleado As TextBox, ByRef txt_agregarNombreUsuario As TextBox, ByRef txt_agregarContraseña As TextBox, ByRef txt_agregarContraseñaComprobado As TextBox, ByRef lbl_comprobarContraseña As Label)
        Dim regex As Regex
        Dim datosValidos As Boolean = False
        If txt_nombreEmpleado.Text.Length > 0 And txt_agregarNombreUsuario.Text.Length > 0 And txt_agregarContraseñaComprobado.Text.Length > 0 And txt_agregarContraseña.Text.Length > 0 Then ' no hay txtbox vacías y las contraseñas tienen más de 8 caracteres
            If txt_agregarContraseña.Text = txt_agregarContraseñaComprobado.Text Then 'las contraseñas coinciden
                regex = New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$") 'Expresion regular de contraseña segura
                'expresión por https://stackoverflow.com/questions/5859632/regular-expression-for-password-validation
                If regex.IsMatch(txt_agregarContraseñaComprobado.Text) Then
                    datosValidos = True
                    lbl_comprobarContraseña.Visible = True
                    lbl_comprobarContraseña.Text = "Las contraseñas coinciden y cumplen con el estándar de seguridad."
                    lbl_comprobarContraseña.ForeColor = Color.Green
                Else
                    lbl_comprobarContraseña.Visible = True
                    lbl_comprobarContraseña.Text = "La contraseña debe tener al menos 8 caracteres, letras minusculas, una letra mayúscula y números."
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
    End Function


End Class
