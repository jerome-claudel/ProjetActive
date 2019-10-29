<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Collaborateurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_droite = New System.Windows.Forms.Panel()
        Me.Btn_Creation = New System.Windows.Forms.Button()
        Me.Btn_Consultation = New System.Windows.Forms.Button()
        Me.Panel_Gauche = New System.Windows.Forms.Panel()
        Me.Btn_Employes = New System.Windows.Forms.Button()
        Me.TabCtrl_Collabo = New System.Windows.Forms.TabControl()
        Me.TabP_Collaborateur = New System.Windows.Forms.TabPage()
        Me.GBx_1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Matricule = New System.Windows.Forms.TextBox()
        Me.Lbl_Matricule = New System.Windows.Forms.Label()
        Me.LstB_Prenoms = New System.Windows.Forms.ListBox()
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Btn_Rechercher_Nom = New System.Windows.Forms.Button()
        Me.Cbx_Nom = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GBx_Genre = New System.Windows.Forms.GroupBox()
        Me.RdB_F = New System.Windows.Forms.RadioButton()
        Me.RdB_M = New System.Windows.Forms.RadioButton()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Txt_Telephone = New System.Windows.Forms.TextBox()
        Me.Lbl_Telephone = New System.Windows.Forms.Label()
        Me.Lbl_Ville = New System.Windows.Forms.Label()
        Me.Lbl_Code_Postal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_nulmero = New System.Windows.Forms.Label()
        Me.Cbx_Ville = New System.Windows.Forms.ComboBox()
        Me.Cbx_CodePostal = New System.Windows.Forms.ComboBox()
        Me.Txt_NomVoie = New System.Windows.Forms.TextBox()
        Me.Lbl_Adresse = New System.Windows.Forms.Label()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Lbl_Prenom = New System.Windows.Forms.Label()
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_Valider = New System.Windows.Forms.Button()
        Me.GBx_Contrat = New System.Windows.Forms.GroupBox()
        Me.Lbl_Fonction = New System.Windows.Forms.Label()
        Me.Cbx_Fonction = New System.Windows.Forms.ComboBox()
        Me.Lbl_Statut = New System.Windows.Forms.Label()
        Me.Cbx_Statut = New System.Windows.Forms.ComboBox()
        Me.Dtp_DateFinContrat = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DateFinContrat = New System.Windows.Forms.Label()
        Me.Dtp_DateEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DateEmbauche = New System.Windows.Forms.Label()
        Me.Txt_Salaire = New System.Windows.Forms.TextBox()
        Me.Lbl_Salaire = New System.Windows.Forms.Label()
        Me.TabP_ListeCollabo = New System.Windows.Forms.TabPage()
        Me.Lbl_Filtre = New System.Windows.Forms.Label()
        Me.Txt_Filtre = New System.Windows.Forms.TextBox()
        Me.DGV_Collabo = New System.Windows.Forms.DataGridView()
        Me.Cb_Filtre = New System.Windows.Forms.ComboBox()
        Me.Btn_Filtre = New System.Windows.Forms.Button()
        Me.Btn_Liste = New System.Windows.Forms.Button()
        Me.Btn_Fiche_Collaborateur = New System.Windows.Forms.Button()
        Me.Btn_Modification = New System.Windows.Forms.Button()
        Me.Panel_droite.SuspendLayout()
        Me.Panel_Gauche.SuspendLayout()
        Me.TabCtrl_Collabo.SuspendLayout()
        Me.TabP_Collaborateur.SuspendLayout()
        Me.GBx_1.SuspendLayout()
        Me.GBx_Genre.SuspendLayout()
        Me.GBx_Contrat.SuspendLayout()
        Me.TabP_ListeCollabo.SuspendLayout()
        CType(Me.DGV_Collabo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_droite
        '
        Me.Panel_droite.BackColor = System.Drawing.Color.White
        Me.Panel_droite.Controls.Add(Me.Btn_Modification)
        Me.Panel_droite.Controls.Add(Me.Btn_Creation)
        Me.Panel_droite.Controls.Add(Me.Btn_Consultation)
        Me.Panel_droite.Location = New System.Drawing.Point(259, 42)
        Me.Panel_droite.Name = "Panel_droite"
        Me.Panel_droite.Size = New System.Drawing.Size(219, 761)
        Me.Panel_droite.TabIndex = 31
        '
        'Btn_Creation
        '
        Me.Btn_Creation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Creation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Creation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Creation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Creation.ForeColor = System.Drawing.Color.White
        Me.Btn_Creation.Location = New System.Drawing.Point(33, 112)
        Me.Btn_Creation.Name = "Btn_Creation"
        Me.Btn_Creation.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Creation.TabIndex = 14
        Me.Btn_Creation.Text = "Création"
        Me.Btn_Creation.UseVisualStyleBackColor = False
        '
        'Btn_Consultation
        '
        Me.Btn_Consultation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Consultation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Consultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Consultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consultation.ForeColor = System.Drawing.Color.White
        Me.Btn_Consultation.Location = New System.Drawing.Point(33, 182)
        Me.Btn_Consultation.Name = "Btn_Consultation"
        Me.Btn_Consultation.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Consultation.TabIndex = 13
        Me.Btn_Consultation.Text = "Consultation"
        Me.Btn_Consultation.UseVisualStyleBackColor = False
        '
        'Panel_Gauche
        '
        Me.Panel_Gauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Gauche.Controls.Add(Me.Btn_Employes)
        Me.Panel_Gauche.Location = New System.Drawing.Point(3, 42)
        Me.Panel_Gauche.Name = "Panel_Gauche"
        Me.Panel_Gauche.Size = New System.Drawing.Size(250, 761)
        Me.Panel_Gauche.TabIndex = 32
        '
        'Btn_Employes
        '
        Me.Btn_Employes.BackColor = System.Drawing.Color.White
        Me.Btn_Employes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Employes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Employes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Employes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Employes.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Employes.Name = "Btn_Employes"
        Me.Btn_Employes.Size = New System.Drawing.Size(250, 57)
        Me.Btn_Employes.TabIndex = 12
        Me.Btn_Employes.Text = "Employés"
        Me.Btn_Employes.UseVisualStyleBackColor = False
        '
        'TabCtrl_Collabo
        '
        Me.TabCtrl_Collabo.Controls.Add(Me.TabP_Collaborateur)
        Me.TabCtrl_Collabo.Controls.Add(Me.TabP_ListeCollabo)
        Me.TabCtrl_Collabo.Location = New System.Drawing.Point(484, 91)
        Me.TabCtrl_Collabo.Name = "TabCtrl_Collabo"
        Me.TabCtrl_Collabo.SelectedIndex = 0
        Me.TabCtrl_Collabo.Size = New System.Drawing.Size(914, 712)
        Me.TabCtrl_Collabo.TabIndex = 34
        '
        'TabP_Collaborateur
        '
        Me.TabP_Collaborateur.Controls.Add(Me.Btn_Valider)
        Me.TabP_Collaborateur.Controls.Add(Me.GBx_1)
        Me.TabP_Collaborateur.Controls.Add(Me.Btn_Annuler)
        Me.TabP_Collaborateur.Controls.Add(Me.GBx_Contrat)
        Me.TabP_Collaborateur.Location = New System.Drawing.Point(4, 22)
        Me.TabP_Collaborateur.Name = "TabP_Collaborateur"
        Me.TabP_Collaborateur.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Collaborateur.Size = New System.Drawing.Size(906, 686)
        Me.TabP_Collaborateur.TabIndex = 0
        Me.TabP_Collaborateur.Text = "Collaborateur"
        Me.TabP_Collaborateur.UseVisualStyleBackColor = True
        '
        'GBx_1
        '
        Me.GBx_1.Controls.Add(Me.Txt_Matricule)
        Me.GBx_1.Controls.Add(Me.Lbl_Matricule)
        Me.GBx_1.Controls.Add(Me.LstB_Prenoms)
        Me.GBx_1.Controls.Add(Me.Txt_Numero)
        Me.GBx_1.Controls.Add(Me.Btn_Rechercher_Nom)
        Me.GBx_1.Controls.Add(Me.Cbx_Nom)
        Me.GBx_1.Controls.Add(Me.Button3)
        Me.GBx_1.Controls.Add(Me.GBx_Genre)
        Me.GBx_1.Controls.Add(Me.Txt_Email)
        Me.GBx_1.Controls.Add(Me.Lbl_Email)
        Me.GBx_1.Controls.Add(Me.Txt_Telephone)
        Me.GBx_1.Controls.Add(Me.Lbl_Telephone)
        Me.GBx_1.Controls.Add(Me.Lbl_Ville)
        Me.GBx_1.Controls.Add(Me.Lbl_Code_Postal)
        Me.GBx_1.Controls.Add(Me.Label1)
        Me.GBx_1.Controls.Add(Me.Lbl_nulmero)
        Me.GBx_1.Controls.Add(Me.Cbx_Ville)
        Me.GBx_1.Controls.Add(Me.Cbx_CodePostal)
        Me.GBx_1.Controls.Add(Me.Txt_NomVoie)
        Me.GBx_1.Controls.Add(Me.Lbl_Adresse)
        Me.GBx_1.Controls.Add(Me.Txt_Prenom)
        Me.GBx_1.Controls.Add(Me.Lbl_Prenom)
        Me.GBx_1.Controls.Add(Me.Lbl_Login)
        Me.GBx_1.Location = New System.Drawing.Point(80, 26)
        Me.GBx_1.Name = "GBx_1"
        Me.GBx_1.Size = New System.Drawing.Size(755, 395)
        Me.GBx_1.TabIndex = 10
        Me.GBx_1.TabStop = False
        Me.GBx_1.Text = "Coordonnées"
        '
        'Txt_Matricule
        '
        Me.Txt_Matricule.Enabled = False
        Me.Txt_Matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Matricule.Location = New System.Drawing.Point(335, 48)
        Me.Txt_Matricule.Multiline = True
        Me.Txt_Matricule.Name = "Txt_Matricule"
        Me.Txt_Matricule.Size = New System.Drawing.Size(61, 27)
        Me.Txt_Matricule.TabIndex = 33
        '
        'Lbl_Matricule
        '
        Me.Lbl_Matricule.AutoSize = True
        Me.Lbl_Matricule.Enabled = False
        Me.Lbl_Matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Matricule.Location = New System.Drawing.Point(247, 55)
        Me.Lbl_Matricule.Name = "Lbl_Matricule"
        Me.Lbl_Matricule.Size = New System.Drawing.Size(82, 20)
        Me.Lbl_Matricule.TabIndex = 34
        Me.Lbl_Matricule.Text = "Matricule"
        Me.Lbl_Matricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstB_Prenoms
        '
        Me.LstB_Prenoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstB_Prenoms.FormattingEnabled = True
        Me.LstB_Prenoms.ItemHeight = 20
        Me.LstB_Prenoms.Location = New System.Drawing.Point(426, 90)
        Me.LstB_Prenoms.Name = "LstB_Prenoms"
        Me.LstB_Prenoms.Size = New System.Drawing.Size(173, 64)
        Me.LstB_Prenoms.TabIndex = 32
        Me.LstB_Prenoms.Visible = False
        '
        'Txt_Numero
        '
        Me.Txt_Numero.Enabled = False
        Me.Txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero.Location = New System.Drawing.Point(124, 194)
        Me.Txt_Numero.Multiline = True
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(59, 28)
        Me.Txt_Numero.TabIndex = 31
        '
        'Btn_Rechercher_Nom
        '
        Me.Btn_Rechercher_Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Rechercher_Nom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Rechercher_Nom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rechercher_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rechercher_Nom.ForeColor = System.Drawing.Color.White
        Me.Btn_Rechercher_Nom.Location = New System.Drawing.Point(426, 90)
        Me.Btn_Rechercher_Nom.Name = "Btn_Rechercher_Nom"
        Me.Btn_Rechercher_Nom.Size = New System.Drawing.Size(110, 28)
        Me.Btn_Rechercher_Nom.TabIndex = 15
        Me.Btn_Rechercher_Nom.Text = "Rechercher"
        Me.Btn_Rechercher_Nom.UseVisualStyleBackColor = False
        Me.Btn_Rechercher_Nom.Visible = False
        '
        'Cbx_Nom
        '
        Me.Cbx_Nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Nom.Enabled = False
        Me.Cbx_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Nom.FormattingEnabled = True
        Me.Cbx_Nom.Location = New System.Drawing.Point(124, 91)
        Me.Cbx_Nom.Name = "Cbx_Nom"
        Me.Cbx_Nom.Size = New System.Drawing.Size(296, 28)
        Me.Cbx_Nom.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(305, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(8, 8)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GBx_Genre
        '
        Me.GBx_Genre.Controls.Add(Me.RdB_F)
        Me.GBx_Genre.Controls.Add(Me.RdB_M)
        Me.GBx_Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBx_Genre.Location = New System.Drawing.Point(124, 19)
        Me.GBx_Genre.Name = "GBx_Genre"
        Me.GBx_Genre.Size = New System.Drawing.Size(99, 56)
        Me.GBx_Genre.TabIndex = 28
        Me.GBx_Genre.TabStop = False
        Me.GBx_Genre.Text = "Genre"
        '
        'RdB_F
        '
        Me.RdB_F.AutoSize = True
        Me.RdB_F.Enabled = False
        Me.RdB_F.Location = New System.Drawing.Point(52, 25)
        Me.RdB_F.Name = "RdB_F"
        Me.RdB_F.Size = New System.Drawing.Size(37, 24)
        Me.RdB_F.TabIndex = 29
        Me.RdB_F.TabStop = True
        Me.RdB_F.Text = "F"
        Me.RdB_F.UseVisualStyleBackColor = True
        '
        'RdB_M
        '
        Me.RdB_M.AutoSize = True
        Me.RdB_M.Enabled = False
        Me.RdB_M.Location = New System.Drawing.Point(6, 25)
        Me.RdB_M.Name = "RdB_M"
        Me.RdB_M.Size = New System.Drawing.Size(40, 24)
        Me.RdB_M.TabIndex = 28
        Me.RdB_M.TabStop = True
        Me.RdB_M.Text = "M"
        Me.RdB_M.UseVisualStyleBackColor = True
        '
        'Txt_Email
        '
        Me.Txt_Email.Enabled = False
        Me.Txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(124, 334)
        Me.Txt_Email.Multiline = True
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(333, 27)
        Me.Txt_Email.TabIndex = 26
        Me.Txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Email.Location = New System.Drawing.Point(65, 341)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Email.TabIndex = 27
        Me.Lbl_Email.Text = "Email"
        Me.Lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Telephone
        '
        Me.Txt_Telephone.Enabled = False
        Me.Txt_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telephone.Location = New System.Drawing.Point(124, 288)
        Me.Txt_Telephone.Multiline = True
        Me.Txt_Telephone.Name = "Txt_Telephone"
        Me.Txt_Telephone.Size = New System.Drawing.Size(182, 27)
        Me.Txt_Telephone.TabIndex = 24
        Me.Txt_Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Telephone
        '
        Me.Lbl_Telephone.AutoSize = True
        Me.Lbl_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telephone.Location = New System.Drawing.Point(25, 295)
        Me.Lbl_Telephone.Name = "Lbl_Telephone"
        Me.Lbl_Telephone.Size = New System.Drawing.Size(93, 20)
        Me.Lbl_Telephone.TabIndex = 25
        Me.Lbl_Telephone.Text = "Téléphone"
        Me.Lbl_Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ville
        '
        Me.Lbl_Ville.AutoSize = True
        Me.Lbl_Ville.Location = New System.Drawing.Point(271, 225)
        Me.Lbl_Ville.Name = "Lbl_Ville"
        Me.Lbl_Ville.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Ville.TabIndex = 23
        Me.Lbl_Ville.Text = "Ville"
        '
        'Lbl_Code_Postal
        '
        Me.Lbl_Code_Postal.AutoSize = True
        Me.Lbl_Code_Postal.Location = New System.Drawing.Point(126, 225)
        Me.Lbl_Code_Postal.Name = "Lbl_Code_Postal"
        Me.Lbl_Code_Postal.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Code_Postal.TabIndex = 22
        Me.Lbl_Code_Postal.Text = "Code Postal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nom de voie"
        '
        'Lbl_nulmero
        '
        Me.Lbl_nulmero.AutoSize = True
        Me.Lbl_nulmero.Location = New System.Drawing.Point(124, 178)
        Me.Lbl_nulmero.Name = "Lbl_nulmero"
        Me.Lbl_nulmero.Size = New System.Drawing.Size(19, 13)
        Me.Lbl_nulmero.TabIndex = 19
        Me.Lbl_nulmero.Text = "N°"
        '
        'Cbx_Ville
        '
        Me.Cbx_Ville.Enabled = False
        Me.Cbx_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Ville.FormattingEnabled = True
        Me.Cbx_Ville.Location = New System.Drawing.Point(271, 241)
        Me.Cbx_Ville.Name = "Cbx_Ville"
        Me.Cbx_Ville.Size = New System.Drawing.Size(328, 28)
        Me.Cbx_Ville.TabIndex = 18
        '
        'Cbx_CodePostal
        '
        Me.Cbx_CodePostal.Enabled = False
        Me.Cbx_CodePostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_CodePostal.FormattingEnabled = True
        Me.Cbx_CodePostal.Location = New System.Drawing.Point(124, 241)
        Me.Cbx_CodePostal.Name = "Cbx_CodePostal"
        Me.Cbx_CodePostal.Size = New System.Drawing.Size(138, 28)
        Me.Cbx_CodePostal.TabIndex = 17
        '
        'Txt_NomVoie
        '
        Me.Txt_NomVoie.Enabled = False
        Me.Txt_NomVoie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NomVoie.Location = New System.Drawing.Point(193, 194)
        Me.Txt_NomVoie.Multiline = True
        Me.Txt_NomVoie.Name = "Txt_NomVoie"
        Me.Txt_NomVoie.Size = New System.Drawing.Size(406, 28)
        Me.Txt_NomVoie.TabIndex = 16
        Me.Txt_NomVoie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Adresse
        '
        Me.Lbl_Adresse.AutoSize = True
        Me.Lbl_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Adresse.Location = New System.Drawing.Point(43, 192)
        Me.Lbl_Adresse.Name = "Lbl_Adresse"
        Me.Lbl_Adresse.Size = New System.Drawing.Size(75, 20)
        Me.Lbl_Adresse.TabIndex = 13
        Me.Lbl_Adresse.Text = "Adresse"
        Me.Lbl_Adresse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Enabled = False
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Prenom.Location = New System.Drawing.Point(124, 138)
        Me.Txt_Prenom.Multiline = True
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(262, 27)
        Me.Txt_Prenom.TabIndex = 10
        '
        'Lbl_Prenom
        '
        Me.Lbl_Prenom.AutoSize = True
        Me.Lbl_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Prenom.Location = New System.Drawing.Point(48, 145)
        Me.Lbl_Prenom.Name = "Lbl_Prenom"
        Me.Lbl_Prenom.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_Prenom.TabIndex = 11
        Me.Lbl_Prenom.Text = "Prénom"
        Me.Lbl_Prenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Login
        '
        Me.Lbl_Login.AutoSize = True
        Me.Lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Login.Location = New System.Drawing.Point(73, 101)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(45, 20)
        Me.Lbl_Login.TabIndex = 9
        Me.Lbl_Login.Text = "Nom"
        Me.Lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.ForeColor = System.Drawing.Color.White
        Me.Btn_Annuler.Location = New System.Drawing.Point(675, 623)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Annuler.TabIndex = 16
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = False
        Me.Btn_Annuler.Visible = False
        '
        'Btn_Valider
        '
        Me.Btn_Valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Valider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Valider.ForeColor = System.Drawing.Color.White
        Me.Btn_Valider.Location = New System.Drawing.Point(490, 623)
        Me.Btn_Valider.Name = "Btn_Valider"
        Me.Btn_Valider.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Valider.TabIndex = 15
        Me.Btn_Valider.Text = "Valider"
        Me.Btn_Valider.UseVisualStyleBackColor = False
        Me.Btn_Valider.Visible = False
        '
        'GBx_Contrat
        '
        Me.GBx_Contrat.Controls.Add(Me.Lbl_Fonction)
        Me.GBx_Contrat.Controls.Add(Me.Cbx_Fonction)
        Me.GBx_Contrat.Controls.Add(Me.Lbl_Statut)
        Me.GBx_Contrat.Controls.Add(Me.Cbx_Statut)
        Me.GBx_Contrat.Controls.Add(Me.Dtp_DateFinContrat)
        Me.GBx_Contrat.Controls.Add(Me.Lbl_DateFinContrat)
        Me.GBx_Contrat.Controls.Add(Me.Dtp_DateEmbauche)
        Me.GBx_Contrat.Controls.Add(Me.Lbl_DateEmbauche)
        Me.GBx_Contrat.Controls.Add(Me.Txt_Salaire)
        Me.GBx_Contrat.Controls.Add(Me.Lbl_Salaire)
        Me.GBx_Contrat.Location = New System.Drawing.Point(80, 437)
        Me.GBx_Contrat.Name = "GBx_Contrat"
        Me.GBx_Contrat.Size = New System.Drawing.Size(755, 180)
        Me.GBx_Contrat.TabIndex = 11
        Me.GBx_Contrat.TabStop = False
        Me.GBx_Contrat.Text = "Contrat"
        '
        'Lbl_Fonction
        '
        Me.Lbl_Fonction.AutoSize = True
        Me.Lbl_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fonction.Location = New System.Drawing.Point(386, 87)
        Me.Lbl_Fonction.Name = "Lbl_Fonction"
        Me.Lbl_Fonction.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_Fonction.TabIndex = 21
        Me.Lbl_Fonction.Text = "Fonction"
        Me.Lbl_Fonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbx_Fonction
        '
        Me.Cbx_Fonction.Enabled = False
        Me.Cbx_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Fonction.FormattingEnabled = True
        Me.Cbx_Fonction.Location = New System.Drawing.Point(471, 80)
        Me.Cbx_Fonction.Name = "Cbx_Fonction"
        Me.Cbx_Fonction.Size = New System.Drawing.Size(269, 28)
        Me.Cbx_Fonction.TabIndex = 20
        '
        'Lbl_Statut
        '
        Me.Lbl_Statut.AutoSize = True
        Me.Lbl_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Statut.Location = New System.Drawing.Point(406, 38)
        Me.Lbl_Statut.Name = "Lbl_Statut"
        Me.Lbl_Statut.Size = New System.Drawing.Size(59, 20)
        Me.Lbl_Statut.TabIndex = 19
        Me.Lbl_Statut.Text = "Statut"
        Me.Lbl_Statut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbx_Statut
        '
        Me.Cbx_Statut.Enabled = False
        Me.Cbx_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Statut.FormattingEnabled = True
        Me.Cbx_Statut.Location = New System.Drawing.Point(471, 30)
        Me.Cbx_Statut.Name = "Cbx_Statut"
        Me.Cbx_Statut.Size = New System.Drawing.Size(87, 28)
        Me.Cbx_Statut.TabIndex = 18
        '
        'Dtp_DateFinContrat
        '
        Me.Dtp_DateFinContrat.Enabled = False
        Me.Dtp_DateFinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateFinContrat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_DateFinContrat.Location = New System.Drawing.Point(196, 81)
        Me.Dtp_DateFinContrat.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.Dtp_DateFinContrat.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.Dtp_DateFinContrat.Name = "Dtp_DateFinContrat"
        Me.Dtp_DateFinContrat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtp_DateFinContrat.Size = New System.Drawing.Size(140, 26)
        Me.Dtp_DateFinContrat.TabIndex = 17
        Me.Dtp_DateFinContrat.Visible = False
        '
        'Lbl_DateFinContrat
        '
        Me.Lbl_DateFinContrat.AutoSize = True
        Me.Lbl_DateFinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DateFinContrat.Location = New System.Drawing.Point(30, 87)
        Me.Lbl_DateFinContrat.Name = "Lbl_DateFinContrat"
        Me.Lbl_DateFinContrat.Size = New System.Drawing.Size(160, 20)
        Me.Lbl_DateFinContrat.TabIndex = 16
        Me.Lbl_DateFinContrat.Text = "Date fin de contrat"
        Me.Lbl_DateFinContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dtp_DateEmbauche
        '
        Me.Dtp_DateEmbauche.Enabled = False
        Me.Dtp_DateEmbauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DateEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_DateEmbauche.Location = New System.Drawing.Point(196, 32)
        Me.Dtp_DateEmbauche.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.Dtp_DateEmbauche.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Dtp_DateEmbauche.Name = "Dtp_DateEmbauche"
        Me.Dtp_DateEmbauche.Size = New System.Drawing.Size(140, 26)
        Me.Dtp_DateEmbauche.TabIndex = 15
        '
        'Lbl_DateEmbauche
        '
        Me.Lbl_DateEmbauche.AutoSize = True
        Me.Lbl_DateEmbauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DateEmbauche.Location = New System.Drawing.Point(40, 38)
        Me.Lbl_DateEmbauche.Name = "Lbl_DateEmbauche"
        Me.Lbl_DateEmbauche.Size = New System.Drawing.Size(150, 20)
        Me.Lbl_DateEmbauche.TabIndex = 14
        Me.Lbl_DateEmbauche.Text = "Date d'embauche"
        Me.Lbl_DateEmbauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Salaire
        '
        Me.Txt_Salaire.Enabled = False
        Me.Txt_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Salaire.Location = New System.Drawing.Point(471, 134)
        Me.Txt_Salaire.Multiline = True
        Me.Txt_Salaire.Name = "Txt_Salaire"
        Me.Txt_Salaire.Size = New System.Drawing.Size(157, 24)
        Me.Txt_Salaire.TabIndex = 12
        Me.Txt_Salaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Salaire
        '
        Me.Lbl_Salaire.AutoSize = True
        Me.Lbl_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Salaire.Location = New System.Drawing.Point(400, 138)
        Me.Lbl_Salaire.Name = "Lbl_Salaire"
        Me.Lbl_Salaire.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_Salaire.TabIndex = 13
        Me.Lbl_Salaire.Text = "Salaire"
        Me.Lbl_Salaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabP_ListeCollabo
        '
        Me.TabP_ListeCollabo.Controls.Add(Me.Lbl_Filtre)
        Me.TabP_ListeCollabo.Controls.Add(Me.Txt_Filtre)
        Me.TabP_ListeCollabo.Controls.Add(Me.DGV_Collabo)
        Me.TabP_ListeCollabo.Controls.Add(Me.Cb_Filtre)
        Me.TabP_ListeCollabo.Controls.Add(Me.Btn_Filtre)
        Me.TabP_ListeCollabo.Location = New System.Drawing.Point(4, 22)
        Me.TabP_ListeCollabo.Name = "TabP_ListeCollabo"
        Me.TabP_ListeCollabo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_ListeCollabo.Size = New System.Drawing.Size(906, 686)
        Me.TabP_ListeCollabo.TabIndex = 1
        Me.TabP_ListeCollabo.Text = "Liste"
        Me.TabP_ListeCollabo.UseVisualStyleBackColor = True
        '
        'Lbl_Filtre
        '
        Me.Lbl_Filtre.AutoSize = True
        Me.Lbl_Filtre.Location = New System.Drawing.Point(103, 38)
        Me.Lbl_Filtre.Name = "Lbl_Filtre"
        Me.Lbl_Filtre.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_Filtre.TabIndex = 33
        Me.Lbl_Filtre.Text = "Filtrer par"
        '
        'Txt_Filtre
        '
        Me.Txt_Filtre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtre.Location = New System.Drawing.Point(390, 55)
        Me.Txt_Filtre.Multiline = True
        Me.Txt_Filtre.Name = "Txt_Filtre"
        Me.Txt_Filtre.Size = New System.Drawing.Size(262, 27)
        Me.Txt_Filtre.TabIndex = 32
        Me.Txt_Filtre.Text = "claudel"
        '
        'DGV_Collabo
        '
        Me.DGV_Collabo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGV_Collabo.ColumnHeadersHeight = 30
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Collabo.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Collabo.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Collabo.Location = New System.Drawing.Point(67, 96)
        Me.DGV_Collabo.Name = "DGV_Collabo"
        Me.DGV_Collabo.RowHeadersVisible = False
        Me.DGV_Collabo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DGV_Collabo.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Collabo.RowTemplate.DividerHeight = 1
        Me.DGV_Collabo.RowTemplate.Height = 30
        Me.DGV_Collabo.Size = New System.Drawing.Size(781, 606)
        Me.DGV_Collabo.TabIndex = 0
        '
        'Cb_Filtre
        '
        Me.Cb_Filtre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cb_Filtre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Filtre.FormattingEnabled = True
        Me.Cb_Filtre.Location = New System.Drawing.Point(106, 54)
        Me.Cb_Filtre.Name = "Cb_Filtre"
        Me.Cb_Filtre.Size = New System.Drawing.Size(257, 28)
        Me.Cb_Filtre.TabIndex = 31
        Me.Cb_Filtre.Text = "Nom"
        '
        'Btn_Filtre
        '
        Me.Btn_Filtre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Filtre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Filtre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Filtre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Filtre.ForeColor = System.Drawing.Color.White
        Me.Btn_Filtre.Location = New System.Drawing.Point(674, 44)
        Me.Btn_Filtre.Name = "Btn_Filtre"
        Me.Btn_Filtre.Size = New System.Drawing.Size(160, 38)
        Me.Btn_Filtre.TabIndex = 16
        Me.Btn_Filtre.Text = "Filtrer"
        Me.Btn_Filtre.UseVisualStyleBackColor = False
        '
        'Btn_Liste
        '
        Me.Btn_Liste.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Liste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Liste.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Liste.ForeColor = System.Drawing.Color.White
        Me.Btn_Liste.Location = New System.Drawing.Point(650, 38)
        Me.Btn_Liste.Name = "Btn_Liste"
        Me.Btn_Liste.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Liste.TabIndex = 35
        Me.Btn_Liste.Text = "Liste"
        Me.Btn_Liste.UseVisualStyleBackColor = False
        '
        'Btn_Fiche_Collaborateur
        '
        Me.Btn_Fiche_Collaborateur.BackColor = System.Drawing.Color.White
        Me.Btn_Fiche_Collaborateur.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Fiche_Collaborateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Fiche_Collaborateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Fiche_Collaborateur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Fiche_Collaborateur.Location = New System.Drawing.Point(484, 38)
        Me.Btn_Fiche_Collaborateur.Name = "Btn_Fiche_Collaborateur"
        Me.Btn_Fiche_Collaborateur.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Fiche_Collaborateur.TabIndex = 38
        Me.Btn_Fiche_Collaborateur.Text = "Collaborateur"
        Me.Btn_Fiche_Collaborateur.UseVisualStyleBackColor = False
        '
        'Btn_Modification
        '
        Me.Btn_Modification.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Modification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Modification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modification.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modification.ForeColor = System.Drawing.Color.White
        Me.Btn_Modification.Location = New System.Drawing.Point(33, 256)
        Me.Btn_Modification.Name = "Btn_Modification"
        Me.Btn_Modification.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Modification.TabIndex = 16
        Me.Btn_Modification.Text = "Modification"
        Me.Btn_Modification.UseVisualStyleBackColor = False
        Me.Btn_Modification.Visible = False
        '
        'Frm_Collaborateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 824)
        Me.Controls.Add(Me.Btn_Fiche_Collaborateur)
        Me.Controls.Add(Me.Btn_Liste)
        Me.Controls.Add(Me.TabCtrl_Collabo)
        Me.Controls.Add(Me.Panel_Gauche)
        Me.Controls.Add(Me.Panel_droite)
        Me.Name = "Frm_Collaborateurs"
        Me.Text = "Collaborateurs"
        Me.Panel_droite.ResumeLayout(False)
        Me.Panel_Gauche.ResumeLayout(False)
        Me.TabCtrl_Collabo.ResumeLayout(False)
        Me.TabP_Collaborateur.ResumeLayout(False)
        Me.GBx_1.ResumeLayout(False)
        Me.GBx_1.PerformLayout()
        Me.GBx_Genre.ResumeLayout(False)
        Me.GBx_Genre.PerformLayout()
        Me.GBx_Contrat.ResumeLayout(False)
        Me.GBx_Contrat.PerformLayout()
        Me.TabP_ListeCollabo.ResumeLayout(False)
        Me.TabP_ListeCollabo.PerformLayout()
        CType(Me.DGV_Collabo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_droite As Panel
    Friend WithEvents Btn_Creation As Button
    Friend WithEvents Btn_Consultation As Button
    Friend WithEvents Panel_Gauche As Panel
    Friend WithEvents Btn_Employes As Button
    Friend WithEvents TabCtrl_Collabo As TabControl
    Friend WithEvents TabP_Collaborateur As TabPage
    Friend WithEvents GBx_1 As GroupBox
    Friend WithEvents Txt_Matricule As TextBox
    Friend WithEvents Lbl_Matricule As Label
    Friend WithEvents LstB_Prenoms As ListBox
    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents Btn_Rechercher_Nom As Button
    Friend WithEvents Cbx_Nom As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GBx_Genre As GroupBox
    Friend WithEvents RdB_F As RadioButton
    Friend WithEvents RdB_M As RadioButton
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Txt_Telephone As TextBox
    Friend WithEvents Lbl_Telephone As Label
    Friend WithEvents Lbl_Ville As Label
    Friend WithEvents Lbl_Code_Postal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_nulmero As Label
    Friend WithEvents Cbx_Ville As ComboBox
    Friend WithEvents Cbx_CodePostal As ComboBox
    Friend WithEvents Txt_NomVoie As TextBox
    Friend WithEvents Lbl_Adresse As Label
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Lbl_Prenom As Label
    Friend WithEvents Lbl_Login As Label
    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents Btn_Valider As Button
    Friend WithEvents GBx_Contrat As GroupBox
    Friend WithEvents Lbl_Fonction As Label
    Friend WithEvents Cbx_Fonction As ComboBox
    Friend WithEvents Lbl_Statut As Label
    Friend WithEvents Cbx_Statut As ComboBox
    Friend WithEvents Dtp_DateFinContrat As DateTimePicker
    Friend WithEvents Lbl_DateFinContrat As Label
    Friend WithEvents Dtp_DateEmbauche As DateTimePicker
    Friend WithEvents Lbl_DateEmbauche As Label
    Friend WithEvents Txt_Salaire As TextBox
    Friend WithEvents Lbl_Salaire As Label
    Friend WithEvents TabP_ListeCollabo As TabPage
    Friend WithEvents Lbl_Filtre As Label
    Friend WithEvents Txt_Filtre As TextBox
    Friend WithEvents DGV_Collabo As DataGridView
    Friend WithEvents Cb_Filtre As ComboBox
    Friend WithEvents Btn_Filtre As Button
    Friend WithEvents Btn_Liste As Button
    Friend WithEvents Btn_Fiche_Collaborateur As Button
    Friend WithEvents Btn_Modification As Button
End Class
