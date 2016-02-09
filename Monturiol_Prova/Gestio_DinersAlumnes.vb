Imports MySql.Data.MySqlClient

Public Class Gestio_DinersAlumnes

    Dim Array1(36) As String
    Dim Array2(36) As String
    Dim cursAlumne As Integer
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged
        If RBt_1r.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 1r d'ESO:"
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 101 Or al.idCursRecollida = 102"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 101
            Dim cursAlumne2 As Integer = 102

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)

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
            End If
        End If
    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged
        If RBt_2n.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 2n d'ESO:"
            cursAlumne = 200
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 201 Or al.idCursRecollida = 202"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 201
            Dim cursAlumne2 As Integer = 202

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)
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
            End If
        End If
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged
        If RBt_3r.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 3r d'ESO:"
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 301 Or al.idCursRecollida = 302"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 301
            Dim cursAlumne2 As Integer = 302

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)
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
            End If
        End If
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        If RBt_4rt.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 4rt d'ESO:"
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 401 Or al.idCursRecollida = 402"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 401
            Dim cursAlumne2 As Integer = 402

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)
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
            End If
        End If
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        If RBt_5e.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 1r de BATX:"
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 501 Or al.idCursRecollida = 502"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 501
            Dim cursAlumne2 As Integer = 502

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)
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
            End If
        End If
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        If RBt_6e.Checked = True Then
            Etiqueta_Curs.Text = "Tria un Alumne de 2n de BATX:"
            Dim consultaAlumnes As String = "SELECT al.nomAlumne, al.idCursRecollida, al.preuTotalRecollida, al.PreuTotalVenda FROM Alumnes al WHERE al.idCursRecollida = 601 Or al.idCursRecollida = 602"
            _subLimpiaCombos()
            Dim cursAlumne1 As Integer = 601
            Dim cursAlumne2 As Integer = 602

            'Consulta los Alumnos para el Combo Box.
            consultaAlumnos(cursAlumne1, cursAlumne2)
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
            End If
        End If
    End Sub

    Public Sub _subLimpiaCombos()
        CBox_Alumnes.DataSource = Nothing
        CBox_Alumnes.ValueMember = Nothing
        CBox_Alumnes.DisplayMember = Nothing
        CBox_Alumnes.DropDownWidth = 1
        CBox_Alumnes.SelectedValue = Nothing
        CBox_Alumnes.Text = Nothing
    End Sub

    Private Sub Boto_Consulta_Alumne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Consulta_Alumne.Click
        '1r Pas: Cojer el ID de alumno seleccionado en el ComboBox
        Dim index As Integer = CBox_Alumnes.SelectedIndex
        Dim IDAlumne As Integer = Array1(index)
        'MsgBox("Valor de l'ID: " & IDAlumne)
        Dim ConsultaDadesAlumne As String = "SELECT * FROM Alumnes WHERE idAlumne = '" & IDAlumne & "'"
        'MsgBox("hola: " & ConsultaDadesAlumne)
        Dim myAdapter As New MySqlDataAdapter(ConsultaDadesAlumne, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub

    Private Sub Boto_Consulta_Grup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Consulta_Grup.Click

        'Declaras la variable de consulta
        Dim ConsultaDadesGrup As String = ""

        If CBox_Grups.SelectedItem = "1r d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 101 OR idCursRecollida = 102"
        ElseIf CBox_Grups.SelectedItem = "1r - A d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 101"
        ElseIf CBox_Grups.SelectedItem = "1r - B d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 102"
        ElseIf CBox_Grups.SelectedItem = "2n d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 201 OR idCursRecollida = 202"
        ElseIf CBox_Grups.SelectedItem = "2n - A d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 201"
        ElseIf CBox_Grups.SelectedItem = "2n - B d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 202"
        ElseIf CBox_Grups.SelectedItem = "3r d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 301 OR idCursRecollida = 302"
        ElseIf CBox_Grups.SelectedItem = "3r - A d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 301"
        ElseIf CBox_Grups.SelectedItem = "3r - B d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 302"
        ElseIf CBox_Grups.SelectedItem = "4rt d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 401 OR idCursRecollida = 402"
        ElseIf CBox_Grups.SelectedItem = "4rt - A d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 401"
        ElseIf CBox_Grups.SelectedItem = "4rt - B d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 402"
        ElseIf CBox_Grups.SelectedItem = "4rt - C d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 403"
        ElseIf CBox_Grups.SelectedItem = "1r de BATX" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 501 OR idCursRecollida = 502"
        ElseIf CBox_Grups.SelectedItem = "1r - A de BATX" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 501"
        ElseIf CBox_Grups.SelectedItem = "1r - B d'ESO" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 502"
        ElseIf CBox_Grups.SelectedItem = "2n de BATX" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 601 OR idCursRecollida = 602"
        ElseIf CBox_Grups.SelectedItem = "2n - A de BATX" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 601"
        ElseIf CBox_Grups.SelectedItem = "2n - B de BATX" Then
            ConsultaDadesGrup = "SELECT * FROM Alumnes WHERE idCursRecollida = 602"
        End If
        Dim index As String = CBox_Grups.SelectedIndex
        Dim IDCursRecollida As String = Array2(index)
        Dim myAdapter As New MySqlDataAdapter(ConsultaDadesGrup, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub

    Private Sub consultaAlumnos(ByVal idCurs, ByVal idCurs2)
        Dim consultaLlistaAlumnes As String = "SELECT idAlumne, nomAlumne FROM Alumnes WHERE idCursRecollida = " & idCurs & " OR idCursRecollida = " & idCurs2 & ""

        'Executem la consulta
        Dim myAdapter As New MySqlDataAdapter(consultaLlistaAlumnes, myConnection)
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        'Si la consulta tiene datos
        If mydatatable.Rows.Count > 0 Then
            CBox_Alumnes.DataSource = mydatatable
            CBox_Alumnes.ValueMember = "nomAlumne"
            Dim final As Integer = mydatatable.Rows.Count
            For iterador As Integer = 0 To final - 1   '35 max alumnos
                Dim idAlumne, nomAlumne As String
                idAlumne = mydatatable.Rows(iterador).Item("idAlumne")
                nomAlumne = mydatatable.Rows(iterador).Item("nomAlumne")
                Array1(iterador) = idAlumne
                Array2(iterador) = nomAlumne
            Next
        End If
    End Sub
End Class