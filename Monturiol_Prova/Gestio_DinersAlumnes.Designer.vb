<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestio_DinersAlumnes
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
        Me.GrupAlumne = New System.Windows.Forms.GroupBox()
        Me.CBox_Alumnes = New System.Windows.Forms.ComboBox()
        Me.Boto_Consulta_Alumne = New System.Windows.Forms.Button()
        Me.Etiqueta_Curs = New System.Windows.Forms.Label()
        Me.GrupGrups = New System.Windows.Forms.GroupBox()
        Me.Boto_Consulta_Grup = New System.Windows.Forms.Button()
        Me.CBox_Grups = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrupCurs.SuspendLayout()
        Me.GrupAlumne.SuspendLayout()
        Me.GrupGrups.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta del Moviment de Diners dels Alumnes"
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
        Me.GrupCurs.TabIndex = 4
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
        'GrupAlumne
        '
        Me.GrupAlumne.Controls.Add(Me.CBox_Alumnes)
        Me.GrupAlumne.Controls.Add(Me.Boto_Consulta_Alumne)
        Me.GrupAlumne.Controls.Add(Me.Etiqueta_Curs)
        Me.GrupAlumne.Location = New System.Drawing.Point(12, 101)
        Me.GrupAlumne.Name = "GrupAlumne"
        Me.GrupAlumne.Size = New System.Drawing.Size(388, 100)
        Me.GrupAlumne.TabIndex = 5
        Me.GrupAlumne.TabStop = False
        Me.GrupAlumne.Text = "Per Alumne:"
        '
        'CBox_Alumnes
        '
        Me.CBox_Alumnes.FormattingEnabled = True
        Me.CBox_Alumnes.Location = New System.Drawing.Point(25, 56)
        Me.CBox_Alumnes.Name = "CBox_Alumnes"
        Me.CBox_Alumnes.Size = New System.Drawing.Size(221, 21)
        Me.CBox_Alumnes.TabIndex = 1
        '
        'Boto_Consulta_Alumne
        '
        Me.Boto_Consulta_Alumne.Location = New System.Drawing.Point(265, 56)
        Me.Boto_Consulta_Alumne.Name = "Boto_Consulta_Alumne"
        Me.Boto_Consulta_Alumne.Size = New System.Drawing.Size(83, 21)
        Me.Boto_Consulta_Alumne.TabIndex = 7
        Me.Boto_Consulta_Alumne.Text = "Consulta!"
        Me.Boto_Consulta_Alumne.UseVisualStyleBackColor = True
        '
        'Etiqueta_Curs
        '
        Me.Etiqueta_Curs.AutoSize = True
        Me.Etiqueta_Curs.Location = New System.Drawing.Point(18, 30)
        Me.Etiqueta_Curs.Name = "Etiqueta_Curs"
        Me.Etiqueta_Curs.Size = New System.Drawing.Size(141, 13)
        Me.Etiqueta_Curs.TabIndex = 0
        Me.Etiqueta_Curs.Text = "Tria un Alumne de 1r d'ESO:"
        '
        'GrupGrups
        '
        Me.GrupGrups.Controls.Add(Me.Boto_Consulta_Grup)
        Me.GrupGrups.Controls.Add(Me.CBox_Grups)
        Me.GrupGrups.Controls.Add(Me.Label3)
        Me.GrupGrups.Location = New System.Drawing.Point(406, 101)
        Me.GrupGrups.Name = "GrupGrups"
        Me.GrupGrups.Size = New System.Drawing.Size(397, 100)
        Me.GrupGrups.TabIndex = 6
        Me.GrupGrups.TabStop = False
        Me.GrupGrups.Text = "Per Cursos:"
        '
        'Boto_Consulta_Grup
        '
        Me.Boto_Consulta_Grup.Location = New System.Drawing.Point(274, 55)
        Me.Boto_Consulta_Grup.Name = "Boto_Consulta_Grup"
        Me.Boto_Consulta_Grup.Size = New System.Drawing.Size(83, 21)
        Me.Boto_Consulta_Grup.TabIndex = 8
        Me.Boto_Consulta_Grup.Text = "Consulta!"
        Me.Boto_Consulta_Grup.UseVisualStyleBackColor = True
        '
        'CBox_Grups
        '
        Me.CBox_Grups.FormattingEnabled = True
        Me.CBox_Grups.Items.AddRange(New Object() {"1r d'ESO", "1r - A d'ESO", "1r - B d'ESO", "2n d'ESO", "2n - A d'ESO", "2n - B d'ESO", "3r d'ESO", "3r - A d'ESO", "3r - B d'ESO", "4rt d'ESO", "4rt - A d'ESO", "4rt - B d'ESO", "4rt - C d'ESO", "1r de BATX", "1r - A de BATX", "1r - B de BATX", "2n de BATX", "2n - A de BATX", "2n - B de BATX"})
        Me.CBox_Grups.Location = New System.Drawing.Point(37, 56)
        Me.CBox_Grups.Name = "CBox_Grups"
        Me.CBox_Grups.Size = New System.Drawing.Size(221, 21)
        Me.CBox_Grups.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tria un Curs Sencer o un Grup:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 288)
        Me.DataGridView1.TabIndex = 8
        '
        'Gestio_DinersAlumnes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 521)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrupGrups)
        Me.Controls.Add(Me.GrupAlumne)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gestio_DinersAlumnes"
        Me.Text = "Gestio_DinersAlumnes"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
        Me.GrupAlumne.ResumeLayout(False)
        Me.GrupAlumne.PerformLayout()
        Me.GrupGrups.ResumeLayout(False)
        Me.GrupGrups.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GrupAlumne As System.Windows.Forms.GroupBox
    Friend WithEvents CBox_Alumnes As System.Windows.Forms.ComboBox
    Friend WithEvents Etiqueta_Curs As System.Windows.Forms.Label
    Friend WithEvents GrupGrups As System.Windows.Forms.GroupBox
    Friend WithEvents CBox_Grups As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Boto_Consulta_Alumne As System.Windows.Forms.Button
    Friend WithEvents Boto_Consulta_Grup As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
