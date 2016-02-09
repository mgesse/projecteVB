<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestio_DadesAlumne
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
        Me.CBox_Alumnes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtB_Nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtB_CursRec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtB_CursVenda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DadesRecollida = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DadesVenda = New System.Windows.Forms.DataGridView()
        Me.GrupCurs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DadesRecollida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DadesVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dades d'Alumnes"
        '
        'GrupCurs
        '
        Me.GrupCurs.Controls.Add(Me.RBt_6e)
        Me.GrupCurs.Controls.Add(Me.RBt_5e)
        Me.GrupCurs.Controls.Add(Me.RBt_4rt)
        Me.GrupCurs.Controls.Add(Me.RBt_3r)
        Me.GrupCurs.Controls.Add(Me.RBt_2n)
        Me.GrupCurs.Controls.Add(Me.RBt_1r)
        Me.GrupCurs.Location = New System.Drawing.Point(12, 36)
        Me.GrupCurs.Name = "GrupCurs"
        Me.GrupCurs.Size = New System.Drawing.Size(791, 44)
        Me.GrupCurs.TabIndex = 8
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
        'CBox_Alumnes
        '
        Me.CBox_Alumnes.FormattingEnabled = True
        Me.CBox_Alumnes.Location = New System.Drawing.Point(268, 86)
        Me.CBox_Alumnes.Name = "CBox_Alumnes"
        Me.CBox_Alumnes.Size = New System.Drawing.Size(252, 21)
        Me.CBox_Alumnes.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tria l'Alumne del Curs Especificat:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(547, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Consulta!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nom de l'Alumne:"
        '
        'TxtB_Nom
        '
        Me.TxtB_Nom.Location = New System.Drawing.Point(129, 125)
        Me.TxtB_Nom.Name = "TxtB_Nom"
        Me.TxtB_Nom.ReadOnly = True
        Me.TxtB_Nom.Size = New System.Drawing.Size(181, 20)
        Me.TxtB_Nom.TabIndex = 13
        Me.TxtB_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Curs d'Origen: "
        '
        'TxtB_CursRec
        '
        Me.TxtB_CursRec.Location = New System.Drawing.Point(414, 125)
        Me.TxtB_CursRec.Name = "TxtB_CursRec"
        Me.TxtB_CursRec.ReadOnly = True
        Me.TxtB_CursRec.Size = New System.Drawing.Size(88, 20)
        Me.TxtB_CursRec.TabIndex = 15
        Me.TxtB_CursRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(527, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Curs de Destí:"
        '
        'TxtB_CursVenda
        '
        Me.TxtB_CursVenda.Location = New System.Drawing.Point(608, 125)
        Me.TxtB_CursVenda.Name = "TxtB_CursVenda"
        Me.TxtB_CursVenda.ReadOnly = True
        Me.TxtB_CursVenda.Size = New System.Drawing.Size(88, 20)
        Me.TxtB_CursVenda.TabIndex = 17
        Me.TxtB_CursVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DadesRecollida)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 246)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Llista de Llibres del Curs d'Origen (Recollida)"
        '
        'DadesRecollida
        '
        Me.DadesRecollida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DadesRecollida.Location = New System.Drawing.Point(19, 23)
        Me.DadesRecollida.Name = "DadesRecollida"
        Me.DadesRecollida.Size = New System.Drawing.Size(759, 209)
        Me.DadesRecollida.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DadesVenda)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 246)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llista de Llibres del Curs de Destí (Venda)"
        '
        'DadesVenda
        '
        Me.DadesVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DadesVenda.Location = New System.Drawing.Point(16, 23)
        Me.DadesVenda.Name = "DadesVenda"
        Me.DadesVenda.Size = New System.Drawing.Size(759, 209)
        Me.DadesVenda.TabIndex = 1
        '
        'Gestio_DadesAlumne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(816, 661)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtB_CursVenda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtB_CursRec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtB_Nom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBox_Alumnes)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gestio_DadesAlumne"
        Me.Text = "Gestio_DadesAlumne"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DadesRecollida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DadesVenda, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CBox_Alumnes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtB_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtB_CursRec As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtB_CursVenda As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DadesRecollida As System.Windows.Forms.DataGridView
    Friend WithEvents DadesVenda As System.Windows.Forms.DataGridView
End Class
