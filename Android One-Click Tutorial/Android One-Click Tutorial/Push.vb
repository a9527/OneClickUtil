Public Class Push

    Private Sub Push_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "Select the folder containing the file/s you want to push to the device..."
        FolderBrowse.ShowNewFolderButton = False
        FolderBrowse.RootFolder = Environment.SpecialFolder.DesktopDirectory
        Dim DialogRes As DialogResult = FolderBrowse.ShowDialog()
        If DialogRes = Windows.Forms.DialogResult.OK Then
            For Each Item As String In My.Computer.FileSystem.GetFiles(FolderBrowse.SelectedPath)
                ListBox1.Items.Add(Item)
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Shell("""ADB\adb.exe"" push " & ListBox1.SelectedItem & " " & TextBox1.Text, AppWinStyle.NormalFocus, True, 30000)
    End Sub
End Class