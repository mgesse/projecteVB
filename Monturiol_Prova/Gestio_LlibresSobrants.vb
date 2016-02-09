Imports MySql.Data.MySqlClient

Public Class Gestio_LlibresSobrants
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    Private Sub Gestio_LlibresSobrants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged
        If RBt_1r.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged
        If RBt_2n.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged
        If RBt_3r.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        If RBt_4rt.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        If RBt_5e.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        If RBt_6e.Checked = True Then
            Dim consultaLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaLlibres, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ConsultaDadesLlibres As String = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3"
        'MsgBox("hola: " & ConsultaDadesLlibres)
        If RBt_1r.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >100 and ll.idDadesLlibre <107"
        ElseIf RBt_2n.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >200 and ll.idDadesLlibre <207"
        ElseIf RBt_3r.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >300 and ll.idDadesLlibre <308"
        ElseIf RBt_4rt.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >400 and ll.idDadesLlibre <405"
        ElseIf RBt_5e.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >500 and ll.idDadesLlibre <515"
        ElseIf RBt_6e.Checked = True Then
            ConsultaDadesLlibres = "SELECT ll.idDadesLlibre, ll.numLlibre, ll.avaluacioInterior, ll.avaluacioExterior, ll.avaluacioTotal, ll.llibreActualitzat, ll.observacio FROM llibres ll WHERE ll.idEstatLlibre = 3 and ll.idDadesLlibre >600 and ll.idDadesLlibre <616"
        End If
        Dim myAdapter As New MySqlDataAdapter(ConsultaDadesLlibres, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub
End Class