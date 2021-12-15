Imports System.Data.OleDb
Imports System.IO

Public Class Form1

    Dim indice As Integer = 0

    Dim miAdaptador As OleDbDataAdapter
    Dim miConexionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\Neptuno.mdb"

    Dim miConexion As New OleDbConnection(miConexionString)
    Dim miTablaDatos As New DataTable

    Dim miBindingSource As New BindingSource
    Dim miConstructor As New OleDbCommandBuilder


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NeptunoDataSet.Productos)

        Try
            miConexion.Open()
            MessageBox.Show("La conexión ha sido exitosa")
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar a la base de datos")
        End Try
    End Sub
    Sub enlaceDb()
        textBoxProducto.DataBindings.Add(New Binding("Text", miBindingSource, "NombreProducto"))
    End Sub
    Private Sub btnTodas_Click(sender As Object, e As EventArgs) Handles btnTodas.Click
        Me.ProductosTableAdapter.FillByTodosProductos(Me.NeptunoDataSet.Productos)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim siguiente As Integer

        siguiente = indice + 1

        If siguiente >= miRejilla.Rows.Count Then
            Exit Sub
        Else
            miRejilla.CurrentCell = miRejilla.Rows(siguiente).Cells(miRejilla.CurrentCell.ColumnIndex)
            indice = indice + 1
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim anterior As Integer
        anterior = indice - 1

        If anterior < 0 Then
            Exit Sub
        Else
            miRejilla.CurrentCell = miRejilla.Rows(anterior).Cells(miRejilla.CurrentCell.ColumnIndex)
            indice = indice - 1
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        Dim registroUltimo As Integer

        registroUltimo = miRejilla.Rows.Count

        miRejilla.CurrentCell = miRejilla.Rows(registroUltimo - 1).Cells(miRejilla.CurrentCell.ColumnIndex)
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        miRejilla.CurrentCell = miRejilla.Rows(0).Cells(miRejilla.CurrentCell.ColumnIndex)
    End Sub

    Private Sub miRejilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles miRejilla.CellClick
        Dim miCelda As DataGridView = sender
        indice = miCelda.CurrentCell.RowIndex
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            'Intentar generar el documento.

            'preparacion de la memoria de volcado
            Dim doc_page As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 55, 20)

            Dim EnMemoria As New MemoryStream()
            Dim ImpPDF_P As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc_page, EnMemoria)

            'preparación del archivo de volcado
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate, 10, 10, 55, 20)
            'Path que guarda el PDF  (Directorio temporal de Internet).
            Dim NombreFichero As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\SIGAD_Export_" + Now.ToFileTimeUtc.ToString + ".pdf"
            Dim FicheroStream As New FileStream(NombreFichero, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            Dim ImpPDF As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, FicheroStream)


            Dim CabPie As New CClassPDFPage2

            CabPie.Logotipo = PicBx_Logo.Image
            CabPie.logoGeneral = PicBx_Logo.Image 'My.Resources.logo
            CabPie.NombreCentro = Centro
            CabPie.CursoActual = Now.Year 'IdAño & "/" & IdAño + 1
            CabPie.ColorTinta1 = Color.Black 'ColorTinta
            CabPie.TotalRegistros = miBindingsourceProd.Count
            'saber cuántas páginas habrá en total volcando PDF primero en memoria.
            doc_page.Open()
            ExportPDF(doc_page, RejillaProductos)
            CabPie.TotalPaginas = ImpPDF_P.PageNumber
            doc_page.Close()

            'generación de informe PDF en archivo

            ImpPDF.PageEvent = CabPie

            doc.Open()

            ExportPDF(doc, miRejilla)
            doc.Close()
            FicheroStream.Close()
            Process.Start(NombreFichero) ' visualizar el PDF ya terminado.
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF" & Chr(13) & ex.Message & Chr(13) &
                            "Puede existir otra exportación PDF abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
