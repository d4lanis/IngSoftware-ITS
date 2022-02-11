Public Class frmServicios
    Dim con As Conexion
    Dim query As String
    Dim id As Integer
    Dim Servicio As String
    Dim seleccionoServicio As Boolean = False
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        fillDgv_Servicios()
        lbl_error.Visible = False
    End Sub

    'Llena el dgv y establece la columna ID como invisible. 
    Private Sub fillDgv_Servicios()
        query = "Select idServicio, nombre as Servicio from servicios;"
        con.fillDGV(query, dgv_Servicios)
        dgv_Servicios.Columns(0).Visible = False

    End Sub

    'Agrega el servicio que tenga en el txtbox
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar()
    End Sub

    Private Sub agregar()
        If validarDatos() Then
            query = "Insert into servicios values (default, '" & txt_nombreServicio.Text & "');"
            con.ejecutarNoQuery(query)
            lbl_error.Visible = True
            lbl_error.ForeColor = Color.Green
            lbl_error.Text = "Se agregó el servicio " & txt_nombreServicio.Text & "."
            fillDgv_Servicios()
            limpiarTxt_nombreServicio()
        End If
        txt_nombreServicio.Select()
    End Sub

    Private Sub limpiarTxt_nombreServicio() 'Solo limpia el txt_nombreServicios del texto.
        txt_nombreServicio.Clear()
    End Sub

    'Revisamos que el txt_nombreServicios no esté vacío.
    Private Function validarDatos()
        Dim datosValidos As Boolean
        If txt_nombreServicio.Text <> String.Empty Then
            datosValidos = True
        Else
            datosValidos = False
            MsgBox("No pueden haber campos en blanco. Revise sus datos.")
        End If
        Return datosValidos
    End Function



    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If seleccionoServicio Then
            If MessageBox.Show("¿Eliminar el servicio " & Servicio & " del catálogo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes And seleccionoServicio Then
                query = "delete from servicios where idServicio = " & id & ";"
                con.ejecutarNoQuery(query)
                fillDgv_Servicios()
                lbl_error.ForeColor = Color.Red
                lbl_error.Text = "Se eliminó el servicio " & Servicio & " del catálogo."
                lbl_error.Visible = True
            End If
        Else
            MsgBox("Seleccione un servicio.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    'establece la id seleccionada
    Private Sub dgv_Servicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Servicios.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= dgv_Servicios.Rows.Count - 1 Then
            id = dgv_Servicios.Rows(e.RowIndex).Cells(0).Value
            Servicio = dgv_Servicios.Rows(e.RowIndex).Cells(1).Value
            seleccionoServicio = True
        End If
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmMenuAdmin.Show()
    End Sub

    Private Sub txt_nombreServicio_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombreServicio.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            agregar()
        End If
    End Sub
End Class