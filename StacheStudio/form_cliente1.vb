Public Class form_cliente1

    Private Sub form_cliente1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With form_login
            lbl_usuario.Text = "Conta: " & aux_email
        End With



        carregar_dados()
        sql = "SELECT * FROM tb_profissionais"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            texto = rs.Fields(1).Value.ToString() ' Obter o texto do campo
            id_profissional = rs.Fields(0).Value ' Obter o valor do campo
            cmb_profissional.Items.Add(New ComboboxItem(texto, id_profissional))
            rs.MoveNext()
        Loop





    End Sub

    Sub agendamento()
        ' Try
        If cmb_profissional.SelectedIndex = -1 Then
            cmb_horarios.Items.Clear()

        Else

            profissional_id = cmb_profissional.SelectedItem.Value
            data_selecionada = dtp_dia.Value.Date

            Dim cabecalho As String = "Horários disponíveis para " & cmb_profissional.SelectedItem.Text & " no dia " & data_selecionada.ToShortDateString() & ":"

            Dim horariosDisponiveis As New List(Of String)({"09:00", "09:45", "10:30", "11:15", "12:00", "14:00", "14:45", "15:30", "16:15", "17:00"})

            sql = "SELECT * FROM tb_agendamentos WHERE id_profissional = '" & profissional_id & "' AND data = '" & data_selecionada.ToString("dd/MM/yyyy") & "'"
            rs = db.Execute(sql)

            Do While Not rs.EOF
                Dim horarioAgendado As String = rs.Fields("horario").Value
                horariosDisponiveis.Remove(horarioAgendado)
                rs.MoveNext()
            Loop


            cmb_horarios.Items.Clear()



            For Each horario As String In horariosDisponiveis
                cmb_horarios.Items.Add(horario)
            Next
        End If

        ' Catch ex As Exception
        'MsgBox("Erro no agendamento")
        ' End Try

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja Sair, " & aux_usu & "?", vbQuestion + vbYesNo, "Sair")
        If resp = vbYes Then
            Close()
            form_login.Show()
        End If

    End Sub

    Private Sub cmb_profissional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_profissional.SelectedIndexChanged
        agendamento()
    End Sub

    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        If cmb_horarios.SelectedItem = Nothing Or cmb_horarios.SelectedIndex = -1 Then
            MsgBox("Escolha o horario")

        Else
            sql = "insert into tb_agendamentos (id_profissional, id_cliente, data, horario) values ('" & profissional_id & "','" & aux_cpf & "','" & data_selecionada.ToString("dd/MM/yyyy") & "','" & cmb_horarios.SelectedItem.ToString & "')"
            rs = db.Execute(sql)
            MsgBox("Agendamento realizado: " & data_selecionada & " " & cmb_horarios.SelectedItem.ToString & vbCrLf & "Profissional: " & cmb_profissional.SelectedItem.ToString, vbInformation + vbOKOnly, "Agendamento realizado!")
            cmb_profissional.SelectedIndex = -1

            cmb_horarios.SelectedIndex = -1

            cmb_horarios.Text = ""


        End If

    End Sub

    Private Sub lbl_usuario_Click(sender As Object, e As EventArgs) Handles lbl_usuario.Click

    End Sub

    Private Sub dtp_dia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dia.ValueChanged
        agendamento()
    End Sub

    Private Sub btn_menu_agendar_Click(sender As Object, e As EventArgs) Handles btn_menu_agendar.Click
        tab_cliente1.SelectedIndex = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tab_cliente1.SelectedIndex = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tab_cliente1.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tab_cliente1.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        form_info_usuário.ShowDialog()
    End Sub

    Private Sub btn_sobre_Click(sender As Object, e As EventArgs) Handles btn_sobre.Click
        form_info_ss.Show()
        Me.Hide()
    End Sub
End Class