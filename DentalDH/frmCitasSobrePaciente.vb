Public Class frmCitasSobrePaciente
    Dim query As String
    Dim con As Conexion
    Dim dt As DataTable
    Dim fechaCita As DateTime
    Dim fecha, tiempoVal, fechaVal As String
    Dim horaApertura, horaCierre As Integer


    Private Sub frmCitasSobrePaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Paciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
        con = New Conexion
        con.fillComboBox("Select * from servicios;", cb_Servicios, "nombre", "idServicio")
        'Establecer comportamiento de los datetimepicker
        dtp_hora.Format = DateTimePickerFormat.Time
        dtp_hora.ShowUpDown = True
        horaApertura = 9
        horaCierre = 19
        revisarHora()
    End Sub

    Public Function horaDisponible() 'Revisa que la hora en la que quieres poner la cita no tenga citas en un intervalo de -20 y 20 minutos.
        Dim disponible As Boolean = False
        fechaVal = Format(dtp_fecha.Value, "yyyy-MM-dd")
        tiempoVal = Format(dtp_hora.Value, "HH:mm:ss")
        query = "Select count(*) from citas where 
date(fecha) = '" & fechaVal & "' and 
TIME(fecha) between SUBTIME('" & tiempoVal & "', '00:20:00') and ADDTIME('" & tiempoVal & "', '00:20:00');"
        dt = con.fillDataTable(query)
        If dt.Rows(0).Item("count(*)") = 0 Then
            disponible = True
        End If
        Return disponible
    End Function

    Private Sub revisarHora()
        If dtp_hora.Value.Hour < horaApertura Then
            dtp_hora.Value = Convert.ToDateTime("9:00 AM")
        ElseIf dtp_hora.Value.Hour >= horaCierre And dtp_hora.Value.Minute >= 0 Then
            dtp_hora.Value = Convert.ToDateTime("7:00 PM")
        End If
    End Sub


    Private Sub dtp_hora_ValueChanged(sender As Object, e As EventArgs) Handles dtp_hora.Leave
        revisarHora()
    End Sub

    Private Sub rtxt_descripcion_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rtxt_descripcion.KeyPress
        If (e.KeyChar = "'" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "=" Or e.KeyChar = "!" Or e.KeyChar = ":" Or e.KeyChar = "34" Or e.KeyChar = "|" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "/" Or e.KeyChar = "*") Then
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

    'Descripción no debe estar vacía ni se deben hacer citas en el pasado
    Private Function validarDatos()
        Dim datosValidos As Boolean = False

        If dtp_fecha.Value >= Date.Today.Date Then 'Citas en fechas a partir de hoy 
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
        Else
            MsgBox("No pueden registrarse citas para antes de la fecha actual. Revise la fecha. ")
        End If
        Return datosValidos
    End Function

    Private Sub registrar()
        If validarDatos() Then
            fecha = Format(dtp_fecha.Value, "yyyy-MM-dd") & " " & Format(dtp_hora.Value, "HH:mm:ss") 'Aún no hace el insert eh, solo da formato
            query = "insert into citas values (default," & cb_Servicios.SelectedValue & " ," & VariablesGlobales.idPaciente & ", '" & rtxt_descripcion.Text & "', '" & fecha & "', 1);" '1 es en progreso, 2 asistió, 3 no asistió
            con.ejecutarNoQuery(query)
            Me.Close()
            frmOperacionesSobreElPaciente.Show()
        End If
    End Sub

    'date: YYYY-MM-DD hh:mm:ss
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        registrar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmOperacionesSobreElPaciente.Show()
    End Sub
End Class