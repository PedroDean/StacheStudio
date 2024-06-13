Module mod_geral

    Public diretorio As String 'Variável da foto do cliente openfiledialog1
    Public db As New ADODB.Connection 'Variável global do banco
    Public rs As New ADODB.Recordset 'Variável da tabela do banco
    Public sql, aux_cpf, aux_status, aux_email, resp, aux_usu, estado As String 'Querys CRUD linguagem SQL
    Public dir_banco = Application.StartupPath & "\BancodeDados\StacheStudio.accdb"
    Public cont As Integer

    Public data_selecionada As Date
    Public texto As String
    Public id_profissional As Integer
    Public profissional_id As Object




    Sub conecta_banco_sql_server()
        ' String de conexão ADO para SQL Server com autenticação do Windows
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & dir_banco)

            '    MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        ' Try


        With form_admin.dgv_dados
            sql = "select * from tb_cadastro"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields("nome").Value, rs.Fields("cpf").Value, rs.Fields("email").Value, rs.Fields("telefone").Value, rs.Fields("status").Value)
                rs.MoveNext()
            Loop

        End With



        '  Catch ex As Exception
        'MsgBox("erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        '  End Try

    End Sub

    Sub carregar_dados_agendamento()
        With form_agendamentos_admin.dgv_agendamento
            sql = "SELECT * FROM tb_agendamentos a INNER JOIN tb_cadastro c ON a.id_cliente = c.cpf "


            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                Dim nome_profissional As String = ""
                If rs.Fields("id_profissional").Value = "1" Then
                    nome_profissional = "Lucas"
                ElseIf rs.Fields("id_profissional").Value = "2" Then
                    nome_profissional = "Robson"
                ElseIf rs.Fields("id_profissional").Value = "3" Then
                    nome_profissional = "Pedro"
                End If
                .Rows.Add(nome_profissional, rs.Fields("data").Value, rs.Fields("horario").Value, rs.Fields("nome").Value, rs.Fields("telefone").Value, rs.Fields("id_agendamento").Value)
                rs.MoveNext()
            Loop

        End With
    End Sub
    Sub limpar_dados()
        With form_cadastro
            .txt_cpf.Clear()
            .txt_email.Clear()
            .txt_nome.Clear()
            .txt_senha.Clear()
            .txt_telefone.Clear()
            .txt_cpf.Focus()
            .chk_senha.Checked = False
        End With
        With form_admin
            .txt_cpf.Clear()
            .txt_email.Clear()
            .txt_nome.Clear()
            .txt_senha.Clear()
            .txt_telefone.Clear()
            .txt_cpf.Focus()
            .chk_senha.Checked = False
        End With

        With form_login

            .txt_usuario.Clear()
            .txt_senha.Clear()
            .chk_senha.Checked = False
            .txt_usuario.Focus()
        End With
    End Sub
End Module

Public Class ComboboxItem
    Public Property Text As String
    Public Property Value As Integer ' Ou o tipo de dado que você precisa

    Public Sub New(text As String, value As Integer)
        Me.Text = text
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

