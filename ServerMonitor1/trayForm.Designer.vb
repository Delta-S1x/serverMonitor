<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trayForm))
        Me.traymenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenServerMonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.traymenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'traymenu
        '
        Me.traymenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenServerMonitorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.traymenu.Name = "traymenu"
        Me.traymenu.Size = New System.Drawing.Size(185, 70)
        '
        'OpenServerMonitorToolStripMenuItem
        '
        Me.OpenServerMonitorToolStripMenuItem.Name = "OpenServerMonitorToolStripMenuItem"
        Me.OpenServerMonitorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OpenServerMonitorToolStripMenuItem.Text = "Open Server Monitor"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'trayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 365)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "trayForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "trayForm"
        Me.TopMost = True
        Me.traymenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents traymenu As ContextMenuStrip
    Friend WithEvents OpenServerMonitorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
