Public Class frmEliminarPaciente

    Dim con As Conexion = New Conexion
    Dim comm As String

    Private Sub frmEliminarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente & " " & VariablesGlobales.paternoPaciente & " " & VariablesGlobales.maternoPaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
        Label3.Text = "Correo: " & VariablesGlobales.correoPaciente
        Label4.Text = "Fecha Nacimiento: " & VariablesGlobales.fechaNacimiento
        Label5.Text = "¿Quiere eliminar este registro?"
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        comm = "delete from pacientes where idPaciente= " & VariablesGlobales.idPaciente
        con.fillDataTable(comm)
        MessageBox.Show("Paciente Eliminado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        frmPacientes.Show()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmRegistroPacientesMenu.Show()

    End Sub

End Class