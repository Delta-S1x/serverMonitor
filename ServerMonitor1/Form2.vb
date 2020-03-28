Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SMTPAddressBox.Text = My.Settings.SMTPServer
        SMTPPortBox.Text = My.Settings.SMTPPort
        SMTPUsernameBox.Text = My.Settings.SMTPUSername
        SMTPPasswordBox.Text = My.Settings.SMPTPassword
    End Sub

    Private Sub SMTPApply_Click(sender As Object, e As EventArgs) Handles SMTPApply.Click
        My.Settings.SMTPUSername = SMTPUsernameBox.Text
        If SMTPPasswordBox.Text.Count > 0 Then
            My.Settings.SMPTPassword = AES_Encrypt(SMTPPasswordBox.Text, "SZ%58rTb123")

        Else
            My.Settings.SMPTPassword = ""
        End If

        My.Settings.SMTPServer = SMTPAddressBox.Text
        My.Settings.SMTPPort = SMTPPortBox.Text
    End Sub

    Private Sub SMTPOk_Click(sender As Object, e As EventArgs) Handles SMTPOk.Click
        My.Settings.SMTPUSername = SMTPUsernameBox.Text
        If SMTPPasswordBox.Text.Count > 0 Then
            My.Settings.SMPTPassword = AES_Encrypt(SMTPPasswordBox.Text, "SZ%58rTb123")

        Else
            My.Settings.SMPTPassword = ""
        End If

        My.Settings.SMTPServer = SMTPAddressBox.Text
        My.Settings.SMTPPort = SMTPPortBox.Text
        Me.Close()
    End Sub

    Private Sub SMTPCancel_Click(sender As Object, e As EventArgs) Handles SMTPCancel.Click
        Me.Hide()

    End Sub

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function



End Class