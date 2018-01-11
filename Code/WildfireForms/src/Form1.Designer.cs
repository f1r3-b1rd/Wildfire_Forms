namespace WildfireForms
{
    partial class Form1
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
            this.ppLabel = new System.Windows.Forms.Label();
            this.fpLabel = new System.Windows.Forms.Label();
            this.grLabel = new System.Windows.Forms.Label();
            this.brLabel = new System.Windows.Forms.Label();
            this.plantProbability = new System.Windows.Forms.TextBox();
            this.fireProbability = new System.Windows.Forms.TextBox();
            this.growthRate = new System.Windows.Forms.TextBox();
            this.burnRate = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.wfPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ppLabel
            // 
            this.ppLabel.AutoSize = true;
            this.ppLabel.Location = new System.Drawing.Point(13, 13);
            this.ppLabel.Name = "ppLabel";
            this.ppLabel.Size = new System.Drawing.Size(110, 17);
            this.ppLabel.TabIndex = 0;
            this.ppLabel.Text = "Plant Probability";
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.Location = new System.Drawing.Point(13, 34);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(102, 17);
            this.fpLabel.TabIndex = 1;
            this.fpLabel.Text = "Fire Probability";
            // 
            // grLabel
            // 
            this.grLabel.AutoSize = true;
            this.grLabel.Location = new System.Drawing.Point(13, 55);
            this.grLabel.Name = "grLabel";
            this.grLabel.Size = new System.Drawing.Size(140, 17);
            this.grLabel.TabIndex = 2;
            this.grLabel.Text = "Growth Rate (cycles)";
            // 
            // brLabel
            // 
            this.brLabel.AutoSize = true;
            this.brLabel.Location = new System.Drawing.Point(13, 76);
            this.brLabel.Name = "brLabel";
            this.brLabel.Size = new System.Drawing.Size(125, 17);
            this.brLabel.TabIndex = 3;
            this.brLabel.Text = "Burn Rate (cycles)";
            // 
            // plantProbability
            // 
            this.plantProbability.Location = new System.Drawing.Point(161, 13);
            this.plantProbability.Name = "plantProbability";
            this.plantProbability.Size = new System.Drawing.Size(100, 22);
            this.plantProbability.TabIndex = 4;
            // 
            // fireProbability
            // 
            this.fireProbability.Location = new System.Drawing.Point(161, 34);
            this.fireProbability.Name = "fireProbability";
            this.fireProbability.Size = new System.Drawing.Size(100, 22);
            this.fireProbability.TabIndex = 5;
            // 
            // growthRate
            // 
            this.growthRate.Location = new System.Drawing.Point(161, 55);
            this.growthRate.Name = "growthRate";
            this.growthRate.Size = new System.Drawing.Size(100, 22);
            this.growthRate.TabIndex = 6;
            // 
            // burnRate
            // 
            this.burnRate.Location = new System.Drawing.Point(161, 76);
            this.burnRate.Name = "burnRate";
            this.burnRate.Size = new System.Drawing.Size(100, 22);
            this.burnRate.TabIndex = 7;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // wfPictureBox
            // 
            this.wfPictureBox.Location = new System.Drawing.Point(267, 12);
            this.wfPictureBox.Name = "wfPictureBox";
            this.wfPictureBox.Size = new System.Drawing.Size(500, 500);
            this.wfPictureBox.TabIndex = 8;
            this.wfPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 105);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(16, 212);
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(229, 56);
            this.speedTrackBar.TabIndex = 10;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(13, 176);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(49, 17);
            this.speedLabel.TabIndex = 11;
            this.speedLabel.Text = "Speed";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 105);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 549);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wfPictureBox);
            this.Controls.Add(this.burnRate);
            this.Controls.Add(this.growthRate);
            this.Controls.Add(this.fireProbability);
            this.Controls.Add(this.plantProbability);
            this.Controls.Add(this.brLabel);
            this.Controls.Add(this.grLabel);
            this.Controls.Add(this.fpLabel);
            this.Controls.Add(this.ppLabel);
            this.Name = "Form1";
            this.Text = "Wildfire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ppLabel;
        private System.Windows.Forms.Label fpLabel;
        private System.Windows.Forms.Label grLabel;
        private System.Windows.Forms.Label brLabel;
        private System.Windows.Forms.TextBox plantProbability;
        private System.Windows.Forms.TextBox fireProbability;
        private System.Windows.Forms.TextBox growthRate;
        private System.Windows.Forms.TextBox burnRate;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.PictureBox wfPictureBox;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

