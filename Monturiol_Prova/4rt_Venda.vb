Imports MySql.Data.MySqlClient

Public Class _4rt_Venda
    'Declarem 6 variables de Llibres i Assignatures per a cada Llibre
    Dim Llibre0 As String
    Dim Llibre1 As String
    Dim Llibre2 As String
    Dim Llibre3 As String


    Dim Assignatura0 As String
    Dim Assignatura1 As String
    Dim Assignatura2 As String
    Dim Assignatura3 As String
    


    'Declarem 1 variable d'Alumne, que desarà l'ID de l'Alumne.
    Dim idAlumne As String

    'Dades per a la connexió del comboBox amb el MySQL
    Public _dtsComboBox As New DataSet

    'Declarem un parell d'Arrays
    Dim ArrayIDAlumnes(36) As String
    Dim ArrayNomAlumnes(36) As String
    Dim ArrayComprovantRec(36) As String

    'Al carregar el formulari, caldrà accedir a la Base de Dades per precarregar les dades.
    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")

    Private Sub _4rt_Venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Mostrem la Data Actual!
        TxtB_Data.Text = Date.Now.Date
        TxtBox_Data_Inf.Text = Date.Now.Date

        'Consultem els llibres que s'han de vendre a 3r d'ESO
        Dim consultaLlibres As String = "SELECT dataL.idDadesLlibre, dataL.idAssignatura, dataL.titolLlibre, dataL.subtitolLlibre, ed.nomEditorial, dataL.pvpVenda FROM DadesLlibre dataL INNER JOIN Editorials ed ON dataL.idEditorial = ed.idEditorial WHERE dataL.idCursLlibre = 400 And dataL.llibreActiu = True"
        Dim myAdapter As New MySqlDataAdapter(consultaLlibres, myConnection)
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        'Emplenem la Graella
        If mydatatable.Rows.Count > 0 Then
            Llibre0 = mydatatable.Rows(0).Item("idDadesLlibre")
            Assignatura0 = mydatatable.Rows(0).Item("idAssignatura")
            TxtB_Llibre1S.Text = mydatatable.Rows(0).Item("titolLlibre") & ", " & mydatatable.Rows(0).Item("subtitolLlibre")
            TxtB_Editorial1S.Text = mydatatable.Rows(0).Item("nomEditorial")
            TxtB_PVP_1.Text = mydatatable.Rows(0).Item("pvpVenda")

            Llibre1 = mydatatable.Rows(1).Item("idDadesLlibre")
            Assignatura1 = mydatatable.Rows(1).Item("idAssignatura")
            TxtB_Llibre2S.Text = mydatatable.Rows(1).Item("titolLlibre") & ", " & mydatatable.Rows(1).Item("subtitolLlibre")
            TxtB_Editorial2S.Text = mydatatable.Rows(1).Item("nomEditorial")
            TxtB_PVP_2.Text = mydatatable.Rows(1).Item("pvpVenda")

            Llibre2 = mydatatable.Rows(2).Item("idDadesLlibre")
            Assignatura2 = mydatatable.Rows(2).Item("idAssignatura")
            TxtB_Llibre3S.Text = mydatatable.Rows(2).Item("titolLlibre") & ", " & mydatatable.Rows(2).Item("subtitolLlibre")
            TxtB_Editorial3S.Text = mydatatable.Rows(2).Item("nomEditorial")
            TxtB_PVP_3.Text = mydatatable.Rows(2).Item("pvpVenda")

            Llibre3 = mydatatable.Rows(3).Item("idDadesLlibre")
            Assignatura3 = mydatatable.Rows(3).Item("idAssignatura")
            TxtB_Llibre4S.Text = mydatatable.Rows(3).Item("titolLlibre") & ", " & mydatatable.Rows(3).Item("subtitolLlibre")
            TxtB_Editorial4S.Text = mydatatable.Rows(3).Item("nomEditorial")
            TxtB_PVP_4.Text = mydatatable.Rows(3).Item("pvpVenda")


        End If

        'Alhora cal que les dades es copiïn a la part inferior
        TxtB_Llibre1I.Text = TxtB_Llibre1S.Text
        TxtB_Llibre2I.Text = TxtB_Llibre2S.Text
        TxtB_Llibre3I.Text = TxtB_Llibre3S.Text
        TxtB_Llibre4I.Text = TxtB_Llibre4S.Text
        TxtB_Llibre5I.Text = TxtB_Llibre5S.Text



        TxtB_Editorial1I.Text = TxtB_Editorial1S.Text
        TxtB_Editorial2I.Text = TxtB_Editorial2S.Text
        TxtB_Editorial3I.Text = TxtB_Editorial3S.Text
        TxtB_Editorial4I.Text = TxtB_Editorial4S.Text



        TxtB_PVP_1I.Text = TxtB_PVP_1.Text
        TxtB_PVP_2I.Text = TxtB_PVP_2.Text
        TxtB_PVP_3I.Text = TxtB_PVP_3.Text
        TxtB_PVP_4I.Text = TxtB_PVP_4.Text


        'Caldrà accedir a la Base de Dades per obtenir els alumnes del grup
        Dim consultaAlumnes As String = "SELECT al.idAlumne, al.nomAlumne, al.preuTotalRecollida FROM Alumnes al WHERE al.idCursVenda = 401 Or al.idCursVenda = 402 Or al.idCursVenda = 403"

        'Segon Adaptador per als Alumnes
        Dim myAdapter2 As New MySqlDataAdapter(consultaAlumnes, myConnection)
        Dim mydatatable2 As New DataTable
        myAdapter2.Fill(mydatatable2)

        'Ens assegurem que hi ha dades
        If mydatatable2.Rows.Count > 0 Then
            ComboBox1.DataSource = mydatatable2
            ComboBox1.ValueMember = "nomAlumne"

            Dim final As Integer = mydatatable2.Rows.Count
            'MsgBox("Valor de final: " & final)
            'Fem una iteració de fins a 35 llocs 'caldria comptar abans quants alumnes hi ha....
            For iterador As Integer = 0 To final - 1 'mydatatable.Rows.Count

                Dim provaID, provaNom, preuRec As String
                idAlumne = mydatatable2.Rows(iterador).Item("idAlumne")
                provaID = mydatatable2.Rows(iterador).Item("idAlumne")
                provaNom = mydatatable2.Rows(iterador).Item("nomAlumne")
                preuRec = mydatatable2.Rows(iterador).Item("PreuTotalRecollida")
                'MsgBox("Iterador: " & iterador & "Valor de l'ID de l'Alumne: " & provaID & "-" & provaNom)
                ArrayIDAlumnes(iterador) = provaID
                ArrayNomAlumnes(iterador) = provaNom
                ArrayComprovantRec(iterador) = preuRec
            Next

        End If

        'Posem els camps del Resguard de Recollida
        TxtB_ResguardRecollida_Sup.Text = ArrayComprovantRec(ComboBox1.SelectedIndex)
        'MsgBox(ArrayComprovantRec(ComboBox1.SelectedIndex))

        ChkB_Llibre5S.Checked = True    'Marquem el Check box
    End Sub

    'Cada cop que canviem el que hi ha en un ComboBox.
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Inserim el nom al Text Box
        TxtB_NomI.Text = ComboBox1.Text

        'Desmarquem el checkBox
        ChkB_Llibre1S.Checked = False
        ChkB_Llibre2S.Checked = False
        ChkB_Llibre3S.Checked = False
        ChkB_Llibre4S.Checked = False
        ChkB_Llibre5S.Checked = True



        'Esborrem els números de llibre
        Num_Llibre1S.Text = ""
        Num_Llibre2S.Text = ""
        Num_Llibre3S.Text = ""
        Num_Llibre4S.Text = ""




        'Esborrem els camps propietaris de resguard i efectius
        TxtB_Efectiu_Sup.Text = "0,00"
        TxtB_ResguardRecollida_Sup.Text = "0,00"
        TxtB_PreuTotalPagar_Sup.Text = "0,00"

        'Posem els camps del Resguard de Recollida
        TxtB_ResguardRecollida_Sup.Text = ArrayComprovantRec(ComboBox1.SelectedIndex)
        'MsgBox(ArrayComprovantRec(ComboBox1.SelectedIndex))

    End Sub

    'Èvents i Accions al triar un llibre, aquest activa el preu i les sumes totals (en base a preu de BBDD).
    Private Sub ChkB_Llibre1S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre1S.CheckedChanged
        Dim LlibresTotals As Integer
        Dim PreuLlibre As Double
        Dim PreuFinal As Double
        Dim Preu As String

        LlibresTotals = TxtB_TotalLlibres.Text          'Obtenim el número de llibres totals
        PreuLlibre = TxtB_PVP_1.Text                    'Obtenim el preu del llibre

        If (ChkB_Llibre1S.Checked = True) Then
            LlibresTotals = LlibresTotals + 1           'Sumem en 1 els llibres totals

            Tick1.Visible = True                        'Marquem la casella del seu homònim inferior.

            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_1.Text = Preu                    'Mostrem el preu
            TxtB_Total_21.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre1S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            Tick1.Visible = False                       'Desmarquem la casella del seu homònim inferior.

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

            Tick2.Visible = True                        'Marquem la casella del seu homònim inferior.

            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_2.Text = Preu                    'Mostrem el preu
            TxtB_Total_22.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre2S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            Tick2.Visible = False                       'Desmarquem la casella del seu homònim inferior.

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

            Tick3.Visible = True                        'Marquem la casella del seu homònim inferior.

            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_3.Text = Preu                    'Mostrem el preu
            TxtB_Total_23.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre3S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            Tick3.Visible = False                       'Desmarquem la casella del seu homònim inferior.

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

            Tick4.Visible = True                        'Marquem la casella del seu homònim inferior.

            PreuFinal = CalculaPreuLlibre(PreuLlibre)   'Calculem el preu final rebaixat del llibre

            Preu = PreuFinal.ToString                   'Passem el preu final a String

            TxtB_Total_4.Text = Preu                    'Mostrem el preu
            TxtB_Total_24.Text = Preu

            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre4S.Checked = False) Then
            LlibresTotals = LlibresTotals - 1           'Restem en 1 els llibres totals

            Tick4.Visible = False                       'Desmarquem la casella del seu homònim inferior.

            PreuFinal = TxtB_Total_4.Text               'Recalculem el preu general

            CalculaPreuTotal(PreuFinal, False)          'Calculem el preu general

            Preu = "0,00"                               'Posem el preu a 0,00

            TxtB_Total_4.Text = Preu                    'Mostrel el preu
            TxtB_Total_24.Text = Preu

        End If
        TxtB_TotalLlibres.Text = LlibresTotals          'Mostrem el preu total
        TxtB_TotalLlibres_Inf.Text = LlibresTotals
    End Sub

    'Aquest mètode va diferent, doncs no es pot deshabilitar, i el resultat total és el 50%
    Private Sub ChkB_Llibre5S_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_Llibre5S.CheckedChanged
        
        Dim PreuFinal As Double

        If (ChkB_Llibre5S.Checked = True) Then

            ChkB_Llibre5S.Checked = True
            Tick5.Visible = True                        'Marquem la casella del seu homònim inferior.

            
            PreuFinal = 12
            CalculaPreuTotal(PreuFinal, True)           'Calculem el preu general

        ElseIf (ChkB_Llibre5S.Checked = False) Then
            

        End If
        
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

        'Arrodonim al decimal superior.
        Dim theRounded = Math.Ceiling(PreuMig * 100D) / 10D

        'Recalculem el preu amb la reducció
        CalculaPreuLlibre = theRounded
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

    

    Private Sub TxtB_ResguardRecollida_Sup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtB_ResguardRecollida_Sup.TextChanged
        TxtB_ResguardRecollida_Inf.Text = TxtB_ResguardRecollida_Sup.Text
    End Sub

    Private Sub TxtB_Efectiu_Sup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtB_Efectiu_Sup.TextChanged
        TxtB_Efectiu_Inf.Text = TxtB_Efectiu_Sup.Text
    End Sub

    Private Sub TxtB_PreuTotalPagar_Sup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtB_PreuTotalPagar_Sup.TextChanged
        TxtB_PreuTotalPagar_Inf.Text = TxtB_PreuTotalPagar_Sup.Text
    End Sub

    'Event que ens permetrà que els TextBox d'inserció de preus manuals NO disposin de caràcters simples.   <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    'Mètode que ens servirà per validar les dades i imprimir.
    Private Sub ValidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidaToolStripMenuItem.Click

        Dim pas1 As Boolean = False
        Dim pas2 As Boolean = False

        'Pas 1: Validar que l'Alumne no vol comprar cap dels llibres que demana comprar.
        pas1 = comprovaLlibresVenutsAlumne()

        'Primer control, si és True vol dir que NO ha comprat un llibre de la mateixa assignatura que vol demanar
        If pas1 = True Then

            pas2 = disponibilitatLlibres()

            If pas2 = True Then
                'Pas 3: Inserció de dades al proper procediment
                distribueixLlibres()

            End If

        End If

    End Sub

    'En aquest mètode comprovem que l'alumne especificat NO ha portat un llibre dels que estan marcats! <<PAS 1>>
    Private Function comprovaLlibresVenutsAlumne() As Boolean

        Dim index As Integer = ComboBox1.SelectedIndex  'Obtenir l'index de l'alumne triat de a partir del ComboBox
        Dim idAlumne As Integer = ArrayIDAlumnes(index)         'Triem l'ID de l'alumne que hi ha dins la posició del primer Array amb l'index
        Dim nomAlumne As String = ArrayNomAlumnes(index)         'Triem el nom de l'alumne que hi ha dins la posició del segon Array amb l'index
        Dim repetit As Boolean = False                  'Ens preveu si un llibre és repetit (True = Repetit / False = Vàlid)
        Dim resCon As Integer = 0                       'Ens desa el resultat de les consultes que provenen d'una funció.
        Dim consultaLlibreNoPortats As String           'Variable de la consulta, que varia en funció del check box.
        'MsgBox("ID triat: " & idAlumne & " Nom: " & nomAlumne) 'Finestra de control

        'L'estructura varia en funció dels check box marcats
        If ChkB_Llibre1S.Checked = True Then

            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneVenda Lav ON Lli.idLlibre = Lav.idLlibre INNER JOIN Alumnes Al ON Lav.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre0 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre1S.Text & " ja li ha estat venut, desmarca'l!")
            End If

        End If

        If ChkB_Llibre2S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneVenda Lav ON Lli.idLlibre = Lav.idLlibre INNER JOIN Alumnes Al ON Lav.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre1 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre2S.Text & " ja li ha estat venut, desmarca'l!")
            End If
        End If

        If ChkB_Llibre3S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneVenda Lav ON Lli.idLlibre = Lav.idLlibre INNER JOIN Alumnes Al ON Lav.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre2 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre3S.Text & " ja li ha estat venut, desmarca'l!")
            End If
        End If

        If ChkB_Llibre4S.Checked = True Then
            'Li definim la consulta
            consultaLlibreNoPortats = "SELECT COUNT(Lli.idDadesLlibre) as res FROM Llibres Lli INNER JOIN LlibreAlumneVenda Lav ON Lli.idLlibre = Lav.idLlibre INNER JOIN Alumnes Al ON Lav.idAlumne = Al.idAlumne WHERE Al.idAlumne = " & idAlumne & " AND Lli.idDadesLlibre = " & Llibre3 & ""

            resCon = executaConsultaLlibres(consultaLlibreNoPortats)    'Executem la Funció de Consulta
            If resCon = 1 Then
                repetit = True
                MsgBox("El llibre de " & TxtB_Llibre4S.Text & " ja li ha estat venut, desmarca'l!")
            End If
        End If


        'Retornarem un 0 si els llibres que vol portar no els ha entregat.
        If repetit = True Then
            comprovaLlibresVenutsAlumne = False    'NO ha passat els requisits
        Else
            comprovaLlibresVenutsAlumne = True     'SI ha passat els requisits
        End If

    End Function

    'Mètode que ens executa la consulta i ens torna un 1 o un 0 depenent del resultat del COUNT a la BBDD   <<Pas 1 - B>>
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

    'Mètode que ens comprova que el Llibre que demanem, cas que sigui existent, es pugui vendre.        <<PAS 2>>
    Private Function disponibilitatLlibres() As Boolean

        Dim disponible As Boolean = False
        Dim resultat As Integer

        If ChkB_Llibre1S.Checked = True Then

            Dim numLlibre1 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre1S.Text = "" Then
                disponible = True
            Else
                numLlibre1 = Num_Llibre1S.Text          'Posem el número de llibre que requereix.
                'Preparem la consulta.
                Dim consultaDisponibilitatLlibre As String = "SELECT idEstatLlibre FROM Llibres WHERE idDadesLlibre = " & Llibre0 & " AND numLlibre = " & numLlibre1 & ""

                'Cridem a la funció que ens executa la consulta
                resultat = executaDisponibilitatLlibres(consultaDisponibilitatLlibre)

                'En funció del resultat... disponible = true/false
                If resultat = 1 Then    'Ja està en Roda, per tant, ja se li ha fet entrega a algun alumne
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre0 & "ja se li ha venut a un altre alumne, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 2 Then    'Està en Revisió, per tant, és apte per vendre.
                    disponible = True
                ElseIf resultat = 3 Then
                    disponible = True
                ElseIf resultat = 4 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre0 & "ha estat cedit, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 5 Then
                    disponible = True
                ElseIf resultat = 6 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre0 & "ha estat RETirat, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                Else                'Aquest entra per si no hi ha hagut dades, això vol dir que el llibre és nou o no se'n disposa de cap dada. 
                    disponible = True
                End If

            End If
        End If

        If ChkB_Llibre2S.Checked = True Then

            Dim numLlibre2 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre2S.Text = "" Then
                disponible = True
            Else
                numLlibre2 = Num_Llibre2S.Text          'Posem el número de llibre que requereix.
                'Preparem la consulta.
                Dim consultaDisponibilitatLlibre As String = "SELECT idEstatLlibre FROM Llibres WHERE idDadesLlibre = " & Llibre1 & " AND numLlibre = " & numLlibre2 & ""

                'Cridem a la funció que ens executa la consulta
                resultat = executaDisponibilitatLlibres(consultaDisponibilitatLlibre)

                'En funció del resultat... disponible = true/false
                If resultat = 1 Then    'Ja està en Roda, per tant, ja se li ha fet entrega a algun alumne
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre1 & "ja se li ha venut a un altre alumne, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 2 Then    'Està en Revisió, per tant, és apte per vendre.
                    disponible = True
                ElseIf resultat = 3 Then
                    disponible = True
                ElseIf resultat = 4 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre1 & "ha estat cedit, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 5 Then
                    disponible = True
                ElseIf resultat = 6 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre1 & "ha estat RETirat, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                Else                'Aquest entra per si no hi ha hagut dades, això vol dir que el llibre és nou o no se'n disposa de cap dada. 
                    disponible = True
                End If

            End If
        End If

        If ChkB_Llibre3S.Checked = True Then

            Dim numLlibre3 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre3S.Text = "" Then
                disponible = True
            Else
                numLlibre3 = Num_Llibre3S.Text          'Posem el número de llibre que requereix.
                'Preparem la consulta.
                Dim consultaDisponibilitatLlibre As String = "SELECT idEstatLlibre FROM Llibres WHERE idDadesLlibre = " & Llibre2 & " AND numLlibre = " & numLlibre3 & ""

                'Cridem a la funció que ens executa la consulta
                resultat = executaDisponibilitatLlibres(consultaDisponibilitatLlibre)

                'En funció del resultat... disponible = true/false
                If resultat = 1 Then    'Ja està en Roda, per tant, ja se li ha fet entrega a algun alumne
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre2 & "ja se li ha venut a un altre alumne, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 2 Then    'Està en Revisió, per tant, és apte per vendre.
                    disponible = True
                ElseIf resultat = 3 Then
                    disponible = True
                ElseIf resultat = 4 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre2 & "ha estat cedit, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 5 Then
                    disponible = True
                ElseIf resultat = 6 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre2 & "ha estat RETirat, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                Else                'Aquest entra per si no hi ha hagut dades, això vol dir que el llibre és nou o no se'n disposa de cap dada. 
                    disponible = True
                End If

            End If
        End If

        If ChkB_Llibre4S.Checked = True Then

            Dim numLlibre4 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre1S.Text = "" Then
                disponible = True
            Else
                numLlibre4 = Num_Llibre4S.Text          'Posem el número de llibre que requereix.
                'Preparem la consulta.
                Dim consultaDisponibilitatLlibre As String = "SELECT idEstatLlibre FROM Llibres WHERE idDadesLlibre = " & Llibre3 & " AND numLlibre = " & numLlibre4 & ""

                'Cridem a la funció que ens executa la consulta
                resultat = executaDisponibilitatLlibres(consultaDisponibilitatLlibre)

                'En funció del resultat... disponible = true/false
                If resultat = 1 Then    'Ja està en Roda, per tant, ja se li ha fet entrega a algun alumne
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre3 & "ja se li ha venut a un altre alumne, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 2 Then    'Està en Revisió, per tant, és apte per vendre.
                    disponible = True
                ElseIf resultat = 3 Then
                    disponible = True
                ElseIf resultat = 4 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre3 & "ha estat cedit, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                ElseIf resultat = 5 Then
                    disponible = True
                ElseIf resultat = 6 Then
                    disponible = False
                    MsgBox("El Llibre indicat de " & Llibre3 & "ha estat RETirat, revisa les dades i/o canvia de Llibre!", MsgBoxStyle.Critical)
                Else                'Aquest entra per si no hi ha hagut dades, això vol dir que el llibre és nou o no se'n disposa de cap dada. 
                    disponible = True
                End If

            End If
        End If

        'MsgBox("Disponible: " & disponible)

        disponibilitatLlibres = disponible

    End Function

    'Mètode que ens executa la consulta de disponibilitat                                               <<PAS 2 - B>>
    Private Function executaDisponibilitatLlibres(ByVal consulta As String) As Integer
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consulta, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        Dim resultat As Integer 'Ens desa el resultat de la consulta

        'Si el resultat disposa de columnes...
        If mydatatable.Rows.Count > 0 Then
            resultat = mydatatable.Rows(0).Item("idEstatLlibre") 'Assignem a la variable resultat el que es contingui.
        End If

        'En funció del resultat, retornem un número 
        If resultat = 1 Then
            executaDisponibilitatLlibres = 1
        ElseIf resultat = 2 Then
            executaDisponibilitatLlibres = 2
        ElseIf resultat = 3 Then
            executaDisponibilitatLlibres = 3
        ElseIf resultat = 4 Then
            executaDisponibilitatLlibres = 4
        ElseIf resultat = 5 Then
            executaDisponibilitatLlibres = 5
        ElseIf resultat = 6 Then
            executaDisponibilitatLlibres = 6
        Else
            executaDisponibilitatLlibres = 0
        End If
    End Function

    'Mètode que distribueix les tasques per a la inserció de llibres a la Base de Dades.                <<PAS 3>>
    Private Function distribueixLlibres() As Boolean

        'Obtenir l'index de l'alumne triat
        Dim index As Integer = ComboBox1.SelectedIndex
        Dim idAlumne As Integer = ArrayIDAlumnes(index)
        Dim nomAlumne As String = ArrayNomAlumnes(index)

        Dim repetit As Boolean = False
        Dim resCon As Integer = 0       'Ens desa el resultat de les consultes que provenen d'una funció.
        'MsgBox("PAS 3: Inserir Llibres - ID triat: " & idAlumne & " Nom: " & nomAlumne)

        'Variables en ús.
        Dim existeix As Boolean

        'L'estructura varia en funció dels check box marcats
        If ChkB_Llibre1S.Checked = True Then

            Dim numLlibre1 As String    'Hi desem el número de Llibre del TextBox

            If Num_Llibre1S.Text = "" Then  'Obtenim el Valor del Número de Llibre del TextBox Corresponent a la fila del CHKBox1
                numLlibre1 = assignaNumero(Llibre0)     'Técnicament s'hauria de vendre cap llibre sense número, no obstant, sempre passen coses rares, cas que es produiexi, llibre val 0
            Else
                numLlibre1 = Num_Llibre1S.Text          'Posem el número de llibre que requereix.

            End If

            'MsgBox("Número del Llibre: " & numLlibre1)

            'Es determina l'existència del llibre (en base al nº llibre), si existeix modifiquem, i si no existeix (cas estrany) inserim un nou registre.
            Dim consultaExistenciaLlibre As String = "SELECT COUNT( Lli.numLlibre ) AS res FROM Llibres Lli WHERE Lli.idDadesLlibre = " & Llibre0 & " AND Lli.numLlibre = " & numLlibre1 & ""
            existeix = consultaExistencia(consultaExistenciaLlibre)
            'MsgBox("Resultat de la consulta de l'existència del llibre " & numLlibre1 & ": " & existeix)

            Dim consultaIDLlibre As Integer      'Per a controlar que la inserció/modificació s'ha fet correctament
            Dim inserirLlibre As Boolean = False 'Ens determina si finalment podem inserir el llibre o no.
            Dim ultimID As Integer

            'En funció de si existeix o no, realitzem un procediment de modificació o de nou registre
            If existeix = True Then
                'Escrivim la consulta amb un UPDATE per a canviar les dades. Bàsicament l'idEstatLlibre és 1 ja que el llibre torna a estar en Roda.
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 1, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre0 & " AND numLlibre = " & numLlibre1 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre0, numLlibre1)

                'MsgBox("L'ID de la consulta és: " & consultaIDLlibre)
                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre0 & ", " & numLlibre1 & ", 1, CURRENT_TIMESTAMP)"

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
                'MsgBox("Valor de l'ID de l'Alumne: " & idAlumne & " - Valor de l'ID del llibre: " & consultaIDLlibre)
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
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 1, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre1 & " AND numLlibre = " & numLlibre2 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre1, numLlibre2)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre1 & ", " & numLlibre2 & ", 1, CURRENT_TIMESTAMP)"

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
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 1, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre2 & " AND numLlibre = " & numLlibre3 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre2, numLlibre3)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre2 & ", " & numLlibre3 & ", 1, CURRENT_TIMESTAMP)"

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
                Dim UpdateDadesLlibre As String = "UPDATE Llibres SET idEstatLlibre = 1, llibreActualitzat = CURRENT_TIMESTAMP WHERE idDadesLlibre = " & Llibre3 & " AND numLlibre = " & numLlibre4 & ""

                'Cridem al mètode per a fer l'Update
                executaModificacioLlibre(UpdateDadesLlibre)
                consultaIDLlibre = comprovaModificacioLlibre(Llibre3, numLlibre4)

                'Si IDLlibre és diferent de 0, vol dir que el llibre existeix i és apte per a la seva modificació.
                If consultaIDLlibre <> 0 Then
                    inserirLlibre = True
                End If
            ElseIf existeix = False Then
                Dim InsertDadesLlibre As String = "INSERT INTO Llibres (idDadesLlibre, numLlibre, idEstatLlibre, llibreActualitzat) VALUES (" & Llibre3 & ", " & numLlibre4 & ", 1, CURRENT_TIMESTAMP)"

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


        'Retornarme un 0 si els llibres que vol portar no els ha entregat.
        If repetit = True Then
            distribueixLlibres = False    'NO ha passat els requisits
        Else
            distribueixLlibres = True     'SI ha passat els requisits
        End If
    End Function

    'Mètode que comprova que un Llibre que es vol entregar existeix a la Base de Dades o no.            <<PAS 3 - B>>
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

    'Mètode per a fer la inserció de les dades d'un Llibre NO existent durant l'entrega de llibres
    Private Function executaInsercioLlibre(ByVal consultaInsert As String, ByVal Llibre As Integer, ByVal numLlibre As Integer) As Integer
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(consultaInsert, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem

        executaInsercioLlibre = 0

    End Function

    'Mètode per a comrpovar que la inserció s'ha realitzat correctament. Alhora, demanem l'id del Llibre    <<PAS 3 - D1>>
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
        If idEstatLlibre = 1 Then
            comprovaModificacioLlibre = idLlibre
        Else
            comprovaModificacioLlibre = 0
        End If
    End Function

    'Mètode per a fer la modificació de les dades d'un llibre existent durant l'entrega de llibres      <<PAS 3 - C1>>
    Private Sub executaModificacioLlibre(ByVal UpdateDadesLlibre)
        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(UpdateDadesLlibre, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem


    End Sub

    'Mètode que ens insereix el registre de relació de recollida entre un Alumne i un Llibre.           <<PAS 3 - E>>
    Private Function insereixRegistreLlibreAlumne(ByVal idAlumne, ByVal IDLlibre) As Boolean

        'Sentència de la consulta a la Base de Dades.
        Dim consultaInserixLlibreAlumne As String = "INSERT INTO llibreAlumneVenda VALUES(" & idAlumne & "," & IDLlibre & " , CURRENT_TIMESTAMP)"
        Dim myAdapter As New MySqlDataAdapter(consultaInserixLlibreAlumne, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable)

        insereixRegistreLlibreAlumne = True

    End Function

    'Mètode que ens permetrà fer l'assignació d'un número de llibre en un que no en disposi!            <<PAS 3 - A>>
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

    'Botó que ens calcula el preu final en base al total de llibres, resguard de recollida i efectiu.
    Private Sub BotoCalcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotoCalcula.Click

        'Agafem el Valors 
        Dim PreuGeneralLlibres As Double = TxtB_PreuTotal.Text
        Dim PreuResguard As Double = TxtB_ResguardRecollida_Sup.Text
        Dim PreuEfectiu As Double = TxtB_Efectiu_Sup.Text

        'Sumem Tot
        Dim PreuTotalVenda As Double
        Dim PreuVariable As Double
        PreuVariable = PreuResguard + PreuEfectiu

        PreuTotalVenda = PreuGeneralLlibres - PreuVariable

        PreuTotalVenda = Math.Round(PreuTotalVenda, 3)

        TxtB_PreuTotalPagar_Sup.Text = PreuTotalVenda

    End Sub



End Class