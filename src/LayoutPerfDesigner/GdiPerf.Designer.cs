namespace LayoutPerf
{
    partial class GdiPerf
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.canvasContainerPanel = new System.Windows.Forms.Panel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(1369, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas Size:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.containerPanelsClientAreaRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1339, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // containerPanelsClientAreaRadioButton
            // 
            this.containerPanelsClientAreaRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerPanelsClientAreaRadioButton.AutoSize = true;
            this.containerPanelsClientAreaRadioButton.Location = new System.Drawing.Point(160, 21);
            this.containerPanelsClientAreaRadioButton.Name = "containerPanelsClientAreaRadioButton";
            this.containerPanelsClientAreaRadioButton.Size = new System.Drawing.Size(267, 24);
            this.containerPanelsClientAreaRadioButton.TabIndex = 2;
            this.containerPanelsClientAreaRadioButton.TabStop = true;
            this.containerPanelsClientAreaRadioButton.Text = "Container Panel\'s client area size";
            this.containerPanelsClientAreaRadioButton.UseVisualStyleBackColor = true;
            this.containerPanelsClientAreaRadioButton.CheckedChanged += new System.EventHandler(this.containerPanelsClientAreaRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelHeightNumericUpDown);
            this.panel1.Controls.Add(this.panelWidthNumericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(598, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 55);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pixel";
            // 
            // panelHeightNumericUpDown
            // 
            this.panelHeightNumericUpDown.Location = new System.Drawing.Point(406, 14);
            this.panelHeightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.panelHeightNumericUpDown.Name = "panelHeightNumericUpDown";
            this.panelHeightNumericUpDown.Size = new System.Drawing.Size(102, 26);
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
            this.panelWidthNumericUpDown.Location = new System.Drawing.Point(276, 12);
            this.panelWidthNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.panelWidthNumericUpDown.Name = "panelWidthNumericUpDown";
            this.panelWidthNumericUpDown.Size = new System.Drawing.Size(102, 26);
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
            this.label1.Location = new System.Drawing.Point(384, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(267, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Container Panel\'s client area size";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 1025);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1369, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // canvasContainerPanel
            // 
            this.canvasContainerPanel.AutoScroll = true;
            this.canvasContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvasContainerPanel.Controls.Add(this.canvasPanel);
            this.canvasContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasContainerPanel.Location = new System.Drawing.Point(3, 120);
            this.canvasContainerPanel.Name = "canvasContainerPanel";
            this.canvasContainerPanel.Size = new System.Drawing.Size(1369, 905);
            this.canvasContainerPanel.TabIndex = 2;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(2000, 2000);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(1192, 11);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 44);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(122, 25);
            this.infoToolStripStatusLabel.Text = "TestResult ms.";
            // 
            // GdiPerf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 1058);
            this.Controls.Add(this.canvasContainerPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GdiPerf";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "GdiPerf";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown panelHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown panelWidthNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button startButton;
        internal System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
    }
}