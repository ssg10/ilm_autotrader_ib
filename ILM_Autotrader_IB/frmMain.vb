Imports System.IO

Public Class frmMain
    Dim IBCONNECTION_NUMBER As Integer = 99 ' Must be unique number or IB will not connect us
    Dim g_connecting_inprogress As Boolean = False
    Public HISTORICAL_TICKER_ID1 As Integer = 10

    Private m_options As List(Of TWSLib.ITagValue)

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
                Call AxTws1.reqCurrentTime()
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

  
    Private Sub AxTws1_connectionClosed(sender As Object, e As EventArgs) Handles AxTws1.connectionClosed
        lbErrorAndLog.Items.Add(Now.ToString & " " & "TWS closed connection!")
        lbErrorAndLog.TopIndex = lbErrorAndLog.Items.Count - 1
    End Sub

    Private Sub AxTws1_currentTime(sender As Object, e As AxTWSLib._DTwsEvents_currentTimeEvent) Handles AxTws1.currentTime
        'Dim displayString As DateTime
        'displayString = Convert.ToDateTime(e.time)
        'lbErrorAndLog.Items.Add(displayString.ToString("g")
        'lblServerTime.Text = displayString
    End Sub


    Private Sub btnRunAlgo_Click(sender As Object, e As EventArgs) Handles btnRunAlgo.Click

    End Sub

    Private Sub btnHistoricalData_Click(sender As Object, e As EventArgs) Handles btnHistoricalData.Click

        ' Create a new contract object
        Dim ContractInfo As TWSLib.IContract
        ' Create a new TagValueList object (For API version 9.71)
        Dim ChartOptions As TWSLib.ITagValueList
        ' Initialize ContractInfo object
        ContractInfo = AxTws1.createContract()
        ' Initialize ChartOptions object (For API version 9.71)
        ChartOptions = AxTws1.createTagValueList()
        ' Clear out the list box
        lbRealTimeData.Items.Clear()
        ' Now fill the ContractInfo object with the necessary information 
        ' Connection identifier
        'ContractInfo.conId = 0
        ' Stock symbol
        ContractInfo.symbol = tbSymbol.Text
        ' Type of instrument: Stock=STK,Option=OPT,Future=FUT, etc.
        ContractInfo.secType = tbSecType.Text
        ' The destination of order or request. "SMART" =IB order router
        ContractInfo.exchange = tbExchange.Text
        'primary exchange should NOT be smart! it is the primary like nasdaq for INTC
        ContractInfo.primaryExchange = tbPrimaryExchange.Text
        ContractInfo.expiry = tbExpiry.Text

        ' The primary exchange where the instrument trades. 
        ' NYSE, NASDAQ, AMEX, BATS, ARCA, PHLX etc.
        ' The currency of the exchange USD or GBP or CAD or EUR, etc.
        ContractInfo.currency = "USD"
        ' Now call reqHistoricalDataEx with parameters:
        ' tickerId, Contract, endDateTime, durationStr, barSize,  
        ' WhatToShow, useRTH, formatDate

        'formatDate param 1 is yyyymmdd hh:mm:dd.  0 is # secs since 1970
        Dim formatDate As Integer = 1

        Call AxTws1.reqHistoricalDataEx(HISTORICAL_TICKER_ID1, ContractInfo, _
                                        tbDate.Text, _
                                        tbDuration.Text, _
                                        tbBars.Text, _
                                        "TRADES", _
                                        CInt(tbUseRTH.Text), _
                                        formatDate, _
                                        ChartOptions)

        'Bar size: 1 sec, 5, 15, 30 secs, 1 min, 2, 3, 5, 15 30 mins, 1 hour, 1 day
    End Sub

    Private Sub AxTws1_historicalData(sender As Object, e As AxTWSLib._DTwsEvents_historicalDataEvent) Handles AxTws1.historicalData
        ' Handle the incoming historical data records. 
        ' Object e contains:
        ' e.date      Date (and time) of the historical data bar
        ' e.open      The opening price of the bar/interval
        ' e.high      The high price for the bar/interval
        ' e.low       The low price for the bar/interval 
        ' e.close     The closing price of the bar/interval
        ' e.volume    The volume (number of shares/contract) for the bar/interval
        ' e.wAP       The average price during the bar/interval 
        Dim OutputString As String
        ' Concatenate all of the required fields into the OutputString
        OutputString = e.date & " " & e.open & " " & e.high & " " & e.low & " " & e.close
        ' Add the output string to the ListBox
        lbRealTimeData.Items.Add(OutputString)
        lbRealTimeData.TopIndex = lbRealTimeData.Items.Count - 1

        ' Below is to check if finished-yyymmdd keyword is found in e.date, which means historical data req done
        ' Also, cancelHistoricalData does not seem to be needed, as it is used only to cancel when server still fetching data!

        'If e.date.Contains("finish") Then
        '   AxTws1.cancelHistoricalData(HISTORICAL_TICKER_ID1)
        '   MsgBox("FINISHED")
        'End If
    End Sub
End Class
