
Imports System.IO
Imports System.Windows.Forms
Public Class painel
    Private Sub painel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub painel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim xNumero_Largura, yNumero_Altura As Integer 'Campo do Contador'
        Dim xAtendimento_Largura, yAtendimento_Altura As Integer 'Campo Label Atendimento'
        Dim Xlogo_img_Largura, Ylogo_img_Altura As Integer 'Campo historeico 1'
        Dim Xhistorico1_Largura, Yhistorico1_Altura As Integer 'Campo historeico 1'
        Dim Xcolor1_largura, Ycolor1_Altura As Integer 'Cor de fundo do Ultimas chamadas'
        Dim Xcolor2_largura, Ycolor2_Altura As Integer 'Cor de fundo do historico'
        Dim xlabelult_chamada_Largura, ylabelult_chamada_Altura As Integer
        Dim xhora_largura, yhora_altura As Integer


        'Posicionamento Número da Chamada INICIO'


        xNumero_Largura = (Me.Width - LabelChamada.Width) / 2.2
        yNumero_Altura = (Me.Height - LabelChamada.Height) / 3


        'Posicionamento Número da chamada FIM'

        '******************************************************************************'

        'Posicionamento  Atendimento em cima do Número INICIO'
        xAtendimento_Largura = (Me.Width - LabelAtendimento.Width) / 2.2
        yAtendimento_Altura = (Me.Height - LabelAtendimento.Height) / 5.7
        'Posicionamento Atendimento em cima do Número FIM'

        '******************************************************************************'

        '******************************************************************************'
        'Posicionamento Historicos Inicio'


        Xhistorico1_Largura = (Me.Width - txthistorico1.Width) / 4.8
        Yhistorico1_Altura = (Me.Height - txthistorico1.Height) / 1.15 'Historico 1'

        'Posicionamento Historicos Fim'
        '******************************************************************************'
        'Barras do historico'

        Xcolor2_largura = (Me.Width - color2.Width) / 0.1
        Ycolor2_Altura = (Me.Height - color2.Height) / 1.1 'color2 = barra azul marinho'
        Xcolor1_largura = (Me.Width - color1.Width) / 0.1
        Ycolor1_Altura = (Me.Height - color1.Height) / 1.5 'color1 = barra preta'
        xlabelult_chamada_Largura = (Me.Width - labelult_chamada.Width) / 7
        ylabelult_chamada_Altura = (Me.Height - labelult_chamada.Height) / 1.5 'Ultimas Chamadas'


        '******************************************************************************'

        xhora_largura = (Me.Width - lblhora.Width) / 1.3
        yhora_altura = (Me.Height - lblhora.Height) / 1.5  'Hora'

        '******************************************************************************'

        Xlogo_img_Largura = (Me.Width - logo_img.Width) / 1.4
        Ylogo_img_Altura = (Me.Height - logo_img.Height) / 1.1 'Logo Marca'

        '******************************************************************************'

        'ação'


        LabelChamada.Location = New Point(xNumero_Largura, yNumero_Altura)
        LabelAtendimento.Location = New Point(xAtendimento_Largura, yAtendimento_Altura)
        logo_img.Location = New Point(Xlogo_img_Largura, Ylogo_img_Altura)
        txthistorico1.Location = New Point(Xhistorico1_Largura, Yhistorico1_Altura)
        color2.Location = New Point(Xcolor2_largura, Ycolor2_Altura)
        color1.Location = New Point(Xcolor1_largura, Ycolor1_Altura)
        labelult_chamada.Location = New Point(xlabelult_chamada_Largura, ylabelult_chamada_Altura)
        lblhora.Location = New Point(xhora_largura, yhora_altura)
        'Fim ação'

        LabelChamada.Font = New Font(LabelChamada.Font.FontFamily, 100) 'font alterada do contador'
        txthistorico1.Font = New Font(LabelChamada.Font.FontFamily, 75) 'font alterada do historico'

    End Sub

    Private Sub Label1_click(sender As Object, e As EventArgs) Handles LabelChamada.Invalidated
        My.Computer.Audio.Play(My.Resources.som_atendimento, AudioPlayMode.Background)
        Dim a As String

        'Abaixo selecionar o caminho do arquivo local...'
        Using x1 As New StreamReader("F:\Documentos\programação\Visual Studio\appchamada2\app\bin\Debug\historico.text")
            Do While x1.Peek <> -1

                txthistorico1.Text = x1.ReadLine

            Loop
            a = txthistorico1.Text

        End Using


    End Sub

    Private Sub painel_Validated(sender As Object, e As EventArgs) Handles Me.Validated

    End Sub

    Private Sub painel_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

    End Sub

    Private Sub Lblhistorico1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lblhistorico1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class