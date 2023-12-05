<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.txt_utilisateur = New System.Windows.Forms.TextBox()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_mdp
        '
        Me.txt_mdp.Location = New System.Drawing.Point(211, 158)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mdp.Size = New System.Drawing.Size(100, 20)
        Me.txt_mdp.TabIndex = 0
        '
        'txt_utilisateur
        '
        Me.txt_utilisateur.Location = New System.Drawing.Point(211, 72)
        Me.txt_utilisateur.Name = "txt_utilisateur"
        Me.txt_utilisateur.Size = New System.Drawing.Size(100, 20)
        Me.txt_utilisateur.TabIndex = 1
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(69, 72)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(113, 15)
        Me.lbl_nom.TabIndex = 2
        Me.lbl_nom.Text = "Nom utilisateur :"
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mdp.Location = New System.Drawing.Point(69, 163)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(101, 15)
        Me.lbl_mdp.TabIndex = 3
        Me.lbl_mdp.Text = "Mot de passe :"
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(223, 262)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(75, 23)
        Me.btn_valider.TabIndex = 4
        Me.btn_valider.Text = "valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(343, 262)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 23)
        Me.btn_annuler.TabIndex = 5
        Me.btn_annuler.Text = "annuler :"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gestion_d_hôpital_s.My.Resources.Resources.VignetteRH3
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.txt_utilisateur)
        Me.Controls.Add(Me.txt_mdp)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents txt_utilisateur As TextBox
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_mdp As Label
    Friend WithEvents btn_valider As Button
    Friend WithEvents btn_annuler As Button
End Class
