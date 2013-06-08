Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.DialogResult
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("ADB") Then
            Directory.CreateDirectory("ADB")
        Else
            If Not File.Exists("ADB\adb.exe") Then
                File.WriteAllBytes("ADB\adb.exe", My.Resources.adb)
            End If
            If Not File.Exists("ADB\AdbWinApi.dll") Then
                File.WriteAllBytes("ADB\AdbWinApi.dll", My.Resources.AdbWinApi)
            End If
            If Not File.Exists("ADB\AdbWinUsbApi.dll") Then
                File.WriteAllBytes("ADB\AdbWinUsbApi.dll", My.Resources.AdbWinUsbApi)
            End If
            If Not File.Exists("ADB\fastboot.exe") Then
                File.WriteAllBytes("ADB\fastboot.exe", My.Resources.fastboot)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Backup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Restore.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Install.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Push.Show()
        Me.Hide()
    End Sub
End Class
