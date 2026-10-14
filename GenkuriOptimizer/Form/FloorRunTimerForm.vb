Public Class FloorRunTimerForm

    ' ===== 定数 =====
    Private Const MaxLaps As Integer = 20         ' 記録できる最大ラップ数
    Private Const RowsPerColumn As Integer = 10   ' 1組あたりの行数(左: 1〜10周目 / 右: 11〜20周目)
    Private Const FloorsPerRow As Integer = 100   ' 1行あたりの階層数

    ' ===== フィールド =====
    Private ReadOnly sw As New Stopwatch()
    Private ReadOnly LapTimeList As New List(Of TimeSpan)

    ' ===== フォーム読み込み時処理 =====
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With TimeLogDataGrid
            .RowTemplate.Height = 20      ' 行を作る前に設定する
            .ColumnCount = 4
            .RowCount = RowsPerColumn

            .Columns(0).Width = 150
            .Columns(1).Width = 100
            .Columns(2).Width = 150
            .Columns(3).Width = 100

            ' 編集不可にし、選択しても色が変わらないようにする
            .ReadOnly = True
            With .DefaultCellStyle
                .SelectionBackColor = .BackColor
                .SelectionForeColor = .ForeColor
            End With

            ' 1列目・3列目の階層表示を設定
            For i As Integer = 0 To RowsPerColumn - 1
                .Rows(i).Cells(0).Value = FloorRangeText(i)
                .Rows(i).Cells(2).Value = FloorRangeText(i + RowsPerColumn)
            Next
        End With
    End Sub

    ' 階層の範囲文字列を作る(0 → "0-100"、1 → "101-200" ...)
    Private Function FloorRangeText(index As Integer) As String
        Dim low As Integer = If(index = 0, 0, index * FloorsPerRow + 1)
        Dim high As Integer = (index + 1) * FloorsPerRow
        Return $"{low}-{high}"
    End Function

    ' ===== START/STOPボタン押下時処理 =====
    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If sw.IsRunning Then
            sw.Stop()
            StartStopButton.Text = "START"
        Else
            sw.Start()
            StartStopButton.Text = "STOP"
        End If

        ' 計測中のみ、表示更新タイマーとラップボタンを有効にする
        Timer1.Enabled = sw.IsRunning
        LapButton.Enabled = sw.IsRunning
    End Sub

    ' ===== タイマーのTick毎処理 =====
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SecCount.Text = FormatElapsed(sw.Elapsed)
    End Sub

    ' ===== ラップボタン押下時処理 =====
    Private Sub LapButton_Click(sender As Object, e As EventArgs) Handles LapButton.Click
        Dim lapIndex As Integer = LapTimeList.Count     ' 今回が何周目か(0始まり)
        Dim lapTime As TimeSpan = sw.Elapsed
        LapTimeList.Add(lapTime)

        ' 10周目までは2列目、それ以降は4列目に書き込む
        Dim col As Integer = If(lapIndex < RowsPerColumn, 1, 3)
        TimeLogDataGrid.Rows(lapIndex Mod RowsPerColumn).Cells(col).Value = FormatElapsed(lapTime)

        ' 上限に達したら計測を終了する
        If LapTimeList.Count >= MaxLaps Then
            sw.Stop()
            Timer1.Enabled = False
            ' タイマーとの誤差を補正するため、ストップウォッチの値で再表示
            SecCount.Text = FormatElapsed(sw.Elapsed)
            StartStopButton.Text = "START"
            StartStopButton.Enabled = False
            LapButton.Enabled = False
        End If
    End Sub

    ' ===== リセットボタン押下時処理 =====
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        sw.Reset()
        Timer1.Enabled = False
        LapTimeList.Clear()

        StartStopButton.Text = "START"
        StartStopButton.Enabled = True      ' 上限による無効化を解除
        LapButton.Enabled = False
        SecCount.Text = FormatElapsed(TimeSpan.Zero)

        For Each row As DataGridViewRow In TimeLogDataGrid.Rows
            row.Cells(1).Value = Nothing
            row.Cells(3).Value = Nothing
        Next
    End Sub

    ' ===== 結果表示ボタン押下時処理 =====
    Private Sub OpenAnalysisChart_Click(sender As Object, e As EventArgs) Handles OpenAnalysisChart.Click
        Dim chartForm As New FloorAnalysisChartForm()
        chartForm.SetLapTimes(LapTimeList)
        chartForm.Show()
    End Sub
End Class