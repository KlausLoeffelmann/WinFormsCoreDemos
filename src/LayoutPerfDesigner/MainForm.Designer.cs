namespace LayoutPerf
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.measurementsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.controlPerSurroundingContainerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.containerControlTypesComboBox = new System.Windows.Forms.ComboBox();
            this.containerPerColumnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useTableLayoutPanelRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useSideBySidePanelsRadioButton = new System.Windows.Forms.RadioButton();
            this.useScrollablePanelRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPerSurroundingContainerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerPerColumnNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(959, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boxing content";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.measurementsNumericUpDown);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.controlPerSurroundingContainerNumericUpDown);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.containerControlTypesComboBox);
            this.panel2.Controls.Add(this.containerPerColumnNumericUpDown);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 150);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "measurement runs in corresponding forms.";
            // 
            // measurementsNumericUpDown
            // 
            this.measurementsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementsNumericUpDown.Location = new System.Drawing.Point(56, 97);
            this.measurementsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.measurementsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.measurementsNumericUpDown.Name = "measurementsNumericUpDown";
            this.measurementsNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.measurementsNumericUpDown.TabIndex = 9;
            this.measurementsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "content units per surrounding container.";
            // 
            // controlPerSurroundingContainerNumericUpDown
            // 
            this.controlPerSurroundingContainerNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlPerSurroundingContainerNumericUpDown.Location = new System.Drawing.Point(56, 58);
            this.controlPerSurroundingContainerNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.controlPerSurroundingContainerNumericUpDown.Name = "controlPerSurroundingContainerNumericUpDown";
            this.controlPerSurroundingContainerNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.controlPerSurroundingContainerNumericUpDown.TabIndex = 5;
            this.controlPerSurroundingContainerNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Use";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "per column.";
            // 
            // containerControlTypesComboBox
            // 
            this.containerControlTypesComboBox.FormattingEnabled = true;
            this.containerControlTypesComboBox.Location = new System.Drawing.Point(172, 16);
            this.containerControlTypesComboBox.Name = "containerControlTypesComboBox";
            this.containerControlTypesComboBox.Size = new System.Drawing.Size(318, 28);
            this.containerControlTypesComboBox.TabIndex = 2;
            // 
            // containerPerColumnNumericUpDown
            // 
            this.containerPerColumnNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPerColumnNumericUpDown.Location = new System.Drawing.Point(56, 17);
            this.containerPerColumnNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.containerPerColumnNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.containerPerColumnNumericUpDown.Name = "containerPerColumnNumericUpDown";
            this.containerPerColumnNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.containerPerColumnNumericUpDown.TabIndex = 1;
            this.containerPerColumnNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Use";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Layout";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ColumnsNumericUpDown);
            this.panel1.Controls.Add(this.useTableLayoutPanelRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PanelCountNumericUpDown);
            this.panel1.Controls.Add(this.useSideBySidePanelsRadioButton);
            this.panel1.Controls.Add(this.useScrollablePanelRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 163);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "columns.";
            // 
            // ColumnsNumericUpDown
            // 
            this.ColumnsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnsNumericUpDown.Location = new System.Drawing.Point(274, 92);
            this.ColumnsNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ColumnsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnsNumericUpDown.Name = "ColumnsNumericUpDown";
            this.ColumnsNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.ColumnsNumericUpDown.TabIndex = 0;
            this.ColumnsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // useTableLayoutPanelRadioButton
            // 
            this.useTableLayoutPanelRadioButton.AutoSize = true;
            this.useTableLayoutPanelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useTableLayoutPanelRadioButton.Location = new System.Drawing.Point(25, 92);
            this.useTableLayoutPanelRadioButton.Name = "useTableLayoutPanelRadioButton";
            this.useTableLayoutPanelRadioButton.Size = new System.Drawing.Size(243, 24);
            this.useTableLayoutPanelRadioButton.TabIndex = 6;
            this.useTableLayoutPanelRadioButton.TabStop = true;
            this.useTableLayoutPanelRadioButton.Text = "Use a TableLayoutPanel with ";
            this.useTableLayoutPanelRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "panels lying side by side in a scrollable container.";
            // 
            // PanelCountNumericUpDown
            // 
            this.PanelCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCountNumericUpDown.Location = new System.Drawing.Point(98, 62);
            this.PanelCountNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PanelCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PanelCountNumericUpDown.Name = "PanelCountNumericUpDown";
            this.PanelCountNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.PanelCountNumericUpDown.TabIndex = 2;
            this.PanelCountNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // useSideBySidePanelsRadioButton
            // 
            this.useSideBySidePanelsRadioButton.AutoSize = true;
            this.useSideBySidePanelsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useSideBySidePanelsRadioButton.Location = new System.Drawing.Point(25, 62);
            this.useSideBySidePanelsRadioButton.Name = "useSideBySidePanelsRadioButton";
            this.useSideBySidePanelsRadioButton.Size = new System.Drawing.Size(67, 24);
            this.useSideBySidePanelsRadioButton.TabIndex = 1;
            this.useSideBySidePanelsRadioButton.TabStop = true;
            this.useSideBySidePanelsRadioButton.Text = "Use ";
            this.useSideBySidePanelsRadioButton.UseVisualStyleBackColor = true;
            // 
            // useScrollablePanelRadioButton
            // 
            this.useScrollablePanelRadioButton.AutoSize = true;
            this.useScrollablePanelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useScrollablePanelRadioButton.Location = new System.Drawing.Point(25, 32);
            this.useScrollablePanelRadioButton.Name = "useScrollablePanelRadioButton";
            this.useScrollablePanelRadioButton.Size = new System.Drawing.Size(396, 24);
            this.useScrollablePanelRadioButton.TabIndex = 0;
            this.useScrollablePanelRadioButton.TabStop = true;
            this.useScrollablePanelRadioButton.Text = "Use only a scrollable Panel as the container control.";
            this.useScrollablePanelRadioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(417, 432);
            this.startButton.Margin = new System.Windows.Forms.Padding(15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 54);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "WinForms Core Layout Performance Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPerSurroundingContainerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerPerColumnNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown controlPerSurroundingContainerNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox containerControlTypesComboBox;
        private System.Windows.Forms.NumericUpDown containerPerColumnNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ColumnsNumericUpDown;
        private System.Windows.Forms.RadioButton useTableLayoutPanelRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PanelCountNumericUpDown;
        private System.Windows.Forms.RadioButton useSideBySidePanelsRadioButton;
        private System.Windows.Forms.RadioButton useScrollablePanelRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown measurementsNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startButton;
    }
}

