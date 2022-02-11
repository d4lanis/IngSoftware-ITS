
Public Class frmMenuAdmin
    Dim con As Conexion = New Conexion()
    Dim comm As String = "select * from logo where idLogo = 1"
    Dim dt As DataTable


    Private Sub frmMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt = con.fillDataTable(comm)

        If dt.Rows.Count = 1 Then
            Dim str As String
            Dim campoImagen As Byte()
            For Each row As DataRow In dt.Rows
                campoImagen = row.Item("imagen")
            Next
            Dim bin As New IO.MemoryStream(campoImagen)
            Dim resultado As Image = Image.FromStream(bin)

            logo.Image = resultado
        End If
    End Sub






    Private Sub btnRegistroPacientes_Click(sender As Object, e As EventArgs) Handles btnRegistroPacientes.Click
        Me.Close()
        frmPacientes.Show()
    End Sub

    Private Sub btnOpSobrePacientes_Click(sender As Object, e As EventArgs) Handles btnOpSobrePacientes.Click
        Me.Close()
        frmOperacionesPacientesMenu.Show()
    End Sub

    Private Sub btnAgendaDeCitas_Click(sender As Object, e As EventArgs) Handles btnAgendaDeCitas.Click
        Me.Close()
        frmReportesDeCitas.Show()
    End Sub

    Private Sub btnReporteDePagos_Click(sender As Object, e As EventArgs) Handles btnReporteDePagos.Click
        Me.Close()
        frmReporteDePagos.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Me.Close()
        frmUsuarios.Show()
    End Sub

    Private Sub btnCatalogoDeServicios_Click(sender As Object, e As EventArgs) Handles btnCatalogoDeServicios.Click
        Me.Hide()
        frmServicios.Show()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Me.Close()
        frmCambiarLogo.Show()
    End Sub

    Private Sub btnCerrarSesión_Click(sender As Object, e As EventArgs) Handles btnCerrarSesión.Click
        Me.Close()
        frmInicioSesion.Show()
    End Sub

    Private Sub Reloj_Tick(sender As Object, e As EventArgs) Handles Reloj.Tick
        lblFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        lblHora.Text = Format(DateTime.Now, "hh:mm:ss")
    End Sub
End Class