Public Class frmEliminarAdeudo
    Dim con As Conexion = New Conexion
    Dim comm As String

    Private Sub frmEliminarAdeudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Paciente: " & VariablesGlobales.nombrePaciente
        Label2.Text = "Telefono: " & VariablesGlobales.telefonoPaciente
        Label3.Text = "Adeudo: " & VariablesGlobales.monto
        Label4.Text = "Concepto: " & VariablesGlobales.concepto
        Label5.Text = "Fecha: " & VariablesGlobales.f
        Label6.Text = "¿Quiere eliminar este registro?"
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmAdeudos.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            comm = "delete from adeudos where idAdeudo=" & VariablesGlobales.idAdeudo
            con.fillDataTable(comm)
            MessageBox.Show("Adeudo Eliminado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("No se pueden eliminar adeudos que tienen abonos registrados o en estatus de pagado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
        frmAdeudos.Show()
    End Sub

End Class