Public Class frmCadastroUsuarios

    'declarar a variável para converter a foto
    Dim strCaminhoFoto As String

    'Variaval para chamar a classe de conexão com o bando
    Dim objConexao As New clConexao
    'Variavem para chamar a classe de mensagens
    Dim objMensagem As New clMensagem

    Function Inicio()

        btnAlterar.Visible = False
        btnGravar.Visible = False
        btnLimpar.Visible = False
        btnExcluir.Visible = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtSenha.Enabled = False
        picImagem.Enabled = False

    End Function

    Function LimparCampos()

        txtCodigo.Clear()
        txtNome.Clear()
        txtSenha.Clear()

    End Function

    Private Sub frmCadastroUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Inicio()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Close()

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtNome.Enabled = True
        txtSenha.Enabled = True
        btnConsultar.Visible = False
        btnLimpar.Visible = True
        btnExcluir.Visible = False
        picImagem.Enabled = True
        LimparCampos()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        frmConsultaUsuarios.Show()

    End Sub

    Private Sub picImagem_Click(sender As Object, e As EventArgs) Handles picImagem.Click
        ofdFoto.Title = "Selecione a foto"

        'filtro para adicionar apenas arquivos nas extenções a seguir
        ofdFoto.Filter = "Foto | *.jpg; *.bmp; *.png"

        'caso selecione um arquivo, salve na variável strCaminhoFoto
        If ofdFoto.ShowDialog = DialogResult.OK Then
            picImagem.Image = Image.FromFile(ofdFoto.FileName)
            strCaminhoFoto = ofdFoto.FileName
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click


        'teste para verificar se o usuário está cadastrando sem nome
        If txtNome.Text = "" Then
            txtNome.Focus()
            objMensagem.CampoObrigatorio()

            'caso nome esteja preenchido realiza o insert ao banco se for um cadastro novo
        ElseIf txtCodigo.Text = "" Then
            objConexao.InsertUsuario(txtNome.Text, txtSenha.Text, strCaminhoFoto)

            'BloquearCampos()
            LimparCampos()

            objMensagem.CadastroRealizado()

        Else
            objConexao.UpdateUsuario(txtCodigo.Text, txtNome.Text, txtSenha.Text, strCaminhoFoto)

            'BloquearCampos()
            LimparCampos()

            objMensagem.CadastroAlterado()
        End If

    End Sub
End Class