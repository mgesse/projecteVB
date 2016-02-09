Imports MySql.Data.MySqlClient

Public Class Admn_LlibresAlumnes

    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
    'Fem tres Arrays per a desar els ID, IDcursRecolllida i idCursVenda, no ens cal el nom ja que el podem agafar de l'index del Combox
    Dim arrayID(70) As Integer
    Dim cursRec(70) As Integer
    Dim nomReco(70) As String
    Dim cursVen(70) As Integer
    Dim nomVend(70) As String

    'Fem 2 Arrays, un per desar els idDadesLlibre de tot un curs i l'altre per desar el nom dels anteriors.
    Dim arrayIDDadesLlibre(20) As Integer
    Dim arrayNomDadesLlibre(20) As String

    Dim idLlibre As Integer 'Ens desa la variable de l'ID del llibre que triem de la taula.
    Dim darrerIDAlumne As Integer   'Ens desa el darrer ID de l'alumne.

    Dim consultaLlibresRecollida As String
    Dim consultaLlibresVenda As String

    Private Sub Admn_LlibresAlumnes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged

        If RBt_1r.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 101 OR idCursRecollida = 102"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 100"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If

    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged
        If RBt_2n.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 201 OR idCursRecollida = 202"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 200"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged
        If RBt_3r.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 301 OR idCursRecollida = 302"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 300"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        If RBt_4rt.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 401 OR idCursRecollida = 402 OR idCursRecollida = 403"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 400"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        If RBt_5e.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 501 OR idCursRecollida = 502"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 500"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        If RBt_6e.Checked = True Then
            'Buidem el ComboBox
            BuidaComboBox()

            'Preparem la consulta a emprar
            Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 601 OR idCursRecollida = 602"

            'Cridem al mètode per a que ens executi la consulta.
            executaLlistaAlumnes(consultaAlumnes)

            'Preparem una consulta per esbrinar els id i noms dels llibres que s'usen en aquest curs.
            Dim consultaLlibre As String = "SELECT idDadesLlibre, titolLlibre FROM dadesLlibre WHERE idCursLlibre = 600"

            'Cridem al mètode que ens executa la consulta.
            executaLlistaLlibre(consultaLlibre)

        End If
    End Sub

    'Event que s'executa al fer al clic, ens consulta els llibres que ha entregat i comprat un alumne.
    Private Sub BotoConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotoConsulta.Click
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
        darrerIDAlumne = idAlumne
        'Preparem la consulta
        consultaLlibresRecollida = "SELECT lli.idLlibre, dl.titolLlibre, lli.numLlibre, lli.avaluacioInterior, lli.avaluacioExterior, lli.avaluacioTotal, et.nomEstat, lli.llibreActualitzat, lli.observacio FROM llibres lli INNER JOIN LlibreAlumneRecollida lar ON lar.idLlibre = lli.idLlibre INNER JOIN Alumnes al ON al.idAlumne = lar.idAlumne INNER JOIN EstatLlibres et ON et.idEstatLlibres = lli.idEstatLlibre INNER JOIN DadesLlibre dl ON dl.idDadesLlibre = lli.idDadesLlibre WHERE al.idAlumne = " & idAlumne & ""
        consultaLlibresVenda = "SELECT lli.idLlibre, dl.titolLlibre, lli.numLlibre, lli.avaluacioInterior, lli.avaluacioExterior, lli.avaluacioTotal, et.nomEstat, lli.llibreActualitzat, lli.observacio FROM llibres lli INNER JOIN LlibreAlumneVenda lav ON lav.idLlibre = lli.idLlibre INNER JOIN Alumnes al ON al.idAlumne = lav.idAlumne INNER JOIN EstatLlibres et ON et.idEstatLlibres = lli.idEstatLlibre INNER JOIN DadesLlibre dl ON dl.idDadesLlibre = lli.idDadesLlibre WHERE al.idAlumne = " & idAlumne & ""

        ompleTaula1(consultaLlibresRecollida)
        ompleTaula2(consultaLlibresVenda)

        
    End Sub

    'Event que s'executa al fer DOBLE clic a una fila de la taula.
    Private Sub DadesRecollida_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DadesRecollida.DoubleClick

        'Inserim les dades al panell superior.
        idLlibre = Me.DadesRecollida.CurrentRow.Cells.Item(0).Value                 'Obtenim l'ID del Llibre
        TxtB_IDLlibre.Text = idLlibre
        TxtB_NumLlibre.Text = Me.DadesRecollida.CurrentRow.Cells.Item(2).Value      'Obtenim el Número de Llibre
        TxtB_NomAssignatura.Text = Me.DadesRecollida.CurrentRow.Cells.Item(1).Value 'Obtenim el Nom de l'Assignatura al que pertany el Llibre
        TxtB_EstatLlibre.Text = Me.DadesRecollida.CurrentRow.Cells.Item(6).Value    'Obtenim el Nom de l'Estat del Llibre Triat.

        
    End Sub

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

    'Mètode per a omplir el Combo Box amb les dades de la llista d'alumnes.
    Private Sub executaLlistaAlumnes(ByVal consultaAlumnes As String)

        Dim myAdapter As New MySqlDataAdapter(consultaAlumnes, myConnection)    'Segon Adaptador per als Alumnes
        Dim mydatatable As New DataTable                                        'Fem una taula virtual
        myAdapter.Fill(mydatatable)                                             'Assigna l'adaptador amb la taula virtual

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then
            CBox_Alumnes.DataSource = mydatatable
            CBox_Alumnes.ValueMember = "nomAlumne"
            Dim final As Integer = mydatatable.Rows.Count

            'Fem una iteració de fins a 40 llocs 
            For iterador As Integer = 0 To final - 1

                Dim idAlumne As Integer
                Dim idCursRec, nom1Aux, idCursVen, nom2Aux As String

                idAlumne = mydatatable.Rows(iterador).Item("idAlumne")
                idCursRec = mydatatable.Rows(iterador).Item("idCursRecollida")
                nom1Aux = mydatatable.Rows(iterador).Item("cursRecollida")
                idCursVen = mydatatable.Rows(iterador).Item("idCursVenda")
                nom2Aux = mydatatable.Rows(iterador).Item("cursVenda")

                arrayID(iterador) = idAlumne
                cursRec(iterador) = idCursRec
                nomReco(iterador) = nom1Aux
                cursVen(iterador) = idCursVen
                nomVend(iterador) = nom2Aux

            Next
        End If

    End Sub

    'Mètode per a omplir els Combo Box amb els noms dels llibres.
    Private Sub executaLlistaLlibre(ByVal consultaLlibre As String)
        Dim myAdapter As New MySqlDataAdapter(consultaLlibre, myConnection)    'Segon Adaptador per als Alumnes
        Dim mydatatable As New DataTable                                        'Fem una taula virtual
        myAdapter.Fill(mydatatable)                                             'Assigna l'adaptador amb la taula virtual

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then
            CBox_Assignatures.DataSource = mydatatable
            CBox_Assignatures.ValueMember = "titolLlibre"
            Dim final As Integer = mydatatable.Rows.Count

            'Fem una iteració de fins a 40 llocs 
            For iterador As Integer = 0 To final - 1

                Dim idLlibreTriat As Integer
                Dim titolLlibre As String

                idLlibreTriat = mydatatable.Rows(iterador).Item("idDadesLlibre")
                titolLlibre = mydatatable.Rows(iterador).Item("titolLlibre")

                arrayIDDadesLlibre(iterador) = idLlibreTriat
                arrayNomDadesLlibre(iterador) = titolLlibre

            Next
        End If
    End Sub
    
    'Event que serveix per a blocar les dades del Modificar
    Private Sub Rbt_Elimina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_Elimina.CheckedChanged

        If Rbt_Elimina.Checked = True Then
            Boto_Elimina.Enabled = True
            TxtB_NouNumLlibre.Enabled = False
            CBox_Assignatures.Enabled = False
            Boto_Modifica.Enabled = False
        ElseIf Rbt_Elimina.Checked = False Then
            Boto_Elimina.Enabled = False
            TxtB_NouNumLlibre.Enabled = True
            CBox_Assignatures.Enabled = True
            Boto_Modifica.Enabled = True
        End If

    End Sub

    'Event que es tracta quan es vol modificar la relació del llibre.
    Private Sub Boto_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Modifica.Click

        'Obtenim les dades noves dels llibres.
        Dim nouNumLlibre As Integer
        Try
            nouNumLlibre = TxtB_NouNumLlibre.Text
        Catch ex As Exception
            MsgBox("Has d'inserir un valor numèric com a Número de Llibre", MsgBoxStyle.Exclamation)
            nouNumLlibre = 0
        End Try
        'Obtenim el valor de l'ID de dades Llibre
        Dim index As Integer = CBox_Assignatures.SelectedIndex
        Dim nouIdDadesLlibre As Integer = arrayIDDadesLlibre(index)

        'Flitrem, si numLlibre > 0 fem les tasques...
        If nouNumLlibre > 0 Then

            'Hem de comprovar que el Nº de Llibre existeix i que no sigui un de retirat.
            Dim consultaComprovaExistencia As String = "SELECT COUNT(numLlibre) As 'res' FROM llibres WHERE idDadesLlibre = " & nouIdDadesLlibre & " AND numLlibre = " & nouNumLlibre & " AND NOT idEstatLlibre = 1 AND NOT idEstatLlibre = 4 AND NOT idEstatLlibre = 6"

            'Executem la consulta...
            Dim controlExistencia As Boolean = comprovaExistencia(consultaComprovaExistencia)

            'Si ha passat la prova, hem de comprovar el seu ID
            If controlExistencia = True Then
                'Cas que el llibre existís i estigués disponible de cara a les seves dades.
                Dim consultaIDLlibre As String = "SELECT idLlibre FROM llibres Where numLlibre = " & nouNumLlibre & " AND idDadesLlibre = " & nouIdDadesLlibre & ""

                'Obtenim l'ID del llibre triat.
                Dim nouIDLlibre As Integer = executaConsultaIDLlibre(consultaIDLlibre)

                'Hem d'eliminar la relació de llibre - assignatura actual per posar la nova.
                Dim deleteRelacio As String = "DELETE FROM llibreAlumneRecollida WHERE idAlumne = " & darrerIDAlumne & " AND idLlibre = " & idLlibre & ""

                'Cridem al mètode per a que elimini la relació.
                esborraRelacio(deleteRelacio)

                Dim insertRelacio As String = "INSERT INTO llibreAlumneRecollida VALUES ( " & darrerIDAlumne & ", " & nouIDLlibre & ", CURRENT_TIMESTAMP)"

                'Cridem al mètode per a que ens insereixi la nova relació.
                insereixRelacio(insertRelacio)

                'Reposem la consulta per carregar les dades de la taula.
                ompleTaula1(consultaLlibresRecollida)
                ompleTaula2(consultaLlibresVenda)


            Else
                MsgBox("El número de llibre de l'assignatura posada no existeix")

            End If


        End If

    End Sub

    'Mètode que em comprova l'existència d'un llibre triat a la Base de Dades
    Private Function comprovaExistencia(ByVal Consulta) As Boolean

        Dim myAdapter As New MySqlDataAdapter(Consulta, myConnection)   'Establim l'adaptador amb la sentència SQL que li passem per paràmetre

        Dim mydatatable As New DataTable        'Fem l'assignació de la taula
        myAdapter.Fill(mydatatable)
        Dim resultat As Integer                 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("res") 'Assignem a la variable resultat el que es contingui.
        End If

        'En funció del resultat, retornem un número / 1 = Repetit - 0 = No portat. /
        If resultat = 1 Then
            comprovaExistencia = True
        Else
            comprovaExistencia = False
        End If

    End Function

    'Mètode que ens obtindrà l'ID del llibre nou triat.
    Private Function executaConsultaIDLlibre(ByVal consulta) As Integer

        Dim myAdapter As New MySqlDataAdapter(consulta, myConnection)   'Establim l'adaptador amb la sentència SQL que li passem per paràmetre

        Dim mydatatable As New DataTable        'Fem l'assignació de la taula
        myAdapter.Fill(mydatatable)
        Dim resultat As Integer                 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("idLlibre") 'Assignem a la variable resultat el que es contingui.
        End If

        executaConsultaIDLlibre = resultat

    End Function

    'Mètode per a esborrar la relació d'un llibre!
    Private Sub esborraRelacio(ByVal delete)

        Dim myAdapter As New MySqlDataAdapter(delete, myConnection)   'Establim l'adaptador amb la sentència SQL que li passem per paràmetre

        Dim mydatatable As New DataTable        'Fem l'assignació de la taula
        myAdapter.Fill(mydatatable)

    End Sub

    'Mètode per a inserir la relació d'un llibre!
    Private Sub insereixRelacio(ByVal insert)

        Dim myAdapter As New MySqlDataAdapter(insert, myConnection)   'Establim l'adaptador amb la sentència SQL que li passem per paràmetre

        Dim mydatatable As New DataTable        'Fem l'assignació de la taula
        myAdapter.Fill(mydatatable)

    End Sub

    'Mètode que ens omple la taula de llibres de recollida
    Private Sub ompleTaula1(ByVal consultaLlibresRecollida)
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
    End Sub

    'Mètode que ens omple la taula de llibres de venda
    Private Sub ompleTaula2(ByVal consultaLlibresVenda)
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

    Private Sub Boto_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Elimina.Click
        'Hem d'eliminar la relació de llibre - assignatura actual per posar la nova.
        Dim deleteRelacio As String = "DELETE FROM llibreAlumneRecollida WHERE idAlumne = " & darrerIDAlumne & " AND idLlibre = " & idLlibre & ""

        'Cridem al mètode per a que elimini la relació.
        esborraRelacio(deleteRelacio)

        'Reposem la consulta per carregar les dades de la taula.
        ompleTaula1(consultaLlibresRecollida)
        ompleTaula2(consultaLlibresVenda)
    End Sub
End Class