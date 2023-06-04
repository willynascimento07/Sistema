Public Class frmMenu
    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click

        frmCadastroUsuarios.MdiParent = Me
        frmCadastroUsuarios.Show()

    End Sub
End Class