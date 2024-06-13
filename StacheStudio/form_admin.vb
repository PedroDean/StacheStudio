Public Class form_admin
    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(4).Selected = True Then
                aux_usu = .CurrentRow.Cells(1).Value
                If .CurrentRow.Cells(4).Value = "Ativado" Then
                    aux_usu = .CurrentRow.Cells(1).Value
                    estado = "Bloqueado"
                    sql = "update tb_cadastro set status = '" & estado & "' where cpf = '" & aux_usu & "'"
                    rs = db.Execute(sql)
                    MsgBox("Status alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    carregar_dados()

                ElseIf .CurrentRow.Cells(4).Value = "Bloqueado" Then
                    aux_usu = .CurrentRow.Cells(1).Value
                    estado = "Ativado"
                    sql = "update tb_cadastro set status = '" & estado & "' where cpf = '" & aux_usu & "'"
                    rs = db.Execute(sql)
                    MsgBox("Status alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    carregar_dados()

                Else
                    MsgBox("Erro ao alterar status de " & aux_usu)
                    MsgBox("Coluna" & .CurrentRow.Cells(4).Value)
                End If


            End If
        End With

    End Sub

    Private Sub form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_sql_server()
        carregar_dados()

    End Sub

    Private Sub btn_cadastro_Click_1(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        If txt_nome.Text = "" Or txt_senha.Text = "" Or txt_cpf.Text = "" Or txt_telefone.Text = "" Or txt_email.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            'Try
            sql = "select * from tb_cadastro where cpf = '" & Replace(Replace(txt_cpf.Text, ".", ""), "-", "") & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_cadastro (cpf, nome, telefone, email, senha, status) values ('" & Replace(Replace(txt_cpf.Text, ".", ""), "-", "") & "', '" & txt_nome.Text & "', '" & txt_telefone.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "', 'Ativado')"
                rs = db.Execute(sql)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_dados()
                carregar_dados()

            Else
                resp = MsgBox("Este CPF ja está cadastrado! Gostaria de sobrescrever os dados? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "update tb_cadastro set cpf = '" & Replace(Replace(txt_cpf.Text, ".", ""), "-", "") & "', nome = '" & txt_nome.Text & "', telefone = '" & txt_telefone.Text & "', email = '" & txt_email.Text & "', senha = '" & txt_senha.Text & "' , status = 'Ativado' where cpf = '" & Replace(Replace(txt_cpf.Text, ".", ""), "-", "") & "'"

                    rs = db.Execute(sql)
                    MsgBox("dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso")
                    limpar_dados()
                    carregar_dados()
                End If
                Exit Sub


            End If
            'Catch ex As Exception

            'MsgBox("Erro ao Gravar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            ' End Try
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            With dgv_dados

                aux_usu = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(1).Value = "" Then
                    MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                Else
                    aux_usu = .CurrentRow.Cells(1).Value
                    sql = "Select * from tb_cadastro where cpf = '" & aux_usu & "'"
                    rs = db.Execute(sql)


                    txt_nome.Text = .CurrentRow.Cells(0).Value

                    txt_email.Text = .CurrentRow.Cells(2).Value
                    txt_telefone.Text = .CurrentRow.Cells(3).Value
                    txt_cpf.Text = .CurrentRow.Cells(1).Value
                    txt_senha.Text = rs.Fields(4).Value





                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub




    Private Sub btn_sair_Click_1(sender As Object, e As EventArgs) Handles btn_sair.Click

        resp = MsgBox("Deseja deslogar da conta de administrador?", vbQuestion + vbYesNo, "Sair")
        If resp = vbYes Then
            Me.Close()
            form_login.Show()
        End If

    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        With dgv_dados
            Try
                aux_usu = .CurrentRow.Cells(1).Value

                If .CurrentRow.Cells(1).Value = "" Then
                    MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                Else
                    resp = MsgBox("Deseja apagar o usuario: '" & aux_usu & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_cadastro where cpf = '" & aux_usu & "'"
                        rs = db.Execute(sql)
                        MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        carregar_dados()

                    End If
                End If

            Catch ex As Exception
                MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        form_agendamentos_admin.ShowDialog()
    End Sub

    Private Sub chk_senha_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        With txt_senha
            If .UseSystemPasswordChar = True Then
                .UseSystemPasswordChar = False
            Else
                .UseSystemPasswordChar = True
            End If
        End With
    End Sub


End Class