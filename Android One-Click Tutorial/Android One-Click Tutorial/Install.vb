Public Class Install

    Private Sub Install_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "Select the folder containing your APK files."
        FolderBrowse.RootFolder = Environment.SpecialFolder.DesktopDirectory
        FolderBrowse.ShowNewFolderButton = False
        Dim DialogRes As DialogResult = FolderBrowse.ShowDialog()
        If DialogRes = Windows.Forms.DialogResult.OK Then
            For Each Item As String In My.Computer.FileSystem.GetFiles(FolderBrowse.SelectedPath)
                ListBox1.Items.Add(Item)
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Shell("""ADB\adb.exe"" install " & ListBox1.SelectedItem.ToString, AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Install_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class