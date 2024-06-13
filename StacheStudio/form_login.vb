Public Class form_login
    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_sql_server()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged, txt_senha.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

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



    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        'Try

        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preecha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
        ElseIf (txt_usuario.Text = "admin" And txt_senha.Text = "admin") Then

            form_admin.Show()
            Me.Hide()
            limpar_dados()

        Else
            sql = "SELECT * FROM tb_cadastro WHERE (cpf = '" & txt_usuario.Text & "' OR email = '" & txt_usuario.Text & "') AND senha = '" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                MsgBox("Dados inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                limpar_dados()
                Exit Sub
            Else
                If rs.EOF = False Then
                    aux_status = rs.Fields(5).Value
                    If aux_status = "Ativado" Then
                        aux_email = rs.Fields(3).Value
                        aux_usu = rs.Fields(1).Value
                        aux_cpf = rs.Fields(0).Value

                        MsgBox("Bem vindo " & rs.Fields(1).Value & "!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)


                        form_cliente1.Show()
                        limpar_dados()
                        Me.Hide()



                    Else
                        MsgBox("Seu acesso foi bloqueado, contate o administrador.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        limpar_dados()
                    End If

                End If
            End If

        End If
        'Catch ex As Exception
        'MsgBox("Erro ao efetuar login", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        'End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        form_cadastro.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        resp = MsgBox("Deseja sair?", vbQuestion + vbYesNo, "Sair?")
        If resp = vbYes Then
            Application.Exit()
        End If

    End Sub


    Private Sub txt_usuario_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = Chr(13) Then ' Verifica se a tecla pressionada é Enter (código 13)
            e.Handled = True ' Indica que o caractere foi tratado, suprimindo o som de bipe
            If txt_usuario.Text <> "" Then
                Me.txt_senha.Focus() ' Mover o foco para o campo de senha
            Else
                MsgBox("Preencha o campo usuário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        End If
    End Sub

    Private Sub txt_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_senha.KeyPress
        If e.KeyChar = Chr(13) Then ' Verifica se a tecla pressionada é Enter (código 13)
            e.Handled = True ' Indica que o caractere foi tratado, suprimindo o som de bipe
            If txt_usuario.Text <> "" Then
                btn_entrar_Click(btn_entrar, New EventArgs())
            Else
                MsgBox("Preencha o campo usuário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        End If
    End Sub
End Class
