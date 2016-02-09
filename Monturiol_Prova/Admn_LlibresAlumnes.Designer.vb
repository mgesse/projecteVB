<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admn_LlibresAlumnes
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DadesVenda = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtB_EstatLlibre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtB_NomAssignatura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtB_NumLlibre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtB_IDLlibre = New System.Windows.Forms.TextBox()
        Me.DadesRecollida = New System.Windows.Forms.DataGridView()
        Me.TxtB_CursVenda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtB_CursRec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtB_Nom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotoConsulta = New System.Windows.Forms.Button()
        Me.CBox_Alumnes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Boto_Elimina = New System.Windows.Forms.Button()
        Me.Rbt_Elimina = New System.Windows.Forms.RadioButton()
        Me.Rbt_Modifica = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtB_NouNumLlibre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBox_Assignatures = New System.Windows.Forms.ComboBox()
        Me.Boto_Modifica = New System.Windows.Forms.Button()
        Me.GrupCurs.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DadesVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DadesRecollida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administració - Relació Llibres - Alumnes"
        '
        'GrupCurs
        '
        Me.GrupCurs.Controls.Add(Me.RBt_6e)
        Me.GrupCurs.Controls.Add(Me.RBt_5e)
        Me.GrupCurs.Controls.Add(Me.RBt_4rt)
        Me.GrupCurs.Controls.Add(Me.RBt_3r)
        Me.GrupCurs.Controls.Add(Me.RBt_2n)
        Me.GrupCurs.Controls.Add(Me.RBt_1r)
        Me.GrupCurs.Location = New System.Drawing.Point(7, 31)
        Me.GrupCurs.Name = "GrupCurs"
        Me.GrupCurs.Size = New System.Drawing.Size(791, 44)
        Me.GrupCurs.TabIndex = 6
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DadesVenda)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 476)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 262)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llista de Llibres del Curs de Destí (Venda)"
        '
        'DadesVenda
        '
        Me.DadesVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DadesVenda.Location = New System.Drawing.Point(6, 19)
        Me.DadesVenda.Name = "DadesVenda"
        Me.DadesVenda.Size = New System.Drawing.Size(759, 209)
        Me.DadesVenda.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Boto_Modifica)
        Me.GroupBox1.Controls.Add(Me.CBox_Assignatures)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtB_NouNumLlibre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Rbt_Modifica)
        Me.GroupBox1.Controls.Add(Me.Rbt_Elimina)
        Me.GroupBox1.Controls.Add(Me.Boto_Elimina)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtB_EstatLlibre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtB_NomAssignatura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtB_NumLlibre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtB_IDLlibre)
        Me.GroupBox1.Controls.Add(Me.DadesRecollida)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 300)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Llista de Llibres del Curs d'Origen (Recollida)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Dades del Llibre Triat"
        '
        'TxtB_EstatLlibre
        '
        Me.TxtB_EstatLlibre.Location = New System.Drawing.Point(231, 73)
        Me.TxtB_EstatLlibre.Name = "TxtB_EstatLlibre"
        Me.TxtB_EstatLlibre.ReadOnly = True
        Me.TxtB_EstatLlibre.Size = New System.Drawing.Size(75, 20)
        Me.TxtB_EstatLlibre.TabIndex = 8
        Me.TxtB_EstatLlibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Estat Llibre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(159, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Assignatura:"
        '
        'TxtB_NomAssignatura
        '
        Me.TxtB_NomAssignatura.Location = New System.Drawing.Point(230, 45)
        Me.TxtB_NomAssignatura.Name = "TxtB_NomAssignatura"
        Me.TxtB_NomAssignatura.ReadOnly = True
        Me.TxtB_NomAssignatura.Size = New System.Drawing.Size(75, 20)
        Me.TxtB_NomAssignatura.TabIndex = 5
        Me.TxtB_NomAssignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Núm. de LLibre:"
        '
        'TxtB_NumLlibre
        '
        Me.TxtB_NumLlibre.Location = New System.Drawing.Point(98, 73)
        Me.TxtB_NumLlibre.Name = "TxtB_NumLlibre"
        Me.TxtB_NumLlibre.ReadOnly = True
        Me.TxtB_NumLlibre.Size = New System.Drawing.Size(55, 20)
        Me.TxtB_NumLlibre.TabIndex = 3
        Me.TxtB_NumLlibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ID del Llibre:"
        '
        'TxtB_IDLlibre
        '
        Me.TxtB_IDLlibre.Location = New System.Drawing.Point(98, 45)
        Me.TxtB_IDLlibre.Name = "TxtB_IDLlibre"
        Me.TxtB_IDLlibre.ReadOnly = True
        Me.TxtB_IDLlibre.Size = New System.Drawing.Size(55, 20)
        Me.TxtB_IDLlibre.TabIndex = 1
        Me.TxtB_IDLlibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DadesRecollida
        '
        Me.DadesRecollida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DadesRecollida.Location = New System.Drawing.Point(6, 103)
        Me.DadesRecollida.Name = "DadesRecollida"
        Me.DadesRecollida.Size = New System.Drawing.Size(778, 191)
        Me.DadesRecollida.TabIndex = 0
        '
        'TxtB_CursVenda
        '
        Me.TxtB_CursVenda.Location = New System.Drawing.Point(647, 132)
        Me.TxtB_CursVenda.Name = "TxtB_CursVenda"
        Me.TxtB_CursVenda.ReadOnly = True
        Me.TxtB_CursVenda.Size = New System.Drawing.Size(88, 20)
        Me.TxtB_CursVenda.TabIndex = 29
        Me.TxtB_CursVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(556, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Curs de Destí:"
        '
        'TxtB_CursRec
        '
        Me.TxtB_CursRec.Location = New System.Drawing.Point(456, 132)
        Me.TxtB_CursRec.Name = "TxtB_CursRec"
        Me.TxtB_CursRec.ReadOnly = True
        Me.TxtB_CursRec.Size = New System.Drawing.Size(88, 20)
        Me.TxtB_CursRec.TabIndex = 27
        Me.TxtB_CursRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Curs d'Origen: "
        '
        'TxtB_Nom
        '
        Me.TxtB_Nom.Location = New System.Drawing.Point(119, 132)
        Me.TxtB_Nom.Name = "TxtB_Nom"
        Me.TxtB_Nom.ReadOnly = True
        Me.TxtB_Nom.Size = New System.Drawing.Size(249, 20)
        Me.TxtB_Nom.TabIndex = 25
        Me.TxtB_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nom de l'Alumne:"
        '
        'BotoConsulta
        '
        Me.BotoConsulta.Location = New System.Drawing.Point(559, 96)
        Me.BotoConsulta.Name = "BotoConsulta"
        Me.BotoConsulta.Size = New System.Drawing.Size(103, 23)
        Me.BotoConsulta.TabIndex = 23
        Me.BotoConsulta.Text = "Consulta!"
        Me.BotoConsulta.UseVisualStyleBackColor = True
        '
        'CBox_Alumnes
        '
        Me.CBox_Alumnes.FormattingEnabled = True
        Me.CBox_Alumnes.Location = New System.Drawing.Point(225, 98)
        Me.CBox_Alumnes.Name = "CBox_Alumnes"
        Me.CBox_Alumnes.Size = New System.Drawing.Size(319, 21)
        Me.CBox_Alumnes.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tira un Alumne del Curs:"
        '
        'Boto_Elimina
        '
        Me.Boto_Elimina.BackColor = System.Drawing.Color.Red
        Me.Boto_Elimina.ForeColor = System.Drawing.Color.White
        Me.Boto_Elimina.Location = New System.Drawing.Point(659, 11)
        Me.Boto_Elimina.Name = "Boto_Elimina"
        Me.Boto_Elimina.Size = New System.Drawing.Size(116, 34)
        Me.Boto_Elimina.TabIndex = 10
        Me.Boto_Elimina.Text = "Elimina la Relació"
        Me.Boto_Elimina.UseVisualStyleBackColor = False
        '
        'Rbt_Elimina
        '
        Me.Rbt_Elimina.AutoSize = True
        Me.Rbt_Elimina.Checked = True
        Me.Rbt_Elimina.Location = New System.Drawing.Point(331, 20)
        Me.Rbt_Elimina.Name = "Rbt_Elimina"
        Me.Rbt_Elimina.Size = New System.Drawing.Size(108, 17)
        Me.Rbt_Elimina.TabIndex = 11
        Me.Rbt_Elimina.TabStop = True
        Me.Rbt_Elimina.Text = "Elimina la Relació"
        Me.Rbt_Elimina.UseVisualStyleBackColor = True
        '
        'Rbt_Modifica
        '
        Me.Rbt_Modifica.AutoSize = True
        Me.Rbt_Modifica.Location = New System.Drawing.Point(331, 46)
        Me.Rbt_Modifica.Name = "Rbt_Modifica"
        Me.Rbt_Modifica.Size = New System.Drawing.Size(115, 17)
        Me.Rbt_Modifica.TabIndex = 12
        Me.Rbt_Modifica.Text = "Modifica la Relació"
        Me.Rbt_Modifica.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(461, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Nou Num Llibre:"
        '
        'TxtB_NouNumLlibre
        '
        Me.TxtB_NouNumLlibre.Location = New System.Drawing.Point(464, 68)
        Me.TxtB_NouNumLlibre.Name = "TxtB_NouNumLlibre"
        Me.TxtB_NouNumLlibre.Size = New System.Drawing.Size(79, 20)
        Me.TxtB_NouNumLlibre.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(551, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tria la Assignatura:"
        '
        'CBox_Assignatures
        '
        Me.CBox_Assignatures.FormattingEnabled = True
        Me.CBox_Assignatures.Location = New System.Drawing.Point(557, 67)
        Me.CBox_Assignatures.Name = "CBox_Assignatures"
        Me.CBox_Assignatures.Size = New System.Drawing.Size(88, 21)
        Me.CBox_Assignatures.TabIndex = 16
        '
        'Boto_Modifica
        '
        Me.Boto_Modifica.BackColor = System.Drawing.Color.DarkOrange
        Me.Boto_Modifica.ForeColor = System.Drawing.Color.White
        Me.Boto_Modifica.Location = New System.Drawing.Point(659, 59)
        Me.Boto_Modifica.Name = "Boto_Modifica"
        Me.Boto_Modifica.Size = New System.Drawing.Size(116, 34)
        Me.Boto_Modifica.TabIndex = 17
        Me.Boto_Modifica.Text = "Modifica la Relació"
        Me.Boto_Modifica.UseVisualStyleBackColor = False
        '
        'Admn_LlibresAlumnes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 750)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtB_CursVenda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtB_CursRec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtB_Nom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BotoConsulta)
        Me.Controls.Add(Me.CBox_Alumnes)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admn_LlibresAlumnes"
        Me.Text = "Admn_LlibresAlumnes"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DadesVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DadesRecollida, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DadesVenda As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DadesRecollida As System.Windows.Forms.DataGridView
    Friend WithEvents TxtB_CursVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtB_CursRec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtB_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BotoConsulta As System.Windows.Forms.Button
    Friend WithEvents CBox_Alumnes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtB_NomAssignatura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtB_NumLlibre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtB_IDLlibre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtB_EstatLlibre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Boto_Elimina As System.Windows.Forms.Button
    Friend WithEvents Boto_Modifica As System.Windows.Forms.Button
    Friend WithEvents CBox_Assignatures As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtB_NouNumLlibre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Rbt_Modifica As System.Windows.Forms.RadioButton
    Friend WithEvents Rbt_Elimina As System.Windows.Forms.RadioButton
End Class
