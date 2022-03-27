<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class painel
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(painel))
        Me.LabelChamada = New System.Windows.Forms.Label()
        Me.LabelAtendimento = New System.Windows.Forms.Label()
        Me.labelult_chamada = New System.Windows.Forms.Label()
        Me.color2 = New System.Windows.Forms.PictureBox()
        Me.color1 = New System.Windows.Forms.PictureBox()
        Me.txthistorico1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.logo_img = New System.Windows.Forms.PictureBox()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.color2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.color1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelChamada
        '
        Me.LabelChamada.AutoSize = True
        Me.LabelChamada.Cursor = System.Windows.Forms.Cursors.No
        Me.LabelChamada.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChamada.ForeColor = System.Drawing.Color.Yellow
        Me.LabelChamada.Location = New System.Drawing.Point(349, 79)
        Me.LabelChamada.Name = "LabelChamada"
        Me.LabelChamada.Size = New System.Drawing.Size(153, 111)
        Me.LabelChamada.TabIndex = 0
        Me.LabelChamada.Text = "xx"
        '
        'LabelAtendimento
        '
        Me.LabelAtendimento.AutoSize = True
        Me.LabelAtendimento.Font = New System.Drawing.Font("Verdana", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAtendimento.ForeColor = System.Drawing.Color.White
        Me.LabelAtendimento.Location = New System.Drawing.Point(178, 21)
        Me.LabelAtendimento.Name = "LabelAtendimento"
        Me.LabelAtendimento.Size = New System.Drawing.Size(498, 78)
        Me.LabelAtendimento.TabIndex = 1
        Me.LabelAtendimento.Text = "Atendimento"
        '
        'labelult_chamada
        '
        Me.labelult_chamada.AutoSize = True
        Me.labelult_chamada.BackColor = System.Drawing.Color.Black
        Me.labelult_chamada.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelult_chamada.ForeColor = System.Drawing.Color.White
        Me.labelult_chamada.Location = New System.Drawing.Point(29, 243)
        Me.labelult_chamada.Name = "labelult_chamada"
        Me.labelult_chamada.Size = New System.Drawing.Size(281, 41)
        Me.labelult_chamada.TabIndex = 6
        Me.labelult_chamada.Text = "Ultima chamada"
        '
        'color2
        '
        Me.color2.BackColor = System.Drawing.Color.MidnightBlue
        Me.color2.Location = New System.Drawing.Point(-23, 305)
        Me.color2.Name = "color2"
        Me.color2.Size = New System.Drawing.Size(65535, 170)
        Me.color2.TabIndex = 10
        Me.color2.TabStop = False
        '
        'color1
        '
        Me.color1.BackColor = System.Drawing.Color.Black
        Me.color1.Location = New System.Drawing.Point(2, 224)
        Me.color1.Name = "color1"
        Me.color1.Size = New System.Drawing.Size(65535, 90)
        Me.color1.TabIndex = 17
        Me.color1.TabStop = False
        '
        'txthistorico1
        '
        Me.txthistorico1.AutoSize = True
        Me.txthistorico1.BackColor = System.Drawing.Color.MidnightBlue
        Me.txthistorico1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthistorico1.ForeColor = System.Drawing.Color.Yellow
        Me.txthistorico1.Location = New System.Drawing.Point(132, 368)
        Me.txthistorico1.Name = "txthistorico1"
        Me.txthistorico1.Size = New System.Drawing.Size(155, 36)
        Me.txthistorico1.TabIndex = 18
        Me.txthistorico1.Text = "Historico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'logo_img
        '
        Me.logo_img.BackColor = System.Drawing.Color.MidnightBlue
        Me.logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logo_img.Image = Global.app.My.Resources.Resources.Logo
        Me.logo_img.Location = New System.Drawing.Point(368, 305)
        Me.logo_img.Name = "logo_img"
        Me.logo_img.Size = New System.Drawing.Size(351, 160)
        Me.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_img.TabIndex = 22
        Me.logo_img.TabStop = False
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.Black
        Me.lblhora.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.Yellow
        Me.lblhora.Location = New System.Drawing.Point(490, 243)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(0, 59)
        Me.lblhora.TabIndex = 23
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'painel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumBlue
        Me.ClientSize = New System.Drawing.Size(830, 460)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.logo_img)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txthistorico1)
        Me.Controls.Add(Me.LabelAtendimento)
        Me.Controls.Add(Me.LabelChamada)
        Me.Controls.Add(Me.labelult_chamada)
        Me.Controls.Add(Me.color2)
        Me.Controls.Add(Me.color1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "painel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System.Painel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.color2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.color1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelChamada As Label
    Friend WithEvents LabelAtendimento As Label
    Friend WithEvents labelult_chamada As Label
    Friend WithEvents color2 As PictureBox
    Friend WithEvents color1 As PictureBox
    Friend WithEvents txthistorico1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logo_img As PictureBox
    Friend WithEvents lblhora As Label
    Friend WithEvents timer As Timer
End Class
