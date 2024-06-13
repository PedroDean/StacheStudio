<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_admin))
        Cadastramento = New GroupBox()
        btn_sair = New Button()
        Button1 = New Button()
        chk_senha = New CheckBox()
        Label1 = New Label()
        txt_senha = New TextBox()
        txt_telefone = New MaskedTextBox()
        txt_cpf = New MaskedTextBox()
        tel = New Label()
        CPF = New Label()
        email = New Label()
        nome = New Label()
        txt_email = New TextBox()
        txt_nome = New TextBox()
        btn_editar = New Button()
        btn_excluir = New Button()
        btn_cadastro = New Button()
        GroupBox1 = New GroupBox()
        dgv_dados = New DataGridView()
        dgvNome = New DataGridViewTextBoxColumn()
        dgvEstado = New DataGridViewTextBoxColumn()
        dgvUser = New DataGridViewTextBoxColumn()
        Telefone = New DataGridViewTextBoxColumn()
        Status = New DataGridViewButtonColumn()
        Cadastramento.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgv_dados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Cadastramento
        ' 
        Cadastramento.BackColor = Color.DarkOrange
        Cadastramento.BackgroundImage = CType(resources.GetObject("Cadastramento.BackgroundImage"), Image)
        Cadastramento.BackgroundImageLayout = ImageLayout.Stretch
        Cadastramento.Controls.Add(btn_sair)
        Cadastramento.Controls.Add(Button1)
        Cadastramento.Controls.Add(chk_senha)
        Cadastramento.Controls.Add(Label1)
        Cadastramento.Controls.Add(txt_senha)
        Cadastramento.Controls.Add(txt_telefone)
        Cadastramento.Controls.Add(txt_cpf)
        Cadastramento.Controls.Add(tel)
        Cadastramento.Controls.Add(CPF)
        Cadastramento.Controls.Add(email)
        Cadastramento.Controls.Add(nome)
        Cadastramento.Controls.Add(txt_email)
        Cadastramento.Controls.Add(txt_nome)
        Cadastramento.Controls.Add(btn_editar)
        Cadastramento.Controls.Add(btn_excluir)
        Cadastramento.Controls.Add(btn_cadastro)
        Cadastramento.Font = New Font("Arial Rounded MT Bold", 11F)
        Cadastramento.ForeColor = SystemColors.ActiveCaptionText
        Cadastramento.Location = New Point(12, 12)
        Cadastramento.Name = "Cadastramento"
        Cadastramento.Size = New Size(941, 272)
        Cadastramento.TabIndex = 11
        Cadastramento.TabStop = False
        Cadastramento.Text = "Cadastro"
        ' 
        ' btn_sair
        ' 
        btn_sair.BackColor = Color.Transparent
        btn_sair.FlatStyle = FlatStyle.Flat
        btn_sair.Font = New Font("Arial Rounded MT Bold", 9F)
        btn_sair.ForeColor = Color.White
        btn_sair.Location = New Point(830, 22)
        btn_sair.Margin = New Padding(3, 2, 3, 2)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(82, 22)
        btn_sair.TabIndex = 47
        btn_sair.Text = "Logout"
        btn_sair.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Rounded MT Bold", 9F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(718, 226)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 24)
        Button1.TabIndex = 46
        Button1.Text = "Agendamentos"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' chk_senha
        ' 
        chk_senha.AutoSize = True
        chk_senha.BackColor = Color.Transparent
        chk_senha.Font = New Font("Arial Rounded MT Bold", 9F)
        chk_senha.ForeColor = SystemColors.ActiveCaptionText
        chk_senha.Location = New Point(718, 110)
        chk_senha.Margin = New Padding(3, 2, 3, 2)
        chk_senha.Name = "chk_senha"
        chk_senha.Size = New Size(109, 18)
        chk_senha.TabIndex = 43
        chk_senha.Text = "Mostrar senha"
        chk_senha.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 9F)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(410, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 14)
        Label1.TabIndex = 44
        Label1.Text = "Senha"
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = SystemColors.ActiveCaptionText
        txt_senha.BorderStyle = BorderStyle.FixedSingle
        txt_senha.ForeColor = SystemColors.InactiveBorder
        txt_senha.Location = New Point(410, 108)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(303, 24)
        txt_senha.TabIndex = 42
        txt_senha.UseSystemPasswordChar = True
        ' 
        ' txt_telefone
        ' 
        txt_telefone.BackColor = SystemColors.ActiveCaptionText
        txt_telefone.BorderStyle = BorderStyle.FixedSingle
        txt_telefone.ForeColor = SystemColors.InactiveBorder
        txt_telefone.Location = New Point(410, 166)
        txt_telefone.Mask = "+99 (99) 99999-9999"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(303, 24)
        txt_telefone.TabIndex = 45
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BackColor = SystemColors.ActiveCaptionText
        txt_cpf.BorderStyle = BorderStyle.FixedSingle
        txt_cpf.ForeColor = SystemColors.InactiveBorder
        txt_cpf.Location = New Point(83, 108)
        txt_cpf.Mask = "000,000,000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(303, 24)
        txt_cpf.TabIndex = 36
        ' 
        ' tel
        ' 
        tel.AutoSize = True
        tel.BackColor = Color.Transparent
        tel.Font = New Font("Arial Rounded MT Bold", 9F)
        tel.ForeColor = SystemColors.ActiveCaptionText
        tel.Location = New Point(410, 148)
        tel.Name = "tel"
        tel.Size = New Size(57, 14)
        tel.TabIndex = 37
        tel.Text = "Telefone"
        ' 
        ' CPF
        ' 
        CPF.AutoSize = True
        CPF.BackColor = Color.Transparent
        CPF.Font = New Font("Arial Rounded MT Bold", 9F)
        CPF.ForeColor = SystemColors.ActiveCaptionText
        CPF.Location = New Point(81, 90)
        CPF.Name = "CPF"
        CPF.Size = New Size(31, 14)
        CPF.TabIndex = 38
        CPF.Text = "CPF"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.BackColor = Color.Transparent
        email.Font = New Font("Arial Rounded MT Bold", 9F)
        email.ForeColor = SystemColors.ActiveCaptionText
        email.Location = New Point(83, 148)
        email.Name = "email"
        email.Size = New Size(43, 14)
        email.TabIndex = 39
        email.Text = "E-mail"
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.BackColor = Color.Transparent
        nome.Font = New Font("Arial Rounded MT Bold", 9F)
        nome.ForeColor = SystemColors.ActiveCaptionText
        nome.Location = New Point(83, 34)
        nome.Name = "nome"
        nome.Size = New Size(41, 14)
        nome.TabIndex = 40
        nome.Text = "Nome"
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = SystemColors.ActiveCaptionText
        txt_email.BorderStyle = BorderStyle.FixedSingle
        txt_email.ForeColor = SystemColors.InactiveBorder
        txt_email.Location = New Point(83, 166)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(303, 24)
        txt_email.TabIndex = 41
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = SystemColors.ActiveCaptionText
        txt_nome.BorderStyle = BorderStyle.FixedSingle
        txt_nome.ForeColor = SystemColors.ButtonHighlight
        txt_nome.Location = New Point(83, 52)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(629, 24)
        txt_nome.TabIndex = 35
        ' 
        ' btn_editar
        ' 
        btn_editar.BackColor = Color.Black
        btn_editar.FlatStyle = FlatStyle.Popup
        btn_editar.Font = New Font("Arial Rounded MT Bold", 9F)
        btn_editar.ForeColor = Color.White
        btn_editar.Location = New Point(362, 226)
        btn_editar.Margin = New Padding(3, 2, 3, 2)
        btn_editar.Name = "btn_editar"
        btn_editar.Size = New Size(108, 24)
        btn_editar.TabIndex = 34
        btn_editar.Text = "Editar"
        btn_editar.UseVisualStyleBackColor = False
        ' 
        ' btn_excluir
        ' 
        btn_excluir.BackColor = Color.Black
        btn_excluir.FlatStyle = FlatStyle.Popup
        btn_excluir.Font = New Font("Arial Rounded MT Bold", 9F)
        btn_excluir.ForeColor = Color.White
        btn_excluir.Location = New Point(473, 226)
        btn_excluir.Margin = New Padding(2)
        btn_excluir.Name = "btn_excluir"
        btn_excluir.Size = New Size(104, 24)
        btn_excluir.TabIndex = 33
        btn_excluir.Text = "Excluir"
        btn_excluir.UseVisualStyleBackColor = False
        ' 
        ' btn_cadastro
        ' 
        btn_cadastro.BackColor = Color.Black
        btn_cadastro.FlatStyle = FlatStyle.Popup
        btn_cadastro.Font = New Font("Arial Rounded MT Bold", 9F)
        btn_cadastro.ForeColor = Color.White
        btn_cadastro.Location = New Point(254, 226)
        btn_cadastro.Margin = New Padding(2)
        btn_cadastro.Name = "btn_cadastro"
        btn_cadastro.Size = New Size(104, 24)
        btn_cadastro.TabIndex = 32
        btn_cadastro.Text = "Cadastrar"
        btn_cadastro.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkOrange
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(dgv_dados)
        GroupBox1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 302)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(941, 349)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados dos Clientes"
        ' 
        ' dgv_dados
        ' 
        dgv_dados.BackgroundColor = Color.Black
        dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_dados.Columns.AddRange(New DataGridViewColumn() {dgvNome, dgvEstado, dgvUser, Telefone, Status})
        dgv_dados.GridColor = Color.Black
        dgv_dados.Location = New Point(87, 40)
        dgv_dados.Margin = New Padding(2)
        dgv_dados.Name = "dgv_dados"
        dgv_dados.RowHeadersWidth = 62
        dgv_dados.Size = New Size(766, 250)
        dgv_dados.TabIndex = 11
        ' 
        ' dgvNome
        ' 
        dgvNome.HeaderText = "Nome"
        dgvNome.MinimumWidth = 8
        dgvNome.Name = "dgvNome"
        dgvNome.Width = 150
        ' 
        ' dgvEstado
        ' 
        dgvEstado.HeaderText = "CPF"
        dgvEstado.MinimumWidth = 8
        dgvEstado.Name = "dgvEstado"
        dgvEstado.Resizable = DataGridViewTriState.True
        dgvEstado.SortMode = DataGridViewColumnSortMode.NotSortable
        dgvEstado.Width = 150
        ' 
        ' dgvUser
        ' 
        dgvUser.HeaderText = "E-mail"
        dgvUser.MinimumWidth = 8
        dgvUser.Name = "dgvUser"
        dgvUser.Width = 150
        ' 
        ' Telefone
        ' 
        Telefone.HeaderText = "Telefone"
        Telefone.MinimumWidth = 6
        Telefone.Name = "Telefone"
        Telefone.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Resizable = DataGridViewTriState.True
        Status.SortMode = DataGridViewColumnSortMode.Automatic
        Status.Width = 125
        ' 
        ' form_admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(968, 676)
        Controls.Add(GroupBox1)
        Controls.Add(Cadastramento)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "form_admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_admin"
        Cadastramento.ResumeLayout(False)
        Cadastramento.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgv_dados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Agendamento As DataGridViewComboBoxColumn
    Friend WithEvents Cadastramento As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents tel As Label
    Friend WithEvents CPF As Label
    Friend WithEvents email As Label
    Friend WithEvents nome As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents dgvNome As DataGridViewTextBoxColumn
    Friend WithEvents dgvEstado As DataGridViewTextBoxColumn
    Friend WithEvents dgvUser As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewButtonColumn
    Friend WithEvents btn_sair As Button
End Class
