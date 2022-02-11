


Public Class frmOperacionesSobreElPaciente

    Dim con As Conexion = New Conexion()
    Dim comm As String = "select * from logo where idLogo = 1"
    Dim dt As DataTable


    Private Sub frmOperacionesSobreElPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_datosPaciente.Text = "Paciente: " & VariablesGlobales.nombrePaciente & "     Telefono: " & VariablesGlobales.telefonoPaciente
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

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmOperacionesPacientesMenu.Show()
    End Sub

    Private Sub btn_agendarCita_Click(sender As Object, e As EventArgs) Handles btnAgendaDeCitas.Click
        Me.Close()
        frmCitasSobrePaciente.Show()
    End Sub

    Private Sub btn_adeudosDelPaciente_Click(sender As Object, e As EventArgs) Handles BtnAdeudos.Click
        Me.Close()
        frmAdeudos.Show()
    End Sub

    Private Sub btn_historialClinico_Click(sender As Object, e As EventArgs) Handles btnHistorialClinico.Click
        Me.Close()
        frmMostrarHistorialClinico.Show()
    End Sub

    Private Sub btn_pagosDelPaciente_Click(sender As Object, e As EventArgs) Handles btnReporteDePagos.Click
        Me.Close()
        frmPagos.Show()
    End Sub

End Class