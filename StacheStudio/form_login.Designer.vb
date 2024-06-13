<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        txt_usuario = New TextBox()
        txt_senha = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btn_entrar = New Button()
        chk_senha = New CheckBox()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_usuario
        ' 
        txt_usuario.BackColor = SystemColors.ActiveCaptionText
        txt_usuario.BorderStyle = BorderStyle.FixedSingle
        txt_usuario.ForeColor = SystemColors.InactiveBorder
        txt_usuario.Location = New Point(123, 334)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(198, 23)
        txt_usuario.TabIndex = 0
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = SystemColors.InactiveCaptionText
        txt_senha.BorderStyle = BorderStyle.FixedSingle
        txt_senha.ForeColor = SystemColors.InactiveBorder
        txt_senha.Location = New Point(123, 382)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(198, 23)
        txt_senha.TabIndex = 1
        txt_senha.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(123, 316)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 1
        Label1.Text = "CPF/E-mail"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(123, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Senha"
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = SystemColors.ActiveCaptionText
        btn_entrar.FlatStyle = FlatStyle.Popup
        btn_entrar.ForeColor = SystemColors.ButtonHighlight
        btn_entrar.Location = New Point(160, 422)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(121, 33)
        btn_entrar.TabIndex = 3
        btn_entrar.Text = "Login"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' chk_senha
        ' 
        chk_senha.AutoSize = True
        chk_senha.BackColor = Color.Transparent
        chk_senha.FlatStyle = FlatStyle.Popup
        chk_senha.Location = New Point(326, 382)
        chk_senha.Margin = New Padding(3, 2, 3, 2)
        chk_senha.Name = "chk_senha"
        chk_senha.Size = New Size(99, 19)
        chk_senha.TabIndex = 7
        chk_senha.Text = "Mostrar senha"
        chk_senha.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Location = New Point(163, 473)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(102, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Cadastre-se agora"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(392, 16)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(444, 556)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(chk_senha)
        Controls.Add(btn_entrar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_senha)
        Controls.Add(txt_usuario)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "form_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_entrar As Button
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox

End Class
