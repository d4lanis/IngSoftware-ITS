Public Class frmReportesDeCitas
    Dim con As Conexion
    Dim idCita As String
    Dim query As String
    Dim fecha1, fecha2 As String
    Dim itext As itext
    Private Sub frmReportesDeCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        itext = New itext
        fillDGV_Hoy()
    End Sub

    Private Sub fillDGV_Hoy()
        query = "select citas.idCita, servicios.idServicio, citas.asistencia, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Nombre, 
servicios.nombre as Servicio,
citas.descripcion, 
citas.fecha,
 case 
 when asistencia = 1 then 'En progreso'
 when asistencia = 2 then 'Asistió'
 when asistencia = 3 then 'No Asistió'
 end as Asistencia
 FROM
pacientes, citas, servicios
WHERE 
citas.idServicio=servicios.idServicio AND
pacientes.idPaciente=citas.idPaciente AND
date(citas.fecha) = CURDATE()
ORDER BY citas.fecha ASC;"
        con.fillDGV(query, dgv_Citas)
        dgv_Citas.Columns(0).Visible = False
        dgv_Citas.Columns(1).Visible = False
        dgv_Citas.Columns(2).Visible = False
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        fillDGV_Consulta()
    End Sub

    Private Sub btn_buscarHoy_Click(sender As Object, e As EventArgs) Handles btn_buscarHoy.Click
        fillDGV_Hoy()
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        itext.imprimirDGV(dgv_Citas, Format(Date.Today, "dd-MM-yyyy"), "Reporte de Citas")
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        If VariablesGlobales.permiso = 1 Then
            frmMenuAdmin.Show()
        Else
            frmMenu.Show()
        End If
    End Sub

    Private Sub dgv_Citas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Citas.CellContentClick

        If e.RowIndex >= 0 And e.RowIndex <= dgv_Citas.Rows.Count - 1 Then
            If dgv_Citas.CurrentCell.Value Is DBNull.Value Then

            Else
                VariablesGlobales.idCita = dgv_Citas.Rows(e.RowIndex).Cells(0).Value
                VariablesGlobales.servicio = dgv_Citas.Rows(e.RowIndex).Cells(4).Value
                VariablesGlobales.nombrePacienteEditCita = dgv_Citas.Rows(e.RowIndex).Cells(3).Value
                VariablesGlobales.descripcion = dgv_Citas.Rows(e.RowIndex).Cells(5).Value
                VariablesGlobales.fecha = DateTime.Parse(dgv_Citas.Rows(e.RowIndex).Cells(6).Value)
                VariablesGlobales.asistencia = dgv_Citas.Rows(e.RowIndex).Cells(2).Value
                Me.Close()
                frmEditarCita.Show()
            End If
        End If
    End Sub

    Private Sub fillDGV_Consulta()
        fecha1 = Format(dtp_fecha1.Value, "yyyy-MM-dd")
        fecha2 = Format(dtp_fecha2.Value, "yyyy-MM-dd")
        query = "select idCita, servicios.idServicio, citas.asistencia, concat_ws(' ', pacientes.nombre, pacientes.aPaterno, pacientes.aMaterno) as Nombre, 
servicios.nombre as Servicio,
citas.descripcion, 
citas.fecha,
 case 
 when asistencia = 1 then 'En proceso'
 when asistencia = 2 then 'Asistió'
 when asistencia = 3 then 'No asistió'
end as Asistencia
 FROM
pacientes, citas, servicios
WHERE 
citas.idServicio=servicios.idServicio AND
pacientes.idPaciente=citas.idPaciente AND
date(citas.fecha) >= '" & fecha1 & "' AND 
date(citas.fecha) <= '" & fecha2 & "'
ORDER BY citas.fecha ASC;"
        con.fillDGV(query, dgv_Citas)
        dgv_Citas.Columns(0).Visible = False
        dgv_Citas.Columns(1).Visible = False
        dgv_Citas.Columns(2).Visible = False
    End Sub
End Class