Imports System.IO
Imports System.Windows.Forms

Public Class app_principal
    Private Sub btnabrir_Click(sender As Object, e As EventArgs) Handles btnabrir.Click
        painel.Show()
        painel.LabelChamada.Text = 0
        btnabrir.Enabled = False

    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        painel.Close()
        btnabrir.Enabled = True
        btnfechar.Enabled = False

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Application.Restart()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim num1 As Integer

        num1 = 1


        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim num1 As Integer

        num1 = 2

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim num1 As Integer

        num1 = 3

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num1 As Integer

        num1 = 4

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1 As Integer

        num1 = 5

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Integer

        num1 = 6

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer

        num1 = 7

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim num1 As Integer

        num1 = 8

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim num1 As Integer

        num1 = 9

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer

        num1 = 10

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim num1 As Integer

        num1 = 11

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim num1 As Integer

        num1 = 12

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim num1 As Integer

        num1 = 13

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim num1 As Integer

        num1 = 14

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim num1 As Integer

        num1 = 15

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim num1 As Integer

        num1 = 16

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim num1 As Integer

        num1 = 17

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim num1 As Integer

        num1 = 18

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim num1 As Integer

        num1 = 19

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim num1 As Integer

        num1 = 20

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim num1 As Integer

        num1 = 21

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim num1 As Integer

        num1 = 22

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim num1 As Integer

        num1 = 23

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim num1 As Integer

        num1 = 24

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim num1 As Integer

        num1 = 25

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim num1 As Integer

        num1 = 26

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim num1 As Integer

        num1 = 27

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim num1 As Integer

        num1 = 28

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim num1 As Integer

        num1 = 29

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim num1 As Integer

        num1 = 30

        painel.Show()
        painel.LabelChamada.Text = num1
        monitor.Text = (num1)
        Dim historico As String = num1
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static x As Integer = 30

        x += 1

        painel.LabelChamada.Text = (x)
        monitor.Text = (x)
        Dim historico As String = x
        Dim texto As New StreamWriter(Application.StartupPath & "/historico.text")
        texto.WriteLine(historico)
        texto.Flush()
        texto.Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        monitor.Text = 0
        painel.LabelChamada.Text = 0
    End Sub

    Private Sub app_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
