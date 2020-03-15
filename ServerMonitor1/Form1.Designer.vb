<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.startbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ServerAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerName = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.minus = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startbtn
        '
        Me.startbtn.Location = New System.Drawing.Point(170, 138)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(159, 24)
        Me.startbtn.TabIndex = 14
        Me.startbtn.Text = "Start"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Server Address"
        '
        'ServerAddress
        '
        Me.ServerAddress.Location = New System.Drawing.Point(253, 90)
        Me.ServerAddress.Name = "ServerAddress"
        Me.ServerAddress.Size = New System.Drawing.Size(191, 20)
        Me.ServerAddress.TabIndex = 12
        Me.ServerAddress.Text = "google.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Server Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Email (Optional)"
        '
        'ServerName
        '
        Me.ServerName.Location = New System.Drawing.Point(42, 90)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(191, 20)
        Me.ServerName.TabIndex = 9
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(45, 27)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(191, 20)
        Me.Email.TabIndex = 8
        '
        'minus
        '
        Me.minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.minus.Location = New System.Drawing.Point(42, 127)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(31, 35)
        Me.minus.TabIndex = 15
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.add.Location = New System.Drawing.Point(80, 127)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(31, 35)
        Me.add.TabIndex = 16
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 213)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.startbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ServerAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ServerName)
        Me.Controls.Add(Me.Email)
        Me.Name = "Form1"
        Me.Text = "Server Monitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ServerAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ServerName As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents minus As Button
    Friend WithEvents add As Button
End Class
