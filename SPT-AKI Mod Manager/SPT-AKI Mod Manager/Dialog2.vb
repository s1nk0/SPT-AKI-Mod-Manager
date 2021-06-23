Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.modFolder = TextBox1.Text
        My.Settings.modRepo = TextBox2.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        TextBox1.Clear()
        TextBox2.Clear()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
        'If Not TextBox1.Text = "" Then
        '    If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
        '        My.Settings.modFolder = TextBox1.Text
        '    Else
        '        MsgBox("Requested directory does not exist! Please try again.")
        '    End If
        'Else
        '    MsgBox("Please set the location of your mods folder within the user directory of your SPT-AKI install.")
        '    TextBox1.Text = My.Settings.modFolder
        'End If
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.loadSettings()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath

        End If
    End Sub
End Class
