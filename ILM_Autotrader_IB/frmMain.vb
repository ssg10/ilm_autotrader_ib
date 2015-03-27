Imports System.IO

Public Class frmMain
    Dim IBCONNECTION_NUMBER As Integer = 99 ' Must be unique number or IB will not connect us
    Dim g_connecting_inprogress As Boolean = False

    Private Sub AxTws1_errMsg(sender As Object, e As AxTWSLib._DTwsEvents_errMsgEvent) Handles AxTws1.errMsg

        lbErrorAndLog.Items.Add(Now.ToString & ":  " & e.errorMsg)
        lbErrorAndLog.TopIndex = lbErrorAndLog.Items.Count - 1

        ' Save it to a file
        Using logfile As StreamWriter = New StreamWriter("c:\awslog.txt", True)
            logfile.WriteLine(Now.ToString & " " & e.errorMsg.ToString)
        End Using

        'Check if marketdata farm is recoqnized, then connection is good
        Dim connection_msg As String

        connection_msg = "Market data farm"

        If g_connecting_inprogress Then

            If e.errorMsg.Contains(connection_msg) Then
                lblConnected.Text = "CONNECTED"
                lblConnected.BackColor = Color.Green
            End If

            ' Just a flag to let this if then executed once
            g_connecting_inprogress = False
        End If



    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        g_connecting_inprogress = True
        Call AxTws1.connect("", "7496", IBCONNECTION_NUMBER)
        'Wait for errMsg event with "Market data farm ", if string contains that, connection is good


    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click

        Call AxTws1.disconnect()
        lblConnected.Text = "DISCONNECTED"
        lblConnected.BackColor = Color.Red

    End Sub

  
End Class
