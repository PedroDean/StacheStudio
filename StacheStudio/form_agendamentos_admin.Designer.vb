<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_agendamentos_admin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_agendamentos_admin))
        dgv_agendamento = New DataGridView()
        Profissional = New DataGridViewTextBoxColumn()
        Data = New DataGridViewTextBoxColumn()
        Horário = New DataGridViewTextBoxColumn()
        Cliente = New DataGridViewTextBoxColumn()
        Telefone = New DataGridViewTextBoxColumn()
        id_agendamento = New DataGridViewTextBoxColumn()
        btn_excluir = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        CType(dgv_agendamento, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_agendamento
        ' 
        dgv_agendamento.BackgroundColor = SystemColors.ActiveCaptionText
        dgv_agendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_agendamento.Columns.AddRange(New DataGridViewColumn() {Profissional, Data, Horário, Cliente, Telefone, id_agendamento})
        dgv_agendamento.GridColor = SystemColors.ActiveCaptionText
        dgv_agendamento.Location = New Point(44, 64)
        dgv_agendamento.Name = "dgv_agendamento"
        dgv_agendamento.RowHeadersWidth = 51
        dgv_agendamento.Size = New Size(761, 279)
        dgv_agendamento.TabIndex = 0
        ' 
        ' Profissional
        ' 
        Profissional.HeaderText = "Profissional"
        Profissional.MinimumWidth = 6
        Profissional.Name = "Profissional"
        Profissional.Width = 125
        ' 
        ' Data
        ' 
        Data.HeaderText = "Data"
        Data.MinimumWidth = 6
        Data.Name = "Data"
        Data.Width = 125
        ' 
        ' Horário
        ' 
        Horário.HeaderText = "Horário"
        Horário.MinimumWidth = 6
        Horário.Name = "Horário"
        Horário.Width = 125
        ' 
        ' Cliente
        ' 
        Cliente.HeaderText = "Cliente"
        Cliente.MinimumWidth = 6
        Cliente.Name = "Cliente"
        Cliente.Width = 125
        ' 
        ' Telefone
        ' 
        Telefone.HeaderText = "Telefone"
        Telefone.MinimumWidth = 6
        Telefone.Name = "Telefone"
        Telefone.Width = 125
        ' 
        ' id_agendamento
        ' 
        id_agendamento.HeaderText = "id_agendamento"
        id_agendamento.MinimumWidth = 6
        id_agendamento.Name = "id_agendamento"
        id_agendamento.Width = 125
        ' 
        ' btn_excluir
        ' 
        btn_excluir.FlatStyle = FlatStyle.Popup
        btn_excluir.ForeColor = SystemColors.ButtonFace
        btn_excluir.Location = New Point(288, 374)
        btn_excluir.Margin = New Padding(2)
        btn_excluir.Name = "btn_excluir"
        btn_excluir.Size = New Size(282, 50)
        btn_excluir.TabIndex = 19
        btn_excluir.Text = "Excluir"
        btn_excluir.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(dgv_agendamento)
        GroupBox1.Controls.Add(btn_excluir)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(849, 502)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Controle de Agendamentos"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(790, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 41)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' form_agendamentos_admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(873, 526)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "form_agendamentos_admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_agendamentos_admin"
        CType(dgv_agendamento, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_agendamento As DataGridView
    Friend WithEvents btn_excluir As Button
    Friend WithEvents Profissional As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Horário As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents id_agendamento As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
