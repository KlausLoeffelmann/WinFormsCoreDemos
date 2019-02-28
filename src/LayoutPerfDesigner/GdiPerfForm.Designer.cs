namespace LayoutPerf
{
    partial class GdiPerfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.containerPanelsClientAreaRadioButton = new System.Windows.Forms.RadioButton();
            this.controlPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fixedSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.canvasContainerPanel = new System.Windows.Forms.Panel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelWidthNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.canvasContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.groupBox1.Size = new System.Drawing.Size(1825, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas Size:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this.containerPanelsClientAreaRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1785, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // containerPanelsClientAreaRadioButton
            // 
            this.containerPanelsClientAreaRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerPanelsClientAreaRadioButton.AutoSize = true;
            this.containerPanelsClientAreaRadioButton.Location = new System.Drawing.Point(209, 26);
            this.containerPanelsClientAreaRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.containerPanelsClientAreaRadioButton.Name = "containerPanelsClientAreaRadioButton";
            this.containerPanelsClientAreaRadioButton.Size = new System.Drawing.Size(363, 29);
            this.containerPanelsClientAreaRadioButton.TabIndex = 2;
            this.containerPanelsClientAreaRadioButton.TabStop = true;
            this.containerPanelsClientAreaRadioButton.Text = "Container Panel\'s client area size";
            this.containerPanelsClientAreaRadioButton.UseVisualStyleBackColor = true;
            this.containerPanelsClientAreaRadioButton.CheckedChanged += new System.EventHandler(this.containerPanelsClientAreaRadioButton_CheckedChanged);
            // 
            // controlPanel1
            // 
            this.controlPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlPanel1.Controls.Add(this.label2);
            this.controlPanel1.Controls.Add(this.panelHeightNumericUpDown);
            this.controlPanel1.Controls.Add(this.panelWidthNumericUpDown);
            this.controlPanel1.Controls.Add(this.label1);
            this.controlPanel1.Controls.Add(this.fixedSizeRadioButton);
            this.controlPanel1.Location = new System.Drawing.Point(797, 6);
            this.controlPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(752, 69);
            this.controlPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pixel";
            // 
            // panelHeightNumericUpDown
            // 
            this.panelHeightNumericUpDown.Location = new System.Drawing.Point(541, 18);
            this.panelHeightNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.panelHeightNumericUpDown.Name = "panelHeightNumericUpDown";
            this.panelHeightNumericUpDown.Size = new System.Drawing.Size(136, 31);
            this.panelHeightNumericUpDown.TabIndex = 8;
            this.panelHeightNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.panelHeightNumericUpDown.ValueChanged += new System.EventHandler(this.panelHeightnumericUpDown_ValueChanged);
            // 
            // panelWidthNumericUpDown
            // 
            this.panelWidthNumericUpDown.Location = new System.Drawing.Point(368, 15);
            this.panelWidthNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWidthNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.panelWidthNumericUpDown.Name = "panelWidthNumericUpDown";
            this.panelWidthNumericUpDown.Size = new System.Drawing.Size(136, 31);
            this.panelWidthNumericUpDown.TabIndex = 7;
            this.panelWidthNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.panelWidthNumericUpDown.ValueChanged += new System.EventHandler(this.panelWidthNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // fixedSizeRadioButton
            // 
            this.fixedSizeRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fixedSizeRadioButton.AutoSize = true;
            this.fixedSizeRadioButton.Checked = true;
            this.fixedSizeRadioButton.Location = new System.Drawing.Point(4, 16);
            this.fixedSizeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixedSizeRadioButton.Name = "fixedSizeRadioButton";
            this.fixedSizeRadioButton.Size = new System.Drawing.Size(363, 29);
            this.fixedSizeRadioButton.TabIndex = 4;
            this.fixedSizeRadioButton.TabStop = true;
            this.fixedSizeRadioButton.Text = "Container Panel\'s client area size";
            this.fixedSizeRadioButton.UseVisualStyleBackColor = true;
            this.fixedSizeRadioButton.CheckedChanged += new System.EventHandler(this.FixedSizeRadioButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(1589, 13);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(171, 55);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 1281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1825, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(164, 32);
            this.infoToolStripStatusLabel.Text = "TestResult ms.";
            // 
            // canvasContainerPanel
            // 
            this.canvasContainerPanel.AutoScroll = true;
            this.canvasContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvasContainerPanel.Controls.Add(this.canvasPanel);
            this.canvasContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasContainerPanel.Location = new System.Drawing.Point(4, 150);
            this.canvasContainerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvasContainerPanel.Name = "canvasContainerPanel";
            this.canvasContainerPanel.Size = new System.Drawing.Size(1825, 1131);
            this.canvasContainerPanel.TabIndex = 2;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(2667, 2500);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            // 
            // GdiPerfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 1322);
            this.Controls.Add(this.canvasContainerPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GdiPerfForm";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "GdiPerf";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.controlPanel1.ResumeLayout(false);
            this.controlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelWidthNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.canvasContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton containerPanelsClientAreaRadioButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel canvasContainerPanel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Panel controlPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown panelHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown panelWidthNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fixedSizeRadioButton;
        private System.Windows.Forms.Button startButton;
        internal System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
    }
}