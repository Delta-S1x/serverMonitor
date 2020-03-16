Public Class Form2
    Public Property SMTPAddress As String
    Public Property SMTPPort As String
    Public Property SMTPUsername As String
    Public Property SMTPPassword As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SMTPApply_Click(sender As Object, e As EventArgs) Handles SMTPApply.Click
        Me.SMTPAddress = SMTPAddressBox.Text
        Me.SMTPPort = SMTPPortBox.Text
        Me.SMTPUsername = SMTPUsernameBox.Text
        Me.SMTPPassword = SMTPPasswordBox.Text

    End Sub

    Private Sub SMTPOk_Click(sender As Object, e As EventArgs) Handles SMTPOk.Click
        Me.SMTPAddress = SMTPAddressBox.Text
        Me.SMTPPort = SMTPPortBox.Text
        Me.SMTPUsername = SMTPUsernameBox.Text
        Me.SMTPPassword = SMTPPasswordBox.Text
        Me.Hide()
    End Sub

    Private Sub SMTPCancel_Click(sender As Object, e As EventArgs) Handles SMTPCancel.Click
        Me.Hide()

    End Sub
End Class