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
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
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
        Me.lbErrorAndLog.Location = New System.Drawing.Point(31, 415)
        Me.lbErrorAndLog.Name = "lbErrorAndLog"
        Me.lbErrorAndLog.Size = New System.Drawing.Size(601, 121)
        Me.lbErrorAndLog.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 396)
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
        Me.lbRealTimeData.Location = New System.Drawing.Point(634, 170)
        Me.lbRealTimeData.Name = "lbRealTimeData"
        Me.lbRealTimeData.Size = New System.Drawing.Size(262, 134)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1010, 567)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 600
        Me.LineShape1.Y1 = 76
        Me.LineShape1.Y2 = 77
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 599
        Me.LineShape2.Y1 = 11
        Me.LineShape2.Y2 = 12
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 567)
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

End Class
