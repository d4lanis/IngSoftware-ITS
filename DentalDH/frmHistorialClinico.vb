Public Class frmHistorialClinico

    Dim con As Conexion = New Conexion
    Dim comm As String

    Private Sub frmHistorialClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
        comm = "select historialclinico.idHIstorialClinico, historialclinico.idPaciente, 
                historialclinico.descripcion, date_format(historialClinico.fecha, '%d/%m/%Y') as Fecha from historialclinico 
                where idPaciente=" & VariablesGlobales.idPaciente
        con.fillDGV(comm, dgv_historial)
        dgv_historial.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_historial.Columns(0).Visible = False
        dgv_historial.Columns(1).Visible = False

        'dgv_historial.Rows(0).Height = 75

    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmMostrarHistorialClinico.Show()
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
        frmAgregarHistorial.Show()
    End Sub

    Private Sub dgv_historial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historial.CellClick
        If e.RowIndex >= 0 And e.RowIndex < dgv_historial.Rows.Count - 1 Then
            VariablesGlobales.idHistorialClinico = dgv_historial.Rows(e.RowIndex).Cells(0).Value
            VariablesGlobales.f = dgv_historial.Rows(e.RowIndex).Cells(2).Value
            Me.Close()
            frmEditarHistorial.Show()
        End If
    End Sub
End Class