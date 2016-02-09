Imports MySql.Data.MySqlClient
Public Class Recollida_1r

    'Declarem 6 variables de Llibres, que emmagatemaràn l'ID de DadesLlibre. A 1r d'ESO en necessitem 6!!
    Dim Llibre0 As String
    Dim Llibre1 As String
    Dim Llibre2 As String
    Dim Llibre3 As String
    Dim Llibre4 As String
    Dim Llibre5 As String

    Dim Assignatura0 As String
    Dim Assignatura1 As String
    Dim Assignatura2 As String
    Dim Assignatura3 As String
    Dim Assignatura4 As String
    Dim Assignatura5 As String

    'Declarem 1 variable d'Alumne, que desarà l'ID de l'Alumne.
    Dim idAlumne As String

    'Dades per a la connexió del comboBox amb el MySQL
    Public _dtsComboBox As New DataSet

    'Declarem un parell d'Arrays
    Dim Array1(36) As String
    Dim Array2(36) As String


    'Al carregar el formulari, caldrà accedir a la Base de Dades per precarregar les dades.
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    Private Sub _1r_Recollida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtB_Data.Text = Date.Now.Date
        TxtBox_Data_Inf.Text = Date.Now.Date
        
        'Dim consultaLlibres As String = "select * from dadesllibre where idCursLlibre = 100"
        Dim consultaLlibres As String = "SELECT dataL.idDadesLlibre, dataL.idAssignatura, dataL.titolLlibre, dataL.subtitolLlibre, ed.nomEditorial, dataL.pvpRecollida FROM DadesLlibre dataL INNER JOIN Editorials ed ON dataL.idEditorial = ed.idEditorial WHERE dataL.idCursLlibre = 100 And dataL.llibreActiu = True"
        Dim myAdapter As New MySqlDataAdapter(consultaLlibres, myConnection)
        Dim mydatatable As New DataTable


        myAdapter.Fill(mydatatable)

        If mydatatable.Rows.Count > 0 Then
            Llibre0 = mydatatable.Rows(0).Item("idDadesLlibre")
            Assignatura0 = mydatatable.Rows(0).Item("idAssignatura")
            TxtB_Llibre1S.Text = mydatatable.Rows(0).Item("titolLlibre") & ", " & mydatatable.Rows(0).Item("subtitolLlibre")
            TxtB_Editorial1S.Text = mydatatable.Rows(0).Item("nomEditorial")
            TxtB_PVP_1.Text = mydatatable.Rows(0).Item("pvpRecollida")

            Llibre1 = mydatatable.Rows(1).Item("idDadesLlibre")
            Assignatura1 = mydatatable.Rows(1).Item("idAssignatura")
            TxtB_Llibre2S.Text = mydatatable.Rows(1).Item("titolLlibre") & ", " & mydatatable.Rows(1).Item("subtitolLlibre")
            TxtB_Editorial2S.Text = mydatatable.Rows(1).Item("nomEditorial")
            TxtB_PVP_2.Text = mydatatable.Rows(1).Item("pvpRecollida")

            Llibre2 = mydatatable.Rows(2).Item("idDadesLlibre")
            Assignatura2 = mydatatable.Rows(2).Item("idAssignatura")
            TxtB_Llibre3S.Text = mydatatable.Rows(2).Item("titolLlibre") & ", " & mydatatable.Rows(2).Item("subtitolLlibre")
            TxtB_Editorial3S.Text = mydatatable.Rows(2).Item("nomEditorial")
            TxtB_PVP_3.Text = mydatatable.Rows(2).Item("pvpRecollida")

            Llibre3 = mydatatable.Rows(3).Item("idDadesLlibre")
            Assignatura3 = mydatatable.Rows(3).Item("idAssignatura")
            TxtB_Llibre4S.Text = mydatatable.Rows(3).Item("titolLlibre") & ", " & mydatatable.Rows(3).Item("subtitolLlibre")
            TxtB_Editorial4S.Text = mydatatable.Rows(3).Item("nomEditorial")
            TxtB_PVP_4.Text = mydatatable.Rows(3).Item("pvpRecollida")

            Llibre4 = mydatatable.Rows(4).Item("idDadesLlibre")
            Assignatura4 = mydatatable.Rows(4).Item("idAssignatura")
            TxtB_Llibre5S.Text = mydatatable.Rows(4).Item("titolLlibre") & ", " & mydatatable.Rows(4).Item("subtitolLlibre")
            TxtB_Editorial5S.Text = mydatatable.Rows(4).Item("nomEditorial")
            TxtB_PVP_5.Text = mydatatable.Rows(4).Item("pvpRecollida")

            Llibre5 = mydatatable.Rows(5).Item("idDadesLlibre")
            Assignatura5 = mydatatable.Rows(5).Item("idAssignatura")
            TxtB_Llibre6S.Text = mydatatable.Rows(5).Item("titolLlibre") & ", " & mydatatable.Rows(5).Item("subtitolLlibre")
            TxtB_Editorial6S.Text = mydatatable.Rows(5).Item("nomEditorial")
            TxtB_PVP_6.Text = mydatatable.Rows(5).Item("pvpRecollida")
        End If

        'Alhora cal que les dades es copiïn a la part inferior
        TxtB_Llibre1I.Text = TxtB_Llibre1S.Text
        TxtB_Llibre2I.Text = TxtB_Llibre2S.Text
        TxtB_Llibre3I.Text = TxtB_Llibre3S.Text
        TxtB_Llibre4I.Text = TxtB_Llibre4S.Text
        TxtB_Llibre5I.Text = TxtB_Llibre5S.Text
        TxtB_Llibre6I.Text = TxtB_Llibre6S.Text

        TxtB_Editorial1I.Text = TxtB_Editorial1S.Text
        TxtB_Editorial2I.Text = TxtB_Editorial2S.Text
        TxtB_Editorial3I.Text = TxtB_Editorial3S.Text
        TxtB_Editorial4I.Text = TxtB_Editorial4S.Text
        TxtB_Editorial5I.Text = TxtB_Editorial5S.Text
        TxtB_Editorial6I.Text = TxtB_Editorial6S.Text

        TxtB_PVP_1I.Text = TxtB_PVP_1.Text
        TxtB_PVP_2I.Text = TxtB_PVP_2.Text
        TxtB_PVP_3I.Text = TxtB_PVP_3.Text
        TxtB_PVP_4I.Text = TxtB_PVP_4.Text
        TxtB_PVP_5I.Text = TxtB_PVP_5.Text
        TxtB_PVP_6I.Text = TxtB_PVP_6.Text

        'Caldrà accedir a la Base de Dades per obtenir els alumnes del grup
        Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne FROM Alumnes al WHERE al.idCursRecollida = 101 Or al.idCursRecollida = 102"

        'Segon Adaptador per als Alumnes
        Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)

        'Fem una taula virtual
        Dim mydatatable2 As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapter2.Fill(mydatatable2)

        'Ens assegurem que hi ha dades
        If mydatatable2.Rows.Count > 0 Then
            ComboBox1.DataSource = mydatatable2
            ComboBox1.ValueMember = "nomAlumne"

            Dim final As Integer = mydatatable2.Rows.Count

            'Dim iterador As Integer = 0
            'Fem una iteració de fins a 35 llocs 'caldria comptar abans quants alumnes hi ha....
            For iterador As Integer = 0 To final - 1 'mydatatable.Rows.Count

                Dim provaID, provaNom As String

                idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                provaID = mydatatable2.Rows(iterador).Item("idAlumne")
                provaNom = mydatatable2.Rows(iterador).Item("nomAlumne")
                MsgBox("Iterador: " & iterador & "Valor de l'ID de l'Alumne: " & provaID & "-" & provaNom)
                Array1(iterador) = provaID
                Array2(iterador) = provaNom

            Next
        End If

    End Sub

  
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Inserim el nom al Text Box
        TxtB_NomI.Text = ComboBox1.Text

        'Desmarquem el checkBox
        ChkB_Llibre1S.Checked = False
        ChkB_Llibre2S.Checked = False
        ChkB_Llibre3S.Checked = False
        ChkB_Llibre4S.Checked = False
        ChkB_Llibre5S.Checked = False
        ChkB_Llibre6S.Checked = False

        'Esborrem els números de llibre
        Num_Llibre1S.Text = ""
        Num_Llibre2S.Text = ""
        Num_Llibre3S.Text = ""
        Num_Llibre4S.Text = ""
        Num_Llibre5S.Text = ""
        Num_Llibre6S.Text = ""



    End Sub

    Private Sub ChkB_Llibre1S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre1S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_1.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre1S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre1I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick1.Visible = True

            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_1.Text = Preu                    'Mostrem el preu
            TxtB_Total_21.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre1S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre1I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick1.Visible = False

            PreuFinal = TxtB_Total_1.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_1.Text = Preu                    'Mostrel el preu
            TxtB_Total_21.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub

    Private Sub ChkB_Llibre2S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre2S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_2.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre2S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre2I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick2.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_2.Text = Preu                    'Mostrem el preu
            TxtB_Total_22.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre2S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre2I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick2.Visible = False
            PreuFinal = TxtB_Total_2.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_2.Text = Preu                    'Mostrel el preu
            TxtB_Total_22.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub


    Private Sub ChkB_Llibre3S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre3S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_3.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre3S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre3I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick3.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_3.Text = Preu                    'Mostrem el preu
            TxtB_Total_23.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre3S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre3I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick3.Visible = False
            PreuFinal = TxtB_Total_3.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_3.Text = Preu                    'Mostrel el preu
            TxtB_Total_23.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub


    Private Sub ChkB_Llibre4S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre4S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_4.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre4S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre4I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick4.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_4.Text = Preu                    'Mostrem el preu
            TxtB_Total_24.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre4S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre4I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick4.Visible = False
            PreuFinal = TxtB_Total_4.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_4.Text = Preu                    'Mostrel el preu
            TxtB_Total_24.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub


    Private Sub ChkB_Llibre5S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre5S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_5.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre5S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre5I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick5.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_5.Text = Preu                    'Mostrem el preu
            TxtB_Total_25.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre5S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre5I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick5.Visible = False
            PreuFinal = TxtB_Total_5.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_5.Text = Preu                    'Mostrel el preu
            TxtB_Total_25.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub

    Private Sub ChkB_Llibre6S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre6S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_6.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre6S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre6I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick6.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_6.Text = Preu                    'Mostrem el preu
            TxtB_Total_26.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre6S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre6I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick6.Visible = False
            PreuFinal = TxtB_Total_6.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_6.Text = Preu                    'Mostrel el preu
            TxtB_Total_26.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub

    Private Sub ChkB_Llibre7S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre7S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_7.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre7S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            ChkB_Llibre7I.Checked = True                   'Marquem la casella del seu homònim inferior.
            Tick7.Visible = True
            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_7.Text = Preu                    'Mostrem el preu
            TxtB_Total_27.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre7S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            ChkB_Llibre7I.Checked = False                  'Desmarquem la casella del seu homònim inferior.
            Tick7.Visible = False
            PreuFinal = TxtB_Total_7.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_7.Text = Preu                    'Mostrel el preu
            TxtB_Total_27.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub

    'Mètode que ens serveix per establir el preu total dels llibres. 'Ha de passar 2 coses: 1- Preu de llibre, 2 - Si suma o resta
    Private Sub CalculaPreuTotal(ByVal PreuTotalLlibre As Double, ByVal operador As Boolean)
        'True = Suma / False = Resta
        Dim PreuFinal As Double

        PreuFinal = TxtB_PreuTotal.Text 'Obtenim el preu final general

        If (operador = True) Then   'Suma
            PreuFinal = PreuFinal + PreuTotalLlibre
        ElseIf (operador = False) Then  'Resta
            PreuFinal = PreuFinal - PreuTotalLlibre
        End If

        'Discriminem per a mostrar un preu final de 0 ben format
        If (PreuFinal > 0) Then
            TxtB_PreuTotal.Text = PreuFinal
            TxtB_PreuTotal_Inf.Text = PreuFinal
        Else
            TxtB_PreuTotal.Text = "0,00"
            TxtB_PreuTotal_Inf.Text = "0,00"
        End If
    End Sub

    Private Function CalculaPreuLlibre(ByVal PreuLlibre As Double) As Double
        Dim PreuMig As Double

        'Reduim el preu en un 50%
        PreuMig = PreuLlibre * 0.5 / 10
        'Arrodonim al decimal inferor.
        Dim theRounded = Math.Sign(PreuMig) * Math.Floor(Math.Abs(PreuMig) * 100) / 100.0
        'TxtB_Total_1.Text = theRounded
        'Recalculem el preu amb la reducció
        CalculaPreuLlibre = theRounded * 10
    End Function

    'FUNCIONS PER A IGUALAR EL NÚMERO DE AMUNT AMB EL DE LA CÒPIA.
    Private Sub Num_Llibre1S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre1S.TextChanged
        Num_Llibre1I.Text = Num_Llibre1S.Text
    End Sub

    Private Sub Num_Llibre2S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre2S.TextChanged
        Num_Llibre2I.Text = Num_Llibre2S.Text
    End Sub

    Private Sub Num_Llibre3S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre3S.TextChanged
        Num_Llibre3I.Text = Num_Llibre3S.Text
    End Sub

    Private Sub Num_Llibre4S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre4S.TextChanged
        Num_Llibre4I.Text = Num_Llibre4S.Text
    End Sub

    Private Sub Num_Llibre5S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre5S.TextChanged
        Num_Llibre5I.Text = Num_Llibre5S.Text
    End Sub

    Private Sub Num_Llibre6S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre6S.TextChanged
        Num_Llibre6I.Text = Num_Llibre6S.Text
    End Sub

    Private Sub Num_Llibre7S_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Llibre7S.TextChanged
        Num_Llibre7I.Text = Num_Llibre7S.Text
    End Sub

    'Mètode que ens servirà per validar les dades i imprimir.
    Private Sub ValidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidaToolStripMenuItem.Click

        Dim pas1 As Boolean = False
        Dim pas2 As Boolean = False

        'Pas 1: Validar que l'Alumne no ha portat cap dels llibres que demana entregar
        pas1 = comprovaLlibresNoPortats()

        'Primer control
        If pas1 = True Then

            'Pas 2: Validar que els llibres que vol portar no coincideixin en número amb algun altre que ja s'hagués portat.
            pas2 = comprovaNumeroLlibres()

            If pas2 = True Then
                'Un cop passades les validacions, cal entrar les dades a la Base de Dades!

                'Pas 3: Inserció de dades al proper procediment
                distribueixLlibres()

            End If

        End If

    End Sub

    'En aquest mètode comprovem que l'alumne especificat NO ha portat un llibre dels que estan marcats!
    Private Function comprovaLlibresNoPortats() As Boolean

        Dim index As Integer = ComboBox1.SelectedIndex  'Obtenir l'index de l'alumne triat de a partir del ComboBox
        Dim idAlumne As Integer = Array1(index)         'Triem l'ID de l'alumne que hi ha dins la posició del primer Array amb l'index
        Dim nomAlumne As String = Array2(index)         'Triem el nom de l'alumne que hi ha dins la posició del segon Array amb l'index
        Dim repetit As Boolean = False                  'Ens preveu si un llibre és repetit (True = Repetit / False = Vàlid)
        Dim resCon As Integer = 0                       'Ens desa el resultat de les consultes que provenen d'una funció.
        Dim consultaLlibreNoPortats As String           'Variable de la consulta, que varia en funció del check box.
        'MsgBox("ID triat: " & idAlumne & " Nom: " & nomAlumne) 'Finestra de control

        'L'estructura varia en funció dels check box marcats
        If ChkB_Llibre1S.Checked = True Then

            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre0 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre1S.Text & " ja ha estat entregat, desmarca'l!")
            End If

        End If

        If ChkB_Llibre2S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre1 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre2S.Text & " ja ha estat entregat, desmarca'l!")
            End If
        End If

        If ChkB_Llibre3S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre2 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre3S.Text & " ja ha estat entregat, desmarca'l!")
            End If
        End If

        If ChkB_Llibre4S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre3 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre4S.Text & " ja ha estat entregat, desmarca'l!")
            End If
        End If

        If ChkB_Llibre5S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre4 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre5S.Text & " ja ha estat entregat, desmarca'l!")
            End If
        End If

        If ChkB_Llibre6S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneRecollida Lar ON Lli.idLlibre = Lar.idLlibre INNER JOIN Alumnes Al ON Lar.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre5 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre6S.Text & " ja ha estat entregat, desmarca'l!")
            End If
        End If

        'Retornarem un 0 si els llibres que vol portar no els ha entregat.
        If repetit = True Then
            comprovaLlibresNoPortats = False    'NO ha passat els requisits
        Else
            comprovaLlibresNoPortats = True     'SI ha passat els requisits
        End If

    End Function

    'En aquest mètode comprovem que l'alumne especificat NO porta un llibre amb un mateix número que ja hagi estat entregat.
    Private Function comprovaNumeroLlibres() As Boolean

        'Obtenir l'index de l'alumne triat
        Dim index As Integer = ComboBox1.SelectedIndex  'Obtenir l'index de l'alumne triat de a partir del ComboBox
        Dim idAlumne As Integer = Array1(index)         'Triem l'ID de l'alumne que hi ha dins la posició del primer Array amb l'index
        Dim nomAlumne As String = Array2(index)         'Triem el nom de l'alumne que hi ha dins la posició del segon Array amb l'index

        Dim repetit As Boolean = False
        Dim resCon As Integer = 0       'Ens desa el resultat de les consultes que provenen d'una funció.
        'MsgBox("PAS 2: Verificació dels Número de Llibre - ID triat: " & idAlumne & " Nom: " & nomAlumne)

        Dim consultaLlibreNumero As String

        'L'estructura varia en funció dels check box marcats
        If ChkB_Llibre1S.Checked = True Then
            Dim numLlibre1 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre1S.Text = "" Then
                numLlibre1 = "SN"
            Else
                numLlibre1 = Num_Llibre1S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre0 & " AND Lli.numLlibre = '" & numLlibre1 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre1, resCon, TxtB_Llibre1S.Text, repetit)
            
            'MsgBox("Llibre: " & TxtB_Llibre1S.Text & " amb Número: " & numLlibre1)

        End If


        If ChkB_Llibre2S.Checked = True Then
            Dim numLlibre2 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre2S.Text = "" Then
                numLlibre2 = "SN"
            Else
                numLlibre2 = Num_Llibre2S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre1 & " AND Lli.numLlibre = '" & numLlibre2 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre2, resCon, TxtB_Llibre2S.Text, repetit)

        End If

        If ChkB_Llibre3S.Checked = True Then
            Dim numLlibre3 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre3S.Text = "" Then
                numLlibre3 = "SN"
            Else
                numLlibre3 = Num_Llibre3S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre2 & " AND Lli.numLlibre = '" & numLlibre3 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre3, resCon, TxtB_Llibre3S.Text, repetit)

        End If

        If ChkB_Llibre4S.Checked = True Then
            Dim numLlibre4 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre4S.Text = "" Then
                numLlibre4 = "SN"
            Else
                numLlibre4 = Num_Llibre4S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre3 & " AND Lli.numLlibre = '" & numLlibre4 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre4, resCon, TxtB_Llibre4S.Text, repetit)

        End If

        If ChkB_Llibre5S.Checked = True Then
            Dim numLlibre5 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre5S.Text = "" Then
                numLlibre5 = "SN"
            Else
                numLlibre5 = Num_Llibre5S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre4 & " AND Lli.numLlibre = '" & numLlibre5 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre5, resCon, TxtB_Llibre5S.Text, repetit)

        End If

        If ChkB_Llibre6S.Checked = True Then
            Dim numLlibre6 As String
            'Obtenim el Valor del Número del TextBox Corresponent a la fila del CHKBox1
            If Num_Llibre6S.Text = "" Then
                numLlibre6 = "SN"
            Else
                numLlibre6 = Num_Llibre6S.Text
            End If

            'Li definim la consulta
            consultaLlibreNumero = "Select Lli.idEstatLlibre FROM Llibres Lli INNER JOIN EstatLlibres Est ON Lli.idEstatLlibre = Est.idEstatLlibres WHERE Lli.idDadesLlibre = " & Llibre5 & " AND Lli.numLlibre = '" & numLlibre6 & "'"

            'Executem la Funció de Consulta
            resCon = executaConsultaNumeroLlibre(consultaLlibreNumero)
            'MsgBox("Valor de resCon: " & resCon)

            'Fem que ens validi el missatge
            repetit = mostraMissatgeNumLlibre(numLlibre6, resCon, TxtB_Llibre6S.Text, repetit)

        End If

        'Retornarme un 0 si els llibres que vol portar no els ha entregat.
        If repetit = True Then
            comprovaNumeroLlibres = False    'NO ha passat els requisits
        Else
            comprovaNumeroLlibres = True     'SI ha passat els requisits
        End If

    End Function

    'Mètode que distribueix les tasques per a la inserció de llibres a la Base de Dades.
    Private Function distribueixLlibres() As Boolean

        'Obtenir l'index de l'alumne triat
        Dim index As Integer = ComboBox1.SelectedIndex
        Dim idAlumne As Integer = Array1(index)
        Dim nomAlumne As String = Array2(index)

        Dim repetit As Boolean = False
        Dim resCon As Integer = 0       'Ens desa el resultat de les consultes que provenen d'una funció.
        'MsgBox("PAS 3: Inserir Llibres - ID triat: " & idAlumne & " Nom: " & nomAlumne)

        'Variables en ús.
        Dim existeix As Boolean

        'Dim consultaLlibreNumero As String

        'L'estructura varia en funció dels check box marcats
        If ChkB_Llibre1S.Checked = True Then

            Dim numLlibre1 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre1S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre1 = assignaNumero(Llibre0)
            Else
                numLlibre1 = Num_Llibre1S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre0 & " AND Lli.numLlibre = " & numLlibre1 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre1 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre0 & " AND numLlibre = " & numLlibre1 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre0, numLlibre1)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre0 & ", " & numLlibre1 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre0, numLlibre1)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre0, numLlibre1)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If


        If ChkB_Llibre2S.Checked = True Then
            Dim numLlibre2 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre2S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre2 = assignaNumero(Llibre1)
            Else
                numLlibre2 = Num_Llibre2S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre1 & " AND Lli.numLlibre = " & numLlibre2 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre1 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre1 & " AND numLlibre = " & numLlibre2 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre1, numLlibre2)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre1 & ", " & numLlibre2 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre1, numLlibre2)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre1, numLlibre2)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If

        If ChkB_Llibre3S.Checked = True Then
            Dim numLlibre3 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre3S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre3 = assignaNumero(Llibre2)
            Else
                numLlibre3 = Num_Llibre3S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre2 & " AND Lli.numLlibre = " & numLlibre3 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre1 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre2 & " AND numLlibre = " & numLlibre3 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre2, numLlibre3)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre2 & ", " & numLlibre3 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre2, numLlibre3)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre2, numLlibre3)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If

        If ChkB_Llibre4S.Checked = True Then
            Dim numLlibre4 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre4S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre4 = assignaNumero(Llibre3)
            Else
                numLlibre4 = Num_Llibre4S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre3 & " AND Lli.numLlibre = " & numLlibre4 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre1 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre3 & " AND numLlibre = " & numLlibre4 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre3, numLlibre4)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre3 & ", " & numLlibre4 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre3, numLlibre4)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre3, numLlibre4)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If

        If ChkB_Llibre5S.Checked = True Then
            Dim numLlibre5 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre5S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre5 = assignaNumero(Llibre4)
            Else
                numLlibre5 = Num_Llibre5S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre4 & " AND Lli.numLlibre = " & numLlibre5 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre5 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre4 & " AND numLlibre = " & numLlibre5 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre4, numLlibre5)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre4 & ", " & numLlibre5 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre4, numLlibre5)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre4, numLlibre5)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If

        If ChkB_Llibre6S.Checked = True Then
            Dim numLlibre6 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre6S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre6 = assignaNumero(Llibre5)
            Else
                numLlibre6 = Num_Llibre6S.Text
            End If

            'Cal comprovar que el llibre existeix amb una consulta
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre5 & " AND Lli.numLlibre = " & numLlibre6 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)

            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre6 & ": " & existeix)

            'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim consultaIDLlibre As Integer
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 2, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre5 & " AND numLlibre = " & numLlibre6 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre5, numLlibre6)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre5 & ", " & numLlibre6 & ", 2, CURRENT_TIMESTAMP)"

                'Cridem al mètode per a fer l'Insert
                ultimID = executaInsercioLlibre(InsertDadesLlibre, Llibre5, numLlibre6)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre5, numLlibre6)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            End If

            If inserirLlibre = True Then
                'Cas que ja disposem de les dues dades necessàries (ID de l'Alumne i ID del llibre) a inserir, continuem.
                Dim resExecutaAlumneLlibre As Boolean = False
                'Cridem al mètode per a fer la inserció de l'ID de l'alumne amb l'ID del Llibre
                resExecutaAlumneLlibre = insereixRegistreLlibreAlumne(idAlumne, consultaIDLlibre)

                'PER DETERMINAR, PODEM FER UNA CONSULTA PER VERIFICAR QUE S'HA INSERIT CORRECTAMENT.

                'MsgBox("El Llibre s'ha inserit correctament! ^^")
            End If

        End If

        'Retornarme un 0 si els llibres que vol portar no els ha entregat.
        If repetit = True Then
            distribueixLlibres = False    'NO ha passat els requisits
        Else
            distribueixLlibres = True     'SI ha passat els requisits
        End If
    End Function

    'Mètode que comprova que un Llibre que es vol entregar existeix a la Base de Dades o no.
    Private Function consultaExistencia(ByVal consultaExistenciaLlibre As String) As Boolean

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consultaExistenciaLlibre, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim resultat As Integer 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("res") 'Assignem a la variable resultat el que es contingui.
        End If

        'En funció del resultat, retornem un número / 1 = Repetit - 0 = No portat. /
        If resultat = 1 Then
            consultaExistencia = True
        Else
            consultaExistencia = False
        End If


    End Function

    'Mètode per a fer la modificació de les dades d'un llibre existent durant l'entrega de llibres
    Private Sub executaModificacioLlibre(ByVal UpdateDadesLlibre)
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(UpdateDadesLlibre, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem


    End Sub

    'Mètode per a fer la inserció de les dades d'un Llibre NO existent durant l'entrega de llibres
    Private Function executaInsercioLlibre(ByVal consultaInsert As String, ByVal Llibre As Integer, ByVal numLlibre As Integer) As Integer
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consultaInsert, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem

        executaInsercioLlibre = 0

    End Function

    'Mètode per a comrpovar que la inserció s'ha realitzat correctament. Alhora, demanem l'id del Llibre
    Private Function comprovaModificacioLlibre(ByVal Llibre, ByVal numLlibre) As Integer
        'MsgBox("Inserint Llibre a la relació")
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim consultaUpdateLlibre As String = "SELECT idLlibre, idEstatLlibre FROM Llibres WHERE idDadesLlibre = " & Llibre & " AND numLlibre = " & numLlibre & ""

        Dim myAdapter As New MySqlDataAdapter(consultaUpdateLlibre, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim idLlibre As String = "" 'Ens desa el ID del llibre, extret com a resultat de la consulta
        Dim idEstatLlibre As Integer

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            idLlibre = mydatatable.Rows(0).Item("idLlibre") 'Assignem a la variable resultat el que es contingui.
            idEstatLlibre = mydatatable.Rows(0).Item("idEstatLlibre")
        End If

        'En funció del resultat
        If idEstatLlibre = 2 Then
            comprovaModificacioLlibre = idLlibre
        Else
            comprovaModificacioLlibre = 0
        End If
    End Function

    'Mètode que ens insereix el registre de relació de recollida entre un Alumne i un Llibre.
    Private Function insereixRegistreLlibreAlumne(ByVal idAlumne, ByVal IDLlibre) As Boolean
        'MsgBox("ID ALUMNE: " & idAlumne & " - ID LLIBRE " & IDLlibre) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        'Sentència de la consulta a la Base de Dades.
        Dim consultaInserixLlibreAlumne As String = "INSERT INTO llibreAlumneRecollida VALUES(" & idAlumne & "," & IDLlibre & " , CURRENT_TIMESTAMP)"
        Dim myAdapter As New MySqlDataAdapter(consultaInserixLlibreAlumne, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        insereixRegistreLlibreAlumne = True

    End Function

    'Mètode que mostra un missatge d'error en funció de l'estat del Llibre.
    Private Function mostraMissatgeNumLlibre(ByVal numLlibre As String, ByVal resCon As Integer, ByVal nomLlibre As String, ByVal repetit As Boolean) As Boolean

        If resCon = 2 Then
            repetit = True
            MsgBox("El llibre de " & nomLlibre & " amb Número: " & numLlibre & " ja ha estat entregat per un altre alumne, desmarca'l!", MsgBoxStyle.Critical)
        ElseIf resCon = 3 Then
            repetit = True
            MsgBox("El llibre de " & nomLlibre & " amb Número: " & numLlibre & " està adscrit a la reserva de l'any anterior, desmarca'l!", MsgBoxStyle.Critical)
        ElseIf resCon = 4 Then
            repetit = True
            MsgBox("El llibre de " & nomLlibre & " amb Número: " & numLlibre & " ha estat cedit a l'alumne i no es pot cobrar per aquest llibre, desmarca'l!", MsgBoxStyle.Critical)
        ElseIf resCon = 6 Then
            repetit = True
            MsgBox("El llibre de " & nomLlibre & " amb Número: " & numLlibre & " ha estat RETIRAT, desmarca'l!", MsgBoxStyle.Critical)
        End If

        mostraMissatgeNumLlibre = repetit

    End Function

    'Mètode que ens executa la consulta i ens torna un 1 o un 0 depenent del resultat del COUNT a la BBDD
    Private Function executaConsultaLlibres(ByVal consultaLlibreNoPortats) As Integer

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consultaLlibreNoPortats, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim resultat As Integer 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("res") 'Assignem a la variable resultat el que es contingui.
        End If

        'En funció del resultat, retornem un número / 1 = Repetit - 0 = No portat. /
        If resultat = 1 Then
            executaConsultaLlibres = 1
        Else
            executaConsultaLlibres = 0
        End If

    End Function

    'Mètode que ens executa la consulta per determinar l'estat d'un llibre en concret.
    Private Function executaConsultaNumeroLlibre(ByVal consultaLlibreNumero) As Integer

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consultaLlibreNumero, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim resultat As Integer 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("idEstatLlibre") 'Assignem a la variable resultat el que es contingui.
        End If
        'MsgBox("Resultat: " & resultat)
        'En funció del resultat, retornem un número 
        If resultat = 1 Or resultat = 5 Then
            executaConsultaNumeroLlibre = resultat
        Else
            executaConsultaNumeroLlibre = resultat
        End If

    End Function

    'Mètode que ens permetrà fer l'assignació d'un número de llibre en un que no en disposi!
    Private Function assignaNumero(ByVal idDadesLlibre) As Integer
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter("SELECT numDisp FROM numProv WHERE idCursLlibre = " & idDadesLlibre & "", myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim resultat As Integer 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("numDisp") 'Assignem a la variable resultat el que es contingui.
        End If
        'MsgBox("Resultat de demanar un número: " & resultat)
        'En funció del resultat, retornem un número / 1 = Repetit - 0 = No portat. /

        Dim reposaNumero As Integer = resultat + 1

        Dim consulta As String = "UPDATE numProv SET numDisp = " & reposaNumero & " WHERE idCursLlibre = " & idDadesLlibre & ""

        'MsgBox(consulta)
        'Inserim el número incrementat a la Base de Dades
        Dim myAdapter2 As New MySqlDataAdapter(consulta, myConnection)
        Dim mydatatable2 As New DataTable
        myAdapter2.Fill(mydatatable2)
        assignaNumero = resultat
    End Function

    'Mètode per a fer la impressió del Windows Form
    Private Sub imprimir()
        Try
            Cursor.Current = Cursors.WaitCursor
            With Me.PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPreview
                .PrinterSettings.DefaultPageSettings.Landscape = False
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End With
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error a l'imprimir")
        End Try
    End Sub

    Private Sub ImprimeixLActualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimeixLActualToolStripMenuItem.Click
        imprimir()

    End Sub

End Class