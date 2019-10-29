<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ProcéduresStockéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button10 = New System.Windows.Forms.Button()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.FrmCollaborateursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Fiche_Collabo = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.FrmCollaborateursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcéduresStockéesToolStripMenuItem
        '
        Me.ProcéduresStockéesToolStripMenuItem.Name = "ProcéduresStockéesToolStripMenuItem"
        Me.ProcéduresStockéesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ProcéduresStockéesToolStripMenuItem.Text = "Procédures stockées"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(33, 182)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(160, 47)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Consultation"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrateurToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AdministrateurToolStripMenuItem
        '
        Me.AdministrateurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcéduresStockéesToolStripMenuItem})
        Me.AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        Me.AdministrateurToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AdministrateurToolStripMenuItem.Text = "Administrateur"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Location = New System.Drawing.Point(169, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 617)
        Me.Panel1.TabIndex = 34
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(0, 39)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(250, 57)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "Employés"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Location = New System.Drawing.Point(423, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 729)
        Me.Panel2.TabIndex = 35
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(33, 112)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 47)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Création"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'FrmCollaborateursBindingSource
        '
        Me.FrmCollaborateursBindingSource.DataSource = GetType(ProjetActive.Frm_Collaborateurs)
        '
        'Btn_Fiche_Collabo
        '
        Me.Btn_Fiche_Collabo.BackColor = System.Drawing.Color.White
        Me.Btn_Fiche_Collabo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Fiche_Collabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Fiche_Collabo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Fiche_Collabo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Fiche_Collabo.Location = New System.Drawing.Point(469, 69)
        Me.Btn_Fiche_Collabo.Name = "Btn_Fiche_Collabo"
        Me.Btn_Fiche_Collabo.Size = New System.Drawing.Size(160, 47)
        Me.Btn_Fiche_Collabo.TabIndex = 32
        Me.Btn_Fiche_Collabo.Text = "Collaborateur"
        Me.Btn_Fiche_Collabo.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(799, 85)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(160, 47)
        Me.Button12.TabIndex = 36
        Me.Button12.Text = "Liste"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1795, 25)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1795, 1047)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Fiche_Collabo)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.FrmCollaborateursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProcéduresStockéesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button10 As Button
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents FrmCollaborateursBindingSource As BindingSource
    Friend WithEvents Btn_Fiche_Collabo As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
