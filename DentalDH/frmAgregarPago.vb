Public Class frmAgregarPago
    Dim dt As DataTable
    Dim query As String
    Dim con As Conexion
    Dim fecha As String
    Dim deuda As Integer


    Private Sub frmAgregarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Conexion
        inicializarDatos()

    End Sub





    Private Sub inicializarDatos()
        lbl_DatosDePaciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
        deuda = con.calcularDeuda(VariablesGlobales.idAdeudo)
        lbl_deudaActual.Text = "Deuda por $" & VariablesGlobales.deuda & ", motivo: " & VariablesGlobales.motivo & vbCr & "Debe: $" & deuda & "."
        lbl_fecha.Text = "A la fecha de: " & Format(Date.Today, "dd-MM-yyyy")
        fecha = Format(Date.Today, "yyyy-MM-dd")
        mtxt_Monto.Text = deuda
        'calcular el resto de la deuda

    End Sub



    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If validarDatos() Then
            query = "insert into pagos values (Default, " & VariablesGlobales.idAdeudo & ", " & VariablesGlobales.idUsuario & ", " & mtxt_Monto.Text & ", '" & fecha & "');"
            con.ejecutarNoQuery(query)
            Me.Close()
            frmPagos.Show()
        End If
    End Sub


    Private Function validarDatos()
        Dim validos As Boolean = False
        If mtxt_Monto.Text.Length > 0 Then
            If mtxt_Monto.Text <= deuda Then 'Va a pagar lo mismo o menos que lo que debe.
                validos = True
            Else
                MsgBox("No puede pagar más que la deuda establecida. Edite la deuda sí el monto ha aumentado, o agregue una deuda nueva.")
            End If
        End If
        Return validos
    End Function

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmPagos.Show()
    End Sub

End Class