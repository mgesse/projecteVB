<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admn_DadesGeneralsAlumnes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrupCurs = New System.Windows.Forms.GroupBox()
        Me.RBt_6e = New System.Windows.Forms.RadioButton()
        Me.RBt_5e = New System.Windows.Forms.RadioButton()
        Me.RBt_4rt = New System.Windows.Forms.RadioButton()
        Me.RBt_3r = New System.Windows.Forms.RadioButton()
        Me.RBt_2n = New System.Windows.Forms.RadioButton()
        Me.RBt_1r = New System.Windows.Forms.RadioButton()
        Me.GrupModifica = New System.Windows.Forms.GroupBox()
        Me.ChkB_Modificacio = New System.Windows.Forms.CheckBox()
        Me.Boto_Modifica = New System.Windows.Forms.Button()
        Me.ChkB_Observacio = New System.Windows.Forms.CheckBox()
        Me.ChkB_Venda = New System.Windows.Forms.CheckBox()
        Me.ChkB_Recollida = New System.Windows.Forms.CheckBox()
        Me.ChkB_Cursos = New System.Windows.Forms.CheckBox()
        Me.TxtB_Observacio = New System.Windows.Forms.TextBox()
        Me.TxtB_ValorVenda = New System.Windows.Forms.TextBox()
        Me.TxtB_ValorRecollida = New System.Windows.Forms.TextBox()
        Me.CBox_CursVen = New System.Windows.Forms.ComboBox()
        Me.CBox_CursRec = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkB_Nom = New System.Windows.Forms.CheckBox()
        Me.TxtB_NomAlumne = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkB_Insrcio = New System.Windows.Forms.CheckBox()
        Me.BotoInsereix = New System.Windows.Forms.Button()
        Me.TxtB_Ins_Observacio = New System.Windows.Forms.TextBox()
        Me.TxtB_Ins_Venda = New System.Windows.Forms.TextBox()
        Me.TxtB_Ins_Recollida = New System.Windows.Forms.TextBox()
        Me.CBox_Ins_Venda = New System.Windows.Forms.ComboBox()
        Me.Cbox_Ins_Recollida = New System.Windows.Forms.ComboBox()
        Me.TxtB_Ins_Nom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GrupCurs.SuspendLayout()
        Me.GrupModifica.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adiministració dels Alumnes"
        '
        'GrupCurs
        '
        Me.GrupCurs.Controls.Add(Me.RBt_6e)
        Me.GrupCurs.Controls.Add(Me.RBt_5e)
        Me.GrupCurs.Controls.Add(Me.RBt_4rt)
        Me.GrupCurs.Controls.Add(Me.RBt_3r)
        Me.GrupCurs.Controls.Add(Me.RBt_2n)
        Me.GrupCurs.Controls.Add(Me.RBt_1r)
        Me.GrupCurs.Location = New System.Drawing.Point(12, 32)
        Me.GrupCurs.Name = "GrupCurs"
        Me.GrupCurs.Size = New System.Drawing.Size(791, 44)
        Me.GrupCurs.TabIndex = 5
        Me.GrupCurs.TabStop = False
        Me.GrupCurs.Text = "Tria un Curs:"
        '
        'RBt_6e
        '
        Me.RBt_6e.AutoSize = True
        Me.RBt_6e.Location = New System.Drawing.Point(668, 19)
        Me.RBt_6e.Name = "RBt_6e"
        Me.RBt_6e.Size = New System.Drawing.Size(83, 17)
        Me.RBt_6e.TabIndex = 5
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
        Me.RBt_5e.Text = "1r de BATX"
        Me.RBt_5e.UseVisualStyleBackColor = True
        '
        'RBt_4rt
        '
        Me.RBt_4rt.AutoSize = True
        Me.RBt_4rt.Location = New System.Drawing.Point(402, 19)
        Me.RBt_4rt.Name = "RBt_4rt"
        Me.RBt_4rt.Size = New System.Drawing.Size(70, 17)
        Me.RBt_4rt.TabIndex = 3
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
        Me.RBt_3r.Text = "3r d'ESO"
        Me.RBt_3r.UseVisualStyleBackColor = True
        '
        'RBt_2n
        '
        Me.RBt_2n.AutoSize = True
        Me.RBt_2n.Location = New System.Drawing.Point(152, 19)
        Me.RBt_2n.Name = "RBt_2n"
        Me.RBt_2n.Size = New System.Drawing.Size(70, 17)
        Me.RBt_2n.TabIndex = 1
        Me.RBt_2n.Text = "2n d'ESO"
        Me.RBt_2n.UseVisualStyleBackColor = True
        '
        'RBt_1r
        '
        Me.RBt_1r.AutoSize = True
        Me.RBt_1r.Checked = True
        Me.RBt_1r.Location = New System.Drawing.Point(25, 19)
        Me.RBt_1r.Name = "RBt_1r"
        Me.RBt_1r.Size = New System.Drawing.Size(67, 17)
        Me.RBt_1r.TabIndex = 0
        Me.RBt_1r.TabStop = True
        Me.RBt_1r.Text = "1r d'ESO"
        Me.RBt_1r.UseVisualStyleBackColor = True
        '
        'GrupModifica
        '
        Me.GrupModifica.Controls.Add(Me.ChkB_Modificacio)
        Me.GrupModifica.Controls.Add(Me.Boto_Modifica)
        Me.GrupModifica.Controls.Add(Me.ChkB_Observacio)
        Me.GrupModifica.Controls.Add(Me.ChkB_Venda)
        Me.GrupModifica.Controls.Add(Me.ChkB_Recollida)
        Me.GrupModifica.Controls.Add(Me.ChkB_Cursos)
        Me.GrupModifica.Controls.Add(Me.TxtB_Observacio)
        Me.GrupModifica.Controls.Add(Me.TxtB_ValorVenda)
        Me.GrupModifica.Controls.Add(Me.TxtB_ValorRecollida)
        Me.GrupModifica.Controls.Add(Me.CBox_CursVen)
        Me.GrupModifica.Controls.Add(Me.CBox_CursRec)
        Me.GrupModifica.Controls.Add(Me.Label8)
        Me.GrupModifica.Controls.Add(Me.ChkB_Nom)
        Me.GrupModifica.Controls.Add(Me.TxtB_NomAlumne)
        Me.GrupModifica.Controls.Add(Me.Label7)
        Me.GrupModifica.Controls.Add(Me.Label6)
        Me.GrupModifica.Controls.Add(Me.Label5)
        Me.GrupModifica.Controls.Add(Me.Label4)
        Me.GrupModifica.Controls.Add(Me.Label3)
        Me.GrupModifica.Controls.Add(Me.Label2)
        Me.GrupModifica.Controls.Add(Me.DataGridView1)
        Me.GrupModifica.Location = New System.Drawing.Point(15, 82)
        Me.GrupModifica.Name = "GrupModifica"
        Me.GrupModifica.Size = New System.Drawing.Size(788, 289)
        Me.GrupModifica.TabIndex = 6
        Me.GrupModifica.TabStop = False
        Me.GrupModifica.Text = "Modifica les Dades dels Alumnes:"
        '
        'ChkB_Modificacio
        '
        Me.ChkB_Modificacio.AutoSize = True
        Me.ChkB_Modificacio.Location = New System.Drawing.Point(19, 266)
        Me.ChkB_Modificacio.Name = "ChkB_Modificacio"
        Me.ChkB_Modificacio.Size = New System.Drawing.Size(183, 17)
        Me.ChkB_Modificacio.TabIndex = 21
        Me.ChkB_Modificacio.Text = "Habilitar la Modificació d'Alumnes"
        Me.ChkB_Modificacio.UseVisualStyleBackColor = True
        '
        'Boto_Modifica
        '
        Me.Boto_Modifica.Location = New System.Drawing.Point(339, 261)
        Me.Boto_Modifica.Name = "Boto_Modifica"
        Me.Boto_Modifica.Size = New System.Drawing.Size(130, 22)
        Me.Boto_Modifica.TabIndex = 19
        Me.Boto_Modifica.Text = "Modifica l'Alumne"
        Me.Boto_Modifica.UseVisualStyleBackColor = True
        '
        'ChkB_Observacio
        '
        Me.ChkB_Observacio.AutoSize = True
        Me.ChkB_Observacio.Location = New System.Drawing.Point(665, 15)
        Me.ChkB_Observacio.Name = "ChkB_Observacio"
        Me.ChkB_Observacio.Size = New System.Drawing.Size(15, 14)
        Me.ChkB_Observacio.TabIndex = 18
        Me.ChkB_Observacio.UseVisualStyleBackColor = True
        '
        'ChkB_Venda
        '
        Me.ChkB_Venda.AutoSize = True
        Me.ChkB_Venda.Location = New System.Drawing.Point(516, 15)
        Me.ChkB_Venda.Name = "ChkB_Venda"
        Me.ChkB_Venda.Size = New System.Drawing.Size(15, 14)
        Me.ChkB_Venda.TabIndex = 17
        Me.ChkB_Venda.UseVisualStyleBackColor = True
        '
        'ChkB_Recollida
        '
        Me.ChkB_Recollida.AutoSize = True
        Me.ChkB_Recollida.Location = New System.Drawing.Point(406, 15)
        Me.ChkB_Recollida.Name = "ChkB_Recollida"
        Me.ChkB_Recollida.Size = New System.Drawing.Size(15, 14)
        Me.ChkB_Recollida.TabIndex = 16
        Me.ChkB_Recollida.UseVisualStyleBackColor = True
        '
        'ChkB_Cursos
        '
        Me.ChkB_Cursos.AutoSize = True
        Me.ChkB_Cursos.Location = New System.Drawing.Point(258, 15)
        Me.ChkB_Cursos.Name = "ChkB_Cursos"
        Me.ChkB_Cursos.Size = New System.Drawing.Size(15, 14)
        Me.ChkB_Cursos.TabIndex = 15
        Me.ChkB_Cursos.UseVisualStyleBackColor = True
        '
        'TxtB_Observacio
        '
        Me.TxtB_Observacio.Enabled = False
        Me.TxtB_Observacio.Location = New System.Drawing.Point(578, 54)
        Me.TxtB_Observacio.Name = "TxtB_Observacio"
        Me.TxtB_Observacio.Size = New System.Drawing.Size(197, 20)
        Me.TxtB_Observacio.TabIndex = 14
        Me.TxtB_Observacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtB_ValorVenda
        '
        Me.TxtB_ValorVenda.Enabled = False
        Me.TxtB_ValorVenda.Location = New System.Drawing.Point(469, 54)
        Me.TxtB_ValorVenda.Name = "TxtB_ValorVenda"
        Me.TxtB_ValorVenda.Size = New System.Drawing.Size(103, 20)
        Me.TxtB_ValorVenda.TabIndex = 13
        Me.TxtB_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtB_ValorRecollida
        '
        Me.TxtB_ValorRecollida.Enabled = False
        Me.TxtB_ValorRecollida.Location = New System.Drawing.Point(360, 53)
        Me.TxtB_ValorRecollida.Name = "TxtB_ValorRecollida"
        Me.TxtB_ValorRecollida.Size = New System.Drawing.Size(103, 20)
        Me.TxtB_ValorRecollida.TabIndex = 12
        Me.TxtB_ValorRecollida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBox_CursVen
        '
        Me.CBox_CursVen.Enabled = False
        Me.CBox_CursVen.FormattingEnabled = True
        Me.CBox_CursVen.Items.AddRange(New Object() {"Sense Curs", "1r d'ESO", "1r d'ESO A", "1r d'ESO B", "2n d'ESO", "2n d'ESO A", "2n d'ESO B", "3r d'ESO", "3r d'ESO A", "3r d'ESO B", "4rt d'ESO", "4rt d'ESO A", "4rt d'ESO B", "4rt d'ESO C", "1r de BATX", "1r BATX A", "1r BATX B", "2n de BATX", "2n BATX A", "2n BATX B"})
        Me.CBox_CursVen.Location = New System.Drawing.Point(267, 53)
        Me.CBox_CursVen.Name = "CBox_CursVen"
        Me.CBox_CursVen.Size = New System.Drawing.Size(87, 21)
        Me.CBox_CursVen.TabIndex = 11
        '
        'CBox_CursRec
        '
        Me.CBox_CursRec.Enabled = False
        Me.CBox_CursRec.FormattingEnabled = True
        Me.CBox_CursRec.Items.AddRange(New Object() {"Sense Curs", "1r d'ESO", "1r d'ESO A", "1r d'ESO B", "2n d'ESO", "2n d'ESO A", "2n d'ESO B", "3r d'ESO", "3r d'ESO A", "3r d'ESO B", "4rt d'ESO", "4rt d'ESO A", "4rt d'ESO B", "4rt d'ESO C", "1r de BATX", "1r BATX A", "1r BATX B", "2n de BATX", "2n BATX A", "2n BATX B"})
        Me.CBox_CursRec.Location = New System.Drawing.Point(174, 53)
        Me.CBox_CursRec.Name = "CBox_CursRec"
        Me.CBox_CursRec.Size = New System.Drawing.Size(87, 21)
        Me.CBox_CursRec.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Modifica:"
        '
        'ChkB_Nom
        '
        Me.ChkB_Nom.AutoSize = True
        Me.ChkB_Nom.Location = New System.Drawing.Point(82, 18)
        Me.ChkB_Nom.Name = "ChkB_Nom"
        Me.ChkB_Nom.Size = New System.Drawing.Size(15, 14)
        Me.ChkB_Nom.TabIndex = 8
        Me.ChkB_Nom.UseVisualStyleBackColor = True
        '
        'TxtB_NomAlumne
        '
        Me.TxtB_NomAlumne.Enabled = False
        Me.TxtB_NomAlumne.Location = New System.Drawing.Point(12, 54)
        Me.TxtB_NomAlumne.Name = "TxtB_NomAlumne"
        Me.TxtB_NomAlumne.Size = New System.Drawing.Size(156, 20)
        Me.TxtB_NomAlumne.TabIndex = 7
        Me.TxtB_NomAlumne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(642, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Observació:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valor Resguard Ven:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valor Resguard Rec:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Curs Venda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Curs Recollida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom Alumne:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(763, 180)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkB_Insrcio)
        Me.GroupBox2.Controls.Add(Me.BotoInsereix)
        Me.GroupBox2.Controls.Add(Me.TxtB_Ins_Observacio)
        Me.GroupBox2.Controls.Add(Me.TxtB_Ins_Venda)
        Me.GroupBox2.Controls.Add(Me.TxtB_Ins_Recollida)
        Me.GroupBox2.Controls.Add(Me.CBox_Ins_Venda)
        Me.GroupBox2.Controls.Add(Me.Cbox_Ins_Recollida)
        Me.GroupBox2.Controls.Add(Me.TxtB_Ins_Nom)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 135)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insereix un Nou Alumne:"
        '
        'ChkB_Insrcio
        '
        Me.ChkB_Insrcio.AutoSize = True
        Me.ChkB_Insrcio.Location = New System.Drawing.Point(21, 28)
        Me.ChkB_Insrcio.Name = "ChkB_Insrcio"
        Me.ChkB_Insrcio.Size = New System.Drawing.Size(166, 17)
        Me.ChkB_Insrcio.TabIndex = 35
        Me.ChkB_Insrcio.Text = "Habilitar la Inserció d'Alumnes"
        Me.ChkB_Insrcio.UseVisualStyleBackColor = True
        '
        'BotoInsereix
        '
        Me.BotoInsereix.Location = New System.Drawing.Point(341, 107)
        Me.BotoInsereix.Name = "BotoInsereix"
        Me.BotoInsereix.Size = New System.Drawing.Size(130, 22)
        Me.BotoInsereix.TabIndex = 34
        Me.BotoInsereix.Text = "Insereix el Nou Alumne!"
        Me.BotoInsereix.UseVisualStyleBackColor = True
        '
        'TxtB_Ins_Observacio
        '
        Me.TxtB_Ins_Observacio.Location = New System.Drawing.Point(580, 77)
        Me.TxtB_Ins_Observacio.Name = "TxtB_Ins_Observacio"
        Me.TxtB_Ins_Observacio.Size = New System.Drawing.Size(197, 20)
        Me.TxtB_Ins_Observacio.TabIndex = 33
        Me.TxtB_Ins_Observacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtB_Ins_Venda
        '
        Me.TxtB_Ins_Venda.Location = New System.Drawing.Point(471, 77)
        Me.TxtB_Ins_Venda.Name = "TxtB_Ins_Venda"
        Me.TxtB_Ins_Venda.Size = New System.Drawing.Size(103, 20)
        Me.TxtB_Ins_Venda.TabIndex = 32
        Me.TxtB_Ins_Venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtB_Ins_Recollida
        '
        Me.TxtB_Ins_Recollida.Location = New System.Drawing.Point(362, 76)
        Me.TxtB_Ins_Recollida.Name = "TxtB_Ins_Recollida"
        Me.TxtB_Ins_Recollida.Size = New System.Drawing.Size(103, 20)
        Me.TxtB_Ins_Recollida.TabIndex = 31
        Me.TxtB_Ins_Recollida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBox_Ins_Venda
        '
        Me.CBox_Ins_Venda.FormattingEnabled = True
        Me.CBox_Ins_Venda.Items.AddRange(New Object() {"Sense Curs", "1r d'ESO", "1r d'ESO A", "1r d'ESO B", "2n d'ESO", "2n d'ESO A", "2n d'ESO B", "3r d'ESO", "3r d'ESO A", "3r d'ESO B", "4rt d'ESO", "4rt d'ESO A", "4rt d'ESO B", "4rt d'ESO C", "1r de BATX", "1r BATX A", "1r BATX B", "2n de BATX", "2n BATX A", "2n BATX B"})
        Me.CBox_Ins_Venda.Location = New System.Drawing.Point(269, 76)
        Me.CBox_Ins_Venda.Name = "CBox_Ins_Venda"
        Me.CBox_Ins_Venda.Size = New System.Drawing.Size(87, 21)
        Me.CBox_Ins_Venda.TabIndex = 30
        '
        'Cbox_Ins_Recollida
        '
        Me.Cbox_Ins_Recollida.FormattingEnabled = True
        Me.Cbox_Ins_Recollida.Items.AddRange(New Object() {"Sense Curs", "1r d'ESO", "1r d'ESO A", "1r d'ESO B", "2n d'ESO", "2n d'ESO A", "2n d'ESO B", "3r d'ESO", "3r d'ESO A", "3r d'ESO B", "4rt d'ESO", "4rt d'ESO A", "4rt d'ESO B", "4rt d'ESO C", "1r de BATX", "1r BATX A", "1r BATX B", "2n de BATX", "2n BATX A", "2n BATX B"})
        Me.Cbox_Ins_Recollida.Location = New System.Drawing.Point(176, 76)
        Me.Cbox_Ins_Recollida.Name = "Cbox_Ins_Recollida"
        Me.Cbox_Ins_Recollida.Size = New System.Drawing.Size(87, 21)
        Me.Cbox_Ins_Recollida.TabIndex = 29
        '
        'TxtB_Ins_Nom
        '
        Me.TxtB_Ins_Nom.Location = New System.Drawing.Point(7, 76)
        Me.TxtB_Ins_Nom.Name = "TxtB_Ins_Nom"
        Me.TxtB_Ins_Nom.Size = New System.Drawing.Size(163, 20)
        Me.TxtB_Ins_Nom.TabIndex = 28
        Me.TxtB_Ins_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(639, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Observació:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(471, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Valor Resguard Ven:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(359, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Valor Resguard Rec:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(280, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Curs Venda:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(185, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Curs Recollida:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Nom Alumne:"
        '
        'Admn_DadesGeneralsAlumnes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 521)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrupModifica)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admn_DadesGeneralsAlumnes"
        Me.Text = "Admn_DadesGeneralsAlumnes"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
        Me.GrupModifica.ResumeLayout(False)
        Me.GrupModifica.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrupCurs As System.Windows.Forms.GroupBox
    Friend WithEvents RBt_6e As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_5e As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_4rt As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_3r As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_2n As System.Windows.Forms.RadioButton
    Friend WithEvents RBt_1r As System.Windows.Forms.RadioButton
    Friend WithEvents GrupModifica As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Boto_Modifica As System.Windows.Forms.Button
    Friend WithEvents ChkB_Observacio As System.Windows.Forms.CheckBox
    Friend WithEvents ChkB_Venda As System.Windows.Forms.CheckBox
    Friend WithEvents ChkB_Recollida As System.Windows.Forms.CheckBox
    Friend WithEvents ChkB_Cursos As System.Windows.Forms.CheckBox
    Friend WithEvents TxtB_Observacio As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_ValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_ValorRecollida As System.Windows.Forms.TextBox
    Friend WithEvents CBox_CursVen As System.Windows.Forms.ComboBox
    Friend WithEvents CBox_CursRec As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkB_Nom As System.Windows.Forms.CheckBox
    Friend WithEvents TxtB_NomAlumne As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BotoInsereix As System.Windows.Forms.Button
    Friend WithEvents TxtB_Ins_Observacio As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_Ins_Venda As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_Ins_Recollida As System.Windows.Forms.TextBox
    Friend WithEvents CBox_Ins_Venda As System.Windows.Forms.ComboBox
    Friend WithEvents Cbox_Ins_Recollida As System.Windows.Forms.ComboBox
    Friend WithEvents TxtB_Ins_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChkB_Modificacio As System.Windows.Forms.CheckBox
    Friend WithEvents ChkB_Insrcio As System.Windows.Forms.CheckBox
End Class
