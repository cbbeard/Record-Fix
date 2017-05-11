Imports System
Imports System.IO
Imports System.Diagnostics
' RECORD.DAT FIXER BY Chris Beard 3/15/2017
' DELETES RECORD.DAT AND ENDS ALL CURRENT FLEXPLAY PROCESSES
' edit 3/27



Public Class Fix
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub FixButton_Click(sender As Object, e As EventArgs) Handles FixButton.Click
        ' Get drive info
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
            Dim d As DriveInfo
            Dim RECORD As String
        Dim procsToKill() As String = {"FPL16Pro", "FPL16Player", "FPL18Player", "FPLPro7", "FPLPro7M"}
        ' Kill current processes to prevent error
        For Each p As Process In Process.GetProcesses
            If procsToKill.Contains(p.ProcessName) Then
                p.Kill()
            End If
        Next
        For Each d In allDrives
            ' Delete record.dat
            RECORD = System.IO.Path.Combine(d.Name, "RECORD.DAT")
            If System.IO.File.Exists(RECORD) = True Then
                File.SetAttributes(RECORD, FileAttributes.Normal)
                System.IO.File.Delete(RECORD)
                MessageBox.Show("Success! Now open Flexplay.")
            End If
        Next
    End Sub
End Class
