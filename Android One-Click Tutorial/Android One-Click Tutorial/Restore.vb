Public Class Restore

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFile.Multiselect = False
        OpenFile.Filter = "AB (Android Backups)|*.ab"
        OpenFile.SupportMultiDottedExtensions = False
        OpenFile.Title = "Select the Android Backup (*.ab) file to restore your device from..."
        Dim DialogRes As DialogResult = OpenFile.ShowDialog()
        If DialogRes = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("""ADB\adb.exe"" restore " & TextBox1.Text, AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Restore_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class