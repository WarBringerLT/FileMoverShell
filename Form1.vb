Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Multiselect = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button5.Text = "MODE: Files" Then
             OpenFileDialog1.ShowDialog()
            TextBox1.Text = OpenFileDialog1.FileName

        Else
            FolderBrowserDialog1.ShowDialog()
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            TextBox2.Text = FolderBrowserDialog2.SelectedPath
        End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog2.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog2.SelectedPath
    End Sub



    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub FolderBrowserDialog2_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog2.HelpRequest
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        TextBox2.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Check selected folders!", MsgBoxStyle.Exclamation)
        Else
            MsgBox("If files are big, the program may show ""Not Responding"", so please wait, program is working..", MsgBoxStyle.Information)
            MsgBox("Created by: WarBringerLT", MsgBoxStyle.Information)
            Shell("C:\Windows\System32\cmd.exe /k move """ & TextBox1.Text & """ """ & TextBox2.Text & """") 'AppWinStyle.Hide)

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "MODE: Folders" Then
            Button5.Text = "MODE: Files"
            Label1.Text = "Move File:"

        Else
            Button5.Text = "MODE: Folders"
            Label1.Text = "Move Folder:"
        End If
    End Sub


End Class
