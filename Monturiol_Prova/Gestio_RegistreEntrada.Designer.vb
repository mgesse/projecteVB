﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestio_RegistreEntrada
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrupCurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registre d'Entrada"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(809, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Gestio_RegistreEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 585)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrupCurs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gestio_RegistreEntrada"
        Me.Text = "Gestio_RegistreEntrada"
        Me.GrupCurs.ResumeLayout(False)
        Me.GrupCurs.PerformLayout()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
