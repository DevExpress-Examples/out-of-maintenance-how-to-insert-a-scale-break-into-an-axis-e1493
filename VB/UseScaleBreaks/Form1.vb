Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace UseScaleBreaks
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            If checkEdit1.Checked Then
                ' Enable auto scale breaks and define their allowed number.
                CType(chartControl1.Diagram, XYDiagram).AxisY.AutoScaleBreaks.Enabled = True
                CType(chartControl1.Diagram, XYDiagram).AxisY.AutoScaleBreaks.MaxCount = 2

                setScaleBreaksAppearance()
            Else
                CType(chartControl1.Diagram, XYDiagram).AxisY.AutoScaleBreaks.Enabled = False
            End If
        End Sub

        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckedChanged
            If checkEdit2.Checked Then
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreaks.Clear()

                ' Create scale breaks  manually, 
                ' with their Edge1 and Edge2 properties defined in the constructor.
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreaks.Add(New ScaleBreak("Scale Break 1", 10, 100))
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreaks.Add(New ScaleBreak("Scale Break 2", 110, 2000))

                setScaleBreaksAppearance()
            Else
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreaks.Clear()
            End If
        End Sub

        Private Sub setScaleBreaksAppearance()
            If CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreaks.Count > 0 OrElse CType(chartControl1.Diagram, XYDiagram).AxisY.AutoScaleBreaks.Enabled Then

                ' Define the scale breaks' options.
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreakOptions.Style = ScaleBreakStyle.Waved
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreakOptions.SizeInPixels = 20
                CType(chartControl1.Diagram, XYDiagram).AxisY.ScaleBreakOptions.Color = Color.RoyalBlue
            End If
        End Sub

    End Class
End Namespace