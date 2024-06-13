Public Class form_info_usuário
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub form_info_usuário_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT a.data, a.horario, a.id_profissional, p.id_profissional, p.nome FROM tb_agendamentos a INNER JOIN tb_profissionais p ON a.id_profissional = p.id_profissional WHERE a.id_cliente = '" & aux_cpf & "'"

        rs = db.Execute(sql)


        lbl_nome.Text = aux_usu
        lbl_cpf.Text = aux_cpf
        lbl_email.Text = aux_email


        If Not rs.EOF Then
            Dim agendamentos As New System.Text.StringBuilder()


            Do While Not rs.EOF

                agendamentos.AppendLine(rs.Fields("data").Value & " " & rs.Fields("horario").Value & " - Profissional: " & rs.Fields("nome").Value)
                rs.MoveNext()
            Loop

            ' Define o texto do label com o conteúdo do StringBuilder
            lbl_agendamento.Text = agendamentos.ToString()
        Else
            lbl_agendamento.Text = "Nenhum agendamento encontrado para este cliente."
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        form_cliente1.Show()
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class