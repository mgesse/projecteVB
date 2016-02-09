Imports MySql.Data.MySqlClient

Public Class Gestio_LlibresRetirats
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
    Private Sub Gestio_LlibresRetirats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim consultaLlibresRetirats As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 6"

        'Segon Adaptador per als Alumnes
        Dim myAdapter2 As New MySqlDataAdapter(consultaLlibresRetirats, myConnection)

        'Fem una taula virtual
        Dim mydatatable2 As New DataTable

        'Assigna l'adaptador amb la taula virtual
        Dim mydatatable As New DataTable

        myAdapter2.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub
End Class