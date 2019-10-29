<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btn_Connexion = New System.Windows.Forms.Button()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Lbl_1 = New System.Windows.Forms.Label()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Connexion
        '
        Me.Btn_Connexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Connexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Connexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Connexion.ForeColor = System.Drawing.Color.White
        Me.Btn_Connexion.Location = New System.Drawing.Point(179, 281)
        Me.Btn_Connexion.Name = "Btn_Connexion"
        Me.Btn_Connexion.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Connexion.TabIndex = 11
        Me.Btn_Connexion.Text = "Connexion"
        Me.Btn_Connexion.UseVisualStyleBackColor = False
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Password.Location = New System.Drawing.Point(46, 205)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(117, 20)
        Me.Lbl_Password.TabIndex = 10
        Me.Lbl_Password.Text = "Mot de passe"
        Me.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Password
        '
        Me.Txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Password.Location = New System.Drawing.Point(179, 198)
        Me.Txt_Password.Multiline = True
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(221, 27)
        Me.Txt_Password.TabIndex = 9
        Me.Txt_Password.Text = "Jerome54"
        Me.Txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Login
        '
        Me.Lbl_Login.AutoSize = True
        Me.Lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Login.Location = New System.Drawing.Point(91, 146)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Login.TabIndex = 8
        Me.Lbl_Login.Text = "Login"
        Me.Lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_1
        '
        Me.Lbl_1.AutoSize = True
        Me.Lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_1.Location = New System.Drawing.Point(91, 62)
        Me.Lbl_1.Name = "Lbl_1"
        Me.Lbl_1.Size = New System.Drawing.Size(309, 24)
        Me.Lbl_1.TabIndex = 7
        Me.Lbl_1.Text = "Connexion à l'application Active"
        '
        'Txt_Login
        '
        Me.Txt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.Location = New System.Drawing.Point(179, 139)
        Me.Txt_Login.Multiline = True
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(221, 27)
        Me.Txt_Login.TabIndex = 6
        Me.Txt_Login.Text = "jerome.claudel"
        Me.Txt_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 371)
        Me.Controls.Add(Me.Btn_Connexion)
        Me.Controls.Add(Me.Lbl_Password)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Lbl_Login)
        Me.Controls.Add(Me.Lbl_1)
        Me.Controls.Add(Me.Txt_Login)
        Me.Name = "Frm_Principal"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Connexion As Button
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Lbl_Login As Label
    Friend WithEvents Lbl_1 As Label
    Friend WithEvents Txt_Login As TextBox
End Class
