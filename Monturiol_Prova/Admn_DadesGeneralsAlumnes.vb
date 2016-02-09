Imports MySql.Data.MySqlClient

Public Class Admn_DadesGeneralsAlumnes

    Dim consultaAlumnes As String = ""  'Variable que ens desa la consulta per treure la lllista d'Alumnes.
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    Dim idAlumne As String = "" 'Variable que desa l'ID de l'alumne
    Dim darreraConsulta As String = "" 'Variable que ens desa la darrera consulta de llista d'Alumnes.
    Dim arrayIDCursos(20) As Integer

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged
        'Definim la consulta d'alumnes a fer.
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 101 OR idCursRecollida = 102"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 201 OR idCursRecollida = 202"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 301 OR idCursRecollida = 302"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 401 OR idCursRecollida = 402 OR idCursRecollida = 403"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 501 OR idCursRecollida = 502"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        consultaAlumnes = "SELECT al.idAlumne, al.nomAlumne, al.idCursRecollida, c.nomCurs as cursRecollida, al.idCursVenda, z.nomCurs as cursVenda, al.PreuTotalRecollida, al.PreuTotalVenda, al.Observacio, al.alumneActualitzat FROM alumnes al INNER JOIN Cursos c ON al.idCursRecollida = c.idCursos INNER JOIN Cursos z ON al.idCursVenda = z.idCursos WHERE idCursRecollida = 601 OR idCursRecollida = 602"
        getAlumnes(consultaAlumnes)

        'Desem la consulta:
        darreraConsulta = consultaAlumnes

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        netejaDades()
    End Sub

    'Mètode que ens insereix els alumnes a la taula en funció del curs triat.
    Private Sub getAlumnes(ByVal consultaAlumnes As String)

        'Segon Adaptador per als Alumnes
        Dim myAdapter As New MySqlDataAdapter(consultaAlumnes, myConnection)

        'Fem una taula virtual
        Dim mydatatable As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapter.Fill(mydatatable)

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then

            'Omplim la taula
            DataGridView1.DataSource = mydatatable
           
        End If
    End Sub

    'Mètode que ens desmarca el CheckBox.
    Private Sub desmarcaCheckBox()
        ChkB_Nom.Checked = False
        ChkB_Cursos.Checked = False
        ChkB_Recollida.Checked = False
        ChkB_Venda.Checked = False
        ChkB_Observacio.Checked = False
    End Sub

    'Mètode que ens neteja el text dels elements.
    Private Sub netejaDades()
        TxtB_NomAlumne.Text = ""
        CBox_CursRec.Text = "Sense Curs"
        CBox_CursVen.Text = "Sense Curs"
        TxtB_ValorRecollida.Text = ""
        TxtB_ValorVenda.Text = ""
        TxtB_Observacio.Text = ""
    End Sub

    'Si fem doble clic a una fila de la taula, posarem les dades al text box de fora!
    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'Inserim les dades al panell superior.

        idAlumne = Me.DataGridView1.CurrentRow.Cells.Item(0).Value              'Extreiem l'ID triat de l'alumne!
        Try
            TxtB_NomAlumne.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value   'Extreiem el Nom de l'Alumne
        Catch ex As Exception
            TxtB_NomAlumne.Text = "NOM PER DETERMINAR, CANVIA'L"
        End Try


        Try
            CBox_CursRec.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value 'Extraiem el Curs de Recollida de l'Alumne
        Catch ex As Exception
            CBox_CursRec.Text = "Sense Curs"                                        'Cas que no hi hagi curs, posem el valor per defecte.
        End Try

        Try
            CBox_CursVen.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value 'Extraiem el Curs de Venda de l'Alumne
        Catch ex As Exception
            CBox_CursVen.Text = "Sense Curs"                                        'Cas que no hi hagi curs, posem el valor per defecte.
        End Try

        Try
            TxtB_ValorRecollida.Text = Me.DataGridView1.CurrentRow.Cells.Item(6).Value  'Extraiem el valor dels comprovants de Recollida.
        Catch ex As Exception
            TxtB_ValorRecollida.Text = "0,00"
        End Try

        Try
            TxtB_ValorVenda.Text = Me.DataGridView1.CurrentRow.Cells.Item(7).Value      'Extraiem el valor dels comprovants de Venda.
        Catch ex As Exception
            TxtB_ValorVenda.Text = "0,00"
        End Try

        Try
            TxtB_Observacio.Text = Me.DataGridView1.CurrentRow.Cells.Item(8).Value      'Extraiem el valor de la Observació.
        Catch ex As Exception
            TxtB_Observacio.Text = ""
        End Try

        'Bloquem els CheckBox per a que no es pugui modificar per defecte.
        desmarcaCheckBox()
        

    End Sub

    'Mètodes de canvis de Check Box per a habilitar l'edició dels camps!
    Private Sub ChkB_Nom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Nom.CheckedChanged

        If ChkB_Nom.Checked = True Then
            TxtB_NomAlumne.Enabled = True
        ElseIf ChkB_Nom.Checked = False Then
            TxtB_NomAlumne.Enabled = False
        End If

    End Sub

    Private Sub ChkB_Cursos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Cursos.CheckedChanged
        If ChkB_Cursos.Checked = True Then
            CBox_CursRec.Enabled = True
            CBox_CursVen.Enabled = True
        ElseIf ChkB_Cursos.Checked = False Then
            CBox_CursRec.Enabled = False
            CBox_CursVen.Enabled = False
        End If
    End Sub

    Private Sub ChkB_Recollida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Recollida.CheckedChanged
        If ChkB_Recollida.Checked = True Then
            TxtB_ValorRecollida.Enabled = True
        ElseIf ChkB_Recollida.Checked = False Then
            TxtB_ValorRecollida.Enabled = False
        End If
    End Sub

    Private Sub ChkB_Venda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Venda.CheckedChanged
        If ChkB_Venda.Checked = True Then
            TxtB_ValorVenda.Enabled = True
        ElseIf ChkB_Venda.Checked = False Then
            TxtB_ValorVenda.Enabled = False
        End If
    End Sub

    Private Sub ChkB_Observacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Observacio.CheckedChanged
        If ChkB_Observacio.Checked = True Then
            TxtB_Observacio.Enabled = True
        ElseIf ChkB_Observacio.Checked = False Then
            TxtB_Observacio.Enabled = False
        End If
    End Sub

    Private Sub Admn_DadesGeneralsAlumnes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carreguem l'Array
        arrayIDCursos(0) = 1
        arrayIDCursos(1) = 100
        arrayIDCursos(2) = 101
        arrayIDCursos(3) = 102
        arrayIDCursos(4) = 200
        arrayIDCursos(5) = 201
        arrayIDCursos(6) = 202
        arrayIDCursos(7) = 300
        arrayIDCursos(8) = 301
        arrayIDCursos(9) = 302
        arrayIDCursos(10) = 400
        arrayIDCursos(11) = 401
        arrayIDCursos(12) = 402
        arrayIDCursos(13) = 403
        arrayIDCursos(14) = 500
        arrayIDCursos(15) = 501
        arrayIDCursos(16) = 502
        arrayIDCursos(17) = 600
        arrayIDCursos(18) = 601
        arrayIDCursos(19) = 602

        'MsgBox("Contingut de l'Array i ComboBox a la posició 8: " & arrayIDCursos(0) & " - " & CBox_CursRec.Items(0).ToString)

    End Sub

    'Mètode que fara la modificació a la Base de Dades.
    Private Sub Boto_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Modifica.Click
        'Obtenim els elements que s'han modificat.
        Dim nouNom As String = TxtB_NomAlumne.Text
        

        'Cas que estigui permesa la modificació d'alumnes al check box corresponent, fem els procediments necessaris
        If ChkB_Modificacio.Checked = True Then

            'Fem un control per evitar que no pugui actualitzar-se alguna cosa que no hagi estat modificada o a null.
            If nouNom = "" Then
                MsgBox("Insereix i/o actualitza les dades")
            Else

                Dim idCursAux As Integer = CBox_CursRec.SelectedIndex
                'MsgBox("Index triat: " & idCursAux)
                Dim nouCursRecollida As Integer = arrayIDCursos(idCursAux)
                idCursAux = CBox_CursVen.SelectedIndex
                Dim nouCursVenda As Integer = arrayIDCursos(idCursAux)
                Dim nouValorResguardRecollida As Double = TxtB_ValorRecollida.Text
                Dim nouValorResguardVenda As Double = TxtB_ValorVenda.Text
                Dim novaObservacio As String = TxtB_Observacio.Text

                'Preparem la consulta d'inserció.
                Dim update As String = "UPDATE alumnes SET nomAlumne = '" & nouNom & "', idCursRecollida = " & nouCursRecollida & ", idCursVenda = " & nouCursVenda & ", preuTotalRecollida = " & nouValorResguardRecollida & ", preuTotalVenda = " & nouValorResguardVenda & ", observacio = '" & novaObservacio & "', alumneActualitzat = CURRENT_TIMESTAMP WHERE idAlumne = " & idAlumne & ""

                'Cridem el mètode que ens permetrà fer l'actualització.
                executaModificacio(update)

                'Actualitzem la Taula
                actualitzaTaula(darreraConsulta)

                'Reposem els controls
                desmarcaCheckBox()
                netejaDades()
            End If
            

        End If


    End Sub

    'Mètode que ens actualitza la Base de Dades!
    Private Sub executaModificacio(ByVal modificacio)

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(modificacio, myConnection)
        'MsgBox("Consulta: " & modificacio)
        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem

    End Sub

    'Mètode que ens actualitza la Base de Dades!
    Private Sub executaInsercio(ByVal modificacio)

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(modificacio, myConnection)
        'MsgBox("Inserció: " & modificacio)
        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem

    End Sub

    Private Sub actualitzaTaula(ByVal consulta As String)

        Dim myAdapter As New MySqlDataAdapter(consulta, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub

    Private Sub ChkB_Modificacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Modificacio.CheckedChanged

        If ChkB_Modificacio.Checked = True Then
            ChkB_Insrcio.Checked = False
        Else
            ChkB_Insrcio.Checked = True
        End If

    End Sub

    Private Sub ChkB_Insrcio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Insrcio.CheckedChanged
        If ChkB_Insrcio.Checked = True Then
            ChkB_Modificacio.Checked = False
        Else
            ChkB_Modificacio.Checked = True
        End If
    End Sub

    Private Sub BotoInsereix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotoInsereix.Click
        'Obtenim els elements que s'han modificat.
        Dim nouNom As String = TxtB_Ins_Nom.Text


        'Cas que estigui permesa la inserció d'alumnes al check box corresponent, fem els procediments necessaris
        If ChkB_Insrcio.Checked = True Then

            'Fem un control per evitar que no pugui actualitzar-se alguna cosa que no hagi estat modificada o a null.
            If nouNom = "" Then
                MsgBox("Insereix i/o actualitza les dades")
            Else

                Dim idCursAux As Integer = Cbox_Ins_Recollida.SelectedIndex
                'MsgBox("Index triat: " & idCursAux)
                Dim nouCursRecollida As Integer = arrayIDCursos(idCursAux)
                idCursAux = CBox_Ins_Venda.SelectedIndex
                Dim nouCursVenda As Integer = arrayIDCursos(idCursAux)
                Dim nouValorResguardRecollida As Double = TxtB_Ins_Recollida.Text
                Dim nouValorResguardVenda As Double = TxtB_Ins_Venda.Text
                Dim novaObservacio As String = TxtB_Ins_Observacio.Text

                'Preparem la consulta d'inserció.
                Dim insert As String = "INSERT INTO alumnes SET nomAlumne, idCursRecollida, idCursVenda, preuTotalRecollida, preuTotalVenda, observacio, alumneActualitzat VALUES ('" & nouNom & "', " & nouCursRecollida & ", " & nouCursVenda & ", " & nouValorResguardRecollida & ", " & nouValorResguardVenda & ", '" & novaObservacio & "', CURRENT_TIMESTAMP)"

                'Cridem el mètode que ens permetrà fer l'actualització.
                executaInsercio(insert)

                'Actualitzem la Taula
                actualitzaTaula(darreraConsulta)

                'Reposem els controls
                desmarcaCheckBox()
                netejaDades()
            End If


        End If
    End Sub
End Class