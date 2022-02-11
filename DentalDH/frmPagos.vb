Public Class frmPagos
    Dim con As Conexion
    Dim dt As DataTable
    Dim query As String

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        inicializarDatos()
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmOperacionesSobreElPaciente.Show()
    End Sub

    Private Sub inicializarDatos()
        lbl_datosDelPaciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
        query = "select adeudos.idAdeudo, usuarios.nombre as Empleado, 
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
                AND t.idAdeudo = adeudos.idAdeudo GROUP BY adeudos.idAdeudo;"
        con.fillDGV(query, dgv_Adeudos)
        dgv_Adeudos.Columns(0).Visible = False
    End Sub

    Private Sub dgv_Adeudos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Adeudos.CellClick
        If dgv_Adeudos.CurrentCell.Value Is DBNull.Value Then

        Else
            If e.RowIndex >= 0 And e.RowIndex <= dgv_Adeudos.Rows.Count - 1 Then
                If dgv_Adeudos.Rows(e.RowIndex).Cells(6).Value.compareTo("NO PAGADO") = 0 Then

                    VariablesGlobales.idAdeudo = dgv_Adeudos.Rows(e.RowIndex).Cells(0).Value
                    VariablesGlobales.deuda = dgv_Adeudos.Rows(e.RowIndex).Cells(3).Value
                    VariablesGlobales.motivo = dgv_Adeudos.Rows(e.RowIndex).Cells(2).Value
                    Me.Close()
                    frmAgregarPago.Show()
                Else
                    MsgBox("La deuda está pagada.")
                End If
            Else
                MsgBox("Algo salió mal.")
            End If
        End If


    End Sub

    Private Sub ll_verPagos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_verPagos.LinkClicked
        Me.Close()
        frmReporteDePagos.Show()
    End Sub


End Class