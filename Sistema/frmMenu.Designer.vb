<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        mnMenu = New MenuStrip()
        CadastrosToolStripMenuItem = New ToolStripMenuItem()
        UsuáriosToolStripMenuItem = New ToolStripMenuItem()
        PessoasToolStripMenuItem = New ToolStripMenuItem()
        mnMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnMenu
        ' 
        mnMenu.Items.AddRange(New ToolStripItem() {CadastrosToolStripMenuItem})
        mnMenu.Location = New Point(0, 0)
        mnMenu.Name = "mnMenu"
        mnMenu.Size = New Size(800, 24)
        mnMenu.TabIndex = 1
        mnMenu.Text = "MenuStrip1"
        ' 
        ' CadastrosToolStripMenuItem
        ' 
        CadastrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UsuáriosToolStripMenuItem, PessoasToolStripMenuItem})
        CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        CadastrosToolStripMenuItem.Size = New Size(71, 20)
        CadastrosToolStripMenuItem.Text = "Cadastros"
        ' 
        ' UsuáriosToolStripMenuItem
        ' 
        UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        UsuáriosToolStripMenuItem.Size = New Size(119, 22)
        UsuáriosToolStripMenuItem.Text = "Usuários"
        ' 
        ' PessoasToolStripMenuItem
        ' 
        PessoasToolStripMenuItem.Name = "PessoasToolStripMenuItem"
        PessoasToolStripMenuItem.Size = New Size(119, 22)
        PessoasToolStripMenuItem.Text = "Pessoas"
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(mnMenu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        IsMdiContainer = True
        MainMenuStrip = mnMenu
        MaximizeBox = False
        Name = "frmMenu"
        Text = "Menu"
        WindowState = FormWindowState.Maximized
        mnMenu.ResumeLayout(False)
        mnMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnMenu As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PessoasToolStripMenuItem As ToolStripMenuItem
End Class
