Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Conexion
    Private cnx As String
    Private sqlCom As MySqlCommand
    Private sqlCnx As MySqlConnection
    Private sqlDA As MySqlDataAdapter
    Public dt As DataTable
    Private ms As MemoryStream
    Private lector As MySqlDataReader


    'Metodo constructor que genera un objeto conexión sin abrir.
    Public Sub New()
        Try
            cnx = VariablesGlobales.cnx 'Hay que darle valor desde el módulo.
            sqlCnx = New MySqlConnection(cnx)
            sqlCnx.Open()
        Catch e As Exception
            MsgBox("Error conectando con la Base de Datos: " & e.Message)
        End Try

    End Sub

    'Metodo que regresa un datatable que se llena a partir de un query.
    'La manera correcta de usarlo es creando un objeto DataTable en la clase en la que
    'lo quieres usar y escribiendo ésto: dt = Conexion.DataTable("String con el query")
    'Muestra un mensaje de error cuándo falla y devuelve un objeto datatable vacío.
    Public Function fillDataTable(ByVal query As String)
        Try
            sqlCom = New MySqlCommand(query, sqlCnx)
            sqlDA = New MySqlDataAdapter(sqlCom)
            dt = New DataTable
            sqlDA.Fill(dt)
            sqlCom.Dispose()
            sqlDA.Dispose()
            Return dt
        Catch e As Exception

            If e.Message.CompareTo("Cannot delete or update a parent row: a foreing key constraint fails.") <> 0 Then 'Para que no salte por cmd vacío (Necesario para casos de uso con dgv y búsqueda por txtbox
                MsgBox("Se ha generado un error: Llame al administrador.")

            ElseIf e.Message.CompareTo("The CommandText property has not been properly initialized.") <> 0 Then 'Para que no salte por cmd vacío (Necesario para casos de uso con dgv y búsqueda por txtbox
                MsgBox("Error en el método fillDataTable de la clase Conexión: " & e.Message & ". Llame al administrador.")
            Else
                MsgBox("Error en el método fillDataTable de la clase Conexión: " & e.Message & ". Llame al administrador.")
            End If
            dt = New DataTable
            sqlCom.Dispose()
            sqlDA.Dispose()
            Return dt
        End Try
    End Function

    'A éste método se le envía un objeto DGV y lo llena con un query. 
    'Se invoca así: Conexion.fillDGV("String con el query", dgv) NOTA: dgv es un objeto DataGridView
    Public Sub fillDGV(ByVal query As String, ByRef dgv As DataGridView)
        Dim dt As DataTable
        dt = fillDataTable(query)
        dgv.DataSource = dt
        dt.Dispose()
    End Sub


    'Similar a fillDGV, pero con un combo box. Se invoca igual:
    'Conexion.fillComboBox("String con el query", cb) NOTA: cb es un objeto combobox.
    Public Sub fillComboBox(ByVal query As String, ByRef cb As ComboBox, ByVal displayMember As String, ByVal valueMember As String)
        Dim dt As DataTable
        dt = fillDataTable(query)
        cb.DataSource = dt
        cb.DisplayMember = displayMember
        cb.ValueMember = valueMember
    End Sub

    'Ejecuta un comando que no sea query, como un delete, update o insert. Se le envía un string con el comando. No regresa nada.
    Public Sub ejecutarNoQuery(ByVal comando As String)
        Try
            sqlCom = New MySqlCommand(comando, sqlCnx)
            sqlCom.ExecuteNonQuery()
            sqlCom.Dispose()
        Catch e As Exception
            If (e.Message.CompareTo("Duplicate entry 'admin' for key 'usuarios.usuario'") <> 0) Then
                MsgBox("Error en método ejecutarNoQuery de la clase conexión " & e.Message & ". Llame al administrador.")
            Else
                MsgBox("Ya existe un empleado con el mismo nombre de usuario.")
                VariablesGlobales.usuarioDuplicado = True
            End If

        End Try
    End Sub

    Public Sub insertImagen(ByVal comando As String, ByVal ms As MemoryStream)
        Try
            sqlCom = New MySqlCommand(comando, sqlCnx)
            sqlCom.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
            sqlCom.ExecuteNonQuery()
            sqlCom.Dispose()
        Catch e As Exception
            MsgBox("Error en método ejecutarNoQuery de la clase conexión " & e.Message & ". Llame al administrador.")
        End Try
    End Sub

    Public Function calcularDeuda(ByVal idAdeudo As Integer)
        Dim deuda As Integer = 0
        Dim query As String
        Dim dt As DataTable
        query = "SELECT adeudos.monto - (SELECT (CASE WHEN SUM(pagos.monto) IS NOT NULL
THEN SUM(pagos.monto)
ELSE '0'
END) FROM pagos where pagos.idAdeudo=" & idAdeudo & ") as deudaTotal from adeudos where adeudos.idAdeudo=" & idAdeudo & ""
        dt = fillDataTable(query)
        If dt.Rows(0).Item("deudaTotal") >= 0 Then 'si la deuda es 0 o mayor que 0 dasela
            deuda = dt.Rows(0).Item("deudaTotal")
        End If
        Return deuda 'Regresa la deuda total o un 0 si le debemos al cliente jijiji
    End Function

    Function validaremail(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            validaremail = True
        Else
            validaremail = False
        End If

    End Function

End Class
