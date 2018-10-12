using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutPerf
{
    public partial class GdiPerf : Form
    {
        private bool _figureEnabled;

        public GdiPerf()
        {
            InitializeComponent();
        }

        private void containerPanelsClientAreaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ( containerPanelsClientAreaRadioButton.Checked)
            {
                canvasPanel.Dock = DockStyle.Fill;
                panelWidthNumericUpDown.Enabled = false;
                panelHeightNumericUpDown.Enabled = false;
            }
            else
            {
                canvasPanel.Dock = DockStyle.None;
                panelWidthNumericUpDown.Enabled = true;
                panelHeightNumericUpDown.Enabled = true;
                canvasPanel.Height = (int) panelHeightNumericUpDown.Value;
                canvasPanel.Width = (int) panelWidthNumericUpDown.Value;
            }
        }

        private void panelWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            canvasPanel.Width = (int)panelWidthNumericUpDown.Value;
        }

        private void panelHeightnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            canvasPanel.Width = (int)panelHeightNumericUpDown.Value;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _figureEnabled = true;
            canvasPanel.Invalidate();
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_figureEnabled)
            {
                var pen = Pens.Black;
                var stopWatch = Stopwatch.StartNew();

                for (int x = 0; x < canvasPanel.ClientSize.Width; x+=3)
                {
                    e.Graphics.DrawLine(pen, x, 0,
                                        canvasPanel.ClientSize.Width - 1 - x, 
                                        canvasPanel.ClientSize.Height - 1);

                }

                for (int y = 0; y < canvasPanel.ClientSize.Height; y += 3)
                {
                    e.Graphics.DrawLine(pen, 0, y,
                                        canvasPanel.ClientSize.Width - 1,
                                        canvasPanel.ClientSize.Height - y - 1);

                }

                infoToolStripStatusLabel.Text = $"Testrun: {stopWatch.ElapsedMilliseconds:#,###} ms.";
            }
        }
    }
}
