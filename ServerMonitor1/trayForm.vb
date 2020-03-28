Public Class trayForm
    Private Sub trayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        traymenu.Show(Cursor.Position) 'Shows the Right click menu on the cursor position
        Me.Left = traymenu.Left + 1 'Puts the form behind the menu horizontally
        Me.Top = traymenu.Top + 1 'Puts the form behind the menu vertically

    End Sub

    Private Sub trayForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        End
    End Sub

    Private Sub OpenServerMonitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenServerMonitorToolStripMenuItem.Click
        Form1.Show()
        Form1.WindowState = System.Windows.Forms.FormWindowState.Normal

    End Sub
End Class