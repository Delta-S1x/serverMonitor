Imports System.Threading
Public Class Form1
    Dim runtime = True
    Dim running = False
    Dim serveradd = 1
    Dim ServernameHeight = 0




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        If running = True Then
            running = False
        Else
            running = True
        End If
        ServerName.Text = running

    End Sub

    Private mythread As Thread



    Sub Pinger()
        Control.CheckForIllegalCrossThreadCalls = False
        MsgBox("at Pinger")
        Do While runtime = True
            If running = False Then
                BackColor = Control.DefaultBackColor
            End If
            If running = True Then

                Try
                    My.Computer.Network.Ping(ServerAddress.Text)
                    BackColor = Color.FromArgb(25, 207, 52)
                    Threading.Thread.Sleep(3000)
                Catch
                    BackColor = Color.FromArgb(255, 0, 0)
                    Threading.Thread.Sleep(3000)
                End Try

            End If

        Loop

    End Sub
    Sub ThreadKiller(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub
    Sub Threader(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        mythread = New Thread(AddressOf Pinger)
        mythread.IsBackground = True
        mythread.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles minus.Click
        ' lastServerName = ("servername" & Str(serveradd)).Name
        ServerName.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add.Click
        serveradd = serveradd + 1
        ServernameHeight = ServernameHeight + 30
        Dim NewTB As New TextBox
        NewTB = New TextBox
        NewTB.Name = "servername" & Str(serveradd)
        NewTB.Left = (ServerName.Location.X)
        NewTB.Top = ServerName.Location.Y + ServernameHeight
        add.Top += 30
        minus.Top += 30
        startbtn.Top += 30
        Me.Height += 30



        Me.Controls.Add(NewTB)
        ' AddHandler NewTB.TextChanged, AddressOf HandleTextChanged
    End Sub
End Class
