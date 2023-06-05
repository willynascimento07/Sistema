Public Class frmCadastroUsuarios
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
End Class