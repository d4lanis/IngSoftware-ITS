Public Class frmMenu

    Dim con As Conexion = New Conexion()
    Dim comm As String = "select * from logo where idLogo = 1"
    Dim dt As DataTable

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnCerrarSesión.Click
        Me.Close()
        frmInicioSesion.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub OperacionesSobrePacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnOpSobrePacientes.Click
        Me.Close()
        frmOperacionesPacientesMenu.Show()
    End Sub

    Private Sub AgendaDeCitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAgendaDeCitas.Click
        Me.Close()
        frmReportesDeCitas.Show()
    End Sub

    Private Sub RegistroPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnRegistroPacientes.Click
        Me.Close()
        frmPacientes.Show()
    End Sub

    Private Sub ReporteDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnReporteDePagos.Click
        Me.Close()
        frmReporteDePagos.Show()
    End Sub

    Private Sub Reloj_Tick(sender As Object, e As EventArgs) Handles Reloj.Tick
        lblFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        lblHora.Text = Format(DateTime.Now, "hh:mm:ss")
    End Sub
End Class