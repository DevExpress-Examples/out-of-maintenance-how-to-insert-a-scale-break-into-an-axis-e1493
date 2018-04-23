using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace UseScaleBreaks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            if (checkEdit1.Checked) {
                // Enable auto scale breaks and define their allowed number.
                ((XYDiagram)chartControl1.Diagram).AxisY.AutoScaleBreaks.Enabled = true;
                ((XYDiagram)chartControl1.Diagram).AxisY.AutoScaleBreaks.MaxCount = 2;

                setScaleBreaksAppearance();
            }
            else {
                ((XYDiagram)chartControl1.Diagram).AxisY.AutoScaleBreaks.Enabled = false;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e) {
            if (checkEdit2.Checked) {
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreaks.Clear();

                // Create scale breaks  manually, 
                // with their Edge1 and Edge2 properties defined in the constructor.
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreaks.Add(new ScaleBreak("Scale Break 1", 10, 100));
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreaks.Add(new ScaleBreak("Scale Break 2", 110, 2000));

                setScaleBreaksAppearance();
            }
            else {
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreaks.Clear();
            }
        }

        private void setScaleBreaksAppearance() {
            if (((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreaks.Count > 0 ||
                ((XYDiagram)chartControl1.Diagram).AxisY.AutoScaleBreaks.Enabled) {

                // Define the scale breaks' options.
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreakOptions.Style = ScaleBreakStyle.Waved;
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreakOptions.SizeInPixels = 20;
                ((XYDiagram)chartControl1.Diagram).AxisY.ScaleBreakOptions.Color = Color.RoyalBlue;
            }
        }

    }
}