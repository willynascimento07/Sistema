<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        PictureBox1 = New PictureBox()
        lblNome = New Label()
        lblSenha = New Label()
        txtUsuario = New TextBox()
        txtSenha = New TextBox()
        btnEntrar = New Button()
        btnFechar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblNome.Location = New Point(245, 12)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(81, 25)
        lblNome.TabIndex = 1
        lblNome.Text = "Usuário:"
        ' 
        ' lblSenha
        ' 
        lblSenha.AutoSize = True
        lblSenha.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSenha.Location = New Point(245, 67)
        lblSenha.Name = "lblSenha"
        lblSenha.Size = New Size(68, 25)
        lblSenha.TabIndex = 2
        lblSenha.Text = "Senha:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsuario.Location = New Point(332, 9)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(138, 33)
        txtUsuario.TabIndex = 3
        ' 
        ' txtSenha
        ' 
        txtSenha.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSenha.Location = New Point(331, 64)
        txtSenha.Name = "txtSenha"
        txtSenha.Size = New Size(138, 33)
        txtSenha.TabIndex = 4
        ' 
        ' btnEntrar
        ' 
        btnEntrar.BackgroundImage = My.Resources.Resources.entrar
        btnEntrar.BackgroundImageLayout = ImageLayout.None
        btnEntrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEntrar.Location = New Point(245, 106)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(220, 55)
        btnEntrar.TabIndex = 5
        btnEntrar.Text = "Entrar"
        btnEntrar.TextAlign = ContentAlignment.MiddleRight
        btnEntrar.UseVisualStyleBackColor = True
        ' 
        ' btnFechar
        ' 
        btnFechar.BackgroundImage = My.Resources.Resources.fechar
        btnFechar.BackgroundImageLayout = ImageLayout.None
        btnFechar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnFechar.Location = New Point(244, 166)
        btnFechar.Name = "btnFechar"
        btnFechar.Size = New Size(220, 55)
        btnFechar.TabIndex = 6
        btnFechar.Text = "Fechar"
        btnFechar.TextAlign = ContentAlignment.MiddleRight
        btnFechar.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(491, 230)
        ControlBox = False
        Controls.Add(btnFechar)
        Controls.Add(btnEntrar)
        Controls.Add(txtSenha)
        Controls.Add(txtUsuario)
        Controls.Add(lblSenha)
        Controls.Add(lblNome)
        Controls.Add(PictureBox1)
        Name = "frmLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnFechar As Button
End Class
