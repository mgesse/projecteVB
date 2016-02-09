<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_GestioDadesGeneralsLlibres
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_IdCursLlibre = New System.Windows.Forms.Label()
        Me.lbl_llibreActiu = New System.Windows.Forms.Label()
        Me.lbl_pvpVenda = New System.Windows.Forms.Label()
        Me.lbl_pvpRecollida = New System.Windows.Forms.Label()
        Me.lbl_subtitolLlibre = New System.Windows.Forms.Label()
        Me.lbl_titolLlibre = New System.Windows.Forms.Label()
        Me.RBt_6e = New System.Windows.Forms.RadioButton()
        Me.RBt_5e = New System.Windows.Forms.RadioButton()
        Me.RBt_2n = New System.Windows.Forms.RadioButton()
        Me.RBt_1r = New System.Windows.Forms.RadioButton()
        Me.lbl_NomEditorial = New System.Windows.Forms.Label()
        Me.RBt_4rt = New System.Windows.Forms.RadioButton()
        Me.RBt_3r = New System.Windows.Forms.RadioButton()
        Me.cmb_IdCursLlibre = New System.Windows.Forms.ComboBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.cmb_llibreActiu = New System.Windows.Forms.ComboBox()
        Me.txt_pvpVenda = New System.Windows.Forms.TextBox()
        Me.txt_pvpRecollida = New System.Windows.Forms.TextBox()
        Me.cmb_NomEditorial = New System.Windows.Forms.ComboBox()
        Me.txt_subtitolLlibre = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_titolLlibre = New System.Windows.Forms.TextBox()
        Me.GrupCurs = New System.Windows.Forms.GroupBox()
        Me.txt_InsertarEditorial = New System.Windows.Forms.TextBox()
        Me.Etiqueta_Curs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrupAlumne = New System.Windows.Forms.GroupBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrupCurs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrupAlumne.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(417, 24)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Administració - Dades Generals dels Llibres"
        '
        'lbl_IdCursLlibre
        '
        Me.lbl_IdCursLlibre.AutoSize = True
        Me.lbl_IdCursLlibre.Location = New System.Drawing.Point(717, 112)
        Me.lbl_IdCursLlibre.Name = "lbl_IdCursLlibre"
        Me.lbl_IdCursLlibre.Size = New System.Drawing.Size(62, 13)
        Me.lbl_IdCursLlibre.TabIndex = 60
        Me.lbl_IdCursLlibre.Text = "IdCursLlibre"
        '
        'lbl_llibreActiu
        '
        Me.lbl_llibreActiu.AutoSize = True
        Me.lbl_llibreActiu.Location = New System.Drawing.Point(610, 112)
        Me.lbl_llibreActiu.Name = "lbl_llibreActiu"
        Me.lbl_llibreActiu.Size = New System.Drawing.Size(52, 13)
        Me.lbl_llibreActiu.TabIndex = 59
        Me.lbl_llibreActiu.Text = "llibreActiu"
        '
        'lbl_pvpVenda
        '
        Me.lbl_pvpVenda.AutoSize = True
        Me.lbl_pvpVenda.Location = New System.Drawing.Point(500, 113)
        Me.lbl_pvpVenda.Name = "lbl_pvpVenda"
        Me.lbl_pvpVenda.Size = New System.Drawing.Size(56, 13)
        Me.lbl_pvpVenda.TabIndex = 58
        Me.lbl_pvpVenda.Text = "pvpVenda"
        '
        'lbl_pvpRecollida
        '
        Me.lbl_pvpRecollida.AutoSize = True
        Me.lbl_pvpRecollida.Location = New System.Drawing.Point(396, 113)
        Me.lbl_pvpRecollida.Name = "lbl_pvpRecollida"
        Me.lbl_pvpRecollida.Size = New System.Drawing.Size(69, 13)
        Me.lbl_pvpRecollida.TabIndex = 57
        Me.lbl_pvpRecollida.Text = "pvpRecollida"
        '
        'lbl_subtitolLlibre
        '
        Me.lbl_subtitolLlibre.AutoSize = True
        Me.lbl_subtitolLlibre.Location = New System.Drawing.Point(192, 113)
        Me.lbl_subtitolLlibre.Name = "lbl_subtitolLlibre"
        Me.lbl_subtitolLlibre.Size = New System.Drawing.Size(65, 13)
        Me.lbl_subtitolLlibre.TabIndex = 55
        Me.lbl_subtitolLlibre.Text = "subtitolLlibre"
        '
        'lbl_titolLlibre
        '
        Me.lbl_titolLlibre.AutoSize = True
        Me.lbl_titolLlibre.Location = New System.Drawing.Point(79, 113)
        Me.lbl_titolLlibre.Name = "lbl_titolLlibre"
        Me.lbl_titolLlibre.Size = New System.Drawing.Size(48, 13)
        Me.lbl_titolLlibre.TabIndex = 54
        Me.lbl_titolLlibre.Text = "titolLlibre"
        '
        'RBt_6e
        '
        Me.RBt_6e.AutoSize = True
        Me.RBt_6e.Location = New System.Drawing.Point(668, 19)
        Me.RBt_6e.Name = "RBt_6e"
        Me.RBt_6e.Size = New System.Drawing.Size(83, 17)
        Me.RBt_6e.TabIndex = 5
        Me.RBt_6e.TabStop = True
        Me.RBt_6e.Text = "2n de BATX"
        Me.RBt_6e.UseVisualStyleBackColor = True
        '
        'RBt_5e
        '
        Me.RBt_5e.AutoSize = True
        Me.RBt_5e.Location = New System.Drawing.Point(535, 19)
        Me.RBt_5e.Name = "RBt_5e"
        Me.RBt_5e.Size = New System.Drawing.Size(80, 17)
        Me.RBt_5e.TabIndex = 4
        Me.RBt_5e.TabStop = True
        Me.RBt_5e.Text = "1r de BATX"
        Me.RBt_5e.UseVisualStyleBackColor = True
        '
        'RBt_2n
        '
        Me.RBt_2n.AutoSize = True
        Me.RBt_2n.Location = New System.Drawing.Point(152, 19)
        Me.RBt_2n.Name = "RBt_2n"
        Me.RBt_2n.Size = New System.Drawing.Size(70, 17)
        Me.RBt_2n.TabIndex = 1
        Me.RBt_2n.TabStop = True
        Me.RBt_2n.Text = "2n d'ESO"
        Me.RBt_2n.UseVisualStyleBackColor = True
        '
        'RBt_1r
        '
        Me.RBt_1r.AutoSize = True
        Me.RBt_1r.Location = New System.Drawing.Point(25, 19)
        Me.RBt_1r.Name = "RBt_1r"
        Me.RBt_1r.Size = New System.Drawing.Size(67, 17)
        Me.RBt_1r.TabIndex = 0
        Me.RBt_1r.TabStop = True
        Me.RBt_1r.Text = "1r d'ESO"
        Me.RBt_1r.UseVisualStyleBackColor = True
        '
        'lbl_NomEditorial
        '
        Me.lbl_NomEditorial.AutoSize = True
        Me.lbl_NomEditorial.Location = New System.Drawing.Point(290, 113)
        Me.lbl_NomEditorial.Name = "lbl_NomEditorial"
        Me.lbl_NomEditorial.Size = New System.Drawing.Size(66, 13)
        Me.lbl_NomEditorial.TabIndex = 56
        Me.lbl_NomEditorial.Text = "NomEditorial"
        '
        'RBt_4rt
        '
        Me.RBt_4rt.AutoSize = True
        Me.RBt_4rt.Location = New System.Drawing.Point(402, 19)
        Me.RBt_4rt.Name = "RBt_4rt"
        Me.RBt_4rt.Size = New System.Drawing.Size(70, 17)
        Me.RBt_4rt.TabIndex = 3
        Me.RBt_4rt.TabStop = True
        Me.RBt_4rt.Text = "4rt d'ESO"
        Me.RBt_4rt.UseVisualStyleBackColor = True
        '
        'RBt_3r
        '
        Me.RBt_3r.AutoSize = True
        Me.RBt_3r.Location = New System.Drawing.Point(281, 19)
        Me.RBt_3r.Name = "RBt_3r"
        Me.RBt_3r.Size = New System.Drawing.Size(67, 17)
        Me.RBt_3r.TabIndex = 2
        Me.RBt_3r.TabStop = True
        Me.RBt_3r.Text = "3r d'ESO"
        Me.RBt_3r.UseVisualStyleBackColor = True
        '
        'cmb_IdCursLlibre
        '
        Me.cmb_IdCursLlibre.FormattingEnabled = True
        Me.cmb_IdCursLlibre.Location = New System.Drawing.Point(704, 128)
        Me.cmb_IdCursLlibre.Name = "cmb_IdCursLlibre"
        Me.cmb_IdCursLlibre.Size = New System.Drawing.Size(100, 21)
        Me.cmb_IdCursLlibre.TabIndex = 53
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(265, 56)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(83, 21)
        Me.btn_modificar.TabIndex = 7
        Me.btn_modificar.Text = "Modificar!"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'cmb_llibreActiu
        '
        Me.cmb_llibreActiu.FormattingEnabled = True
        Me.cmb_llibreActiu.Location = New System.Drawing.Point(598, 128)
        Me.cmb_llibreActiu.Name = "cmb_llibreActiu"
        Me.cmb_llibreActiu.Size = New System.Drawing.Size(100, 21)
        Me.cmb_llibreActiu.TabIndex = 52
        '
        'txt_pvpVenda
        '
        Me.txt_pvpVenda.Location = New System.Drawing.Point(492, 129)
        Me.txt_pvpVenda.Name = "txt_pvpVenda"
        Me.txt_pvpVenda.Size = New System.Drawing.Size(100, 20)
        Me.txt_pvpVenda.TabIndex = 51
        '
        'txt_pvpRecollida
        '
        Me.txt_pvpRecollida.Location = New System.Drawing.Point(386, 129)
        Me.txt_pvpRecollida.Name = "txt_pvpRecollida"
        Me.txt_pvpRecollida.Size = New System.Drawing.Size(100, 20)
        Me.txt_pvpRecollida.TabIndex = 50
        '
        'cmb_NomEditorial
        '
        Me.cmb_NomEditorial.FormattingEnabled = True
        Me.cmb_NomEditorial.Location = New System.Drawing.Point(280, 128)
        Me.cmb_NomEditorial.Name = "cmb_NomEditorial"
        Me.cmb_NomEditorial.Size = New System.Drawing.Size(100, 21)
        Me.cmb_NomEditorial.TabIndex = 49
        '
        'txt_subtitolLlibre
        '
        Me.txt_subtitolLlibre.Location = New System.Drawing.Point(174, 129)
        Me.txt_subtitolLlibre.Name = "txt_subtitolLlibre"
        Me.txt_subtitolLlibre.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtitolLlibre.TabIndex = 48
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(25, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modifica una Editorial de 1r d'ESO:"
        '
        'txt_titolLlibre
        '
        Me.txt_titolLlibre.Location = New System.Drawing.Point(68, 129)
        Me.txt_titolLlibre.Name = "txt_titolLlibre"
        Me.txt_titolLlibre.Size = New System.Drawing.Size(100, 20)
        Me.txt_titolLlibre.TabIndex = 47
        '
        'GrupCurs
        '
        Me.GrupCurs.Controls.Add(Me.RBt_6e)
        Me.GrupCurs.Controls.Add(Me.RBt_5e)
        Me.GrupCurs.Controls.Add(Me.RBt_4rt)
        Me.GrupCurs.Controls.Add(Me.RBt_3r)
        Me.GrupCurs.Controls.Add(Me.RBt_2n)
        Me.GrupCurs.Controls.Add(Me.RBt_1r)
        Me.GrupCurs.Location = New System.Drawing.Point(45, 62)
        Me.GrupCurs.Name = "GrupCurs"
        Me.GrupCurs.Size = New System.Drawing.Size(791, 44)
        Me.GrupCurs.TabIndex = 46
        Me.GrupCurs.TabStop = False
        Me.GrupCurs.Text = "Tria un Curs:"
        '
        'txt_InsertarEditorial
        '
        Me.txt_InsertarEditorial.Location = New System.Drawing.Point(25, 56)
        Me.txt_InsertarEditorial.Name = "txt_InsertarEditorial"
        Me.txt_InsertarEditorial.Size = New System.Drawing.Size(221, 20)
        Me.txt_InsertarEditorial.TabIndex = 8
        '
        'Etiqueta_Curs
        '
        Me.Etiqueta_Curs.AutoSize = True
        Me.Etiqueta_Curs.Location = New System.Drawing.Point(18, 30)
        Me.Etiqueta_Curs.Name = "Etiqueta_Curs"
        Me.Etiqueta_Curs.Size = New System.Drawing.Size(162, 13)
        Me.Etiqueta_Curs.TabIndex = 0
        Me.Etiqueta_Curs.Text = "Inserta una editorial de 1r d'ESO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(448, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 100)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editorial:"
        '
        'GrupAlumne
        '
        Me.GrupAlumne.Controls.Add(Me.txt_InsertarEditorial)
        Me.GrupAlumne.Controls.Add(Me.btn_insertar)
        Me.GrupAlumne.Controls.Add(Me.Etiqueta_Curs)
        Me.GrupAlumne.Location = New System.Drawing.Point(45, 392)
        Me.GrupAlumne.Name = "GrupAlumne"
        Me.GrupAlumne.Size = New System.Drawing.Size(388, 100)
        Me.GrupAlumne.TabIndex = 44
        Me.GrupAlumne.TabStop = False
        Me.GrupAlumne.Text = "Editorial:"
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(265, 56)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(83, 21)
        Me.btn_insertar.TabIndex = 7
        Me.btn_insertar.Text = "Inserta!"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 231)
        Me.DataGridView1.TabIndex = 43
        '
        'Admin_GestioDadesGeneralsLlibres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 511)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_IdCursLlibre)
        Me.Controls.Add(Me.lbl_llibreActiu)
        Me.Controls.Add(Me.lbl_pvpVenda)
        Me.Controls.Add(Me.lbl_pvpRecollida)
        Me.Controls.Add(Me.lbl_subtitolLlibre)
        Me.Controls.Add(Me.lbl_titolLlibre)
        Me.Controls.Add(Me.lbl_NomEditorial)
        Me.Controls.Add(Me.cmb_IdCursLlibre)
        Me.Controls.Add(Me.cmb_llibreActiu)
        Me.Controls.Add(Me.txt_pvpVenda)
        Me.Controls.Add(Me.txt_pvpRecollida)
        Me.Controls.Add(Me.cmb_NomEditorial)
        Me.Controls.Add(Me.txt_subtitolLlibre)
        Me.Controls.Add(Me.txt_titolLlibre)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrupAlumne)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Admin_GestioDadesGeneralsLlibres"
        Me.Text = "Admin_GestioDadesGeneralsLlibres"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupAlumne.ResumeLayout(False)
        Me.GrupAlumne.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_IdCursLlibre As System.Windows.Forms.Label
    Friend WithEvents lbl_llibreActiu As System.Windows.Forms.Label
    Friend WithEvents lbl_pvpVenda As System.Windows.Forms.Label
    Friend WithEvents lbl_pvpRecollida As System.Windows.Forms.Label
    Friend WithEvents lbl_subtitolLlibre As System.Windows.Forms.Label
    Friend WithEvents lbl_titolLlibre As System.Windows.Forms.Label
    Friend WithEvents RBt_6e As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_5e As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_2n As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_1r As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_NomEditorial As System.Windows.Forms.Label
    Friend WithEvents RBt_4rt As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_3r As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_IdCursLlibre As System.Windows.Forms.ComboBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents cmb_llibreActiu As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pvpVenda As System.Windows.Forms.TextBox
    Friend WithEvents txt_pvpRecollida As System.Windows.Forms.TextBox
    Friend WithEvents cmb_NomEditorial As System.Windows.Forms.ComboBox
    Friend WithEvents txt_subtitolLlibre As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_titolLlibre As System.Windows.Forms.TextBox
    Friend WithEvents GrupCurs As System.Windows.Forms.GroupBox
    Friend WithEvents txt_InsertarEditorial As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta_Curs As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrupAlumne As System.Windows.Forms.GroupBox
    Friend WithEvents btn_insertar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
