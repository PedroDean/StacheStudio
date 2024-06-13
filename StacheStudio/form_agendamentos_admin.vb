Public Class form_agendamentos_admin
    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        With dgv_agendamento
            ' Try


            If .CurrentRow.Cells(1).Value = "" Then
                MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

            Else
                resp = MsgBox("Deseja apagar o agendamento do cliente " & .CurrentRow.Cells(3).Value & " em " & .CurrentRow.Cells(1).Value & " " & .CurrentRow.Cells(2).Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                If resp = MsgBoxResult.Yes Then
                    Dim id_agendamento As Integer
                    id_agendamento = Convert.ToInt32(.CurrentRow.Cells(5).Value)
                    sql = "DELETE FROM tb_agendamentos WHERE id_agendamento = " & id_agendamento
                    rs = db.Execute(sql)
                    MsgBox("Agendamento excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                    carregar_dados_agendamento()

                End If
            End If

            ' Catch ex As Exception
            'MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            '  End Try

        End With
    End Sub

    Private Sub form_agendamentos_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_agendamento()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        form_admin.Show()
    End Sub
End Class