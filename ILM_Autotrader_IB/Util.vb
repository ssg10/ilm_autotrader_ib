Module Util

    Public HISTORICAL_DATA_CLIENT_ID_START As Integer = 10
    Public HISTORICAL_DATA_CLIENT_ID_END As Integer = 30

    Function GetHistoricalDataClientID(ByVal Ticker As String) As Integer
        Dim client_id As Integer
        Dim i As Integer

        'Historical Data client ID starts at 10
        'Table (for example:)
        'ClientID   Ticker
        '10         ES
        '11         CL
        '12         GC

        For i = HISTORICAL_DATA_CLIENT_ID_START To HISTORICAL_DATA_CLIENT_ID_END

        Next


        Return client_id
    End Function



End Module
