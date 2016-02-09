Public Class Inicial

    Private Sub Inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Boto_Recollida_1r_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Recollida_1r.Click
        'ProvaImprimir1.Show()
        Recollida_1r.Show()
    End Sub

    Private Sub Boto_Recollida_2n_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Recollida_2n.Click
        Recollida2n.Show()
    End Sub

    Private Sub Boto_Recollida_3r_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Recollida_3r.Click
        Recollida3r.Show()
    End Sub

    Private Sub Boto_Recollida_4rt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Recollida_4rt.Click
        _4rt_Recollida.Show()
    End Sub

    'Mètode que ens mira si la clau de pas inserida és correcta o no.
    Private Sub Boto_AdminMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_AdminMode.Click

        'Definim la clau de pas correcta:
        Dim clauCorrecta As String = "02coord"

        'Obtenim el text del textBox:
        Dim clauDePas As String = TxtB_ClauDePas.Text()

        'Comparem si són iguals
        If clauCorrecta = clauDePas Then
            'Cas que sigui correcte!
            MsgBox("RECORDA: Tingues cura amb els canvis", MsgBoxStyle.Information, "Accés Correcte")

            'Fem visibles els elements
            ObrePanell()

        Else
            MsgBox("Error: La Clau de Pas Inserida és INCORRECTA. NOTA AL TRIBUNAL AVALUADOR: LA CLAU ÉS '02coord' ", MsgBoxStyle.Critical, "Error d'Accés")

            'Fem Invisible tot el panell d'Administració
            TancaPanell()

        End If

        'Eliminem el contingut del camp de text
        TxtB_ClauDePas.Text = ""


    End Sub

    Private Sub ObrePanell()
        'Fem visible tot el panell d'Administració
        GrupAdministracio.Visible = True

        'Fem que sigui visible el Botó de Tancar
        Boto_TancaAdmin.Visible = True
    End Sub

    Private Sub TancaPanell()
        'Fem Invisible tot el panell d'Administració
        GrupAdministracio.Visible = False

        'Fem que sigui visible el Botó de Tancar
        Boto_TancaAdmin.Visible = False
    End Sub

    Private Sub Boto_TancaAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_TancaAdmin.Click
        TancaPanell()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Gestio_EstatNumLlibres.Click
        Gestio_EstatNumLlibres.Show()

    End Sub

    Private Sub Boto_Gestio_DinersAlumnes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Gestio_DinersAlumnes.Click
        Gestio_DinersAlumnes.Show()
    End Sub

    Private Sub Boto_Gestio_LlibresRecollits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Gestio_LlibresRecollits.Click
        Gestio_XifresLlibresRecollitsvb.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Gestio_LlibresRetirats.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Gestio_LlibresSobrants.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Gestio_DadesAlumne.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ProvaBBDD.Show()
    End Sub

    
    Private Sub Boto_Venda_3r_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Venda_3r.Click
        _3r_Venda.Show()
    End Sub

    Private Sub Boto_Venda_1r_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Venda_1r.Click
        _1r_Venda.Show()
    End Sub

    Private Sub Boto_Venda_2n_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_Venda_2n.Click
        _2n_Venda.Show()
    End Sub

    Private Sub Boto_venda_4rt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boto_venda_4rt.Click
        _4rt_Venda.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Admin_EstatNumLlibres.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Admn_DadesGeneralsAlumnes.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Admn_LlibresAlumnes.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Admin_GestioDadesGeneralsLlibres.Show()
    End Sub
End Class