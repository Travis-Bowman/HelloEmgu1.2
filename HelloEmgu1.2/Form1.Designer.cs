namespace HelloEmgu1._2
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
            this.emguPictureBox = new System.Windows.Forms.PictureBox();
            this.binaryPictureBox = new System.Windows.Forms.PictureBox();
            this.ThresholdTrackbar = new System.Windows.Forms.TrackBar();
            this.whitePixelsExtendedOutputLOL = new System.Windows.Forms.Label();
            this.whitePixelsExtendedOutputLIL = new System.Windows.Forms.Label();
            this.whitePixelsExtendedOutputLCent = new System.Windows.Forms.Label();
            this.whitePixelsExtendedOutputLIR = new System.Windows.Forms.Label();
            this.whitePixelsExtendedOutputLOR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // emguPictureBox
            // 
            this.emguPictureBox.Location = new System.Drawing.Point(152, 107);
            this.emguPictureBox.Name = "emguPictureBox";
            this.emguPictureBox.Size = new System.Drawing.Size(1016, 755);
            this.emguPictureBox.TabIndex = 0;
            this.emguPictureBox.TabStop = false;
            // 
            // binaryPictureBox
            // 
            this.binaryPictureBox.Location = new System.Drawing.Point(1498, 123);
            this.binaryPictureBox.Name = "binaryPictureBox";
            this.binaryPictureBox.Size = new System.Drawing.Size(1104, 738);
            this.binaryPictureBox.TabIndex = 1;
            this.binaryPictureBox.TabStop = false;
            // 
            // ThresholdTrackbar
            // 
            this.ThresholdTrackbar.Location = new System.Drawing.Point(426, 920);
            this.ThresholdTrackbar.Maximum = 250;
            this.ThresholdTrackbar.Minimum = 1;
            this.ThresholdTrackbar.Name = "ThresholdTrackbar";
            this.ThresholdTrackbar.Size = new System.Drawing.Size(1737, 114);
            this.ThresholdTrackbar.TabIndex = 2;
            this.ThresholdTrackbar.Value = 1;
            this.ThresholdTrackbar.Scroll += new System.EventHandler(this.ThresholdTrackbar_ValueChanged);
            // 
            // whitePixelsExtendedOutputLOL
            // 
            this.whitePixelsExtendedOutputLOL.AutoSize = true;
            this.whitePixelsExtendedOutputLOL.Location = new System.Drawing.Point(1492, 58);
            this.whitePixelsExtendedOutputLOL.Name = "whitePixelsExtendedOutputLOL";
            this.whitePixelsExtendedOutputLOL.Size = new System.Drawing.Size(196, 32);
            this.whitePixelsExtendedOutputLOL.TabIndex = 3;
            this.whitePixelsExtendedOutputLOL.Text = "whitePixelsOL";
            // 
            // whitePixelsExtendedOutputLIL
            // 
            this.whitePixelsExtendedOutputLIL.AutoSize = true;
            this.whitePixelsExtendedOutputLIL.Location = new System.Drawing.Point(1747, 58);
            this.whitePixelsExtendedOutputLIL.Name = "whitePixelsExtendedOutputLIL";
            this.whitePixelsExtendedOutputLIL.Size = new System.Drawing.Size(181, 32);
            this.whitePixelsExtendedOutputLIL.TabIndex = 4;
            this.whitePixelsExtendedOutputLIL.Text = "whitePixelsIL";
            // 
            // whitePixelsExtendedOutputLCent
            // 
            this.whitePixelsExtendedOutputLCent.AutoSize = true;
            this.whitePixelsExtendedOutputLCent.Location = new System.Drawing.Point(1976, 58);
            this.whitePixelsExtendedOutputLCent.Name = "whitePixelsExtendedOutputLCent";
            this.whitePixelsExtendedOutputLCent.Size = new System.Drawing.Size(218, 32);
            this.whitePixelsExtendedOutputLCent.TabIndex = 5;
            this.whitePixelsExtendedOutputLCent.Text = "whitePixelsCent";
            // 
            // whitePixelsExtendedOutputLIR
            // 
            this.whitePixelsExtendedOutputLIR.AutoSize = true;
            this.whitePixelsExtendedOutputLIR.Location = new System.Drawing.Point(2207, 61);
            this.whitePixelsExtendedOutputLIR.Name = "whitePixelsExtendedOutputLIR";
            this.whitePixelsExtendedOutputLIR.Size = new System.Drawing.Size(185, 32);
            this.whitePixelsExtendedOutputLIR.TabIndex = 6;
            this.whitePixelsExtendedOutputLIR.Text = "whitePixelsIR";
            // 
            // whitePixelsExtendedOutputLOR
            // 
            this.whitePixelsExtendedOutputLOR.AutoSize = true;
            this.whitePixelsExtendedOutputLOR.Location = new System.Drawing.Point(2429, 61);
            this.whitePixelsExtendedOutputLOR.Name = "whitePixelsExtendedOutputLOR";
            this.whitePixelsExtendedOutputLOR.Size = new System.Drawing.Size(200, 32);
            this.whitePixelsExtendedOutputLOR.TabIndex = 7;
            this.whitePixelsExtendedOutputLOR.Text = "whitePixelsOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2914, 1046);
            this.Controls.Add(this.whitePixelsExtendedOutputLOR);
            this.Controls.Add(this.whitePixelsExtendedOutputLIR);
            this.Controls.Add(this.whitePixelsExtendedOutputLCent);
            this.Controls.Add(this.whitePixelsExtendedOutputLIL);
            this.Controls.Add(this.whitePixelsExtendedOutputLOL);
            this.Controls.Add(this.ThresholdTrackbar);
            this.Controls.Add(this.binaryPictureBox);
            this.Controls.Add(this.emguPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emguPictureBox;
        private System.Windows.Forms.PictureBox binaryPictureBox;
        private System.Windows.Forms.TrackBar ThresholdTrackbar;
        private System.Windows.Forms.Label whitePixelsExtendedOutputLOL;
        private System.Windows.Forms.Label whitePixelsExtendedOutputLIL;
        private System.Windows.Forms.Label whitePixelsExtendedOutputLCent;
        private System.Windows.Forms.Label whitePixelsExtendedOutputLIR;
        private System.Windows.Forms.Label whitePixelsExtendedOutputLOR;
    }
}

