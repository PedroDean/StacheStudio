<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_info_ss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_info_ss))
        lbl_agendamento = New Label()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_agendamento
        ' 
        lbl_agendamento.AutoSize = True
        lbl_agendamento.BackColor = Color.Transparent
        lbl_agendamento.ForeColor = SystemColors.ButtonFace
        lbl_agendamento.Location = New Point(24, 133)
        lbl_agendamento.Name = "lbl_agendamento"
        lbl_agendamento.Size = New Size(0, 15)
        lbl_agendamento.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(lbl_agendamento)
        GroupBox1.Location = New Point(12, 11)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(316, 449)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "StacheStudio"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(36, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 12
        Label1.Text = "Lucas Fernando da Silva" & vbTab
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(36, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 13
        Label2.Text = "Pedro Dean"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(36, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 15)
        Label3.TabIndex = 14
        Label3.Text = "Robson Sousa Ferreira"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaptionText
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(175, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 15)
        Label6.TabIndex = 15
        Label6.Text = "RA: 1680482321034"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(175, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 15)
        Label4.TabIndex = 16
        Label4.Text = "RA: 1680482321031"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(175, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 17
        Label5.Text = "RA: 1680482321013"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(109, 75)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 15)
        Label7.TabIndex = 18
        Label7.Text = "Desenvolvedores:"
        ' 
        ' form_info_ss
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(340, 471)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "form_info_ss"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_info_ss"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl_agendamento As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
