Public Class form_cadastro
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If txt_nome.Text = "" Or txt_senha.Text = "" Or txt_cpf.Text = "" Or txt_telefone.Text = "" Or txt_email.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            'Try
            sql = "select * from tb_cadastro where cpf = '" & Replace(Replace(Replace(txt_cpf.Text, ",", ""), "-", ""), ".", "") & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_cadastro (cpf, nome, telefone, email, senha, status) values ('" & Replace(Replace(Replace(txt_cpf.Text, ",", ""), "-", ""), ".", "") & "', '" & txt_nome.Text & "', '" & txt_telefone.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "', 'Ativado')"
                rs = db.Execute(sql)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_dados()
                Me.Close()
                form_login.Show()

                'carregar_dados()
            Else
                MsgBox("Este CPF ja está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                '    If resp = MsgBoxResult.Yes Then
                '        sql = "UPDATE tb_cadastro SET nome = '" & txtNome.Text & "', senha = '" & txtSenha.Text & "' WHERE nomeUsuario = '" & txtUser.Text & "'"

                '        rs = db.Execute(sql)
                '        MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                '        limpar_dados()
                '        'carregar_dados()
                '    End If
                '    Exit Sub


            End If
            'Catch ex As Exception

            'MsgBox("Erro ao Gravar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            ' End Try
        End If
    End Sub

    Private Sub form_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_sql_server()
    End Sub

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        With txt_senha
            If .UseSystemPasswordChar = True Then
                .UseSystemPasswordChar = False
            Else
                .UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_dados()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class