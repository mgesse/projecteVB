Imports MySql.Data.MySqlClient

Public Class Gestio_EstatNumLlibres




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
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 101"

        ElseIf RBt_1r.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 102"
        ElseIf RBt_1r.Checked = True And RBt_NAT.Checked = True Then
            MsgBox("Has triat NATURALS de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 103"
        ElseIf RBt_1r.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 105"
        ElseIf RBt_1r.Checked = True And RBt_TEC.Checked = True Then
            MsgBox("Has triat TECNOLOGIA de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 104"
        ElseIf RBt_1r.Checked = True And RBt_ANG.Checked = True Then
            MsgBox("Has triat ANGLÈS de 1r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 106"

            '2N D'ESO
        ElseIf RBt_2n.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 201"
        ElseIf RBt_2n.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 202"
        ElseIf RBt_2n.Checked = True And RBt_NAT.Checked = True Then
            MsgBox("Has triat NATURALS de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 203"
        ElseIf RBt_2n.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 205"
        ElseIf RBt_2n.Checked = True And RBt_TEC.Checked = True Then
            MsgBox("Has triat TECNOLOGIA de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 204"
        ElseIf RBt_2n.Checked = True And RBt_ANG.Checked = True Then
            MsgBox("Has triat ANGLÈS de 2n d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 206"

            '3R D'ESO
        ElseIf RBt_3r.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 301"
        ElseIf RBt_3r.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 302"
        ElseIf RBt_3r.Checked = True And RBt_BIG.Checked = True Then
            MsgBox("Has triat BIOLOGIA I GEOLOGIA de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 305"
        ElseIf RBt_3r.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 303"
        ElseIf RBt_3r.Checked = True And RBt_TEC.Checked = True Then
            MsgBox("Has triat TECNOLOGIA de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 304"
        ElseIf RBt_3r.Checked = True And RBt_FIQ.Checked = True Then
            MsgBox("Has triat FÍSICA I QUÍMICA de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 306"
        ElseIf RBt_3r.Checked = True And RBt_MAT.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES de 3r d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 307"

            '4RT D'ESO
        ElseIf RBt_4rt.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 4rt d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 401"
        ElseIf RBt_4rt.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 4rt d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 402"
        ElseIf RBt_4rt.Checked = True And RBt_MAT.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES de 4rt d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 404"
        ElseIf RBt_4rt.Checked = True And RBt_SOC.Checked = True Then
            MsgBox("Has triat SOCIALS de 4rt d'ESO")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 403"

            '1R DE BATX
        ElseIf RBt_5e.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 501"
        ElseIf RBt_5e.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 502"
        ElseIf RBt_5e.Checked = True And RBt_FIL.Checked = True Then
            MsgBox("Has triat FILOSOFIA I CIUTADANIA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 503"
        ElseIf RBt_5e.Checked = True And RBt_TEI.Checked = True Then
            MsgBox("Has triat TECNOLOGIA INDUSTRIAL de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 504"
        ElseIf RBt_5e.Checked = True And RBt_LLA.Checked = True Then
            MsgBox("Has triat LLATÍ de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 505"
        ElseIf RBt_5e.Checked = True And RBt_HMC.Checked = True Then
            MsgBox("Has triat HISTÒRIA MÓN CONTEMPORANI de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 506"
        ElseIf RBt_5e.Checked = True And RBt_MAC.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (CIENT.) de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 507"
        ElseIf RBt_5e.Checked = True And RBt_MAH.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (HUMAN.) de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 508"
        ElseIf RBt_5e.Checked = True And RBt_FIS.Checked = True Then
            MsgBox("Has triat FÍSICA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 509"
        ElseIf RBt_5e.Checked = True And RBt_QUI.Checked = True Then
            MsgBox("Has triat QUÍMICA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 510"
        ElseIf RBt_5e.Checked = True And RBt_ECE.Checked = True Then
            MsgBox("Has triat ECONOMIA DE L'EMPRESA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 511"
        ElseIf RBt_5e.Checked = True And RBt_BIO.Checked = True Then
            MsgBox("Has triat BIOLOGIA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 512"
        ElseIf RBt_5e.Checked = True And RBt_CMC.Checked = True Then
            MsgBox("Has triat CIÈNCIES MÓN CONTEMPORANI de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 513"
        ElseIf RBt_5e.Checked = True And RBt_ECO.Checked = True Then
            MsgBox("Has triat ECONOMIA de 1r de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 514"

            '2N DE BATX
        ElseIf RBt_6e.Checked = True And RBt_CAT.Checked = True Then
            MsgBox("Has triat CATALÀ de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 601"
        ElseIf RBt_6e.Checked = True And RBt_CAS.Checked = True Then
            MsgBox("Has triat CASTELLÀ de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 602"
        ElseIf RBt_6e.Checked = True And RBt_HFI.Checked = True Then
            MsgBox("Has triat HISTÒRIA DE LA FILOSOFIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 615"
        ElseIf RBt_6e.Checked = True And RBt_TEI.Checked = True Then
            MsgBox("Has triat TECNOLOGIA INDUSTRIAL de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 603"
        ElseIf RBt_6e.Checked = True And RBt_LLA.Checked = True Then
            MsgBox("Has triat LLATÍ de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 604"
        ElseIf RBt_6e.Checked = True And RBt_HIS.Checked = True Then
            MsgBox("Has triat HISTÒRIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 611"
        ElseIf RBt_6e.Checked = True And RBt_MAC.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (CIENT.) de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 605"
        ElseIf RBt_6e.Checked = True And RBt_MAH.Checked = True Then
            MsgBox("Has triat MATEMÀTIQUES (HUMAN.) de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 606"
        ElseIf RBt_6e.Checked = True And RBt_FIS.Checked = True Then
            MsgBox("Has triat FÍSICA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 607"
        ElseIf RBt_6e.Checked = True And RBt_QUI.Checked = True Then
            MsgBox("Has triat QUÍMICA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 608"
        ElseIf RBt_6e.Checked = True And RBt_ECE.Checked = True Then
            MsgBox("Has triat ECONOMIA DE L'EMPRESA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 609"
        ElseIf RBt_6e.Checked = True And RBt_BIO.Checked = True Then
            MsgBox("Has triat BIOLOGIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 610"
        ElseIf RBt_6e.Checked = True And RBt_ELE.Checked = True Then
            MsgBox("Has triat ELECTROTÈCNIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 612"
        ElseIf RBt_6e.Checked = True And RBt_GEO.Checked = True Then
            MsgBox("Has triat GEOLOGIA de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 613"
        ElseIf RBt_6e.Checked = True And RBt_ART.Checked = True Then
            MsgBox("Has triat HISTÒRIA DE L'ART de 2n de BATX")
            ConsultaDadesLlibres = "SELECT lli.numLlibre AS 'N. Llibre', lli.avaluacioInterior AS 'Nota Int', lli.avaluacioExterior AS  'Nota Ext', lli.avaluacioTotal AS  'Nota Total', Est.nomEstat AS  'Estat', lli.llibreActualitzat AS  'Darrer Canvi' FROM llibres lli INNER JOIN EstatLlibres Est ON lli.idEstatLlibre = Est.idEstatLlibres WHERE lli.idDadesLlibre = 614"

        End If
        Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres2")
        Dim myAdapter As New MySqlDataAdapter(ConsultaDadesLlibres, myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        DataGridView1.DataSource = mydatatable
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

    
End Class