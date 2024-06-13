<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cadastro))
        txt_nome = New TextBox()
        txt_email = New TextBox()
        nome = New Label()
        email = New Label()
        CPF = New Label()
        tel = New Label()
        txt_cpf = New MaskedTextBox()
        txt_telefone = New MaskedTextBox()
        btn_limpar = New Button()
        Label1 = New Label()
        txt_senha = New TextBox()
        chk_senha = New CheckBox()
        btn_cadastrar = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = SystemColors.InactiveCaptionText
        txt_nome.BorderStyle = BorderStyle.FixedSingle
        txt_nome.ForeColor = SystemColors.InactiveBorder
        txt_nome.Location = New Point(38, 44)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(424, 23)
        txt_nome.TabIndex = 0
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = SystemColors.InactiveCaptionText
        txt_email.BorderStyle = BorderStyle.FixedSingle
        txt_email.ForeColor = SystemColors.InactiveBorder
        txt_email.Location = New Point(38, 158)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(424, 23)
        txt_email.TabIndex = 2
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.BackColor = Color.Transparent
        nome.ForeColor = SystemColors.ActiveCaptionText
        nome.Location = New Point(20, 26)
        nome.Name = "nome"
        nome.Size = New Size(40, 15)
        nome.TabIndex = 1
        nome.Text = "Nome"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.BackColor = Color.Transparent
        email.ForeColor = SystemColors.ActiveCaptionText
        email.Location = New Point(20, 140)
        email.Name = "email"
        email.Size = New Size(41, 15)
        email.TabIndex = 1
        email.Text = "E-mail"
        ' 
        ' CPF
        ' 
        CPF.AutoSize = True
        CPF.BackColor = Color.Transparent
        CPF.ForeColor = SystemColors.ActiveCaptionText
        CPF.Location = New Point(20, 82)
        CPF.Name = "CPF"
        CPF.Size = New Size(28, 15)
        CPF.TabIndex = 1
        CPF.Text = "CPF"
        ' 
        ' tel
        ' 
        tel.AutoSize = True
        tel.BackColor = Color.Transparent
        tel.ForeColor = SystemColors.ActiveCaptionText
        tel.Location = New Point(20, 248)
        tel.Name = "tel"
        tel.Size = New Size(51, 15)
        tel.TabIndex = 1
        tel.Text = "Telefone"
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BackColor = SystemColors.InactiveCaptionText
        txt_cpf.BorderStyle = BorderStyle.FixedSingle
        txt_cpf.ForeColor = SystemColors.InactiveBorder
        txt_cpf.Location = New Point(38, 100)
        txt_cpf.Mask = "000,000,000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(424, 23)
        txt_cpf.TabIndex = 1
        ' 
        ' txt_telefone
        ' 
        txt_telefone.BackColor = SystemColors.InactiveCaptionText
        txt_telefone.BorderStyle = BorderStyle.FixedSingle
        txt_telefone.ForeColor = SystemColors.InactiveBorder
        txt_telefone.Location = New Point(38, 266)
        txt_telefone.Mask = "+99 (99) 99999-9999"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(424, 23)
        txt_telefone.TabIndex = 5
        ' 
        ' btn_limpar
        ' 
        btn_limpar.FlatStyle = FlatStyle.Popup
        btn_limpar.ForeColor = SystemColors.ButtonHighlight
        btn_limpar.Location = New Point(537, 170)
        btn_limpar.Name = "btn_limpar"
        btn_limpar.Size = New Size(121, 33)
        btn_limpar.TabIndex = 7
        btn_limpar.Text = "Limpar "
        btn_limpar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(20, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 5
        Label1.Text = "Senha"
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = SystemColors.InactiveCaptionText
        txt_senha.BorderStyle = BorderStyle.FixedSingle
        txt_senha.ForeColor = SystemColors.InactiveBorder
        txt_senha.Location = New Point(38, 209)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(424, 23)
        txt_senha.TabIndex = 3
        txt_senha.UseSystemPasswordChar = True
        ' 
        ' chk_senha
        ' 
        chk_senha.AutoSize = True
        chk_senha.BackColor = Color.Transparent
        chk_senha.Location = New Point(467, 212)
        chk_senha.Margin = New Padding(3, 2, 3, 2)
        chk_senha.Name = "chk_senha"
        chk_senha.Size = New Size(101, 19)
        chk_senha.TabIndex = 4
        chk_senha.Text = "Mostrar senha"
        chk_senha.UseVisualStyleBackColor = False
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.FlatStyle = FlatStyle.Popup
        btn_cadastrar.ForeColor = SystemColors.ButtonHighlight
        btn_cadastrar.Location = New Point(537, 123)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(121, 33)
        btn_cadastrar.TabIndex = 8
        btn_cadastrar.Text = "Cadastrar"
        btn_cadastrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaptionText
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(txt_nome)
        GroupBox1.Controls.Add(btn_cadastrar)
        GroupBox1.Controls.Add(txt_email)
        GroupBox1.Controls.Add(chk_senha)
        GroupBox1.Controls.Add(nome)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(email)
        GroupBox1.Controls.Add(txt_senha)
        GroupBox1.Controls.Add(CPF)
        GroupBox1.Controls.Add(btn_limpar)
        GroupBox1.Controls.Add(tel)
        GroupBox1.Controls.Add(txt_telefone)
        GroupBox1.Controls.Add(txt_cpf)
        GroupBox1.Location = New Point(10, 9)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(787, 326)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cadastro de Usuário"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(735, 10)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' form_cadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(808, 344)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "form_cadastro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro de Clientes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents nome As Label
    Friend WithEvents email As Label
    Friend WithEvents CPF As Label
    Friend WithEvents tel As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents btn_limpar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
