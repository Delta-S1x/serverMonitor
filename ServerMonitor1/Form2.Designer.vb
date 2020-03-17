<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SMTPAddressBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SMTPUsernameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SMTPPasswordBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SMTPPortBox = New System.Windows.Forms.TextBox()
        Me.SMTPOk = New System.Windows.Forms.Button()
        Me.SMTPCancel = New System.Windows.Forms.Button()
        Me.SMTPApply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SMTPAddressBox
        '
        Me.SMTPAddressBox.Location = New System.Drawing.Point(24, 38)
        Me.SMTPAddressBox.Name = "SMTPAddressBox"
        Me.SMTPAddressBox.Size = New System.Drawing.Size(150, 20)
        Me.SMTPAddressBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SMTP Server Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'SMTPUsernameBox
        '
        Me.SMTPUsernameBox.Location = New System.Drawing.Point(24, 93)
        Me.SMTPUsernameBox.Name = "SMTPUsernameBox"
        Me.SMTPUsernameBox.Size = New System.Drawing.Size(150, 20)
        Me.SMTPUsernameBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'SMTPPasswordBox
        '
        Me.SMTPPasswordBox.Location = New System.Drawing.Point(24, 137)
        Me.SMTPPasswordBox.Name = "SMTPPasswordBox"
        Me.SMTPPasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SMTPPasswordBox.Size = New System.Drawing.Size(150, 20)
        Me.SMTPPasswordBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Port:"
        '
        'SMTPPortBox
        '
        Me.SMTPPortBox.Location = New System.Drawing.Point(180, 38)
        Me.SMTPPortBox.Name = "SMTPPortBox"
        Me.SMTPPortBox.Size = New System.Drawing.Size(38, 20)
        Me.SMTPPortBox.TabIndex = 6
        '
        'SMTPOk
        '
        Me.SMTPOk.Location = New System.Drawing.Point(24, 191)
        Me.SMTPOk.Name = "SMTPOk"
        Me.SMTPOk.Size = New System.Drawing.Size(71, 24)
        Me.SMTPOk.TabIndex = 8
        Me.SMTPOk.Text = "Ok"
        Me.SMTPOk.UseVisualStyleBackColor = True
        '
        'SMTPCancel
        '
        Me.SMTPCancel.Location = New System.Drawing.Point(103, 191)
        Me.SMTPCancel.Name = "SMTPCancel"
        Me.SMTPCancel.Size = New System.Drawing.Size(71, 24)
        Me.SMTPCancel.TabIndex = 9
        Me.SMTPCancel.Text = "Cancel"
        Me.SMTPCancel.UseVisualStyleBackColor = True
        '
        'SMTPApply
        '
        Me.SMTPApply.Location = New System.Drawing.Point(183, 191)
        Me.SMTPApply.Name = "SMTPApply"
        Me.SMTPApply.Size = New System.Drawing.Size(71, 24)
        Me.SMTPApply.TabIndex = 10
        Me.SMTPApply.Text = "Apply"
        Me.SMTPApply.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 227)
        Me.Controls.Add(Me.SMTPApply)
        Me.Controls.Add(Me.SMTPCancel)
        Me.Controls.Add(Me.SMTPOk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SMTPPortBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SMTPPasswordBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SMTPUsernameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SMTPAddressBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SMTPAddressBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SMTPUsernameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SMTPPasswordBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SMTPPortBox As TextBox
    Friend WithEvents SMTPOk As Button
    Friend WithEvents SMTPCancel As Button
    Friend WithEvents SMTPApply As Button
End Class
