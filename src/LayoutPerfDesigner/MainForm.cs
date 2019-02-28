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
    public partial class MainForm : Form
    {
        private List<Type> _containerControlTypeList = new List<Type> { typeof(GroupBox) ,
                                                                        typeof(Panel),
                                                                        typeof(FlowLayoutPanel)};

        public MainForm()
        {
            InitializeComponent();
            foreach (var typeItem in _containerControlTypeList)
            {
                containerControlTypesComboBox.Items.Add(typeItem);
            }
            containerControlTypesComboBox.SelectedIndex = 0;
        }

        private void LayoutPerformanceStartButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).BeginInvoke(new Action(RunTests));
        }

        private void RunTests()
        {
            var formCount = measurementsNumericUpDown.Value;

            var columns = !useScrollablePanelRadioButton.Checked ?
                           panelCountNumericUpDown.Value :
                           1;

            for (int c = 0; c < formCount; c++)
            {
                var stopWatch = Stopwatch.StartNew();

                var layoutContainer = new LayoutContainerForm { Text = $"Testrun {c}" };
                layoutContainer.SuspendLayout();
                var columnPanel_x = 5;

                for (int columnCount = 0; columnCount < columns; columnCount++)
                {
                    var contentContainer_y = 20;

                    var columnPanel = new Panel
                    {
                        AutoSize = true,
                        Location = new Point(columnPanel_x, 10)
                    };

                    for (int boxedContainers = 0; boxedContainers < containerPerColumnNumericUpDown.Value; boxedContainers++)
                    {
                        var contentContainer = (Control)Activator.CreateInstance((Type)containerControlTypesComboBox.SelectedItem);
                        contentContainer.Location = new Point(10, contentContainer_y);
                        contentContainer.AutoSize = true;
                        contentContainer.Padding = new Padding(20);
                        contentContainer.BackColor = Color.Yellow;

                        contentContainer_y += contentContainer.Height + 5;
                        var contentPanel_y = 20;

                        bool firstRunFlag = false;

                        for (int contentItems = 0; contentItems < controlPerSurroundingContainerNumericUpDown.Value; contentItems++)
                        {
                            var contentPanel = new Panel
                            {
                                Size = new Size(1, 1),
                                AutoSize = true,
                                Location = new Point(0, contentPanel_y),
                                BorderStyle = BorderStyle.Fixed3D,
                                Padding = new Padding(5)
                            };

                            if (!firstRunFlag)
                            {
                                contentPanel.Controls.Add(new Label
                                {
                                    Text = $"Control Block #{boxedContainers}",
                                    Font = new Font("Consolas", 18, FontStyle.Bold),
                                    AutoSize = true,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Margin = new Padding(10),
                                    Padding = new Padding(3),
                                    Location = new Point(0, 5)
                                });
                                firstRunFlag = true;
                            }
                            else
                            {
                                var label = new Label
                                {
                                    Text = $"Label {boxedContainers + 1}:{contentItems + 1}",
                                    AutoSize = true,
                                    Location = new Point(5, 5)
                                };
                                contentPanel.Controls.Add(label);
                                var textBox = new TextBox
                                {
                                    Location = new Point(100, 5),
                                    Size = new Size(200, 25)
                                };

                                contentPanel.Controls.Add(textBox);
                            }
                            contentContainer.Controls.Add(contentPanel);
                            contentPanel_y += contentPanel.Height + 10;
                        }

                        columnPanel.Controls.Add(contentContainer);
                        contentContainer_y += contentContainer.Height + 20;
                    }

                    layoutContainer.contentContainerPanel.Controls.Add(columnPanel);
                    columnPanel_x += columnPanel.Width + 20;

                }

                layoutContainer.ResumeLayout();
                layoutContainer.Show();
                layoutContainer.infoToolStripStatusLabel.Text = $"Testrun: {stopWatch.ElapsedMilliseconds:#,###} ms.";
            }
        }

        private void SimpleGdiPerformanceTest_Click(object sender, EventArgs e)
        {
            new GdiPerfForm().ShowDialog();
            return;
        }

        private void fiddleButton_Click(object sender, EventArgs e)
        {
            new FiddleForm().ShowDialog();
            return;
        }
    }
}
