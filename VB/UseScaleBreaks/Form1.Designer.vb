Namespace UseScaleBreaks
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(5, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(104, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(2006, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(3, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(108, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(2007, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (DirectCast(4, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (DirectCast(105, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (DirectCast(2009, Object))})
            Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            xyDiagram1.AxisX.Label.Visible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(12, 37)
            Me.chartControl1.Name = "chartControl1"
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
            Me.chartControl1.Size = New System.Drawing.Size(319, 278)
            Me.chartControl1.TabIndex = 0
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Show Auto Scale Breaks"
            Me.checkEdit1.Size = New System.Drawing.Size(157, 19)
            Me.checkEdit1.TabIndex = 1
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.Location = New System.Drawing.Point(175, 12)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Show Manual Scale Breaks"
            Me.checkEdit2.Size = New System.Drawing.Size(156, 19)
            Me.checkEdit2.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(343, 327)
            Me.Controls.Add(Me.checkEdit2)
            Me.Controls.Add(Me.checkEdit1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace

