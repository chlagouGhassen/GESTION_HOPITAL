<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajouterrdv
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.lbl_code2 = New System.Windows.Forms.Label()
        Me.lbl_datrdv = New System.Windows.Forms.Label()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.txt_code2 = New System.Windows.Forms.TextBox()
        Me.txt_heure = New System.Windows.Forms.TextBox()
        Me.txt_datrdv = New System.Windows.Forms.TextBox()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ajouter.Location = New System.Drawing.Point(169, 299)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(75, 35)
        Me.btn_ajouter.TabIndex = 0
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Blue
        Me.btn_reset.Location = New System.Drawing.Point(378, 220)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 26)
        Me.btn_reset.TabIndex = 1
        Me.btn_reset.Text = "reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'lbl_code2
        '
        Me.lbl_code2.AutoSize = True
        Me.lbl_code2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code2.Location = New System.Drawing.Point(74, 58)
        Me.lbl_code2.Name = "lbl_code2"
        Me.lbl_code2.Size = New System.Drawing.Size(55, 16)
        Me.lbl_code2.TabIndex = 2
        Me.lbl_code2.Text = "code2:"
        '
        'lbl_datrdv
        '
        Me.lbl_datrdv.AutoSize = True
        Me.lbl_datrdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datrdv.Location = New System.Drawing.Point(74, 142)
        Me.lbl_datrdv.Name = "lbl_datrdv"
        Me.lbl_datrdv.Size = New System.Drawing.Size(60, 16)
        Me.lbl_datrdv.TabIndex = 3
        Me.lbl_datrdv.Text = "datrdv :"
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heure.Location = New System.Drawing.Point(74, 230)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(55, 16)
        Me.lbl_heure.TabIndex = 4
        Me.lbl_heure.Text = "heure :"
        '
        'txt_code2
        '
        Me.txt_code2.Location = New System.Drawing.Point(144, 58)
        Me.txt_code2.Name = "txt_code2"
        Me.txt_code2.Size = New System.Drawing.Size(100, 20)
        Me.txt_code2.TabIndex = 5
        '
        'txt_heure
        '
        Me.txt_heure.Location = New System.Drawing.Point(144, 223)
        Me.txt_heure.Name = "txt_heure"
        Me.txt_heure.Size = New System.Drawing.Size(100, 20)
        Me.txt_heure.TabIndex = 6
        '
        'txt_datrdv
        '
        Me.txt_datrdv.Location = New System.Drawing.Point(144, 142)
        Me.txt_datrdv.Name = "txt_datrdv"
        Me.txt_datrdv.Size = New System.Drawing.Size(100, 20)
        Me.txt_datrdv.TabIndex = 7
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annuler.ForeColor = System.Drawing.Color.Red
        Me.btn_Annuler.Location = New System.Drawing.Point(312, 299)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(89, 35)
        Me.btn_Annuler.TabIndex = 8
        Me.btn_Annuler.Text = "supprimer"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'frm_ajouterrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gestion_d_hôpital_s.My.Resources.Resources.image_hopital_avif
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.txt_datrdv)
        Me.Controls.Add(Me.txt_heure)
        Me.Controls.Add(Me.txt_code2)
        Me.Controls.Add(Me.lbl_heure)
        Me.Controls.Add(Me.lbl_datrdv)
        Me.Controls.Add(Me.lbl_code2)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Name = "frm_ajouterrdv"
        Me.Text = "ajouterrdv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents lbl_code2 As Label
    Friend WithEvents lbl_datrdv As Label
    Friend WithEvents lbl_heure As Label
    Friend WithEvents txt_code2 As TextBox
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents txt_datrdv As TextBox
    Friend WithEvents btn_Annuler As Button
End Class
