Public Class frmRegistroPacientesMenu
    Private Sub frmRegistroPacientesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente & " " & VariablesGlobales.paternoPaciente & " " & VariablesGlobales.maternoPaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmPacientes.Show()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Me.Close()
        frmModificarPaciente.Show()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me.Close()
        frmEliminarPaciente.Show()
    End Sub

End Class