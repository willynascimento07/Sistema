Imports System.Data.SqlClient

Public Class clConexao


    Private conexao As New SqlConnection(My.Settings.Conexao)

    Private comando As SqlCommand

    Private da As New SqlDataAdapter

    Private ds As New DataSet

    Private dr As SqlDataReader

    Private strSql As String

    Private strNome As String
    Private strEndereco As String

    Dim dt As New DataTable

    Public Sub InsertPessoa(nome As String, endereco As String, bairro As String, numero As String)
        conexao.Close()
        strSql = "insert into cadastros_pessoa (nome, endereco, bairro, numero) values(@nome, @endereco, @bairro, @numero)"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@nome", nome)
        comando.Parameters.AddWithValue("@endereco", endereco)
        comando.Parameters.AddWithValue("@bairro", bairro)
        comando.Parameters.AddWithValue("@numero", numero)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Function SelectPessoa() As DataTable
        conexao.Close()
        strSql = "select * from cadastros_pessoa order by nome"
        comando = New SqlCommand(strSql, conexao)
        da = New SqlDataAdapter(comando)
        ds = New DataSet
        da.Fill(ds)
        conexao.Open()
        Return ds.Tables(0)
        conexao.Close()
    End Function

    Public Function ConsultaNomePessoa(nome As String) As DataTable
        conexao.Close()
        strSql = "Select * from cadastros_pessoa where nome like @nome"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@nome", "%" + nome + "%")
        da = New SqlDataAdapter(comando)
        ds = New DataSet
        da.Fill(ds)
        conexao.Open()
        Return ds.Tables(0)
        dr = comando.ExecuteReader
        conexao.Close()
    End Function

    Public Sub DeletePessoa(codigo As Integer)
        conexao.Close()
        strSql = "delete from cadastros_pessoa where codigo = @codigo"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@codigo", codigo)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub


    Public Sub UpdatePessoa(codigo As Integer, nome As String, endereco As String, bairro As String, numero As String)
        conexao.Close()
        strSql = "update cadastros_pessoa set nome = @nome, endereco = @endereco, bairro = @bairro, numero = @numero where codigo = @codigo"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@codigo", codigo)
        comando.Parameters.AddWithValue("@nome", nome)
        comando.Parameters.AddWithValue("@endereco", endereco)
        comando.Parameters.AddWithValue("@bairro", bairro)
        comando.Parameters.AddWithValue("@numero", numero)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Function setDados(dgv As DataGridView) As Boolean
        conexao.Close()
        conexao.Open()
        Dim linhas As DataGridViewRow

        For Each linhas In dgv.Rows
            If "0" + linhas.Cells("codigo").Value = 0 Then
                strSql = "insert into cadastros_pessoa (nome, endereco, bairro, numero) values(@nome, @endereco, @bairro, @numero)"
            Else
                strSql = "update cadastros_pessoa set nome = @nome, endereco = @endereco, bairro = @bairro, numero = @numero where codigo = @codigo"
            End If
            comando = New SqlCommand(strSql, conexao)
            comando.Parameters.AddWithValue("@codigo", linhas.Cells("codigo").Value)
            comando.Parameters.AddWithValue("@nome", linhas.Cells("nome").Value)
            comando.Parameters.AddWithValue("@endereco", linhas.Cells("endereco").Value)
            comando.Parameters.AddWithValue("@bairro", linhas.Cells("bairro").Value)
            comando.Parameters.AddWithValue("@numero", linhas.Cells("numero").Value)

            comando.ExecuteNonQuery()

        Next

        Return True
    End Function

    Public Sub UpdateEndereco(EnderecoNovo As String, EnderecoAntigo As String)

        conexao.Close()
        strSql = "update cadastros_pessoa set endereco = @enderecoNovo where endereco = @enderecoAntigo"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@enderecoNovo", EnderecoNovo)
        comando.Parameters.AddWithValue("@enderecoAntigo", EnderecoAntigo)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub


    Public Function login(nome As String, senha As String) As DataTable

        strSql = "select * from usuarios where nome = @nome and senha = @senha"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@nome", nome)
        comando.Parameters.AddWithValue("@senha", senha)
        da = New SqlDataAdapter(comando)
        ds = New DataSet
        conexao.Open()
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

    Public Sub InsertUsuario(nome As String, senha As String, imagem As String)
        Try
            conexao.Close()
            strSql = "insert into usuarios (nome, senha, imagem) values(@nome, @senha, @imagem)"
            comando = New SqlCommand(strSql, conexao)
            comando.Parameters.AddWithValue("@nome", nome)
            comando.Parameters.AddWithValue("@senha", senha)
            comando.Parameters.AddWithValue("@imagem", clTratarImagem.ConverterFotoParaBase64(imagem))
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conexao.Close()
        End Try
    End Sub

    Public Sub UpdateUsuario(codigo As Integer, nome As String, senha As String, imagem As String)
        conexao.Close()
        strSql = "update usuarios set nome = @nome, senha = @senha, imagem = @imagem where codigo = @codigo"
        comando = New SqlCommand(strSql, conexao)
        comando.Parameters.AddWithValue("@codigo", codigo)
        comando.Parameters.AddWithValue("@nome", nome)
        comando.Parameters.AddWithValue("@senha", senha)
        comando.Parameters.AddWithValue("@imagem", imagem)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Function ConsultaUsuario() As DataTable
        conexao.Close()
        strSql = "select * from usuarios order by nome"
        comando = New SqlCommand(strSql, conexao)
        da = New SqlDataAdapter(comando)
        ds = New DataSet
        da.Fill(ds)
        conexao.Open()
        Return ds.Tables(0)
        conexao.Close()
    End Function

End Class
