Public Class FloorAnalysisChartForm
    ' ===== 定数 =====
    Private Const DiamondExpected500 As Double = 125.5
    Private Const DiamondExpected600 As Double = 150.6
    Private Const DiamondExpected700 As Double = 175.7
    Private Const DiamondExpected800 As Double = 200.8
    Private Const DiamondExpected900 As Double = 225.9
    Private Const DiamondExpected1000 As Double = 254.21
    Private Const DiamondExpected1100 As Double = 281.52
    Private Const DiamondExpected1200 As Double = 308.83
    Private Const DiamondExpected1300 As Double = 336.14
    Private Const DiamondExpected1400 As Double = 363.45
    Private Const DiamondExpected1500 As Double = 390.76
    Private Const DiamondExpected1600 As Double = 418.07
    Private Const DiamondExpected1700 As Double = 445.38
    Private Const DiamondExpected1800 As Double = 472.69
    Private Const DiamondExpected1900 As Double = 500
    Private Const DiamondExpected2000 As Double = 529.52

    ' ===== フィールド =====
    Private ReadOnly FloorAnalysisDataGridColumnName() As String = {"階層", "所要時間", "毎時期待値"}
    Private ReadOnly FloorLevels() As Integer = {500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000}
    Private ReceivedLapTimes As New List(Of TimeSpan)
    Private CalcLapTimes As New List(Of TimeSpan)

    ' ラップタイムデータ受け取り処理
    Public Sub SetLapTimes(LapTimes As IEnumerable(Of TimeSpan))
        ReceivedLapTimes = New List(Of TimeSpan)(LapTimes)
    End Sub

    ' ===== フォーム読み込み時処理 =====
    Private Sub FloorAnalysisChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With FloorAnalysisDataGrid
            .RowTemplate.Height = 20      ' 行を作る前に設定する
            .ColumnCount = 3
            .RowCount = FloorLevels.Length + 1

            .Columns(0).Width = 75
            .Columns(1).Width = 75
            .Columns(2).Width = 75

            ' 編集不可にし、選択しても色が変わらないようにする
            .ReadOnly = True
            With .DefaultCellStyle
                .SelectionBackColor = .BackColor
                .SelectionForeColor = .ForeColor
            End With

            ' 列名の設定
            For i As Integer = 0 To FloorAnalysisDataGridColumnName.Length - 1
                .Rows(0).Cells(i).Value = FloorAnalysisDataGridColumnName(i)
            Next

            ' 階層列の設定
            For i As Integer = 0 To FloorLevels.Length - 1
                .Rows(i + 1).Cells(0).Value = FloorLevels(i)
            Next

            ' 所要時間列の設定
            For i As Integer = 0 To FloorLevels.Length - 1
                Dim lapIndex As Integer = i + 4 ' 500層 → 5周目 → インデックス4
                If lapIndex = ReceivedLapTimes.Count Then
                    Exit For
                End If
                .Rows(i + 1).Cells(1).Value = FormatElapsed(ReceivedLapTimes(lapIndex))
                CalcLapTimes.Add(ReceivedLapTimes(lapIndex))
            Next



        End With
    End Sub
End Class