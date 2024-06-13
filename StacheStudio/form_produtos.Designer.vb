<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_produtos
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
        btn_voltar = New Button()
        SuspendLayout()
        ' 
        ' btn_voltar
        ' 
        btn_voltar.Location = New Point(26, 22)
        btn_voltar.Name = "btn_voltar"
        btn_voltar.Size = New Size(75, 23)
        btn_voltar.TabIndex = 0
        btn_voltar.Text = "Voltar"
        btn_voltar.UseVisualStyleBackColor = True
        ' 
        ' form_produtos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_voltar)
        Name = "form_produtos"
        Text = "form_produtos"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_voltar As Button
End Class
