<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FloorRunTimerForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.SecCount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLogDataGrid = New System.Windows.Forms.DataGridView()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LapButton = New System.Windows.Forms.Button()
        Me.OpenAnalysisChart = New System.Windows.Forms.Button()
        CType(Me.TimeLogDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartStopButton
        '
        Me.StartStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StartStopButton.Location = New System.Drawing.Point(260, 121)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(60, 20)
        Me.StartStopButton.TabIndex = 0
        Me.StartStopButton.Text = "START"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'SecCount
        '
        Me.SecCount.Font = New System.Drawing.Font("ＭＳ ゴシック", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SecCount.Location = New System.Drawing.Point(200, 50)
        Me.SecCount.Name = "SecCount"
        Me.SecCount.Size = New System.Drawing.Size(400, 50)
        Me.SecCount.TabIndex = 1
        Me.SecCount.Text = "0.00"
        Me.SecCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'TimeLogDataGrid
        '
        Me.TimeLogDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TimeLogDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TimeLogDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeLogDataGrid.ColumnHeadersVisible = False
        Me.TimeLogDataGrid.Location = New System.Drawing.Point(150, 160)
        Me.TimeLogDataGrid.Name = "TimeLogDataGrid"
        Me.TimeLogDataGrid.RowHeadersVisible = False
        Me.TimeLogDataGrid.RowTemplate.Height = 21
        Me.TimeLogDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TimeLogDataGrid.Size = New System.Drawing.Size(500, 204)
        Me.TimeLogDataGrid.TabIndex = 3
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ResetButton.Location = New System.Drawing.Point(479, 121)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(60, 20)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'LapButton
        '
        Me.LapButton.Enabled = False
        Me.LapButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LapButton.Location = New System.Drawing.Point(368, 121)
        Me.LapButton.Name = "LapButton"
        Me.LapButton.Size = New System.Drawing.Size(60, 20)
        Me.LapButton.TabIndex = 5
        Me.LapButton.Text = "LAP"
        Me.LapButton.UseVisualStyleBackColor = True
        '
        'OpenAnalysisChart
        '
        Me.OpenAnalysisChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OpenAnalysisChart.Location = New System.Drawing.Point(574, 121)
        Me.OpenAnalysisChart.Name = "OpenAnalysisChart"
        Me.OpenAnalysisChart.Size = New System.Drawing.Size(76, 20)
        Me.OpenAnalysisChart.TabIndex = 6
        Me.OpenAnalysisChart.Text = "結果表示"
        Me.OpenAnalysisChart.UseVisualStyleBackColor = True
        '
        'FloorRunTimerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.OpenAnalysisChart)
        Me.Controls.Add(Me.LapButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TimeLogDataGrid)
        Me.Controls.Add(Me.SecCount)
        Me.Controls.Add(Me.StartStopButton)
        Me.Name = "FloorRunTimerForm"
        Me.Text = "幻クリ時給計算機"
        CType(Me.TimeLogDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartStopButton As Button
    Friend WithEvents SecCount As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents TimeLogDataGrid As DataGridView
    Friend WithEvents ResetButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LapButton As Button
    Friend WithEvents OpenAnalysisChart As Button
End Class
