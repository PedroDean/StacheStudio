<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_info_usuário
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_info_usuário))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbl_agendamento = New Label()
        lbl_email = New Label()
        lbl_cpf = New Label()
        lbl_nome = New Label()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(24, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(24, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 1
        Label2.Text = "CPF: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(24, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(24, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 3
        Label4.Text = "Agendamentos:"
        ' 
        ' lbl_agendamento
        ' 
        lbl_agendamento.AutoSize = True
        lbl_agendamento.BackColor = Color.Transparent
        lbl_agendamento.ForeColor = SystemColors.ButtonFace
        lbl_agendamento.Location = New Point(24, 134)
        lbl_agendamento.Name = "lbl_agendamento"
        lbl_agendamento.Size = New Size(0, 15)
        lbl_agendamento.TabIndex = 8
        ' 
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.BackColor = Color.Transparent
        lbl_email.ForeColor = SystemColors.ButtonFace
        lbl_email.Location = New Point(75, 82)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(0, 15)
        lbl_email.TabIndex = 7
        ' 
        ' lbl_cpf
        ' 
        lbl_cpf.AutoSize = True
        lbl_cpf.BackColor = Color.Transparent
        lbl_cpf.ForeColor = SystemColors.ButtonFace
        lbl_cpf.Location = New Point(75, 57)
        lbl_cpf.Name = "lbl_cpf"
        lbl_cpf.Size = New Size(0, 15)
        lbl_cpf.TabIndex = 6
        ' 
        ' lbl_nome
        ' 
        lbl_nome.AutoSize = True
        lbl_nome.BackColor = Color.Transparent
        lbl_nome.ForeColor = SystemColors.ButtonFace
        lbl_nome.Location = New Point(75, 32)
        lbl_nome.Name = "lbl_nome"
        lbl_nome.Size = New Size(0, 15)
        lbl_nome.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(lbl_agendamento)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbl_email)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(lbl_cpf)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(lbl_nome)
        GroupBox1.Location = New Point(10, 9)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(318, 451)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados do Usuário"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(85, 421)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 15)
        Label5.TabIndex = 13
        Label5.Text = "cancelar um agendamento"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Black
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(73, 406)
        Label7.Name = "Label7"
        Label7.Size = New Size(173, 15)
        Label7.TabIndex = 12
        Label7.Text = "*Contacte o administrador para"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(275, 8)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' form_info_usuário
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(340, 471)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "form_info_usuário"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_info_usuário"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_agendamento As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
