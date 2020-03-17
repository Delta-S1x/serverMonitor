﻿Imports System.Threading
Public Class Form1
    Dim runtime = True
    Dim running = False
    Dim serveradd = 1
    Dim ServernameHeight = 0
    Dim MyServerNameList As List(Of Control)
    Dim MyServerAddressList As List(Of Control)
    Dim MyPanelList As List(Of Control)
    Dim MyCheckBoxList As List(Of Control)
    Dim last
    Private WithEvents NotifyIcon1 As NotifyIcon
    Private mypopupthread As Thread
    Dim dead As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        If startbtn.Text = "Start" Then
            startbtn.Text = "Stop"

        ElseIf startbtn.Text = "Stop" Then
            startbtn.Text = "Start"

        End If
        If running = True Then
            running = False
        Else
            running = True
        End If


    End Sub

    Private mythread As Thread



    Sub Pinger()
        Control.CheckForIllegalCrossThreadCalls = False

        Do While runtime = True
            If running = False Then
                Panel1.BackColor = Control.DefaultBackColor
            End If
            If running = True Then
                If ServerAddress.Text.Count > 1 Then

                    Try
                        My.Computer.Network.Ping(ServerAddress.Text)
                        Panel1.BackColor = Color.FromArgb(25, 207, 52)
                        Threading.Thread.Sleep(500)
                        dead = 1
                    Catch
                        Panel1.BackColor = Color.FromArgb(255, 0, 0)
                        Threading.Thread.Sleep(3000)
                        If popupbox.Checked = True Then
                            If dead = 1 Then
                                mypopupthread = New Thread(AddressOf Popupboxsubmain)
                                mypopupthread.IsBackground = True
                                mypopupthread.Start()

                            End If
                        End If
                    End Try
                End If

            End If
            Dim refrence = 0
            For Each tb As Control In MyServerAddressList.ToList

                If running = True Then
                    If tb.Text.Count > 1 Then
                        Dim thispanel = MyPanelList(refrence)
                        Try
                            My.Computer.Network.Ping(tb.Text)

                            thispanel.BackColor = Color.FromArgb(25, 207, 52)
                            Threading.Thread.Sleep(500)
                        Catch
                            thispanel.BackColor = Color.FromArgb(255, 0, 0)
                            Threading.Thread.Sleep(3000)
                        End Try
                    Else
                        Dim thispanel = MyPanelList(refrence)
                        thispanel.BackColor = Control.DefaultBackColor
                    End If

                End If
                refrence += 1
            Next






        Loop

    End Sub
    Private Sub Popupboxsubmain()
        dead = 0
        MsgBox(ServerName.Text & " " & vbNewLine & ServerAddress.Text & vbNewLine & " Has been disconnected at " & System.DateTime.Now, MsgBoxStyle.ApplicationModal, "Server Monitor")

        mypopupthread.Abort()

    End Sub


    Sub Threader(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyServerAddressList = New List(Of Control)
        MyServerNameList = New List(Of Control)
        MyPanelList = New List(Of Control)
        MyCheckBoxList = New List(Of Control)
        NotifyIcon1 = New NotifyIcon

        mythread = New Thread(AddressOf Pinger)
        mythread.IsBackground = True
        mythread.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles minus.Click

        If MyServerNameList.Count > 0 Then
            last = MyServerNameList.Last()
            MyServerNameList.RemoveAt(MyServerNameList.Count - 1)
            last.Dispose()

            last = MyServerAddressList.Last()
            MyServerAddressList.RemoveAt(MyServerAddressList.Count - 1)
            last.Dispose()

            last = MyPanelList.Last()
            MyPanelList.RemoveAt(MyPanelList.Count - 1)
            last.Dispose()

            last = MyCheckBoxList.Last()
            MyCheckBoxList.RemoveAt(MyCheckBoxList.Count - 1)
            last.Dispose()

            ServernameHeight -= 30
            add.Top -= 30
            minus.Top -= 30
            startbtn.Top -= 30
            Me.Height -= 30
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add.Click

        serveradd = serveradd + 1
        ServernameHeight += 30
        Dim NewTB As New TextBox
        Dim NewTB2 As New TextBox
        Dim NewPanel As New Panel
        Dim NewCheckBox As New CheckBox
        NewTB = New TextBox
        NewTB2 = New TextBox
        NewPanel = New Panel
        NewCheckBox = New CheckBox

        MyServerAddressList.Add(NewTB2)
        NewTB2.Left = (ServerAddress.Location.X)
        NewTB2.Top = ServerAddress.Location.Y + ServernameHeight
        NewTB2.Width = 191

        MyServerNameList.Add(NewTB)
        NewTB.Left = (ServerName.Location.X)
        NewTB.Top = ServerName.Location.Y + ServernameHeight
        NewTB.Width = 191

        MyPanelList.Add(NewPanel)
        NewPanel.Left = (Panel1.Location.X)
        NewPanel.Top = Panel1.Location.Y + ServernameHeight
        NewPanel.Size = Panel1.Size

        MyCheckBoxList.Add(NewCheckBox)
        NewCheckBox.Left = (CheckBox1.Location.X)
        NewCheckBox.Top = CheckBox1.Location.Y + ServernameHeight
        NewCheckBox.Text = "Email Alerts"

        add.Top += 30
        minus.Top += 30
        startbtn.Top += 30
        Me.Height += 30

        Me.Controls.Add(NewTB)
        Me.Controls.Add(NewTB2)
        Me.Controls.Add(NewPanel)
        Me.Controls.Add(NewCheckBox)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Server Monitor"
            NotifyIcon1.BalloonTipText = "Running In Background"
            NotifyIcon1.ShowBalloonTip(50000)
            Dim icon = Me.Icon
            NotifyIcon1.Icon = icon
            Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotityIcon1_RightClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then

            trayForm.Show() 'Shows the Form that is the parent of "traymenu"
            trayForm.Activate() 'Set the Form to "Active", that means that that will be the "selected" window
            trayForm.Width = 1 'Set the Form width to 1 pixel, that is needed because later we will set it behind the "traymenu"
            trayForm.Height = 1
        End If

    End Sub

End Class
