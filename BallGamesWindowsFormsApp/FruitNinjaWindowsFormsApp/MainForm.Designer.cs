namespace FruitNinjaWindowsFormsApp
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(184, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(16, 18);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // rulesButton
            // 
            this.rulesButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesButton.Location = new System.Drawing.Point(225, 1);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(94, 34);
            this.rulesButton.TabIndex = 2;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Name = "MainForm";
            this.Text = "FruitNinja";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rulesButton;
    }
}

