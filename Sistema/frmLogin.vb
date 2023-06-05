Public Class frmLogin

    Function limparcampos()

        txtUsuario.Clear()
        txtSenha.Clear()

    End Function

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Close()

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim objConexao As New clConexao

        If objConexao.login(txtUsuario.Text, txtSenha.Text).Rows.Count = 1 Then
            Me.Hide()
            frmMenu.ShowDialog()
        Else
            MessageBox.Show("Usuário ou senha inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class