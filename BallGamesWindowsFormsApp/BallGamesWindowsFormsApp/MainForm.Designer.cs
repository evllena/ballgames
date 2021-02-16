namespace BallGamesWindowsFormsApp
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
            this.createBallButton = new System.Windows.Forms.Button();
            this.catchBallsButton = new System.Windows.Forms.Button();
            this.countBallsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundsLeftLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBallButton
            // 
            this.createBallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createBallButton.Location = new System.Drawing.Point(329, 27);
            this.createBallButton.Name = "createBallButton";
            this.createBallButton.Size = new System.Drawing.Size(89, 33);
            this.createBallButton.TabIndex = 0;
            this.createBallButton.Text = "Create balls";
            this.createBallButton.UseVisualStyleBackColor = true;
            this.createBallButton.Click += new System.EventHandler(this.createBallButton_Click);
            // 
            // catchBallsButton
            // 
            this.catchBallsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catchBallsButton.Location = new System.Drawing.Point(329, 66);
            this.catchBallsButton.Name = "catchBallsButton";
            this.catchBallsButton.Size = new System.Drawing.Size(89, 34);
            this.catchBallsButton.TabIndex = 1;
            this.catchBallsButton.Text = "Catch balls";
            this.catchBallsButton.UseVisualStyleBackColor = true;
            this.catchBallsButton.Click += new System.EventHandler(this.catchBallsButton_Click);
            // 
            // countBallsLabel
            // 
            this.countBallsLabel.AutoSize = true;
            this.countBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBallsLabel.Location = new System.Drawing.Point(68, 32);
            this.countBallsLabel.Name = "countBallsLabel";
            this.countBallsLabel.Size = new System.Drawing.Size(14, 15);
            this.countBallsLabel.TabIndex = 2;
            this.countBallsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rounds left:";
            // 
            // roundsLeftLabel
            // 
            this.roundsLeftLabel.AutoSize = true;
            this.roundsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundsLeftLabel.Location = new System.Drawing.Point(171, 32);
            this.roundsLeftLabel.Name = "roundsLeftLabel";
            this.roundsLeftLabel.Size = new System.Drawing.Size(21, 15);
            this.roundsLeftLabel.TabIndex = 5;
            this.roundsLeftLabel.Text = "10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(418, 300);
            this.Controls.Add(this.roundsLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countBallsLabel);
            this.Controls.Add(this.catchBallsButton);
            this.Controls.Add(this.createBallButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BallGames";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBallButton;
        private System.Windows.Forms.Button catchBallsButton;
        private System.Windows.Forms.Label countBallsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roundsLeftLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

