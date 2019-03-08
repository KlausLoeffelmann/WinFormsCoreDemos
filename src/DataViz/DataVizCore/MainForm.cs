// Original samples by cephalin@microsoft.com (Cephas Lin)
// https://code.msdn.microsoft.com/Samples-Environments-for-b01e9c61

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#if DATAVIZCORE
using System.Windows.Forms.DataVisualization.Charting;
#endif

namespace DataVizCore
{
    public partial class MainForm : Form
    {
#if DATAVIZCORE
        Chart chartControl;
#endif

        private Point mouseDownPoint = Point.Empty;
        private int origRotation = 0;
        private int origInclination = 0;

        public MainForm()
        {
            InitializeComponent();
#if DATAVIZCORE
            const int PADDING= 10;

            chartControl = new Chart
            {
                Location = new Point(PADDING, PADDING),
                Size = new Size(ClientSize.Width - PADDING * 2, ClientSize.Height - PADDING * 2),
                Anchor = AnchorStyles.Bottom |
                                  AnchorStyles.Top |
                                  AnchorStyles.Left |
                                  AnchorStyles.Right
            };

            chartControl.MouseDown += ChartControl_MouseDown;
            chartControl.MouseUp += ChartControl_MouseUp;
            chartControl.MouseMove += ChartControl_MouseMove;

            this.Controls.Add(chartControl);
#endif
        }

        private void Demo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DATAVIZCORE
            // Create Chart Area
            ChartArea chartArea1 = new ChartArea();

            // Enable 3D charts
            chartArea1.Area3DStyle.Enable3D = true;

            // Add Chart Area to the Chart
            chartControl.ChartAreas.Add(chartArea1);

            // Create a data series
            Series series1 = new Series();
            series1["DrawingStyle"] = "Cylinder";
            

            Series series2 = new Series();
            Series series3 = new Series();

            // Add data points to the first series
            series1.Points.Add(34);
            series1.Points.Add(24);
            series1.Points.Add(32);
            series1.Points.Add(28);
            series1.Points.Add(44);

            // Add data points to the second series
            series2.Points.Add(14);
            series2.Points.Add(44);
            series2.Points.Add(24);
            series2.Points.Add(32);
            series2.Points.Add(28);

            // Add data points to the second series
            series3.Points.Add(24);
            series3.Points.Add(34);
            series3.Points.Add(14);
            series3.Points.Add(22);
            series3.Points.Add(18);


            // Add series to the chart
            chartControl.Series.Add(series1);
            chartControl.Series.Add(series2);
            chartControl.Series.Add(series3);

            var chartTitel = new Title();
            chartTitel.Font = new System.Drawing.Font(this.Font.Name, 14.25F, System.Drawing.FontStyle.Bold);
            chartTitel.ForeColor = Color.Black;
            chartTitel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartTitel.ShadowOffset = 3;
            chartTitel.Text = "3D Chart (WinForms Core)";
            this.chartControl.Titles.Add(chartTitel);

#endif
        }

        private void ChartControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            chartControl.Cursor = Cursors.NoMove2D;
            mouseDownPoint = new Point(e.X, e.Y);
            origRotation = this.chartControl.ChartAreas[0].Area3DStyle.Rotation;
            origInclination = this.chartControl.ChartAreas[0].Area3DStyle.Inclination;
        }

        private void ChartControl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            chartControl.Cursor = Cursors.Hand;
            mouseDownPoint = Point.Empty;
        }

        private void ChartControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!mouseDownPoint.IsEmpty)
            {
                int RotationDelta = (mouseDownPoint.X - e.X / 10);
                int Rotation = origRotation;
                for (int i = 0; i != RotationDelta;)
                {
                    if (RotationDelta > 0)
                    {
                        if (Rotation >= 180)
                        {
                            Rotation = -180;
                        }
                        ++Rotation;
                    }
                    else
                    {
                        if (Rotation <= -180)
                        {
                            Rotation = 180;
                        }
                        --Rotation;
                    }

                    i += (RotationDelta > 0) ? 1 : -1;
                }
                this.chartControl.ChartAreas[0].Area3DStyle.Rotation = Rotation;

                int InclinationDelta = (e.Y - mouseDownPoint.Y);
                int Inclination = origInclination;
                for (int i = 0; i != InclinationDelta;)
                {
                    if (InclinationDelta > 0)
                    {
                        if (Inclination >= 90)
                        {
                            Inclination = -90;
                        }
                        ++Inclination;
                    }
                    else
                    {
                        if (Inclination <= -90)
                        {
                            Inclination = 90;
                        }
                        --Inclination;
                    }

                    i += (InclinationDelta > 0) ? 1 : -1;
                }
                this.chartControl.ChartAreas[0].Area3DStyle.Inclination = Inclination;

                this.chartControl.Invalidate();
                this.chartControl.Update();
            }
        }
    }
}
