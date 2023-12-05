<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_code2 = New System.Windows.Forms.TextBox()
        Me.txt_datrdv = New System.Windows.Forms.TextBox()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.txt_heure = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.ForeColor = System.Drawing.Color.Red
        Me.lbl_code.Location = New System.Drawing.Point(93, 85)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(51, 16)
        Me.lbl_code.TabIndex = 0
        Me.lbl_code.Text = "code :"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Red
        Me.lbl_date.Location = New System.Drawing.Point(93, 175)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(60, 16)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "datrdv :"
        '
        'txt_code2
        '
        Me.txt_code2.Location = New System.Drawing.Point(207, 82)
        Me.txt_code2.Name = "txt_code2"
        Me.txt_code2.Size = New System.Drawing.Size(100, 20)
        Me.txt_code2.TabIndex = 2
        '
        'txt_datrdv
        '
        Me.txt_datrdv.Location = New System.Drawing.Point(207, 175)
        Me.txt_datrdv.Name = "txt_datrdv"
        Me.txt_datrdv.Size = New System.Drawing.Size(100, 20)
        Me.txt_datrdv.TabIndex = 3
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heure.ForeColor = System.Drawing.Color.Red
        Me.lbl_heure.Location = New System.Drawing.Point(90, 265)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(81, 16)
        Me.lbl_heure.TabIndex = 4
        Me.lbl_heure.Text = "heure rdv :"
        '
        'txt_heure
        '
        Me.txt_heure.Location = New System.Drawing.Point(207, 265)
        Me.txt_heure.Name = "txt_heure"
        Me.txt_heure.Size = New System.Drawing.Size(100, 20)
        Me.txt_heure.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ajouter.Location = New System.Drawing.Point(247, 367)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btn_reset.Location = New System.Drawing.Point(383, 366)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 7
        Me.btn_reset.Text = "reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.txt_heure)
        Me.Controls.Add(Me.lbl_heure)
        Me.Controls.Add(Me.txt_datrdv)
        Me.Controls.Add(Me.txt_code2)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_code)
        Me.Name = "form2"
        Me.Text = "frm_rdvpatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_code2 As TextBox
    Friend WithEvents txt_datrdv As TextBox
    Friend WithEvents lbl_heure As Label
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_reset As Button
End Class
