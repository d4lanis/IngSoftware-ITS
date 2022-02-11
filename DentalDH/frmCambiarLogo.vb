Imports System.IO

Public Class frmCambiarLogo

    Dim dt As DataTable
    Private con As Conexion
    Private comm As String
    Private command As String
    Private ms As New MemoryStream

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmMenuAdmin.Show()
    End Sub

    Private Sub btn_Examinar_Click(sender As Object, e As EventArgs) Handles btn_Examinar.Click
        OpenFileDialog1.Filter = "Imágenes |*.jpg; *.png; *.jpeg; *.bmp"
        OpenFileDialog1.Title = "Seleccione una Imagen"
        OpenFileDialog1.InitialDirectory = ""

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txt_RutaImagen.Text = OpenFileDialog1.FileName
            PictureBoxLogo.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btn_SubirLogo_Click(sender As Object, e As EventArgs) Handles btn_SubirLogo.Click
        If String.IsNullOrEmpty(txt_RutaImagen.Text) Then
            MessageBox.Show("Por favor seleccione una imagen", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PictureBoxLogo.Image.Save(ms, PictureBoxLogo.Image.RawFormat)
            comm = "Select * from logo"
            con = New Conexion
            dt = con.fillDataTable(comm)

            If dt.Rows.Count = 0 Then
                command = "insert into logo (imagen) values (@img )"
                con.insertImagen(command, ms)
                MessageBox.Show("Logo cambiado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                command = "update logo set imagen=(@img) where idLogo=1"
                con.insertImagen(command, ms)
                MessageBox.Show("Logo cambiado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

End Class