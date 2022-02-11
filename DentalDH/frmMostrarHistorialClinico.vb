Public Class frmMostrarHistorialClinico

    Dim con As Conexion = New Conexion
    Dim comm As String
    Dim h As String = ""
    Dim dt As DataTable

    Private Sub frmMostrarHistorialClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente & " Telefono: " & VariablesGlobales.telefonoPaciente

        'comm = "select concat_ws(' ',date_format(historialClinico.fecha, '%d/%m/%Y'), historialclinico.descripcion ) as registro from historialclinico where idPaciente=5"
        comm = "select date_format(historialClinico.fecha, '%d/%m/%Y') as fecha ,historialclinico.descripcion from historialclinico where idPaciente=" & VariablesGlobales.idPaciente & ";"
        dt = con.fillDataTable(comm)

        For Each row As DataRow In dt.Rows
            'h = h & row.Item("registro") & vbCrLf & vbCrLf
            h = h & row.Item("fecha") & " " & row.Item("descripcion") & vbCrLf & vbCrLf
        Next

        txt_historial.Text = h


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
        frmHistorialClinico.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmOperacionesSobreElPaciente.Show()
    End Sub

End Class