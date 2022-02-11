Imports Microsoft.VisualBasic
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Module VariablesGlobales
    Public idUsuario As Integer
    Public nombreUsuario As String
    Public idAdeudo As Integer
    Public idPaciente As Integer
    Public nombrePaciente As String
    Public paternoPaciente As String
    Public maternoPaciente As String
    Public telefonoPaciente As String
    Public correoPaciente As String
    Public fechaNacimiento As String
    Public permiso As Integer
    Public concepto As String
    Public monto As Integer
    Public f As String
    Public idHistorialClinico As Integer
    Public cnx As String = "server=localhost;uid=dentaldh;pwd=desarollo123;database=dental" 'Hay que elegir el valor de ésto cuándo hagamos la sintaxis y un usuario, de tal manera que el mismo string funcione en tu pc y en la mía para que al hacer el ejecutable todo funcione igual.
    'Accedemos a éstas variables llamandolas desde cualquier lugar. Cambia sus valores al cada que ocupes DE MANERA DINÁMICA.
    'Éstas las uso para mover datos para editar el usuario. -Jesús. No las uses Alanigod. 
    Public idUsuarioEdit As Integer
    Public permisosNombreEdit As String
    Public nombreUsuarioEdit As String
    Public usuarioDuplicado As Boolean
    Public nombrePacienteEditCita As String
    Public fecha As Date
    Public servicio As String
    Public descripcion As String
    Public asistencia As Boolean
    Public idCita As Integer
    Public deuda As Integer
    Public motivo As String
    'Para registro de pagos

End Module
