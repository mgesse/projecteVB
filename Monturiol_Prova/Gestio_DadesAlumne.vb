Imports MySql.Data.MySqlClient


Public Class Gestio_DadesAlumne

    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    'Fem tres Arrays per a desar els ID, IDcursRecolllida i idCursVenda, no ens cal el nom ja que el podem agafar de l'index del Combox
    Dim arrayID(70) As Integer
    Dim cursRec(70) As Integer
    Dim nomReco(70) As String
    Dim cursVen(70) As Integer
    Dim nomVend(70) As String

    'Mètode per a buidar el Combo Box i dades dels TextBox.
    Public Sub BuidaComboBox()
        CBox_Alumnes.DataSource = Nothing
        CBox_Alumnes.ValueMember = Nothing
        CBox_Alumnes.DisplayMember = Nothing
        CBox_Alumnes.DropDownWidth = 1
        CBox_Alumnes.SelectedValue = Nothing
        CBox_Alumnes.Text = Nothing
        TxtB_Nom.Text = ""
        TxtB_CursRec.Text = ""
        TxtB_CursVenda.Text = ""
    End Sub

    'Mètodes dels Botons, en els que gestionarem la llista d'alumnes.
    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged

        If RBt_1r.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Primer d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 101 OR idCursRecollida =102"
            '"SELECT idAlumne, nomAlumne, idCursRecollida, idCursVenda FROM alumnes WHERE idCursRecollida = 101 OR idCursRecollida = 102"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"
                Dim final As Integer = mydatatable2.Rows.Count

                'Fem una iteració de fins a 40 llocs 
                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If
        ElseIf RBt_1r.Checked = False Then

        End If
        

        'Consulta = "SELECT idAlumne, nomAlumne, idCursRecollida, idCursVenda FROM alumnes WHERE idCursRecollida = 101 OR idCursRecollida = 102"
    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged

        If RBt_2n.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Segon d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 201 OR idCursRecollida =202"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"

                'Fem una iteració de fins a 40 llocs 
                Dim final As Integer = mydatatable2.Rows.Count

                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If

        ElseIf RBt_2n.Checked = False Then

        End If
        
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged

        If RBt_3r.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Primer d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 301 OR idCursRecollida = 302"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"

                'Fem una iteració de fins a 40 llocs 
                Dim final As Integer = mydatatable2.Rows.Count

                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If

        ElseIf RBt_3r.Checked = False Then

        End If
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        If RBt_4rt.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Primer d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 401 OR idCursRecollida = 402 OR idCursRecollida = 403"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"

                'Fem una iteració de fins a 40 llocs 
                Dim final As Integer = mydatatable2.Rows.Count

                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If

        ElseIf RBt_4rt.Checked = False Then

        End If
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        If RBt_5e.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Primer d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 501 OR idCursRecollida = 502"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"

                'Fem una iteració de fins a 40 llocs 
                Dim final As Integer = mydatatable2.Rows.Count

                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If

        ElseIf RBt_5e.Checked = False Then

        End If
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        If RBt_6e.Checked = True Then
            'Buidem les dades que hi ha al comboBox 
            BuidaComboBox()

            'Consulta específica per a Primer d'ESO
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 601 OR idCursRecollida = 602"

            'Segon Adaptador per als Alumnes
            Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

            'Fem una taula virtual
            Dim mydatatable2 As New DataTable

            'Assigna l'adaptador amb la taula virtual
            myAdapter2.Fill(mydatatable2)

            'Ens assegurem que hi ha dades
            If mydatatable2.Rows.Count > 0 Then
                CBox_Alumnes.DataSource = mydatatable2
                CBox_Alumnes.ValueMember = "nomAlumne"

                'Fem una iteració de fins a 40 llocs 
                Dim final As Integer = mydatatable2.Rows.Count

                For iterador As Integer = 0 To final - 1

                    Dim idAlumne As Integer
                    Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                    idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                    idCursRec = mydatatable2.Rows(iterador).Item("idCursRecollida")
                    nom1Aux = mydatatable2.Rows(iterador).Item("cursRecollida")
                    idCursVen = mydatatable2.Rows(iterador).Item("idCursVenda")
                    nom2Aux = mydatatable2.Rows(iterador).Item("cursVenda")

                    arrayID(iterador) = idAlumne
                    cursRec(iterador) = idCursRec
                    nomReco(iterador) = nom1Aux
                    cursVen(iterador) = idCursVen
                    nomVend(iterador) = nom2Aux

                Next
            End If

        ElseIf RBt_6e.Checked = False Then

        End If
    End Sub

    'Mètode que executa la consulta.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Esborrem les dades que hi pugui haver al Data Gred View
        DadesRecollida.DataSource = Nothing
        DadesRecollida.Refresh()

        DadesVenda.DataSource = Nothing
        DadesVenda.Refresh()

        'Posem les dades estàtiques de l'alumne triat al ComboBox.
        Dim index As Integer = CBox_Alumnes.SelectedIndex
        TxtB_Nom.Text = CBox_Alumnes.Text
        TxtB_CursRec.Text = nomReco(index)
        TxtB_CursVenda.Text = nomVend(index)

        'Realitzem la consulta amb les dades de l'Alumne triat.

        'Obtenim l'ID de l'Alumne
        Dim idAlumne As Integer = arrayID(index)

        'Preparem la consulta
        Dim consultaLlibresRecollida As String = "SELECT lli.idLlibre, dl.titolLlibre, lli.numLlibre, lli.avaluacioInterior, lli.avaluacioExterior, lli.avaluacioTotal, et.nomEstat, lli.llibreActualitzat, lli.observacio FROM llibres lli INNER JOIN LlibreAlumneRecollida lar ON lar.idLlibre = lli.idLlibre INNER JOIN Alumnes al ON al.idAlumne = lar.idAlumne INNER JOIN EstatLlibres et ON et.idEstatLlibres = lli.idEstatLlibre INNER JOIN DadesLlibre dl ON dl.idDadesLlibre = lli.idDadesLlibre WHERE al.idAlumne = " & idAlumne & ""
        Dim consultaLlibresVenda As String = "SELECT lli.idLlibre, dl.titolLlibre, lli.numLlibre, lli.avaluacioInterior, lli.avaluacioExterior, lli.avaluacioTotal, et.nomEstat, lli.llibreActualitzat, lli.observacio FROM llibres lli INNER JOIN LlibreAlumneVenda lav ON lav.idLlibre = lli.idLlibre INNER JOIN Alumnes al ON al.idAlumne = lav.idAlumne INNER JOIN EstatLlibres et ON et.idEstatLlibres = lli.idEstatLlibre INNER JOIN DadesLlibre dl ON dl.idDadesLlibre = lli.idDadesLlibre WHERE al.idAlumne = " & idAlumne & ""

        'Adaptador per als Alumnes
        Dim myAdapter As New MySqlDataAdapter(consultaLlibresRecollida, myConnection)

        'Fem una taula virtual
        Dim mydatatable As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapter.Fill(mydatatable)

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then

            'Omplim la taula
            DadesRecollida.DataSource = mydatatable


        End If

        'Adaptador per als Alumnes
        Dim myAdapterVenda As New MySqlDataAdapter(consultaLlibresVenda, myConnection)

        'Fem una taula virtual
        Dim mydatatableVenda As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapterVenda.Fill(mydatatableVenda)

        'Ens assegurem que hi ha dades
        If mydatatableVenda.Rows.Count > 0 Then

            'Omplim la taula
            DadesVenda.DataSource = mydatatableVenda


        End If

    End Sub

   
    
    
    Private Sub Gestio_DadesAlumne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class