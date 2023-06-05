Public Class frmConsultaUsuarios

    Dim objconexao As New clConexao
    Function CarregarGrid()
        dgvUsuarios.DataSource = objconexao.ConsultaUsuario

    End Function

    Private Sub frmConsultaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarGrid()

    End Sub

    Private Sub dgvUsuarios_DoubleClick(sender As Object, e As EventArgs)
        Dim row As DataGridViewRow = dgvUsuarios.CurrentRow

        frmCadastroUsuarios.txtCodigo.Text = row.Cells(0).Value.ToString
        frmCadastroUsuarios.txtNome.Text = row.Cells(1).Value.ToString
        frmCadastroUsuarios.txtSenha.Text = row.Cells(2).Value.ToString
        Close()

    End Sub

End Class