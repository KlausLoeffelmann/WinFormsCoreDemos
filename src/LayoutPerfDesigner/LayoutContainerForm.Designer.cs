namespace LayoutPerf
{
    partial class LayoutContainerForm
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
            this.contentContainerPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainerPanel
            // 
            this.contentContainerPanel.AutoScroll = true;
            this.contentContainerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contentContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.contentContainerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentContainerPanel.Name = "contentContainerPanel";
            this.contentContainerPanel.Size = new System.Drawing.Size(1307, 868);
            this.contentContainerPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 831);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1307, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(164, 32);
            this.infoToolStripStatusLabel.Text = "TestResult ms.";
            // 
            // LayoutContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 868);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.contentContainerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LayoutContainerForm";
            this.Text = "Testrun #";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
        internal System.Windows.Forms.Panel contentContainerPanel;
    }
}