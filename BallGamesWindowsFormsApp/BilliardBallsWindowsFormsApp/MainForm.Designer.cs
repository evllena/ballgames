namespace BilliardBallsWindowsFormsApp
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
            this.leftLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.Location = new System.Drawing.Point(12, 129);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(15, 16);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "0";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upLabel.Location = new System.Drawing.Point(213, 9);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(15, 16);
            this.upLabel.TabIndex = 1;
            this.upLabel.Text = "0";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.Location = new System.Drawing.Point(408, 129);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(15, 16);
            this.rightLabel.TabIndex = 2;
            this.rightLabel.Text = "0";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel.Location = new System.Drawing.Point(213, 281);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(15, 16);
            this.downLabel.TabIndex = 3;
            this.downLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(431, 306);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.leftLabel);
            this.Name = "MainForm";
            this.Text = "BiliardBalls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
    }
}

