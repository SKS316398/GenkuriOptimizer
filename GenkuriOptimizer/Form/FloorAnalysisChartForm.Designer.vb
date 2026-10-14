<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloorAnalysisChartForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FloorAnalysisDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.FloorAnalysisDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloorAnalysisDataGrid
        '
        Me.FloorAnalysisDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FloorAnalysisDataGrid.ColumnHeadersVisible = False
        Me.FloorAnalysisDataGrid.Location = New System.Drawing.Point(47, 28)
        Me.FloorAnalysisDataGrid.Name = "FloorAnalysisDataGrid"
        Me.FloorAnalysisDataGrid.RowHeadersVisible = False
        Me.FloorAnalysisDataGrid.RowTemplate.Height = 21
        Me.FloorAnalysisDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FloorAnalysisDataGrid.Size = New System.Drawing.Size(225, 340)
        Me.FloorAnalysisDataGrid.TabIndex = 4
        '
        'FloorAnalysisChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FloorAnalysisDataGrid)
        Me.Name = "FloorAnalysisChartForm"
        Me.Text = "FloorAnalysisChartForm"
        CType(Me.FloorAnalysisDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FloorAnalysisDataGrid As DataGridView
End Class
