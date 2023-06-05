<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroUsuarios
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
        grbCodigo = New GroupBox()
        txtCodigo = New TextBox()
        grbNome = New GroupBox()
        txtNome = New TextBox()
        grbSenha = New GroupBox()
        txtSenha = New TextBox()
        picImagem = New PictureBox()
        btnNovo = New Button()
        btnAlterar = New Button()
        btnGravar = New Button()
        btnLimpar = New Button()
        btnExcluir = New Button()
        btnConsultar = New Button()
        btnFechar = New Button()
        ofdFoto = New OpenFileDialog()
        grbCodigo.SuspendLayout()
        grbNome.SuspendLayout()
        grbSenha.SuspendLayout()
        CType(picImagem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grbCodigo
        ' 
        grbCodigo.Controls.Add(txtCodigo)
        grbCodigo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        grbCodigo.Location = New Point(12, 12)
        grbCodigo.Name = "grbCodigo"
        grbCodigo.Size = New Size(114, 60)
        grbCodigo.TabIndex = 0
        grbCodigo.TabStop = False
        grbCodigo.Text = "Códgio"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(6, 22)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 29)
        txtCodigo.TabIndex = 0
        ' 
        ' grbNome
        ' 
        grbNome.Controls.Add(txtNome)
        grbNome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        grbNome.Location = New Point(132, 12)
        grbNome.Name = "grbNome"
        grbNome.Size = New Size(210, 60)
        grbNome.TabIndex = 1
        grbNome.TabStop = False
        grbNome.Text = "Nome"
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(6, 22)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(196, 29)
        txtNome.TabIndex = 0
        ' 
        ' grbSenha
        ' 
        grbSenha.Controls.Add(txtSenha)
        grbSenha.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        grbSenha.Location = New Point(348, 12)
        grbSenha.Name = "grbSenha"
        grbSenha.Size = New Size(210, 60)
        grbSenha.TabIndex = 2
        grbSenha.TabStop = False
        grbSenha.Text = "Senha"
        ' 
        ' txtSenha
        ' 
        txtSenha.Location = New Point(6, 22)
        txtSenha.Name = "txtSenha"
        txtSenha.Size = New Size(196, 29)
        txtSenha.TabIndex = 0
        ' 
        ' picImagem
        ' 
        picImagem.BorderStyle = BorderStyle.Fixed3D
        picImagem.Image = My.Resources.Resources.perfil
        picImagem.Location = New Point(579, 12)
        picImagem.Name = "picImagem"
        picImagem.Size = New Size(200, 190)
        picImagem.SizeMode = PictureBoxSizeMode.StretchImage
        picImagem.TabIndex = 3
        picImagem.TabStop = False
        ' 
        ' btnNovo
        ' 
        btnNovo.BackgroundImage = My.Resources.Resources.novo_registro
        btnNovo.BackgroundImageLayout = ImageLayout.None
        btnNovo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNovo.Location = New Point(12, 84)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(130, 60)
        btnNovo.TabIndex = 4
        btnNovo.Text = "Novo"
        btnNovo.TextAlign = ContentAlignment.MiddleRight
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnAlterar
        ' 
        btnAlterar.BackgroundImage = My.Resources.Resources.Alterar
        btnAlterar.BackgroundImageLayout = ImageLayout.None
        btnAlterar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAlterar.Location = New Point(153, 84)
        btnAlterar.Name = "btnAlterar"
        btnAlterar.Size = New Size(130, 60)
        btnAlterar.TabIndex = 5
        btnAlterar.Text = "Alterar"
        btnAlterar.TextAlign = ContentAlignment.MiddleRight
        btnAlterar.UseVisualStyleBackColor = True
        ' 
        ' btnGravar
        ' 
        btnGravar.BackgroundImage = My.Resources.Resources.salvar
        btnGravar.BackgroundImageLayout = ImageLayout.None
        btnGravar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGravar.Location = New Point(153, 153)
        btnGravar.Name = "btnGravar"
        btnGravar.Size = New Size(130, 60)
        btnGravar.TabIndex = 6
        btnGravar.Text = "Gravar"
        btnGravar.TextAlign = ContentAlignment.MiddleRight
        btnGravar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackgroundImage = My.Resources.Resources.limpart
        btnLimpar.BackgroundImageLayout = ImageLayout.None
        btnLimpar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpar.Location = New Point(292, 84)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(130, 60)
        btnLimpar.TabIndex = 7
        btnLimpar.Text = "Limpar"
        btnLimpar.TextAlign = ContentAlignment.MiddleRight
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.BackgroundImage = My.Resources.Resources.excluir
        btnExcluir.BackgroundImageLayout = ImageLayout.None
        btnExcluir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExcluir.Location = New Point(292, 153)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(130, 60)
        btnExcluir.TabIndex = 8
        btnExcluir.Text = "Excluir"
        btnExcluir.TextAlign = ContentAlignment.MiddleRight
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.BackgroundImage = My.Resources.Resources.Consultar
        btnConsultar.BackgroundImageLayout = ImageLayout.None
        btnConsultar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnConsultar.Location = New Point(12, 153)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(130, 60)
        btnConsultar.TabIndex = 9
        btnConsultar.Text = "Consultar"
        btnConsultar.TextAlign = ContentAlignment.MiddleRight
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnFechar
        ' 
        btnFechar.BackgroundImage = My.Resources.Resources.fechar
        btnFechar.BackgroundImageLayout = ImageLayout.None
        btnFechar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnFechar.Location = New Point(435, 84)
        btnFechar.Name = "btnFechar"
        btnFechar.Size = New Size(130, 60)
        btnFechar.TabIndex = 10
        btnFechar.Text = "Fechar"
        btnFechar.TextAlign = ContentAlignment.MiddleRight
        btnFechar.UseVisualStyleBackColor = True
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ' 
        ' frmCadastroUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(791, 225)
        ControlBox = False
        Controls.Add(btnFechar)
        Controls.Add(btnConsultar)
        Controls.Add(btnExcluir)
        Controls.Add(btnLimpar)
        Controls.Add(btnGravar)
        Controls.Add(btnAlterar)
        Controls.Add(btnNovo)
        Controls.Add(picImagem)
        Controls.Add(grbSenha)
        Controls.Add(grbNome)
        Controls.Add(grbCodigo)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmCadastroUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro Usuários"
        grbCodigo.ResumeLayout(False)
        grbCodigo.PerformLayout()
        grbNome.ResumeLayout(False)
        grbNome.PerformLayout()
        grbSenha.ResumeLayout(False)
        grbSenha.PerformLayout()
        CType(picImagem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grbCodigo As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents grbNome As GroupBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents grbSenha As GroupBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents picImagem As PictureBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents ofdFoto As OpenFileDialog
End Class
