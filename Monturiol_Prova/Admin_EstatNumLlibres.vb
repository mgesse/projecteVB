Imports MySql.Data.MySqlClient

Public Class Admin_EstatNumLlibres

    Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
    'Fem l'array per desar els ID de l'estat dels Llibres.
    Dim arrayID(6) As Integer
    Dim numLlibreInicial As String
    Dim idLlibre As Integer
    Dim darreraConsulta As String
    Dim DarrerIDDadesLlibre As Integer

    Private Sub redefineixLlibres()
        'Cas que el RadioButton de 1r d'ESO o 2n d'ESO estigui marcat
        If RBt_1r.Checked = True Or RBt_2n.Checked = True Then
            'Llista d'Assignatures
            RBt_CAT.Enabled = True      'Català
            RBt_CAS.Enabled = True      'Castellà
            RBt_NAT.Enabled = True      'Naturals
            RBt_SOC.Enabled = True      'Socials
            RBt_TEC.Enabled = True      'Tecnologia
            RBt_ANG.Enabled = True      'Anglès
            RBt_BIG.Enabled = False     'Biologia i Geologia
            RBt_FIQ.Enabled = False     'Física i Química
            RBt_MAT.Enabled = False     'Matemàtiques
            RBt_FIL.Enabled = False     'Filosofia
            RBt_TEI.Enabled = False     'Tecnologia Ind.
            RBt_LLA.Enabled = False     'Llatí
            RBt_HMC.Enabled = False     'Història Món Contem.
            RBt_MAC.Enabled = False     'Matemàtiques (Cient)
            RBt_MAH.Enabled = False     'Matemàtiques (Human)
            RBt_FIS.Enabled = False     'Física
            RBt_QUI.Enabled = False     'Química
            RBt_ECE.Enabled = False     'Economia de l'Empr.
            RBt_BIO.Enabled = False     'Biologia
            RBt_CMC.Enabled = False     'Ciències Món Cont.
            RBt_ECO.Enabled = False     'Economia 
            RBt_HIS.Enabled = False     'Història 
            RBt_ELE.Enabled = False     'Electrotècnia
            RBt_GEO.Enabled = False     'Geologia
            RBt_ART.Enabled = False     'Història de l'Art
            RBt_HFI.Enabled = False     'Història de la Fi.

        ElseIf RBt_3r.Checked = True Then

            'Llista d'Assignatures
            RBt_CAT.Enabled = True      'Català
            RBt_CAS.Enabled = True      'Castellà
            RBt_NAT.Enabled = False     'Naturals
            RBt_SOC.Enabled = True      'Socials
            RBt_TEC.Enabled = True      'Tecnologia
            RBt_ANG.Enabled = False     'Anglès
            RBt_BIG.Enabled = True      'Biologia i Geologia
            RBt_FIQ.Enabled = True      'Física i Química
            RBt_MAT.Enabled = True      'Matemàtiques
            RBt_FIL.Enabled = False     'Filosofia
            RBt_TEI.Enabled = False     'Tecnologia Ind.
            RBt_LLA.Enabled = False     'Llatí
            RBt_HMC.Enabled = False     'Història Món Contem.
            RBt_MAC.Enabled = False     'Matemàtiques (Cient)
            RBt_MAH.Enabled = False     'Matemàtiques (Human)
            RBt_FIS.Enabled = False     'Física
            RBt_QUI.Enabled = False     'Química
            RBt_ECE.Enabled = False     'Economia de l'Empr.
            RBt_BIO.Enabled = False     'Biologia
            RBt_CMC.Enabled = False     'Ciències Món Cont.
            RBt_ECO.Enabled = False     'Economia 
            RBt_HIS.Enabled = False     'Història 
            RBt_ELE.Enabled = False     'Electrotècnia
            RBt_GEO.Enabled = False     'Geologia
            RBt_ART.Enabled = False     'Història de l'Art
            RBt_HFI.Enabled = False     'Història de la Fi.

        ElseIf RBt_4rt.Checked = True Then
            'Llista d'Assignatures
            RBt_CAT.Enabled = True      'Català
            RBt_CAS.Enabled = True      'Castellà
            RBt_NAT.Enabled = False     'Naturals
            RBt_SOC.Enabled = True      'Socials
            RBt_TEC.Enabled = False     'Tecnologia
            RBt_ANG.Enabled = False     'Anglès
            RBt_BIG.Enabled = False     'Biologia i Geologia
            RBt_FIQ.Enabled = False     'Física i Química
            RBt_MAT.Enabled = True      'Matemàtiques
            RBt_FIL.Enabled = False     'Filosofia
            RBt_TEI.Enabled = False     'Tecnologia Ind.
            RBt_LLA.Enabled = False     'Llatí
            RBt_HMC.Enabled = False     'Història Món Contem.
            RBt_MAC.Enabled = False     'Matemàtiques (Cient)
            RBt_MAH.Enabled = False     'Matemàtiques (Human)
            RBt_FIS.Enabled = False     'Física
            RBt_QUI.Enabled = False     'Química
            RBt_ECE.Enabled = False     'Economia de l'Empr.
            RBt_BIO.Enabled = False     'Biologia
            RBt_CMC.Enabled = False     'Ciències Món Cont.
            RBt_ECO.Enabled = False     'Economia 
            RBt_HIS.Enabled = False     'Història 
            RBt_ELE.Enabled = False     'Electrotècnia
            RBt_GEO.Enabled = False     'Geologia
            RBt_ART.Enabled = False     'Història de l'Art
            RBt_HFI.Enabled = False     'Història de la Fi.

        ElseIf RBt_5e.Checked = True Then
            'Llista d'Assignatures
            RBt_CAT.Enabled = True      'Català
            RBt_CAS.Enabled = True      'Castellà
            RBt_NAT.Enabled = False     'Naturals
            RBt_SOC.Enabled = False      'Socials
            RBt_TEC.Enabled = False      'Tecnologia
            RBt_ANG.Enabled = False     'Anglès
            RBt_BIG.Enabled = False      'Biologia i Geologia
            RBt_FIQ.Enabled = False      'Física i Química
            RBt_MAT.Enabled = False      'Matemàtiques
            RBt_FIL.Enabled = True     'Filosofia
            RBt_TEI.Enabled = True     'Tecnologia Ind.
            RBt_LLA.Enabled = True     'Llatí
            RBt_HMC.Enabled = True     'Història Món Contem.
            RBt_MAC.Enabled = True     'Matemàtiques (Cient)
            RBt_MAH.Enabled = True     'Matemàtiques (Human)
            RBt_FIS.Enabled = True     'Física
            RBt_QUI.Enabled = True     'Química
            RBt_ECE.Enabled = True     'Economia de l'Empr.
            RBt_BIO.Enabled = True     'Biologia
            RBt_CMC.Enabled = True     'Ciències Món Cont.
            RBt_ECO.Enabled = True     'Economia 
            RBt_HIS.Enabled = False     'Història 
            RBt_ELE.Enabled = False     'Electrotècnia
            RBt_GEO.Enabled = False     'Geologia
            RBt_ART.Enabled = False     'Història de l'Art
            RBt_HFI.Enabled = False     'Història de la Fi.

        ElseIf RBt_6e.Checked = True Then
            'Llista d'Assignatures
            RBt_CAT.Enabled = True      'Català
            RBt_CAS.Enabled = True      'Castellà
            RBt_NAT.Enabled = False     'Naturals
            RBt_SOC.Enabled = False     'Socials
            RBt_TEC.Enabled = False     'Tecnologia
            RBt_ANG.Enabled = False     'Anglès
            RBt_BIG.Enabled = False     'Biologia i Geologia
            RBt_FIQ.Enabled = False     'Física i Química
            RBt_MAT.Enabled = False     'Matemàtiques
            RBt_FIL.Enabled = False     'Filosofia
            RBt_TEI.Enabled = True      'Tecnologia Ind.
            RBt_LLA.Enabled = True      'Llatí
            RBt_HMC.Enabled = False     'Història Món Contem.
            RBt_MAC.Enabled = True      'Matemàtiques (Cient)
            RBt_MAH.Enabled = True      'Matemàtiques (Human)
            RBt_FIS.Enabled = True      'Física
            RBt_QUI.Enabled = True      'Química
            RBt_ECE.Enabled = True      'Economia de l'Empr.
            RBt_BIO.Enabled = True      'Biologia
            RBt_CMC.Enabled = False     'Ciències Món Cont.
            RBt_ECO.Enabled = False     'Economia 
            RBt_HIS.Enabled = True      'Història 
            RBt_ELE.Enabled = True      'Electrotècnia
            RBt_GEO.Enabled = True      'Geologia
            RBt_ART.Enabled = True      'Història de l'Art
            RBt_HFI.Enabled = True      'Història de la Fi.
        End If

        'Posem el check del llibres al de català
        RBt_CAT.Checked = True

    End Sub

    'En funció de la doble tria, farà una consulta o una altre a la Base de Dades.
    Private Sub Boto_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Consulta.Click
        Dim ConsultaDadesLlibres As String = ""
        If RBt_1r.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 1r d'ESO")
            DarrerIDDadesLlibre = 101
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 101 ORDER BY lli.numLlibre"

        ElseIf RBt_1r.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 1r d'ESO")
            DarrerIDDadesLlibre = 102
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 102 ORDER BY lli.numLlibre"
        ElseIf RBt_1r.Checked = True And RBt_NAT.Checked = True Then
            MsgBox("Has triat NATURALS de 1r d'ESO")
            DarrerIDDadesLlibre = 103
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 103 ORDER BY lli.numLlibre"
        ElseIf RBt_1r.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 1r d'ESO")
            DarrerIDDadesLlibre = 104
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 105 ORDER BY lli.numLlibre"
        ElseIf RBt_1r.Checked = True And RBt_TEC.Checked = True Then
            DarrerIDDadesLlibre = 105
            MsgBox("Has triat TECNOLOGIA de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 104 ORDER BY lli.numLlibre"
        ElseIf RBt_1r.Checked = True And RBt_ANG.Checked = True Then
            MsgBox("Has triat ANGLÈS de 1r d'ESO")
            DarrerIDDadesLlibre = 106
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 106 ORDER BY lli.numLlibre"

            '2N D'ESO
        ElseIf RBt_2n.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 2n d'ESO")
            DarrerIDDadesLlibre = 201
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 201 ORDER BY lli.numLlibre"
        ElseIf RBt_2n.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 2n d'ESO")
            DarrerIDDadesLlibre = 202
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 202 ORDER BY lli.numLlibre"
        ElseIf RBt_2n.Checked = True And RBt_NAT.Checked = True Then
            MsgBox("Has triat NATURALS de 2n d'ESO")
            DarrerIDDadesLlibre = 203
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 203 ORDER BY lli.numLlibre"
        ElseIf RBt_2n.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 2n d'ESO")
            DarrerIDDadesLlibre = 204
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 205 ORDER BY lli.numLlibre"
        ElseIf RBt_2n.Checked = True And RBt_TEC.Checked = True Then
            MsgBox("Has triat TECNOLOGIA de 2n d'ESO")
            DarrerIDDadesLlibre = 205
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 204 ORDER BY lli.numLlibre"
        ElseIf RBt_2n.Checked = True And RBt_ANG.Checked = True Then
            MsgBox("Has triat ANGLÈS de 2n d'ESO")
            DarrerIDDadesLlibre = 206
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 206 ORDER BY lli.numLlibre"

            '3R D'ESO
        ElseIf RBt_3r.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 3r d'ESO")
            DarrerIDDadesLlibre = 301
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 301 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_CAS.Checked = True Then
            DarrerIDDadesLlibre = 302
            MsgBox("Has triat CASTELLÀ de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 302 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_BIG.Checked = True Then
            MsgBox("Has triat BIOLOGIA I GEOLOGIA de 3r d'ESO")
            DarrerIDDadesLlibre = 305
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 305 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 3r d'ESO")
            DarrerIDDadesLlibre = 303
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 303 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_TEC.Checked = True Then
            MsgBox("Has triat TECNOLOGIA de 3r d'ESO")
            DarrerIDDadesLlibre = 304
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 304 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_FIQ.Checked = True Then
            MsgBox("Has triat FÍSICA I QUÍMICA de 3r d'ESO")
            DarrerIDDadesLlibre = 306
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 306 ORDER BY lli.numLlibre"
        ElseIf RBt_3r.Checked = True And RBt_MAT.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES de 3r d'ESO")
            DarrerIDDadesLlibre = 307
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 307 ORDER BY lli.numLlibre"

            '4RT D'ESO
        ElseIf RBt_4rt.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 4rt d'ESO")
            DarrerIDDadesLlibre = 401
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 401 ORDER BY lli.numLlibre"
        ElseIf RBt_4rt.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 4rt d'ESO")
            DarrerIDDadesLlibre = 402
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 402 ORDER BY lli.numLlibre"
        ElseIf RBt_4rt.Checked = True And RBt_MAT.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES de 4rt d'ESO")
            DarrerIDDadesLlibre = 404
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 404 ORDER BY lli.numLlibre"
        ElseIf RBt_4rt.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 4rt d'ESO")
            DarrerIDDadesLlibre = 403
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 403 ORDER BY lli.numLlibre"

            '1R DE BATX
        ElseIf RBt_5e.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 1r de BATX")
            DarrerIDDadesLlibre = 501
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 501 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 1r de BATX")
            DarrerIDDadesLlibre = 502
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 502 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_FIL.Checked = True Then
            MsgBox("Has triat FILOSOFIA I CIUTADANIA de 1r de BATX")
            DarrerIDDadesLlibre = 503
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 503 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_TEI.Checked = True Then
            MsgBox("Has triat TECNOLOGIA INDUSTRIAL de 1r de BATX")
            DarrerIDDadesLlibre = 504
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 504 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_LLA.Checked = True Then
            MsgBox("Has triat LLATÍ de 1r de BATX")
            DarrerIDDadesLlibre = 505
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 505 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_HMC.Checked = True Then
            MsgBox("Has triat HISTÒRIA MÓN CONTEMPORANI de 1r de BATX")
            DarrerIDDadesLlibre = 506
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 506 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_MAC.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (CIENT.) de 1r de BATX")
            DarrerIDDadesLlibre = 507
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 507 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_MAH.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (HUMAN.) de 1r de BATX")
            DarrerIDDadesLlibre = 508
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 508 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_FIS.Checked = True Then
            MsgBox("Has triat FÍSICA de 1r de BATX")
            DarrerIDDadesLlibre = 509
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 509 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_QUI.Checked = True Then
            MsgBox("Has triat QUÍMICA de 1r de BATX")
            DarrerIDDadesLlibre = 510
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 510 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_ECE.Checked = True Then
            MsgBox("Has triat ECONOMIA DE L'EMPRESA de 1r de BATX")
            DarrerIDDadesLlibre = 511
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 511 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_BIO.Checked = True Then
            MsgBox("Has triat BIOLOGIA de 1r de BATX")
            DarrerIDDadesLlibre = 512
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 512 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_CMC.Checked = True Then
            MsgBox("Has triat CIÈNCIES MÓN CONTEMPORANI de 1r de BATX")
            DarrerIDDadesLlibre = 513
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 513 ORDER BY lli.numLlibre"
        ElseIf RBt_5e.Checked = True And RBt_ECO.Checked = True Then
            MsgBox("Has triat ECONOMIA de 1r de BATX")
            DarrerIDDadesLlibre = 514
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 514 ORDER BY lli.numLlibre"

            '2N DE BATX
        ElseIf RBt_6e.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 2n de BATX")
            DarrerIDDadesLlibre = 601
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 601 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 2n de BATX")
            DarrerIDDadesLlibre = 602
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 602 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_HFI.Checked = True Then
            DarrerIDDadesLlibre = 615
            MsgBox("Has triat HISTÒRIA DE LA FILOSOFIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 615 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_TEI.Checked = True Then
            MsgBox("Has triat TECNOLOGIA INDUSTRIAL de 2n de BATX")
            DarrerIDDadesLlibre = 603
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 603 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_LLA.Checked = True Then
            MsgBox("Has triat LLATÍ de 2n de BATX")
            DarrerIDDadesLlibre = 604
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 604 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_HIS.Checked = True Then
            MsgBox("Has triat HISTÒRIA de 2n de BATX")
            DarrerIDDadesLlibre = 611
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 611 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_MAC.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (CIENT.) de 2n de BATX")
            DarrerIDDadesLlibre = 605
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 605 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_MAH.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (HUMAN.) de 2n de BATX")
            DarrerIDDadesLlibre = 606
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 606 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_FIS.Checked = True Then
            MsgBox("Has triat FÍSICA de 2n de BATX")
            DarrerIDDadesLlibre = 607
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 607 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_QUI.Checked = True Then
            MsgBox("Has triat QUÍMICA de 2n de BATX")
            DarrerIDDadesLlibre = 608
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 608 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_ECE.Checked = True Then
            MsgBox("Has triat ECONOMIA DE L'EMPRESA de 2n de BATX")
            DarrerIDDadesLlibre = 609
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 609 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_BIO.Checked = True Then
            MsgBox("Has triat BIOLOGIA de 2n de BATX")
            DarrerIDDadesLlibre = 610
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 610 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_ELE.Checked = True Then
            MsgBox("Has triat ELECTROTÈCNIA de 2n de BATX")
            DarrerIDDadesLlibre = 612
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 612 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_GEO.Checked = True Then
            MsgBox("Has triat GEOLOGIA de 2n de BATX")
            DarrerIDDadesLlibre = 613
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 613 ORDER BY lli.numLlibre"
        ElseIf RBt_6e.Checked = True And RBt_ART.Checked = True Then
            MsgBox("Has triat HISTÒRIA DE L'ART de 2n de BATX")
            DarrerIDDadesLlibre = 614
            ConsultaDadesLlibres = "SELECT lli.idLlibre, lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 614 ORDER BY lli.numLlibre"

        End If

        darreraConsulta = ConsultaDadesLlibres

        Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
        Dim myAdapter As New MySqlDataAdapter(ConsultaDadesLlibres, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable

        reposaDades()
    End Sub

    Private Sub RBt_1r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_1r.CheckedChanged
        redefineixLlibres()
    End Sub

    Private Sub RBt_2n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_2n.CheckedChanged
        redefineixLlibres()
    End Sub

    Private Sub RBt_3r_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_3r.CheckedChanged
        redefineixLlibres()
    End Sub

    Private Sub RBt_4rt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_4rt.CheckedChanged
        redefineixLlibres()
    End Sub

    Private Sub RBt_5e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_5e.CheckedChanged
        redefineixLlibres()
    End Sub

    Private Sub RBt_6e_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBt_6e.CheckedChanged
        redefineixLlibres()
    End Sub


    Private Sub Admin_EstatNumLlibres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Quan carrega el formulari, consulta a la Base de Dades les possibles opcions que hi ha com a estat de llibre.
        Dim consultaEstat As String = "SELECT idEstatLlibres, nomEstat FROM estatLlibres"

        'Segon Adaptador per als Alumnes
        Dim myAdapter As New MySqlDataAdapter(consultaEstat, myConnection)

        'Fem una taula virtual
        Dim mydatatable As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapter.Fill(mydatatable)

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then
            CBox_Estat.DataSource = mydatatable
            CBox_Estat.ValueMember = "nomEstat"
            Dim final As Integer = mydatatable.Rows.Count

            'Fem una iteració de fins a 40 llocs 
            For iterador As Integer = 0 To final - 1

                Dim idEstat As Integer
                Dim nomEstat As String

                idEstat = mydatatable.Rows(iterador).Item("idEstatLlibres")
                'MsgBox("Valor de l'ID ESTAT: " & idEstat)
                nomEstat = mydatatable.Rows(iterador).Item("nomEstat")

                arrayID(iterador) = idEstat
            Next
        End If

    End Sub

    Private Sub Boto_Actualitza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Actualitza.Click

        'MsgBox("Valor del Estat: " & arrayID(CBox_Estat.SelectedIndex))
        

        If TxtB_NumLlibre.Text = "" Then
            'Cas que el Text Box del número de llibre sigui "null", no fem res.
            MsgBox("Fes clic abans a una fila de la taula")
        Else

            'Obtenim les dades dels elements modificables
            Dim nouNumero As Integer = TxtB_NumLlibre.Text
            Dim novaNotaInt As String = CBox_Interior.SelectedItem()
            Dim novaNotaExt As String = CBox_Exterior.SelectedItem()
            Dim novaNotaTot As String = CBox_Total.SelectedItem()
            Dim nouEstat As Integer = arrayID(CBox_Estat.SelectedIndex())

            'En funció de la edició del número de llibre és actiu o no, seguim un procediment.
            If ChkB_ActivaNumero.Checked = False Then

                'Preparem la consulta per l'Update
                Dim modificacio As String = "UPDATE llibres SET avaluacioInterior = '" & novaNotaInt & "', avaluacioExterior = '" & novaNotaExt & "', avaluacioTotal = '" & novaNotaTot & "', idEstatLlibre = '" & nouEstat & "', llibreActualitzat = CURRENT_TIMESTAMP  WHERE idLlibre = " & idLlibre & ""

                executaModificacio(modificacio)

                actualitzaTaula(darreraConsulta)
                reposaDades()

            ElseIf ChkB_ActivaNumero.Checked = True Then

                'Hem de fer la comrpovació primer de que el nou número de llibre que es vol inserir NO està agafat.
                'Fem una select per saber si està el llibre agafat o no.
                Dim consulta As String = "SELECT COUNT(numLlibre) AS 'res' FROM Llibres WHERE idDadesLlibre = " & DarrerIDDadesLlibre & " AND numLlibre = '" & nouNumero & "'"

                Dim resultat As Integer = comprovaNumero(consulta)

                If resultat = 0 Then
                    'Cas bo, podem canviar el número de llibre ja que no n'existeix cap
                    'Preparem la modificació del número de llibre.
                    Dim modificacio As String = "UPDATE llibres SET numLlibre = " & nouNumero & ", avaluacioInterior = '" & novaNotaInt & "', avaluacioExterior = '" & novaNotaExt & "', avaluacioTotal = '" & novaNotaTot & "', idEstatLlibre = '" & nouEstat & "', llibreActualitzat = CURRENT_TIMESTAMP  WHERE idLlibre = " & idLlibre & ""

                    executaModificacio(modificacio)

                    actualitzaTaula(darreraConsulta)
                    reposaDades()

                ElseIf resultat > 0 Then
                    'Cas dolent, ja que ja hi ha un llibre agafat.
                    MsgBox("El Número introduït ja està agafat")
                End If

                
            End If

        End If
        

    End Sub

    'S'executa quan es fa doble clic a l'index d'una fila.
    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'Inserim les dades al panell superior.
        idLlibre = Me.DataGridView1.CurrentRow.Cells.Item(0).Value

        TxtB_NumLlibre.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value
        numLlibreInicial = TxtB_NumLlibre.Text
        TxtB_NumLlibre.ReadOnly = True
        ChkB_ActivaNumero.Checked = False

        Try
            CBox_Interior.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value
        Catch ex As Exception
            CBox_Interior.Text = "DET"
        End Try

        Try
            CBox_Exterior.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value
        Catch ex As Exception
            CBox_Exterior.Text = "DET"
        End Try

        Try
            CBox_Total.Text = Me.DataGridView1.CurrentRow.Cells.Item(4).Value
        Catch ex As Exception
            CBox_Total.Text = "DET"
        End Try

        CBox_Estat.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value
    End Sub

    'En funció de si està activat o no, es permet l'edició del número de llibre.
    'Cas que es canviï el Nº de llibre, caldrà seguir uns procediments lleugerament suficients.
    Private Sub ChkB_ActivaNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkB_ActivaNumero.CheckedChanged

        If ChkB_ActivaNumero.Checked = True Then
            TxtB_NumLlibre.ReadOnly = False
        ElseIf ChkB_ActivaNumero.Checked = False Then
            'Reposem el número inicial del llibre
            TxtB_NumLlibre.Text = numLlibreInicial
            TxtB_NumLlibre.ReadOnly = True
        End If


    End Sub

    Private Sub executaModificacio(ByVal modificacio)

        'Establim l'adaptador amb la sentència SQL que li passem per paràmetre
        Dim myAdapter As New MySqlDataAdapter(modificacio, myConnection)

        'Fem l'assignació de la taula
        Dim mydatatable As New DataTable
        myAdapter.Fill(mydatatable) 'Executem

    End Sub

    Private Sub actualitzaTaula(ByVal consulta As String)
        Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
        Dim myAdapter As New MySqlDataAdapter(consulta, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
    End Sub

    Private Function comprovaNumero(ByVal consulta) As Integer
        'Adaptador per als Alumnes
        Dim myAdapter As New MySqlDataAdapter(consulta, myConnection)

        'Fem una taula virtual
        Dim mydatatable As New DataTable

        'Assigna l'adaptador amb la taula virtual
        myAdapter.Fill(mydatatable)

        'Fem una variable amb el resultat
        Dim resultat As Integer

        'Ens assegurem que hi ha dades
        If mydatatable.Rows.Count > 0 Then

            'Omplim la taula
            resultat = mydatatable.Rows(0).Item("res") 'Assignem a la variable resultat el que es contingui.

        End If

        comprovaNumero = resultat

    End Function

    'Mètode que reposa les dades normals dels textbox i combo box.
    Private Sub reposaDades()
        TxtB_NumLlibre.Text = ""


    End Sub

    
End Class