<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_cliente1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cliente1))
        tab_cliente1 = New TabControl()
        TabPage2 = New TabPage()
        btn_sobre = New Button()
        Button4 = New Button()
        Button1 = New Button()
        btn_menu_agendar = New Button()
        TabPage1 = New TabPage()
        Button2 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_agendar = New Button()
        cmb_horarios = New ComboBox()
        dtp_dia = New DateTimePicker()
        cmb_profissional = New ComboBox()
        TabPage3 = New TabPage()
        Button3 = New Button()
        btn_sair = New Button()
        lbl_usuario = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        tab_cliente1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tab_cliente1
        ' 
        tab_cliente1.Controls.Add(TabPage2)
        tab_cliente1.Controls.Add(TabPage1)
        tab_cliente1.Controls.Add(TabPage3)
        tab_cliente1.ItemSize = New Size(1, 1)
        tab_cliente1.Location = New Point(10, 36)
        tab_cliente1.Margin = New Padding(1)
        tab_cliente1.Multiline = True
        tab_cliente1.Name = "tab_cliente1"
        tab_cliente1.SelectedIndex = 0
        tab_cliente1.Size = New Size(759, 385)
        tab_cliente1.SizeMode = TabSizeMode.FillToRight
        tab_cliente1.TabIndex = 2
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Black
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(btn_sobre)
        TabPage2.Controls.Add(Button4)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(btn_menu_agendar)
        TabPage2.ForeColor = SystemColors.ActiveCaptionText
        TabPage2.Location = New Point(4, 5)
        TabPage2.Margin = New Padding(3, 2, 3, 2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 2, 3, 2)
        TabPage2.Size = New Size(751, 376)
        TabPage2.TabIndex = 1
        ' 
        ' btn_sobre
        ' 
        btn_sobre.BackColor = Color.Black
        btn_sobre.FlatStyle = FlatStyle.Flat
        btn_sobre.Font = New Font("Segoe UI", 9F)
        btn_sobre.ForeColor = SystemColors.ButtonHighlight
        btn_sobre.Location = New Point(634, 4)
        btn_sobre.Margin = New Padding(3, 2, 3, 2)
        btn_sobre.Name = "btn_sobre"
        btn_sobre.Size = New Size(82, 26)
        btn_sobre.TabIndex = 3
        btn_sobre.Text = "Sobre"
        btn_sobre.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 15F)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(503, 320)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(196, 38)
        Button4.TabIndex = 2
        Button4.Text = "Minha conta"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(277, 320)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 38)
        Button1.TabIndex = 1
        Button1.Text = "Cortes e Produtos"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_menu_agendar
        ' 
        btn_menu_agendar.BackColor = Color.Black
        btn_menu_agendar.FlatStyle = FlatStyle.Popup
        btn_menu_agendar.Font = New Font("Segoe UI", 15F)
        btn_menu_agendar.ForeColor = SystemColors.ButtonHighlight
        btn_menu_agendar.Location = New Point(51, 320)
        btn_menu_agendar.Margin = New Padding(3, 2, 3, 2)
        btn_menu_agendar.Name = "btn_menu_agendar"
        btn_menu_agendar.Size = New Size(196, 38)
        btn_menu_agendar.TabIndex = 0
        btn_menu_agendar.Text = "Agendamento"
        btn_menu_agendar.TextAlign = ContentAlignment.TopCenter
        btn_menu_agendar.UseVisualStyleBackColor = False
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.formcliente1b
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(btn_agendar)
        TabPage1.Controls.Add(cmb_horarios)
        TabPage1.Controls.Add(dtp_dia)
        TabPage1.Controls.Add(cmb_profissional)
        TabPage1.Location = New Point(4, 5)
        TabPage1.Margin = New Padding(3, 2, 3, 2)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 2, 3, 2)
        TabPage1.Size = New Size(751, 376)
        TabPage1.TabIndex = 0
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(634, 4)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 25)
        Button2.TabIndex = 5
        Button2.Text = "Início"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(497, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 15)
        Label3.TabIndex = 8
        Label3.Text = "Selecione um horário:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 15)
        Label2.TabIndex = 7
        Label2.Text = "Selecione uma data:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 15)
        Label1.TabIndex = 6
        Label1.Text = "Selecione seu profissional:"
        ' 
        ' btn_agendar
        ' 
        btn_agendar.BackColor = Color.Black
        btn_agendar.FlatStyle = FlatStyle.Popup
        btn_agendar.Font = New Font("Segoe UI", 15F)
        btn_agendar.ForeColor = SystemColors.ButtonHighlight
        btn_agendar.Location = New Point(252, 280)
        btn_agendar.Margin = New Padding(3, 2, 3, 2)
        btn_agendar.Name = "btn_agendar"
        btn_agendar.Size = New Size(247, 38)
        btn_agendar.TabIndex = 5
        btn_agendar.Text = "Agendar"
        btn_agendar.UseVisualStyleBackColor = False
        ' 
        ' cmb_horarios
        ' 
        cmb_horarios.BackColor = SystemColors.InactiveCaptionText
        cmb_horarios.FlatStyle = FlatStyle.Popup
        cmb_horarios.ForeColor = SystemColors.InactiveBorder
        cmb_horarios.FormattingEnabled = True
        cmb_horarios.Location = New Point(497, 60)
        cmb_horarios.Margin = New Padding(3, 2, 3, 2)
        cmb_horarios.Name = "cmb_horarios"
        cmb_horarios.Size = New Size(198, 23)
        cmb_horarios.TabIndex = 4
        ' 
        ' dtp_dia
        ' 
        dtp_dia.CalendarForeColor = SystemColors.ButtonHighlight
        dtp_dia.CalendarMonthBackground = SystemColors.InactiveCaptionText
        dtp_dia.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtp_dia.CalendarTitleForeColor = SystemColors.ButtonHighlight
        dtp_dia.CalendarTrailingForeColor = Color.DarkOrange
        dtp_dia.CausesValidation = False
        dtp_dia.Location = New Point(276, 61)
        dtp_dia.Margin = New Padding(3, 2, 3, 2)
        dtp_dia.Name = "dtp_dia"
        dtp_dia.Size = New Size(198, 23)
        dtp_dia.TabIndex = 3
        dtp_dia.Value = New Date(2024, 6, 12, 0, 0, 0, 0)
        ' 
        ' cmb_profissional
        ' 
        cmb_profissional.BackColor = SystemColors.InactiveCaptionText
        cmb_profissional.FlatStyle = FlatStyle.Popup
        cmb_profissional.ForeColor = SystemColors.InactiveBorder
        cmb_profissional.FormattingEnabled = True
        cmb_profissional.Location = New Point(56, 60)
        cmb_profissional.Margin = New Padding(3, 2, 3, 2)
        cmb_profissional.Name = "cmb_profissional"
        cmb_profissional.Size = New Size(198, 23)
        cmb_profissional.TabIndex = 2
        cmb_profissional.Text = "Escolha um profissional"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), Image)
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(Button3)
        TabPage3.Location = New Point(4, 5)
        TabPage3.Margin = New Padding(3, 2, 3, 2)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 2, 3, 2)
        TabPage3.Size = New Size(751, 376)
        TabPage3.TabIndex = 2
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(634, 4)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 25)
        Button3.TabIndex = 5
        Button3.Text = "Início"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btn_sair
        ' 
        btn_sair.FlatStyle = FlatStyle.Flat
        btn_sair.ForeColor = SystemColors.ButtonHighlight
        btn_sair.Location = New Point(648, 8)
        btn_sair.Margin = New Padding(3, 2, 3, 2)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(82, 25)
        btn_sair.TabIndex = 4
        btn_sair.Text = "Logout"
        btn_sair.UseVisualStyleBackColor = True
        ' 
        ' lbl_usuario
        ' 
        lbl_usuario.Anchor = AnchorStyles.Left
        lbl_usuario.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbl_usuario.ForeColor = Color.SeaShell
        lbl_usuario.Location = New Point(14, 11)
        lbl_usuario.Name = "lbl_usuario"
        lbl_usuario.RightToLeft = RightToLeft.No
        lbl_usuario.Size = New Size(301, 19)
        lbl_usuario.TabIndex = 3
        lbl_usuario.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(322, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 25)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' form_cliente1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(780, 430)
        Controls.Add(PictureBox1)
        Controls.Add(btn_sair)
        Controls.Add(lbl_usuario)
        Controls.Add(tab_cliente1)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "form_cliente1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_cliente1"
        tab_cliente1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tab_cliente1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmb_profissional As ComboBox
    Friend WithEvents dtp_dia As DateTimePicker
    Friend WithEvents cmb_horarios As ComboBox
    Friend WithEvents btn_agendar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_menu_agendar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_sobre As Button
    Private WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
End Class
