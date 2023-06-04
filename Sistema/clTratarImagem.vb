'importação da biblioteca para manipular arquivos do Windows ao código
Imports System.IO

'criando a classe que irá converter as imagens salvas no sistema
Public Class clTratarImagem
    'criando a função que irá converar o arquivo em binário, Shared sendo usado sem criar uma instancia da classe
    Public Shared Function ConverterFotoParaBase64(caminho As String)
        Try
            'variável para fazer a leitura do caminho da foto
            Dim ArquivoEmByte() = File.ReadAllBytes(caminho)
            'conversão da foto em base64
            Dim ArquivoEmbase64 = Convert.ToBase64String(ArquivoEmByte)
            'retorno a imagem convertida
            Return ArquivoEmbase64

        Catch ex As Exception

        End Try
    End Function

    'criação da função que converte a string para arquivo
    Public Shared Function ConverterBase64ParaFoto(arquivo As String) As Image
        Try
            'variável para converter o byte para arquivo
            Dim ArquivoEmByte() = Convert.FromBase64String(arquivo)
            'variável que irá salvar em memória  o arquivo em byte
            Dim MS As New MemoryStream(ArquivoEmByte)
            'declaração da variárial que irá armazenar a imagem convertida
            Dim Imagem As Image
            'recebendo a string que foi convertida para imagem e armazenando na variável imagem
            Imagem = Image.FromStream(MS)
            'retornando o resultado da converção de imagem
            Return Imagem

        Catch ex As Exception

        End Try

    End Function
End Class

