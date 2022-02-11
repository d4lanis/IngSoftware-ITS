Public Class frmAdeudos

    Dim con As Conexion = New Conexion
    Dim comm As String

    Private Sub frmAdeudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_datosPaciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
        comm = "select adeudos.idAdeudo, usuarios.nombre as Empleado, 
                adeudos.concepto,
                adeudos.monto, 
                adeudos.monto - t.deuda as debe,
                date_format(adeudos.fecha, '%d/%m/%Y') as Fecha,
                case 
                 when pagado = 1 then 'PAGADO'
                 when pagado = 0 then 'NO PAGADO'
                end as Pagado
                FROM
                adeudos, usuarios, pagos, (SELECT pagos.idAdeudo, ifnull(SUM(pagos.monto), 0) as deuda from pagos, adeudos where pagos.idAdeudo = adeudos.idAdeudo and adeudos.idPaciente=" & VariablesGlobales.idPaciente & " GROUP BY pagos.idAdeudo) as t
                WHERE
                adeudos.idPaciente=" & VariablesGlobales.idPaciente & " and adeudos.idEmpleado = usuarios.idUsuario
                AND pagos.idAdeudo=adeudos.idAdeudo
                AND t.idAdeudo = adeudos.idAdeudo GROUP BY adeudos.idAdeudo;;"
        con.fillDGV(comm, dgv_adeudos)
        dgv_adeudos.Columns(0).Visible = False

    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Close()
        frmOperacionesSobreElPaciente.Show()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Me.Close()
        frmAgregarAdeudo.Show()
    End Sub

    Private Sub dgv_adeudos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_adeudos.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= dgv_adeudos.Rows.Count - 1 Then
            If dgv_adeudos.CurrentCell.Value Is DBNull.Value Then

            Else
                VariablesGlobales.idAdeudo = dgv_adeudos.Rows(e.RowIndex).Cells(0).Value
                VariablesGlobales.concepto = dgv_adeudos.Rows(e.RowIndex).Cells(2).Value
                VariablesGlobales.monto = dgv_adeudos.Rows(e.RowIndex).Cells(3).Value
                VariablesGlobales.f = dgv_adeudos.Rows(e.RowIndex).Cells(4).Value
                Me.Close()
                frmEliminarAdeudo.Show()
            End If
        End If
    End Sub


End Class