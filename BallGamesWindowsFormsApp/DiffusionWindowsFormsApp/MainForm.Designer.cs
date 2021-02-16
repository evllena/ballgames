namespace DiffusionWindowsFormsApp
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
            this.startButton = new System.Windows.Forms.Button();
            this.leftMintLabel = new System.Windows.Forms.Label();
            this.brownLeftLabel = new System.Windows.Forms.Label();
            this.upMintLabel = new System.Windows.Forms.Label();
            this.rightMintLabel = new System.Windows.Forms.Label();
            this.downMintLabel = new System.Windows.Forms.Label();
            this.brownDownLabel = new System.Windows.Forms.Label();
            this.brownRightLabel = new System.Windows.Forms.Label();
            this.brownUpLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(148, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 27);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Diffusion";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // leftMintLabel
            // 
            this.leftMintLabel.AutoSize = true;
            this.leftMintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftMintLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.leftMintLabel.Location = new System.Drawing.Point(3, 122);
            this.leftMintLabel.Name = "leftMintLabel";
            this.leftMintLabel.Size = new System.Drawing.Size(15, 16);
            this.leftMintLabel.TabIndex = 1;
            this.leftMintLabel.Text = "0";
            this.leftMintLabel.Visible = false;
            // 
            // brownLeftLabel
            // 
            this.brownLeftLabel.AutoSize = true;
            this.brownLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brownLeftLabel.ForeColor = System.Drawing.Color.Sienna;
            this.brownLeftLabel.Location = new System.Drawing.Point(3, 140);
            this.brownLeftLabel.Name = "brownLeftLabel";
            this.brownLeftLabel.Size = new System.Drawing.Size(15, 16);
            this.brownLeftLabel.TabIndex = 2;
            this.brownLeftLabel.Text = "0";
            this.brownLeftLabel.Visible = false;
            // 
            // upMintLabel
            // 
            this.upMintLabel.AutoSize = true;
            this.upMintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upMintLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.upMintLabel.Location = new System.Drawing.Point(127, 9);
            this.upMintLabel.Name = "upMintLabel";
            this.upMintLabel.Size = new System.Drawing.Size(15, 16);
            this.upMintLabel.TabIndex = 3;
            this.upMintLabel.Text = "0";
            this.upMintLabel.Visible = false;
            // 
            // rightMintLabel
            // 
            this.rightMintLabel.AutoSize = true;
            this.rightMintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightMintLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.rightMintLabel.Location = new System.Drawing.Point(244, 140);
            this.rightMintLabel.Name = "rightMintLabel";
            this.rightMintLabel.Size = new System.Drawing.Size(15, 16);
            this.rightMintLabel.TabIndex = 4;
            this.rightMintLabel.Text = "0";
            this.rightMintLabel.Visible = false;
            // 
            // downMintLabel
            // 
            this.downMintLabel.AutoSize = true;
            this.downMintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downMintLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.downMintLabel.Location = new System.Drawing.Point(106, 282);
            this.downMintLabel.Name = "downMintLabel";
            this.downMintLabel.Size = new System.Drawing.Size(15, 16);
            this.downMintLabel.TabIndex = 5;
            this.downMintLabel.Text = "0";
            this.downMintLabel.Visible = false;
            // 
            // brownDownLabel
            // 
            this.brownDownLabel.AutoSize = true;
            this.brownDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brownDownLabel.ForeColor = System.Drawing.Color.Sienna;
            this.brownDownLabel.Location = new System.Drawing.Point(127, 282);
            this.brownDownLabel.Name = "brownDownLabel";
            this.brownDownLabel.Size = new System.Drawing.Size(15, 16);
            this.brownDownLabel.TabIndex = 6;
            this.brownDownLabel.Text = "0";
            this.brownDownLabel.Visible = false;
            // 
            // brownRightLabel
            // 
            this.brownRightLabel.AutoSize = true;
            this.brownRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brownRightLabel.ForeColor = System.Drawing.Color.Sienna;
            this.brownRightLabel.Location = new System.Drawing.Point(244, 122);
            this.brownRightLabel.Name = "brownRightLabel";
            this.brownRightLabel.Size = new System.Drawing.Size(15, 16);
            this.brownRightLabel.TabIndex = 7;
            this.brownRightLabel.Text = "0";
            this.brownRightLabel.Visible = false;
            // 
            // brownUpLabel
            // 
            this.brownUpLabel.AutoSize = true;
            this.brownUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brownUpLabel.ForeColor = System.Drawing.Color.Sienna;
            this.brownUpLabel.Location = new System.Drawing.Point(106, 9);
            this.brownUpLabel.Name = "brownUpLabel";
            this.brownUpLabel.Size = new System.Drawing.Size(15, 16);
            this.brownUpLabel.TabIndex = 8;
            this.brownUpLabel.Text = "0";
            this.brownUpLabel.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(148, 45);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(53, 25);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.Location = new System.Drawing.Point(207, 45);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(53, 25);
            this.rulesButton.TabIndex = 10;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(149, 76);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(111, 27);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(271, 297);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.brownUpLabel);
            this.Controls.Add(this.brownRightLabel);
            this.Controls.Add(this.brownDownLabel);
            this.Controls.Add(this.downMintLabel);
            this.Controls.Add(this.rightMintLabel);
            this.Controls.Add(this.upMintLabel);
            this.Controls.Add(this.brownLeftLabel);
            this.Controls.Add(this.leftMintLabel);
            this.Controls.Add(this.startButton);
            this.Name = "MainForm";
            this.Text = "Diffusion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label leftMintLabel;
        private System.Windows.Forms.Label brownLeftLabel;
        private System.Windows.Forms.Label upMintLabel;
        private System.Windows.Forms.Label rightMintLabel;
        private System.Windows.Forms.Label downMintLabel;
        private System.Windows.Forms.Label brownDownLabel;
        private System.Windows.Forms.Label brownRightLabel;
        private System.Windows.Forms.Label brownUpLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button continueButton;
    }
}

