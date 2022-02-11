Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class itext

    Public Sub New()
        'nada xd
    End Sub

    Public Sub imprimirDGV(ByVal dgv As DataGridView, ByVal fecha As String, ByVal titulo As String)
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "Reporte" & Format(DateTime.Now, "ddMMyyyyhhmmss") & ".pdf"
            Dim file As New FileStream(filename, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc, dgv, fecha, titulo)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show(ex.Message & "En impresion_click")
        End Try
    End Sub


    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document, ByVal DataGridView2 As DataGridView, ByVal fecha As String, ByVal titulo As String)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGridView2.ColumnCount)
        'Se asignan las propiedades del .PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGridView2)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("REPORTE", New Font(Font.NORMAL, 20, Font.BOLD))
        Dim texto1 As New Paragraph("Nombre: " + titulo, New Font(Font.NORMAL, 14, Font.BOLD))
        Dim texto2 As New Paragraph("Fecha: " + fecha, New Font(Font.NORMAL, 14, Font.BOLD))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGridView2.ColumnCount - 1
            datatable.AddCell(DataGridView2.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1  'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGridView2.RowCount - 2
            For j As Integer = 0 To DataGridView2.ColumnCount - 1

                datatable.AddCell(DataGridView2(j, i).Value.ToString())

            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto1)
        document.Add(texto2)
        document.Add(datatable)
    End Sub
End Class
