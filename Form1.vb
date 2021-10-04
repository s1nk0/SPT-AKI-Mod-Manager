Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json.Linq
Imports System.Threading
Imports System.Net
Imports System.Diagnostics

Public Class Form1
    Dim zipFiles As New List(Of String)
    Dim modsEnabled As New List(Of String)
    Dim modsInstalled As New List(Of String)
    Dim modsDisabled As New List(Of String)
    Dim modsUninstalled As New List(Of String)
    Dim readProfile As New List(Of String)
    Dim filepath As String = ""
    Dim gameFolderPath As String = ""
    Dim modFolderPath As String = ""
    Dim lastProfileName As String = ""
    Public latestVersion As String = ""

    Sub applyChanges()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")
        If My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text) Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                Dim modName As String = CheckedListBox1.Items.Item(i)
                If CheckedListBox1.GetItemCheckState(i).ToString = "Checked" Then
                    Dim installTo = """" + Dialog2.TextBox1.Text + "\user\mods\" + modName + """"
                    Dim installFrom = """" + Dialog2.TextBox2.Text + "\" + modName + """"

                    If My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text + "\user\mods\" + modName) Then

                        modsEnabled.Add(modName)
                    Else
                        Process.Start("CMD", "/c " + driveLetter(0) + "& mklink /J " + installTo + " " + installFrom)
                        modsInstalled.Add(modName)
                    End If
                ElseIf CheckedListBox1.GetItemCheckState(i).ToString = "Unchecked" Then
                    If Not My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text + "\user\mods\" + modName) Then
                        modsDisabled.Add(modName)
                    Else
                        My.Computer.FileSystem.DeleteDirectory(Dialog2.TextBox1.Text + "\user\mods\" + modName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                        modsUninstalled.Add(modName)
                    End If
                End If
            Next
            If modsInstalled.Count > 0 Then
                For Each item In modsInstalled
                Next
            End If
            If modsEnabled.Count > 0 Then
            End If
            If modsUninstalled.Count > 0 Then
                For Each item In modsUninstalled
                Next
            End If
            modsEnabled.Clear()
            modsInstalled.Clear()
            modsDisabled.Clear()
            modsUninstalled.Clear()
        Else
            MsgBox("Saved mod folder does not exist! Please set it again.")
            gameFolderPath = ""
        End If
    End Sub
    Sub enableModTest()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")
        If My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text) Then
            Dim installTo = """" + Dialog2.TextBox1.Text + "\user\mods\" + CheckedListBox1.SelectedItem.ToString + """"
            Dim installFrom = """" + Dialog2.TextBox2.Text + "\" + CheckedListBox1.SelectedItem.ToString + """"
            If Not My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text + "\user\mods\" + CheckedListBox1.SelectedItem.ToString) Then
                Process.Start("CMD", "/c " + driveLetter(0) + "& mklink /J " + installTo + " " + installFrom)
            End If

        End If
        refreshMods()
    End Sub
    Sub disableModTest()
        If Not My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text + "\user\mods\" + CheckedListBox1.SelectedItem.ToString) Then

        Else
            Dim confirmDelete As Integer
            confirmDelete = MsgBox("Are you sure you want to disable " + """" + CheckedListBox1.SelectedItem.ToString + """" + " mod?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Disable")
            If confirmDelete = vbYes Then
                My.Computer.FileSystem.DeleteDirectory(Dialog2.TextBox1.Text + "\user\mods\" + CheckedListBox1.SelectedItem.ToString, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If
        End If
    End Sub
    Sub enableMod()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")

        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub

    Sub disableMod()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        enableMod()
    End Sub
    Sub refreshMods()
        If Not Dialog2.TextBox2.Text = "" Then
            Dim modRepo As String = """" + Dialog2.TextBox2.Text + """"

            CheckedListBox1.Items.Clear()
            If My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox2.Text) Then
                For Each item As String In My.Computer.FileSystem.GetDirectories(Dialog2.TextBox2.Text)
                    Dim modName As String = item.Substring(item.LastIndexOf("\") + 1)
                    CheckedListBox1.Items.Add(modName)
                Next
                modFolderPath = Dialog2.TextBox2.Text
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SelectedIndex = i
                    If My.Computer.FileSystem.DirectoryExists(Dialog2.TextBox1.Text + "\user\mods\" + CheckedListBox1.SelectedItem) Then
                        CheckedListBox1.SetItemChecked(i, True)
                    End If
                Next
            Else
                MsgBox("Mod repository directory does not exist! Please set it again File > Settings.")
                modFolderPath = ""
            End If
            For Each item As String In My.Computer.FileSystem.GetDirectories(Dialog2.TextBox1.Text + "\user\mods")
                Dim modName As String = item.Substring(item.LastIndexOf("\") + 1)
                If Not CheckedListBox1.Items.Contains(modName) Then
                    MsgBox("Mod " + """" + modName + """" + " exists in mod folder but not mod list! Deleting hard link...")
                    My.Computer.FileSystem.DeleteDirectory(item, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

                End If
            Next
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        refreshMods()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        disableMod()
    End Sub

    Sub loadPaths()
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\paths\gameFolder.txt") Or Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\paths\modsFolder.txt") Then
            MsgBox("Please set directories again under File > Settings.")
        Else
            gameFolderPath = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\paths\gameFolder.txt")
            modFolderPath = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\paths\modsFolder.txt")
            Dialog2.TextBox1.Text = gameFolderPath
            Dialog2.TextBox2.Text = modFolderPath
            refreshMods()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ""
        loadPaths()
        loadProfiles()
    End Sub

    Private Sub OpenModFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenModFolderToolStripMenuItem.Click
        If Not Dialog2.TextBox1.Text = "" Then
            Process.Start(Dialog2.TextBox1.Text + "\user\mods")
        End If
    End Sub

    Private Sub OpenRepositoryFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRepositoryFolderToolStripMenuItem.Click
        If Not Dialog2.TextBox2.Text = "" Then
            Process.Start(Dialog2.TextBox2.Text)
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        Dim json As String = File.ReadAllText(Dialog2.TextBox2.Text + "\" + CheckedListBox1.SelectedItem.ToString + "\package.json")
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

        ListBox1.Items.Add("Mod name: " + read.Item("name").ToString)
        ListBox1.Items.Add("Author: " + read.Item("author").ToString)
        ListBox1.Items.Add("Version: " + read.Item("version").ToString)
        ListBox1.Items.Add("License: " + read.Item("license").ToString)

    End Sub
    Private Sub GameFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameFolderToolStripMenuItem.Click
        Process.Start(Dialog2.TextBox1.Text)
    End Sub
    Sub startServer()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")
        Process.Start("CMD", "/c " + driveLetter(0) + "& cd " + gameFolderPath.ToString + "& Server.exe")
    End Sub
    Sub startLauncher()
        Dim driveLetter = Split(Dialog2.TextBox1.Text, "\")
        Process.Start("CMD", "/c " + driveLetter(0) + "& cd " + gameFolderPath.ToString + "& Launcher.exe")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        startServer()
        Threading.Thread.Sleep(5000)
        startLauncher()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub ServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerToolStripMenuItem.Click
        startServer()
    End Sub

    Private Sub LauncherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LauncherToolStripMenuItem.Click
        startLauncher()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim confirmDelete As Integer

        confirmDelete = MsgBox("Are you sure you want to delete " + """" + CheckedListBox1.SelectedItem.ToString + """" + " mod from your mod list?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Delete")
        If confirmDelete = vbYes Then
            My.Computer.FileSystem.DeleteDirectory(Dialog2.TextBox2.Text + "\" + CheckedListBox1.SelectedItem.ToString, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            refreshMods()
        End If
    End Sub

    Private Sub DsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DsToolStripMenuItem.Click
        disableModTest()
        refreshMods()
    End Sub

    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableToolStripMenuItem.Click
        enableModTest()
        refreshMods()
    End Sub

    Private Sub ViewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFolderToolStripMenuItem.Click
        Process.Start(Dialog2.TextBox2.Text + "\" + CheckedListBox1.SelectedItem.ToString)
    End Sub

    Private Sub CheckedListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles CheckedListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Sub unzipFiles()
        ToolStripProgressBar1.Maximum = zipFiles.Count
        ToolStripStatusLabel1.Text = "Installing mods, please wait..."
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub CheckedListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles CheckedListBox1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            zipFiles.Add(path)
        Next
        unzipFiles()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim sum As Integer = 0
        BackgroundWorker1.ReportProgress(0)
        For Each item In zipFiles
            Dim extractPath As String = modFolderPath
            ZipFile.ExtractToDirectory(item.ToString, extractPath.ToString)
            BackgroundWorker1.ReportProgress(sum + 1)
        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ToolStripStatusLabel1.Text = "Install complete!"
        ToolStripProgressBar1.Value = zipFiles.Count
        refreshMods()
        zipFiles.Clear()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub EnableAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
        enableMod()
    End Sub

    Private Sub DisableAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
        disableMod()
    End Sub

    Private Sub EnableAllModsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableAllModsToolStripMenuItem.Click
        enableMod()
    End Sub

    Private Sub DsiableAllModsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DsiableAllModsToolStripMenuItem.Click
        disableMod()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1

            MsgBox(CheckedListBox1.GetItemCheckState(i).ToString)
        Next
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        refreshMods()
    End Sub

    Private Sub ApplyChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyChangesToolStripMenuItem.Click
        applyChanges()
    End Sub
    Sub addMod()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            For Each file In OpenFileDialog1.FileNames
                zipFiles.Add(file)
            Next
            unzipFiles()
        End If
    End Sub
    Private Sub AddModToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddModToolStripMenuItem.Click
        addMod()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        addMod()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        disableModTest()
    End Sub

    Private Sub ApplyChangesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ApplyChangesToolStripMenuItem1.Click
        applyChanges()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.Text = "" Then
            Dim lst As String = ""
            For Each foundFile As String In My.Computer.FileSystem.GetDirectories(gameFolderPath + "\user\mods")
                lst &= My.Computer.FileSystem.GetName(foundFile) & vbCrLf
            Next
            Dim line As System.IO.StreamWriter
            filepath = My.Computer.FileSystem.CurrentDirectory + "\profiles\" + ComboBox1.Text + ".txt"
            If My.Computer.FileSystem.FileExists(filepath) Then
                Dim confirmOverwrite As Integer
                confirmOverwrite = MsgBox("Are you sure you want to overwrite the current profile?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Overwrite")
                If confirmOverwrite = vbYes Then
                    line = My.Computer.FileSystem.OpenTextFileWriter(filepath, False)
                    line.WriteLine(lst)
                    line.Close()
                    applyChanges()
                    saveLastProfile()
                    MsgBox("Profile saved!")
                Else
                    MsgBox("Overwrite cancelled.")
                End If
            Else
                line = My.Computer.FileSystem.OpenTextFileWriter(filepath, False)
                line.WriteLine(lst)
                line.Close()
                applyChanges()
                saveLastProfile()
                MsgBox("Profile saved!")
            End If

        End If
    End Sub
    Sub saveLastProfile()
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory + "\paths\lastProfile.txt", ComboBox1.Text, False)
        loadProfiles()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim testString As String = ""
        If Not ComboBox1.Text = "" Then
            filepath = My.Computer.FileSystem.CurrentDirectory + "\profiles\" + ComboBox1.Text + ".txt"
            If My.Computer.FileSystem.FileExists(filepath) Then
                disableMod()
                readProfile.Clear()
                Dim fileReader As System.IO.StreamReader

                fileReader = My.Computer.FileSystem.OpenTextFileReader(filepath)
                Do Until fileReader.EndOfStream
                    testString &= fileReader.ReadLine & vbCrLf
                Loop
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    If testString.Contains(CheckedListBox1.Items.Item(i).ToString) Then
                        CheckedListBox1.SetItemChecked(i, True)
                    End If
                Next
                fileReader.Close()
            End If
            applyChanges()
            saveLastProfile()
            MsgBox("Profile loaded!")
        Else
            MsgBox("Requested profile does not exist!")
        End If

    End Sub
    Sub loadProfiles()
        ComboBox1.Items.Clear()
        For Each item As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory + "\profiles")
            Dim fileName As String = Path.GetFileNameWithoutExtension(item)
            ComboBox1.Items.Add(fileName)
        Next
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\paths\lastProfile.txt") Then
            lastProfileName = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\paths\lastProfile.txt")
            ComboBox1.Text = lastProfileName
        End If

    End Sub

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        ComboBox1.Text = ComboBox1.SelectedValue
    End Sub

    Private Sub ProfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilesToolStripMenuItem.Click
        Process.Start(My.Computer.FileSystem.CurrentDirectory + "\profiles")
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedItem.ToString.Contains("Mod name:") Then
            MsgBox(ListBox1.SelectedItem.ToString)
        End If
    End Sub
End Class
