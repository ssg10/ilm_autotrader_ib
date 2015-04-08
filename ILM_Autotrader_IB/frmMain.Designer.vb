<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.AxTws1 = New AxTWSLib.AxTws()
        Me.lbErrorAndLog = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lbRealTimeData = New System.Windows.Forms.ListBox()
        Me.btnRunAlgo = New System.Windows.Forms.Button()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblServerTime = New System.Windows.Forms.Label()
        Me.btnHistoricalData = New System.Windows.Forms.Button()
        Me.tbSymbol = New System.Windows.Forms.TextBox()
        Me.tbExchange = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.tbDuration = New System.Windows.Forms.TextBox()
        Me.tbBars = New System.Windows.Forms.TextBox()
        Me.tbUseRTH = New System.Windows.Forms.TextBox()
        Me.tbSecType = New System.Windows.Forms.TextBox()
        Me.tbExpiry = New System.Windows.Forms.TextBox()
        Me.tbPrimaryExchange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbRealTimeHeartBeat = New System.Windows.Forms.ListBox()
        Me.lbAccountInfo = New System.Windows.Forms.ListBox()
        Me.btnAccountInfo = New System.Windows.Forms.Button()
        Me.btnAccSummary = New System.Windows.Forms.Button()
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxTws1
        '
        Me.AxTws1.Enabled = True
        Me.AxTws1.Location = New System.Drawing.Point(883, 505)
        Me.AxTws1.Name = "AxTws1"
        Me.AxTws1.OcxState = CType(resources.GetObject("AxTws1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTws1.Size = New System.Drawing.Size(100, 50)
        Me.AxTws1.TabIndex = 0
        '
        'lbErrorAndLog
        '
        Me.lbErrorAndLog.FormattingEnabled = True
        Me.lbErrorAndLog.HorizontalScrollbar = True
        Me.lbErrorAndLog.Location = New System.Drawing.Point(31, 473)
        Me.lbErrorAndLog.Name = "lbErrorAndLog"
        Me.lbErrorAndLog.Size = New System.Drawing.Size(601, 121)
        Me.lbErrorAndLog.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Errors and Logs"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(31, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(125, 34)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect IB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(207, 24)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(119, 34)
        Me.btnDisconnect.TabIndex = 4
        Me.btnDisconnect.Text = "Disconnect IB"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'lbRealTimeData
        '
        Me.lbRealTimeData.FormattingEnabled = True
        Me.lbRealTimeData.Location = New System.Drawing.Point(644, 251)
        Me.lbRealTimeData.Name = "lbRealTimeData"
        Me.lbRealTimeData.Size = New System.Drawing.Size(339, 212)
        Me.lbRealTimeData.TabIndex = 5
        '
        'btnRunAlgo
        '
        Me.btnRunAlgo.Location = New System.Drawing.Point(31, 113)
        Me.btnRunAlgo.Name = "btnRunAlgo"
        Me.btnRunAlgo.Size = New System.Drawing.Size(122, 36)
        Me.btnRunAlgo.TabIndex = 6
        Me.btnRunAlgo.Text = "Run Algo"
        Me.btnRunAlgo.UseVisualStyleBackColor = True
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.BackColor = System.Drawing.Color.Red
        Me.lblConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.Location = New System.Drawing.Point(390, 30)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(157, 20)
        Me.lblConnected.TabIndex = 7
        Me.lblConnected.Text = "NOT CONNECTED"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1071, 632)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(645, 6)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(409, 36)
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 605
        Me.LineShape2.Y1 = 11
        Me.LineShape2.Y2 = 12
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 600
        Me.LineShape1.Y1 = 76
        Me.LineShape1.Y2 = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Server Time: "
        '
        'lblServerTime
        '
        Me.lblServerTime.AutoSize = True
        Me.lblServerTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerTime.Location = New System.Drawing.Point(788, 13)
        Me.lblServerTime.Name = "lblServerTime"
        Me.lblServerTime.Padding = New System.Windows.Forms.Padding(1)
        Me.lblServerTime.Size = New System.Drawing.Size(2, 22)
        Me.lblServerTime.TabIndex = 10
        '
        'btnHistoricalData
        '
        Me.btnHistoricalData.Location = New System.Drawing.Point(642, 76)
        Me.btnHistoricalData.Name = "btnHistoricalData"
        Me.btnHistoricalData.Size = New System.Drawing.Size(119, 35)
        Me.btnHistoricalData.TabIndex = 11
        Me.btnHistoricalData.Text = "Get Historical Data"
        Me.btnHistoricalData.UseVisualStyleBackColor = True
        '
        'tbSymbol
        '
        Me.tbSymbol.Location = New System.Drawing.Point(644, 122)
        Me.tbSymbol.Name = "tbSymbol"
        Me.tbSymbol.Size = New System.Drawing.Size(82, 20)
        Me.tbSymbol.TabIndex = 12
        Me.tbSymbol.Text = "ES"
        '
        'tbExchange
        '
        Me.tbExchange.Location = New System.Drawing.Point(642, 148)
        Me.tbExchange.Name = "tbExchange"
        Me.tbExchange.Size = New System.Drawing.Size(82, 20)
        Me.tbExchange.TabIndex = 13
        Me.tbExchange.Text = "GLOBEX"
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(828, 147)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(131, 20)
        Me.tbDate.TabIndex = 14
        Me.tbDate.Text = "20150329 16:15:00 est"
        '
        'tbDuration
        '
        Me.tbDuration.Location = New System.Drawing.Point(828, 199)
        Me.tbDuration.Name = "tbDuration"
        Me.tbDuration.Size = New System.Drawing.Size(73, 20)
        Me.tbDuration.TabIndex = 15
        Me.tbDuration.Text = "1 M"
        '
        'tbBars
        '
        Me.tbBars.Location = New System.Drawing.Point(828, 173)
        Me.tbBars.Name = "tbBars"
        Me.tbBars.Size = New System.Drawing.Size(73, 20)
        Me.tbBars.TabIndex = 16
        Me.tbBars.Text = "1 day"
        '
        'tbUseRTH
        '
        Me.tbUseRTH.Location = New System.Drawing.Point(833, 225)
        Me.tbUseRTH.Name = "tbUseRTH"
        Me.tbUseRTH.Size = New System.Drawing.Size(68, 20)
        Me.tbUseRTH.TabIndex = 18
        Me.tbUseRTH.Text = "1"
        '
        'tbSecType
        '
        Me.tbSecType.Location = New System.Drawing.Point(642, 200)
        Me.tbSecType.Name = "tbSecType"
        Me.tbSecType.Size = New System.Drawing.Size(84, 20)
        Me.tbSecType.TabIndex = 19
        Me.tbSecType.Text = "FUT"
        '
        'tbExpiry
        '
        Me.tbExpiry.Location = New System.Drawing.Point(828, 122)
        Me.tbExpiry.Name = "tbExpiry"
        Me.tbExpiry.Size = New System.Drawing.Size(131, 20)
        Me.tbExpiry.TabIndex = 20
        Me.tbExpiry.Text = "201506"
        '
        'tbPrimaryExchange
        '
        Me.tbPrimaryExchange.Location = New System.Drawing.Point(644, 174)
        Me.tbPrimaryExchange.Name = "tbPrimaryExchange"
        Me.tbPrimaryExchange.Size = New System.Drawing.Size(82, 20)
        Me.tbPrimaryExchange.TabIndex = 21
        Me.tbPrimaryExchange.Text = "GLOBEX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Exchange"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(547, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Primary Exchange"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(760, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Expiry"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(763, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "End Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(763, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Bar Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(763, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Duration"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(763, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "UseRTH"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(907, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "S, D, W, M, Y"
        '
        'lbRealTimeHeartBeat
        '
        Me.lbRealTimeHeartBeat.FormattingEnabled = True
        Me.lbRealTimeHeartBeat.Location = New System.Drawing.Point(31, 180)
        Me.lbRealTimeHeartBeat.Name = "lbRealTimeHeartBeat"
        Me.lbRealTimeHeartBeat.Size = New System.Drawing.Size(243, 134)
        Me.lbRealTimeHeartBeat.TabIndex = 30
        '
        'lbAccountInfo
        '
        Me.lbAccountInfo.FormattingEnabled = True
        Me.lbAccountInfo.Location = New System.Drawing.Point(309, 180)
        Me.lbAccountInfo.Name = "lbAccountInfo"
        Me.lbAccountInfo.Size = New System.Drawing.Size(232, 264)
        Me.lbAccountInfo.TabIndex = 31
        '
        'btnAccountInfo
        '
        Me.btnAccountInfo.Location = New System.Drawing.Point(309, 113)
        Me.btnAccountInfo.Name = "btnAccountInfo"
        Me.btnAccountInfo.Size = New System.Drawing.Size(106, 33)
        Me.btnAccountInfo.TabIndex = 32
        Me.btnAccountInfo.Text = "Get Acc Info"
        Me.btnAccountInfo.UseVisualStyleBackColor = True
        '
        'btnAccSummary
        '
        Me.btnAccSummary.Location = New System.Drawing.Point(444, 113)
        Me.btnAccSummary.Name = "btnAccSummary"
        Me.btnAccSummary.Size = New System.Drawing.Size(97, 36)
        Me.btnAccSummary.TabIndex = 33
        Me.btnAccSummary.Text = "Get Acc Summary"
        Me.btnAccSummary.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 632)
        Me.Controls.Add(Me.btnAccSummary)
        Me.Controls.Add(Me.btnAccountInfo)
        Me.Controls.Add(Me.lbAccountInfo)
        Me.Controls.Add(Me.lbRealTimeHeartBeat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPrimaryExchange)
        Me.Controls.Add(Me.tbExpiry)
        Me.Controls.Add(Me.tbSecType)
        Me.Controls.Add(Me.tbUseRTH)
        Me.Controls.Add(Me.tbBars)
        Me.Controls.Add(Me.tbDuration)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbExchange)
        Me.Controls.Add(Me.tbSymbol)
        Me.Controls.Add(Me.btnHistoricalData)
        Me.Controls.Add(Me.lblServerTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblConnected)
        Me.Controls.Add(Me.btnRunAlgo)
        Me.Controls.Add(Me.lbRealTimeData)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbErrorAndLog)
        Me.Controls.Add(Me.AxTws1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ILM AutoTrader on IB"
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxTws1 As AxTWSLib.AxTws
    Friend WithEvents lbErrorAndLog As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents lbRealTimeData As System.Windows.Forms.ListBox
    Friend WithEvents btnRunAlgo As System.Windows.Forms.Button
    Friend WithEvents lblConnected As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblServerTime As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnHistoricalData As System.Windows.Forms.Button
    Friend WithEvents tbSymbol As System.Windows.Forms.TextBox
    Friend WithEvents tbExchange As System.Windows.Forms.TextBox
    Friend WithEvents tbDate As System.Windows.Forms.TextBox
    Friend WithEvents tbDuration As System.Windows.Forms.TextBox
    Friend WithEvents tbBars As System.Windows.Forms.TextBox
    Friend WithEvents tbUseRTH As System.Windows.Forms.TextBox
    Friend WithEvents tbSecType As System.Windows.Forms.TextBox
    Friend WithEvents tbExpiry As System.Windows.Forms.TextBox
    Friend WithEvents tbPrimaryExchange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbRealTimeHeartBeat As System.Windows.Forms.ListBox
    Friend WithEvents lbAccountInfo As System.Windows.Forms.ListBox
    Friend WithEvents btnAccountInfo As System.Windows.Forms.Button
    Friend WithEvents btnAccSummary As System.Windows.Forms.Button

End Class
