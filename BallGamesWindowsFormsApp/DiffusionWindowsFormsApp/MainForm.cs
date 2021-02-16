using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsCommon;

namespace DiffusionWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int countBalls = 6;
        List<DiffusionBrownBall> brownBalls;
        List<DiffusionMintBall> mintBalls;
        private Timer diffTimer;
        public MainForm()
        {
            InitializeComponent();
          
        }


        private void startButton_Click(object sender, EventArgs e)
        { mintBalls = new List<DiffusionMintBall>();
            brownBalls = new List<DiffusionBrownBall>();

            for (int i = 0; i < countBalls; i++)
            {
                var mintBall = new DiffusionMintBall(this);
                mintBalls.Add(mintBall);
                var brownBall = new DiffusionBrownBall(this);
                brownBalls.Add(brownBall);
                mintBall.Start();
                mintBall.OnHited += MintBall_OnHited;
                brownBall.Start();
                brownBall.OnHited += BrownBall_OnHited;

            }
            diffTimer = new Timer();
            diffTimer.Interval = 60;
            diffTimer.Start();
            diffTimer.Tick += DiffTimer_Tick;
        }

        private void BrownBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    brownLeftLabel.Text = (Convert.ToInt32(brownLeftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    brownRightLabel.Text = (Convert.ToInt32(brownRightLabel.Text) + 1).ToString();
                    break;
                case Side.Up:
                    brownUpLabel.Text = (Convert.ToInt32(brownUpLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    brownDownLabel.Text = (Convert.ToInt32(brownDownLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void MintBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftMintLabel.Text = (Convert.ToInt32(leftMintLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                   rightMintLabel.Text = (Convert.ToInt32(rightMintLabel.Text) + 1).ToString();
                    break;
                case Side.Up:
                    upMintLabel.Text = (Convert.ToInt32(upMintLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downMintLabel.Text = (Convert.ToInt32(downMintLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void DiffTimer_Tick(object sender, EventArgs e)
        { int countMintX = 0;
            int countBrownX = 0;
            int countMintY = 0;
            int countBrownY = 0;


            for (int i = 0; i < brownBalls.Count; i++)
            {
                if (brownBalls[i].OnLeft())
                {
                    countBrownX++;
                }
                if (mintBalls[i].OnLeft())
                {
                    countMintX++;
                }
            }

            for (int i = 0; i < countBalls; i++)
            {
                if (brownBalls[i].OnTop())
                {
                    countBrownY++;
                }
                if (mintBalls[i].OnTop())
                {
                    countMintY++;
                }
            }

            if (countBrownX == countMintX && countBrownY == countMintY && countBrownX== countBalls / 2 && countBrownY == countBalls / 2)
            {
                for (int i = 0; i < countBalls; i++)
                {
                    mintBalls[i].Stop();
                    brownBalls[i].Stop();
                }
                diffTimer.Stop();
            }   
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Pause();
        }

        private void LabelsShow()
        {
            upMintLabel.Visible = true;
            downMintLabel.Visible = true;
            leftMintLabel.Visible = true;
            rightMintLabel.Visible = true;
            brownLeftLabel.Visible = true;
            brownDownLabel.Visible = true;
            brownRightLabel.Visible = true;
            brownUpLabel.Visible = true;
        }

        private void LabelsHide()
        {
            upMintLabel.Visible = false;
            downMintLabel.Visible = false;
            leftMintLabel.Visible = false;
            rightMintLabel.Visible = false;
            brownLeftLabel.Visible = false;
            brownDownLabel.Visible = false;
            brownRightLabel.Visible = false;
            brownUpLabel.Visible = false;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Unpause(); 
        }
        private void Pause()
        {
            for (int i = 0; i < countBalls; i++)
            {
                mintBalls[i].Stop();
                brownBalls[i].Stop();
            }
            diffTimer.Stop();
            LabelsShow();
        }

        private void Unpause()
        {
            for (int i = 0; i < countBalls; i++)
            {
                mintBalls[i].Start();
                brownBalls[i].Start();
            }
            diffTimer.Start();
            LabelsHide();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для начала нажмите кнопку Start diffusion. Чтобы посмотреть давление газов на стенки сосудов, нажмите и удерживайте левую кнопку мыши или нажмите Stop. Шарики перестанут двигаться, когда достигнут равновесного состояния, то есть соотношение шаров разного цвета сверху-снизу и слева-справа будет одинаковым.");
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Unpause();
        }
    }   
}
