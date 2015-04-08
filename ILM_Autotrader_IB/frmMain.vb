Imports System.IO

Public Class frmMain
    Dim IBCONNECTION_NUMBER As Integer = 99 ' Must be unique number or IB will not connect us
    Dim g_connecting_inprogress As Boolean = False
    Public HISTORICAL_TICKER_ID1 As Integer = 10
    Public RT_TICKER_ID_START As Integer = 20
    Public RT_TICKER_ID_END As Integer = 40

    Public g_accounts As String() = {"U129661", "U1465027"}
    Public g_accounts_requpdate_flag As Integer = 0

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
        lbErrorAndLog.Items.Add(ConvertTimestamp(e.time))
        lblServerTime.Text = ConvertTimestamp(e.time)
    End Sub
    Function ConvertTimestamp(ByVal timestamp as Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp).ToLocalTime
    End Function


    Private Sub btnRunAlgo_Click(sender As Object, e As EventArgs) Handles btnRunAlgo.Click
        Call subscribeRTData()
    End Sub

    Private Sub subscribeRTData()
        ' Sub to get real-time data

        ' Create a Contract object to hold contract details
        Dim ContractInfo As TWSLib.IContract
        Dim ChartOptions As TWSLib.ITagValueList

        ChartOptions = AxTws1.createTagValueList()
        ContractInfo = AxTws1.createContract()

        ' Now fill the ContractInfo object with the necessary information 
        ContractInfo.conId = 0              ' identifier
        ' Stock symbol
        ContractInfo.symbol = tbSymbol.Text
        ' Security Type: Stock=STK, Option=OPT, Future=FUT, etc.
        ContractInfo.secType = tbSecType.Text
        ContractInfo.expiry = tbExpiry.Text
        ' The destination of order or request. "SMART" =IB order router
        ContractInfo.exchange = tbExchange.Text
        ' The primary exchange where the instrument trades. 
        ContractInfo.primaryExchange = tbPrimaryExchange.Text
        ' The currency USD or GBP or CAD or EUR, etc.
        ContractInfo.currency = "USD"

        AxTws1.reqMktDataEx(RT_TICKER_ID_START, ContractInfo, "", 0, ChartOptions)
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

    Private Sub AxTws1_tickPrice(sender As Object, e As AxTWSLib._DTwsEvents_tickPriceEvent) Handles AxTws1.tickPrice
        ' Callback method to handle new market data Price change events
        ' When this callback method/routine is activated, price changes will 
        ' appear in the Events objects named "e" 
        ' Properties of "e" include:
        ' e.id              The identifier that was set in the call to reqMktData
        ' e.price           The latest Price
        ' e.tickType        The tick type 1=bid,2=ask, 4=last, 6=high, 7=low, 9=close 
        ' e.canAutoExecute  A flag 1= the order can be automatically executed
        ' If this is a last price change, then display it
        If (e.tickType = 4) Then
            ' Add the latest price to the list box
            lbRealTimeHeartBeat.Items.Add("price=" & e.price)
            lbRealTimeHeartBeat.TopIndex = lbRealTimeHeartBeat.Items.Count - 1
        End If
    End Sub

    Private Sub btnAccountInfo_Click(sender As Object, e As EventArgs) Handles btnAccountInfo.Click
        ' NOTE: reqAccountUpdate is a subscription base and TWS will send updates. Not sure how often.
        ' If account is connected to another program (such as ninja) then TWS won't take your subscription

        If g_accounts_requpdate_flag < 1 Then

            Call AxTws1.reqAccountUpdates(1, g_accounts(0))
            g_accounts_requpdate_flag = 1
            btnAccountInfo.Text = "Stop Acc Info"
        Else
            Call AxTws1.reqAccountUpdates(0, g_accounts(0))
            g_accounts_requpdate_flag = 0
            btnAccountInfo.Text = "Get Acc Info"
        End If

    End Sub

    Private Sub AxTws1_updateAccountTime(sender As Object, e As AxTWSLib._DTwsEvents_updateAccountTimeEvent) Handles AxTws1.updateAccountTime

        lbAccountInfo.Items.Add("UpdateAccountTime: " & e.timeStamp.ToString)
        lbAccountInfo.TopIndex = lbAccountInfo.Items.Count - 1

    End Sub

    Private Sub AxTws1_updateAccountValue(sender As Object, e As AxTWSLib._DTwsEvents_updateAccountValueEvent) Handles AxTws1.updateAccountValue
        lbAccountInfo.Items.Add(e.accountName & " " & e.key & " " & e.value)
        lbAccountInfo.TopIndex = lbAccountInfo.Items.Count - 1
    End Sub

    Private Sub btnAccSummary_Click(sender As Object, e As EventArgs) Handles btnAccSummary.Click
        'reqAccountSummary is a one shot request vs. reqAccountUpdates

        Call AxTws1.reqAccountSummary(1, "All", "AccruedCash,BuyingPower,NetLiquidation")
    End Sub

    Private Sub AxTws1_accountSummary(sender As Object, e As AxTWSLib._DTwsEvents_accountSummaryEvent) Handles AxTws1.accountSummary

        Select Case e.tag
            Case "AccruedCash"
                lbAccountInfo.Items.Add(e.account & "   AccruedCash = " & e.value.ToString)
            Case "BuyingPower"
                lbAccountInfo.Items.Add(e.account & "   BuyingPower = " & e.value.ToString)
            Case "NetLiquidation"
                lbAccountInfo.Items.Add(e.account & "   NetLiquidation = " & e.value.ToString)
            Case Else
                lbAccountInfo.Items.Add("Case Else caught")

        End Select
        lbAccountInfo.TopIndex = lbAccountInfo.Items.Count - 1


    End Sub

    Private Sub AxTws1_accountSummaryEnd(sender As Object, e As AxTWSLib._DTwsEvents_accountSummaryEndEvent) Handles AxTws1.accountSummaryEnd
        lbAccountInfo.Items.Add("AccountSummary request end")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
