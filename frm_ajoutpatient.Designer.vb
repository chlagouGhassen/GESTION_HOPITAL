<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutpatient
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
        Me.Lbl_code = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.btn_Ajouter = New System.Windows.Forms.Button()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_vider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_code
        '
        Me.Lbl_code.AutoSize = True
        Me.Lbl_code.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_code.Location = New System.Drawing.Point(61, 55)
        Me.Lbl_code.Name = "Lbl_code"
        Me.Lbl_code.Size = New System.Drawing.Size(47, 16)
        Me.Lbl_code.TabIndex = 0
        Me.Lbl_code.Text = "code :"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(61, 132)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(44, 16)
        Me.lbl_nom.TabIndex = 1
        Me.lbl_nom.Text = "nom :"
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prenom.Location = New System.Drawing.Point(61, 219)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(65, 16)
        Me.lbl_prenom.TabIndex = 2
        Me.lbl_prenom.Text = "prenom :"
        '
        'btn_Ajouter
        '
        Me.btn_Ajouter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajouter.ForeColor = System.Drawing.Color.OliveDrab
        Me.btn_Ajouter.Location = New System.Drawing.Point(124, 299)
        Me.btn_Ajouter.Name = "btn_Ajouter"
        Me.btn_Ajouter.Size = New System.Drawing.Size(91, 25)
        Me.btn_Ajouter.TabIndex = 3
        Me.btn_Ajouter.Text = "Ajouter"
        Me.btn_Ajouter.UseVisualStyleBackColor = True
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annuler.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_Annuler.Image = Global.gestion_d_hôpital_s.My.Resources.Resources.image_hopital
        Me.btn_Annuler.Location = New System.Drawing.Point(316, 299)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(91, 25)
        Me.btn_Annuler.TabIndex = 4
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(191, 52)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(74, 20)
        Me.txt_code.TabIndex = 5
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(191, 125)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(74, 20)
        Me.txt_nom.TabIndex = 6
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(191, 212)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(74, 20)
        Me.txt_prenom.TabIndex = 7
        '
        'btn_vider
        '
        Me.btn_vider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vider.ForeColor = System.Drawing.Color.Maroon
        Me.btn_vider.Location = New System.Drawing.Point(383, 212)
        Me.btn_vider.Name = "btn_vider"
        Me.btn_vider.Size = New System.Drawing.Size(86, 23)
        Me.btn_vider.TabIndex = 8
        Me.btn_vider.Text = "vider"
        Me.btn_vider.UseVisualStyleBackColor = True
        '
        'frm_ajoutpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gestion_d_hôpital_s.My.Resources.Resources.image_hopital
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_vider)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.btn_Ajouter)
        Me.Controls.Add(Me.lbl_prenom)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.Lbl_code)
        Me.Name = "frm_ajoutpatient"
        Me.Text = "frm_ajoutpatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_code As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_prenom As Label
    Friend WithEvents btn_Ajouter As Button
    Friend WithEvents btn_Annuler As Button
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_vider As Button
End Class
