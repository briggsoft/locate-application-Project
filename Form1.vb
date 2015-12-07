Public Class Form1
    'Boot at Start up
    'Add timer to restart Application 
    'Restart every 5 to 10 mins or if you want Every second
    'and Of course [hide all]
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label1.Text = ("Notepad is not running")
        Label1.ForeColor = Color.Red

        If IsProcessRunning("notepad") = True Then
            'Action
            Label1.Text = ("notepad is running")
            Label1.ForeColor = Color.Green
        Else
            'No Action
            Label1.Text = ("Notepad is not running")
        End If
    End Sub
    'Important Function
    Public Function IsProcessRunning(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub
End Class
