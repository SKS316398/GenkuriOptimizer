Module TimeFormatter
    ' ===== 経過時間の表示文字列を作る =====
    Public Function FormatElapsed(ts As TimeSpan) As String
        Dim cs As Integer = ts.Milliseconds \ 10        ' 1/100秒
        Dim totalHours As Integer = ts.Days * 24 + ts.Hours

        If totalHours >= 1 Then
            Return $"{totalHours}:{ts.Minutes:00}:{ts.Seconds:00}.{cs:00}"   ' 0:00:00.00
        ElseIf ts.Minutes >= 10 Then
            Return $"{ts.Minutes:00}:{ts.Seconds:00}.{cs:00}"                ' 00:00.00
        ElseIf ts.Minutes >= 1 Then
            Return $"{ts.Minutes}:{ts.Seconds:00}.{cs:00}"                   ' 0:00.00
        ElseIf ts.Seconds >= 10 Then
            Return $"{ts.Seconds:00}.{cs:00}"                                ' 00.00
        Else
            Return $"{ts.Seconds}.{cs:00}"                                   ' 0.00
        End If
    End Function
End Module
