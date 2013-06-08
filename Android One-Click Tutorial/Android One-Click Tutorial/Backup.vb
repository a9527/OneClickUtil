Imports System.IO
Public Class Backup

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = "Backup_From_" & Date.Now.ToShortTimeString
        If Not Directory.Exists(TextBox1.Text) Then
            Directory.CreateDirectory(TextBox1.Text)
        End If
    End Sub

    Private Sub Backup_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "Select the destination of where you wish your backup to be saved to." _
            & "Note: Please do not choose locations with spaces in the directories. These may cause errors!"
        FolderBrowse.ShowNewFolderButton = True
        Dim DialogRes As DialogResult = FolderBrowse.ShowDialog
        If DialogRes = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowse.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("""ADB\adb.exe"" backup -f" & TextBox1.Text & "\" & TextBox2.Text & "-apk -system -full -all", AppWinStyle.NormalFocus, True, 30000)
    End Sub
End Class