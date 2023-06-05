Public Class clMensagem
    'Função para mostrar a mensagem quando o cadastro for realizado
    Public Function CadastroRealizado()
        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Confirmação")
    End Function

    'Função para mostrar a mensagem quando o cadastro for alterado
    Public Function CadastroAlterado()
        MsgBox("Cadastro alterado com sucesso!", MsgBoxStyle.Information, "Confirmação")
    End Function

    'função para mostrar a mensagem quando não for preenchido algum campo obrigatório
    Public Function CampoObrigatorio()
        MsgBox("Campo não preenchido, campos que tem asterisco são obrigatórios!", MsgBoxStyle.Exclamation, "Atenção!")
    End Function
End Class
