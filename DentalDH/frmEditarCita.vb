Public Class frmEditarCita
    Dim con As Conexion
    Dim query As String
    Dim fecha, tiempoVal, fechaVal, tiempoValAct, fechaValAct As String
    Dim asistencia As Integer
    Dim horaApertura As Integer = 9
    Dim horaCierre As Integer = 19
    Dim dt As DataTable

    Private Sub frmEditarCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        con.fillComboBox("Select * from servicios;", cb_Servicios, "nombre", "idServicio")
        'Establecer comportamiento de los datetimepicker
        dtp_hora.Format = DateTimePickerFormat.Time
        dtp_hora.ShowUpDown = True
        cargarDatos()
        revisarHora()
    End Sub

    Private Sub revisarHora()
        If dtp_hora.Value.Hour < horaApertura Then
            dtp_hora.Value = Convert.ToDateTime("9:00 AM")
        ElseIf dtp_hora.Value.Hour >= horaCierre And dtp_hora.Value.Minute >= 0 Then
            dtp_hora.Value = Convert.ToDateTime("7:00 PM")
        End If
    End Sub

    Public Function horaDisponible() 'Revisa que la hora en la que quieres poner la cita no tenga citas en un intervalo de -20 y 20 minutos.
        Dim disponible As Boolean = False
        fechaVal = Format(dtp_fecha.Value, "yyyy-MM-dd")
        tiempoVal = Format(dtp_hora.Value, "HH:mm:ss")
        query = "Select count(*)-(
Select count(*) from citas where date(fecha) = '" & fechaValAct & "' and 
TIME(fecha) between SUBTIME('" & tiempoValAct & "', '00:20:00') and ADDTIME('" & tiempoValAct & "', '00:20:00') and idcita=" & VariablesGlobales.idCita & "
) as cuenta
from citas where 
date(fecha) = '" & fechaVal & "' and 
TIME(fecha) between SUBTIME('" & tiempoVal & "', '00:20:00') and ADDTIME('" & tiempoVal & "', '00:20:00');"
        dt = con.fillDataTable(query)
        If dt.Rows(0).Item("cuenta") <= 0 Then
            disponible = True
        End If
        Return disponible
    End Function


    Private Sub cargarDatos()
        lbl_Paciente.Text = "Paciente: " & VariablesGlobales.nombrePacienteEditCita
        dtp_fecha.Value = VariablesGlobales.fecha
        dtp_hora.Value = VariablesGlobales.fecha
        cb_Servicios.SelectedIndex = cb_Servicios.FindStringExact(VariablesGlobales.servicio)
        rtxt_descripcion.Text = VariablesGlobales.descripcion
        tiempoValAct = Format(dtp_hora.Value, "HH:mm:ss")
        fechaValAct = Format(dtp_fecha.Value, "yyyy-MM-dd")
        If VariablesGlobales.asistencia = 2 Then 'asistió
            checkB_Asistencia.Checked = True
        Else
            checkB_Asistencia.Checked = False
        End If
    End Sub

    Private Sub asignarAsistencia() '1 es en progreso, 2 asistió, 3 no asistió
        If checkB_Asistencia.Checked Then
            asistencia = 2
        Else
            asistencia = 3
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        registrar()
    End Sub

    Private Sub registrar()
        If validarDatos() Then
            fecha = Format(dtp_fecha.Value, "yyyy-MM-dd") & " " & Format(dtp_hora.Value, "HH:mm:ss") 'Aún no hace el insert eh, solo da formato
            asignarAsistencia()
            query = "update citas set idServicio = " & cb_Servicios.SelectedValue & ", descripcion ='" & rtxt_descripcion.Text & "', fecha = '" & fecha & "', asistencia = " & asistencia & " where idCita = " & VariablesGlobales.idCita & ";"
            con.ejecutarNoQuery(query)
            Me.Close()
            frmReportesDeCitas.Show()
        End If
    End Sub

    Private Sub rtxt_descripcion_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rtxt_descripcion.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
            e.Handled = True
            MessageBox.Show("Caracter no valido: " & e.KeyChar, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Space) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
            registrar()
        End If
    End Sub

    Private Function validarDatos()
        Dim datosValidos As Boolean = False

        If rtxt_descripcion.TextLength > 0 Then 'La descripción tiene datos.
            If dtp_hora.Value.Hour >= horaApertura And dtp_hora.Value.Hour <= horaCierre Then 'Citas en horas válidas
                If horaDisponible() Then
                    datosValidos = True
                ElseIf MessageBox.Show("Ya hay citas agendadas en un intervalo de -+20 minutos." & vbCr & " ¿Agendar cita de todas formas? (Podría provocar citas a la misma fecha y hora, o con muy poco tiempo entre ellas.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    datosValidos = True
                End If
            Else
                MsgBox("El horario de citas es entre 9AM a 7PM, de Lunes a Domingo.")
            End If
        Else
            MsgBox("No pueden haber campos vacíos. ")
        End If
        Return datosValidos
    End Function

    Private Sub dtp_hora_leave(sender As Object, e As EventArgs) Handles dtp_hora.Leave
        revisarHora()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmReportesDeCitas.Show()
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_EliminarCita.Click
        If MessageBox.Show("¿Eliminar la cita con el paciente " & VariablesGlobales.nombrePaciente & " del día " & Format(VariablesGlobales.fecha, "dd-MM-yyyy") & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            query = "Delete from citas where idCita = " & VariablesGlobales.idCita & ";"
            con.ejecutarNoQuery(query)
            Me.Close()
            frmReportesDeCitas.Show()
        End If
    End Sub


End Class