﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyChangesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenModFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRepositoryFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableAllModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsiableAllModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(15, 170)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.ScrollAlwaysVisible = True
        Me.CheckedListBox1.Size = New System.Drawing.Size(428, 140)
        Me.CheckedListBox1.TabIndex = 5
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddModToolStripMenuItem, Me.EnableToolStripMenuItem, Me.DsToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ApplyChangesToolStripMenuItem, Me.ViewFolderToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 180)
        '
        'AddModToolStripMenuItem
        '
        Me.AddModToolStripMenuItem.Name = "AddModToolStripMenuItem"
        Me.AddModToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddModToolStripMenuItem.Text = "Add Mod"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DsToolStripMenuItem
        '
        Me.DsToolStripMenuItem.Name = "DsToolStripMenuItem"
        Me.DsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DsToolStripMenuItem.Text = "Disable"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ApplyChangesToolStripMenuItem
        '
        Me.ApplyChangesToolStripMenuItem.Name = "ApplyChangesToolStripMenuItem"
        Me.ApplyChangesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ApplyChangesToolStripMenuItem.Text = "Apply Changes"
        '
        'ViewFolderToolStripMenuItem
        '
        Me.ViewFolderToolStripMenuItem.Name = "ViewFolderToolStripMenuItem"
        Me.ViewFolderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewFolderToolStripMenuItem.Text = "View Folder"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mod List:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DirectoriesToolStripMenuItem, Me.SelectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchToolStripMenuItem, Me.ModsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LaunchToolStripMenuItem
        '
        Me.LaunchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.LauncherToolStripMenuItem})
        Me.LaunchToolStripMenuItem.Name = "LaunchToolStripMenuItem"
        Me.LaunchToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LaunchToolStripMenuItem.Text = "Launch"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'LauncherToolStripMenuItem
        '
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LauncherToolStripMenuItem.Text = "Launcher"
        '
        'ModsToolStripMenuItem
        '
        Me.ModsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.ApplyChangesToolStripMenuItem1})
        Me.ModsToolStripMenuItem.Name = "ModsToolStripMenuItem"
        Me.ModsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ModsToolStripMenuItem.Text = "Mods"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ApplyChangesToolStripMenuItem1
        '
        Me.ApplyChangesToolStripMenuItem1.Name = "ApplyChangesToolStripMenuItem1"
        Me.ApplyChangesToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ApplyChangesToolStripMenuItem1.Text = "Apply Changes"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DirectoriesToolStripMenuItem
        '
        Me.DirectoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenModFolderToolStripMenuItem, Me.OpenRepositoryFolderToolStripMenuItem, Me.GameFolderToolStripMenuItem, Me.ProfilesToolStripMenuItem})
        Me.DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem"
        Me.DirectoriesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DirectoriesToolStripMenuItem.Text = "Directories"
        '
        'OpenModFolderToolStripMenuItem
        '
        Me.OpenModFolderToolStripMenuItem.Name = "OpenModFolderToolStripMenuItem"
        Me.OpenModFolderToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenModFolderToolStripMenuItem.Text = "Deployed Mods"
        '
        'OpenRepositoryFolderToolStripMenuItem
        '
        Me.OpenRepositoryFolderToolStripMenuItem.Name = "OpenRepositoryFolderToolStripMenuItem"
        Me.OpenRepositoryFolderToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenRepositoryFolderToolStripMenuItem.Text = "Downloaded Mods"
        '
        'GameFolderToolStripMenuItem
        '
        Me.GameFolderToolStripMenuItem.Name = "GameFolderToolStripMenuItem"
        Me.GameFolderToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GameFolderToolStripMenuItem.Text = "Game Directory"
        '
        'ProfilesToolStripMenuItem
        '
        Me.ProfilesToolStripMenuItem.Name = "ProfilesToolStripMenuItem"
        Me.ProfilesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ProfilesToolStripMenuItem.Text = "Profiles"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableAllModsToolStripMenuItem, Me.DsiableAllModsToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'EnableAllModsToolStripMenuItem
        '
        Me.EnableAllModsToolStripMenuItem.Name = "EnableAllModsToolStripMenuItem"
        Me.EnableAllModsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EnableAllModsToolStripMenuItem.Text = "Select all mods"
        '
        'DsiableAllModsToolStripMenuItem
        '
        Me.DsiableAllModsToolStripMenuItem.Name = "DsiableAllModsToolStripMenuItem"
        Me.DsiableAllModsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DsiableAllModsToolStripMenuItem.Text = "Deselect all mods"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(428, 82)
        Me.ListBox1.TabIndex = 25
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(322, 330)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 47)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Play"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(463, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "ZIP files|*.zip"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(332, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(353, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(401, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Profile:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 428)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(471, 456)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPT-AKI Mod Manager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenModFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenRepositoryFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GameFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaunchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LauncherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableAllModsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DsiableAllModsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyChangesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ApplyChangesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
