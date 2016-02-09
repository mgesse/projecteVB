Imports MySql.Data.MySqlClient


Public Class ProvaBBDD

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dades de connexió a la Base de Dades, tenir en compte la IP i nom de la BBDD <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres")

        Dim myAdapter As New MySqlDataAdapter("select * from dadesllibre", myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)

        If mydatatable.Rows.Count > 0 Then
            TextBox1.Text = mydatatable.Rows(0).Item("idDadesLlibre")
            TextBox2.Text = mydatatable.Rows(0).Item("titolLlibre")
            TextBox3.Text = mydatatable.Rows(0).Item("subtitolLlibre")
            TextBox4.Text = mydatatable.Rows(0).Item("editorial")
            TextBox5.Text = mydatatable.Rows(0).Item("pvpRecollida")
            TextBox6.Text = mydatatable.Rows(0).Item("pvpVenda")
            TextBox7.Text = mydatatable.Rows(0).Item("llibreActiu")
            TextBox8.Text = mydatatable.Rows(0).Item("idCursLlibre")
        End If

        DataGridView1.DataSource = mydatatable


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dades de connexió a la Base de Dades, tenir en compte la IP i nom de la BBDD <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim myConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=llibres")

        Dim myAdapter As New MySqlDataAdapter("select nomAlumne from alumnes", myConnection)
        Dim mydatatable As New DataTable

        myAdapter.Fill(mydatatable)
        Dim index As Integer = 0
        If mydatatable.Rows.Count > 0 Then
            'TextBox1.Text = mydatatable.Rows(index).Item("titolLlibre")
            ComboBox1.DataSource = mydatatable
            ComboBox1.ValueMember = "nomAlumne"

            index = index + 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim preuIni As Double = TextBox9.Text
        Dim preuMig As Double = preuIni * 0.5 / 10
        TextBox11.Text = preuMig
        TextBox10.Text = Math.Ceiling(preuMig * 100D) / 10D
    End Sub
End Class

